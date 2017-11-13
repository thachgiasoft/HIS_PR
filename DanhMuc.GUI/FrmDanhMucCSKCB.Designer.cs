namespace DanhMuc.GUI
{
    partial class FrmDanhMucCSKCB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDanhMucCSKCB));
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.splitContainerControl = new DevExpress.XtraEditors.SplitContainerControl();
            this.navBarControl = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroupDMCSKCB = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarGiuongBenh = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarCongKham = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarDVKT = new DevExpress.XtraNavBar.NavBarItem();
            this.panelControl = new DevExpress.XtraEditors.PanelControl();
            this.navBarNhomCanLamSan = new DevExpress.XtraNavBar.NavBarItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl)).BeginInit();
            this.splitContainerControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 1;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl.ShowToolbarCustomizeItem = false;
            this.ribbonControl.Size = new System.Drawing.Size(864, 27);
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // splitContainerControl
            // 
            this.splitContainerControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl.Location = new System.Drawing.Point(0, 27);
            this.splitContainerControl.Name = "splitContainerControl";
            this.splitContainerControl.Panel1.Controls.Add(this.navBarControl);
            this.splitContainerControl.Panel1.Text = "Panel1";
            this.splitContainerControl.Panel2.Controls.Add(this.panelControl);
            this.splitContainerControl.Panel2.Text = "Panel2";
            this.splitContainerControl.Size = new System.Drawing.Size(864, 456);
            this.splitContainerControl.SplitterPosition = 178;
            this.splitContainerControl.TabIndex = 1;
            this.splitContainerControl.Text = "splitContainerControl1";
            // 
            // navBarControl
            // 
            this.navBarControl.ActiveGroup = this.navBarGroupDMCSKCB;
            this.navBarControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navBarControl.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroupDMCSKCB});
            this.navBarControl.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navBarGiuongBenh,
            this.navBarCongKham,
            this.navBarDVKT,
            this.navBarNhomCanLamSan});
            this.navBarControl.Location = new System.Drawing.Point(0, 0);
            this.navBarControl.Name = "navBarControl";
            this.navBarControl.OptionsNavPane.ExpandedWidth = 178;
            this.navBarControl.Size = new System.Drawing.Size(178, 456);
            this.navBarControl.TabIndex = 0;
            this.navBarControl.Text = "navBarControl1";
            // 
            // navBarGroupDMCSKCB
            // 
            this.navBarGroupDMCSKCB.Caption = "Danh mục tại CSKCB";
            this.navBarGroupDMCSKCB.Expanded = true;
            this.navBarGroupDMCSKCB.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarGiuongBenh),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarCongKham),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarDVKT),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarNhomCanLamSan)});
            this.navBarGroupDMCSKCB.Name = "navBarGroupDMCSKCB";
            this.navBarGroupDMCSKCB.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarGroupDMCSKCB.SmallImage")));
            // 
            // navBarGiuongBenh
            // 
            this.navBarGiuongBenh.Caption = "Danh mục Giường bệnh";
            this.navBarGiuongBenh.Name = "navBarGiuongBenh";
            this.navBarGiuongBenh.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarGiuongBenh.SmallImage")));
            this.navBarGiuongBenh.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarGiuongBenh_LinkClicked);
            // 
            // navBarCongKham
            // 
            this.navBarCongKham.Caption = "Danh mục Công khám";
            this.navBarCongKham.Name = "navBarCongKham";
            this.navBarCongKham.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarCongKham.SmallImage")));
            this.navBarCongKham.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarCongKham_LinkClicked);
            // 
            // navBarDVKT
            // 
            this.navBarDVKT.Caption = "Danh mục DVKT";
            this.navBarDVKT.Name = "navBarDVKT";
            this.navBarDVKT.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarDVKT.SmallImage")));
            this.navBarDVKT.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarDVKT_LinkClicked);
            // 
            // panelControl
            // 
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl.Location = new System.Drawing.Point(0, 0);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(681, 456);
            this.panelControl.TabIndex = 0;
            // 
            // navBarNhomCanLamSan
            // 
            this.navBarNhomCanLamSan.Caption = "Nhóm Cận lâm sàn";
            this.navBarNhomCanLamSan.Name = "navBarNhomCanLamSan";
            this.navBarNhomCanLamSan.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarNhomCanLamSan.SmallImage")));
            this.navBarNhomCanLamSan.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarNhomCanLamSan_LinkClicked);
            // 
            // FrmDanhMucCSKCB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 483);
            this.Controls.Add(this.splitContainerControl);
            this.Controls.Add(this.ribbonControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDanhMucCSKCB";
            this.Ribbon = this.ribbonControl;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục tại Cơ sở KCB";
            this.Load += new System.EventHandler(this.FrmDanhMucCSKCB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl)).EndInit();
            this.splitContainerControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl;
        private DevExpress.XtraEditors.PanelControl panelControl;
        private DevExpress.XtraNavBar.NavBarControl navBarControl;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroupDMCSKCB;
        private DevExpress.XtraNavBar.NavBarItem navBarGiuongBenh;
        private DevExpress.XtraNavBar.NavBarItem navBarCongKham;
        private DevExpress.XtraNavBar.NavBarItem navBarDVKT;
        private DevExpress.XtraNavBar.NavBarItem navBarNhomCanLamSan;
    }
}