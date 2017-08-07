using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

namespace Core.DAL
{
    public class Utils
    {
        private static System.Globalization.CultureInfo elGR = System.Globalization.CultureInfo.CreateSpecificCulture ("el-GR");
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
                "' And Lop_CN = '" + MaCN + "' And DanhSachQuyen.Ma_CN = ChucNang.Ma_CN And ChucNang.TinhTrang = 1",
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
        public static string VietHoa (string s)
        {
            if (String.IsNullOrEmpty (s))
                return s;

            string result = "";

            //lấy danh sách các từ  

            string[] words = s.Split (' ');

            foreach (string word in words)
            {
                // từ nào là các khoảng trắng thừa thì bỏ  
                if (word.Trim () != "")
                {
                    if (word.Length > 1)
                        result += word.Substring (0, 1).ToUpper () + word.Substring (1) + " ";
                    else
                        result += word.ToUpper () + " ";
                }

            }
            return result.Trim ();
        }
        public static decimal ToDecimal(string value)
        {
            try
            {
                return Convert.ToDecimal (value);
            }
            catch
            {
                return 0;
            }
        }
        public static string ToString(string value)
        {
            try
            {
                return Convert.ToDecimal (value).ToString ("0,0", elGR);
            }
            catch
            {
                return null;
            }
        }
        public static string ChuyenSo (string number)
        {
            string[] dv = { "", "mươi", "trăm", "nghìn", "triệu", "tỉ" };
            string[] cs = { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
            string doc;
            int i, j, k, n, len, found, ddv, rd;

            len = number.Length;
            number += "ss";
            doc = "";
            found = 0;
            ddv = 0;
            rd = 0;

            i = 0;
            while (i < len)
            {
                //So chu so o hang dang duyet
                n = (len - i + 2) % 3 + 1;

                //Kiem tra so 0
                found = 0;
                for (j = 0; j < n; j++)
                {
                    if (number[i + j] != '0')
                    {
                        found = 1;
                        break;
                    }
                }
                //Duyet n chu so
                if (found == 1)
                {
                    rd = 1;
                    for (j = 0; j < n; j++)
                    {
                        ddv = 1;
                        switch (number[i + j])
                        {
                            case '0':
                                if (n - j == 3)
                                    doc += cs[0] + " ";
                                if (n - j == 2)
                                {
                                    if (number[i + j + 1] != '0')
                                        doc += "lẻ ";
                                    ddv = 0;
                                }
                                break;
                            case '1':
                                if (n - j == 3)
                                    doc += cs[1] + " ";
                                if (n - j == 2)
                                {
                                    doc += "mười ";
                                    ddv = 0;
                                }
                                if (n - j == 1)
                                {
                                    if (i + j == 0)
                                        k = 0;
                                    else
                                        k = i + j - 1;

                                    if (number[k] != '1' && number[k] != '0')
                                        doc += "mốt ";
                                    else
                                        doc += cs[1] + " ";
                                }
                                break;
                            case '5':
                                if (i + j == len - 1)
                                    doc += "lăm ";
                                else
                                    doc += cs[5] + " ";
                                break;
                            default:
                                doc += cs[(int) number[i + j] - 48] + " ";
                                break;
                        }

                        //Doc don vi nho
                        if (ddv == 1)
                        {
                            doc += dv[n - j - 1] + " ";
                        }
                    }
                }

                //Doc don vi lon
                if (len - i - n > 0)
                {
                    if ((len - i - n) % 9 == 0)
                    {
                        if (rd == 1)
                            for (k = 0; k < (len - i - n) / 9; k++)
                                doc += "tỉ ";
                        rd = 0;
                    }
                    else
                        if (found != 0)
                        doc += dv[((len - i - n + 1) % 9) / 3 + 2] + " ";
                }

                i += n;
            }

            if (len == 1)
                if (number[0] == '0' || number[0] == '5')
                    return cs[(int) number[0] - 48];

            return doc + "đồng";
        }
    }
}
