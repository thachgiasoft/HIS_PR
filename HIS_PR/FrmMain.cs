using Core.DAL;
using DanhMuc.GUI;
using DevExpress.XtraBars.Ribbon;
using HeThong.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HIS_PR
{
    public partial class FrmMain : RibbonForm
    {
        Form frm;
        AppConfig appConfig = new AppConfig ();
        public FrmMain (Form frm)
        {
            InitializeComponent ();
            this.frm = frm;
            this.WindowState = FormWindowState.Maximized;
            
            DevExpress.XtraBars.Helpers.SkinHelper.InitSkinPopupMenu (barLinkSkin);
            //foreach (RibbonControlColorScheme color in Enum.GetValues (typeof (RibbonControlColorScheme)))
            //{
            //    barListColor.Strings.Add (color.ToString());
            //}

            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle (AppConfig.Theme);
        }

        private void FrmMain_Load (object sender, EventArgs e)
        {
        }

        private void FrmMain_FormClosing (object sender, FormClosingEventArgs e)
        {
            if (AppConfig.Theme != DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName)
            {
                AppConfig.Theme = DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName;
                appConfig.WriteTheme ();
            }
            this.Hide ();
            frm.Show ();
            e.Cancel = true;
        }

        private void barQuanTriHeThong_ItemClick (object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //
            foreach(Form frm in this.MdiChildren)
            {
                if(frm.GetType()==typeof(FrmQuanTriHeThong))
                {
                    frm.Activate ();
                    frm.WindowState = FormWindowState.Maximized;
                    return;
                }
            }
            FrmQuanTriHeThong frmQTHeThong = new FrmQuanTriHeThong ();
            frmQTHeThong.MdiParent = this;
            frmQTHeThong.Show ();
        }

        private void barDanhMucNhanVien_ItemClick (object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.GetType () == typeof (FrmNhanVien))
                {
                    frm.Activate ();
                    frm.WindowState = FormWindowState.Maximized;
                    return;
                }
            }
            FrmNhanVien frmNhanVien = new FrmNhanVien ();
            frmNhanVien.MdiParent = this;
            frmNhanVien.Show ();
        }
    }
}
