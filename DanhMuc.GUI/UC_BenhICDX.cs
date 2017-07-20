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
    public partial class UC_BenhICDX : UserControl
    {
        BenhICDXEntity benhICD;
        public UC_BenhICDX ()
        {
            InitializeComponent ();
            benhICD = new BenhICDXEntity ();
        }

        private void UC_BenhICDX_Load (object sender, EventArgs e)
        {
            gridControl.DataSource = benhICD.DSBenh ();
        }
    }
}
