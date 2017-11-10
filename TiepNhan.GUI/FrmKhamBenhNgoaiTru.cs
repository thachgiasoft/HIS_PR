using Core.DAL;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using KhamBenh.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TiepNhan.GUI
{
    public partial class FrmKhamBenhNgoaiTru : RibbonForm
    {
        DataTable dataDanhSach;
        KhamBenhEntity khambenh;
        string quyen = "";
        private List<int> listPhongKham = new List<int>();
        FrmLichSuKCB lichSuKCB;
        public FrmKhamBenhNgoaiTru()
        {
            InitializeComponent();
            khambenh = new KhamBenhEntity();
            DataTable phongkham = khambenh.DSKhoaBan(2);
            checkButton();
            lichSuKCB = new FrmLichSuKCB(khambenh.DSCoSoKCB());
            if (phongkham != null)
            {
                foreach (DataRow dr in phongkham.Rows)
                {
                    SimpleButton b = new SimpleButton();
                    b.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    b.Appearance.Options.UseFont = true;
                    b.ImageUri.Uri = "Forward;Size16x16;Office2013";
                    b.Name = dr["MaKhoa"].ToString();
                    b.Size = new System.Drawing.Size(120, 23);
                    b.Text = dr["TenKhoa"].ToString();
                    b.Click += btnNew_Click;
                    flowLayoutPanelChuyenPhong.Controls.Add(b);
                    listPhongKham.Add(Utils.ToInt(b.Name.Substring(b.Name.Length - 2, 2)));
                    if (quyen.IndexOf('2') >= 0 && b.Name != AppConfig.MaKhoa)// mã khoa khác mã kha của nhân viên
                    {
                        b.Enabled = true;
                    }
                    else
                    {
                        b.Enabled = false;
                    }
                }
            }
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.WindowState = FormWindowState.Maximized;
        }
        private void checkButton()
        {
            quyen = Core.DAL.Utils.GetQuyen(this.Name);
        }
        private void FrmKhamBenhNgoaiTru_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            checkChoKham.Checked = false;
            dataDanhSach = khambenh.DSTiepNhan(DateTime.Now.ToShortDateString(),
                Utils.ToInt(AppConfig.MaKhoa.Substring(AppConfig.MaKhoa.Length - 2, 2)));
            checkChoKham.Checked = true;
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            SimpleButton clickedButton = (SimpleButton)sender;
            ChuyenPhong(Utils.ToInt(clickedButton.Name.Substring(clickedButton.Name.Length - 2, 2)));
        }
        private void GanSoLuongPhongKham(DataTable data, string sql = null)
        {
            lblPhongKham.Text = "";

            var sqlCountPhong = listPhongKham.Aggregate(string.Empty,
                (total, part) => total + "SUM(CASE WHEN PHONG = " + part + " THEN 1 ELSE 0 END) AS Phong" + part + ",");
            sqlCountPhong = "SELECT " + sqlCountPhong.Substring(0, sqlCountPhong.Length - 1) + " FROM ThongTinBNChiTiet " +
                "Where CAST(NgayVao AS DATE) = CAST('" + DateTime.Now.ToShortDateString() + "' AS DATE)";
            if (sql != null)
            {
                sqlCountPhong += " And " + sql;
            }
            var dt = khambenh.CountSoLuongBN(sqlCountPhong);
            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (var t in listPhongKham)
                {
                    lblPhongKham.Text += "Phòng khám " + t + ": " + dt.Rows[0]["Phong" + t] + "     ";
                }
            }
            else
            {
                foreach (var t in listPhongKham)
                {
                    lblPhongKham.Text += "Phòng khám " + t + ": 0     ";
                }
            }
            gridControl.DataSource = data;
        }
        private void checkTatCa_CheckedChanged(object sender, EventArgs e)
        {
            if (checkTatCa.Checked)
            {
                gridControl.DataSource = dataDanhSach;
                GanSoLuongPhongKham(dataDanhSach, null);
            }
        }

        private void checkChoKham_CheckedChanged(object sender, EventArgs e)
        {
            if (checkChoKham.Checked)
            {
                var data = dataDanhSach.Select(Library.SqlChoKham);
                if (data.Length > 0)
                    GanSoLuongPhongKham(data.CopyToDataTable(), Library.SqlChoKham);
                else
                    GanSoLuongPhongKham(null, Library.SqlChoKham);
            }
        }

        private void checkDaKham_CheckedChanged(object sender, EventArgs e)
        {
            if (checkDaKham.Checked)
            {
                var data = dataDanhSach.Select(Library.SqlDaKham);
                if (data.Length > 0)
                    GanSoLuongPhongKham(data.CopyToDataTable(), Library.SqlDaKham);
                else
                    GanSoLuongPhongKham(null, Library.SqlDaKham);
            }
        }

        private void checkChuyenTuyen_CheckedChanged(object sender, EventArgs e)
        {
            if (checkChuyenTuyen.Checked)
            {
                var data = dataDanhSach.Select(Library.SqlChuyenTuyen);
                if (data.Length > 0)
                    GanSoLuongPhongKham(data.CopyToDataTable(), Library.SqlChuyenTuyen);
                else
                    GanSoLuongPhongKham(null, Library.SqlChuyenTuyen);
            }
        }

        private void checkNhapVien_CheckedChanged(object sender, EventArgs e)
        {
            if (checkNhapVien.Checked)
            {
                var data = dataDanhSach.Select(Library.SqlNhapVien);
                if (data.Length > 0)
                    GanSoLuongPhongKham(data.CopyToDataTable(), Library.SqlNhapVien);
                else
                    GanSoLuongPhongKham(null, Library.SqlNhapVien);
            }
        }

        private void checkRaVien_CheckedChanged(object sender, EventArgs e)
        {
            if (checkRaVien.Checked)
            {
                var data = dataDanhSach.Select(Library.SqlRaVien);
                if (data.Length > 0)
                    GanSoLuongPhongKham(data.CopyToDataTable(), Library.SqlRaVien);
                else
                    GanSoLuongPhongKham(null, Library.SqlRaVien);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadData();
            checkChoKham.Checked = true;
        }

        private void gridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.Name == "GioiTinhDS")
            {
                if (Utils.ToInt(e.Value) == 0)
                    e.DisplayText = "Nam";
                else
                    e.DisplayText = "Nữ";
            }
            else
                if (e.Column.Name == "TinhTrang")
            {
                switch (Utils.ToInt(e.Value))
                {
                    case 2:
                        e.DisplayText = "Cấp cứu";
                        break;
                    case 1:
                        e.DisplayText = "Ưu tiên";
                        break;
                    default:
                        e.DisplayText = "Thường";
                        break;
                }
            }
        }

        private async void btnLichSuKCB_Click(object sender, EventArgs e)
        {
            DataRow dr = gridView.GetFocusedDataRow();
            if (dr != null)
            {
                if (Utils.ToBoolean(dr["CoThe"]) == true)
                {
                    ThongTinThe thongtin = new ThongTinThe();
                    thongtin.MaBN = null;
                    thongtin.MaThe = dr["MaThe"].ToString();
                    thongtin.HoTen = dr["HoTen"].ToString();
                    thongtin.NgaySinh = dr["NgaySinh"].ToString();
                    thongtin.GioiTinh = Utils.ToInt(dr["GioiTinh"]);
                    thongtin.MaCoSoDKKCB = dr["MaDKBD"].ToString();
                    thongtin.TheTu = dr["TheTu"].ToString(); ;
                    thongtin.TheDen = dr["TheDen"].ToString();
                    thongtin = await Utils.LichSuKhamChuaBenhBHYT(thongtin);
                    if (thongtin.Code == "false")
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
                else
                {
                    // Lấy danh sách lịch sử từ phần mềm, dựa vào họ tên, ngày sinh, giới tính -> mã bệnh nhân
                    ThongTinThe thongtin = new ThongTinThe();
                    thongtin.MaBN = dr["MaBN"].ToString();
                    thongtin.MaThe = null;
                    thongtin.HoTen = dr["HoTen"].ToString();
                    thongtin.NgaySinh = dr["NgaySinh"].ToString();
                    thongtin.GioiTinh = Utils.ToInt(dr["GioiTinh"]);
                    // lấy lịch sử
                    thongtin.LichSuPhanMem = khambenh.DSLichSuPhanMem(thongtin.MaBN, thongtin.HoTen, thongtin.GioiTinh);
                    lichSuKCB.ThongTin = thongtin;
                    lichSuKCB.ShowDialog();
                }
            }
        }
        private void ChuyenPhong(int soPhong)
        {
            DataRow dr = gridView.GetFocusedDataRow();
            if (dr != null)
            {
                DialogResult traloi;
                traloi = XtraMessageBox.Show(Library.ChuyenBenhNhan + soPhong, "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (traloi == DialogResult.Yes)
                {
                    if (!string.IsNullOrEmpty(dr["MaBenh"].ToString()) ||
                        !string.IsNullOrEmpty(dr["NgayRa"].ToString()))
                    {
                        XtraMessageBox.Show(Library.BenhNhanDaKhamRaVien, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else// thực hiện chuyển phòng và cấp số mới
                    {
                        khambenh.MaLK = dr["MaLK"].ToString();
                        khambenh.NgayVao = Utils.ToDateTime(dr["NgayVao"].ToString());
                        khambenh.Phong = soPhong;
                        string err = null;
                        if (!khambenh.SpChuyenPhong(ref err))
                        {
                            XtraMessageBox.Show(err, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    LoadData();
                }
            }
        }

        private void btnChuyenTuyen_Click(object sender, EventArgs e)
        {
            // chuyển tuyến : Tình trạng ra viện 2: Chuyển viện
            DataRow dr = gridView.GetFocusedDataRow();
            if (dr != null)
            {
                DialogResult traloi;
                traloi = XtraMessageBox.Show(Library.ChuyenTuyenBenhNhan, "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (traloi == DialogResult.Yes)
                {
                    khambenh.MaLK = dr["MaLK"].ToString();
                    khambenh.TinhTrangRaVien = 2;
                    string err = null;
                    if (!khambenh.SpChuyenVien(ref err))
                    {
                        XtraMessageBox.Show(err, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    LoadData();
                }
            }
        }

        private void btnNhapVien_Click(object sender, EventArgs e)
        {
            // MaLoaiKCB 1. Khám bệnh, 2. Điều trị ngoại trú, 3. Điều trị nội trú
            // chọn khoa: MaKhoa
            DataRow dr = gridView.GetFocusedDataRow();
            if (dr != null)
            {
                FrmChonKhoa frm = new FrmChonKhoa(khambenh.DSKhoaBan(1));
                if (frm.ShowDialog(this) == DialogResult.OK)
                {
                    khambenh.MaLK = dr["MaLK"].ToString();
                    khambenh.MaLoaiKCB = 3;
                    khambenh.MaKhoa = frm.MaKhoa;
                }
            }
        }
    }
}
