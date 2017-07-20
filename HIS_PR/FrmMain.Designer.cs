namespace HIS_PR
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose ();
            }
            base.Dispose (disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.ribbonControlMain = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barLinkSkin = new DevExpress.XtraBars.BarLinkContainerItem();
            this.barQuanTriHeThong = new DevExpress.XtraBars.BarButtonItem();
            this.barDanhMucNhanVien = new DevExpress.XtraBars.BarButtonItem();
            this.barlblMaNV = new DevExpress.XtraBars.BarStaticItem();
            this.barbtnLogout = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageHeThong = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupHeThong = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageDanhMuc = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupDanhMuc = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBarMain = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barDanhMucKhac = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControlMain)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControlMain
            // 
            this.ribbonControlMain.ExpandCollapseItem.Id = 0;
            this.ribbonControlMain.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControlMain.ExpandCollapseItem,
            this.barLinkSkin,
            this.barQuanTriHeThong,
            this.barDanhMucNhanVien,
            this.barlblMaNV,
            this.barbtnLogout,
            this.barSubItem1,
            this.barButtonItem1,
            this.barDanhMucKhac});
            this.ribbonControlMain.Location = new System.Drawing.Point(0, 0);
            this.ribbonControlMain.MaxItemId = 15;
            this.ribbonControlMain.Name = "ribbonControlMain";
            this.ribbonControlMain.PageHeaderItemLinks.Add(this.barLinkSkin);
            this.ribbonControlMain.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPageHeThong,
            this.ribbonPageDanhMuc});
            this.ribbonControlMain.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControlMain.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControlMain.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.True;
            this.ribbonControlMain.Size = new System.Drawing.Size(1290, 143);
            this.ribbonControlMain.StatusBar = this.ribbonStatusBarMain;
            // 
            // barLinkSkin
            // 
            this.barLinkSkin.Caption = "Giao diện";
            this.barLinkSkin.Id = 8;
            this.barLinkSkin.Name = "barLinkSkin";
            // 
            // barQuanTriHeThong
            // 
            this.barQuanTriHeThong.Caption = "Quản trị hệ thống";
            this.barQuanTriHeThong.Id = 1;
            this.barQuanTriHeThong.Name = "barQuanTriHeThong";
            this.barQuanTriHeThong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barQuanTriHeThong_ItemClick);
            // 
            // barDanhMucNhanVien
            // 
            this.barDanhMucNhanVien.Caption = "Danh mục nhân viên";
            this.barDanhMucNhanVien.Id = 3;
            this.barDanhMucNhanVien.Name = "barDanhMucNhanVien";
            this.barDanhMucNhanVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barDanhMucNhanVien_ItemClick);
            // 
            // barlblMaNV
            // 
            this.barlblMaNV.Caption = "NhanVien";
            this.barlblMaNV.Id = 9;
            this.barlblMaNV.Name = "barlblMaNV";
            this.barlblMaNV.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barbtnLogout
            // 
            this.barbtnLogout.Caption = "Thoát";
            this.barbtnLogout.Id = 10;
            this.barbtnLogout.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barbtnLogout.ImageOptions.Image")));
            this.barbtnLogout.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barbtnLogout.ImageOptions.LargeImage")));
            this.barbtnLogout.Name = "barbtnLogout";
            this.barbtnLogout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtnLogout_ItemClick);
            // 
            // ribbonPageHeThong
            // 
            this.ribbonPageHeThong.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupHeThong});
            this.ribbonPageHeThong.Name = "ribbonPageHeThong";
            this.ribbonPageHeThong.Text = "Hệ thống";
            // 
            // ribbonPageGroupHeThong
            // 
            this.ribbonPageGroupHeThong.ItemLinks.Add(this.barQuanTriHeThong);
            this.ribbonPageGroupHeThong.Name = "ribbonPageGroupHeThong";
            this.ribbonPageGroupHeThong.ShowCaptionButton = false;
            // 
            // ribbonPageDanhMuc
            // 
            this.ribbonPageDanhMuc.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupDanhMuc});
            this.ribbonPageDanhMuc.Name = "ribbonPageDanhMuc";
            this.ribbonPageDanhMuc.Text = "Danh mục";
            // 
            // ribbonPageGroupDanhMuc
            // 
            this.ribbonPageGroupDanhMuc.ItemLinks.Add(this.barDanhMucNhanVien);
            this.ribbonPageGroupDanhMuc.ItemLinks.Add(this.barDanhMucKhac);
            this.ribbonPageGroupDanhMuc.Name = "ribbonPageGroupDanhMuc";
            this.ribbonPageGroupDanhMuc.ShowCaptionButton = false;
            // 
            // ribbonStatusBarMain
            // 
            this.ribbonStatusBarMain.ItemLinks.Add(this.barlblMaNV);
            this.ribbonStatusBarMain.ItemLinks.Add(this.barbtnLogout);
            this.ribbonStatusBarMain.Location = new System.Drawing.Point(0, 668);
            this.ribbonStatusBarMain.Name = "ribbonStatusBarMain";
            this.ribbonStatusBarMain.Ribbon = this.ribbonControlMain;
            this.ribbonStatusBarMain.Size = new System.Drawing.Size(1290, 31);
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "barSubItem1";
            this.barSubItem1.Id = 12;
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1)});
            this.barSubItem1.Name = "barSubItem1";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 13;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barDanhMucKhac
            // 
            this.barDanhMucKhac.Caption = "Danh mục khác";
            this.barDanhMucKhac.Id = 14;
            this.barDanhMucKhac.Name = "barDanhMucKhac";
            this.barDanhMucKhac.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barDanhMucKhac_ItemClick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 699);
            this.Controls.Add(this.ribbonStatusBarMain);
            this.Controls.Add(this.ribbonControlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "FrmMain";
            this.Ribbon = this.ribbonControlMain;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBarMain;
            this.Text = "Hệ thống quản lý bệnh viện";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControlMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControlMain;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBarMain;   
        private DevExpress.XtraBars.BarLinkContainerItem barLinkSkin;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageHeThong;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupHeThong;
        private DevExpress.XtraBars.BarButtonItem barQuanTriHeThong;
        private DevExpress.XtraBars.BarButtonItem barDanhMucNhanVien;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageDanhMuc;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupDanhMuc;
        private DevExpress.XtraBars.BarStaticItem barlblMaNV;
        private DevExpress.XtraBars.BarButtonItem barbtnLogout;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barDanhMucKhac;
    }
}