using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace DuocPham.GUI
{
    public partial class RptPhieuLinhThuoc : DevExpress.XtraReports.UI.XtraReport
    {
        public RptPhieuLinhThuoc ()
        {
            Core.DAL.SplashScreen.Start ();
            InitializeComponent ();
        }

        private void RptPhieuLinhThuoc_ParametersRequestBeforeShow (object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {
            Core.DAL.SplashScreen.Stop ();
        }
    }
}
