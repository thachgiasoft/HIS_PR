using DevExpress.XtraBars.Ribbon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DanhMuc.GUI
{
    public partial class FrmDanhMucCSKCB : RibbonForm
    {
        UC_GiuongBenh ucTienKham;
        public FrmDanhMucCSKCB ()
        {
            InitializeComponent ();
        }
        protected override void OnLoad (EventArgs e)
        {
            base.OnLoad (e);
            this.WindowState = FormWindowState.Maximized;
        }
        private void FrmDanhMucCSKCB_Load (object sender, EventArgs e)
        {

        }

        private void navBarGiuongBenh_LinkClicked (object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (!panelControl.Controls.Contains (ucTienKham))
            {
                ucTienKham = new UC_GiuongBenh ();
                ucTienKham.Dock = DockStyle.Fill;
                panelControl.Controls.Add (ucTienKham);
            }
            ucTienKham.BringToFront ();
        }
    }
}
