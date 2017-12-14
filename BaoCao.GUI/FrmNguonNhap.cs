using BaoCao.DAL;
using Core.DAL;
using DevExpress.XtraBars.Ribbon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaoCao.GUI
{
    public partial class FrmNguonNhap : RibbonForm
    {
        TonKhoEntity tonKho;
        DataTable dataDS;
        public FrmNguonNhap()
        {
            InitializeComponent();
            tonKho = new TonKhoEntity();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.WindowState = FormWindowState.Maximized;
        }
        //https://www.devexpress.com/Support/Center/Question/Details/T326869/displaying-sum-of-groupings-in-group-header
        //https://www.devexpress.com/Support/Center/Example/Details/T317187/how-to-use-aggregate-functions-in-calculated-field-expressions
        private void FrmNguonNhap_Load(object sender, EventArgs e)
        {
            for(int i = DateTime.Now.Year-10;i<DateTime.Now.Year+10;i++)
            {
                cbNam.Properties.Items.Add(i);
            }
            cbThang.SelectedIndex = DateTime.Now.Month-1;
            cbNam.SelectedItem = DateTime.Now.Year;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            dataDS = tonKho.DSKhoNhap(cbThang.SelectedIndex + 1, Utils.ToInt(cbNam.SelectedItem));
            gridControl.DataSource = dataDS;
        }

        private void btnIn_Click(object sender, EventArgs e)
        {

        }
    }
}
