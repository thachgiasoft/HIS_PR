using Core.DAL;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using KhamBenh.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TiepNhan.GUI
{
    public partial class FrmGiuongBenh : RibbonForm
    {
        HoSoEntity hoso;
        DataView dvGiuongBenh;
        Dictionary<string, int> listGiuong;
        List<string> loaiGiuong = new List<string> { "H", "T", "C", "K" };
        public FrmGiuongBenh()
        {
            InitializeComponent();
            hoso = new HoSoEntity();
            lookUpGiuong.Properties.DataSource = hoso.DSGiuong();
            lookUpGiuong.Properties.DisplayMember = "Ten";
        }
        public string MaLK { get; set; }
        public string MaKhoa { get; set; }
        public string MaBacSi { get; set; }

        private void FrmGiuongBenh_Load(object sender, EventArgs e)
        {
            hoso.MaLK = this.MaLK;
            //
            dateNgayYLenh.DateTime = DateTime.Now;
            txtSoGiuong.Text = "001";
            cbLoaiGiuong.SelectedIndex = 0;
            this.ActiveControl = lookUpGiuong;
            // lấy ds giường bệnh
            dvGiuongBenh = hoso.DSDichVuGiuongBenh().AsDataView();
            gridControl.DataSource = dvGiuongBenh;
            listGiuong = new Dictionary<string, int>();
            foreach(DataRowView drv in dvGiuongBenh)
            {
                listGiuong.Add(drv["MaDichVu"].ToString(), 1);
            }
        }

        private void lookUpGiuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                txtSoNgay.Focus();
        }

        private void txtSoNgay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                cbLoaiGiuong.Focus();
        }

        private void cbLoaiGiuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                txtSoGiuong.Focus();
        }

        private void txtSoGiuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                btnChon.Focus();
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            if (lookUpGiuong.EditValue is DataRowView)
            {
                DataRowView dr = (lookUpGiuong.EditValue as DataRowView);
                string maDichVu = dr["Ma"].ToString();
                if (listGiuong.ContainsKey(maDichVu) && listGiuong[maDichVu] > 0)
                {
                    if (listGiuong[maDichVu] > 0)
                    {
                        // đã có và 1 hoặc 2
                        XtraMessageBox.Show(Library.DichVuDaDuocChon, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        lookUpGiuong.Focus();
                    }
                    else//listGiuong[maDichVu] == 0
                    {
                        listGiuong[maDichVu] = 1;// đã có và đánh dấu 0. xóa, cập nhật lại
                    }
                }
                else
                {
                    listGiuong.Add(maDichVu, 2);// 2. thêm mới
                }
                DataRowView drvNew = (gridControl.DataSource as DataView).AddNew();
                drvNew["MaDichVu"] = maDichVu;
                drvNew["TenDichVu"] = dr["Ten"];
                drvNew["SoLuong"] = txtSoNgay.Value;
                drvNew["DonGia"] = dr["DonGia"];
                drvNew["ThanhTien"] = txtSoNgay.Value * Utils.ToDecimal(dr["DonGia"]);
                drvNew["NgayKQ"] = DateTime.Now;
                drvNew["NgayYLenh"] = DateTime.Now;
                drvNew["MaKhoa"] = this.MaKhoa;
                drvNew["MaGiuong"] = loaiGiuong[cbLoaiGiuong.SelectedIndex] + txtSoGiuong.Text;
                drvNew["MaBacSi"] = this.MaBacSi;
                drvNew["DonViTinh"] = "Ngày";
                drvNew.EndEdit();
                lookUpGiuong.Focus();
            }
        }

        private void txtSoNgay_Enter(object sender, EventArgs e)
        {
            txtSoNgay.Select(0, txtSoNgay.Value.ToString().Length);
        }

        private void repbtnXoa_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int index = gridView.GetFocusedDataSourceRowIndex();
            if (index > -1)
            {
                // 0. xóa
                string key = dvGiuongBenh.ToTable().Rows[index]["MaDichVu"].ToString();
                if (listGiuong[key] == 1)
                    listGiuong[key] = 0;
                else
                    listGiuong.Remove(key);
                (gridControl.DataSource as DataView).Delete(index);
            }
        }

        private void gridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.Name == "SoLuong")
            {
                this.gridView.CellValueChanged -= new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView_CellValueChanged);
                var dongia = gridView.GetRowCellValue(e.RowHandle, gridView.Columns["DonGia"]);
                gridView.SetFocusedRowCellValue("ThanhTien", Utils.ToInt(e.Value) * Utils.ToDecimal(dongia));
                this.gridView.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView_CellValueChanged);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string err = "";
            hoso.MaLK = this.MaLK;
            List<string> keys = new List<string>(listGiuong.Keys);
            foreach (string key in keys)
            {
                if (listGiuong[key] == 0)
                {
                    // xóa
                    err = "";
                    hoso.MaDichVu = key;
                    hoso.NgayKQ = DateTime.Now;
                    hoso.NgayYLenh = DateTime.Now;
                    if (hoso.SpDichVuChiTiet(ref err, "DELETE_GIUONG"))
                    {
                        listGiuong.Remove(key);
                    }
                }
            }
            foreach (DataRowView drv in dvGiuongBenh)
            {
                err = "";

                hoso.MaDichVu = drv["MaDichVu"].ToString();
                hoso.TenDichVu = drv["TenDichVu"].ToString();
                hoso.DonViTinh = "Ngày";
                hoso.SoLuong = Utils.ToInt(drv["SoLuong"]);
                hoso.DonGia = Utils.ToDecimal(drv["DonGia"]);
                hoso.TyLe = 100;
                hoso.ThanhTien = Utils.ToDecimal(drv["ThanhTien"]);
                hoso.MaKhoa = this.MaKhoa;
                hoso.MaBacSi = this.MaBacSi;
                hoso.NgayYLenh = Utils.ToDateTime(drv["NgayYLenh"].ToString());
                hoso.NgayKQ = Utils.ToDateTime(drv["NgayKQ"].ToString());
                hoso.MaGiuong = drv["MaGiuong"].ToString();
                hoso.MaNhom = 15;
                if (listGiuong[hoso.MaDichVu] == 1)
                {
                    // cập nhật
                    hoso.SpDichVuChiTiet(ref err, "UPDATE_GIUONG");
                }
                else if (listGiuong[hoso.MaDichVu] == 2)
                {
                    // thêm mới
                    if (hoso.SpDichVuChiTiet(ref err, "INSERT_GIUONG"))
                        listGiuong[hoso.MaDichVu] = 1;
                }
                if (!string.IsNullOrEmpty(err))
                {
                    XtraMessageBox.Show(err, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
