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
    public partial class UC_CongKham : UserControl
    {
        CongKhamEntity congkham;
        bool them = false;
        string quyen = "";
        public UC_CongKham()
        {
            InitializeComponent();
            congkham = new CongKhamEntity();
        }

        private void UC_CongKham_Load(object sender, EventArgs e)
        {
            lookUpCoSoKCB.Properties.DisplayMember = "Ten_CS";
            lookUpCoSoKCB.Properties.ValueMember = "Ma_CS";
            lookUpCoSoKCB.Properties.DataSource = congkham.DSCoSo();

            lookUpChuyenKhoa.Properties.DisplayMember = "Ten";
            lookUpChuyenKhoa.Properties.ValueMember = "Ma";
            lookUpChuyenKhoa.Properties.DataSource = congkham.DSChuyenKhoa();

            LoadData();
            CheckButton();
        }
        private void LoadData()
        {
            them = false;
            gridControl.DataSource = congkham.DSCongKham();
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
        private void btnMoi_Click(object sender, EventArgs e)
        {
            them = true;
            txtDonGia.Text = "";
            txtMa.Text = "";
            txtTen.Text = "";
            txtMa.ReadOnly = false;
            checkTinhTrang.Checked = true;
            Enabled_Luu();
            btnXoa.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            congkham.Ma = txtMa.Text;
            congkham.Ten = txtTen.Text;
            congkham.Ma_CS =Utils.ToString( lookUpCoSoKCB.EditValue);
            congkham.DonGia = Utils.ToDecimal(txtDonGia.Text);
            congkham.TinhTrang = checkTinhTrang.Checked;
            congkham.MaCK =Utils.ToString( lookUpChuyenKhoa.EditValue);
            congkham.MaNhom = 13;
            string err = "";
            if (them)
            {
                if (congkham.SpCongKham(ref err, "INSERT"))
                {
                    LoadData();
                }
            }
            else
            {
                if (congkham.SpCongKham(ref err, "UPDATE"))
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
                if (!congkham.SpCongKham(ref err, "DELETE"))
                {
                    XtraMessageBox.Show(err, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                LoadData();
            }
        }

        private void lookUpCoSoKCB_EditValueChanged(object sender, EventArgs e)
        {
            congkham.Ma_CS = lookUpCoSoKCB.EditValue.ToString();
            gridControl.DataSource = congkham.DSCongKham();
        }

        private void gridView_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            DataRow dr = gridView.GetDataRow(e.RowHandle);
            if(dr!=null)
            {
                txtMa.Text = dr["Ma"].ToString();
                txtTen.Text = dr["Ten"].ToString();
                txtDonGia.Text = dr["DonGia"].ToString();
                checkTinhTrang.Checked = Utils.ToBoolean(dr["TinhTrang"].ToString());
                lookUpChuyenKhoa.EditValue = dr["MaCK"];

                congkham.Ma = txtMa.Text;

                txtMa.ReadOnly = true;
                them = false;

                Enabled_Xoa();
                Enabled_Luu();
            }
        }
    }
}
