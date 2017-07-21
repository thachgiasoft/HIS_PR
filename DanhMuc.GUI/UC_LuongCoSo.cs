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

namespace DanhMuc.GUI
{
    public partial class UC_LuongCoSo : UserControl
    {
        LuongCoSoEntity luong;
        DataRow dr;
        string quyen = "";
        public UC_LuongCoSo ()
        {
            InitializeComponent ();
            luong = new LuongCoSoEntity ();
        }
        private void CheckButton ()
        {
            quyen = Core.DAL.Utils.GetQuyen (this.Name);
            btnLuu.Enabled = false;

        }
        private void Enabled_Luu ()
        {
            if (quyen.IndexOf ('2') >= 0)
            {
                btnLuu.Enabled = true;
            }
            else
            {
                btnLuu.Enabled = false;
            }
        }
        void LoadData ()
        {
            gridControl.DataSource = luong.DSLuongCoSo ();
        }
        private void UC_LuongCoSo_Load (object sender, EventArgs e)
        {
            LoadData ();
            CheckButton ();
        }

        private void btnLuu_Click (object sender, EventArgs e)
        {

            luong.Luong_CS = decimal.Parse (txtLuong.Text);
            string err = "";

                if (luong.SuaLuongCoSo (ref err))
                {
                    LoadData ();
                }

            if (!string.IsNullOrEmpty (err))
            {
                MessageBox.Show (err, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridView_RowClick (object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            dr = gridView.GetFocusedDataRow ();
            if (dr != null)
            {
                luong.Ma_CS = dr["Ma_CS"].ToString ();
                
                txtLuong.Text = dr["Luong_CS"].ToString ();

                Enabled_Luu ();
            }
        }
    }
}
