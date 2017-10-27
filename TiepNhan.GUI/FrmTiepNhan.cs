using DevExpress.XtraBars.Ribbon;
using KhamBenh.DAL;
using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Core.DAL;
using System.Threading.Tasks;

namespace TiepNhan.GUI
{
    public partial class FrmTiepNhan : RibbonForm
    {
        TiepNhanEntity tiepnhan;
        DataTable dataCoso,dataTinh,dataMucHuong;
        private bool themMoi = true;
        FrmLichSuKCB lichSuKCB = new FrmLichSuKCB();
        public FrmTiepNhan()
        {
            InitializeComponent();
            tiepnhan = new TiepNhanEntity();

            lookUpTaiNan.Properties.DataSource = tiepnhan.DSTaiNan();
            lookUpTaiNan.Properties.DisplayMember = "Ten";
            lookUpTaiNan.Properties.ValueMember = "Ma";
            dataCoso = tiepnhan.DSCoSoKCB();
            lookUpNoiChuyenDen.Properties.DataSource = dataCoso;
            lookUpNoiChuyenDen.Properties.ValueMember = "Ma_CS";
            lookUpNoiChuyenDen.Properties.DisplayMember = "Ten_CS";
            cbLoaiKCB.SelectedIndex = 0;

            DataTable phongkham = tiepnhan.DSKhoaBan(2);
            if(phongkham!=null)
            {
                foreach(DataRow dr in phongkham.Rows)
                {
                    SimpleButton b = new SimpleButton();
                    b.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    b.Appearance.Options.UseFont = true;
                    b.ImageUri.Uri = "Forward;Size16x16;Office2013";
                    b.Name = dr["MaKhoa"].ToString();
                    b.Size = new System.Drawing.Size(120, 27);
                    b.Text = dr["TenKhoa"].ToString();
                    b.Click += btnNew_Click;
                    flowLayoutPanel.Controls.Add(b);
                }
            }
            // Data Tỉnh, Mức hưởng
            dataTinh = tiepnhan.DSTinh();
            dataMucHuong = tiepnhan.DSMucHuong();
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                KiemTraThongTinTiepNhan(true);
                SimpleButton clickedButton = (SimpleButton)sender;
                ChuyenPhong(Utils.ToInt(clickedButton.Name.ToLower().Replace("phongkham", "")));
            }
            catch { }
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.WindowState = FormWindowState.Maximized;
        }
        private void FrmTiepNhan_Load(object sender, EventArgs e)
        {
            ResetForm();
            this.ActiveControl = txtMaQR;
        }
        private void ResetForm()
        {
            checkBHYT.Checked = true;
            txtNgayTN.Text = DateTime.Now.ToString("dd/MM/yyyy");
            cbGioiTinh.SelectedIndex = 0;
            cbLyDoVaoVien.SelectedIndex = 0;
            lookUpTaiNan.ItemIndex = 0;
            cbLoaiKCB.SelectedIndex = 0;
            checkCapCuu.Checked = false;
            checkChiTra.Checked = false;
            checkUuTien.Checked = false;
            themMoi = true;
            // thông tin bệnh nhân
            txtMaQR.Text = null;
            cbKhuVuc.SelectedItem = null;
            txtTheBHYT.Text = null;
            txtTheTu.Text = null;
            txtTheDen.Text = null;
            txtTyLe.Text = null;
            txtTenDKKCB.Text = null;
            txtSTTNgay.Text = null;
            txtNgaySinh.Text = null;
            txtMucHuong.Text = null;
            txtMaDKKCB.Text = null;
            txtHoTen.Text = null;
            txtDu5Nam.Text = null;
            txtCanNang.Text = null;
            txtDiaChi.Text = null;

        }
        private void checkBHYT_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBHYT.Checked == true)
            {
                txtMaQR.ReadOnly = false;
                txtTheBHYT.ReadOnly = false;
                txtTheTu.ReadOnly = false;
                txtTheDen.ReadOnly = false;
                txtMaDKKCB.ReadOnly = false;
                txtTenDKKCB.ReadOnly = false;
                txtDu5Nam.ReadOnly = false;
                cbKhuVuc.ReadOnly = false;
                txtMaBN.ReadOnly = true;
                btnKtraThongTuyen.Enabled = true;
                txtMaQR.Focus();
            }
            else
            {
                txtMaQR.ReadOnly = true;
                txtMaQR.Text = null;
                txtTheBHYT.ReadOnly = true;
                txtTheBHYT.Text = null;
                txtTheTu.ReadOnly = true;
                txtTheTu.Text = null;
                txtTheDen.ReadOnly = true;
                txtTheDen.Text = null;
                txtMaDKKCB.ReadOnly = true;
                txtMaDKKCB.Text = null;
                txtTenDKKCB.ReadOnly = true;
                txtTenDKKCB.Text = null;
                txtDu5Nam.ReadOnly = true;
                txtDu5Nam.Text = null;
                cbKhuVuc.ReadOnly = true;
                cbKhuVuc.SelectedItem = null;
                txtMaBN.ReadOnly = false;
                txtMucHuong.Text = "0";
                txtTyLe.Text = "0";
                btnKtraThongTuyen.Enabled = false;
                txtMaBN.Focus();
            }
        }

        private void checkCapCuu_CheckedChanged(object sender, EventArgs e)
        {
            if(checkCapCuu.Checked == true)
            {
                checkUuTien.Checked = false;
                cbLyDoVaoVien.SelectedIndex = 1;
            }
            else
            {
                cbLyDoVaoVien.SelectedIndex = 0;
            }
        }

        private void checkUuTien_CheckedChanged(object sender, EventArgs e)
        {
            if(checkUuTien.Checked == true)
            {
                checkCapCuu.Checked = false;
            }
        }
        private void ChuyenPhong(int phongKham)
        {
            XtraMessageBox.Show("Chuyển phòng: "+phongKham);
        }

        private void btnNhapMoi_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private async void btnKtraThongTuyen_Click(object sender, EventArgs e)
        {
            if (KiemTraThongTinTiepNhan() == false)
                return;
            ThongTinThe thongtin = await Utils.KiemTraThongTuyen(txtTheBHYT.Text, txtHoTen.Text, txtNgaySinh.Text);
            switch(thongtin.Code)
            {
                case "1":
                    // chỉnh thông tin
                    if (thongtin.HoTen != txtHoTen.Text)
                    {
                        txtHoTen.Text = thongtin.HoTen;
                    }
                    if (thongtin.NgaySinh != txtNgaySinh.Text)
                    {
                        txtNgaySinh.Text = thongtin.NgaySinh;
                    }
                    if(cbGioiTinh.SelectedIndex != thongtin.GioiTinh)
                    {
                        cbGioiTinh.SelectedIndex = thongtin.GioiTinh;
                    }
                    if (txtDiaChi.Text != thongtin.DiaChi)
                    {
                        txtDiaChi.Text = thongtin.DiaChi;
                    }
                    if (txtMaDKKCB.Text != thongtin.MaCoSoDKKCB)
                    {
                        txtMaDKKCB.Text = thongtin.MaCoSoDKKCB;
                        object ten = lookUpNoiChuyenDen.Properties.GetDisplayValueByKeyValue(thongtin.MaCoSoDKKCB);
                        if (ten != null)
                            txtTenDKKCB.Text = ten.ToString();
                        else
                            txtTenDKKCB.Text = null;
                    }
                    if(txtTheTu.Text != thongtin.TheTu)
                    {
                        txtTheTu.Text = thongtin.TheTu;
                    }
                    if (txtTheDen.Text != thongtin.TheDen)
                    {
                        txtTheDen.Text = thongtin.TheDen;
                    }
                    btnLichSuKCB.Focus();
                    break;
                default:
                    XtraMessageBox.Show(thongtin.ThongBao.Replace(":", ""), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private async void btnLichSuKCB_Click(object sender, EventArgs e)
        {
            if(checkBHYT.Checked == true )
            {
                // Lấy danh sách lịch sử trên cổng (trên phần mềm nếu cổng lỗi)
                if (KiemTraThongTinTiepNhan(true))
                {
                    ThongTinThe thongtin = new ThongTinThe();
                    thongtin.MaBN = null;
                    thongtin.MaThe = txtTheBHYT.Text;
                    thongtin.HoTen = txtHoTen.Text;
                    thongtin.NgaySinh = txtNgaySinh.Text;
                    thongtin.GioiTinh = cbGioiTinh.SelectedIndex;
                    thongtin.MaCoSoDKKCB = txtMaDKKCB.Text;
                    thongtin.TheTu = txtTheTu.Text;
                    thongtin.TheDen = txtTheDen.Text;
                    thongtin = await Utils.LichSuKhamChuaBenhBHYT(thongtin);
                    if(thongtin.Code == "false")
                    {
                        // lỗi hệ thống
                        XtraMessageBox.Show(thongtin.ThongBao, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        // hiện thông báo, lịch sử
                        lichSuKCB.ThongTin = thongtin;
                        lichSuKCB.ShowDialog();
                    }
                }
            }
            else
            if(KiemTraThongTinTiepNhan())
            {
                // Lấy danh sách lịch sử từ phần mềm, dựa vào họ tên, ngày sinh, giới tính -> mã bệnh nhân
                ThongTinThe thongtin = new ThongTinThe();
                thongtin.MaBN = "";
                thongtin.MaThe = null;
                thongtin.HoTen = txtHoTen.Text;
                thongtin.NgaySinh = txtNgaySinh.Text;
                thongtin.GioiTinh = cbGioiTinh.SelectedIndex;
                lichSuKCB.ThongTin = thongtin;
                lichSuKCB.ShowDialog();
            }
        }

        private void btnInLai_Click(object sender, EventArgs e)
        {

        }

        private void txtMaQR_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                kiemTraQR();
            }
        }

        private void txtTheBHYT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtTheTu.Focus();
            }
        }

        private void txtTheTu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtTheDen.Focus();
            }
        }

        private void txtTheDen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtMaDKKCB.Focus();
            }
        }

        private void txtHoTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtHoTen.Text = Utils.VietHoaTuDong(txtHoTen.Text);
                cbGioiTinh.Focus();
            }
        }

        private void cbGioiTinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtNgaySinh.Focus();
            }
        }

        private void txtNgaySinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtDiaChi.Focus();
            }
        }

        private void txtDiaChi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtDiaChi.Text = Utils.VietHoaTuDong(txtDiaChi.Text);
                if (checkBHYT.Checked)
                    btnKtraThongTuyen.Focus();
                else
                    btnLichSuKCB.Focus();
            }
        }

        private void txtMaDKKCB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                // lấy tên CoSo
                object ten = lookUpNoiChuyenDen.Properties.GetDisplayValueByKeyValue(txtMaDKKCB.Text);
                if (ten != null)
                    txtTenDKKCB.Text = ten.ToString();
                else
                    txtTenDKKCB.Text = null;
                txtHoTen.Focus();
            }
        }
        private void kiemTraQR()
        {
            if (txtMaQR.Text.Length > 0)
            {
                string[] qr = null;
                if (txtMaQR.Text.Split('~').Length > 1)
                {
                    qr = txtMaQR.Text.Split('~');
                }
                if (txtMaQR.Text.Split('|').Length > 1)
                {
                    qr = txtMaQR.Text.Split('|');
                }
                if (qr != null && qr.Length == 15)
                {
                    txtTheBHYT.Text = qr[0];
                    txtHoTen.Text = Utils.HexToText(qr[1]);
                    txtNgaySinh.Text = qr[2];
                    if (int.Parse(qr[3]) == 1)
                    {
                        cbGioiTinh.SelectedIndex = 0;
                    }
                    else
                    {
                        cbGioiTinh.SelectedIndex = 1;
                    }
                    txtDiaChi.Text = Utils.HexToText(qr[4]);
                    txtMaDKKCB.Text = qr[5].Remove(2, 3);
                    // lấy tên CoSo
                    object ten = lookUpNoiChuyenDen.Properties.GetDisplayValueByKeyValue(txtMaDKKCB.Text);
                    if (ten != null)
                        txtTenDKKCB.Text = ten.ToString();
                    else
                        txtTenDKKCB.Text = null;
                    txtTheTu.Text = qr[6];
                    txtTheDen.Text = qr[7];
                    txtDu5Nam.Text = qr[12];

                    if (qr[11] == "5")
                    {
                        cbKhuVuc.SelectedIndex = 0;
                    }
                    else
                    if (qr[11] == "6")
                    {
                        cbKhuVuc.SelectedIndex = 1;
                    }
                    else
                    if (qr[11] == "7")
                    {
                        cbKhuVuc.SelectedIndex = 2;
                    }
                    btnKtraThongTuyen.Focus();

                    return;
                }
                else
                {
                    XtraMessageBox.Show("Sai mã QR!","Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMaQR.SelectAll();
                    txtMaQR.Focus();
                }
            }
            txtTheBHYT.Focus();
        }

        private void txtTheBHYT_Leave(object sender, EventArgs e)
        {
            this.txtTheBHYT.Leave -= new System.EventHandler(this.txtTheBHYT_Leave);
            if (checkBHYT.Checked == true && txtTheBHYT.Text.Length > 0)
            {
                if (txtTheBHYT.Text.Length != 15)
                {
                    XtraMessageBox.Show(Library.KyTuTheBHYT, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTheBHYT.Focus();
                    this.txtTheBHYT.Leave += new System.EventHandler(this.txtTheBHYT_Leave);
                    return;
                }
                LayThongTinBenhNhan();
            }
            this.txtTheBHYT.Leave += new System.EventHandler(this.txtTheBHYT_Leave);
        }

        private void txtTheBHYT_EditValueChanged(object sender, EventArgs e)
        {
            LayThongTinBenhNhan();
        }
        private void LayThongTinBenhNhan()
        {
            if (txtTheBHYT.Text.Length == 15)
            {
                // kiểm tra thông tin thẻ (3 ký tự đầu)
                if (CheckMaThe(txtTheBHYT.Text) == false)
                {
                    txtTheBHYT.Focus();
                    return;
                }
                // Lấy thông tin thẻ nếu có trong csdl
                // Hồ sơ bệnh án khám trong ngày
                // Lấy mã bệnh nhân
                tiepnhan.LayThongTinCoThe(txtTheBHYT.Text,
                        Utils.ToDateTime(txtNgayTN.Text, "dd/MM/yyyy").ToShortDateString());
                // Kiểm tra đã tiếp nhận hay chưa, ngày khám 1 lần
                if(!string.IsNullOrEmpty(tiepnhan.MaLK))
                {
                    XtraMessageBox.Show(Library.BenhNhanDaTiepNhan , "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTheBHYT.SelectAll();
                    txtTheBHYT.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtMaQR.Text) && !string.IsNullOrEmpty(tiepnhan.MaBN))
                {
                    // gán thông tin, nếu không quyét bằng mã QR
                    txtMaBN.Text = tiepnhan.MaBN;
                    txtHoTen.Text = tiepnhan.HoTen;
                    txtNgaySinh.Text = tiepnhan.NgaySinh.ToString("dd/MM/yyyy");
                    cbGioiTinh.SelectedIndex = tiepnhan.GioiTinh;
                    txtDiaChi.Text = tiepnhan.DiaChi;
                    txtTheTu.Text = tiepnhan.TheTu.ToString("dd/MM/yyyy");
                    txtTheDen.Text = tiepnhan.TheDen.ToString("dd/MM/yyyy");
                    txtMaDKKCB.Text = tiepnhan.MaCS;
                    object ten = lookUpNoiChuyenDen.Properties.GetDisplayValueByKeyValue(txtMaDKKCB.Text);
                    if (ten != null)
                        txtTenDKKCB.Text = ten.ToString();
                    else
                        txtTenDKKCB.Text = null;
                    txtDu5Nam.Text = tiepnhan.Du5Nam.ToString("dd/MM/yyyy");
                    cbKhuVuc.SelectedItem = tiepnhan.MaKhuVuc;
                    btnKtraThongTuyen.Focus();
                    return;
                }
            }
        }

        private void txtMaBN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13 )
            {
                // lấy thông tin bệnh nhân, không có thẻ
                if(checkBHYT.Checked == false)
                {
                    if(txtMaBN.Text.Length > 11 && tiepnhan.LayThongTinKhongThe(txtMaBN.Text))
                    {
                        txtMaBN.Text = tiepnhan.MaBN;
                        txtHoTen.Text = tiepnhan.HoTen;
                        txtNgaySinh.Text = tiepnhan.NgaySinh.ToString("dd/MM/yyyy");
                        cbGioiTinh.SelectedIndex = tiepnhan.GioiTinh;
                        txtDiaChi.Text = tiepnhan.DiaChi;
                        btnLichSuKCB.Focus();
                    }
                    else
                    {
                        XtraMessageBox.Show(Library.MaBNKhongTonTai, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                txtHoTen.Focus();
            }
        }

        private bool CheckMaThe(string maThe)
        {

            DataRow[] dr = null;
            dr = dataMucHuong.Select("Ma = '"+maThe.Substring(0,3)+"'", "");
            if(dr!=null && dr.Length >0)
            {
                txtTyLe.Text = dr[0]["TyLe"].ToString();
                txtMucHuong.Text = dr[0]["MaHieu"].ToString();
            }
            else
            {
                XtraMessageBox.Show(Library.BaKyTuDau, "Lỗi",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            dr = null;
            dr = dataTinh.Select("Ma = '"+maThe.Substring(3,2)+"'", "");
            if(dr == null || dr.Length == 0)
            {
                XtraMessageBox.Show(Library.HaiKyTuTinh, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private bool KiemTraThongTinTiepNhan(bool ktraChiTiet = false)
        {
            if(string.IsNullOrEmpty( txtTheBHYT.Text) && checkBHYT.Checked)
            {
                XtraMessageBox.Show(Library.NhapMaThe, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTheBHYT.Focus();
                return false;
            }
            if (ktraChiTiet && checkBHYT.Checked)
            {
                if (string.IsNullOrEmpty(txtTheTu.Text))
                {
                    XtraMessageBox.Show(Library.NhapTheTu, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTheTu.Focus();
                    return false;
                }
                if (string.IsNullOrEmpty(txtTheDen.Text))
                {
                    XtraMessageBox.Show(Library.NhapTheDen, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTheDen.Focus();
                    return false;
                }
                DateTime theTu = Utils.ToDateTime(txtTheTu.Text, "dd/MM/yyyy");
                if (theTu > DateTime.Now)
                {
                    XtraMessageBox.Show(Library.TheTuLonHonHienTai, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTheTu.Focus();
                    return false;
                }
                if (theTu > Utils.ToDateTime(txtTheDen.Text,"dd/MM/yyyy"))
                {
                    XtraMessageBox.Show(Library.TheTuLonHonTheDen, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTheDen.Focus();
                    return false;
                }
                if (string.IsNullOrEmpty(txtMaDKKCB.Text))
                {
                    XtraMessageBox.Show(Library.NhapKCBBD, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMaDKKCB.Focus();
                    return false;
                }
            }
            if (string.IsNullOrEmpty(txtHoTen.Text))
            {
                XtraMessageBox.Show(Library.NhapHoTen, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHoTen.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtNgaySinh.Text))
            {
                XtraMessageBox.Show(Library.NhapNgaySinh, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNgaySinh.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtDiaChi.Text) && ktraChiTiet)
            {
                XtraMessageBox.Show(Library.NhapDiaChi, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDiaChi.Focus();
                return false;
            }
            return true;
        }
    }
}
