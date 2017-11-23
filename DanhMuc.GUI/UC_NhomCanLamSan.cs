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
using Core.DAL;
using DevExpress.XtraEditors;

namespace DanhMuc.GUI
{
    public partial class UC_NhomCanLamSan : UserControl
    {
        NhomCanLamSanEntity canlamsan;
        bool them = false;
        string quyen = "";
        public UC_NhomCanLamSan()
        {
            InitializeComponent();
            canlamsan = new NhomCanLamSanEntity();

            lookUpCoSo.Properties.DataSource = canlamsan.DSCoSo();
            lookUpCoSo.Properties.ValueMember = "Ma_CS";
            lookUpCoSo.Properties.DisplayMember = "Ten_CS";
            lookUpPhong.Properties.ValueMember = "MaKhoa";
            lookUpPhong.Properties.DisplayMember = "TenKhoa";

            lookUpNhomDVKT.Properties.DataSource = canlamsan.DSNhom();
            lookUpNhomDVKT.Properties.DisplayMember = "TenNhom";
            lookUpNhomDVKT.Properties.ValueMember = "MaNhom";
        }

        private void UC_NhomCanLamSan_Load(object sender, EventArgs e)
        {
            CheckButton();
            LoadData();
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
            gridControl.DataSource = canlamsan.DSNhomCanLamSan();
        }
        private void lookUpCoSo_EditValueChanged(object sender, EventArgs e)
        {
            canlamsan.MaCoSo = lookUpCoSo.EditValue.ToString();
            lookUpPhong.Properties.DataSource = canlamsan.DSKhoaBan(3);
            LoadData();
        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            them = true;
            txtMaNhom.Text = "";
            txtMauSo.Text = "";
            txtTenNhom.Text = "";
            txtMaNhom.ReadOnly = false;
            Enabled_Luu();
            btnXoa.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtMaNhom.Text))
            {
                XtraMessageBox.Show("Vui lòng nhập mã nhóm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            canlamsan.Ma = txtMaNhom.Text;
            canlamsan.Ten = txtTenNhom.Text;
            canlamsan.MaCoSo = Utils.ToString( lookUpCoSo.EditValue);
            canlamsan.MauSo = txtMauSo.Text;
            canlamsan.MaKhoa = Utils.ToString( lookUpPhong.EditValue);
            canlamsan.MaNhom = Utils.ToString(lookUpNhomDVKT.EditValue);
            canlamsan.MaMay = txtMaMay.Text;
            string err = null;
            if(them)
            {
                canlamsan.SpNhomCanLamSan(ref err, "INSERT");
            }
            else
            {
                canlamsan.SpNhomCanLamSan(ref err, "UPDATE");
            }
            if(!string.IsNullOrEmpty(err))
            {
                XtraMessageBox.Show(err, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            LoadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            string err = "";
            traloi = XtraMessageBox.Show("Chắc chắn bạn muốn xóa mục này?", "Trả lời",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
            {
                if (!canlamsan.SpNhomCanLamSan(ref err, "DELETE"))
                {
                    XtraMessageBox.Show(err, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                LoadData();
            }
        }

        private void gridView_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            DataRow dr = gridView.GetDataRow(e.RowHandle);
            if (dr != null)
            {
                txtMaNhom.Text = dr["Ma"].ToString();
                canlamsan.Ma = txtMaNhom.Text;
                txtTenNhom.Text = dr["Ten"].ToString();
                lookUpNhomDVKT.EditValue = dr["MaNhom"];
                txtMauSo.Text = dr["MauSo"].ToString();
                lookUpPhong.EditValue = dr["MaKhoa"];
                txtMaMay.Text = dr["MaMay"].ToString();
                txtMaNhom.ReadOnly = true;
                them = false;

                Enabled_Xoa();
                Enabled_Luu();
            }
        }
    }
}
