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
    public partial class UC_CoSoKCB : UserControl
    {
        CoSoKCBEntity cosoKCB;
        public UC_CoSoKCB ()
        {
            InitializeComponent ();
            cosoKCB = new CoSoKCBEntity ();
        }

        private void UC_CoSoKCB_Load (object sender, EventArgs e)
        {
            gridControl.DataSource = cosoKCB.DSCoSoKCB ();
        }
    }
}
