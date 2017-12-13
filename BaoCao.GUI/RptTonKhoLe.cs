
using Core.DAL;
using DevExpress.XtraSplashScreen;

namespace BaoCao.GUI
{
    public partial class RptTonKhoLe : DevExpress.XtraReports.UI.XtraReport
    {
        public RptTonKhoLe()
        {
            SplashScreenManager.ShowForm(typeof(WaitFormLoad));
            InitializeComponent();
        }

        private void RptTonKhoLe_ParametersRequestBeforeShow(object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {
            SplashScreenManager.CloseForm();
        }
    }
}
