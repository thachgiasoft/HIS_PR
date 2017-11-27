﻿namespace TiepNhan.GUI
{
    partial class FrmGiuongBenh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGiuongBenh));
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.layoutControlMain = new DevExpress.XtraLayout.LayoutControl();
            this.btnDong = new DevExpress.XtraEditors.SimpleButton();
            this.btnChon = new DevExpress.XtraEditors.SimpleButton();
            this.txtSoGiuong = new DevExpress.XtraEditors.TextEdit();
            this.cbLoaiGiuong = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtSoNgay = new System.Windows.Forms.NumericUpDown();
            this.dateNgayYLenh = new DevExpress.XtraEditors.DateEdit();
            this.lookUpGiuong = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaGiuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenGiuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DonGiaGiuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaNhomGiuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroupMain = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlMain)).BeginInit();
            this.layoutControlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoGiuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbLoaiGiuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoNgay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayYLenh.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayYLenh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpGiuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
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
            this.ribbonControl.Size = new System.Drawing.Size(784, 27);
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // layoutControlMain
            // 
            this.layoutControlMain.Controls.Add(this.gridControl);
            this.layoutControlMain.Controls.Add(this.btnDong);
            this.layoutControlMain.Controls.Add(this.btnChon);
            this.layoutControlMain.Controls.Add(this.txtSoGiuong);
            this.layoutControlMain.Controls.Add(this.cbLoaiGiuong);
            this.layoutControlMain.Controls.Add(this.txtSoNgay);
            this.layoutControlMain.Controls.Add(this.dateNgayYLenh);
            this.layoutControlMain.Controls.Add(this.lookUpGiuong);
            this.layoutControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControlMain.Location = new System.Drawing.Point(0, 27);
            this.layoutControlMain.Name = "layoutControlMain";
            this.layoutControlMain.Root = this.layoutControlGroupMain;
            this.layoutControlMain.Size = new System.Drawing.Size(784, 384);
            this.layoutControlMain.TabIndex = 1;
            this.layoutControlMain.Text = "layoutControl1";
            // 
            // btnDong
            // 
            this.btnDong.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.Appearance.Options.UseFont = true;
            this.btnDong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.ImageOptions.Image")));
            this.btnDong.Location = new System.Drawing.Point(704, 38);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(68, 23);
            this.btnDong.StyleController = this.layoutControlMain;
            this.btnDong.TabIndex = 11;
            this.btnDong.Text = "Đóng";
            // 
            // btnChon
            // 
            this.btnChon.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChon.Appearance.Options.UseFont = true;
            this.btnChon.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnChon.ImageOptions.Image")));
            this.btnChon.Location = new System.Drawing.Point(632, 38);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(68, 23);
            this.btnChon.StyleController = this.layoutControlMain;
            this.btnChon.TabIndex = 10;
            this.btnChon.Text = "Chọn";
            // 
            // txtSoGiuong
            // 
            this.txtSoGiuong.Location = new System.Drawing.Point(521, 38);
            this.txtSoGiuong.MenuManager = this.ribbonControl;
            this.txtSoGiuong.Name = "txtSoGiuong";
            this.txtSoGiuong.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoGiuong.Properties.Appearance.Options.UseFont = true;
            this.txtSoGiuong.Properties.Mask.BeepOnError = true;
            this.txtSoGiuong.Properties.Mask.EditMask = "[0-9][0-9][1-9]";
            this.txtSoGiuong.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtSoGiuong.Size = new System.Drawing.Size(107, 22);
            this.txtSoGiuong.StyleController = this.layoutControlMain;
            this.txtSoGiuong.TabIndex = 9;
            this.txtSoGiuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoGiuong_KeyPress);
            // 
            // cbLoaiGiuong
            // 
            this.cbLoaiGiuong.Location = new System.Drawing.Point(294, 38);
            this.cbLoaiGiuong.MenuManager = this.ribbonControl;
            this.cbLoaiGiuong.Name = "cbLoaiGiuong";
            this.cbLoaiGiuong.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoaiGiuong.Properties.Appearance.Options.UseFont = true;
            this.cbLoaiGiuong.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoaiGiuong.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cbLoaiGiuong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbLoaiGiuong.Properties.Items.AddRange(new object[] {
            "H. Giường kế hoạch",
            "T. Giường kê thêm",
            "C. Giường tự chọn",
            "K. Loại giường khác"});
            this.cbLoaiGiuong.Size = new System.Drawing.Size(223, 22);
            this.cbLoaiGiuong.StyleController = this.layoutControlMain;
            this.cbLoaiGiuong.TabIndex = 8;
            this.cbLoaiGiuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbLoaiGiuong_KeyPress);
            // 
            // txtSoNgay
            // 
            this.txtSoNgay.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoNgay.Location = new System.Drawing.Point(76, 38);
            this.txtSoNgay.Name = "txtSoNgay";
            this.txtSoNgay.Size = new System.Drawing.Size(150, 23);
            this.txtSoNgay.TabIndex = 6;
            this.txtSoNgay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoNgay_KeyPress);
            // 
            // dateNgayYLenh
            // 
            this.dateNgayYLenh.EditValue = null;
            this.dateNgayYLenh.Location = new System.Drawing.Point(76, 12);
            this.dateNgayYLenh.MenuManager = this.ribbonControl;
            this.dateNgayYLenh.Name = "dateNgayYLenh";
            this.dateNgayYLenh.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNgayYLenh.Properties.Appearance.Options.UseFont = true;
            this.dateNgayYLenh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgayYLenh.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgayYLenh.Properties.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm";
            this.dateNgayYLenh.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateNgayYLenh.Properties.EditFormat.FormatString = "dd/MM/yyyy HH:mm";
            this.dateNgayYLenh.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateNgayYLenh.Properties.Mask.EditMask = "dd/MM/yyyy HH:mm";
            this.dateNgayYLenh.Size = new System.Drawing.Size(150, 22);
            this.dateNgayYLenh.StyleController = this.layoutControlMain;
            this.dateNgayYLenh.TabIndex = 4;
            // 
            // lookUpGiuong
            // 
            this.lookUpGiuong.Location = new System.Drawing.Point(294, 12);
            this.lookUpGiuong.MenuManager = this.ribbonControl;
            this.lookUpGiuong.Name = "lookUpGiuong";
            this.lookUpGiuong.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookUpGiuong.Properties.Appearance.Options.UseFont = true;
            this.lookUpGiuong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpGiuong.Properties.NullText = "";
            this.lookUpGiuong.Properties.PopupView = this.searchLookUpEdit1View;
            this.lookUpGiuong.Size = new System.Drawing.Size(478, 22);
            this.lookUpGiuong.StyleController = this.layoutControlMain;
            this.lookUpGiuong.TabIndex = 5;
            this.lookUpGiuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lookUpGiuong_KeyPress);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaGiuong,
            this.TenGiuong,
            this.DonGiaGiuong,
            this.MaNhomGiuong});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // MaGiuong
            // 
            this.MaGiuong.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaGiuong.AppearanceCell.Options.UseFont = true;
            this.MaGiuong.Caption = "Mã";
            this.MaGiuong.FieldName = "Ma";
            this.MaGiuong.Name = "MaGiuong";
            this.MaGiuong.OptionsColumn.AllowEdit = false;
            this.MaGiuong.Visible = true;
            this.MaGiuong.VisibleIndex = 0;
            this.MaGiuong.Width = 60;
            // 
            // TenGiuong
            // 
            this.TenGiuong.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenGiuong.AppearanceCell.Options.UseFont = true;
            this.TenGiuong.Caption = "Tên";
            this.TenGiuong.FieldName = "Ten";
            this.TenGiuong.Name = "TenGiuong";
            this.TenGiuong.OptionsColumn.AllowEdit = false;
            this.TenGiuong.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.TenGiuong.Visible = true;
            this.TenGiuong.VisibleIndex = 1;
            this.TenGiuong.Width = 249;
            // 
            // DonGiaGiuong
            // 
            this.DonGiaGiuong.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonGiaGiuong.AppearanceCell.Options.UseFont = true;
            this.DonGiaGiuong.Caption = "Đơn giá";
            this.DonGiaGiuong.DisplayFormat.FormatString = "#,###";
            this.DonGiaGiuong.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.DonGiaGiuong.FieldName = "DonGia";
            this.DonGiaGiuong.Name = "DonGiaGiuong";
            this.DonGiaGiuong.OptionsColumn.AllowEdit = false;
            this.DonGiaGiuong.Visible = true;
            this.DonGiaGiuong.VisibleIndex = 2;
            this.DonGiaGiuong.Width = 60;
            // 
            // MaNhomGiuong
            // 
            this.MaNhomGiuong.Caption = "MaNhom";
            this.MaNhomGiuong.FieldName = "MaNhom";
            this.MaNhomGiuong.Name = "MaNhomGiuong";
            // 
            // layoutControlGroupMain
            // 
            this.layoutControlGroupMain.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroupMain.GroupBordersVisible = false;
            this.layoutControlGroupMain.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem4,
            this.layoutControlItem7,
            this.layoutControlItem8});
            this.layoutControlGroupMain.Name = "layoutControlGroupMain";
            this.layoutControlGroupMain.Size = new System.Drawing.Size(784, 384);
            this.layoutControlGroupMain.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.dateNgayYLenh;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(218, 26);
            this.layoutControlItem1.Text = "Ngày Y lệnh:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(61, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.lookUpGiuong;
            this.layoutControlItem2.Location = new System.Drawing.Point(218, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(546, 26);
            this.layoutControlItem2.Text = "Loại giường:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(61, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtSoNgay;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(218, 27);
            this.layoutControlItem3.Text = "Số ngày:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(61, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.cbLoaiGiuong;
            this.layoutControlItem5.Location = new System.Drawing.Point(218, 26);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(291, 27);
            this.layoutControlItem5.Text = "Giường:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(61, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.txtSoGiuong;
            this.layoutControlItem6.Location = new System.Drawing.Point(509, 26);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(111, 27);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnChon;
            this.layoutControlItem4.Location = new System.Drawing.Point(620, 26);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(72, 27);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.btnDong;
            this.layoutControlItem7.Location = new System.Drawing.Point(692, 26);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(72, 27);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // gridControl
            // 
            this.gridControl.Location = new System.Drawing.Point(12, 65);
            this.gridControl.MainView = this.gridView;
            this.gridControl.MenuManager = this.ribbonControl;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(760, 307);
            this.gridControl.TabIndex = 12;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsView.ShowGroupPanel = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.gridControl;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 53);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(764, 311);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // FrmGiuongBenh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.layoutControlMain);
            this.Controls.Add(this.ribbonControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmGiuongBenh";
            this.Ribbon = this.ribbonControl;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giường bệnh";
            this.Load += new System.EventHandler(this.FrmGiuongBenh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlMain)).EndInit();
            this.layoutControlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtSoGiuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbLoaiGiuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoNgay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayYLenh.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayYLenh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpGiuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraLayout.LayoutControl layoutControlMain;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroupMain;
        private DevExpress.XtraEditors.TextEdit txtSoGiuong;
        private DevExpress.XtraEditors.ComboBoxEdit cbLoaiGiuong;
        private System.Windows.Forms.NumericUpDown txtSoNgay;
        private DevExpress.XtraEditors.DateEdit dateNgayYLenh;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraEditors.SimpleButton btnDong;
        private DevExpress.XtraEditors.SimpleButton btnChon;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraEditors.SearchLookUpEdit lookUpGiuong;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn MaGiuong;
        private DevExpress.XtraGrid.Columns.GridColumn TenGiuong;
        private DevExpress.XtraGrid.Columns.GridColumn DonGiaGiuong;
        private DevExpress.XtraGrid.Columns.GridColumn MaNhomGiuong;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
    }
}