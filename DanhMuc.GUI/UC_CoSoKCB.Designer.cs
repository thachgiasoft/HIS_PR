namespace DanhMuc.GUI
{
    partial class UC_CoSoKCB
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
            this.MaCS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenCS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.progressBarControl = new DevExpress.XtraEditors.ProgressBarControl();
            this.layoutProcess = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnNhap = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
            this.layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutProcess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl
            // 
            this.layoutControl.Controls.Add(this.btnNhap);
            this.layoutControl.Controls.Add(this.progressBarControl);
            this.layoutControl.Controls.Add(this.gridControl);
            this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl.Location = new System.Drawing.Point(0, 0);
            this.layoutControl.Name = "layoutControl";
            this.layoutControl.Root = this.layoutControlGroup;
            this.layoutControl.Size = new System.Drawing.Size(781, 471);
            this.layoutControl.TabIndex = 0;
            this.layoutControl.Text = "layoutControl1";
            // 
            // gridControl
            // 
            this.gridControl.Location = new System.Drawing.Point(12, 38);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(757, 421);
            this.gridControl.TabIndex = 4;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaCS,
            this.TenCS,
            this.DiaChi});
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsFind.AlwaysVisible = true;
            this.gridView.OptionsFind.FindNullPrompt = "Nhập thông tin cần tìm";
            this.gridView.OptionsView.ShowGroupPanel = false;
            // 
            // MaCS
            // 
            this.MaCS.Caption = "Mã cơ sở";
            this.MaCS.FieldName = "Ma_CS";
            this.MaCS.Name = "MaCS";
            this.MaCS.OptionsColumn.AllowEdit = false;
            this.MaCS.Visible = true;
            this.MaCS.VisibleIndex = 0;
            // 
            // TenCS
            // 
            this.TenCS.Caption = "Tên cơ sở";
            this.TenCS.FieldName = "Ten_CS";
            this.TenCS.Name = "TenCS";
            this.TenCS.OptionsColumn.AllowEdit = false;
            this.TenCS.Visible = true;
            this.TenCS.VisibleIndex = 1;
            // 
            // DiaChi
            // 
            this.DiaChi.Caption = "Địa chỉ";
            this.DiaChi.FieldName = "DiaChi";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.OptionsColumn.AllowEdit = false;
            this.DiaChi.Visible = true;
            this.DiaChi.VisibleIndex = 2;
            // 
            // layoutControlGroup
            // 
            this.layoutControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup.GroupBordersVisible = false;
            this.layoutControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutProcess,
            this.layoutControlItem3,
            this.emptySpaceItem1});
            this.layoutControlGroup.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup.Name = "layoutControlGroup";
            this.layoutControlGroup.Size = new System.Drawing.Size(781, 471);
            this.layoutControlGroup.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(761, 425);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // progressBarControl
            // 
            this.progressBarControl.Location = new System.Drawing.Point(64, 12);
            this.progressBarControl.Name = "progressBarControl";
            this.progressBarControl.Size = new System.Drawing.Size(488, 18);
            this.progressBarControl.StyleController = this.layoutControl;
            this.progressBarControl.TabIndex = 5;
            // 
            // layoutProcess
            // 
            this.layoutProcess.Control = this.progressBarControl;
            this.layoutProcess.Location = new System.Drawing.Point(0, 0);
            this.layoutProcess.Name = "layoutProcess";
            this.layoutProcess.Size = new System.Drawing.Size(544, 26);
            this.layoutProcess.Text = "Tiến trình:";
            this.layoutProcess.TextSize = new System.Drawing.Size(49, 13);
            // 
            // btnNhap
            // 
            this.btnNhap.ImageUri.Uri = "ExportToXLS;Size16x16";
            this.btnNhap.Location = new System.Drawing.Point(688, 12);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(81, 22);
            this.btnNhap.StyleController = this.layoutControl;
            this.btnNhap.TabIndex = 6;
            this.btnNhap.Text = "Nhập excel";
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnNhap;
            this.layoutControlItem3.Location = new System.Drawing.Point(676, 0);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(85, 26);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(85, 26);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(85, 26);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(544, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(132, 26);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // UC_CoSoKCB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl);
            this.Name = "UC_CoSoKCB";
            this.Size = new System.Drawing.Size(781, 471);
            this.Load += new System.EventHandler(this.UC_CoSoKCB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
            this.layoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutProcess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn MaCS;
        private DevExpress.XtraGrid.Columns.GridColumn TenCS;
        private DevExpress.XtraGrid.Columns.GridColumn DiaChi;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SimpleButton btnNhap;
        private DevExpress.XtraEditors.ProgressBarControl progressBarControl;
        private DevExpress.XtraLayout.LayoutControlItem layoutProcess;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
    }
}
