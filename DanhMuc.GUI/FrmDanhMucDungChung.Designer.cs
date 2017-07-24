namespace DanhMuc.GUI
{
    partial class FrmDanhMucDungChung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDanhMucDungChung));
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.splitContainerControl = new DevExpress.XtraEditors.SplitContainerControl();
            this.navBarControl = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroupDungChung = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarDMBenhICDX = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarDMCSKCB = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroupKhac = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarDMDonViTinh = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarDMDuongDung = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarDMLuongCoSo = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarDMNuocSX = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarDMNhaCC = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroupDuoc = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarDMLoaiVatTu = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarDMNhomVatTu = new DevExpress.XtraNavBar.NavBarItem();
            this.panelControl = new DevExpress.XtraEditors.PanelControl();
            this.navBarDMVatTu = new DevExpress.XtraNavBar.NavBarItem();
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
            this.ribbonControl.Size = new System.Drawing.Size(888, 27);
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
            this.splitContainerControl.Size = new System.Drawing.Size(888, 487);
            this.splitContainerControl.SplitterPosition = 173;
            this.splitContainerControl.TabIndex = 1;
            // 
            // navBarControl
            // 
            this.navBarControl.ActiveGroup = this.navBarGroupDungChung;
            this.navBarControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navBarControl.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navBarControl.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroupDungChung,
            this.navBarGroupKhac,
            this.navBarGroupDuoc});
            this.navBarControl.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navBarDMBenhICDX,
            this.navBarDMCSKCB,
            this.navBarDMDonViTinh,
            this.navBarDMDuongDung,
            this.navBarDMLuongCoSo,
            this.navBarDMNuocSX,
            this.navBarDMNhaCC,
            this.navBarDMLoaiVatTu,
            this.navBarDMNhomVatTu,
            this.navBarDMVatTu});
            this.navBarControl.Location = new System.Drawing.Point(0, 0);
            this.navBarControl.Name = "navBarControl";
            this.navBarControl.OptionsNavPane.ExpandedWidth = 173;
            this.navBarControl.Size = new System.Drawing.Size(173, 487);
            this.navBarControl.TabIndex = 0;
            // 
            // navBarGroupDungChung
            // 
            this.navBarGroupDungChung.Caption = "Danh mục dùng chung";
            this.navBarGroupDungChung.Expanded = true;
            this.navBarGroupDungChung.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarDMBenhICDX),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarDMCSKCB)});
            this.navBarGroupDungChung.Name = "navBarGroupDungChung";
            this.navBarGroupDungChung.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarGroupDungChung.SmallImage")));
            // 
            // navBarDMBenhICDX
            // 
            this.navBarDMBenhICDX.Caption = "Danh mục Bệnh ICD 10";
            this.navBarDMBenhICDX.Name = "navBarDMBenhICDX";
            this.navBarDMBenhICDX.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarDMBenhICDX.SmallImage")));
            this.navBarDMBenhICDX.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarDMBenhICDX_LinkClicked);
            // 
            // navBarDMCSKCB
            // 
            this.navBarDMCSKCB.Caption = "Danh mục CSKCB";
            this.navBarDMCSKCB.Name = "navBarDMCSKCB";
            this.navBarDMCSKCB.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarDMCSKCB.SmallImage")));
            this.navBarDMCSKCB.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarDMCSKCB_LinkClicked);
            // 
            // navBarGroupKhac
            // 
            this.navBarGroupKhac.Caption = "Danh mục khác";
            this.navBarGroupKhac.Expanded = true;
            this.navBarGroupKhac.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarDMDonViTinh),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarDMDuongDung),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarDMLuongCoSo),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarDMNuocSX),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarDMNhaCC)});
            this.navBarGroupKhac.Name = "navBarGroupKhac";
            this.navBarGroupKhac.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarGroupKhac.SmallImage")));
            // 
            // navBarDMDonViTinh
            // 
            this.navBarDMDonViTinh.Caption = "Danh mục Đơn vị tính";
            this.navBarDMDonViTinh.Name = "navBarDMDonViTinh";
            this.navBarDMDonViTinh.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarDMDonViTinh.SmallImage")));
            this.navBarDMDonViTinh.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarDMDonViTinh_LinkClicked);
            // 
            // navBarDMDuongDung
            // 
            this.navBarDMDuongDung.Caption = "Danh mục Đường dùng";
            this.navBarDMDuongDung.Name = "navBarDMDuongDung";
            this.navBarDMDuongDung.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarDMDuongDung.SmallImage")));
            this.navBarDMDuongDung.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarDMDuongDung_LinkClicked);
            // 
            // navBarDMLuongCoSo
            // 
            this.navBarDMLuongCoSo.Caption = "Danh mục Lương cơ sở";
            this.navBarDMLuongCoSo.Name = "navBarDMLuongCoSo";
            this.navBarDMLuongCoSo.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarDMLuongCoSo.SmallImage")));
            this.navBarDMLuongCoSo.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarDMLuongCoSo_LinkClicked);
            // 
            // navBarDMNuocSX
            // 
            this.navBarDMNuocSX.Caption = "Danh mục Nước sản xuất";
            this.navBarDMNuocSX.Name = "navBarDMNuocSX";
            this.navBarDMNuocSX.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarDMNuocSX.SmallImage")));
            this.navBarDMNuocSX.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarDMNuocSX_LinkClicked);
            // 
            // navBarDMNhaCC
            // 
            this.navBarDMNhaCC.Caption = "Danh mục Nhà cung cấp";
            this.navBarDMNhaCC.Name = "navBarDMNhaCC";
            this.navBarDMNhaCC.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarDMNhaCC.SmallImage")));
            this.navBarDMNhaCC.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarDMNhaCC_LinkClicked);
            // 
            // navBarGroupDuoc
            // 
            this.navBarGroupDuoc.Caption = "Danh mục dược";
            this.navBarGroupDuoc.Expanded = true;
            this.navBarGroupDuoc.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarDMLoaiVatTu),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarDMNhomVatTu),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarDMVatTu)});
            this.navBarGroupDuoc.Name = "navBarGroupDuoc";
            this.navBarGroupDuoc.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarGroupDuoc.SmallImage")));
            // 
            // navBarDMLoaiVatTu
            // 
            this.navBarDMLoaiVatTu.Caption = "Danh mục Loại vật tư";
            this.navBarDMLoaiVatTu.Name = "navBarDMLoaiVatTu";
            this.navBarDMLoaiVatTu.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarDMLoaiVatTu.SmallImage")));
            this.navBarDMLoaiVatTu.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarDMLoaiVatTu_LinkClicked);
            // 
            // navBarDMNhomVatTu
            // 
            this.navBarDMNhomVatTu.Caption = "Danh mục Nhóm vật tư";
            this.navBarDMNhomVatTu.Name = "navBarDMNhomVatTu";
            this.navBarDMNhomVatTu.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarDMNhomVatTu.SmallImage")));
            this.navBarDMNhomVatTu.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarDMNhomVatTu_LinkClicked);
            // 
            // panelControl
            // 
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl.Location = new System.Drawing.Point(0, 0);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(710, 487);
            this.panelControl.TabIndex = 0;
            // 
            // navBarDMVatTu
            // 
            this.navBarDMVatTu.Caption = "Danh mục Vật tư";
            this.navBarDMVatTu.Name = "navBarDMVatTu";
            this.navBarDMVatTu.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarDMVatTu.SmallImage")));
            this.navBarDMVatTu.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarDMVatTu_LinkClicked);
            // 
            // FrmDanhMucDungChung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 514);
            this.Controls.Add(this.splitContainerControl);
            this.Controls.Add(this.ribbonControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDanhMucDungChung";
            this.Ribbon = this.ribbonControl;
            this.Text = "Danh mục dùng chung";
            this.Load += new System.EventHandler(this.FrmDanhMucKhac_Load);
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
        private DevExpress.XtraNavBar.NavBarGroup navBarGroupDungChung;
        private DevExpress.XtraNavBar.NavBarItem navBarDMBenhICDX;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroupKhac;
        private DevExpress.XtraNavBar.NavBarItem navBarDMCSKCB;
        private DevExpress.XtraNavBar.NavBarItem navBarDMDonViTinh;
        private DevExpress.XtraNavBar.NavBarItem navBarDMDuongDung;
        private DevExpress.XtraNavBar.NavBarItem navBarDMLuongCoSo;
        private DevExpress.XtraNavBar.NavBarItem navBarDMNuocSX;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroupDuoc;
        private DevExpress.XtraNavBar.NavBarItem navBarDMLoaiVatTu;
        private DevExpress.XtraNavBar.NavBarItem navBarDMNhomVatTu;
        private DevExpress.XtraNavBar.NavBarItem navBarDMNhaCC;
        private DevExpress.XtraNavBar.NavBarItem navBarDMVatTu;
    }
}