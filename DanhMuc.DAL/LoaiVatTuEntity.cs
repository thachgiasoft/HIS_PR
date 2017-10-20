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
    public class LoaiVatTuEntity
    {
        Connection db;
        public LoaiVatTuEntity ()
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
        public string MauBC
        {
            get;
            set;
        }
        public DataTable DSLoaiVatTu ()
        {
            return db.ExcuteQuery ("Select * From LoaiVatTu",
                CommandType.Text, null);
        }
        public bool ThemLoaiVatTu (ref string err)
        {
            return db.MyExecuteNonQuery ("SpThemLoaiVatTu",
                CommandType.StoredProcedure, ref err,
                new SqlParameter ("@Ma", Ma),
                new SqlParameter ("@Ten", Ten),
                new SqlParameter("@Mau", MauBC),
                new SqlParameter ("@TinhTrang", TinhTrang));
        }
        public bool SuaLoaiVatTu (ref string err)
        {
            return db.MyExecuteNonQuery ("SpSuaLoaiVatTu",
                CommandType.StoredProcedure, ref err,
                new SqlParameter ("@Ma", Ma),
                new SqlParameter ("@Ten", Ten),
                new SqlParameter("@Mau", MauBC),
                new SqlParameter ("@TinhTrang", TinhTrang));
        }
        public bool XoaLoaiVatTu (ref string err)
        {
            return db.MyExecuteNonQuery ("SpXoaLoaiVatTu",
                CommandType.StoredProcedure, ref err,
                new SqlParameter ("@Ma", Ma));
        }
    }
}
