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
    public class LuongCoSoEntity
    {
        Connection db;
        public LuongCoSoEntity()
        {
            db = new Connection ();
        }
        public string Ma_CS
        {
            get;
            set;
        }
        public decimal Luong_CS
        {
            get;
            set;
        }
        public DataTable DSLuongCoSo ()
        {
            return db.ExcuteQuery ("Select Ma_CS,TenKhoa,Luong_CS From LuongCoSo,KhoaBan Where LuongCoSo.Ma_CS = KhoaBan.MaKhoa",
                CommandType.Text, null);
        }

        public bool SuaLuongCoSo (ref string err)
        {
            return db.MyExecuteNonQuery ("SpSuaLuongCoSo",
                CommandType.StoredProcedure, ref err,
                new SqlParameter ("@Ma_CS", Ma_CS),
                new SqlParameter ("@Luong_CS", Luong_CS));
        }

    }
}
