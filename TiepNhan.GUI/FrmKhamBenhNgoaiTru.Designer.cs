namespace TiepNhan.GUI
{
    partial class FrmKhamBenhNgoaiTru
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKhamBenhNgoaiTru));
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.layoutControlMain = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroupMain = new DevExpress.XtraLayout.LayoutControlGroup();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.checkTatCa = new DevExpress.XtraEditors.CheckEdit();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.checkChoKham = new DevExpress.XtraEditors.CheckEdit();
            this.checkDaKham = new DevExpress.XtraEditors.CheckEdit();
            this.checkChuyenTuyen = new DevExpress.XtraEditors.CheckEdit();
            this.checkNhapVien = new DevExpress.XtraEditors.CheckEdit();
            this.checkRaVien = new DevExpress.XtraEditors.CheckEdit();
            this.layoutControlItem31 = new DevExpress.XtraLayout.LayoutControlItem();
            this.flowLayoutPanelSoLuong = new System.Windows.Forms.FlowLayoutPanel();
            this.lblPhongKham = new DevExpress.XtraEditors.LabelControl();
            this.layoutControlItem32 = new DevExpress.XtraLayout.LayoutControlItem();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlMain)).BeginInit();
            this.layoutControlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupMain)).BeginInit();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkTatCa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkChoKham.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkDaKham.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkChuyenTuyen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkNhapVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkRaVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem31)).BeginInit();
            this.flowLayoutPanelSoLuong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
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
            this.ribbonControl.Size = new System.Drawing.Size(890, 27);
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // layoutControlMain
            // 
            this.layoutControlMain.Controls.Add(this.gridControl);
            this.layoutControlMain.Controls.Add(this.flowLayoutPanel3);
            this.layoutControlMain.Controls.Add(this.flowLayoutPanelSoLuong);
            this.layoutControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControlMain.Location = new System.Drawing.Point(0, 27);
            this.layoutControlMain.Name = "layoutControlMain";
            this.layoutControlMain.Root = this.layoutControlGroupMain;
            this.layoutControlMain.Size = new System.Drawing.Size(890, 468);
            this.layoutControlMain.TabIndex = 1;
            // 
            // layoutControlGroupMain
            // 
            this.layoutControlGroupMain.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroupMain.GroupBordersVisible = false;
            this.layoutControlGroupMain.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem31,
            this.layoutControlItem32,
            this.layoutControlItem1});
            this.layoutControlGroupMain.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroupMain.Name = "layoutControlGroupMain";
            this.layoutControlGroupMain.Size = new System.Drawing.Size(890, 468);
            this.layoutControlGroupMain.TextVisible = false;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.checkTatCa);
            this.flowLayoutPanel3.Controls.Add(this.checkChoKham);
            this.flowLayoutPanel3.Controls.Add(this.checkDaKham);
            this.flowLayoutPanel3.Controls.Add(this.checkChuyenTuyen);
            this.flowLayoutPanel3.Controls.Add(this.checkNhapVien);
            this.flowLayoutPanel3.Controls.Add(this.checkRaVien);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(431, 27);
            this.flowLayoutPanel3.TabIndex = 4;
            // 
            // checkTatCa
            // 
            this.checkTatCa.EditValue = true;
            this.checkTatCa.Location = new System.Drawing.Point(3, 3);
            this.checkTatCa.MenuManager = this.ribbonControl1;
            this.checkTatCa.Name = "checkTatCa";
            this.checkTatCa.Properties.Caption = "Tất cả";
            this.checkTatCa.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.checkTatCa.Properties.RadioGroupIndex = 0;
            this.checkTatCa.Size = new System.Drawing.Size(58, 19);
            this.checkTatCa.TabIndex = 0;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 1;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(1190, 25);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // checkChoKham
            // 
            this.checkChoKham.Location = new System.Drawing.Point(67, 3);
            this.checkChoKham.MenuManager = this.ribbonControl1;
            this.checkChoKham.Name = "checkChoKham";
            this.checkChoKham.Properties.Caption = "Chờ khám";
            this.checkChoKham.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.checkChoKham.Properties.RadioGroupIndex = 0;
            this.checkChoKham.Size = new System.Drawing.Size(75, 19);
            this.checkChoKham.TabIndex = 1;
            this.checkChoKham.TabStop = false;
            // 
            // checkDaKham
            // 
            this.checkDaKham.Location = new System.Drawing.Point(148, 3);
            this.checkDaKham.MenuManager = this.ribbonControl1;
            this.checkDaKham.Name = "checkDaKham";
            this.checkDaKham.Properties.Caption = "Đã khám";
            this.checkDaKham.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.checkDaKham.Properties.RadioGroupIndex = 0;
            this.checkDaKham.Size = new System.Drawing.Size(75, 19);
            this.checkDaKham.TabIndex = 2;
            this.checkDaKham.TabStop = false;
            // 
            // checkChuyenTuyen
            // 
            this.checkChuyenTuyen.Location = new System.Drawing.Point(229, 3);
            this.checkChuyenTuyen.MenuManager = this.ribbonControl1;
            this.checkChuyenTuyen.Name = "checkChuyenTuyen";
            this.checkChuyenTuyen.Properties.Caption = "Chuyển tuyến";
            this.checkChuyenTuyen.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.checkChuyenTuyen.Properties.RadioGroupIndex = 0;
            this.checkChuyenTuyen.Size = new System.Drawing.Size(101, 19);
            this.checkChuyenTuyen.TabIndex = 3;
            this.checkChuyenTuyen.TabStop = false;
            // 
            // checkNhapVien
            // 
            this.checkNhapVien.Location = new System.Drawing.Point(336, 3);
            this.checkNhapVien.MenuManager = this.ribbonControl1;
            this.checkNhapVien.Name = "checkNhapVien";
            this.checkNhapVien.Properties.Caption = "Nhập viện";
            this.checkNhapVien.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.checkNhapVien.Properties.RadioGroupIndex = 0;
            this.checkNhapVien.Size = new System.Drawing.Size(75, 19);
            this.checkNhapVien.TabIndex = 4;
            this.checkNhapVien.TabStop = false;
            // 
            // checkRaVien
            // 
            this.checkRaVien.Location = new System.Drawing.Point(3, 28);
            this.checkRaVien.MenuManager = this.ribbonControl1;
            this.checkRaVien.Name = "checkRaVien";
            this.checkRaVien.Properties.Caption = "Ra viện";
            this.checkRaVien.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.checkRaVien.Properties.RadioGroupIndex = 0;
            this.checkRaVien.Size = new System.Drawing.Size(75, 19);
            this.checkRaVien.TabIndex = 5;
            this.checkRaVien.TabStop = false;
            // 
            // layoutControlItem31
            // 
            this.layoutControlItem31.Control = this.flowLayoutPanel3;
            this.layoutControlItem31.CustomizationFormText = "layoutControlItem31";
            this.layoutControlItem31.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem31.MaxSize = new System.Drawing.Size(0, 31);
            this.layoutControlItem31.MinSize = new System.Drawing.Size(104, 31);
            this.layoutControlItem31.Name = "layoutControlItem31";
            this.layoutControlItem31.Size = new System.Drawing.Size(435, 31);
            this.layoutControlItem31.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem31.Text = "layoutControlItem31";
            this.layoutControlItem31.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem31.TextVisible = false;
            // 
            // flowLayoutPanelSoLuong
            // 
            this.flowLayoutPanelSoLuong.Controls.Add(this.lblPhongKham);
            this.flowLayoutPanelSoLuong.Location = new System.Drawing.Point(447, 12);
            this.flowLayoutPanelSoLuong.Name = "flowLayoutPanelSoLuong";
            this.flowLayoutPanelSoLuong.Size = new System.Drawing.Size(431, 27);
            this.flowLayoutPanelSoLuong.TabIndex = 5;
            // 
            // lblPhongKham
            // 
            this.lblPhongKham.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhongKham.Appearance.Options.UseFont = true;
            this.lblPhongKham.Location = new System.Drawing.Point(3, 3);
            this.lblPhongKham.Name = "lblPhongKham";
            this.lblPhongKham.Size = new System.Drawing.Size(215, 16);
            this.lblPhongKham.TabIndex = 0;
            this.lblPhongKham.Text = "Phòng khám 1 : 0 - Phòng khám 2 : 0";
            // 
            // layoutControlItem32
            // 
            this.layoutControlItem32.Control = this.flowLayoutPanelSoLuong;
            this.layoutControlItem32.CustomizationFormText = "layoutControlItem32";
            this.layoutControlItem32.Location = new System.Drawing.Point(435, 0);
            this.layoutControlItem32.MaxSize = new System.Drawing.Size(0, 31);
            this.layoutControlItem32.MinSize = new System.Drawing.Size(104, 31);
            this.layoutControlItem32.Name = "layoutControlItem32";
            this.layoutControlItem32.Size = new System.Drawing.Size(435, 31);
            this.layoutControlItem32.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem32.Text = "layoutControlItem32";
            this.layoutControlItem32.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem32.TextVisible = false;
            // 
            // gridControl
            // 
            this.gridControl.Location = new System.Drawing.Point(12, 43);
            this.gridControl.MainView = this.gridView;
            this.gridControl.MenuManager = this.ribbonControl;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(866, 413);
            this.gridControl.TabIndex = 6;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 31);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(870, 417);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // FrmKhamBenhNgoaiTru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 495);
            this.Controls.Add(this.layoutControlMain);
            this.Controls.Add(this.ribbonControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmKhamBenhNgoaiTru";
            this.Ribbon = this.ribbonControl;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khám bệnh ngoại trú";
            this.Load += new System.EventHandler(this.FrmKhamBenhNgoaiTru_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlMain)).EndInit();
            this.layoutControlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupMain)).EndInit();
            this.flowLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkTatCa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkChoKham.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkDaKham.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkChuyenTuyen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkNhapVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkRaVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem31)).EndInit();
            this.flowLayoutPanelSoLuong.ResumeLayout(false);
            this.flowLayoutPanelSoLuong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraLayout.LayoutControl layoutControlMain;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroupMain;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private DevExpress.XtraEditors.CheckEdit checkTatCa;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraEditors.CheckEdit checkChoKham;
        private DevExpress.XtraEditors.CheckEdit checkDaKham;
        private DevExpress.XtraEditors.CheckEdit checkChuyenTuyen;
        private DevExpress.XtraEditors.CheckEdit checkNhapVien;
        private DevExpress.XtraEditors.CheckEdit checkRaVien;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem31;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelSoLuong;
        private DevExpress.XtraEditors.LabelControl lblPhongKham;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem32;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}