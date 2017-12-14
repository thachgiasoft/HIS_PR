namespace BaoCao.GUI
{
    partial class FrmBCTonKho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBCTonKho));
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.layoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.gridControlDC = new DevExpress.XtraGrid.GridControl();
            this.gridViewDC = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HoTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ChucVu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.STT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaBV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenVatTu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DonViTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoLuongTon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Ten = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnIn = new DevExpress.XtraEditors.SimpleButton();
            this.btnTim = new DevExpress.XtraEditors.SimpleButton();
            this.dateNgay = new DevExpress.XtraEditors.DateEdit();
            this.layoutControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
            this.layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
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
            this.ribbonControl.Size = new System.Drawing.Size(892, 27);
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // layoutControl
            // 
            this.layoutControl.Controls.Add(this.gridControlDC);
            this.layoutControl.Controls.Add(this.gridControl);
            this.layoutControl.Controls.Add(this.btnIn);
            this.layoutControl.Controls.Add(this.btnTim);
            this.layoutControl.Controls.Add(this.dateNgay);
            this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl.Location = new System.Drawing.Point(0, 27);
            this.layoutControl.Name = "layoutControl";
            this.layoutControl.Root = this.layoutControlGroup;
            this.layoutControl.Size = new System.Drawing.Size(892, 469);
            this.layoutControl.TabIndex = 1;
            this.layoutControl.Text = "layoutControl1";
            // 
            // gridControlDC
            // 
            this.gridControlDC.Location = new System.Drawing.Point(12, 12);
            this.gridControlDC.MainView = this.gridViewDC;
            this.gridControlDC.MenuManager = this.ribbonControl;
            this.gridControlDC.Name = "gridControlDC";
            this.gridControlDC.Size = new System.Drawing.Size(237, 445);
            this.gridControlDC.TabIndex = 10;
            this.gridControlDC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDC});
            // 
            // gridViewDC
            // 
            this.gridViewDC.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Id,
            this.HoTen,
            this.ChucVu});
            this.gridViewDC.GridControl = this.gridControlDC;
            this.gridViewDC.Name = "gridViewDC";
            this.gridViewDC.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridViewDC.OptionsView.ShowGroupPanel = false;
            // 
            // Id
            // 
            this.Id.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id.AppearanceCell.Options.UseFont = true;
            this.Id.Caption = "Id";
            this.Id.FieldName = "Id";
            this.Id.Name = "Id";
            this.Id.OptionsColumn.AllowEdit = false;
            this.Id.Visible = true;
            this.Id.VisibleIndex = 0;
            this.Id.Width = 20;
            // 
            // HoTen
            // 
            this.HoTen.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoTen.AppearanceCell.Options.UseFont = true;
            this.HoTen.Caption = "Họ tên";
            this.HoTen.FieldName = "HoTen";
            this.HoTen.Name = "HoTen";
            this.HoTen.Visible = true;
            this.HoTen.VisibleIndex = 1;
            this.HoTen.Width = 98;
            // 
            // ChucVu
            // 
            this.ChucVu.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChucVu.AppearanceCell.Options.UseFont = true;
            this.ChucVu.Caption = "Chức vụ";
            this.ChucVu.FieldName = "ChucVu";
            this.ChucVu.Name = "ChucVu";
            this.ChucVu.Visible = true;
            this.ChucVu.VisibleIndex = 2;
            this.ChucVu.Width = 101;
            // 
            // gridControl
            // 
            this.gridControl.Location = new System.Drawing.Point(253, 39);
            this.gridControl.MainView = this.gridView;
            this.gridControl.MenuManager = this.ribbonControl;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(627, 418);
            this.gridControl.TabIndex = 9;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.STT,
            this.MaBV,
            this.TenVatTu,
            this.DonViTinh,
            this.SoLuongTon,
            this.Ten});
            this.gridView.GridControl = this.gridControl;
            this.gridView.GroupCount = 1;
            this.gridView.Name = "gridView";
            this.gridView.OptionsView.ShowGroupPanel = false;
            this.gridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.Ten, DevExpress.Data.ColumnSortOrder.Ascending)});
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
            this.STT.Width = 51;
            // 
            // MaBV
            // 
            this.MaBV.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaBV.AppearanceCell.Options.UseFont = true;
            this.MaBV.Caption = "Mã vật tư";
            this.MaBV.FieldName = "MaBV";
            this.MaBV.Name = "MaBV";
            this.MaBV.Visible = true;
            this.MaBV.VisibleIndex = 1;
            this.MaBV.Width = 88;
            // 
            // TenVatTu
            // 
            this.TenVatTu.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenVatTu.AppearanceCell.Options.UseFont = true;
            this.TenVatTu.Caption = "Tên vật tư";
            this.TenVatTu.FieldName = "TenVatTu";
            this.TenVatTu.Name = "TenVatTu";
            this.TenVatTu.Visible = true;
            this.TenVatTu.VisibleIndex = 2;
            this.TenVatTu.Width = 276;
            // 
            // DonViTinh
            // 
            this.DonViTinh.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonViTinh.AppearanceCell.Options.UseFont = true;
            this.DonViTinh.Caption = "Đơn vị";
            this.DonViTinh.FieldName = "DonViTinh";
            this.DonViTinh.Name = "DonViTinh";
            this.DonViTinh.Visible = true;
            this.DonViTinh.VisibleIndex = 3;
            this.DonViTinh.Width = 80;
            // 
            // SoLuongTon
            // 
            this.SoLuongTon.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoLuongTon.AppearanceCell.Options.UseFont = true;
            this.SoLuongTon.Caption = "Số lượng";
            this.SoLuongTon.DisplayFormat.FormatString = "#,###";
            this.SoLuongTon.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.SoLuongTon.FieldName = "SoLuongTon";
            this.SoLuongTon.Name = "SoLuongTon";
            this.SoLuongTon.Visible = true;
            this.SoLuongTon.VisibleIndex = 4;
            this.SoLuongTon.Width = 114;
            // 
            // Ten
            // 
            this.Ten.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ten.AppearanceCell.Options.UseFont = true;
            this.Ten.Caption = "Loại vật tư";
            this.Ten.FieldName = "Ten";
            this.Ten.Name = "Ten";
            this.Ten.Visible = true;
            this.Ten.VisibleIndex = 4;
            this.Ten.Width = 139;
            // 
            // btnIn
            // 
            this.btnIn.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIn.Appearance.Options.UseFont = true;
            this.btnIn.ImageOptions.ImageUri.Uri = "Print;Size16x16";
            this.btnIn.Location = new System.Drawing.Point(822, 12);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(58, 23);
            this.btnIn.StyleController = this.layoutControl;
            this.btnIn.TabIndex = 8;
            this.btnIn.Text = "In";
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnTim
            // 
            this.btnTim.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Appearance.Options.UseFont = true;
            this.btnTim.ImageOptions.ImageUri.Uri = "Zoom;Size16x16";
            this.btnTim.Location = new System.Drawing.Point(378, 12);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(58, 23);
            this.btnTim.StyleController = this.layoutControl;
            this.btnTim.TabIndex = 7;
            this.btnTim.Text = "Tìm";
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // dateNgay
            // 
            this.dateNgay.EditValue = null;
            this.dateNgay.Location = new System.Drawing.Point(285, 12);
            this.dateNgay.MenuManager = this.ribbonControl;
            this.dateNgay.Name = "dateNgay";
            this.dateNgay.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNgay.Properties.Appearance.Options.UseFont = true;
            this.dateNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgay.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dateNgay.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateNgay.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dateNgay.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateNgay.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dateNgay.Properties.ReadOnly = true;
            this.dateNgay.Size = new System.Drawing.Size(89, 22);
            this.dateNgay.StyleController = this.layoutControl;
            this.dateNgay.TabIndex = 6;
            // 
            // layoutControlGroup
            // 
            this.layoutControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup.GroupBordersVisible = false;
            this.layoutControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem1,
            this.emptySpaceItem1});
            this.layoutControlGroup.Name = "layoutControlGroup";
            this.layoutControlGroup.Size = new System.Drawing.Size(892, 469);
            this.layoutControlGroup.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.dateNgay;
            this.layoutControlItem3.Location = new System.Drawing.Point(241, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(125, 27);
            this.layoutControlItem3.Text = "Ngày:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(29, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnTim;
            this.layoutControlItem4.Location = new System.Drawing.Point(366, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(62, 27);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnIn;
            this.layoutControlItem5.Location = new System.Drawing.Point(810, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(62, 27);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.gridControl;
            this.layoutControlItem6.Location = new System.Drawing.Point(241, 27);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(631, 422);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControlDC;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(241, 449);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(428, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(382, 27);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // FrmBCTonKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 496);
            this.Controls.Add(this.layoutControl);
            this.Controls.Add(this.ribbonControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmBCTonKho";
            this.Ribbon = this.ribbonControl;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kiểm kê Thuốc - Y dụng cụ";
            this.Load += new System.EventHandler(this.FrmBCTonKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
            this.layoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraLayout.LayoutControl layoutControl;
        private DevExpress.XtraEditors.DateEdit dateNgay;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.SimpleButton btnTim;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.SimpleButton btnIn;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraGrid.GridControl gridControlDC;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDC;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraGrid.Columns.GridColumn HoTen;
        private DevExpress.XtraGrid.Columns.GridColumn ChucVu;
        private DevExpress.XtraGrid.Columns.GridColumn STT;
        private DevExpress.XtraGrid.Columns.GridColumn MaBV;
        private DevExpress.XtraGrid.Columns.GridColumn TenVatTu;
        private DevExpress.XtraGrid.Columns.GridColumn DonViTinh;
        private DevExpress.XtraGrid.Columns.GridColumn SoLuongTon;
        private DevExpress.XtraGrid.Columns.GridColumn Ten;
    }
}