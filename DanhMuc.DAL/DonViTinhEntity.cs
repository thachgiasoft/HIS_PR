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
    public class DonViTinhEntity
    {
        Connection db;
        public DonViTinhEntity()
        {
            db = new Connection ();
        }
        public string ID
        {
            get;
            set;
        }
        public string Ten
        {
            get;
            set;
        }
        public DataTable DSDonViTinh ()
        {
            return db.ExcuteQuery ("Select * From DonViTinh",
                CommandType.Text, null);
        }
        public bool ThemDonViTinh (ref string err)
        {
            return db.MyExecuteNonQuery ("SpThemDonViTinh",
                CommandType.StoredProcedure, ref err,
                new SqlParameter ("@ID", ID),
                new SqlParameter ("@Ten", Ten));
        }
        public bool SuaDonViTinh (ref string err)
        {
            return db.MyExecuteNonQuery ("SpSuaDonViTinh",
                CommandType.StoredProcedure, ref err,
                new SqlParameter ("@ID", ID),
                new SqlParameter ("@Ten", Ten));
        }
        public bool XoaDonViTinh (ref string err)
        {
            return db.MyExecuteNonQuery ("SpXoaDonViTinh",
                CommandType.StoredProcedure, ref err,
                new SqlParameter ("@ID", ID));
        }
    }
}
