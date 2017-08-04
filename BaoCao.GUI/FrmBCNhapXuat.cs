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
    public partial class FrmBCNhapXuat : RibbonForm
    {
        NhapXuatEntity nhapxuat;
        public FrmBCNhapXuat ()
        {
            InitializeComponent ();
            nhapxuat = new NhapXuatEntity ();
        }
        protected override void OnLoad (EventArgs e)
        {
            base.OnLoad (e);
            this.WindowState = FormWindowState.Maximized;
        }
        private void FrmBCNhapXuatThuoc_Load (object sender, EventArgs e)
        {
            dateTuNgay.DateTime = DateTime.Now;
            dateDenNgay.DateTime = DateTime.Now;

            cbThoiGian.SelectedIndex = 0;
            cbThang.SelectedIndex = DateTime.Now.Month - 1;
            cbNam.SelectedIndex = 0;
            cbQuy.SelectedIndex = DateTime.Now.Month / 4;

            layctrlNam.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            layctrlQuy.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            layctrlThang.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;

            this.cbNam.Properties.Items.Clear ();
            string[] nam = new string[30];
            int j = 0;
            for (int i = DateTime.Now.Year; i > DateTime.Now.Year - 30; i--)
            {
                nam[j] = i.ToString ();
                j++;
            }
            this.cbNam.Properties.Items.AddRange (nam);
            cbNam.SelectedIndex = 0;
            //
            lookUpLoaiVatTu.Properties.DataSource = nhapxuat.DSLoaiVatTu ();
            lookUpLoaiVatTu.Properties.DisplayMember = "Ten";
            lookUpLoaiVatTu.Properties.ValueMember = "Ma";
            lookUpLoaiVatTu.ItemIndex = 0;
        }

        private void cbThoiGian_SelectedIndexChanged (object sender, EventArgs e)
        {
            if (cbThoiGian.SelectedIndex != 0)
            {
                layctrlTuNgay.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                layctrlDenNgay.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                layctrlQuy.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                layctrlThang.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                layctrlNam.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                if (cbThoiGian.SelectedIndex == 1)
                {
                    layctrlThang.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                }
                if (cbThoiGian.SelectedIndex == 2)
                {
                    layctrlQuy.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                }
            }
            else
            {
                layctrlNam.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                layctrlQuy.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                layctrlThang.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;

                layctrlTuNgay.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                layctrlDenNgay.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            }
        }

        private void btnXem_Click (object sender, EventArgs e)
        {
            nhapxuat.LoaiVatTu = lookUpLoaiVatTu.EditValue.ToString ();
            nhapxuat.TuNgay = dateTuNgay.DateTime;
            nhapxuat.DenNgay = dateDenNgay.DateTime;
            if(checkTatCa.Checked)
            {
                nhapxuat.LoaiVatTu = null;
            }
            gridControl.DataSource = nhapxuat.DSVatTu ();
        }

        private void btnIn_Click (object sender, EventArgs e)
        {

        }
    }
}
