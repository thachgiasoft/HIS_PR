using DevExpress.XtraBars.Ribbon;
using System;
using System.Windows.Forms;

namespace HeThong.GUI
{
    public partial class FrmQuanTriHeThong : RibbonForm
    {
        UC_ChucNang ucChucNang;
        UC_Menu ucMenu;
        UC_SoDoToChuc ucSoDoToChuc;
        UC_PhanQuyen ucPhanQuyen;
        public FrmQuanTriHeThong ()
        {
            InitializeComponent ();
        }
        protected override void OnLoad (EventArgs e)
        {
            base.OnLoad (e);
            this.WindowState = FormWindowState.Maximized;
        }
        private void FrmQuanTriHeThong_Load (object sender, EventArgs e)
        {
            
            
        }

        private void navBarChucNang_LinkClicked (object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if(!panelControl.Controls.Contains (ucChucNang))
            {
                ucChucNang = new UC_ChucNang ();
                ucChucNang.Dock = DockStyle.Fill;
                panelControl.Controls.Add (ucChucNang);
            }
            ucChucNang.BringToFront ();
        }

        private void navBarMenu_LinkClicked (object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (!panelControl.Controls.Contains (ucMenu))
            {
                ucMenu = new UC_Menu ();
                ucMenu.Dock = DockStyle.Fill;
                panelControl.Controls.Add (ucMenu);
            }
            ucMenu.BringToFront ();
        }

        private void navBarSoDoToChuc_LinkClicked (object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (!panelControl.Controls.Contains (ucSoDoToChuc))
            {
                ucSoDoToChuc = new UC_SoDoToChuc ();
                ucSoDoToChuc.Dock = DockStyle.Fill;
                panelControl.Controls.Add (ucSoDoToChuc);
            }
            ucSoDoToChuc.BringToFront ();
        }

        private void navBarPhanQuyen_LinkClicked (object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (!panelControl.Controls.Contains (ucPhanQuyen))
            {
                ucPhanQuyen = new UC_PhanQuyen ();
                ucPhanQuyen.Dock = DockStyle.Fill;
                panelControl.Controls.Add (ucPhanQuyen);
            }
            ucPhanQuyen.BringToFront ();
        }
    }
}
