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
    public class DuongDungEntity
    {
        Connection db;
        public DuongDungEntity()
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
        public DataTable DSDuongDung ()
        {
            return db.ExcuteQuery ("Select * From DuongDung",
                CommandType.Text, null);
        }
        public bool ThemDonViTinh (ref string err)
        {
            return db.MyExecuteNonQuery ("SpThemDuongDung",
                CommandType.StoredProcedure, ref err,
                new SqlParameter ("@Ma", Ma),
                new SqlParameter ("@Ten", Ten));
        }
        public bool SuaDonViTinh (ref string err)
        {
            return db.MyExecuteNonQuery ("SpSuaDuongDung",
                CommandType.StoredProcedure, ref err,
                new SqlParameter ("@Ma", Ma),
                new SqlParameter ("@Ten", Ten));
        }
        public bool XoaDonViTinh (ref string err)
        {
            return db.MyExecuteNonQuery ("SpXoaDuongDung",
                CommandType.StoredProcedure, ref err,
                new SqlParameter ("@Ma", Ma));
        }
    }
}
