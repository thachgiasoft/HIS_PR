using Core.DAL;
using DanhMuc.GUI;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DuocPham.GUI;
using HeThong.GUI;
using System;
using System.Windows.Forms;

namespace HIS_PR
{
    public partial class FrmMain : RibbonForm
    {
        Form frm;
        AppConfig appConfig = new AppConfig ();
        DangNhapEntity dangnhap = new DangNhapEntity ();
        bool dangxuat = false;
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
        private void LoadMenu ()
        {
            foreach(RibbonPage page in ribbonControlMain.Pages)
            {
               foreach(RibbonPageGroup pageGroup in page.Groups)
                {
                    foreach(BarButtonItemLink barButton in pageGroup.ItemLinks)
                    {
                        if(Utils.CheckMenu(barButton.Item.Name))
                        {
                            barButton.Item.Enabled = true;
                        }
                        else
                        {
                            barButton.Item.Enabled = false;
                        }
                    }
                }
            }
        }
        private void FrmMain_Load (object sender, EventArgs e)
        {
            barlblMaNV.Caption = AppConfig.MaNV;
            LoadMenu ();
        }

        private void FrmMain_FormClosing (object sender, FormClosingEventArgs e)
        {
            if (!dangxuat)
            {
                DialogResult traloi;
                traloi = XtraMessageBox.Show ("Thoát ứng dụng?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (traloi == DialogResult.Yes)
                {
                    if (AppConfig.Theme != DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName)
                    {
                        AppConfig.Theme = DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName;
                        appConfig.WriteTheme ();       
                    }
                    Utils.ThemHoatDong (Library.DANGXUAT);
                    frm.Close ();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void barQuanTriHeThong_ItemClick (object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
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

        private void barbtnLogout_ItemClick (object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Utils.ThemHoatDong (Library.DANGXUAT);

            AppConfig.MaNV = "";
            AppConfig.MatKhau = "";
            AppConfig.CoSoKCB = "";       

            dangxuat = true;

            this.Close ();
            frm.Show ();

        }

        private void barDanhMucKhac_ItemClick (object sender, ItemClickEventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.GetType () == typeof (FrmDanhMucDungChung))
                {
                    frm.Activate ();
                    frm.WindowState = FormWindowState.Maximized;
                    return;
                }
            }
            FrmDanhMucDungChung frmDMKhac = new FrmDanhMucDungChung ();
            frmDMKhac.MdiParent = this;
            frmDMKhac.Show ();
        }

        private void barButtonNhapKho_ItemClick (object sender, ItemClickEventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.GetType () == typeof (FrmNhapKho))
                {
                    frm.Activate ();
                    frm.WindowState = FormWindowState.Maximized;
                    return;
                }
            }
            FrmNhapKho frmNhapKho = new FrmNhapKho ();
            frmNhapKho.MdiParent = this;
            frmNhapKho.Show ();
        }

        private void barButtonXuatKho_ItemClick (object sender, ItemClickEventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.GetType () == typeof (FrmXuatKho))
                {
                    frm.Activate ();
                    frm.WindowState = FormWindowState.Maximized;
                    return;
                }
            }
            FrmXuatKho frmXuatKho = new FrmXuatKho ();
            frmXuatKho.MdiParent = this;
            frmXuatKho.Show ();
        }
    }
}
