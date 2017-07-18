using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HeThong.DAL;
using DevExpress.XtraEditors;

namespace HeThong.GUI
{
    public partial class UC_Menu : UserControl
    {
        MenuEntity menu = new MenuEntity ();
        bool them = false;
        DataRowView selectNodeDataRow = null;
        DataRow dr = null;
        public UC_Menu ()
        {
            InitializeComponent ();
        }
        private void checkButton()
        {
            Enabled_Them ();
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
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
        private void LoadData()
        {
            treeList.DataSource = menu.DSCayMenu ();
            treeList.ExpandAll ();
            gridControl.DataSource = menu.DSMenu ();
        }
        private void btnThem_Click (object sender, EventArgs e)
        {
            them = true;
            txtMa.ReadOnly = false;
            txtMa.Text = "";
            txtTen.Text = "";
            checkTinhTrang.Checked = true;
            Enabled_Luu ();
        }

        private void btnLuu_Click (object sender, EventArgs e)
        {
            menu.MaMenu = txtMa.Text;
            menu.TenMenu = txtTen.Text;
            menu.MenuCha = "";
            menu.MaCN = "";
            if (lookUpDMCha.GetSelectedDataRow () != null)
            {
                menu.MenuCha = (lookUpDMCha.GetSelectedDataRow () as DataRowView)[0].ToString ();
            }
            if (lookUpChucNang.GetSelectedDataRow () != null)
            {
                menu.MaCN = (lookUpChucNang.GetSelectedDataRow () as DataRowView)[0].ToString ();
            }
            menu.CapDo = cbCap.SelectedIndex + 1;
            menu.TinhTrang = checkTinhTrang.Checked;
            string err = "";
            if (them)
            {
                if (menu.ThemMenu (ref err))
                {
                    LoadData ();
                }
            }
            else
            {
                if (menu.SuaMenu (ref err))
                {
                    LoadData ();
                }
            }
            if (!string.IsNullOrEmpty (err))
            {
                MessageBox.Show (err, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoad_Click (object sender, EventArgs e)
        {
            UC_Menu_Load (null, null);
        }

        private void btnXoa_Click (object sender, EventArgs e)
        {
            DialogResult traloi;
            string err = "";
            traloi = XtraMessageBox.Show ("Chắc chắn bạn muốn xóa mục này?", "Trả lời",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
            {
                if (!menu.XoaMenu (ref err))
                {
                    MessageBox.Show (err, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                LoadData ();
            }
        }

        private void UC_Menu_Load (object sender, EventArgs e)
        {
            lookUpChucNang.Properties.DataSource = menu.DSChucNang ();
            lookUpChucNang.Properties.ValueMember = "Ma_CN";
            lookUpChucNang.Properties.DisplayMember = "Ten_CN";
            lookUpDMCha.Properties.DataSource = menu.DSMenu (0);
            lookUpDMCha.Properties.DisplayMember = "Ten_Menu";
            lookUpDMCha.Properties.ValueMember = "Ma_Menu";
            LoadData ();
            checkButton ();
        }

        private void cbCap_SelectedIndexChanged (object sender, EventArgs e)
        {
            lookUpDMCha.Properties.DataSource = menu.DSMenu (cbCap.SelectedIndex);
        }

        private void treeList_NodeCellStyle (object sender, DevExpress.XtraTreeList.GetCustomNodeCellStyleEventArgs e)
        {
            if(e.Node.Focused)
            {
                e.Appearance.BackColor = System.Drawing.Color.Gray;
            }
        }

        private void treeList_FocusedNodeChanged (object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            selectNodeDataRow = treeList.GetDataRecordByNode (e.Node) as DataRowView;
            if(selectNodeDataRow!=null)
            {
                int rowHandle = gridView.LocateByValue ("Ma_Menu", selectNodeDataRow["Ma_Menu"]);
                gridView.FocusedRowHandle = rowHandle;
            }
        }


        private void gridView_RowClick (object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            dr = gridView.GetFocusedDataRow ();
            if (dr != null)
            {

                txtMa.Text = dr["Ma_Menu"].ToString ();
                menu.MaMenu = txtMa.Text;
                txtTen.Text = dr["Ten_Menu"].ToString ();
                cbCap.EditValue = dr["CapDo"].ToString ();
                lookUpChucNang.EditValue = dr["Ma_CN"].ToString ();
                lookUpDMCha.EditValue = dr["MenuCha"].ToString ();
                checkTinhTrang.Checked = bool.Parse (dr["TinhTrang"].ToString ());
                txtMa.ReadOnly = true;
                them = false;

                Enabled_Xoa ();
                Enabled_Luu ();
            }
        }
    }
}
