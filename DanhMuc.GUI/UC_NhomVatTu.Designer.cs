namespace DanhMuc.GUI
{
    partial class UC_NhomVatTu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
        {
            this.layoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaLoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaNhom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Ten = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TinhTrang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.checkTinhTrang = new DevExpress.XtraEditors.CheckEdit();
            this.txtTenNhom = new DevExpress.XtraEditors.TextEdit();
            this.lookUpLoaiVT = new DevExpress.XtraEditors.LookUpEdit();
            this.txtMaNhom = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
            this.layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkTinhTrang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNhom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpLoaiVT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNhom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl
            // 
            this.layoutControl.Controls.Add(this.gridControl);
            this.layoutControl.Controls.Add(this.btnLuu);
            this.layoutControl.Controls.Add(this.btnThem);
            this.layoutControl.Controls.Add(this.btnXoa);
            this.layoutControl.Controls.Add(this.checkTinhTrang);
            this.layoutControl.Controls.Add(this.txtTenNhom);
            this.layoutControl.Controls.Add(this.lookUpLoaiVT);
            this.layoutControl.Controls.Add(this.txtMaNhom);
            this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl.Location = new System.Drawing.Point(0, 0);
            this.layoutControl.Name = "layoutControl";
            this.layoutControl.Root = this.layoutControlGroup;
            this.layoutControl.Size = new System.Drawing.Size(714, 362);
            this.layoutControl.TabIndex = 0;
            this.layoutControl.Text = "layoutControl1";
            // 
            // gridControl
            // 
            this.gridControl.Location = new System.Drawing.Point(12, 64);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit});
            this.gridControl.Size = new System.Drawing.Size(690, 286);
            this.gridControl.TabIndex = 12;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaLoai,
            this.MaNhom,
            this.Ten,
            this.TinhTrang});
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsView.ShowAutoFilterRow = true;
            this.gridView.OptionsView.ShowGroupPanel = false;
            this.gridView.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView_RowClick);
            // 
            // MaLoai
            // 
            this.MaLoai.Caption = "Mã Loại";
            this.MaLoai.FieldName = "MaLoai";
            this.MaLoai.Name = "MaLoai";
            this.MaLoai.OptionsColumn.AllowEdit = false;
            this.MaLoai.Visible = true;
            this.MaLoai.VisibleIndex = 0;
            this.MaLoai.Width = 102;
            // 
            // MaNhom
            // 
            this.MaNhom.Caption = "Mã Nhóm";
            this.MaNhom.FieldName = "Ma";
            this.MaNhom.Name = "MaNhom";
            this.MaNhom.OptionsColumn.AllowEdit = false;
            this.MaNhom.Visible = true;
            this.MaNhom.VisibleIndex = 1;
            this.MaNhom.Width = 90;
            // 
            // Ten
            // 
            this.Ten.Caption = "Tên Nhóm";
            this.Ten.FieldName = "Ten";
            this.Ten.Name = "Ten";
            this.Ten.OptionsColumn.AllowEdit = false;
            this.Ten.Visible = true;
            this.Ten.VisibleIndex = 2;
            this.Ten.Width = 417;
            // 
            // TinhTrang
            // 
            this.TinhTrang.Caption = "Hiệu lực";
            this.TinhTrang.ColumnEdit = this.repositoryItemCheckEdit;
            this.TinhTrang.FieldName = "TinhTrang";
            this.TinhTrang.Name = "TinhTrang";
            this.TinhTrang.OptionsColumn.AllowEdit = false;
            this.TinhTrang.Visible = true;
            this.TinhTrang.VisibleIndex = 3;
            this.TinhTrang.Width = 63;
            // 
            // repositoryItemCheckEdit
            // 
            this.repositoryItemCheckEdit.AutoHeight = false;
            this.repositoryItemCheckEdit.Name = "repositoryItemCheckEdit";
            // 
            // btnLuu
            // 
            this.btnLuu.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Appearance.Options.UseFont = true;
            this.btnLuu.ImageUri.Uri = "Save;Size16x16";
            this.btnLuu.Location = new System.Drawing.Point(546, 38);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(76, 22);
            this.btnLuu.StyleController = this.layoutControl;
            this.btnLuu.TabIndex = 10;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.ImageUri.Uri = "Add;Size16x16";
            this.btnThem.Location = new System.Drawing.Point(466, 38);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(76, 22);
            this.btnThem.StyleController = this.layoutControl;
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Mới";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.ImageUri.Uri = "Cancel;Size16x16";
            this.btnXoa.Location = new System.Drawing.Point(626, 38);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(76, 22);
            this.btnXoa.StyleController = this.layoutControl;
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // checkTinhTrang
            // 
            this.checkTinhTrang.Location = new System.Drawing.Point(399, 38);
            this.checkTinhTrang.Name = "checkTinhTrang";
            this.checkTinhTrang.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkTinhTrang.Properties.Appearance.Options.UseFont = true;
            this.checkTinhTrang.Properties.Caption = "";
            this.checkTinhTrang.Size = new System.Drawing.Size(63, 19);
            this.checkTinhTrang.StyleController = this.layoutControl;
            this.checkTinhTrang.TabIndex = 7;
            // 
            // txtTenNhom
            // 
            this.txtTenNhom.Location = new System.Drawing.Point(399, 12);
            this.txtTenNhom.Name = "txtTenNhom";
            this.txtTenNhom.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNhom.Properties.Appearance.Options.UseFont = true;
            this.txtTenNhom.Size = new System.Drawing.Size(303, 22);
            this.txtTenNhom.StyleController = this.layoutControl;
            this.txtTenNhom.TabIndex = 6;
            // 
            // lookUpLoaiVT
            // 
            this.lookUpLoaiVT.Location = new System.Drawing.Point(71, 12);
            this.lookUpLoaiVT.Name = "lookUpLoaiVT";
            this.lookUpLoaiVT.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookUpLoaiVT.Properties.Appearance.Options.UseFont = true;
            this.lookUpLoaiVT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpLoaiVT.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ma", "Mã"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten", "Tên")});
            this.lookUpLoaiVT.Properties.NullText = "";
            this.lookUpLoaiVT.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpLoaiVT.Size = new System.Drawing.Size(265, 22);
            this.lookUpLoaiVT.StyleController = this.layoutControl;
            this.lookUpLoaiVT.TabIndex = 5;
            this.lookUpLoaiVT.EditValueChanged += new System.EventHandler(this.lookUpLoaiVT_EditValueChanged);
            // 
            // txtMaNhom
            // 
            this.txtMaNhom.Location = new System.Drawing.Point(71, 38);
            this.txtMaNhom.Name = "txtMaNhom";
            this.txtMaNhom.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNhom.Properties.Appearance.Options.UseFont = true;
            this.txtMaNhom.Size = new System.Drawing.Size(265, 22);
            this.txtMaNhom.StyleController = this.layoutControl;
            this.txtMaNhom.TabIndex = 4;
            // 
            // layoutControlGroup
            // 
            this.layoutControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup.GroupBordersVisible = false;
            this.layoutControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem3,
            this.layoutControlItem1,
            this.layoutControlItem9});
            this.layoutControlGroup.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup.Name = "layoutControlGroup";
            this.layoutControlGroup.Size = new System.Drawing.Size(714, 362);
            this.layoutControlGroup.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.lookUpLoaiVT;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(328, 26);
            this.layoutControlItem2.Text = "Loại vật tư:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(56, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.checkTinhTrang;
            this.layoutControlItem4.Location = new System.Drawing.Point(328, 26);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(126, 26);
            this.layoutControlItem4.Text = "Hiệu lực:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(56, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnXoa;
            this.layoutControlItem5.Location = new System.Drawing.Point(614, 26);
            this.layoutControlItem5.MaxSize = new System.Drawing.Size(80, 26);
            this.layoutControlItem5.MinSize = new System.Drawing.Size(80, 26);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(80, 26);
            this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.btnThem;
            this.layoutControlItem6.Location = new System.Drawing.Point(454, 26);
            this.layoutControlItem6.MaxSize = new System.Drawing.Size(80, 26);
            this.layoutControlItem6.MinSize = new System.Drawing.Size(80, 26);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(80, 26);
            this.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.btnLuu;
            this.layoutControlItem7.Location = new System.Drawing.Point(534, 26);
            this.layoutControlItem7.MaxSize = new System.Drawing.Size(80, 26);
            this.layoutControlItem7.MinSize = new System.Drawing.Size(80, 26);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(80, 26);
            this.layoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtTenNhom;
            this.layoutControlItem3.Location = new System.Drawing.Point(328, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(366, 26);
            this.layoutControlItem3.Text = "Tên nhóm:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(56, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtMaNhom;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(328, 26);
            this.layoutControlItem1.Text = "Mã nhóm:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(56, 13);
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.gridControl;
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 52);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(694, 290);
            this.layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem9.TextVisible = false;
            // 
            // UC_NhomVatTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl);
            this.Name = "UC_NhomVatTu";
            this.Size = new System.Drawing.Size(714, 362);
            this.Load += new System.EventHandler(this.UC_NhomVatTu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
            this.layoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkTinhTrang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNhom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpLoaiVT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNhom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.CheckEdit checkTinhTrang;
        private DevExpress.XtraEditors.TextEdit txtTenNhom;
        private DevExpress.XtraEditors.LookUpEdit lookUpLoaiVT;
        private DevExpress.XtraEditors.TextEdit txtMaNhom;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraGrid.Columns.GridColumn MaLoai;
        private DevExpress.XtraGrid.Columns.GridColumn MaNhom;
        private DevExpress.XtraGrid.Columns.GridColumn Ten;
        private DevExpress.XtraGrid.Columns.GridColumn TinhTrang;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit;
    }
}
