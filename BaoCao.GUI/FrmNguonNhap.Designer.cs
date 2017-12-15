namespace BaoCao.GUI
{
    partial class FrmNguonNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNguonNhap));
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.layoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.txtKhoaDuoc = new DevExpress.XtraEditors.TextEdit();
            this.txtNguoiLap = new DevExpress.XtraEditors.TextEdit();
            this.txtKeToan = new DevExpress.XtraEditors.TextEdit();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnIn = new DevExpress.XtraEditors.SimpleButton();
            this.btnTim = new DevExpress.XtraEditors.SimpleButton();
            this.cbNam = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbThang = new DevExpress.XtraEditors.ComboBoxEdit();
            this.layoutControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.STT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoPhieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayNhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoHoaDon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NguoiGiaoHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ThanhTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NhaCungCap = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
            this.layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtKhoaDuoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNguoiLap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKeToan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbNam.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbThang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
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
            this.ribbonControl.Size = new System.Drawing.Size(990, 27);
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // layoutControl
            // 
            this.layoutControl.Controls.Add(this.txtKhoaDuoc);
            this.layoutControl.Controls.Add(this.txtNguoiLap);
            this.layoutControl.Controls.Add(this.txtKeToan);
            this.layoutControl.Controls.Add(this.gridControl);
            this.layoutControl.Controls.Add(this.btnIn);
            this.layoutControl.Controls.Add(this.btnTim);
            this.layoutControl.Controls.Add(this.cbNam);
            this.layoutControl.Controls.Add(this.cbThang);
            this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl.Location = new System.Drawing.Point(0, 27);
            this.layoutControl.Name = "layoutControl";
            this.layoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(376, 260, 650, 400);
            this.layoutControl.Root = this.layoutControlGroup;
            this.layoutControl.Size = new System.Drawing.Size(990, 468);
            this.layoutControl.TabIndex = 1;
            this.layoutControl.Text = "layoutControl1";
            // 
            // txtKhoaDuoc
            // 
            this.txtKhoaDuoc.EditValue = "Cao Thị Tâm";
            this.txtKhoaDuoc.Location = new System.Drawing.Point(12, 70);
            this.txtKhoaDuoc.MenuManager = this.ribbonControl;
            this.txtKhoaDuoc.Name = "txtKhoaDuoc";
            this.txtKhoaDuoc.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKhoaDuoc.Properties.Appearance.Options.UseFont = true;
            this.txtKhoaDuoc.Size = new System.Drawing.Size(147, 22);
            this.txtKhoaDuoc.StyleController = this.layoutControl;
            this.txtKhoaDuoc.TabIndex = 11;
            // 
            // txtNguoiLap
            // 
            this.txtNguoiLap.EditValue = "Nguyễn Thị Nga";
            this.txtNguoiLap.Location = new System.Drawing.Point(12, 28);
            this.txtNguoiLap.MenuManager = this.ribbonControl;
            this.txtNguoiLap.Name = "txtNguoiLap";
            this.txtNguoiLap.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNguoiLap.Properties.Appearance.Options.UseFont = true;
            this.txtNguoiLap.Size = new System.Drawing.Size(147, 22);
            this.txtNguoiLap.StyleController = this.layoutControl;
            this.txtNguoiLap.TabIndex = 10;
            // 
            // txtKeToan
            // 
            this.txtKeToan.EditValue = "Nguyễn Thị Ái Hoa";
            this.txtKeToan.Location = new System.Drawing.Point(12, 112);
            this.txtKeToan.MenuManager = this.ribbonControl;
            this.txtKeToan.Name = "txtKeToan";
            this.txtKeToan.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKeToan.Properties.Appearance.Options.UseFont = true;
            this.txtKeToan.Size = new System.Drawing.Size(147, 22);
            this.txtKeToan.StyleController = this.layoutControl;
            this.txtKeToan.TabIndex = 9;
            // 
            // gridControl
            // 
            this.gridControl.Location = new System.Drawing.Point(163, 39);
            this.gridControl.MainView = this.gridView;
            this.gridControl.MenuManager = this.ribbonControl;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(815, 417);
            this.gridControl.TabIndex = 8;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.STT,
            this.SoPhieu,
            this.NgayNhap,
            this.SoHoaDon,
            this.NguoiGiaoHang,
            this.ThanhTien,
            this.NhaCungCap});
            this.gridView.GridControl = this.gridControl;
            this.gridView.GroupCount = 1;
            this.gridView.Name = "gridView";
            this.gridView.OptionsView.ShowGroupPanel = false;
            this.gridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.NhaCungCap, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // btnIn
            // 
            this.btnIn.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIn.Appearance.Options.UseFont = true;
            this.btnIn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnIn.ImageOptions.Image")));
            this.btnIn.Location = new System.Drawing.Point(926, 12);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(52, 23);
            this.btnIn.StyleController = this.layoutControl;
            this.btnIn.TabIndex = 7;
            this.btnIn.Text = "In";
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnTim
            // 
            this.btnTim.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Appearance.Options.UseFont = true;
            this.btnTim.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTim.ImageOptions.Image")));
            this.btnTim.Location = new System.Drawing.Point(406, 12);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(57, 23);
            this.btnTim.StyleController = this.layoutControl;
            this.btnTim.TabIndex = 6;
            this.btnTim.Text = "Tìm";
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // cbNam
            // 
            this.cbNam.Location = new System.Drawing.Point(315, 12);
            this.cbNam.MenuManager = this.ribbonControl;
            this.cbNam.Name = "cbNam";
            this.cbNam.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNam.Properties.Appearance.Options.UseFont = true;
            this.cbNam.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNam.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cbNam.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbNam.Size = new System.Drawing.Size(87, 22);
            this.cbNam.StyleController = this.layoutControl;
            this.cbNam.TabIndex = 5;
            // 
            // cbThang
            // 
            this.cbThang.Location = new System.Drawing.Point(202, 12);
            this.cbThang.MenuManager = this.ribbonControl;
            this.cbThang.Name = "cbThang";
            this.cbThang.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbThang.Properties.Appearance.Options.UseFont = true;
            this.cbThang.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbThang.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cbThang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbThang.Properties.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbThang.Size = new System.Drawing.Size(79, 22);
            this.cbThang.StyleController = this.layoutControl;
            this.cbThang.TabIndex = 4;
            // 
            // layoutControlGroup
            // 
            this.layoutControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup.GroupBordersVisible = false;
            this.layoutControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.emptySpaceItem2,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.emptySpaceItem1});
            this.layoutControlGroup.Name = "Root";
            this.layoutControlGroup.Size = new System.Drawing.Size(990, 468);
            this.layoutControlGroup.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.cbThang;
            this.layoutControlItem1.Location = new System.Drawing.Point(151, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(122, 27);
            this.layoutControlItem1.Text = "Tháng:";
            this.layoutControlItem1.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(34, 13);
            this.layoutControlItem1.TextToControlDistance = 5;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.cbNam;
            this.layoutControlItem2.Location = new System.Drawing.Point(273, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(121, 27);
            this.layoutControlItem2.Text = "Năm:";
            this.layoutControlItem2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(25, 13);
            this.layoutControlItem2.TextToControlDistance = 5;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnTim;
            this.layoutControlItem3.Location = new System.Drawing.Point(394, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(61, 27);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnIn;
            this.layoutControlItem4.Location = new System.Drawing.Point(914, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(56, 27);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(455, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(459, 27);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.gridControl;
            this.layoutControlItem5.Location = new System.Drawing.Point(151, 27);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(819, 421);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.txtKeToan;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 84);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(151, 42);
            this.layoutControlItem6.Text = "Kế toán trưởng";
            this.layoutControlItem6.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(73, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.txtNguoiLap;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(151, 42);
            this.layoutControlItem7.Text = "Người lập:";
            this.layoutControlItem7.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem7.TextSize = new System.Drawing.Size(73, 13);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.txtKhoaDuoc;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 42);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(151, 42);
            this.layoutControlItem8.Text = "TR. Khoa dược";
            this.layoutControlItem8.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem8.TextSize = new System.Drawing.Size(73, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 126);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(151, 322);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // STT
            // 
            this.STT.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STT.AppearanceCell.Options.UseFont = true;
            this.STT.Caption = "STT";
            this.STT.FieldName = "STT";
            this.STT.Name = "STT";
            this.STT.Visible = true;
            this.STT.VisibleIndex = 0;
            this.STT.Width = 41;
            // 
            // SoPhieu
            // 
            this.SoPhieu.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoPhieu.AppearanceCell.Options.UseFont = true;
            this.SoPhieu.Caption = "Số phiếu";
            this.SoPhieu.FieldName = "SoPhieu";
            this.SoPhieu.Name = "SoPhieu";
            this.SoPhieu.Visible = true;
            this.SoPhieu.VisibleIndex = 1;
            this.SoPhieu.Width = 150;
            // 
            // NgayNhap
            // 
            this.NgayNhap.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NgayNhap.AppearanceCell.Options.UseFont = true;
            this.NgayNhap.Caption = "Ngày nhập";
            this.NgayNhap.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.NgayNhap.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.NgayNhap.FieldName = "NgayNhap";
            this.NgayNhap.Name = "NgayNhap";
            this.NgayNhap.Visible = true;
            this.NgayNhap.VisibleIndex = 2;
            this.NgayNhap.Width = 150;
            // 
            // SoHoaDon
            // 
            this.SoHoaDon.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoHoaDon.AppearanceCell.Options.UseFont = true;
            this.SoHoaDon.Caption = "Số hóa đơn";
            this.SoHoaDon.FieldName = "SoHoaDon";
            this.SoHoaDon.Name = "SoHoaDon";
            this.SoHoaDon.Visible = true;
            this.SoHoaDon.VisibleIndex = 3;
            this.SoHoaDon.Width = 150;
            // 
            // NguoiGiaoHang
            // 
            this.NguoiGiaoHang.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NguoiGiaoHang.AppearanceCell.Options.UseFont = true;
            this.NguoiGiaoHang.Caption = "Người nhập";
            this.NguoiGiaoHang.FieldName = "NguoiGiaoHang";
            this.NguoiGiaoHang.Name = "NguoiGiaoHang";
            this.NguoiGiaoHang.Visible = true;
            this.NguoiGiaoHang.VisibleIndex = 4;
            this.NguoiGiaoHang.Width = 200;
            // 
            // ThanhTien
            // 
            this.ThanhTien.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThanhTien.AppearanceCell.Options.UseFont = true;
            this.ThanhTien.Caption = "Thành tiền";
            this.ThanhTien.DisplayFormat.FormatString = "#,###";
            this.ThanhTien.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.ThanhTien.FieldName = "ThanhTien";
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.Visible = true;
            this.ThanhTien.VisibleIndex = 5;
            this.ThanhTien.Width = 150;
            // 
            // NhaCungCap
            // 
            this.NhaCungCap.Caption = "Nhà cung cấp";
            this.NhaCungCap.FieldName = "NhaCungCap";
            this.NhaCungCap.Name = "NhaCungCap";
            this.NhaCungCap.Visible = true;
            this.NhaCungCap.VisibleIndex = 6;
            // 
            // FrmNguonNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 495);
            this.Controls.Add(this.layoutControl);
            this.Controls.Add(this.ribbonControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmNguonNhap";
            this.Ribbon = this.ribbonControl;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phân tích nguồn nhập";
            this.Load += new System.EventHandler(this.FrmNguonNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
            this.layoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtKhoaDuoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNguoiLap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKeToan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbNam.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbThang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraLayout.LayoutControl layoutControl;
        private DevExpress.XtraEditors.SimpleButton btnTim;
        private DevExpress.XtraEditors.ComboBoxEdit cbNam;
        private DevExpress.XtraEditors.ComboBoxEdit cbThang;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.TextEdit txtKhoaDuoc;
        private DevExpress.XtraEditors.TextEdit txtNguoiLap;
        private DevExpress.XtraEditors.TextEdit txtKeToan;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraEditors.SimpleButton btnIn;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraGrid.Columns.GridColumn STT;
        private DevExpress.XtraGrid.Columns.GridColumn SoPhieu;
        private DevExpress.XtraGrid.Columns.GridColumn NgayNhap;
        private DevExpress.XtraGrid.Columns.GridColumn SoHoaDon;
        private DevExpress.XtraGrid.Columns.GridColumn NguoiGiaoHang;
        private DevExpress.XtraGrid.Columns.GridColumn ThanhTien;
        private DevExpress.XtraGrid.Columns.GridColumn NhaCungCap;
    }
}