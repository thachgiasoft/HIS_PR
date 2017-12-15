using Core.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaoCao.DAL
{
    public class TongHopEntity
    {
        Connection db;
        public TongHopEntity()
        {
            db = new Connection();
        }
        public DataTable DSKhoaBan(int loaiPhong)
        {
            string sql = "";
            sql = "EXEC SpGetKhoaBan '" + AppConfig.CoSoKCB + "'," + loaiPhong;
            return db.ExcuteQuery(sql,
                CommandType.Text, null);
        }
        public DataTable DSDichVuKyThuat(string maKhoa,DateTime tuNgay, DateTime denNgay)
        {
            return db.ExcuteQuery("select MaDichVu,TenDichVu,DonGia,DichVu.MaNhom," +
                "SoLuong,ThanhTien,TenNhom from Nhom,"+
                    "(select MaDichVu, TenDichVu, DonGia, MaNhom,"+
                    "SUM(SoLuong) as SoLuong, (SUM(SoLuong) * DonGia) as ThanhTien "+
                    "from DichVuChiTiet "+
                    "where MaKhoa = '"+maKhoa+"' and(NgayYLenh between convert(date,'"+tuNgay+"') and convert(date,'"+denNgay+"')) "+
                    "group by MaDichVu, TenDichVu, DonGia, MaNhom) "+
                    "as DichVu "+
                    "where Nhom.MaNhom = DichVu.MaNhom",
                CommandType.Text, null);
        }
    }
}
