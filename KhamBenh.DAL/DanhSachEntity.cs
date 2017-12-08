using Core.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhamBenh.DAL
{
    public class DanhSachEntity
    {
        Connection db;
        public DanhSachEntity()
        {
            db = new Connection();
        }
        public DataTable DSBenhNhan(DateTime tuNgay, DateTime denNgay)
        {
            return db.ExcuteQuery("Select *,(~DaGui) as Chon From ThongTinBNChiTiet " +
                "Where CONVERT(Date,NgayThanhToan) between CONVERT(Date, '"+tuNgay+"') and CONVERT(Date, '"+denNgay+"')",
                CommandType.Text, null);
        }
    }
}
