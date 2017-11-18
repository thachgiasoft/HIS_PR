using Core.DAL;
using DevExpress.XtraBars.Ribbon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeThong.GUI
{
    public partial class FrmThamSoHeThong : RibbonForm
    {
        public FrmThamSoHeThong ()
        {
            InitializeComponent ();
        }

        private void FrmThamSoHeThong_Load(object sender, EventArgs e)
        {
            txtServerName.Text = AppConfig.ServerName;
            txtDatabase.Text = AppConfig.Database;
            txtUserName.Text = AppConfig.UserName;
            txtPassword.Text = AppConfig.Password;
            //
            txtUserNameBHYT.Text = AppConfig.UserLoginBHYT;
            txtPasswordBHYT.Text = AppConfig.PassWordBHYT;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            AppConfig app = new AppConfig();
            AppConfig.ServerName = txtServerName.Text;
            AppConfig.Database = txtDatabase.Text;
            AppConfig.UserName = txtUserName.Text;
            AppConfig.Password = txtPassword.Text;
            //
            AppConfig.UserLoginBHYT = txtUserNameBHYT.Text;
            AppConfig.PassWordBHYT = txtPasswordBHYT.Text;
            app.WriteCauHinh();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
