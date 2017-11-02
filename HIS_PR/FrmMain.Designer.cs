namespace HIS_PR
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.ribbonControlMain = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barLinkSkin = new DevExpress.XtraBars.BarLinkContainerItem();
            this.barQuanTriHeThong = new DevExpress.XtraBars.BarButtonItem();
            this.barDanhMucNhanVien = new DevExpress.XtraBars.BarButtonItem();
            this.barlblMaNV = new DevExpress.XtraBars.BarStaticItem();
            this.barbtnLogout = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barDanhMucDungChung = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonNhapKho = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonXuatKho = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonPLinhThuoc = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonYCLinhThuoc = new DevExpress.XtraBars.BarButtonItem();
            this.barDanhMucCSKCB = new DevExpress.XtraBars.BarButtonItem();
            this.barBaoCaoNhapXuat = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonNhapKhaTra = new DevExpress.XtraBars.BarButtonItem();
            this.barTonKho = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonTiepNhan = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageHeThong = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupHeThong = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageTiepNhan = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupTiepNhan = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageDanhMuc = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupDanhMuc = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupCSKCB = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageDuocPham = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupNhapChuyenKho = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupQuanLyDuoc = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageBaoCao = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupBaoCao = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBarMain = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControlMain)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControlMain
            // 
            this.ribbonControlMain.ExpandCollapseItem.Id = 0;
            this.ribbonControlMain.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControlMain.ExpandCollapseItem,
            this.barLinkSkin,
            this.barQuanTriHeThong,
            this.barDanhMucNhanVien,
            this.barlblMaNV,
            this.barbtnLogout,
            this.barSubItem1,
            this.barButtonItem1,
            this.barDanhMucDungChung,
            this.barButtonNhapKho,
            this.barButtonXuatKho,
            this.barButtonPLinhThuoc,
            this.barButtonYCLinhThuoc,
            this.barDanhMucCSKCB,
            this.barBaoCaoNhapXuat,
            this.barButtonNhapKhaTra,
            this.barTonKho,
            this.barButtonTiepNhan});
            this.ribbonControlMain.Location = new System.Drawing.Point(0, 0);
            this.ribbonControlMain.MaxItemId = 24;
            this.ribbonControlMain.Name = "ribbonControlMain";
            this.ribbonControlMain.PageHeaderItemLinks.Add(this.barLinkSkin);
            this.ribbonControlMain.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPageHeThong,
            this.ribbonPageTiepNhan,
            this.ribbonPageDanhMuc,
            this.ribbonPageDuocPham,
            this.ribbonPageBaoCao});
            this.ribbonControlMain.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControlMain.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControlMain.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.True;
            this.ribbonControlMain.Size = new System.Drawing.Size(1290, 143);
            this.ribbonControlMain.StatusBar = this.ribbonStatusBarMain;
            // 
            // barLinkSkin
            // 
            this.barLinkSkin.Caption = "Giao diện";
            this.barLinkSkin.Id = 8;
            this.barLinkSkin.Name = "barLinkSkin";
            // 
            // barQuanTriHeThong
            // 
            this.barQuanTriHeThong.Caption = "Quản trị hệ thống";
            this.barQuanTriHeThong.Id = 1;
            this.barQuanTriHeThong.ImageOptions.Image = global::HIS_PR.Properties.Resources.system_icon;
            this.barQuanTriHeThong.Name = "barQuanTriHeThong";
            this.barQuanTriHeThong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barQuanTriHeThong_ItemClick);
            // 
            // barDanhMucNhanVien
            // 
            this.barDanhMucNhanVien.Caption = "Danh mục nhân viên";
            this.barDanhMucNhanVien.Id = 3;
            this.barDanhMucNhanVien.ImageOptions.Image = global::HIS_PR.Properties.Resources.user_settings_icon;
            this.barDanhMucNhanVien.Name = "barDanhMucNhanVien";
            this.barDanhMucNhanVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barDanhMucNhanVien_ItemClick);
            // 
            // barlblMaNV
            // 
            this.barlblMaNV.Caption = "NhanVien";
            this.barlblMaNV.Id = 9;
            this.barlblMaNV.Name = "barlblMaNV";
            this.barlblMaNV.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barbtnLogout
            // 
            this.barbtnLogout.Caption = "Thoát";
            this.barbtnLogout.Id = 10;
            this.barbtnLogout.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barbtnLogout.ImageOptions.Image")));
            this.barbtnLogout.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barbtnLogout.ImageOptions.LargeImage")));
            this.barbtnLogout.Name = "barbtnLogout";
            this.barbtnLogout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtnLogout_ItemClick);
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "barSubItem1";
            this.barSubItem1.Id = 12;
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1)});
            this.barSubItem1.Name = "barSubItem1";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 13;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barDanhMucDungChung
            // 
            this.barDanhMucDungChung.Caption = "Danh mục dùng chung";
            this.barDanhMucDungChung.Id = 14;
            this.barDanhMucDungChung.ImageOptions.Image = global::HIS_PR.Properties.Resources.category_icon;
            this.barDanhMucDungChung.Name = "barDanhMucDungChung";
            this.barDanhMucDungChung.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barDanhMucKhac_ItemClick);
            // 
            // barButtonNhapKho
            // 
            this.barButtonNhapKho.Caption = "Nhập kho";
            this.barButtonNhapKho.Id = 15;
            this.barButtonNhapKho.ImageOptions.Image = global::HIS_PR.Properties.Resources.store_icon;
            this.barButtonNhapKho.Name = "barButtonNhapKho";
            this.barButtonNhapKho.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonNhapKho_ItemClick);
            // 
            // barButtonXuatKho
            // 
            this.barButtonXuatKho.Caption = "Xuất kho";
            this.barButtonXuatKho.Id = 16;
            this.barButtonXuatKho.ImageOptions.Image = global::HIS_PR.Properties.Resources.store_label_icon;
            this.barButtonXuatKho.Name = "barButtonXuatKho";
            this.barButtonXuatKho.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonXuatKho_ItemClick);
            // 
            // barButtonPLinhThuoc
            // 
            this.barButtonPLinhThuoc.Caption = "Phiếu lĩnh thuốc";
            this.barButtonPLinhThuoc.Id = 17;
            this.barButtonPLinhThuoc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonPLinhThuoc.ImageOptions.Image")));
            this.barButtonPLinhThuoc.Name = "barButtonPLinhThuoc";
            this.barButtonPLinhThuoc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonPLinhThuoc_ItemClick);
            // 
            // barButtonYCLinhThuoc
            // 
            this.barButtonYCLinhThuoc.Caption = "Yêu cầu lĩnh thuốc";
            this.barButtonYCLinhThuoc.Id = 18;
            this.barButtonYCLinhThuoc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonYCLinhThuoc.ImageOptions.Image")));
            this.barButtonYCLinhThuoc.Name = "barButtonYCLinhThuoc";
            this.barButtonYCLinhThuoc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonYCLinhThuoc_ItemClick);
            // 
            // barDanhMucCSKCB
            // 
            this.barDanhMucCSKCB.Caption = "Danh mục tại CSKCB";
            this.barDanhMucCSKCB.Id = 19;
            this.barDanhMucCSKCB.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barDanhMucCSKCB.ImageOptions.Image")));
            this.barDanhMucCSKCB.Name = "barDanhMucCSKCB";
            this.barDanhMucCSKCB.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barDanhMucCSKCB_ItemClick);
            // 
            // barBaoCaoNhapXuat
            // 
            this.barBaoCaoNhapXuat.Caption = "Báo cáo nhập xuất";
            this.barBaoCaoNhapXuat.Id = 20;
            this.barBaoCaoNhapXuat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBaoCaoNhapXuat.ImageOptions.Image")));
            this.barBaoCaoNhapXuat.Name = "barBaoCaoNhapXuat";
            this.barBaoCaoNhapXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBaoCaoNhapXuat_ItemClick);
            // 
            // barButtonNhapKhaTra
            // 
            this.barButtonNhapKhaTra.Caption = "Nhập khoa trả";
            this.barButtonNhapKhaTra.Id = 21;
            this.barButtonNhapKhaTra.ImageOptions.Image = global::HIS_PR.Properties.Resources.store_arrow_icon;
            this.barButtonNhapKhaTra.Name = "barButtonNhapKhaTra";
            this.barButtonNhapKhaTra.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonNhapKhaTra_ItemClick);
            // 
            // barTonKho
            // 
            this.barTonKho.Caption = "Tồn kho theo ngày";
            this.barTonKho.Id = 22;
            this.barTonKho.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barTonKho.ImageOptions.Image")));
            this.barTonKho.Name = "barTonKho";
            this.barTonKho.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barTonKho_ItemClick);
            // 
            // barButtonTiepNhan
            // 
            this.barButtonTiepNhan.Caption = "Tiếp nhận hồ sơ";
            this.barButtonTiepNhan.Id = 23;
            this.barButtonTiepNhan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonTiepNhan.ImageOptions.Image")));
            this.barButtonTiepNhan.Name = "barButtonTiepNhan";
            this.barButtonTiepNhan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonTiepNhan_ItemClick);
            // 
            // ribbonPageHeThong
            // 
            this.ribbonPageHeThong.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupHeThong});
            this.ribbonPageHeThong.Name = "ribbonPageHeThong";
            this.ribbonPageHeThong.Text = "Hệ thống";
            // 
            // ribbonPageGroupHeThong
            // 
            this.ribbonPageGroupHeThong.ItemLinks.Add(this.barQuanTriHeThong);
            this.ribbonPageGroupHeThong.Name = "ribbonPageGroupHeThong";
            this.ribbonPageGroupHeThong.ShowCaptionButton = false;
            // 
            // ribbonPageTiepNhan
            // 
            this.ribbonPageTiepNhan.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupTiepNhan});
            this.ribbonPageTiepNhan.Name = "ribbonPageTiepNhan";
            this.ribbonPageTiepNhan.Text = "Tiếp nhận";
            // 
            // ribbonPageGroupTiepNhan
            // 
            this.ribbonPageGroupTiepNhan.ItemLinks.Add(this.barButtonTiepNhan);
            this.ribbonPageGroupTiepNhan.Name = "ribbonPageGroupTiepNhan";
            this.ribbonPageGroupTiepNhan.ShowCaptionButton = false;
            // 
            // ribbonPageDanhMuc
            // 
            this.ribbonPageDanhMuc.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupDanhMuc,
            this.ribbonPageGroupCSKCB});
            this.ribbonPageDanhMuc.Name = "ribbonPageDanhMuc";
            this.ribbonPageDanhMuc.Text = "Danh mục";
            // 
            // ribbonPageGroupDanhMuc
            // 
            this.ribbonPageGroupDanhMuc.ItemLinks.Add(this.barDanhMucNhanVien);
            this.ribbonPageGroupDanhMuc.ItemLinks.Add(this.barDanhMucDungChung);
            this.ribbonPageGroupDanhMuc.Name = "ribbonPageGroupDanhMuc";
            this.ribbonPageGroupDanhMuc.ShowCaptionButton = false;
            // 
            // ribbonPageGroupCSKCB
            // 
            this.ribbonPageGroupCSKCB.ItemLinks.Add(this.barDanhMucCSKCB);
            this.ribbonPageGroupCSKCB.Name = "ribbonPageGroupCSKCB";
            this.ribbonPageGroupCSKCB.ShowCaptionButton = false;
            // 
            // ribbonPageDuocPham
            // 
            this.ribbonPageDuocPham.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupNhapChuyenKho,
            this.ribbonPageGroupQuanLyDuoc});
            this.ribbonPageDuocPham.Name = "ribbonPageDuocPham";
            this.ribbonPageDuocPham.Text = "Dược phẩm";
            // 
            // ribbonPageGroupNhapChuyenKho
            // 
            this.ribbonPageGroupNhapChuyenKho.ItemLinks.Add(this.barButtonNhapKho);
            this.ribbonPageGroupNhapChuyenKho.ItemLinks.Add(this.barButtonXuatKho);
            this.ribbonPageGroupNhapChuyenKho.ItemLinks.Add(this.barButtonNhapKhaTra);
            this.ribbonPageGroupNhapChuyenKho.ItemLinks.Add(this.barButtonPLinhThuoc);
            this.ribbonPageGroupNhapChuyenKho.Name = "ribbonPageGroupNhapChuyenKho";
            // 
            // ribbonPageGroupQuanLyDuoc
            // 
            this.ribbonPageGroupQuanLyDuoc.ItemLinks.Add(this.barButtonYCLinhThuoc);
            this.ribbonPageGroupQuanLyDuoc.Name = "ribbonPageGroupQuanLyDuoc";
            // 
            // ribbonPageBaoCao
            // 
            this.ribbonPageBaoCao.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupBaoCao});
            this.ribbonPageBaoCao.Name = "ribbonPageBaoCao";
            this.ribbonPageBaoCao.Text = "Báo cáo";
            // 
            // ribbonPageGroupBaoCao
            // 
            this.ribbonPageGroupBaoCao.ItemLinks.Add(this.barBaoCaoNhapXuat);
            this.ribbonPageGroupBaoCao.ItemLinks.Add(this.barTonKho);
            this.ribbonPageGroupBaoCao.Name = "ribbonPageGroupBaoCao";
            this.ribbonPageGroupBaoCao.ShowCaptionButton = false;
            this.ribbonPageGroupBaoCao.Text = "Dược";
            // 
            // ribbonStatusBarMain
            // 
            this.ribbonStatusBarMain.ItemLinks.Add(this.barlblMaNV);
            this.ribbonStatusBarMain.ItemLinks.Add(this.barbtnLogout);
            this.ribbonStatusBarMain.Location = new System.Drawing.Point(0, 668);
            this.ribbonStatusBarMain.Name = "ribbonStatusBarMain";
            this.ribbonStatusBarMain.Ribbon = this.ribbonControlMain;
            this.ribbonStatusBarMain.Size = new System.Drawing.Size(1290, 31);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 699);
            this.Controls.Add(this.ribbonStatusBarMain);
            this.Controls.Add(this.ribbonControlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "FrmMain";
            this.Ribbon = this.ribbonControlMain;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBarMain;
            this.Text = "Hệ thống quản lý bệnh viện";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControlMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControlMain;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBarMain;   
        private DevExpress.XtraBars.BarLinkContainerItem barLinkSkin;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageHeThong;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupHeThong;
        private DevExpress.XtraBars.BarButtonItem barQuanTriHeThong;
        private DevExpress.XtraBars.BarButtonItem barDanhMucNhanVien;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageDanhMuc;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupDanhMuc;
        private DevExpress.XtraBars.BarStaticItem barlblMaNV;
        private DevExpress.XtraBars.BarButtonItem barbtnLogout;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barDanhMucDungChung;
        private DevExpress.XtraBars.BarButtonItem barButtonNhapKho;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageDuocPham;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupNhapChuyenKho;
        private DevExpress.XtraBars.BarButtonItem barButtonXuatKho;
        private DevExpress.XtraBars.BarButtonItem barButtonPLinhThuoc;
        private DevExpress.XtraBars.BarButtonItem barButtonYCLinhThuoc;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupQuanLyDuoc;
        private DevExpress.XtraBars.BarButtonItem barDanhMucCSKCB;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupCSKCB;
        private DevExpress.XtraBars.BarButtonItem barBaoCaoNhapXuat;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageBaoCao;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupBaoCao;
        private DevExpress.XtraBars.BarButtonItem barButtonNhapKhaTra;
        private DevExpress.XtraBars.BarButtonItem barTonKho;
        private DevExpress.XtraBars.BarButtonItem barButtonTiepNhan;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageTiepNhan;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupTiepNhan;
    }
}