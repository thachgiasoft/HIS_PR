using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DanhMuc.DAL;
using DevExpress.XtraEditors;
using Core.DAL;

namespace DanhMuc.GUI
{
    public partial class UC_ThuocNgoaiDM : UserControl
    {
        ThuocNgoaiDMEntity thuocNgoaiDM;
        bool them = false;
        string quyen = "";
        public UC_ThuocNgoaiDM()
        {
            InitializeComponent();
            thuocNgoaiDM = new ThuocNgoaiDMEntity();
            lookUpCoSoKCB.Properties.DisplayMember = "Ten_CS";
            lookUpCoSoKCB.Properties.ValueMember = "Ma_CS";
            lookUpCoSoKCB.Properties.DataSource = thuocNgoaiDM.DSCoSo();

            lookUpDuongDung.Properties.DataSource = thuocNgoaiDM.DSDuongDung();
            lookUpDuongDung.Properties.DisplayMember = "Ten";
            lookUpDuongDung.Properties.ValueMember = "Ma";

            lookUpDonViTinh.Properties.DataSource = thuocNgoaiDM.DSDonViTinh();
            lookUpDonViTinh.Properties.DisplayMember = "Ten";
            lookUpDonViTinh.Properties.ValueMember = "Ten";

        }

        private void UC_ThuocNgoaiDM_Load(object sender, EventArgs e)
        {
            lookUpCoSoKCB.ItemIndex = 0;
            lookUpDonViTinh.ItemIndex = 0;
            lookUpDuongDung.ItemIndex = 0;
            LoadData();
            CheckButton();
        }
        private void CheckButton()
        {
            quyen = Core.DAL.Utils.GetQuyen(this.Name);
            Enabled_Them();
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;
        }
        private void Enabled_Luu()
        {
            if (quyen.IndexOf('2') >= 0 || them)
            {
                btnLuu.Enabled = true;
            }
            else
            {
                btnLuu.Enabled = false;
            }
        }
        private void Enabled_Xoa()
        {
            if (quyen.IndexOf('3') >= 0)
            {
                btnXoa.Enabled = true;
            }
            else
            {
                btnXoa.Enabled = false;
            }
        }
        private void Enabled_Them()
        {
            if (quyen.IndexOf('1') >= 0)
            {
                btnMoi.Enabled = true;
            }
            else
            {
                btnMoi.Enabled = false;
            }
        }
        private void LoadData()
        {
            them = false;
            gridControl.DataSource = thuocNgoaiDM.DSThuocNgoaiDM();
        }
        private void btnMoi_Click(object sender, EventArgs e)
        {
            them = true;
            txtDonGia.Text = "";
            txtMaBV.Text = "";
            txtTenThuoc.Text = "";
            txtMaHoaChat.Text = "";
            txtHamLuong.Text = "";
            txtSoDangKy.Text = "";
            txtThongTinThau.Text = "";
            txtTyLeTT.Text = "100";
            txtMaBV.ReadOnly = false;
            Enabled_Luu();
            btnXoa.Enabled = false;
            txtMaBV.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtMaBV.Text))
            {
                XtraMessageBox.Show("Chưa nhập mã vật tư", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaBV.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtMaHoaChat.Text))
            {
                XtraMessageBox.Show("Chưa nhập mã hóa chất", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaHoaChat.Focus();
                return;
            }
            thuocNgoaiDM.MaBV = txtMaBV.Text;
            thuocNgoaiDM.MaThuoc = txtMaHoaChat.Text;
            thuocNgoaiDM.DonViTinh = lookUpDonViTinh.Properties.GetDisplayValueByKeyValue(lookUpDonViTinh.EditValue).ToString();
            thuocNgoaiDM.HamLuong = txtHamLuong.Text;
            thuocNgoaiDM.MaDuongDung = Utils.ToString(lookUpDuongDung.EditValue);
            thuocNgoaiDM.TenThuoc = txtTenThuoc.Text;
            thuocNgoaiDM.Ma_CS = Utils.ToString(lookUpCoSoKCB.EditValue);
            thuocNgoaiDM.SoDK = txtSoDangKy.Text;
            thuocNgoaiDM.TTinThau = txtThongTinThau.Text;
            thuocNgoaiDM.DonGia = Utils.ToDecimal(txtDonGia.Text);
            thuocNgoaiDM.MaNhom = 4;
            thuocNgoaiDM.TyLeTT = Utils.ToInt(txtTyLeTT.Text); 
            string err = "";
            if (them)
            {
                if (thuocNgoaiDM.SpThuocNgoaiDM(ref err, "INSERT"))
                {
                    LoadData();
                }
            }
            else
            {
                if (thuocNgoaiDM.SpThuocNgoaiDM(ref err, "UPDATE"))
                {
                    LoadData();
                }
            }
            if (!string.IsNullOrEmpty(err))
            {
                XtraMessageBox.Show(err, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            string err = "";
            traloi = XtraMessageBox.Show("Chắc chắn bạn muốn xóa mục này?", "Trả lời",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
            {
                if (!thuocNgoaiDM.SpThuocNgoaiDM(ref err, "DELETE"))
                {
                    XtraMessageBox.Show(err, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                LoadData();
            }
        }

        private void lookUpCoSoKCB_EditValueChanged(object sender, EventArgs e)
        {
            thuocNgoaiDM.Ma_CS = lookUpCoSoKCB.EditValue.ToString();
            gridControl.DataSource = thuocNgoaiDM.DSThuocNgoaiDM();
        }

        private void gridView_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            DataRow dr = gridView.GetDataRow(e.RowHandle);
            if (dr != null)
            {
                txtMaBV.Text = dr["MaBV"].ToString();
                txtMaHoaChat.Text = dr["MaThuoc"].ToString();
                txtTenThuoc.Text = dr["TenThuoc"].ToString();
                lookUpDonViTinh.EditValue = dr["DonViTinh"];
                txtHamLuong.Text = dr["HamLuong"].ToString();
                lookUpDuongDung.EditValue = dr["MaDuongDung"];
                txtDonGia.Text = dr["DonGia"].ToString();
                txtSoDangKy.Text = dr["SoDK"].ToString();
                txtThongTinThau.Text = dr["TTinThau"].ToString();
                txtTyLeTT.Text = dr["TyLeTT"].ToString();
                thuocNgoaiDM.MaBV = txtMaBV.Text;
                txtMaBV.ReadOnly = true;
                them = false;

                Enabled_Xoa();
                Enabled_Luu();
            }
        }
    }
}
