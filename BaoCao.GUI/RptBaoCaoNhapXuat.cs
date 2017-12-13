using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.DAL;
using DevExpress.XtraSplashScreen;

namespace BaoCao.GUI
{
    public partial class RptBaoCaoNhapXuat : DevExpress.XtraReports.UI.XtraReport
    {
        public RptBaoCaoNhapXuat ()
        {
            SplashScreenManager.ShowForm(typeof(WaitFormLoad));
            InitializeComponent ();
        }

        private void RptBaoCaoNhapXuat_ParametersRequestBeforeShow (object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {
            SplashScreenManager.CloseForm();
        }
    }
}
