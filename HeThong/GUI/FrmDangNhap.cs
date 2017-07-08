using DevExpress.XtraBars.Ribbon;
using System;


namespace HeThong.GUI
{
    public partial class FrmDangNhap : RibbonForm
    {
        public FrmDangNhap ()
        {
            InitializeComponent ();
        }

        private void FrmDangNhap_Load (object sender, EventArgs e)
        {

        }

        private void btnOK_Click (object sender, EventArgs e)
        {

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
