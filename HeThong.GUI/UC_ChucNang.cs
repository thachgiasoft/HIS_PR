using HeThong.DAL;
using System;
using System.Data;
using System.Windows.Forms;

namespace HeThong.GUI
{
    public partial class UC_ChucNang : UserControl
    {
        ChucNangEntity chucnang = new ChucNangEntity ();
        bool them = false;
        public UC_ChucNang ()
        {
            InitializeComponent ();
        }
        private void LoadData()
        {
            gridControl.DataSource = chucnang.DSChucnang ();
        }
        private void CheckButton()
        {
            Enabled_Them ();
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;
        }
        private void Enabled_Luu ()
        {
            btnLuu.Enabled = true;
        }
        private void Enabled_Xoa ()
        {
            btnXoa.Enabled = true;
        }
        private void Enabled_Them ()
        {
            btnThem.Enabled = true;
        }
        private void UC_ChucNang_Load (object sender, EventArgs e)
        {
            LoadData ();
            CheckButton ();
        }

        private void btnThem_Click (object sender, EventArgs e)
        {
            txtMa.Text = "";
            txtLop.Text = "";
            txtMoTa.Text = "";
            txtTen.Text = "";
            checkChoPhep.Checked = true;
            them = true;
            txtMa.ReadOnly = false;

            Enabled_Luu ();
            btnXoa.Enabled = false;
        }

        private void btnLuu_Click (object sender, EventArgs e)
        {
            chucnang.Ma = txtMa.Text;
            chucnang.Ten = txtTen.Text;
            chucnang.Lop = txtLop.Text;
            chucnang.MoTa = txtMoTa.Text;
            chucnang.TinhTrang = checkChoPhep.Checked;
            string err = "";
            if(them)
            {               
                if(chucnang.ThemCN(ref err))
                {
                    LoadData ();
                }
            }
            else
            {
                if (chucnang.SuaCN (ref err))
                {
                    LoadData ();
                }
            }
            if(!string.IsNullOrEmpty(err))
            {
                MessageBox.Show (err,"Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click (object sender, EventArgs e)
        {
            DialogResult traloi;
            string err = "";
            traloi = MessageBox.Show ("Chắc chắn bạn muốn xóa mục này?", "Trả lời",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
            {
                if (!chucnang.XoaCN (ref err))
                {
                    MessageBox.Show (err, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                LoadData ();
            }
        }

        private void gridView_RowClick (object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            DataRow dr = gridView.GetFocusedDataRow ();
            if(dr != null)
            {
                txtMa.Text = dr["Ma_CN"].ToString ();
                chucnang.Ma = txtMa.Text;
                txtTen.Text = dr["Ten_CN"].ToString ();
                txtLop.Text = dr["Lop_CN"].ToString ();
                txtMoTa.Text = dr["MoTa"].ToString ();
                checkChoPhep.Checked = bool.Parse (dr["TinhTrang"].ToString ());
                txtMa.ReadOnly = true;
                them = false;

                Enabled_Xoa ();
                Enabled_Luu ();
            }
        }
    }
}
