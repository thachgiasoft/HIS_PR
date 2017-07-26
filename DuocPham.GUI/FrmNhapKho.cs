using DevExpress.XtraBars.Ribbon;
using DuocPham.DAL;
using System;
using System.Windows.Forms;
using Core.DAL;
using DevExpress.XtraEditors;
using System.Data;
using System.Collections.Generic;

namespace DuocPham.GUI
{
    public partial class FrmNhapKho : RibbonForm
    {
        NhapKhoEntity nhapkho;
        string quyen = "";
        string err = "";
        bool them = false;
        DataTable data;
        DataTable dtPhieu;
        Dictionary<string, bool> dsVatTu = new Dictionary<string, bool> ();
        public FrmNhapKho ()
        {
            InitializeComponent ();
            nhapkho = new NhapKhoEntity ();
        }
        protected override void OnLoad (EventArgs e)
        {
            base.OnLoad (e);
            this.WindowState = FormWindowState.Maximized;
        }
        private void FrmNhapKho_Load (object sender, EventArgs e)
        {
            lookUpKhoNhap.Properties.DataSource = nhapkho.DSKho ();
            lookUpKhoNhap.Properties.DisplayMember = "TenKhoa";
            lookUpKhoNhap.Properties.ValueMember = "MaKhoa";

            lookUpNhaCungCap.Properties.DataSource = nhapkho.DSNhaCungCap ();
            lookUpNhaCungCap.Properties.DisplayMember = "Ten";
            lookUpNhaCungCap.Properties.ValueMember = "Ten";

            lookUpNguoiNhan.Properties.DataSource = nhapkho.DSNguoiNhan ();
            lookUpNguoiNhan.Properties.DisplayMember = "Ten_NV";
            lookUpNguoiNhan.Properties.ValueMember = "Ma_NV";

            lookUpMaVatTu.Properties.DisplayMember = "MaBV";

            checkButton ();
            //LoadData ();
        }
        private void LoadData ()
        {
            them = false;
            //dt = vattu.DSVatTu ();
            //gridControl.DataSource = dt;
            //lblSoLuong.Text = dt.Rows.Count.ToString ();
        }

        private void checkButton ()
        {
            quyen = Utils.GetQuyen (this.Name);
            Enabled_Them ();
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
        }
        private void Enabled_Luu ()
        {
            if (quyen.IndexOf ('2') >= 0 || them)
            {
                btnLuu.Enabled = true;
            }
            else
            {
                btnLuu.Enabled = false;
            }
        }
        private void Enabled_Xoa ()
        {
            if (quyen.IndexOf ('3') >= 0)
            {
                btnXoa.Enabled = true;
            }
            else
            {
                btnXoa.Enabled = false;
            }
        }
        private void Enabled_Them ()
        {
            if (quyen.IndexOf ('1') >= 0)
            {
                btnThem.Enabled = true;
            }
            else
            {
                btnThem.Enabled = false;
            }
        }
        private void btnThem_Click (object sender, EventArgs e)
        {
            them = true;

            txtSoPhieu.Text = "0";
            txtSoHoaDon.Text = "";
            txtTKNo.Text = "";
            cbLoaiThau.SelectedIndex = 0;
            txtNhomThau.Text = "";
            dateNgayNhap.EditValue = DateTime.Now;
            lookUpNhaCungCap.EditValue = "";
            txtNguoiGiaoHang.Text = "";
            lookUpKhoNhap.EditValue = "";
            lookUpNguoiNhan.EditValue = "";
            txtNoiDung.Text = "";

            nhapkho.SoPhieu = 0;
            dtPhieu = nhapkho.DSPhieuVatTu ();
            gridControlDS.DataSource = dtPhieu;
            dsVatTu.Clear ();

            txtTKNo.Focus ();
            Enabled_Luu ();
        }

        private void btnLuu_Click (object sender, EventArgs e)
        {
            nhapkho.SoPhieu = int.Parse(txtSoPhieu.Text);
            nhapkho.SoHoaDon = txtSoHoaDon.Text;
            nhapkho.TKNo = txtTKNo.Text;
            nhapkho.LoaiThau = cbLoaiThau.SelectedIndex;
            nhapkho.NhomThau = txtNhomThau.Text;
            nhapkho.NgayNhap = dateNgayNhap.DateTime;
            nhapkho.NhaCungCap = lookUpNhaCungCap.EditValue.ToString ();
            nhapkho.NguoiGiaoHang = txtNguoiGiaoHang.Text;
            nhapkho.KhoNhap = lookUpKhoNhap.EditValue.ToString ();
            nhapkho.NguoiNhan = lookUpNguoiNhan.EditValue.ToString();
            nhapkho.NoiDung = txtNoiDung.Text;

            nhapkho.NgayCapNhat = DateTime.Now;
            err = "";
            if (them)
            {
                nhapkho.NguoiTao = AppConfig.MaNV;
                if (nhapkho.SpPhieuNhap (ref err, "INSERT"))
                {
                    txtSoPhieu.Text = nhapkho.SoPhieu.ToString();
                    LuuVatTu ();
                    LoadData ();
                }
            }
            else
            {
                nhapkho.NguoiCapNhat = AppConfig.MaNV;

                if (nhapkho.SpPhieuNhap (ref err, "UPDATE"))
                {
                    LuuVatTu ();
                    LoadData ();
                }
            }
            if (!string.IsNullOrEmpty (err))
            {
                XtraMessageBox.Show (err, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LuuVatTu()
        {
            data = (gridControlDS.DataSource as DataTable);

            foreach(DataRow dr in data.Rows)
            {
                err = "";
                nhapkho.MaVatTu = dr["MaVatTu"].ToString ();
                nhapkho.QuyCach = dr["QuyCach"].ToString ();
                nhapkho.SoLuong = int.Parse(dr["SoLuong"].ToString ());
                nhapkho.SoLuongQuyDoi = int.Parse (dr["SoLuongQuyDoi"].ToString ());
                nhapkho.SoLuongTon = int.Parse (dr["SoLuongTon"].ToString ());
                nhapkho.DonGiaBHYT = decimal.Parse (dr["DonGiaBHYT"].ToString ());
                nhapkho.DonGiaBV = decimal.Parse (dr["DonGiaBV"].ToString ());
                nhapkho.SoLo = dr["SoLo"].ToString ();
                nhapkho.HetHan = DateTime.Parse (dr["HetHan"].ToString ());
                nhapkho.ThanhTien = decimal.Parse (dr["ThanhTien"].ToString ());
                if(them)
                {
                    dsVatTu.Add (nhapkho.MaVatTu, true);
                    nhapkho.SpPhieuNhapChiTiet (ref err, "INSERT");
                }
                if(!string.IsNullOrEmpty(err))
                {
                    XtraMessageBox.Show (err, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnXoa_Click (object sender, EventArgs e)
        {

        }

        private void btnIn_Click (object sender, EventArgs e)
        {

        }

        private void txtTKNo_Leave (object sender, EventArgs e)
        {
            if(txtTKNo.Text.Length == 4)
            {
                lookUpMaVatTu.Properties.DataSource = nhapkho.DSVatTu(txtTKNo.Text.Substring(3,1));
            }
        }

        private void lookUpMaVatTu_EditValueChanged (object sender, EventArgs e)
        {
            if(lookUpMaVatTu.EditValue!=null && lookUpMaVatTu.EditValue is DataRowView)
            {
                txtTenVatTu.Text = (lookUpMaVatTu.EditValue as DataRowView)[1].ToString ();
            }
        }
    }
}
