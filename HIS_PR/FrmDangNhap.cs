using Core.DAL;
using DevExpress.XtraBars.Ribbon;
using System;


namespace HIS_PR
{
    public partial class FrmDangNhap : RibbonForm
    {
        FrmMain frmMain;
        AppConfig appConfig = new AppConfig ();
        public FrmDangNhap ()
        {
            InitializeComponent ();
            appConfig.Read ();
            frmMain = new FrmMain (this);
        }

        private void FrmDangNhap_Load (object sender, EventArgs e)
        {

        }

        private void btnOK_Click (object sender, EventArgs e)
        {
            this.Hide ();
            frmMain.Show ();
        }

        private void btnThoat_Click (object sender, EventArgs e)
        {
            this.Close ();
        }

        private void txtTenDN_KeyPress (object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if(e.KeyChar == 13 && txtTenDN.Text.Length >0)
            {
                txtMatKhau.Focus ();
            }
        }

        private void txtMatKhau_KeyPress (object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 && txtMatKhau.Text.Length > 0)
            {
                btnOK.Focus ();
            }
        }
    }
}
