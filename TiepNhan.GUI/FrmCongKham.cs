using Core.DAL;
using DevExpress.XtraBars.Ribbon;
using KhamBenh.DAL;
using System;
using System.Data;

namespace TiepNhan.GUI
{
    public partial class FrmCongKham : RibbonForm
    {
        ThanhToanEntity thanhToan;
        public FrmCongKham(ThanhToanEntity thanhtoan)
        {
            InitializeComponent();
            thanhToan = thanhtoan;
        }
        public string MaLK { get; set; }
        public string MaKhoa { get; set; }
        public string MaBacSi { get; set; }
        private void FrmCongKham_Load(object sender, EventArgs e)
        {
            thanhToan.MaLK = this.MaLK;
            thanhToan.MaKhoa = this.MaKhoa;
            thanhToan.MaBacSi = this.MaBacSi;
            gridControl.DataSource = thanhToan.DSCongKham();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if(e.Column.Name == "Chon")
            {
                string err = "";
                DataRow dr = gridView.GetDataRow(e.RowHandle);
                thanhToan.MaDichVu = dr["Ma"].ToString();
                thanhToan.MaKhoa = this.MaKhoa;
                thanhToan.MaBacSi = this.MaBacSi;
                thanhToan.NgayKQ = DateTime.Now;
                thanhToan.NgayYLenh = DateTime.Now;
                if (Utils.ToBoolean(e.Value))
                {
                    // thêm
                    thanhToan.TenDichVu = dr["Ten"].ToString();
                    thanhToan.DonViTinh = "Lần";
                    thanhToan.SoLuong = 1;
                    thanhToan.DonGia = Utils.ToDecimal(dr["DonGia"]);
                    thanhToan.TyLe = 100;
                    thanhToan.ThanhTien = thanhToan.DonGia;
                    thanhToan.MaNhom =Utils.ToInt( dr["MaNhom"]);

                    thanhToan.SpDichVuChiTiet(ref err, "INSERT_CK");
                }
                else
                {
                    // xóa
                    thanhToan.SpDichVuChiTiet(ref err, "DELETE_CK");
                }
            }
        }
    }
}
