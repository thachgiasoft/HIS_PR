using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

namespace Core.DAL
{
    public class Utils
    {
        public static Connection db = new Connection ();
        public static string toMD5 (string matKhau)
        {
            MD5 mh = MD5.Create ();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes (matKhau);
            byte[] hash = mh.ComputeHash (inputBytes);
            StringBuilder sb = new StringBuilder ();

            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append (hash[i].ToString ("X2"));
            }
            return sb.ToString ();
        }
        public static bool ThemHoatDong(string noidung)
        {
            return true;
            string err = "";
           if(db ==null)
            {
                db = new Connection ();
            }
            return db.MyExecuteNonQuery ("SpThemHoatDong",
                CommandType.StoredProcedure, ref err,
                new SqlParameter ("@Ma_NV", AppConfig.MaNV),
                new SqlParameter ("@Ten_May", Environment.MachineName),
                new SqlParameter ("@NguoiDung", Environment.UserName),
                new SqlParameter ("@Ngay", DateTime.Now),
                new SqlParameter ("@HoatDong", noidung));
        }
        public static string GetQuyen (string MaCN)
        {
            if (db == null)
            {
                db = new Connection ();
            }
            DataTable data = db.ExcuteQuery ("Select * From DanhSachQuyen,ChucNang Where Ma_NV = '" + AppConfig.MaNV +
                "' And Lop_CN = '" + MaCN + "' And DanhSachQuyen.Ma_CN = ChucNang.Ma_CN",
               CommandType.Text, null);
            if (data == null || data.Rows.Count == 0)
            {
                return "";
            }
            return data.Rows[0]["MaQuyen"].ToString ();
        }
        public static bool CheckMenu (string MaCN)
        {
            if (db == null)
            {
                db = new Connection ();
            }
            DataTable data = db.ExcuteQuery ("Select * From DanhSachQuyen Where Ma_NV = '" + AppConfig.MaNV + "' And Ma_CN = '" + MaCN + "'",
                CommandType.Text, null);
            if (data == null || data.Rows.Count == 0)
            {
                return false;
            }
            return true;
        }
    }
}
