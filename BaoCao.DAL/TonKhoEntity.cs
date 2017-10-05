using Core.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaoCao.DAL
{
    public class TonKhoEntity
    {
        Connection db;
        public TonKhoEntity()
        {
            db = new Connection ();
        }
        public DataTable DSLoaiVatTu ()
        {
            return db.ExcuteQuery ("Select Ma,Ten From LoaiVattu Where TinhTrang = 1 ",
                CommandType.Text, null);
        }
        public DataTable DSKho ()
        {
            return db.ExcuteQuery ("Select MaKhoa,TenKhoa,LoaiKho From KhoaBan Where TinhTrang = 1 And KhoVatTu = 1",
                CommandType.Text, null);
        }
    }
}
