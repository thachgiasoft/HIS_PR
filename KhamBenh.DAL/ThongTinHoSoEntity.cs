using Core.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhamBenh.DAL
{
    public class ThongTinHoSoEntity
    {
        Connection db;
        public ThongTinHoSoEntity()
        {
            db = new Connection();
        }
        public string MaLK { get; set; }
        public DataTable DSDichVu()
        {
            return db.ExcuteQuery("Select * From DichVuChiTiet Where MaLK = '" + MaLK + "' ",
                CommandType.Text, null);
        }
        public DataTable DSThuoc()
        {
            return db.ExcuteQuery("Select * From DonThuocChiTiet Where MaLK = '" + MaLK + "' ",
                CommandType.Text, null);
        }
    }
}
