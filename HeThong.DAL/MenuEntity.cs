using Core.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThong.DAL
{
    public class MenuEntity
    {
        Connection db;
        public MenuEntity()
        {
            db = new Connection ();
        }
        public string MaMenu
        {
            get;
            set;
        }
        public string TenMenu
        {
            get;
            set;
        }
        public string CapDo
        {
            get;
            set;
        }
        public string MenuCha
        {
            get;
            set;
        }
        public string MaCN
        {
            get;
            set;
        }
        public bool TinhTrang
        {
            get;
            set;
        }
        public DataTable DSMenu ()
        {
            return db.ExcuteQuery ("Select * From Menu",
                CommandType.Text, null);
        }
        public DataTable DSCayMenu ()
        {
            return db.ExcuteQuery ("Select Ma_Menu,Ten_Menu,MenuCha From Menu",
                CommandType.Text, null);
        }
        public bool ThemMenu (ref string err)
        {
            return db.MyExecuteNonQuery ("SpThemMenu",
                CommandType.StoredProcedure, ref err,
                new SqlParameter ("@Ma_Menu", MaMenu),
                new SqlParameter ("@Ten_Menu", TenMenu),
                new SqlParameter ("@CapDo", CapDo),
                new SqlParameter ("@MenuCha", MenuCha),
                new SqlParameter ("@Ma_CN", MaCN),
                new SqlParameter ("@TinhTrang", TinhTrang));
        }
    }
}
