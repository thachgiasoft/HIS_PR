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
    public partial class FrmGiuongBenh : RibbonForm
    {
        HoSoEntity hoso;
        public FrmGiuongBenh()
        {
            InitializeComponent();
            hoso = new HoSoEntity();
            lookUpGiuong.Properties.DataSource = hoso.DSGiuong();
            lookUpGiuong.Properties.DisplayMember = "Ten";
        }
        public string MaLK { get; set; }

        private void FrmGiuongBenh_Load(object sender, EventArgs e)
        {
            dateNgayYLenh.DateTime = DateTime.Now;
            txtSoGiuong.Text = "001";
            cbLoaiGiuong.SelectedIndex = 0;
            this.ActiveControl = lookUpGiuong;
            // lấy ds giường bệnh

        }

        private void lookUpGiuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                txtSoNgay.Focus();
        }

        private void txtSoNgay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                cbLoaiGiuong.Focus();
        }

        private void cbLoaiGiuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                txtSoGiuong.Focus();
        }

        private void txtSoGiuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                btnChon.Focus();
        }
    }
}
