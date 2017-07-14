using System;
using DevExpress.XtraBars.Ribbon;
using System.Windows.Forms;

namespace DanhMuc.GUI
{
    public partial class FrmNhanVien : RibbonForm
    {
        public FrmNhanVien ()
        {
            InitializeComponent ();
        }
        protected override void OnLoad (EventArgs e)
        {
            base.OnLoad (e);
            this.WindowState = FormWindowState.Maximized;
        }
        private void FrmNhanVien_Load (object sender, EventArgs e)
        {

        }
    }
}