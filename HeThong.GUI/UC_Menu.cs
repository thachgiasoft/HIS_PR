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

namespace HeThong.GUI
{
    public partial class UC_Menu : UserControl
    {
        MenuEntity menu = new MenuEntity ();
        public UC_Menu ()
        {
            InitializeComponent ();
        }
        private void LoadData()
        {
            treeList.DataSource = menu.DSCayMenu ();
            gridControl.DataSource = menu.DSMenu ();
        }
        private void btnThem_Click (object sender, EventArgs e)
        {

        }

        private void btnLuu_Click (object sender, EventArgs e)
        {

        }

        private void btnLoad_Click (object sender, EventArgs e)
        {

        }

        private void btnXoa_Click (object sender, EventArgs e)
        {

        }

        private void UC_Menu_Load (object sender, EventArgs e)
        {
            LoadData ();
        }
    }
}
