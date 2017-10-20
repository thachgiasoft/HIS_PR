using Core.DAL;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using DuocPham.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuocPham.GUI
{
    public partial class FrmYeuCauLinhThuoc : RibbonForm
    {
        LinhThuocEntity linhthuoc;
        bool them = false;
        string quyen = "";
        CultureInfo elGR = CultureInfo.CreateSpecificCulture ("el-GR");
        System.Drawing.Font fontB = new System.Drawing.Font ("Times New Roman", 11, System.Drawing.FontStyle.Bold);
        System.Drawing.Font font = new System.Drawing.Font ("Times New Roman", 11);
        public FrmYeuCauLinhThuoc ()
        {
            InitializeComponent ();
            linhthuoc = new LinhThuocEntity ();
        }
        protected override void OnLoad (EventArgs e)
        {
            base.OnLoad (e);
            this.WindowState = FormWindowState.Maximized;
        }
        private void FrmYeuCauLinhThuoc_Load (object sender, EventArgs e)
        {
            if(linhthuoc.LayKhoXuat())
            {
                txtKhoXuat.Text = linhthuoc.TenKhoXuat;
            }
            if(linhthuoc.LayKhoNhan())
            {
                txtKhoNhan.Text = linhthuoc.TenKhoNhan;
            }
            lookUpLoaiVatTu.Properties.DataSource = linhthuoc.DSLoaiVatTu ();
            lookUpLoaiVatTu.Properties.DisplayMember = "Ten";
            lookUpLoaiVatTu.Properties.ValueMember = "Ma";
            lookUpMaVatTu.Properties.DisplayMember = "TenVatTu";

            checkButton ();
            LoadData ();
            btnIn.Enabled = false;
        }
        private void LoadData()
        {
            gridControlPhieu.DataSource = linhthuoc.DSPhieu ();
            them = false;
            btnLuu.Enabled = false;
        }
        private void checkButton ()
        {
            quyen = Utils.GetQuyen (this.Name);
            Enabled_Them ();
            btnLuu.Enabled = false;

        }
        private void Enabled_Luu ()
        {
            if (quyen.IndexOf ('2') >= 0 || them)
            {
                btnLuu.Enabled = true;
            }
            else
            {
                btnLuu.Enabled = false;
            }
        }
        private void Enabled_Them ()
        {
            if (quyen.IndexOf ('1') >= 0)
            {
                btnThem.Enabled = true;
            }
            else
            {
                btnThem.Enabled = false;
            }
        }
        private void lookUpLoaiVatTu_EditValueChanged (object sender, EventArgs e)
        {
            lookUpMaVatTu.Properties.DataSource = linhthuoc.DSVatTu (lookUpLoaiVatTu.EditValue.ToString());
        }

        private void btnThem_Click (object sender, EventArgs e)
        {
            them = true;
            txtSoLuong.Text = "";

            linhthuoc.SoPhieu = 0;
            linhthuoc.NgayXuat = DateTime.Now;
            linhthuoc.NgayCapNhat = DateTime.Now;
            linhthuoc.PheDuyet = false;
            linhthuoc.NguoiNhan = linhthuoc.LayNguoiNhan ();
            linhthuoc.NoiDung = "Khoa yêu cầu phát thuốc.";

            gridControlDS.DataSource = linhthuoc.DSPhieuVatTu ().AsDataView ();

            lookUpMaVatTu.Focus ();
            Enabled_Luu ();
            btnIn.Enabled = false;
        }

        private void btnLuu_Click (object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty (linhthuoc.KhoNhan))
            {
                XtraMessageBox.Show ("Không tìm thấy kho nhận thuốc!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if ((gridControlDS.DataSource as DataView).Count == 0)
            {
                XtraMessageBox.Show ("Nhập vật tư!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lookUpMaVatTu.Focus ();
                return;
            }       
            linhthuoc.TKCo = "156" + lookUpLoaiVatTu.EditValue;
            string err = "";
            DialogResult traloi;
            traloi = XtraMessageBox.Show ("Chắc chắn bạn muốn lưu, những thông tin này sẽ không được chỉnh sửa?", "Trả lời",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
            {
                if (them)
                {
                    linhthuoc.NguoiTao = AppConfig.MaNV;
                    if (linhthuoc.SpThemPhieuXuat (ref err))
                    {
                        LuuVatTu ();
                        LoadData ();
                    }
                }
                else
                {
                    linhthuoc.NguoiCapNhat = AppConfig.MaNV;
                }
                if (!string.IsNullOrEmpty (err))
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show (err, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                btnIn.Enabled = true;
            }
        }

        private void btnIn_Click (object sender, EventArgs e)
        {
            inPhieuLinh ();
        }
        private void LuuVatTu ()
        {
            DataView dv = (gridControlDS.DataSource as DataView);
            string err = "";
            foreach (DataRowView drv in dv)
            {
                err = "";
                linhthuoc.SoPhieuNhap = int.Parse (drv["SoPhieuNhap"].ToString ());
                linhthuoc.MaVatTu = drv["MaVatTu"].ToString ();
                linhthuoc.SoDangKy = drv["SoDangKy"].ToString ();
                linhthuoc.SoLuong = int.Parse (drv["SoLuong"].ToString ());
                linhthuoc.SoLuongDung = 0;
                linhthuoc.DonGiaBHYT = decimal.Parse (drv["DonGiaBHYT"].ToString ());
                linhthuoc.DonGiaBV = decimal.Parse (drv["DonGiaBV"].ToString ());
                linhthuoc.HetHan = DateTime.Parse (drv["HetHan"].ToString ());
                linhthuoc.ThanhTien = decimal.Parse (drv["ThanhTien"].ToString ());
                linhthuoc.LoaiVatTu = drv["LoaiVatTu"].ToString ();
                if (them)
                {
                    linhthuoc.SpThemPhieuNhapChiTiet (ref err);
                }
                if (!string.IsNullOrEmpty (err))
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show (err, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtSoLuong_KeyPress (object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (txtSoLuong.Text.Length == 0 || txtSoLuong.Text == "0")
                {
                    XtraMessageBox.Show ("Nhập số lượng!");
                    txtSoLuong.Focus ();
                    e.Handled = true;
                }
                if (gridControlDS.DataSource is DataView && btnLuu.Enabled)
                {
                    DataRowView drview = (lookUpMaVatTu.GetSelectedDataRow () as DataRowView);
                    DataRow[] drv = (gridViewDS.DataSource as DataView).Table.Select ("MaVatTu = '" + drview["MaVatTu"].ToString ()
                        + "' and SoPhieuNhap = '" + drview["SoPhieu"].ToString () + "'");
                    if (drv.Length != 0)
                    {
                        XtraMessageBox.Show ("Vật tư đã được chọn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (Utils.ToInt (txtSoLuong.Text) > Utils.ToInt (drview["SoLuongTon"].ToString ()))
                    {
                        XtraMessageBox.Show ("Số lượng tồn kho không đủ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    DataRowView dr = (gridControlDS.DataSource as DataView).AddNew ();
                    dr["SoPhieuNhap"] = drview["SoPhieu"].ToString ();
                    dr["MaVatTu"] = drview["MaVatTu"].ToString ();
                    dr["TenVatTu"] = drview["TenVatTu"].ToString ();
                    dr["SoDangKy"] = drview["SoDangKy"].ToString ();
                    dr["SoLuong"] = Utils.ToInt(txtSoLuong.Text);
                    dr["SoLuongDung"] = 0;
                    dr["DonGiaBHYT"] = drview["DonGiaBHYT"].ToString ();
                    dr["DonGiaBV"] = drview["DonGiaBV"].ToString ();
                    dr["HetHan"] = drview["HetHan"].ToString ();
                    dr["ThanhTien"] = Convert.ToDecimal (txtSoLuong.Text) * Convert.ToDecimal (drview["DonGiaBHYT"].ToString ());
                    dr["LoaiVatTu"] = drview["LoaiVatTu"].ToString ();
                    dr["DonViTinh"] = drview["DonViTinh"].ToString ();

                    txtSoLuong.Text = "";
                }
            }
        }

        private void btnXoa_ButtonClick (object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (them)
            {
                (gridControlDS.DataSource as DataView).Delete (gridViewDS.GetFocusedDataSourceRowIndex ());
            }
        }

        private void gridViewPhieu_RowClick (object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            DataRow dr = gridViewPhieu.GetDataRow (e.RowHandle);
            if (dr != null)
            {
                linhthuoc.SoPhieu = int.Parse(dr["SoPhieu"].ToString ());
                linhthuoc.TKCo = dr["TKCo"].ToString ();
                linhthuoc.NgayXuat =DateTime.Parse( dr["NgayXuat"].ToString ());
                linhthuoc.KhoNhan = dr["KhoNhan"].ToString ();
                linhthuoc.KhoXuat = dr["khoXuat"].ToString ();
                linhthuoc.NguoiNhan = dr["NguoiNhan"].ToString ();
                linhthuoc.NoiDung = dr["NoiDung"].ToString ();

                them = false;
                Enabled_Luu ();

                btnIn.Enabled = true;
                // danh sách
                lookUpMaVatTu.Properties.DataSource = linhthuoc.DSVatTu (linhthuoc.TKCo.Substring (3, 1));
                gridControlDS.DataSource = linhthuoc.DSPhieuVatTu ().AsDataView ();
            }
        }
        private void inPhieuLinh ()
        {
            RptPhieuLinhThuoc rpt = new RptPhieuLinhThuoc ();
            rpt.lblSoPhieu.Text = linhthuoc.SoPhieu.ToString();
            rpt.lblNgayXuat.Text = "Ngày " + linhthuoc.NgayXuat.Day + " tháng "
                + linhthuoc.NgayXuat.Month + " năm " + linhthuoc.NgayXuat.Year;
            rpt.lblKhoaNhan.Text = linhthuoc.TenKhoNhan;
           rpt.lblNgayIn.Text = "Ngày " + DateTime.Now.Day + " tháng " + DateTime.Now.Month + " năm " + DateTime.Now.Year;
            DataRow drow = linhthuoc.MauPhieu();
            if (drow != null)
            {
                rpt.lblPhieuLinh.Text = "PHIẾU LĨNH " + drow["Ten"].ToString().ToUpper();
                rpt.lblMauSo.Text = "MS: " + drow["Mau"] + "/BV01";
            }
            XRTableRow row;
            XRTableCell cell;
            int stt = 0;
            decimal soluong = 0;
            foreach (DataRowView drview in (gridViewDS.DataSource as DataView))
            {
                row = new XRTableRow ();

                cell = new XRTableCell ();
                cell.Text = stt.ToString ();
                cell.Font = font;
                cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
                cell.WidthF = 40;
                row.Cells.Add (cell);

                cell = new XRTableCell ();
                cell.Text = drview["MaVatTu"].ToString ();
                cell.Font = font;
                cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
                cell.WidthF = 80;
                row.Cells.Add (cell);

                cell = new XRTableCell ();
                cell.Text = drview["TenVatTu"].ToString ();
                cell.Font = font;
                cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
                cell.WidthF = 348;
                row.Cells.Add (cell);

                cell = new XRTableCell ();
                cell.Text = drview["DonViTinh"].ToString ();
                cell.Font = font;
                cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
                cell.WidthF = 50;
                row.Cells.Add (cell);

                decimal sl = Utils.ToDecimal (drview["SoLuong"].ToString ());
                soluong += sl;
                cell = new XRTableCell ();
                cell.Text = sl.ToString ("0,0", elGR);
                cell.Font = font;
                cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
                cell.WidthF = 70;
                row.Cells.Add (cell);

                cell = new XRTableCell ();
                cell.Text = sl.ToString ("0,0", elGR);
                cell.Font = font;
                cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
                cell.WidthF = 70;
                row.Cells.Add (cell);

                cell = new XRTableCell ();
                cell.Text = "";
                cell.Font = font;
                cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
                cell.WidthF = 108;
                row.Cells.Add (cell);

                stt++;
                rpt.xrTable.Rows.Add (row);
            }
            row = new XRTableRow ();
   
            cell = new XRTableCell ();
            cell.Text = "";
            cell.Font = font;
            cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            cell.WidthF = 40;
            row.Cells.Add (cell);

            cell = new XRTableCell ();
            cell.Text = "";
            cell.Font = font;
            cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            cell.WidthF = 80;
            row.Cells.Add (cell);

            cell = new XRTableCell ();
            cell.Text = "Cộng khoản:";
            cell.Font = fontB;
            cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            cell.WidthF = 348;
            row.Cells.Add (cell);

            cell = new XRTableCell ();
            cell.Text = "";
            cell.Font = font;
            cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            cell.WidthF = 50;
            row.Cells.Add (cell);

            cell = new XRTableCell ();
            cell.Text = soluong.ToString ("0,0", elGR);
            cell.Font = fontB;
            cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            cell.WidthF = 70;
            row.Cells.Add (cell);

            cell = new XRTableCell ();
            cell.Text = soluong.ToString ("0,0", elGR);
            cell.Font = fontB;
            cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            cell.WidthF = 70;
            row.Cells.Add (cell);

            cell = new XRTableCell ();
            cell.Text = "";
            cell.Font = font;
            cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            cell.WidthF = 108;
            row.Cells.Add (cell);

            rpt.xrTable.Rows.Add (row);

            rpt.CreateDocument ();
            rpt.ShowPreviewDialog ();
        }
    }
}
