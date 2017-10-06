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
    public partial class UC_GiuongBenh : UserControl
    {
        GiuongBenhEntity giuongbenh;
        bool them = false;
        string quyen = "";
        public UC_GiuongBenh ()
        {
            InitializeComponent ();
            giuongbenh = new GiuongBenhEntity ();
        }
        private void CheckButton ()
        {
            quyen = Core.DAL.Utils.GetQuyen (this.Name);
            Enabled_Them ();
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;
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
        private void LoadData ()
        {
            them = false;
            gridControl.DataSource = giuongbenh.DSGiuong ();
        }
        private void UC_TienKham_Load (object sender, EventArgs e)
        {
            DataTable dt = giuongbenh.DSCoSo ();
            lookUpCoSoKCB.Properties.DataSource = dt;
            lookUpCoSoKCB.Properties.ValueMember = "Ma_CS";
            lookUpCoSoKCB.Properties.DisplayMember = "Ten_CS";
            repItemLookUpCoSo.DataSource = dt;
            repItemLookUpCoSo.ValueMember = "Ma_CS";
            repItemLookUpCoSo.DisplayMember = "Ten_CS";

            dt= giuongbenh.DSKhoa ();
            lookUpKhoaPhong.Properties.DataSource = dt;
            lookUpKhoaPhong.Properties.ValueMember = "MaKhoa";
            lookUpKhoaPhong.Properties.DisplayMember = "TenKhoa";
            repItemLookUpKhoa.DataSource = dt;
            repItemLookUpKhoa.ValueMember = "MaKhoa";
            repItemLookUpKhoa.DisplayMember = "TenKhoa";

            LoadData ();
            CheckButton ();
        }

        private void btnThem_Click (object sender, EventArgs e)
        {
            them = true;
            txtDonGia.Text = "";
            txtMa.Text = "";
            txtTen.Text = "";
            txtMa.ReadOnly = false;
            checkTinhTrang.Checked = true;
            Enabled_Luu ();
            btnXoa.Enabled = false;     
        }

        private void btnLuu_Click (object sender, EventArgs e)
        {
            giuongbenh.Ma = txtMa.Text;
            giuongbenh.Ten = txtTen.Text;
            giuongbenh.Ma_CS = lookUpCoSoKCB.EditValue.ToString ();
            giuongbenh.DonGia = Utils.ToDecimal (txtDonGia.Text);
            giuongbenh.TinhTrang = checkTinhTrang.Checked;
            giuongbenh.MaKhoa = lookUpKhoaPhong.EditValue.ToString ();
            giuongbenh.MaNhom = 15;
            string err = "";
            if (them)
            {
                if (giuongbenh.SpGiuongBenh (ref err,"INSERT"))
                {
                    LoadData ();
                }
            }
            else
            {
                if (giuongbenh.SpGiuongBenh(ref err,"UPDATE"))
                {
                    LoadData ();
                }
            }
            if (!string.IsNullOrEmpty (err))
            {
                XtraMessageBox.Show (err, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click (object sender, EventArgs e)
        {
            DialogResult traloi;
            string err = "";
            traloi = XtraMessageBox.Show ("Chắc chắn bạn muốn xóa mục này?", "Trả lời",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
            {
                if (!giuongbenh.SpGiuongBenh(ref err,"DELETE"))
                {
                    XtraMessageBox.Show (err, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                LoadData ();
            }
        }

        private void lookUpCoSoKCB_EditValueChanged (object sender, EventArgs e)
        {
            giuongbenh.Ma_CS = lookUpCoSoKCB.EditValue.ToString ();
            gridControl.DataSource = giuongbenh.DSGiuong ();
        }

        private void gridView_RowClick (object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            DataRow dr = gridView.GetDataRow (e.RowHandle);
            if(dr!=null)
            {
                txtMa.Text = dr["Ma"].ToString ();
                txtTen.Text = dr["Ten"].ToString ();
                txtDonGia.Text = dr["DonGia"].ToString ();
                checkTinhTrang.Checked = Utils.ToBoolean (dr["TinhTrang"].ToString ());
                lookUpKhoaPhong.EditValue = dr["MaKhoa"];

                txtMa.ReadOnly = true;
                them = false;

                Enabled_Xoa ();
                Enabled_Luu ();
            }
        }

        private void gridControl_Click(object sender, EventArgs e)
        {

        }
    }
}
