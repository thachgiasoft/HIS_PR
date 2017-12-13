using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.DAL;
using DevExpress.XtraSplashScreen;

namespace TiepNhan.GUI
{
    public partial class RptDonThuoc : DevExpress.XtraReports.UI.XtraReport
    {
        public RptDonThuoc()
        {
            SplashScreenManager.ShowForm(typeof(WaitFormLoad));
            InitializeComponent();
        }

        private void RptDonThuoc_ParametersRequestBeforeShow(object sender, 
            DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {
            SplashScreenManager.CloseForm();
        }
    }
}
