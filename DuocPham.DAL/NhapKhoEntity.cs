using Core.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuocPham.DAL
{
    public class NhapKhoEntity
    {
        Connection db;
        public NhapKhoEntity()
        {
            db = new Connection ();
        }
        public DataTable DSKho ()
        {
            return db.ExcuteQuery ("Select MaKhoa,TenKhoa From KhoaBan Where TinhTrang = 1 And KhoVatTu = 1",
                CommandType.Text, null);
        }
        public DataTable DSNguoiNhan ()
        {
            return db.ExcuteQuery ("Select Ma_NV,Ten_NV From NhanVien Where TinhTrang = 1",
                CommandType.Text, null);
        }
        public DataTable DSNhaCungCap ()
        {
            return db.ExcuteQuery ("Select ID,Ten From NhaCungCap Where TinhTrang = 1",
                CommandType.Text, null);
        }
    }
}
