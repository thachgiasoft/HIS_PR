namespace TiepNhan.GUI
{
    partial class FrmRaVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRaVien));
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cbKetQua = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cbTinhTrangRaVien = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnChon = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbKetQua.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTinhTrangRaVien.Properties)).BeginInit();
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
            this.ribbonControl.Size = new System.Drawing.Size(262, 30);
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(10, 40);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(92, 16);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Kết quả điều trị:";
            // 
            // cbKetQua
            // 
            this.cbKetQua.Location = new System.Drawing.Point(125, 37);
            this.cbKetQua.MenuManager = this.ribbonControl;
            this.cbKetQua.Name = "cbKetQua";
            this.cbKetQua.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKetQua.Properties.Appearance.Options.UseFont = true;
            this.cbKetQua.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKetQua.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cbKetQua.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbKetQua.Properties.Items.AddRange(new object[] {
            "1. Khỏi",
            "2. Đỡ",
            "3. Không thay đổi",
            "4. Nặng hơn",
            "5. Tử vong"});
            this.cbKetQua.Size = new System.Drawing.Size(120, 22);
            this.cbKetQua.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(10, 70);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(107, 16);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Tình trạng ra viện:";
            // 
            // cbTinhTrangRaVien
            // 
            this.cbTinhTrangRaVien.Location = new System.Drawing.Point(125, 70);
            this.cbTinhTrangRaVien.Name = "cbTinhTrangRaVien";
            this.cbTinhTrangRaVien.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTinhTrangRaVien.Properties.Appearance.Options.UseFont = true;
            this.cbTinhTrangRaVien.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTinhTrangRaVien.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cbTinhTrangRaVien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTinhTrangRaVien.Properties.Items.AddRange(new object[] {
            "1. Ra viện",
            "2. Chuyển tuyến",
            "3. Trốn viện",
            "4. Xin ra viện"});
            this.cbTinhTrangRaVien.Size = new System.Drawing.Size(120, 22);
            this.cbTinhTrangRaVien.TabIndex = 2;
            // 
            // btnChon
            // 
            this.btnChon.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChon.Appearance.Options.UseFont = true;
            this.btnChon.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnChon.ImageOptions.Image")));
            this.btnChon.Location = new System.Drawing.Point(42, 110);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(75, 23);
            this.btnChon.TabIndex = 3;
            this.btnChon.Text = "Chọn";
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Appearance.Options.UseFont = true;
            this.btnHuy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.ImageOptions.Image")));
            this.btnHuy.Location = new System.Drawing.Point(137, 110);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 3;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // FrmRaVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 146);
            this.ControlBox = false;
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.cbTinhTrangRaVien);
            this.Controls.Add(this.cbKetQua);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.ribbonControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRaVien";
            this.Ribbon = this.ribbonControl;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yêu cầu ra viện";
            this.Load += new System.EventHandler(this.FrmRaVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbKetQua.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTinhTrangRaVien.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cbKetQua;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ComboBoxEdit cbTinhTrangRaVien;
        private DevExpress.XtraEditors.SimpleButton btnChon;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
    }
}