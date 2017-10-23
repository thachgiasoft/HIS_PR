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

namespace TiepNhan.GUI
{
    public partial class FrmTiepNhan : RibbonForm
    {
        public FrmTiepNhan()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.WindowState = FormWindowState.Maximized;
        }
        private void FrmTiepNhan_Load(object sender, EventArgs e)
        {
            ResetForm();

        }
        private void ResetForm()
        {
            checkBHYT.Checked = true;
            txtNgayTN.Text = DateTime.Now.ToString("dd/MM/yyyyy");
            cbGioiTinh.SelectedIndex = 0;
            cbLyDoVaoVien.SelectedIndex = 0;
        }
        private void checkBHYT_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBHYT.Checked == true)
            {
                txtMaQR.ReadOnly = false;
                txtTheBHYT.ReadOnly = false;
                txtTheTu.ReadOnly = false;
                txtTheDen.ReadOnly = false;
                txtMaDKKCB.ReadOnly = false;
                txtTenDKKCB.ReadOnly = false;
                txtDu5Nam.ReadOnly = false;
                cbKhuVuc.ReadOnly = false;
            }
            else
            {
                txtMaQR.ReadOnly = true;
                txtMaQR.Text = null;
                txtTheBHYT.ReadOnly = true;
                txtTheBHYT.Text = null;
                txtTheTu.ReadOnly = true;
                txtTheTu.Text = null;
                txtTheDen.ReadOnly = true;
                txtTheDen.Text = null;
                txtMaDKKCB.ReadOnly = true;
                txtMaDKKCB.Text = null;
                txtTenDKKCB.ReadOnly = true;
                txtTenDKKCB.Text = null;
                txtDu5Nam.ReadOnly = true;
                txtDu5Nam.Text = null;
                cbKhuVuc.ReadOnly = true;
            }
        }

      
    }
}
