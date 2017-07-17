﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HeThong.DAL;

namespace HeThong.GUI
{
    public partial class UC_SoDoToChuc : UserControl
    {
        SoDoToChucEntity sodo = new SoDoToChucEntity ();
        DataRowView selectNodeDataRow = null;
        DataRow dr = null;
        bool them = false;
        public UC_SoDoToChuc ()
        {
            InitializeComponent ();
        }
        private void checkButton ()
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
        private void LoadData ()
        {
            treeList.DataSource = sodo.DSCayKhoaBan();
            treeList.ExpandAll ();
            gridControl.DataSource = sodo.DSKhoaBan();
        }
        private void UC_SoDoToChuc_Load (object sender, EventArgs e)
        {
            lookUpMaCha.Properties.DataSource = sodo.DSKhoaBan (0);
            lookUpMaCha.Properties.DisplayMember = "TenKhoa";
            lookUpMaCha.Properties.ValueMember = "MaKhoa";
            LoadData ();
            checkButton ();
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
            sodo.MaKhoa = txtMa.Text;
            sodo.TenKhoa = txtTen.Text;
            sodo.KhoaCha = "";
            if (lookUpMaCha.GetSelectedDataRow () != null)
            {
                sodo.KhoaCha = (lookUpMaCha.GetSelectedDataRow () as DataRowView)[0].ToString ();
            }
            sodo.CapDo = cbCap.SelectedIndex + 1;
            sodo.TinhTrang = checkTinhTrang.Checked;
            string err = "";
            if (them)
            {
                if (sodo.ThemKhoaBan (ref err))
                {
                    LoadData ();
                }
            }
            else
            {
                if (sodo.SuaKhoaBan (ref err))
                {
                    LoadData ();
                }
            }
            if (!string.IsNullOrEmpty (err))
            {
                MessageBox.Show (err, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLamMoi_Click (object sender, EventArgs e)
        {
            UC_SoDoToChuc_Load (null, null);
        }

        private void btnXoa_Click (object sender, EventArgs e)
        {
            DialogResult traloi;
            string err = "";
            traloi = MessageBox.Show ("Chắc chắn bạn muốn xóa mục này?", "Trả lời",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
            {
                if (!sodo.XoaKhoaBan (ref err))
                {
                    MessageBox.Show (err, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                LoadData ();
            }
        }

        private void treeList_FocusedNodeChanged (object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            selectNodeDataRow = treeList.GetDataRecordByNode (e.Node) as DataRowView;
            if (selectNodeDataRow != null)
            {
                int rowHandle = gridView.LocateByValue ("MaKhoa", selectNodeDataRow["MaKhoa"]);
                gridView.FocusedRowHandle = rowHandle;
            }
        }

        private void treeList_NodeCellStyle (object sender, DevExpress.XtraTreeList.GetCustomNodeCellStyleEventArgs e)
        {
            if (e.Node.Focused)
            {
                e.Appearance.BackColor = System.Drawing.Color.Gray;
            }
        }

        private void cbCap_SelectedIndexChanged (object sender, EventArgs e)
        {
            lookUpMaCha.Properties.DataSource =sodo.DSKhoaBan (cbCap.SelectedIndex);
        }

        private void gridView_FocusedRowChanged (object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            dr = gridView.GetFocusedDataRow ();
            if (dr != null)
            {

                txtMa.Text = dr["MaKhoa"].ToString ();
                sodo.MaKhoa = txtMa.Text;
                txtTen.Text = dr["TenKhoa"].ToString ();
                cbCap.EditValue = dr["CapDo"].ToString ();
                lookUpMaCha.EditValue = dr["KhoaCha"].ToString ();
                checkTinhTrang.Checked = bool.Parse (dr["TinhTrang"].ToString ());
                txtMa.ReadOnly = true;
                them = false;

                Enabled_Xoa ();
                Enabled_Luu ();
            }
        }
    }
}