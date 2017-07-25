using DevExpress.XtraBars.Ribbon;
using DuocPham.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuocPham.GUI
{
    public partial class FrmNhapKho : RibbonForm
    {
        NhapKhoEntity nhapkho;
        public FrmNhapKho ()
        {
            InitializeComponent ();
            nhapkho = new NhapKhoEntity ();
        }
        protected override void OnLoad (EventArgs e)
        {
            base.OnLoad (e);
            this.WindowState = FormWindowState.Maximized;
        }
        private void FrmNhapKho_Load (object sender, EventArgs e)
        {
            lookUpKhoNhap.Properties.DataSource = nhapkho.DSKho ();
            lookUpKhoNhap.Properties.DisplayMember = "TenKhoa";
            lookUpKhoNhap.Properties.ValueMember = "MaKhoa";

            lookUpNhaCungCap.Properties.DataSource = nhapkho.DSNhaCungCap ();
            lookUpNhaCungCap.Properties.DisplayMember = "Ten";
            lookUpNhaCungCap.Properties.ValueMember = "Ten";

            lookUpNguoiNhan.Properties.DataSource = nhapkho.DSNguoiNhan ();
            lookUpNguoiNhan.Properties.DisplayMember = "Ten_NV";
            lookUpNguoiNhan.Properties.ValueMember = "Ma_NV";
        }
    }
}
