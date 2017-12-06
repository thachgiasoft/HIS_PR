using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhamBenh.DAL
{
    public class NhomChiPhi
    {
        private string ten;
        private string mau1;
        private string mau2;
        public NhomChiPhi(string ten, string mau1, string mau2)
        {
            this.ten = ten;
            this.mau1 = mau1;
            this.mau2 = mau2;
        }
        public string Ten { get { return ten; } set { ten = value; } }
        public string Mau1 { get { return mau1; } set { mau1 = value; } }
        public string Mau2 { get { return mau2; } set { mau2 = value; } }
    }
}
