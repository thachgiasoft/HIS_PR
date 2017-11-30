using DevExpress.XtraBars.Ribbon;
using KhamBenh.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TiepNhan.GUI
{
    public partial class FrmThanhToan : RibbonForm
    {
        ThanhToanEntity thanhtoan;
        public FrmThanhToan()
        {
            InitializeComponent();
            thanhtoan = new ThanhToanEntity();
        }

        private void FrmThanhToan_Load(object sender, EventArgs e)
        {
            cbLoaiKCB.SelectedIndex = 0;
            cbTimTheo.SelectedIndex = 0;
            dateDenNgay.DateTime = DateTime.Now;
            dateTuNgay.DateTime = DateTime.Now;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {

        }
    }
}
