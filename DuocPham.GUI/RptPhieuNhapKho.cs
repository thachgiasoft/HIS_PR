using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace DuocPham.GUI
{
    public partial class RptPhieuNhapKho : DevExpress.XtraReports.UI.XtraReport
    {
        public RptPhieuNhapKho ()
        {
            Core.DAL.SplashScreen.Start ();
            InitializeComponent ();
        }

        private void RptPhieuNhapKho_ParametersRequestBeforeShow (object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {
            Core.DAL.SplashScreen.Stop ();
        }
    }
}
