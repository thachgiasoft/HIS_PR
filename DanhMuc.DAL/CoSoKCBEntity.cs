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
    public class CoSoKCBEntity
    {
        Connection db;
        public CoSoKCBEntity()
        {
            db = new Connection ();
        }
        public string MaCS { get; set; }
        public string TenCS { get; set; }
        public string DiaChi { get; set; }
        public DataTable DSCoSoKCB ()
        {
            return db.ExcuteQuery ("Select * From CoSoKCB",
                CommandType.Text, null);
        }
        public bool ThemCoSoKCB(ref string err)
        {
            return db.MyExecuteNonQuery("SpThemCoSo",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaCS",MaCS),
                new SqlParameter("@TenCS", TenCS),
                new SqlParameter("@DiaChi", DiaChi));
        }
    }
}
