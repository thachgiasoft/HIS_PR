using Core.DAL;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraReports.UI;
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
    public partial class FrmCDCanLamSan : RibbonForm
    {
        KhamBenhEntity khambenh;
        public string MaLK { get; set; }
        public string HoTen { get; set; }
        public string NamSinh { get; set; }
        public string DiaChi { get; set; }
        public string TheBHYT { get; set; }
        public string GioiTinh { get; set; }
        private DataTable data;
        public FrmCDCanLamSan(KhamBenhEntity khambenh)
        {
            InitializeComponent();
            this.khambenh = khambenh;
            lookUpBacSi.Properties.DataSource = khambenh.DSBacSi();
            lookUpBacSi.Properties.ValueMember = "Ma_BS";
            lookUpBacSi.Properties.DisplayMember = "Ten_NV";
           
        }

        private void FrmCDCanLamSan_Load(object sender, EventArgs e)
        {
            if (lookUpBacSi.ItemIndex <0)
            {
                lookUpBacSi.ItemIndex = 0;
            }
            this.ActiveControl = lookUpBacSi;
            txtHoTen.Text = this.HoTen;
            khambenh.MaLK = MaLK;
            gridControl.DataSource = data = khambenh.DSChiDinhCanLamSan(this.MaLK);
        }

        private void gridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if(e.Column.Name == "Chon")
            {
                bool chon = Utils.ToBoolean(e.Value);
                khambenh.MaCSL = gridView.GetRowCellValue(e.RowHandle, gridView.Columns["Ma"]).ToString();
                khambenh.NgayChiDinh = DateTime.Now.ToShortDateString();
                gridView.SetFocusedRowCellValue("NgayChiDinh", khambenh.NgayChiDinh);
                string err = null;
                if(chon)
                {
                    khambenh.SpCDCanLamSan(ref err, "INSERT");
                }
                else
                {
                    khambenh.SpCDCanLamSan(ref err, "DELETE");
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            LuuCanLamSan();
        }
        private void LuuCanLamSan(bool inPhieu = false)
        {
            foreach(DataRow dr in data.Rows)
            {
                if(Utils.ToBoolean(dr["Chon"]))
                {
                    khambenh.MaCSL = dr["Ma"].ToString();
                    khambenh.MaBS = Utils.ToString(lookUpBacSi.EditValue);
                    khambenh.ChuanDoan = dr["ChuanDoan"].ToString();
                    khambenh.YeuCau = dr["YeuCau"].ToString();
                    khambenh.NgayChiDinh = dr["NgayChiDinh"].ToString();
                    string err = null;
                    if(khambenh.SpCDCanLamSan(ref err, "UPDATE") && inPhieu)
                    {
                        // in phiếu
                        TaoPhieu(dr);
                    }
                }
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            LuuCanLamSan(true);
        }
        private void TaoPhieu(DataRow dr)
        {
            RptPhieuYeuCau rpt = new RptPhieuYeuCau();
            rpt.lblHoTen.Text = this.HoTen;
            rpt.lblNamSinh.Text = this.NamSinh;
            rpt.lblGioiTinh.Text = this.GioiTinh == "0" ? "Nam" : "Nữ";
            rpt.lblMauSo.Text = "MS:" + dr["MauSo"] + "/BV-01";
            rpt.lblDiaChi.Text = this.DiaChi;
            rpt.lblSoThe.Text = this.TheBHYT;
            rpt.lblChuanDoan.Text = khambenh.ChuanDoan;
            rpt.lblYeuCau.Text = khambenh.YeuCau;
            rpt.lblNgayThang.Text = "Ngày " + DateTime.Now.Day + " tháng " + DateTime.Now.Month + " năm " + DateTime.Now.Year;
            rpt.lblTenPhieu.Text = "PHIẾU " + dr["Ten"].ToString().ToUpper();
            rpt.lblTenBacSi.Text = "Họ tên: " + lookUpBacSi.Properties.GetDisplayValueByKeyValue(lookUpBacSi.EditValue);
            rpt.CreateDocument();
            rpt.ShowPreviewDialog();
        }
    }
}
