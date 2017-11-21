using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.DAL;

namespace TiepNhan.GUI
{
    public partial class RptDonThuoc : DevExpress.XtraReports.UI.XtraReport
    {
        public RptDonThuoc()
        {
            SplashScreen.Start();
            InitializeComponent();
        }

        private void RptDonThuoc_ParametersRequestBeforeShow(object sender, 
            DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {
            SplashScreen.Stop();
        }
    }
}
