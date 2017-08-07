using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.DAL;

namespace BaoCao.GUI
{
    public partial class RptBaoCaoNhapXuat : DevExpress.XtraReports.UI.XtraReport
    {
        public RptBaoCaoNhapXuat ()
        {
            SplashScreen.Start ();
            InitializeComponent ();
        }

        private void RptBaoCaoNhapXuat_ParametersRequestBeforeShow (object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {
            SplashScreen.Stop ();
        }
    }
}
