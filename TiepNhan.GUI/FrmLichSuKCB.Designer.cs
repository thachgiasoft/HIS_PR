namespace TiepNhan.GUI
{
    partial class FrmLichSuKCB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLichSuKCB));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.maHoSo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.maCSKCB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.tuNgay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.denNgay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tenBenh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tinhTrang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.kqDieuTri = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnChiTiet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btneditChiTiet = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.lblThongTin = new DevExpress.XtraEditors.LabelControl();
            this.lblGioiTinh = new DevExpress.XtraEditors.LabelControl();
            this.lblNamSinh = new DevExpress.XtraEditors.LabelControl();
            this.lblHoTen = new DevExpress.XtraEditors.LabelControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btneditChiTiet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
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
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridControl);
            this.layoutControl1.Controls.Add(this.lblThongTin);
            this.layoutControl1.Controls.Add(this.lblGioiTinh);
            this.layoutControl1.Controls.Add(this.lblNamSinh);
            this.layoutControl1.Controls.Add(this.lblHoTen);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 27);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(990, 318);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridControl
            // 
            this.gridControl.Location = new System.Drawing.Point(12, 52);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit,
            this.btneditChiTiet});
            this.gridControl.Size = new System.Drawing.Size(966, 254);
            this.gridControl.TabIndex = 8;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.maHoSo,
            this.maCSKCB,
            this.tuNgay,
            this.denNgay,
            this.tenBenh,
            this.tinhTrang,
            this.kqDieuTri,
            this.btnChiTiet});
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsView.ShowGroupPanel = false;
            this.gridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.gridView_CustomColumnDisplayText);
            // 
            // maHoSo
            // 
            this.maHoSo.Caption = "Mã hồ sơ";
            this.maHoSo.FieldName = "maHoSo";
            this.maHoSo.Name = "maHoSo";
            this.maHoSo.OptionsColumn.AllowEdit = false;
            // 
            // maCSKCB
            // 
            this.maCSKCB.Caption = "CSKCB";
            this.maCSKCB.ColumnEdit = this.repositoryItemLookUpEdit;
            this.maCSKCB.FieldName = "maCSKCB";
            this.maCSKCB.Name = "maCSKCB";
            this.maCSKCB.OptionsColumn.AllowEdit = false;
            this.maCSKCB.Visible = true;
            this.maCSKCB.VisibleIndex = 0;
            this.maCSKCB.Width = 210;
            // 
            // repositoryItemLookUpEdit
            // 
            this.repositoryItemLookUpEdit.AutoHeight = false;
            this.repositoryItemLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit.Name = "repositoryItemLookUpEdit";
            this.repositoryItemLookUpEdit.NullText = "";
            // 
            // tuNgay
            // 
            this.tuNgay.Caption = "Từ ngày";
            this.tuNgay.FieldName = "tuNgay";
            this.tuNgay.Name = "tuNgay";
            this.tuNgay.OptionsColumn.AllowEdit = false;
            this.tuNgay.Visible = true;
            this.tuNgay.VisibleIndex = 1;
            // 
            // denNgay
            // 
            this.denNgay.Caption = "Đến ngày";
            this.denNgay.FieldName = "denNgay";
            this.denNgay.Name = "denNgay";
            this.denNgay.OptionsColumn.AllowEdit = false;
            this.denNgay.Visible = true;
            this.denNgay.VisibleIndex = 2;
            this.denNgay.Width = 68;
            // 
            // tenBenh
            // 
            this.tenBenh.Caption = "Tên bệnh";
            this.tenBenh.FieldName = "tenBenh";
            this.tenBenh.Name = "tenBenh";
            this.tenBenh.OptionsColumn.AllowEdit = false;
            this.tenBenh.Visible = true;
            this.tenBenh.VisibleIndex = 3;
            this.tenBenh.Width = 369;
            // 
            // tinhTrang
            // 
            this.tinhTrang.Caption = "Tình trạng";
            this.tinhTrang.FieldName = "tinhTrang";
            this.tinhTrang.Name = "tinhTrang";
            this.tinhTrang.OptionsColumn.AllowEdit = false;
            this.tinhTrang.Visible = true;
            this.tinhTrang.VisibleIndex = 4;
            this.tinhTrang.Width = 73;
            // 
            // kqDieuTri
            // 
            this.kqDieuTri.Caption = "Kết quả";
            this.kqDieuTri.FieldName = "kqDieuTri";
            this.kqDieuTri.Name = "kqDieuTri";
            this.kqDieuTri.OptionsColumn.AllowEdit = false;
            this.kqDieuTri.Visible = true;
            this.kqDieuTri.VisibleIndex = 5;
            this.kqDieuTri.Width = 63;
            // 
            // btnChiTiet
            // 
            this.btnChiTiet.Caption = "#";
            this.btnChiTiet.ColumnEdit = this.btneditChiTiet;
            this.btnChiTiet.Name = "btnChiTiet";
            this.btnChiTiet.OptionsColumn.FixedWidth = true;
            this.btnChiTiet.Visible = true;
            this.btnChiTiet.VisibleIndex = 6;
            this.btnChiTiet.Width = 34;
            // 
            // btneditChiTiet
            // 
            this.btneditChiTiet.AutoHeight = false;
            this.btneditChiTiet.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btneditChiTiet.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.btneditChiTiet.ContextImage = ((System.Drawing.Image)(resources.GetObject("btneditChiTiet.ContextImage")));
            this.btneditChiTiet.Name = "btneditChiTiet";
            this.btneditChiTiet.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btneditChiTiet.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btneditChiTiet_ButtonClick);
            // 
            // lblThongTin
            // 
            this.lblThongTin.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTin.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lblThongTin.Appearance.Options.UseFont = true;
            this.lblThongTin.Appearance.Options.UseForeColor = true;
            this.lblThongTin.Location = new System.Drawing.Point(70, 32);
            this.lblThongTin.Name = "lblThongTin";
            this.lblThongTin.Size = new System.Drawing.Size(194, 16);
            this.lblThongTin.StyleController = this.layoutControl1;
            this.lblThongTin.TabIndex = 7;
            this.lblThongTin.Text = "Thông tin lịch sử khám chữa bệnh";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioiTinh.Appearance.Options.UseFont = true;
            this.lblGioiTinh.Location = new System.Drawing.Point(337, 12);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(26, 16);
            this.lblGioiTinh.StyleController = this.layoutControl1;
            this.lblGioiTinh.TabIndex = 6;
            this.lblGioiTinh.Text = "Nam";
            // 
            // lblNamSinh
            // 
            this.lblNamSinh.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamSinh.Appearance.Options.UseFont = true;
            this.lblNamSinh.Location = new System.Drawing.Point(556, 12);
            this.lblNamSinh.Name = "lblNamSinh";
            this.lblNamSinh.Size = new System.Drawing.Size(66, 16);
            this.lblNamSinh.StyleController = this.layoutControl1;
            this.lblNamSinh.TabIndex = 5;
            this.lblNamSinh.Text = "01/11/1994";
            // 
            // lblHoTen
            // 
            this.lblHoTen.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoTen.Appearance.Options.UseFont = true;
            this.lblHoTen.Location = new System.Drawing.Point(70, 12);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(80, 16);
            this.lblHoTen.StyleController = this.layoutControl1;
            this.lblHoTen.TabIndex = 4;
            this.lblHoTen.Text = "Nguyễn Văn A";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.emptySpaceItem2,
            this.emptySpaceItem3,
            this.emptySpaceItem4,
            this.layoutControlItem4,
            this.layoutControlItem5});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(990, 318);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.lblHoTen;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(142, 20);
            this.layoutControlItem1.Text = "Họ tên:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(55, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.lblNamSinh;
            this.layoutControlItem2.Location = new System.Drawing.Point(486, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(128, 20);
            this.layoutControlItem2.Text = "Năm sinh:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(55, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.lblGioiTinh;
            this.layoutControlItem3.Location = new System.Drawing.Point(267, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(88, 20);
            this.layoutControlItem3.Text = "Giới tính:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(55, 13);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(355, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(131, 20);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(142, 0);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(125, 20);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.Location = new System.Drawing.Point(614, 0);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(356, 20);
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.lblThongTin;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 20);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(970, 20);
            this.layoutControlItem4.Text = "Thông báo:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(55, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.gridControl;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 40);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(970, 258);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // FrmLichSuKCB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 345);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.ribbonControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLichSuKCB";
            this.Ribbon = this.ribbonControl;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lịch sử Khám chữa bệnh";
            this.Load += new System.EventHandler(this.FrmLichSuKCB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btneditChiTiet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.LabelControl lblHoTen;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.LabelControl lblGioiTinh;
        private DevExpress.XtraEditors.LabelControl lblNamSinh;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraEditors.LabelControl lblThongTin;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn maHoSo;
        private DevExpress.XtraGrid.Columns.GridColumn maCSKCB;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit;
        private DevExpress.XtraGrid.Columns.GridColumn tuNgay;
        private DevExpress.XtraGrid.Columns.GridColumn denNgay;
        private DevExpress.XtraGrid.Columns.GridColumn tenBenh;
        private DevExpress.XtraGrid.Columns.GridColumn tinhTrang;
        private DevExpress.XtraGrid.Columns.GridColumn kqDieuTri;
        private DevExpress.XtraGrid.Columns.GridColumn btnChiTiet;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btneditChiTiet;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    }
}