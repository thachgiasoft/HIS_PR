using Core.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhamBenh.DAL
{
    public class KhamBenhEntity
    {
        Connection db;
        public KhamBenhEntity()
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
        public DataTable DSTiepNhan(string ngayVao)
        {
            return db.ExcuteQuery("Select MaLK,MaBN,HoTen,NgaySinh,GioiTinh,DiaChi,MaThe,MaDKBD,TheTu,TheDen," +
                "TenBenh,MaBenh,MaLyDoVaoVien,MaNoiChuyenDen,MaTaiNan,NgayVao,NgayRa,KetQuaDieuTri," +
                "TinhTrangRaVien,NgayThanhToan,MucHuong,MaLoaiKCB,MaKhoa,MaCoSoKCB,MaKhuVuc,STTNgay," +
                "STTPhong,Phong,TinhTrang,CoThe,CanNang From ThongTinBNChiTiet Where CAST(NgayVao AS DATE) = CAST('"
                + ngayVao + "' AS DATE)  Order By STTNgay ASC",
                CommandType.Text, null);
        }
    }
}
