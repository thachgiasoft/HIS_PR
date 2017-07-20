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
    public partial class FrmDanhMucKhac : RibbonForm
    {
        UC_BenhICDX ucBenhICDX;
        UC_CoSoKCB ucCoSoKCB;
        UC_DonViTinh ucDonViTinh;
        public FrmDanhMucKhac ()
        {
            InitializeComponent ();
        }
        protected override void OnLoad (EventArgs e)
        {
            base.OnLoad (e);
            this.WindowState = FormWindowState.Maximized;
        }

        private void FrmDanhMucKhac_Load (object sender, EventArgs e)
        {

        }

        private void navBarDMBenhICDX_LinkClicked (object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (!panelControl.Controls.Contains (ucBenhICDX))
            {
                ucBenhICDX = new UC_BenhICDX ();
                ucBenhICDX.Dock = DockStyle.Fill;
                panelControl.Controls.Add (ucBenhICDX);
            }
            ucBenhICDX.BringToFront ();
        }

        private void navBarDMCSKCB_LinkClicked (object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (!panelControl.Controls.Contains (ucCoSoKCB))
            {
                ucCoSoKCB = new UC_CoSoKCB ();
                ucCoSoKCB.Dock = DockStyle.Fill;
                panelControl.Controls.Add (ucCoSoKCB);
            }
            ucCoSoKCB.BringToFront ();
        }

        private void navBarDMDonViTinh_LinkClicked (object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (!panelControl.Controls.Contains (ucDonViTinh))
            {
                ucDonViTinh = new UC_DonViTinh ();
                ucDonViTinh.Dock = DockStyle.Fill;
                panelControl.Controls.Add (ucDonViTinh);
            }
            ucDonViTinh.BringToFront ();
        }
    }
}
