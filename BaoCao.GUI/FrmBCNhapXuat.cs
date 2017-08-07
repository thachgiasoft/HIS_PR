using BaoCao.DAL;
using Core.DAL;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaoCao.GUI
{
    public partial class FrmBCNhapXuat : RibbonForm
    {
        System.Drawing.Font fontB = new System.Drawing.Font ("Tahoma", 8, System.Drawing.FontStyle.Bold);
        System.Drawing.Font font = new System.Drawing.Font ("Tahoma", 10);
        NhapXuatEntity nhapxuat;
        string txtThoiGian = "";
        DataTable data = null;
        DataRow[] drNhom = null;
        public FrmBCNhapXuat ()
        {
            InitializeComponent ();
            nhapxuat = new NhapXuatEntity ();
        }
        protected override void OnLoad (EventArgs e)
        {
            base.OnLoad (e);
            this.WindowState = FormWindowState.Maximized;
        }
        private void FrmBCNhapXuatThuoc_Load (object sender, EventArgs e)
        {
            dateTuNgay.DateTime = DateTime.Now;
            dateDenNgay.DateTime = DateTime.Now;

            cbThoiGian.SelectedIndex = 0;
            cbThang.SelectedIndex = DateTime.Now.Month - 1;
            cbNam.SelectedIndex = 0;
            cbQuy.SelectedIndex = DateTime.Now.Month / 4;

            layctrlNam.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            layctrlQuy.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            layctrlThang.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;

            this.cbNam.Properties.Items.Clear ();
            string[] nam = new string[30];
            int j = 0;
            for (int i = DateTime.Now.Year; i > DateTime.Now.Year - 30; i--)
            {
                nam[j] = i.ToString ();
                j++;
            }
            this.cbNam.Properties.Items.AddRange (nam);
            cbNam.SelectedIndex = 0;
            //
            lookUpLoaiVatTu.Properties.DataSource = nhapxuat.DSLoaiVatTu ();
            lookUpLoaiVatTu.Properties.DisplayMember = "Ten";
            lookUpLoaiVatTu.Properties.ValueMember = "Ma";
            lookUpLoaiVatTu.ItemIndex = 0;
        }

        private void cbThoiGian_SelectedIndexChanged (object sender, EventArgs e)
        {
            if (cbThoiGian.SelectedIndex != 0)
            {
                layctrlTuNgay.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                layctrlDenNgay.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                layctrlQuy.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                layctrlThang.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                layctrlNam.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                if (cbThoiGian.SelectedIndex == 1)
                {
                    layctrlThang.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                }
                if (cbThoiGian.SelectedIndex == 2)
                {
                    layctrlQuy.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                }
            }
            else
            {
                layctrlNam.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                layctrlQuy.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                layctrlThang.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;

                layctrlTuNgay.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                layctrlDenNgay.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            }
        }
        private int lastDay (int y, int m)
        {
            return DateTime.DaysInMonth (y, m);
        }
        private void btnXem_Click (object sender, EventArgs e)
        {
            DateTime ngayBD;
            DateTime ngayKT;
            if (cbThoiGian.SelectedIndex == 0)
            {
                ngayBD = dateTuNgay.DateTime;
                ngayKT = dateDenNgay.DateTime;
                txtThoiGian = "Từ ngày " + ngayBD.Day + "/" + ngayBD.Month + "/" + ngayBD.Year +
               " đến " + ngayKT.Day + "/" + ngayKT.Month + "/" + ngayKT.Year;
            }
            else
            if (cbThoiGian.SelectedIndex == 1)
            {
                ngayBD = DateTime.ParseExact ("01/"+ cbThang.SelectedItem+"/" + cbNam.SelectedItem, 
                    "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                ngayKT = DateTime.ParseExact (lastDay (Convert.ToInt32 (cbNam.SelectedItem), Convert.ToInt32 (cbThang.SelectedItem))+
                    "/" + cbThang.SelectedItem + "/" + cbNam.SelectedItem,
                    "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                txtThoiGian = "Tháng " + cbThang.SelectedItem + " năm " + cbNam.SelectedItem.ToString ();
            }
            else
            if (cbThoiGian.SelectedIndex == 2)
            {
                string thangDau = "01";
                string thangCuoi = "12";
                if (cbQuy.SelectedIndex == 0)
                {
                    thangDau = "01";
                    thangCuoi = "03";
                }
                else
                    if (cbQuy.SelectedIndex == 1)
                {
                    thangDau = "04";
                    thangCuoi = "06";
                }
                else
                    if (cbQuy.SelectedIndex == 2)
                {
                    thangDau = "07";
                    thangCuoi = "09";
                }
                else
                {
                    thangDau = "10";
                    thangCuoi = "12";
                }
                ngayBD = DateTime.ParseExact ("01/" + thangDau + "/" + cbNam.SelectedItem,
                    "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);

                ngayKT = DateTime.ParseExact (lastDay (Convert.ToInt32 (cbNam.SelectedItem), Convert.ToInt32 (thangCuoi))+
                    "/" + thangCuoi + "/" + cbNam.SelectedItem,
                    "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                txtThoiGian = "Quý " + (cbQuy.SelectedIndex + 1) + " năm " + cbNam.SelectedItem.ToString ();
            }
            else
            {
                ngayBD = DateTime.ParseExact ("01/01/" + cbNam.SelectedItem,
                    "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                ngayKT = DateTime.ParseExact (lastDay (Convert.ToInt32 (cbNam.SelectedItem), 12) +
                    "/12/" + cbNam.SelectedItem,
                    "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                txtThoiGian = "Năm " + cbNam.SelectedItem.ToString ();
            }
            //
            nhapxuat.LoaiVatTu = lookUpLoaiVatTu.EditValue.ToString ();
            nhapxuat.TuNgay = ngayBD;
            nhapxuat.DenNgay = ngayKT;
            if(checkTatCa.Checked)
            {
                nhapxuat.LoaiVatTu = null;
            }
            data  = nhapxuat.DSVatTu ();
            gridControl.DataSource = data;
        }

        private void btnIn_Click (object sender, EventArgs e)
        {
            inBaoCao ();
        }
        private void inBaoCao()
        {
            RptBaoCaoNhapXuat rpt = new RptBaoCaoNhapXuat ();
            rpt.lblThoiGian.Text = txtThoiGian;
            rpt.lblNgayLap.Text = "Ngày " + DateTime.Now.Day + " tháng " + DateTime.Now.Month + " năm " + DateTime.Now.Year;

            rpt.xrTable.Rows.Clear ();
            if (data != null && data.Rows.Count > 0)
            {
                drNhom = null;
                int stt = 0;
                if (checkTatCa.Checked)
                {
                    foreach (DataRow lvt in (lookUpLoaiVatTu.Properties.DataSource as DataTable).Rows)
                    {
                        drNhom = data.Select ("LoaiVatTu = '" + lvt[0].ToString () + "'");
                        if (drNhom.Length > 0)
                        {
                            taoBangVatTu (rpt, drNhom.CopyToDataTable (), "156" + lvt[0], stt);
                        }
                    }
                }
                else
                {
                    taoBangVatTu (rpt, data, "156" + lookUpLoaiVatTu.EditValue, stt);
                }
                XRTableRow row = new XRTableRow ();

                XRTableCell cell;

                cell = new XRTableCell ();
                cell.WidthF = 348;
                cell.Borders = ((DevExpress.XtraPrinting.BorderSide) ((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
            | DevExpress.XtraPrinting.BorderSide.Bottom))));
                row.Cells.Add (cell);

                cell = new XRTableCell ();
                cell.Text = "Tổng cả bảng";
                cell.Font = fontB;
                cell.Borders = ((DevExpress.XtraPrinting.BorderSide) (((( DevExpress.XtraPrinting.BorderSide.Top)
            | DevExpress.XtraPrinting.BorderSide.Right)
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
                cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
                cell.WidthF = 120;
                row.Cells.Add (cell);

                cell = new XRTableCell ();
                cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
                cell.WidthF = 70;
                row.Cells.Add (cell);

                cell = new XRTableCell ();
                cell.Text = Utils.ToString (data.Compute ("SUM(GiaTriTonDK)", "").ToString ());
                cell.Font = fontB;
                cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
                cell.WidthF = 90;
                row.Cells.Add (cell);

                cell = new XRTableCell ();
                cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
                cell.WidthF = 70;
                row.Cells.Add (cell);

                cell = new XRTableCell ();
                cell.Text = Utils.ToString (data.Compute ("SUM(GiaTriNhap)", "").ToString ());
                cell.Font = fontB;
                cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
                cell.WidthF = 90;
                row.Cells.Add (cell);

                cell = new XRTableCell ();
                cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
                cell.WidthF = 70;
                row.Cells.Add (cell);

                cell = new XRTableCell ();
                cell.Text = Utils.ToString (data.Compute ("SUM(GiaTriXuat)", "").ToString ());
                cell.Font = fontB;
                cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
                cell.WidthF = 90;
                row.Cells.Add (cell);

                cell = new XRTableCell ();
                cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
                cell.WidthF = 70;
                row.Cells.Add (cell);

                cell = new XRTableCell ();
                cell.Text = Utils.ToString (data.Compute ("SUM(GiaTriTon)", "").ToString ());
                cell.Font = fontB;
                cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
                cell.WidthF = 90;
                row.Cells.Add (cell);

                rpt.xrTable.Rows.Add (row);

                rpt.lblGiaTriCuoiKy.Text = Utils.ToString (data.Compute ("SUM(GiaTriTon)", "").ToString ());
                rpt.lblGiaTriDauKy.Text = Utils.ToString (data.Compute ("SUM(GiaTriTonDK)", "").ToString ());
                rpt.lblGiaTriNhap.Text = Utils.ToString (data.Compute ("SUM(GiaTriNhap)", "").ToString ());
                rpt.lblGiaTriXuat.Text = Utils.ToString (data.Compute ("SUM(GiaTriXuat)", "").ToString ());
            }
            rpt.CreateDocument ();
            rpt.ShowPreviewDialog ();
        }
        private void taoBangVatTu(RptBaoCaoNhapXuat rpt,DataTable dt, string loaiVatTu, int stt)
        {
            XRTableRow row;
            XRTableCell cell;
            for(int i = 0;i<dt.Rows.Count;i++)
            {
                stt++;
                row = new XRTableRow ();

                cell = new XRTableCell ();
                cell.Text = stt.ToString();
                cell.Font = font;
                cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
                cell.WidthF = 30;
                row.Cells.Add (cell);

                cell = new XRTableCell ();
                cell.Text = dt.Rows[i]["MaBV"].ToString ();
                cell.Font = font;
                cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
                cell.WidthF = 80;
                row.Cells.Add (cell);

                cell = new XRTableCell ();
                cell.Text = dt.Rows[i]["TenVatTu"].ToString();
                cell.Font = font;
                cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
                cell.WidthF = 238;
                row.Cells.Add (cell);

                cell = new XRTableCell ();
                cell.Text = dt.Rows[i]["DonViTinh"].ToString ();
                cell.Font = font;
                cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
                cell.WidthF = 40;
                row.Cells.Add (cell);

                cell = new XRTableCell ();
                cell.Text = Utils.ToString(dt.Rows[i]["DonGia"].ToString ());
                cell.Font = font;
                cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
                cell.WidthF = 80;
                row.Cells.Add (cell);

                cell = new XRTableCell ();
                cell.Text = Utils.ToString (dt.Rows[i]["SoLuongTonDK"].ToString ());
                cell.Font = font;
                cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
                cell.WidthF = 70;
                row.Cells.Add (cell);

                cell = new XRTableCell ();
                cell.Text = Utils.ToString(dt.Rows[i]["GiaTriTonDK"].ToString ());
                cell.Font = font;
                cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
                cell.WidthF = 90;
                row.Cells.Add (cell);

                cell = new XRTableCell ();
                cell.Text = Utils.ToString (dt.Rows[i]["SoLuongNhap"].ToString ());
                cell.Font = font;
                cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
                cell.WidthF = 70;
                row.Cells.Add (cell);

                cell = new XRTableCell ();
                cell.Text = Utils.ToString (dt.Rows[i]["GiaTriNhap"].ToString ());
                cell.Font = font;
                cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
                cell.WidthF = 90;
                row.Cells.Add (cell);

                cell = new XRTableCell ();
                cell.Text = Utils.ToString (dt.Rows[i]["SoLuongXuat"].ToString ());
                cell.Font = font;
                cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
                cell.WidthF = 70;
                row.Cells.Add (cell);

                cell = new XRTableCell ();
                cell.Text = Utils.ToString (dt.Rows[i]["GiaTriXuat"].ToString ());
                cell.Font = font;
                cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
                cell.WidthF = 90;
                row.Cells.Add (cell);

                cell = new XRTableCell ();
                cell.Text = Utils.ToString (dt.Rows[i]["SoLuongTon"].ToString ());
                cell.Font = font;
                cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
                cell.WidthF = 70;
                row.Cells.Add (cell);

                cell = new XRTableCell ();
                cell.Text = Utils.ToString (dt.Rows[i]["GiaTriTon"].ToString ());
                cell.Font = font;
                cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
                cell.WidthF = 90;
                row.Cells.Add (cell);

                rpt.xrTable.Rows.Add (row);
            }
            row = new XRTableRow ();

            cell = new XRTableCell ();

            cell = new XRTableCell ();
            cell.WidthF = 110;
            cell.Borders = ((DevExpress.XtraPrinting.BorderSide) ((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
            | DevExpress.XtraPrinting.BorderSide.Bottom))));
            row.Cells.Add (cell);

            cell = new XRTableCell ();
            cell.Text = "Tổng cộng tài khoản: " + loaiVatTu;
            cell.Font = fontB;
            cell.Borders = ((DevExpress.XtraPrinting.BorderSide) ((((DevExpress.XtraPrinting.BorderSide.Top)
            | DevExpress.XtraPrinting.BorderSide.Right)
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            cell.WidthF = 358;
            row.Cells.Add (cell);

            cell = new XRTableCell ();
            cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            cell.WidthF = 70;
            row.Cells.Add (cell);

            cell = new XRTableCell ();
            cell.Text = Utils.ToString (data.Compute("SUM(GiaTriTonDK)","").ToString ());
            cell.Font = fontB;
            cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            cell.WidthF = 90;
            row.Cells.Add (cell);

            cell = new XRTableCell ();
            cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            cell.WidthF = 70;
            row.Cells.Add (cell);

            cell = new XRTableCell ();
            cell.Text = Utils.ToString (data.Compute ("SUM(GiaTriNhap)", "").ToString ());
            cell.Font = fontB;
            cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            cell.WidthF = 90;
            row.Cells.Add (cell);

            cell = new XRTableCell ();
            cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            cell.WidthF = 70;
            row.Cells.Add (cell);

            cell = new XRTableCell ();
            cell.Text = Utils.ToString (data.Compute ("SUM(GiaTriXuat)", "").ToString ());
            cell.Font = fontB;
            cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            cell.WidthF = 90;
            row.Cells.Add (cell);

            cell = new XRTableCell ();
            cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            cell.WidthF = 70;
            row.Cells.Add (cell);

            cell = new XRTableCell ();
            cell.Text = Utils.ToString (data.Compute ("SUM(GiaTriTon)", "").ToString ());
            cell.Font = fontB;
            cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            cell.WidthF = 90;
            row.Cells.Add (cell);

            rpt.xrTable.Rows.Add (row);
        }
    }
}
