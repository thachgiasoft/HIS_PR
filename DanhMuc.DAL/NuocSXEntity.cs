using Core.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanhMuc.DAL
{
    public class NuocSXEntity
    {
        Connection db;
        public NuocSXEntity()
        {
            db = new Connection ();
        }
        public string Ma
        {
            get;
            set;
        }
        public string Ten
        {
            get;
            set;
        }
        public bool TinhTrang
        {
            get;
            set;
        }
        public DataTable DSNuocSX ()
        {
            return db.ExcuteQuery ("Select * From NuocSX",
                CommandType.Text, null);
        }
        public bool ThemNuocSX (ref string err)
        {
            return db.MyExecuteNonQuery ("SpThemNuocSX",
                CommandType.StoredProcedure, ref err,
                new SqlParameter ("@Ma", Ma),
                new SqlParameter ("@Ten", Ten),
                new SqlParameter ("@TinhTrang",TinhTrang));
        }
        public bool SuaNuocSX (ref string err)
        {
            return db.MyExecuteNonQuery ("SpSuaNuocSX",
                CommandType.StoredProcedure, ref err,
                new SqlParameter ("@Ma", Ma),
                new SqlParameter ("@Ten", Ten),
                new SqlParameter ("@TinhTrang", TinhTrang));
        }
        public bool XoaNuocSX (ref string err)
        {
            return db.MyExecuteNonQuery ("SpXoaNuocSX",
                CommandType.StoredProcedure, ref err,
                new SqlParameter ("@Ma", Ma));
        }
    }
}
