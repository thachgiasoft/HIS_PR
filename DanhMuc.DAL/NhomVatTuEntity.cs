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
    public class NhomVatTuEntity
    {
        Connection db;
        public NhomVatTuEntity ()
        {
            db = new Connection ();
        }
        public string Ma
        {
            get;
            set;
        }
        public string MaLoai
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
        public DataTable DSLoaiVatTu ()
        {
            return db.ExcuteQuery ("Select * From LoaiVatTu Where TinhTrang = 1",
                CommandType.Text, null);
        }
        public DataTable DSNhomVatTu ()
        {
            return db.ExcuteQuery ("Select * From NhomVatTu Where MaLoai = '"+MaLoai+"'",
                CommandType.Text, null);
        }
        public bool ThemNhomVatTu (ref string err)
        {
            return db.MyExecuteNonQuery ("SpThemNhomVatTu",
                CommandType.StoredProcedure, ref err,
                new SqlParameter ("@Ma", Ma),
                new SqlParameter ("@MaLoai", MaLoai),
                new SqlParameter ("@Ten", Ten),
                new SqlParameter ("@TinhTrang", TinhTrang));
        }
        public bool SuaNhomVatTu (ref string err)
        {
            return db.MyExecuteNonQuery ("SpSuaNhomVatTu",
                CommandType.StoredProcedure, ref err,
                new SqlParameter ("@Ma", Ma),
                new SqlParameter ("@MaLoai", MaLoai),
                new SqlParameter ("@Ten", Ten),
                new SqlParameter ("@TinhTrang", TinhTrang));
        }
        public bool XoaNhomVatTu (ref string err)
        {
            return db.MyExecuteNonQuery ("SpXoaNhomVatTu",
                CommandType.StoredProcedure, ref err,
                new SqlParameter ("@Ma", Ma));
        }
    }
}
