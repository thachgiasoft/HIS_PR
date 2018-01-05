using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.DAL;
using DevExpress.XtraSplashScreen;

namespace TiepNhan.GUI
{
    public partial class rptChiPhi : DevExpress.XtraReports.UI.XtraReport
    {
        public rptChiPhi ()
        {
           
            InitializeComponent ();
        }

        private void rptChiPhi_ParametersRequestBeforeShow (object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {
        }
    }
}
