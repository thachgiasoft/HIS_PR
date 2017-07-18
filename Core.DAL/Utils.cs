using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Core.DAL
{
    public class Utils
    {
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
    }
}
