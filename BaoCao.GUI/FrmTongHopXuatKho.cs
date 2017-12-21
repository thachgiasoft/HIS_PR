using BaoCao.DAL;
using Core.DAL;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraReports.UI;
using DevExpress.XtraSplashScreen;
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
    public partial class FrmTongHopXuatKho : RibbonForm
    {
        DataTable dataTongHop;
        NhapXuatEntity nhapXuat;
        int thang1, thang2, thang3;
        public FrmTongHopXuatKho()
        {
            InitializeComponent();
            nhapXuat = new NhapXuatEntity();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.WindowState = FormWindowState.Maximized;
        }
        private void FrmTongHopXuatKho_Load(object sender, EventArgs e)
        {
            this.ActiveControl = cbLoaiVatTu;
            cbLoaiVatTu.SelectedIndex = 0;
            for (int i = DateTime.Now.Year - 10; i < DateTime.Now.Year + 10; i++)
            {
                cbNam.Properties.Items.Add(i);
            }
            cbNam.SelectedItem = DateTime.Now.Year;
            cbQuy.SelectedIndex = (DateTime.Now.Month + 5) / 3 - 2;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            
            
            if(cbQuy.SelectedIndex==0)
            {
                thang1 = 1;
                thang2 = 2;
                thang3 = 3;
            }
            else if(cbQuy.SelectedIndex==1)
            {
                thang1 = 4;
                thang2 = 5;
                thang3 = 6;
            }
            else if(cbQuy.SelectedIndex==2)
            {
                thang1 = 7;
                thang2 = 8;
                thang3 = 9;
            }
            else
            {
                thang1 = 10;
                thang2 = 11;
                thang3 = 12;
            }
            dataTongHop = nhapXuat.DSTongHopXuat(cbLoaiVatTu.SelectedIndex+1,
                thang1,thang2,thang3,Utils.ToInt(cbNam.SelectedItem));
            gridControl.DataSource = dataTongHop;
            gridView.ExpandAllGroups();
           
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if(dataTongHop!=null)
            {
                SplashScreenManager.ShowForm(typeof(WaitFormLoad));
                RptTongHopXuatKho rpt = new RptTongHopXuatKho();
                rpt.xrlblTieuDe.Text = "TỔNG HỢP XUẤT KHO "+cbLoaiVatTu.SelectedItem.ToString().ToUpper()+" QUÝ "+cbQuy.SelectedItem+" NĂM "+cbNam.SelectedItem;
                rpt.xrlblNgayIn.Text = "Ngày " +DateTime.Now.Day+ " tháng "+DateTime.Now.Month + " năm " + DateTime.Now.Year ;
                rpt.xrcellThang1.Text = "Tháng " + thang1;
                rpt.xrcellThang2.Text = "Tháng " + thang2;
                rpt.xrcellThang3.Text = "Tháng " + thang3;
                rpt.DataSource = dataTongHop;
                rpt.CreateDocument();
                rpt.ShowPreviewDialog();
                SplashScreenManager.CloseForm();
            }
        }
    }
}
