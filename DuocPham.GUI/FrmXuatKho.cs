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
    public partial class FrmXuatKho : RibbonForm
    {
        XuatKhoEntity xuatkho;
        public FrmXuatKho ()
        {
            InitializeComponent ();
            xuatkho = new XuatKhoEntity ();
        }
        protected override void OnLoad (EventArgs e)
        {
            base.OnLoad (e);
            this.WindowState = FormWindowState.Maximized;
        }
        private void FrmXuatKho_Load (object sender, EventArgs e)
        {
            lookUpKhoXuat.Properties.DataSource = xuatkho.DSKhoXuat ();
            lookUpKhoXuat.Properties.ValueMember = "MaKhoa";
            lookUpKhoXuat.Properties.DisplayMember = "TenKhoa";
            lookUpKhoXuat.EditValue = "70013";

            lookUpKhoNhan.Properties.DataSource = xuatkho.DSKhoNhan ();
            lookUpKhoNhan.Properties.ValueMember = "MaKhoa";
            lookUpKhoNhan.Properties.DisplayMember = "TenKhoa";


            lookUpMaVatTu.Properties.DisplayMember = "TenVatTu";
            lookUpMaVatTu.Properties.ValueMember = "MaVatTu";
        }

        private void txtTKCo_EditValueChanged (object sender, EventArgs e)
        {
            if(txtTKCo.Text.Length==4)
            {
                //xuatkho.TKCo = txtTKCo.Text;
                xuatkho.KhoXuat = lookUpKhoXuat.EditValue.ToString ();
                lookUpMaVatTu.Properties.DataSource = xuatkho.DSVatTu (txtTKCo.Text.Substring (3, 1));
            }
        }
    }
}
