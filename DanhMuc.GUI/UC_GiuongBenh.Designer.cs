namespace DanhMuc.GUI
{
    partial class UC_GiuongBenh
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
            this.Ma = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Ten = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DonGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaKhoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repItemLookUpKhoa = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.MaCS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repItemLookUpCoSo = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.TinhTrang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lookUpKhoaPhong = new DevExpress.XtraEditors.LookUpEdit();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.checkTinhTrang = new DevExpress.XtraEditors.CheckEdit();
            this.txtDonGia = new DevExpress.XtraEditors.TextEdit();
            this.txtTen = new DevExpress.XtraEditors.TextEdit();
            this.txtMa = new DevExpress.XtraEditors.TextEdit();
            this.lookUpCoSoKCB = new DevExpress.XtraEditors.LookUpEdit();
            this.layoutControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
            this.layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repItemLookUpKhoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repItemLookUpCoSo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpKhoaPhong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkTinhTrang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpCoSoKCB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl
            // 
            this.layoutControl.Controls.Add(this.gridControl);
            this.layoutControl.Controls.Add(this.lookUpKhoaPhong);
            this.layoutControl.Controls.Add(this.btnXoa);
            this.layoutControl.Controls.Add(this.btnLuu);
            this.layoutControl.Controls.Add(this.btnThem);
            this.layoutControl.Controls.Add(this.checkTinhTrang);
            this.layoutControl.Controls.Add(this.txtDonGia);
            this.layoutControl.Controls.Add(this.txtTen);
            this.layoutControl.Controls.Add(this.txtMa);
            this.layoutControl.Controls.Add(this.lookUpCoSoKCB);
            this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl.Location = new System.Drawing.Point(0, 0);
            this.layoutControl.Name = "layoutControl";
            this.layoutControl.Root = this.layoutControlGroup;
            this.layoutControl.Size = new System.Drawing.Size(852, 488);
            this.layoutControl.TabIndex = 0;
            this.layoutControl.Text = "layoutControl1";
            // 
            // gridControl
            // 
            this.gridControl.Location = new System.Drawing.Point(12, 65);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repItemLookUpKhoa,
            this.repItemLookUpCoSo});
            this.gridControl.Size = new System.Drawing.Size(828, 411);
            this.gridControl.TabIndex = 13;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            this.gridControl.Click += new System.EventHandler(this.gridControl_Click);
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Ma,
            this.Ten,
            this.DonGia,
            this.MaKhoa,
            this.MaCS,
            this.TinhTrang});
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsFind.AlwaysVisible = true;
            this.gridView.OptionsFind.FindNullPrompt = "Nhập thông tin cần tìm";
            this.gridView.OptionsView.ShowGroupPanel = false;
            this.gridView.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView_RowClick);
            // 
            // Ma
            // 
            this.Ma.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ma.AppearanceCell.Options.UseFont = true;
            this.Ma.Caption = "Mã";
            this.Ma.FieldName = "Ma";
            this.Ma.Name = "Ma";
            this.Ma.OptionsColumn.AllowEdit = false;
            this.Ma.Visible = true;
            this.Ma.VisibleIndex = 0;
            this.Ma.Width = 72;
            // 
            // Ten
            // 
            this.Ten.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ten.AppearanceCell.Options.UseFont = true;
            this.Ten.Caption = "Tên";
            this.Ten.FieldName = "Ten";
            this.Ten.Name = "Ten";
            this.Ten.OptionsColumn.AllowEdit = false;
            this.Ten.Visible = true;
            this.Ten.VisibleIndex = 1;
            this.Ten.Width = 261;
            // 
            // DonGia
            // 
            this.DonGia.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonGia.AppearanceCell.Options.UseFont = true;
            this.DonGia.Caption = "Đơn giá";
            this.DonGia.DisplayFormat.FormatString = "#,###";
            this.DonGia.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.DonGia.FieldName = "DonGia";
            this.DonGia.Name = "DonGia";
            this.DonGia.OptionsColumn.AllowEdit = false;
            this.DonGia.Visible = true;
            this.DonGia.VisibleIndex = 2;
            this.DonGia.Width = 76;
            // 
            // MaKhoa
            // 
            this.MaKhoa.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaKhoa.AppearanceCell.Options.UseFont = true;
            this.MaKhoa.Caption = "Khoa/Phòng";
            this.MaKhoa.ColumnEdit = this.repItemLookUpKhoa;
            this.MaKhoa.FieldName = "MaKhoa";
            this.MaKhoa.Name = "MaKhoa";
            this.MaKhoa.OptionsColumn.AllowEdit = false;
            this.MaKhoa.Visible = true;
            this.MaKhoa.VisibleIndex = 3;
            this.MaKhoa.Width = 188;
            // 
            // repItemLookUpKhoa
            // 
            this.repItemLookUpKhoa.AutoHeight = false;
            this.repItemLookUpKhoa.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repItemLookUpKhoa.Name = "repItemLookUpKhoa";
            this.repItemLookUpKhoa.NullText = "";
            // 
            // MaCS
            // 
            this.MaCS.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaCS.AppearanceCell.Options.UseFont = true;
            this.MaCS.Caption = "Cơ sở KCB";
            this.MaCS.ColumnEdit = this.repItemLookUpCoSo;
            this.MaCS.FieldName = "Ma_CS";
            this.MaCS.Name = "MaCS";
            this.MaCS.OptionsColumn.AllowEdit = false;
            this.MaCS.Visible = true;
            this.MaCS.VisibleIndex = 4;
            this.MaCS.Width = 193;
            // 
            // repItemLookUpCoSo
            // 
            this.repItemLookUpCoSo.AutoHeight = false;
            this.repItemLookUpCoSo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repItemLookUpCoSo.Name = "repItemLookUpCoSo";
            this.repItemLookUpCoSo.NullText = "";
            // 
            // TinhTrang
            // 
            this.TinhTrang.Caption = "#";
            this.TinhTrang.FieldName = "TinhTrang";
            this.TinhTrang.Name = "TinhTrang";
            this.TinhTrang.OptionsColumn.AllowEdit = false;
            this.TinhTrang.OptionsColumn.FixedWidth = true;
            this.TinhTrang.Visible = true;
            this.TinhTrang.VisibleIndex = 5;
            this.TinhTrang.Width = 25;
            // 
            // lookUpKhoaPhong
            // 
            this.lookUpKhoaPhong.Location = new System.Drawing.Point(361, 38);
            this.lookUpKhoaPhong.Name = "lookUpKhoaPhong";
            this.lookUpKhoaPhong.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookUpKhoaPhong.Properties.Appearance.Options.UseFont = true;
            this.lookUpKhoaPhong.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookUpKhoaPhong.Properties.AppearanceDropDown.Options.UseFont = true;
            this.lookUpKhoaPhong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpKhoaPhong.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaKhoa", "Mã"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenKhoa", 60, "Tên")});
            this.lookUpKhoaPhong.Properties.NullText = "";
            this.lookUpKhoaPhong.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpKhoaPhong.Size = new System.Drawing.Size(226, 22);
            this.lookUpKhoaPhong.StyleController = this.layoutControl;
            this.lookUpKhoaPhong.TabIndex = 12;
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.ImageUri.Uri = "Cancel;Size16x16";
            this.btnXoa.Location = new System.Drawing.Point(763, 38);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(77, 23);
            this.btnXoa.StyleController = this.layoutControl;
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Appearance.Options.UseFont = true;
            this.btnLuu.ImageUri.Uri = "Save;Size16x16";
            this.btnLuu.Location = new System.Drawing.Point(684, 38);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
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
            this.btnThem.Location = new System.Drawing.Point(604, 38);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(76, 23);
            this.btnThem.StyleController = this.layoutControl;
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Mới";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // checkTinhTrang
            // 
            this.checkTinhTrang.Location = new System.Drawing.Point(235, 38);
            this.checkTinhTrang.Name = "checkTinhTrang";
            this.checkTinhTrang.Properties.Caption = "";
            this.checkTinhTrang.Size = new System.Drawing.Size(57, 19);
            this.checkTinhTrang.StyleController = this.layoutControl;
            this.checkTinhTrang.TabIndex = 8;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(77, 38);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.Properties.Appearance.Options.UseFont = true;
            this.txtDonGia.Properties.Mask.EditMask = "\\d+";
            this.txtDonGia.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtDonGia.Size = new System.Drawing.Size(89, 22);
            this.txtDonGia.StyleController = this.layoutControl;
            this.txtDonGia.TabIndex = 7;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(525, 12);
            this.txtTen.Name = "txtTen";
            this.txtTen.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Properties.Appearance.Options.UseFont = true;
            this.txtTen.Size = new System.Drawing.Size(315, 22);
            this.txtTen.StyleController = this.layoutControl;
            this.txtTen.TabIndex = 6;
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(361, 12);
            this.txtMa.Name = "txtMa";
            this.txtMa.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMa.Properties.Appearance.Options.UseFont = true;
            this.txtMa.Size = new System.Drawing.Size(95, 22);
            this.txtMa.StyleController = this.layoutControl;
            this.txtMa.TabIndex = 5;
            // 
            // lookUpCoSoKCB
            // 
            this.lookUpCoSoKCB.Location = new System.Drawing.Point(77, 12);
            this.lookUpCoSoKCB.Name = "lookUpCoSoKCB";
            this.lookUpCoSoKCB.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookUpCoSoKCB.Properties.Appearance.Options.UseFont = true;
            this.lookUpCoSoKCB.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookUpCoSoKCB.Properties.AppearanceDropDown.Options.UseFont = true;
            this.lookUpCoSoKCB.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpCoSoKCB.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ma_CS", "Mã"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten_CS", 60, "Tên")});
            this.lookUpCoSoKCB.Properties.NullText = "";
            this.lookUpCoSoKCB.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpCoSoKCB.Size = new System.Drawing.Size(215, 22);
            this.lookUpCoSoKCB.StyleController = this.layoutControl;
            this.lookUpCoSoKCB.TabIndex = 4;
            this.lookUpCoSoKCB.EditValueChanged += new System.EventHandler(this.lookUpCoSoKCB_EditValueChanged);
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
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.emptySpaceItem2,
            this.layoutControlItem9,
            this.layoutControlItem10});
            this.layoutControlGroup.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup.Name = "layoutControlGroup";
            this.layoutControlGroup.Size = new System.Drawing.Size(852, 488);
            this.layoutControlGroup.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.lookUpCoSoKCB;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(284, 26);
            this.layoutControlItem1.Text = "Cơ sở KCB:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(62, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtMa;
            this.layoutControlItem2.Location = new System.Drawing.Point(284, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(164, 26);
            this.layoutControlItem2.Text = "Mã:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(62, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtTen;
            this.layoutControlItem3.Location = new System.Drawing.Point(448, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(384, 26);
            this.layoutControlItem3.Text = "Tên:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(62, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txtDonGia;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(158, 27);
            this.layoutControlItem4.Text = "Đơn giá:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(62, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.checkTinhTrang;
            this.layoutControlItem5.Location = new System.Drawing.Point(158, 26);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(126, 27);
            this.layoutControlItem5.Text = "Hiệu lực:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(62, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.btnThem;
            this.layoutControlItem6.Location = new System.Drawing.Point(592, 26);
            this.layoutControlItem6.MaxSize = new System.Drawing.Size(80, 27);
            this.layoutControlItem6.MinSize = new System.Drawing.Size(80, 27);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(80, 27);
            this.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.btnLuu;
            this.layoutControlItem7.Location = new System.Drawing.Point(672, 26);
            this.layoutControlItem7.MaxSize = new System.Drawing.Size(79, 27);
            this.layoutControlItem7.MinSize = new System.Drawing.Size(79, 27);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(79, 27);
            this.layoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.btnXoa;
            this.layoutControlItem8.Location = new System.Drawing.Point(751, 26);
            this.layoutControlItem8.MaxSize = new System.Drawing.Size(81, 27);
            this.layoutControlItem8.MinSize = new System.Drawing.Size(81, 27);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(81, 27);
            this.layoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(579, 26);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(13, 27);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.lookUpKhoaPhong;
            this.layoutControlItem9.Location = new System.Drawing.Point(284, 26);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(295, 27);
            this.layoutControlItem9.Text = "Khoa/Phòng:";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(62, 13);
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.gridControl;
            this.layoutControlItem10.Location = new System.Drawing.Point(0, 53);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(832, 415);
            this.layoutControlItem10.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem10.TextVisible = false;
            // 
            // UC_GiuongBenh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl);
            this.Name = "UC_GiuongBenh";
            this.Size = new System.Drawing.Size(852, 488);
            this.Load += new System.EventHandler(this.UC_TienKham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
            this.layoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repItemLookUpKhoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repItemLookUpCoSo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpKhoaPhong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkTinhTrang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpCoSoKCB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl;
        private DevExpress.XtraEditors.LookUpEdit lookUpCoSoKCB;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.TextEdit txtTen;
        private DevExpress.XtraEditors.TextEdit txtMa;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.CheckEdit checkTinhTrang;
        private DevExpress.XtraEditors.TextEdit txtDonGia;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraEditors.LookUpEdit lookUpKhoaPhong;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraGrid.Columns.GridColumn Ma;
        private DevExpress.XtraGrid.Columns.GridColumn Ten;
        private DevExpress.XtraGrid.Columns.GridColumn DonGia;
        private DevExpress.XtraGrid.Columns.GridColumn MaKhoa;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repItemLookUpKhoa;
        private DevExpress.XtraGrid.Columns.GridColumn MaCS;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repItemLookUpCoSo;
        private DevExpress.XtraGrid.Columns.GridColumn TinhTrang;
    }
}
