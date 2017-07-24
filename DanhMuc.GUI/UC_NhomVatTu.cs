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

namespace DanhMuc.GUI
{
    public partial class UC_NhomVatTu : UserControl
    {
        NhomVatTuEntity nhomvattu;
        DataRow dr;
        string quyen = "";
        bool them = false;
        public UC_NhomVatTu ()
        {
            InitializeComponent ();
            nhomvattu = new NhomVatTuEntity ();
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
            gridControl.DataSource = nhomvattu.DSNhomVatTu ();
        }

        private void UC_NhomVatTu_Load (object sender, EventArgs e)
        {
            lookUpLoaiVT.Properties.DataSource = nhomvattu.DSLoaiVatTu ();
            lookUpLoaiVT.Properties.DisplayMember = "Ten";
            LoadData ();
            CheckButton ();
        }

        private void btnThem_Click (object sender, EventArgs e)
        {
            txtMaNhom.Text = "";
            txtTenNhom.Text = "";
            them = true;
            txtMaNhom.ReadOnly = false;

            Enabled_Luu ();
            btnXoa.Enabled = false;
        }

        private void btnLuu_Click (object sender, EventArgs e)
        {
            nhomvattu.Ma = txtMaNhom.Text;
            nhomvattu.Ten = txtTenNhom.Text;
            nhomvattu.TinhTrang = checkTinhTrang.Checked;
            string err = "";
            if (them)
            {
                if (nhomvattu.ThemNhomVatTu (ref err))
                {
                    LoadData ();
                }
            }
            else
            {
                if (nhomvattu.SuaNhomVatTu (ref err))
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
                if (!nhomvattu.XoaNhomVatTu (ref err))
                {
                    MessageBox.Show (err, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                LoadData ();
            }
        }

        private void lookUpLoaiVT_EditValueChanged (object sender, EventArgs e)
        {
            nhomvattu.MaLoai = (lookUpLoaiVT.GetSelectedDataRow () as DataRowView)[0].ToString();
            LoadData ();
        }

        private void gridView_RowClick (object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            dr = gridView.GetFocusedDataRow ();
            if (dr != null)
            {
                txtMaNhom.Text = dr["Ma"].ToString ();
                nhomvattu.Ma = txtMaNhom.Text;
                txtTenNhom.Text = dr["Ten"].ToString ();
                txtMaNhom.ReadOnly = true;
                checkTinhTrang.Checked = bool.Parse (dr["TinhTrang"].ToString ());
                them = false;

                Enabled_Xoa ();
                Enabled_Luu ();
            }
        }
    }
}
