using Core.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaoCao.DAL
{
    public class TonKhoLeEntity
    {
        Connection db;
        public TonKhoLeEntity()
        {
            db = new Connection();
        }
        public DataTable DSLoaiVatTu()
        {
            return db.ExcuteQuery("Select Ma,Ten,CONVERT(bit,1) as Chon From LoaiVatTu Where TinhTrang = 1",
                CommandType.Text, null);
        }
        public DataTable DSKhoLe()
        {
            return db.ExcuteQuery("Select MaKhoa,TenKhoa From KhoaBan Where TinhTrang = 1 And KhoVatTu = 1 And LoaiKho = 2",
                CommandType.Text, null);
        }
        public DataTable DSTonKhoVatTu(string sql)
        {
            sql = "Select *,ROW_NUMBER() OVER (PARTITION BY Ma ORDER By MaVatTu) as STT From " +
                    "(Select MaVatTu, KhoNhan, SUM(SoLuong) - SUM(SoLuongDung) as SoLuongTon " +
                    "From PhieuXuatChiTiet Where SoLuong - SoLuongDung > 0 Group By MaVatTu, KhoNhan) " +
                    "as KhoVatTu, " +
                    "(Select MaBV, TenVatTu, DonViTinh, Ten, Ma From VatTu, LoaiVatTu where VatTu.LoaiVatTu = LoaiVatTu.Ma) " +
                    "as VatTu " +
                    "Where KhoVatTu.MaVatTu = VatTu.MaBV And "+ sql;
            return db.ExcuteQuery(sql,
                CommandType.Text, null);
        }
    }
}
