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
    public class NhomCanLamSanEntity
    {
        Connection db;
        public NhomCanLamSanEntity()
        {
            db = new Connection();
        }
        public string Ma { get; set; }
        public string Ten { get; set; }
        public string MaNhom { get; set; }
        public string MauSo { get; set; }
        public string MaKhoa { get; set; }
        public string MaCoSo { get; set; }
        public DataTable DSKhoaBan(int loaiPhong)
        {
            string sql = "";
            sql = "EXEC SpGetKhoaBan '" + MaCoSo + "'," + loaiPhong;
            return db.ExcuteQuery(sql,
                CommandType.Text, null);
        }
        public DataTable DSCoSo()
        {
            return db.ExcuteQuery("Select Ma_CS,Ten_CS From CoSoKCB Where Ma_CS = '70013' OR Ma_CS = '70074' "
                + "OR Ma_CS = '70075' OR Ma_CS = '70076' OR Ma_CS = '70077' OR Ma_CS = '70078'",
                CommandType.Text, null);
        }
        public DataTable DSNhomCanLamSan()
        {
            return db.ExcuteQuery("Select * From NhomCanLamSan Where MaCoSo ='"+MaCoSo+"'",
                CommandType.Text, null);
        }
        public DataTable DSNhom()
        {
            return db.ExcuteQuery("Select MaNhom,TenNhom From Nhom Where MaNhom != 10 And MaNhom != 4 And MaNhom != 5 And MaNhom != 6" +
                " And MaNhom != 11 And MaNhom != 13 And MaNhom != 14 And MaNhom != 15",
                CommandType.Text, null);
        }
        public bool SpNhomCanLamSan(ref string err, string Action)
        {
            return db.MyExecuteNonQuery("SpNhomCanLamSan",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@Action", Action),
                new SqlParameter("@Ma", Ma),
                new SqlParameter("@Ten", Ten),
                new SqlParameter("@MaNhom", MaNhom),
                new SqlParameter("@MauSo", MauSo),
                new SqlParameter("@MaKhoa", MaKhoa),
                new SqlParameter("@MaCoSo", MaCoSo));
        }
    }
}
