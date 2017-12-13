using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.DAL;
using DevExpress.XtraSplashScreen;

namespace DuocPham.GUI
{
    public partial class RptPhieuNhapKho : DevExpress.XtraReports.UI.XtraReport
    {
        public RptPhieuNhapKho ()
        {
            SplashScreenManager.ShowForm(typeof(WaitFormLoad));
            InitializeComponent ();
        }

        private void RptPhieuNhapKho_ParametersRequestBeforeShow (object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {
            SplashScreenManager.CloseForm();
        }
    }
}
