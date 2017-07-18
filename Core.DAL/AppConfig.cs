using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Core.DAL
{
    public class AppConfig
    {
        XmlDocument xmlfile;
        private static string theme = "";
        private static string serverName = "";
        private static string database = "";
        private static string userName = "";
        private static string password = "";
        private static string coSoKCB = "70013";
        private static string maNV = "";
        private static string matKhau = "";
        public AppConfig()
        {
            xmlfile = new XmlDocument ();
            xmlfile.Load ("AppConfig.xml");
        }
        public static string Theme
        {
            get
            {
                return theme;
            }

            set
            {
                theme = value;
            }
        }

        public static string ServerName
        {
            get
            {
                return serverName;
            }

            set
            {
                serverName = value;
            }
        }

        public static string Database
        {
            get
            {
                return database;
            }

            set
            {
                database = value;
            }
        }

        public static string UserName
        {
            get
            {
                return userName;
            }

            set
            {
                userName = value;
            }
        }

        public static string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public static string CoSoKCB
        {
            get
            {
                return coSoKCB;
            }

            set
            {
                coSoKCB = value;
            }
        }

        public static string MaNV
        {
            get
            {
                return maNV;
            }

            set
            {
                maNV = value;
            }
        }

        public static string MatKhau
        {
            get
            {
                return matKhau;
            }

            set
            {
                matKhau = value;
            }
        }

        public void Read ()
        {
            
            AppConfig.Theme = xmlfile.SelectSingleNode ("AppConfig/ThemeConfig/Theme").InnerText.ToString ();
            AppConfig.ServerName = xmlfile.SelectSingleNode ("AppConfig/Connection/ServerName").InnerText.ToString ();
            AppConfig.Database = xmlfile.SelectSingleNode ("AppConfig/Connection/Database").InnerText.ToString ();
            AppConfig.UserName = xmlfile.SelectSingleNode ("AppConfig/Connection/UserName").InnerText.ToString ();
            AppConfig.Password = xmlfile.SelectSingleNode ("AppConfig/Connection/Password").InnerText.ToString ();
        }
        public void WriteTheme()
        {
            xmlfile.SelectSingleNode ("AppConfig/ThemeConfig/Theme").InnerText = AppConfig.Theme;
            xmlfile.Save ("AppConfig.xml");
        }
    }
}
