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
    public class ChucNangEntity
    {
        Connection db;
        public ChucNangEntity()
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
        public string Lop
        {
            get;
            set;
        }
        public bool TinhTrang
        {
            get;
            set;
        }
        public string MoTa
        {
            get;
            set;
        }
        public DataTable DSChucnang ()
        {
            return db.ExcuteQuery ("Select * From ChucNang",
                CommandType.Text, null);
        }
        public bool ThemCN (ref string err)
        {
            return db.MyExecuteNonQuery ("SpThemChucNang",
                CommandType.StoredProcedure, ref err,
                new SqlParameter ("@Ma_CN", Ma),
                new SqlParameter ("@Ten_CN", Ten),
                new SqlParameter ("@Lop_CN", Lop),
                new SqlParameter ("@TinhTrang", TinhTrang),
                new SqlParameter ("@MoTa", MoTa));
        }
        public bool SuaCN (ref string err)
        {
            return db.MyExecuteNonQuery ("SpSuaChucNang",
                CommandType.StoredProcedure, ref err,
                new SqlParameter ("@Ma_CN", Ma),
                new SqlParameter ("@Ten_CN", Ten),
                new SqlParameter ("@Lop_CN", Lop),
                new SqlParameter ("@TinhTrang", TinhTrang),
                new SqlParameter ("@MoTa", MoTa));
        }
        public bool XoaCN (ref string err)
        {
            return db.MyExecuteNonQuery ("SpXoaChucNang",
                CommandType.StoredProcedure, ref err,
                new SqlParameter ("@Ma_CN", Ma));
        }
    }
}
