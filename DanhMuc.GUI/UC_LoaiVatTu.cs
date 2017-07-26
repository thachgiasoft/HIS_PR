using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using DanhMuc.DAL;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DanhMuc.GUI
{
    public partial class UC_LoaiVatTu : UserControl
    {
        LoaiVatTuEntity loaivattu;

        DataRow dr;
        string quyen = "";
        bool them = false;
        public UC_LoaiVatTu ()
        {
            InitializeComponent ();
            loaivattu = new LoaiVatTuEntity ();
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
            gridControl.DataSource = loaivattu.DSLoaiVatTu ();
        }
        private void UC_LoaiVatTu_Load (object sender, EventArgs e)
        {
            LoadData ();
            CheckButton ();
        }

        private void btnThem_Click (object sender, EventArgs e)
        {
            txtMa.Text = "";
            txtTen.Text = "";
            them = true;
            txtMa.ReadOnly = false;

            Enabled_Luu ();
            btnXoa.Enabled = false;
        }

        private void btnLuu_Click (object sender, EventArgs e)
        {
            loaivattu.Ma = txtMa.Text;
            loaivattu.Ten = txtTen.Text;
            loaivattu.TinhTrang = checkTinhTrang.Checked;
            string err = "";
            if (them)
            {
                if (loaivattu.ThemLoaiVatTu (ref err))
                {
                    LoadData ();
                }
            }
            else
            {
                if (loaivattu.SuaLoaiVatTu (ref err))
                {
                    LoadData ();
                }
            }
            if (!string.IsNullOrEmpty (err))
            {
                MessageBox.Show (err, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (!loaivattu.XoaLoaiVatTu (ref err))
                {
                    MessageBox.Show (err, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                LoadData ();
            }
        }

        private void gridView_RowClick (object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            dr = gridView.GetFocusedDataRow ();
            if (dr != null)
            {
                txtMa.Text = dr["Ma"].ToString ();
                loaivattu.Ma = txtMa.Text;
                txtTen.Text = dr["Ten"].ToString ();
                checkTinhTrang.Checked = bool.Parse (dr["TinhTrang"].ToString ());
                txtMa.ReadOnly = true;
                them = false;

                Enabled_Xoa ();
                Enabled_Luu ();
            }
        }
    }
}
