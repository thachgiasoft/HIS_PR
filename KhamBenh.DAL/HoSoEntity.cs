using Core.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhamBenh.DAL
{
    public class HoSoEntity
    {
        Connection db;
        public HoSoEntity()
        {
            db = new Connection();
        }
        public DataTable DSGiuong()
        {
            return db.ExcuteQuery("Select Ma,Ten,DonGia,MaNhom From GiuongBenh Where TinhTrang =1 And Ma_CS ='" + 
                AppConfig.CoSoKCB + "'", CommandType.Text, null);
        }
    }
}
