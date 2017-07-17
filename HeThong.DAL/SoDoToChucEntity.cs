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
    public class SoDoToChucEntity
    {
        Connection db;
        public SoDoToChucEntity ()
        {
            db = new Connection ();
        }
        public string MaKhoa
        {
            get;
            set;
        }
        public string TenKhoa
        {
            get;
            set;
        }
        public int CapDo
        {
            get;
            set;
        }
        public string KhoaCha
        {
            get;
            set;
        }
        public bool TinhTrang
        {
            get;
            set;
        }
        public DataTable DSKhoaBan ()
        {
            return db.ExcuteQuery ("Select * From KhoaBan",
                CommandType.Text, null);
        }
        public DataTable DSKhoaBan (int cap)
        {
            return db.ExcuteQuery ("Select * From KhoaBan Where CapDo = " + cap,
                CommandType.Text, null);
        }
        public DataTable DSCayKhoaBan ()
        {
            return db.ExcuteQuery ("Select MaKhoa,TenKhoa,KhoaCha From KhoaBan",
                CommandType.Text, null);
        }
        public bool ThemKhoaBan (ref string err)
        {
            return db.MyExecuteNonQuery ("SpThemKhoaBan",
                CommandType.StoredProcedure, ref err,
                new SqlParameter ("@MaKhoa", MaKhoa),
                new SqlParameter ("@TenKhoa", TenKhoa),
                new SqlParameter ("@CapDo", CapDo),
                new SqlParameter ("@KhoaCha", KhoaCha),
                new SqlParameter ("@TinhTrang", TinhTrang));
        }
        public bool SuaKhoaBan (ref string err)
        {
            return db.MyExecuteNonQuery ("SpSuaKhoaBan",
                CommandType.StoredProcedure, ref err,
                new SqlParameter ("@MaKhoa", MaKhoa),
                new SqlParameter ("@TenKhoa", TenKhoa),
                new SqlParameter ("@CapDo", CapDo),
                new SqlParameter ("@KhoaCha", KhoaCha),
                new SqlParameter ("@TinhTrang", TinhTrang));
        }
        public bool XoaKhoaBan (ref string err)
        {
            return db.MyExecuteNonQuery ("SpXoaKhoaBan",
                CommandType.StoredProcedure, ref err,
                new SqlParameter ("@MaKhoa", MaKhoa));
        }
    }
}
