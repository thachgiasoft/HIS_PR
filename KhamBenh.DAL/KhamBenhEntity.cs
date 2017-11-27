using Core.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
        // thông tin chuyển phòng
        public string MaLK { get; set; }
        public DateTime NgayVao { get; set; }
        public int Phong { get; set; }
        // Nhập viện
        public int MaLoaiKCB { get; set; }
        public string MaKhoa { get; set; }
        // Ra viện
        public int KetQuaDieuTri { get; set; }
        public int TinhTrangRaVien { get; set; }
        public DateTime NgayRa { get; set; }
        // cận lâm sàn
        public string MaCSL { get; set; }
        public string MaBS { get; set; }
        public string ChuanDoan { get; set; }
        public string YeuCau { get; set; }
        public string NgayChiDinh { get; set; }
        public DataTable DSKhoaBan(int loaiPhong)
        {
            string sql = "";
            sql = "EXEC SpGetKhoaBan '" + AppConfig.CoSoKCB + "'," + loaiPhong;
            return db.ExcuteQuery(sql,
                CommandType.Text, null);
        }
        public DataTable DSBenh()
        {
            return db.ExcuteQuery("Select MaBenh,TenBenh From BenhICD ",
                CommandType.Text, null);
        }
        public DataTable DSTiepNhan(string ngayVao, int phong)
        {
            return db.ExcuteQuery("Select MaLK,MaBN,HoTen,NgaySinh,GioiTinh,DiaChi,MaThe,MaDKBD,TheTu,TheDen," +
                "TenBenh,MaBenh,MaLyDoVaoVien,MaNoiChuyenDen,MaTaiNan,NgayVao,NgayRa,KetQuaDieuTri," +
                "TinhTrangRaVien,NgayThanhToan,MucHuong,MaLoaiKCB,MaKhoa,MaCoSoKCB,MaKhuVuc,STTNgay," +
                "STTPhong,Phong,TinhTrang,CoThe,CanNang From ThongTinBNChiTiet Where CAST(NgayVao AS DATE) = CAST('"
                + ngayVao + "' AS DATE) And (Phong = "+phong+" Or "+phong+" = 0)  Order By STTNgay ASC",
                CommandType.Text, null);
        }
        public DataTable DSBenhNhanNoiTru(string tuNgay, string denNgay, string maKhoa)
        {
            return db.ExcuteQuery("Select * From ThongTinBNChiTiet Where MaLoaiKCB > 1 And MaKhoa = '" + maKhoa + "'" +
                "And CONVERT(Date,NgayVao) Between CONVERT(Date,'" + tuNgay + "') And CONVERT(Date,'" + denNgay + "') And NgayRa is NULL",
                CommandType.Text, null);
        }
        public DataTable CountSoLuongBN(string sql)
        {
            return db.ExcuteQuery(sql,
                CommandType.Text, null);
        }
        public DataTable DSCoSoKCB()
        {
            return db.ExcuteQuery("Select Ma_CS,Ten_CS From CoSoKCB ",
                CommandType.Text, null);
        }
        public DataTable DSBacSi()
        {
            return db.ExcuteQuery("Select Ma_BS, Ten_NV From NhanVien Where TinhTrang=1 And CoSoKCB = '"
                +AppConfig.CoSoKCB+"' And LEN(Ma_BS) > 0",
                CommandType.Text, null);
        }
        public DataTable DSLichSuPhanMem(string MaBN, string HoTen, int GioiTinh)
        {
            return db.ExcuteQuery("select MaLK as maHoSo,MaCoSoKCB as maCSKCB,"
            + "NgayVao as tuNgay, NgayRa as denNgay, TenBenh as tenBenh, "
            + "TinhTrangRaVien as tinhTrang, KetQuaDieuTri as kqDieuTri "
            + "from ThongTinBNChiTiet "
            + "where MaBN = '" + MaBN + "' "
            + "or(dbo.ChangeVietnameseWord(N'" + HoTen + "') = dbo.ChangeVietnameseWord(HoTen) "
            + "AND '01/11/1994' = NgaySinh AND GioiTinh = " + GioiTinh + ")",
                CommandType.Text, null);
        }
        public bool SpChuyenPhong(ref string err)
        {
            return db.MyExecuteNonQuery("SpChuyenPhong",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaLK", MaLK),
                new SqlParameter("@NgayVao", NgayVao),
                new SqlParameter("@Phong", Phong));
        }
        public bool SpChuyenVien(ref string err)
        {
            return db.MyExecuteNonQuery("SpChuyenVien",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaLK", MaLK),
                new SqlParameter("@TinhTrangRaVien", TinhTrangRaVien));
        }
        public bool SpNhapVien(ref string err)
        {
            return db.MyExecuteNonQuery("SpNhapVien",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaLK", MaLK),
                new SqlParameter("@MaLoaiKCB", MaLoaiKCB),
                new SqlParameter("@MaKhoa", MaKhoa));
        }
        public bool SpRaVien(ref string err)
        {
            return db.MyExecuteNonQuery("SpRaVien",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaLK", MaLK),
                new SqlParameter("@NgayRa", NgayRa),
                new SqlParameter("@KetQuaDieuTri", KetQuaDieuTri),
                new SqlParameter("@TinhTrangRaVien", TinhTrangRaVien));
        }
        // chỉ định cận lâm sàn
        public DataTable DSChiDinhCanLamSan(string maLK)
        {
            return db.ExcuteQuery("Select * From getChiDinhCLS('" + maLK + "')",
                CommandType.Text, null);
        }
        public bool SpCDCanLamSan(ref string err, string Action)
        {
            return db.MyExecuteNonQuery("SpCDCanLamSan",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@Action", Action),
                new SqlParameter("@MaLK", MaLK),
                new SqlParameter("@MaCLS", MaCSL),
                new SqlParameter("@MaBS", MaBS),
                new SqlParameter("@ChuanDoan",ChuanDoan ),
                new SqlParameter("@YeuCau", YeuCau),
                new SqlParameter("@NgayChiDinh",NgayChiDinh ));
        }
    }
}
