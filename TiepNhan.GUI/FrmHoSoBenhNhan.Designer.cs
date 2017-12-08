namespace TiepNhan.GUI
{
    partial class FrmHoSoBenhNhan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHoSoBenhNhan));
            this.layoutControlMain = new DevExpress.XtraLayout.LayoutControl();
            this.btnBHYT = new DevExpress.XtraEditors.SimpleButton();
            this.btnTim = new DevExpress.XtraEditors.SimpleButton();
            this.dateDenNgay = new DevExpress.XtraEditors.DateEdit();
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.dateTuNgay = new DevExpress.XtraEditors.DateEdit();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Chon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repCheck = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.HoTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GioiTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NamSinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CoThe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaThe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenBenh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayVao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayRa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayThanhToan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TienBNCCT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TienBHTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TongChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DaGui = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroupMain = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlMain)).BeginInit();
            this.layoutControlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateDenNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDenNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTuNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTuNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControlMain
            // 
            this.layoutControlMain.Controls.Add(this.btnBHYT);
            this.layoutControlMain.Controls.Add(this.btnTim);
            this.layoutControlMain.Controls.Add(this.dateDenNgay);
            this.layoutControlMain.Controls.Add(this.dateTuNgay);
            this.layoutControlMain.Controls.Add(this.gridControl);
            this.layoutControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControlMain.Location = new System.Drawing.Point(0, 27);
            this.layoutControlMain.Name = "layoutControlMain";
            this.layoutControlMain.Root = this.layoutControlGroupMain;
            this.layoutControlMain.Size = new System.Drawing.Size(934, 384);
            this.layoutControlMain.TabIndex = 0;
            this.layoutControlMain.Text = "layoutControl1";
            // 
            // btnBHYT
            // 
            this.btnBHYT.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBHYT.Appearance.Options.UseFont = true;
            this.btnBHYT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBHYT.ImageOptions.Image")));
            this.btnBHYT.Location = new System.Drawing.Point(841, 12);
            this.btnBHYT.Name = "btnBHYT";
            this.btnBHYT.Size = new System.Drawing.Size(81, 23);
            this.btnBHYT.StyleController = this.layoutControlMain;
            this.btnBHYT.TabIndex = 8;
            this.btnBHYT.Text = "Gửi BHYT";
            this.btnBHYT.Click += new System.EventHandler(this.btnBHYT_Click);
            // 
            // btnTim
            // 
            this.btnTim.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Appearance.Options.UseFont = true;
            this.btnTim.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTim.ImageOptions.Image")));
            this.btnTim.Location = new System.Drawing.Point(319, 12);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(51, 23);
            this.btnTim.StyleController = this.layoutControlMain;
            this.btnTim.TabIndex = 7;
            this.btnTim.Text = "Tìm";
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // dateDenNgay
            // 
            this.dateDenNgay.EditValue = null;
            this.dateDenNgay.Location = new System.Drawing.Point(245, 12);
            this.dateDenNgay.MenuManager = this.ribbonControl;
            this.dateDenNgay.Name = "dateDenNgay";
            this.dateDenNgay.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDenNgay.Properties.Appearance.Options.UseFont = true;
            this.dateDenNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateDenNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateDenNgay.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dateDenNgay.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateDenNgay.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dateDenNgay.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateDenNgay.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dateDenNgay.Size = new System.Drawing.Size(70, 22);
            this.dateDenNgay.StyleController = this.layoutControlMain;
            this.dateDenNgay.TabIndex = 6;
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
            this.ribbonControl.Size = new System.Drawing.Size(934, 27);
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // dateTuNgay
            // 
            this.dateTuNgay.EditValue = null;
            this.dateTuNgay.Location = new System.Drawing.Point(117, 12);
            this.dateTuNgay.MenuManager = this.ribbonControl;
            this.dateTuNgay.Name = "dateTuNgay";
            this.dateTuNgay.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTuNgay.Properties.Appearance.Options.UseFont = true;
            this.dateTuNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateTuNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateTuNgay.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dateTuNgay.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateTuNgay.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dateTuNgay.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateTuNgay.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dateTuNgay.Size = new System.Drawing.Size(70, 22);
            this.dateTuNgay.StyleController = this.layoutControlMain;
            this.dateTuNgay.TabIndex = 5;
            // 
            // gridControl
            // 
            this.gridControl.Location = new System.Drawing.Point(12, 39);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repCheck});
            this.gridControl.Size = new System.Drawing.Size(910, 333);
            this.gridControl.TabIndex = 4;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Chon,
            this.HoTen,
            this.GioiTinh,
            this.NamSinh,
            this.DiaChi,
            this.CoThe,
            this.MaThe,
            this.TenBenh,
            this.NgayVao,
            this.NgayRa,
            this.NgayThanhToan,
            this.TienBNCCT,
            this.TienBHTT,
            this.TongChi,
            this.DaGui});
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsCustomization.AllowMergedGrouping = DevExpress.Utils.DefaultBoolean.True;
            this.gridView.OptionsFind.AlwaysVisible = true;
            this.gridView.OptionsFind.FindNullPrompt = "Nhập thông tin cần tìm";
            this.gridView.OptionsView.ShowAutoFilterRow = true;
            this.gridView.OptionsView.ShowGroupPanel = false;
            this.gridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.NamSinh, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.HoTen, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.GioiTinh, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // Chon
            // 
            this.Chon.Caption = "Chọn";
            this.Chon.ColumnEdit = this.repCheck;
            this.Chon.FieldName = "Chon";
            this.Chon.Name = "Chon";
            this.Chon.OptionsColumn.FixedWidth = true;
            this.Chon.Visible = true;
            this.Chon.VisibleIndex = 0;
            this.Chon.Width = 35;
            // 
            // repCheck
            // 
            this.repCheck.AutoHeight = false;
            this.repCheck.Name = "repCheck";
            // 
            // HoTen
            // 
            this.HoTen.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoTen.AppearanceCell.Options.UseFont = true;
            this.HoTen.Caption = "Họ tên";
            this.HoTen.FieldName = "HoTen";
            this.HoTen.Name = "HoTen";
            this.HoTen.OptionsColumn.AllowEdit = false;
            this.HoTen.Visible = true;
            this.HoTen.VisibleIndex = 1;
            this.HoTen.Width = 120;
            // 
            // GioiTinh
            // 
            this.GioiTinh.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GioiTinh.AppearanceCell.Options.UseFont = true;
            this.GioiTinh.Caption = "GT";
            this.GioiTinh.FieldName = "GioiTinh";
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.OptionsColumn.AllowEdit = false;
            this.GioiTinh.OptionsColumn.FixedWidth = true;
            this.GioiTinh.Visible = true;
            this.GioiTinh.VisibleIndex = 2;
            this.GioiTinh.Width = 35;
            // 
            // NamSinh
            // 
            this.NamSinh.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NamSinh.AppearanceCell.Options.UseFont = true;
            this.NamSinh.Caption = "Năm sinh";
            this.NamSinh.FieldName = "NgaySinh";
            this.NamSinh.Name = "NamSinh";
            this.NamSinh.OptionsColumn.AllowEdit = false;
            this.NamSinh.Visible = true;
            this.NamSinh.VisibleIndex = 3;
            this.NamSinh.Width = 50;
            // 
            // DiaChi
            // 
            this.DiaChi.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiaChi.AppearanceCell.Options.UseFont = true;
            this.DiaChi.Caption = "Địa chỉ";
            this.DiaChi.FieldName = "DiaChi";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.OptionsColumn.AllowEdit = false;
            this.DiaChi.Visible = true;
            this.DiaChi.VisibleIndex = 4;
            this.DiaChi.Width = 133;
            // 
            // CoThe
            // 
            this.CoThe.Caption = "CoThe";
            this.CoThe.FieldName = "CoThe";
            this.CoThe.Name = "CoThe";
            // 
            // MaThe
            // 
            this.MaThe.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaThe.AppearanceCell.Options.UseFont = true;
            this.MaThe.Caption = "Thẻ BHYT";
            this.MaThe.FieldName = "MaThe";
            this.MaThe.Name = "MaThe";
            this.MaThe.OptionsColumn.AllowEdit = false;
            this.MaThe.Visible = true;
            this.MaThe.VisibleIndex = 5;
            this.MaThe.Width = 80;
            // 
            // TenBenh
            // 
            this.TenBenh.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenBenh.AppearanceCell.Options.UseFont = true;
            this.TenBenh.Caption = "Tên bệnh";
            this.TenBenh.FieldName = "TenBenh";
            this.TenBenh.Name = "TenBenh";
            this.TenBenh.OptionsColumn.AllowEdit = false;
            this.TenBenh.Visible = true;
            this.TenBenh.VisibleIndex = 6;
            this.TenBenh.Width = 99;
            // 
            // NgayVao
            // 
            this.NgayVao.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NgayVao.AppearanceCell.Options.UseFont = true;
            this.NgayVao.Caption = "Ngày Vào";
            this.NgayVao.FieldName = "NgayVao";
            this.NgayVao.Name = "NgayVao";
            this.NgayVao.OptionsColumn.AllowEdit = false;
            this.NgayVao.Visible = true;
            this.NgayVao.VisibleIndex = 7;
            this.NgayVao.Width = 50;
            // 
            // NgayRa
            // 
            this.NgayRa.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NgayRa.AppearanceCell.Options.UseFont = true;
            this.NgayRa.Caption = "Ngày Ra";
            this.NgayRa.FieldName = "NgayRa";
            this.NgayRa.Name = "NgayRa";
            this.NgayRa.OptionsColumn.AllowEdit = false;
            this.NgayRa.Visible = true;
            this.NgayRa.VisibleIndex = 8;
            this.NgayRa.Width = 50;
            // 
            // NgayThanhToan
            // 
            this.NgayThanhToan.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NgayThanhToan.AppearanceCell.Options.UseFont = true;
            this.NgayThanhToan.Caption = "Ngày TT";
            this.NgayThanhToan.FieldName = "NgayThanhToan";
            this.NgayThanhToan.Name = "NgayThanhToan";
            this.NgayThanhToan.OptionsColumn.AllowEdit = false;
            this.NgayThanhToan.Visible = true;
            this.NgayThanhToan.VisibleIndex = 9;
            this.NgayThanhToan.Width = 50;
            // 
            // TienBNCCT
            // 
            this.TienBNCCT.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TienBNCCT.AppearanceCell.Options.UseFont = true;
            this.TienBNCCT.Caption = "BNCCT";
            this.TienBNCCT.FieldName = "TienBNCCT";
            this.TienBNCCT.Name = "TienBNCCT";
            this.TienBNCCT.OptionsColumn.AllowEdit = false;
            this.TienBNCCT.Visible = true;
            this.TienBNCCT.VisibleIndex = 10;
            this.TienBNCCT.Width = 50;
            // 
            // TienBHTT
            // 
            this.TienBHTT.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TienBHTT.AppearanceCell.Options.UseFont = true;
            this.TienBHTT.Caption = "BHTT";
            this.TienBHTT.FieldName = "TienBHTT";
            this.TienBHTT.Name = "TienBHTT";
            this.TienBHTT.OptionsColumn.AllowEdit = false;
            this.TienBHTT.Visible = true;
            this.TienBHTT.VisibleIndex = 11;
            this.TienBHTT.Width = 50;
            // 
            // TongChi
            // 
            this.TongChi.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TongChi.AppearanceCell.Options.UseFont = true;
            this.TongChi.Caption = "Tổng chi";
            this.TongChi.FieldName = "TongChi";
            this.TongChi.Name = "TongChi";
            this.TongChi.OptionsColumn.AllowEdit = false;
            this.TongChi.Visible = true;
            this.TongChi.VisibleIndex = 12;
            this.TongChi.Width = 50;
            // 
            // DaGui
            // 
            this.DaGui.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DaGui.AppearanceCell.Options.UseFont = true;
            this.DaGui.Caption = "Đã gửi";
            this.DaGui.FieldName = "DaGui";
            this.DaGui.Name = "DaGui";
            this.DaGui.OptionsColumn.AllowEdit = false;
            this.DaGui.OptionsColumn.FixedWidth = true;
            this.DaGui.Visible = true;
            this.DaGui.VisibleIndex = 13;
            this.DaGui.Width = 40;
            // 
            // layoutControlGroupMain
            // 
            this.layoutControlGroupMain.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroupMain.GroupBordersVisible = false;
            this.layoutControlGroupMain.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.emptySpaceItem1,
            this.layoutControlItem5});
            this.layoutControlGroupMain.Name = "layoutControlGroupMain";
            this.layoutControlGroupMain.Size = new System.Drawing.Size(934, 384);
            this.layoutControlGroupMain.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 27);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(914, 337);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.dateTuNgay;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(179, 27);
            this.layoutControlItem2.Text = "Thanh toán từ ngày:";
            this.layoutControlItem2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(100, 13);
            this.layoutControlItem2.TextToControlDistance = 5;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.dateDenNgay;
            this.layoutControlItem3.Location = new System.Drawing.Point(179, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(128, 27);
            this.layoutControlItem3.Text = "đến ngày:";
            this.layoutControlItem3.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(49, 13);
            this.layoutControlItem3.TextToControlDistance = 5;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnTim;
            this.layoutControlItem4.Location = new System.Drawing.Point(307, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(55, 27);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(362, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(467, 27);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnBHYT;
            this.layoutControlItem5.Location = new System.Drawing.Point(829, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(85, 27);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // FrmHoSoBenhNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 411);
            this.Controls.Add(this.layoutControlMain);
            this.Controls.Add(this.ribbonControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmHoSoBenhNhan";
            this.Ribbon = this.ribbonControl;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hồ sơ bệnh nhân";
            this.Load += new System.EventHandler(this.FrmHoSoBenhNhan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlMain)).EndInit();
            this.layoutControlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dateDenNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDenNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTuNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTuNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControlMain;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroupMain;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn HoTen;
        private DevExpress.XtraGrid.Columns.GridColumn GioiTinh;
        private DevExpress.XtraGrid.Columns.GridColumn NamSinh;
        private DevExpress.XtraGrid.Columns.GridColumn DiaChi;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraEditors.SimpleButton btnTim;
        private DevExpress.XtraEditors.DateEdit dateDenNgay;
        private DevExpress.XtraEditors.DateEdit dateTuNgay;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraGrid.Columns.GridColumn CoThe;
        private DevExpress.XtraGrid.Columns.GridColumn MaThe;
        private DevExpress.XtraGrid.Columns.GridColumn TenBenh;
        private DevExpress.XtraGrid.Columns.GridColumn NgayVao;
        private DevExpress.XtraGrid.Columns.GridColumn NgayRa;
        private DevExpress.XtraGrid.Columns.GridColumn NgayThanhToan;
        private DevExpress.XtraGrid.Columns.GridColumn TienBNCCT;
        private DevExpress.XtraGrid.Columns.GridColumn TienBHTT;
        private DevExpress.XtraGrid.Columns.GridColumn TongChi;
        private DevExpress.XtraGrid.Columns.GridColumn DaGui;
        private DevExpress.XtraGrid.Columns.GridColumn Chon;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repCheck;
        private DevExpress.XtraEditors.SimpleButton btnBHYT;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    }
}