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
    public partial class FrmRaVien : RibbonForm
    {
        public FrmRaVien()
        {
            InitializeComponent();
        }
        public int KetQuaDieuTri { get; set; }
        public int TinhTrangRaVien { get; set; }
        private void FrmRaVien_Load(object sender, EventArgs e)
        {
            cbTinhTrangRaVien.SelectedIndex = 0;
            cbKetQua.SelectedIndex = 0;
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            this.KetQuaDieuTri = cbKetQua.SelectedIndex + 1;
            this.TinhTrangRaVien = cbTinhTrangRaVien.SelectedIndex + 1;
            this.DialogResult = DialogResult.OK;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
