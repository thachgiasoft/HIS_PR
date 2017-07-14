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
            this.ribbonPageHeThong = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupHeThong = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBarMain = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPageDanhMuc = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupDanhMuc = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barDanhMucNhanVien = new DevExpress.XtraBars.BarButtonItem();
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
            this.barDanhMucNhanVien});
            this.ribbonControlMain.Location = new System.Drawing.Point(0, 0);
            this.ribbonControlMain.MaxItemId = 4;
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
            // ribbonStatusBarMain
            // 
            this.ribbonStatusBarMain.Location = new System.Drawing.Point(0, 668);
            this.ribbonStatusBarMain.Name = "ribbonStatusBarMain";
            this.ribbonStatusBarMain.Ribbon = this.ribbonControlMain;
            this.ribbonStatusBarMain.Size = new System.Drawing.Size(1290, 31);
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
            this.ribbonPageGroupDanhMuc.Name = "ribbonPageGroupDanhMuc";
            this.ribbonPageGroupDanhMuc.ShowCaptionButton = false;
            // 
            // barDanhMucNhanVien
            // 
            this.barDanhMucNhanVien.Caption = "Danh mục nhân viên";
            this.barDanhMucNhanVien.Id = 3;
            this.barDanhMucNhanVien.Name = "barDanhMucNhanVien";
            this.barDanhMucNhanVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barDanhMucNhanVien_ItemClick);
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
    }
}