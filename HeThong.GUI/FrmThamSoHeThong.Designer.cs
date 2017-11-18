namespace HeThong.GUI
{
    partial class FrmThamSoHeThong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmThamSoHeThong));
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.layoutControlMain = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroupMain = new DevExpress.XtraLayout.LayoutControlGroup();
            this.txtServerName = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.txtDatabase = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtUserName = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtUserNameBHYT = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtPasswordBHYT = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlMain)).BeginInit();
            this.layoutControlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtServerName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDatabase.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserNameBHYT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPasswordBHYT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
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
            this.ribbonControl.Size = new System.Drawing.Size(285, 27);
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // layoutControlMain
            // 
            this.layoutControlMain.Controls.Add(this.btnLuu);
            this.layoutControlMain.Controls.Add(this.btnCancel);
            this.layoutControlMain.Controls.Add(this.txtPasswordBHYT);
            this.layoutControlMain.Controls.Add(this.txtUserNameBHYT);
            this.layoutControlMain.Controls.Add(this.txtPassword);
            this.layoutControlMain.Controls.Add(this.txtUserName);
            this.layoutControlMain.Controls.Add(this.txtDatabase);
            this.layoutControlMain.Controls.Add(this.txtServerName);
            this.layoutControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControlMain.Location = new System.Drawing.Point(0, 27);
            this.layoutControlMain.Name = "layoutControlMain";
            this.layoutControlMain.Root = this.layoutControlGroupMain;
            this.layoutControlMain.Size = new System.Drawing.Size(285, 228);
            this.layoutControlMain.TabIndex = 1;
            this.layoutControlMain.Text = "layoutControl1";
            // 
            // layoutControlGroupMain
            // 
            this.layoutControlGroupMain.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroupMain.GroupBordersVisible = false;
            this.layoutControlGroupMain.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.emptySpaceItem2,
            this.layoutControlItem7,
            this.layoutControlItem8});
            this.layoutControlGroupMain.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroupMain.Name = "layoutControlGroupMain";
            this.layoutControlGroupMain.Size = new System.Drawing.Size(285, 228);
            this.layoutControlGroupMain.TextVisible = false;
            // 
            // txtServerName
            // 
            this.txtServerName.Location = new System.Drawing.Point(99, 12);
            this.txtServerName.MenuManager = this.ribbonControl;
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServerName.Properties.Appearance.Options.UseFont = true;
            this.txtServerName.Size = new System.Drawing.Size(174, 22);
            this.txtServerName.StyleController = this.layoutControlMain;
            this.txtServerName.TabIndex = 2;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtServerName;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(265, 26);
            this.layoutControlItem1.Text = "Server name:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(83, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 167);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(265, 14);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // txtDatabase
            // 
            this.txtDatabase.Location = new System.Drawing.Point(99, 38);
            this.txtDatabase.MenuManager = this.ribbonControl;
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatabase.Properties.Appearance.Options.UseFont = true;
            this.txtDatabase.Size = new System.Drawing.Size(174, 22);
            this.txtDatabase.StyleController = this.layoutControlMain;
            this.txtDatabase.TabIndex = 4;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtDatabase;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(265, 26);
            this.layoutControlItem2.Text = "Database:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(83, 13);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(99, 64);
            this.txtUserName.MenuManager = this.ribbonControl;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Properties.Appearance.Options.UseFont = true;
            this.txtUserName.Size = new System.Drawing.Size(174, 22);
            this.txtUserName.StyleController = this.layoutControlMain;
            this.txtUserName.TabIndex = 5;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtUserName;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 52);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(265, 26);
            this.layoutControlItem3.Text = "User name:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(83, 13);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(99, 90);
            this.txtPassword.MenuManager = this.ribbonControl;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Properties.Appearance.Options.UseFont = true;
            this.txtPassword.Properties.UseSystemPasswordChar = true;
            this.txtPassword.Size = new System.Drawing.Size(174, 22);
            this.txtPassword.StyleController = this.layoutControlMain;
            this.txtPassword.TabIndex = 6;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txtPassword;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 78);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(265, 26);
            this.layoutControlItem4.Text = "Password:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(83, 13);
            // 
            // txtUserNameBHYT
            // 
            this.txtUserNameBHYT.Location = new System.Drawing.Point(99, 127);
            this.txtUserNameBHYT.MenuManager = this.ribbonControl;
            this.txtUserNameBHYT.Name = "txtUserNameBHYT";
            this.txtUserNameBHYT.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserNameBHYT.Properties.Appearance.Options.UseFont = true;
            this.txtUserNameBHYT.Size = new System.Drawing.Size(174, 22);
            this.txtUserNameBHYT.StyleController = this.layoutControlMain;
            this.txtUserNameBHYT.TabIndex = 7;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.txtUserNameBHYT;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 115);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(265, 26);
            this.layoutControlItem5.Text = "User name BHYT:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(83, 13);
            // 
            // txtPasswordBHYT
            // 
            this.txtPasswordBHYT.Location = new System.Drawing.Point(99, 153);
            this.txtPasswordBHYT.MenuManager = this.ribbonControl;
            this.txtPasswordBHYT.Name = "txtPasswordBHYT";
            this.txtPasswordBHYT.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordBHYT.Properties.Appearance.Options.UseFont = true;
            this.txtPasswordBHYT.Properties.UseSystemPasswordChar = true;
            this.txtPasswordBHYT.Size = new System.Drawing.Size(174, 22);
            this.txtPasswordBHYT.StyleController = this.layoutControlMain;
            this.txtPasswordBHYT.TabIndex = 8;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.txtPasswordBHYT;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 141);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(265, 26);
            this.layoutControlItem6.Text = "Password BHYT:";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(83, 13);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 104);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(265, 11);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.ImageUri.Uri = "Close;Size16x16;Office2013";
            this.btnCancel.Location = new System.Drawing.Point(144, 193);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(129, 23);
            this.btnCancel.StyleController = this.layoutControlMain;
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Thoát";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.btnCancel;
            this.layoutControlItem7.Location = new System.Drawing.Point(132, 181);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(133, 27);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // btnLuu
            // 
            this.btnLuu.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Appearance.Options.UseFont = true;
            this.btnLuu.ImageUri.Uri = "SaveAs;Size16x16;Office2013";
            this.btnLuu.Location = new System.Drawing.Point(12, 193);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(128, 23);
            this.btnLuu.StyleController = this.layoutControlMain;
            this.btnLuu.TabIndex = 10;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.btnLuu;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 181);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(132, 27);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // FrmThamSoHeThong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 255);
            this.Controls.Add(this.layoutControlMain);
            this.Controls.Add(this.ribbonControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmThamSoHeThong";
            this.Ribbon = this.ribbonControl;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cấu hình hệ thống";
            this.Load += new System.EventHandler(this.FrmThamSoHeThong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlMain)).EndInit();
            this.layoutControlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtServerName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDatabase.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserNameBHYT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPasswordBHYT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraLayout.LayoutControl layoutControlMain;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.TextEdit txtUserName;
        private DevExpress.XtraEditors.TextEdit txtDatabase;
        private DevExpress.XtraEditors.TextEdit txtServerName;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroupMain;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.TextEdit txtPasswordBHYT;
        private DevExpress.XtraEditors.TextEdit txtUserNameBHYT;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
    }
}