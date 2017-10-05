using BaoCao.DAL;
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
    public partial class FrmBCTonKho : RibbonForm
    {
        TonKhoEntity tonkho;
        public FrmBCTonKho ()
        {
            InitializeComponent ();
            tonkho = new TonKhoEntity ();
        }
        protected override void OnLoad (EventArgs e)
        {
            base.OnLoad (e);
            this.WindowState = FormWindowState.Maximized;
        }
        private void FrmBCTonKho_Load (object sender, EventArgs e)
        {
            lookUpKhoVatTu.Properties.DataSource = tonkho.DSKho ();
            lookUpKhoVatTu.Properties.DisplayMember = "TenKhoa";
            lookUpKhoVatTu.Properties.ValueMember = "MaKhoa";

            lookUpLoaiVatTu.Properties.DataSource = tonkho.DSLoaiVatTu ();
            lookUpLoaiVatTu.Properties.DisplayMember = "Ten";
            lookUpLoaiVatTu.Properties.ValueMember = "Ma";
        }
    }
}
