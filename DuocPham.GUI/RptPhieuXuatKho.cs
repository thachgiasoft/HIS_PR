using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace DuocPham.GUI
{
    public partial class RptPhieuXuatKho : DevExpress.XtraReports.UI.XtraReport
    {
        public RptPhieuXuatKho ()
        {
            Core.DAL.SplashScreen.Start ();
            InitializeComponent ();
        }

        private void RptPhieuXuatKho_ParametersRequestBeforeShow (object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {
            Core.DAL.SplashScreen.Stop ();
        }
    }
}
