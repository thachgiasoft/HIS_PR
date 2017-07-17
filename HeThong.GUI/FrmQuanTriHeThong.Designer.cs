namespace HeThong.GUI
{
    partial class FrmQuanTriHeThong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuanTriHeThong));
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.splitContainerControl = new DevExpress.XtraEditors.SplitContainerControl();
            this.navBarControl2 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarHeThong = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarChucNang = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarMenu = new DevExpress.XtraNavBar.NavBarItem();
            this.panelControl = new DevExpress.XtraEditors.PanelControl();
            this.navBarSoDoToChuc = new DevExpress.XtraNavBar.NavBarItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl)).BeginInit();
            this.splitContainerControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.barButtonItem1});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 2;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl.ShowToolbarCustomizeItem = false;
            this.ribbonControl.Size = new System.Drawing.Size(890, 27);
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // splitContainerControl
            // 
            this.splitContainerControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl.Location = new System.Drawing.Point(0, 27);
            this.splitContainerControl.Name = "splitContainerControl";
            this.splitContainerControl.Panel1.Controls.Add(this.navBarControl2);
            this.splitContainerControl.Panel1.Text = "PanelLeft";
            this.splitContainerControl.Panel2.Controls.Add(this.panelControl);
            this.splitContainerControl.Size = new System.Drawing.Size(890, 468);
            this.splitContainerControl.SplitterPosition = 169;
            this.splitContainerControl.TabIndex = 1;
            // 
            // navBarControl2
            // 
            this.navBarControl2.ActiveGroup = this.navBarHeThong;
            this.navBarControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navBarControl2.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarHeThong});
            this.navBarControl2.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navBarChucNang,
            this.navBarMenu,
            this.navBarSoDoToChuc});
            this.navBarControl2.Location = new System.Drawing.Point(0, 0);
            this.navBarControl2.Name = "navBarControl2";
            this.navBarControl2.OptionsNavPane.ExpandedWidth = 169;
            this.navBarControl2.Size = new System.Drawing.Size(169, 468);
            this.navBarControl2.TabIndex = 0;
            this.navBarControl2.Text = "navBarControl2";
            // 
            // navBarHeThong
            // 
            this.navBarHeThong.Caption = "Quản trị hệ thống";
            this.navBarHeThong.Expanded = true;
            this.navBarHeThong.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarChucNang),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarMenu),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarSoDoToChuc)});
            this.navBarHeThong.Name = "navBarHeThong";
            this.navBarHeThong.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarHeThong.SmallImage")));
            // 
            // navBarChucNang
            // 
            this.navBarChucNang.Caption = "Chức năng";
            this.navBarChucNang.Name = "navBarChucNang";
            this.navBarChucNang.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarChucNang.SmallImage")));
            this.navBarChucNang.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarChucNang_LinkClicked);
            // 
            // navBarMenu
            // 
            this.navBarMenu.Caption = "Menu";
            this.navBarMenu.Name = "navBarMenu";
            this.navBarMenu.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarMenu.SmallImage")));
            this.navBarMenu.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarMenu_LinkClicked);
            // 
            // panelControl
            // 
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl.Location = new System.Drawing.Point(0, 0);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(716, 468);
            this.panelControl.TabIndex = 0;
            // 
            // navBarSoDoToChuc
            // 
            this.navBarSoDoToChuc.Caption = "Sơ đồ tổ chức";
            this.navBarSoDoToChuc.Name = "navBarSoDoToChuc";
            this.navBarSoDoToChuc.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarSoDoToChuc.SmallImage")));
            this.navBarSoDoToChuc.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarSoDoToChuc_LinkClicked);
            // 
            // FrmQuanTriHeThong
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 495);
            this.Controls.Add(this.splitContainerControl);
            this.Controls.Add(this.ribbonControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmQuanTriHeThong";
            this.Ribbon = this.ribbonControl;
            this.Text = "Quản trị hệ thống";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmQuanTriHeThong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl)).EndInit();
            this.splitContainerControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl;
        private DevExpress.XtraNavBar.NavBarControl navBarControl2;
        private DevExpress.XtraNavBar.NavBarGroup navBarHeThong;
        private DevExpress.XtraNavBar.NavBarItem navBarChucNang;
        private DevExpress.XtraEditors.PanelControl panelControl;
        private DevExpress.XtraNavBar.NavBarItem navBarMenu;
        private DevExpress.XtraNavBar.NavBarItem navBarSoDoToChuc;
    }
}