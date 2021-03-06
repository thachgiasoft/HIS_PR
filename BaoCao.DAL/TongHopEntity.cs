﻿using Core.DAL;
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
            return db.ExcuteQuery("select ROW_NUMBER() OVER (PARTITION BY DichVu.MaNhom ORDER By MaDichVu) as STT," +
                "MaDichVu,TenDichVu,DonGia,DichVu.MaNhom," +
                "SoLuong,ThanhTien,TenNhom,TyLe from Nhom,"+
                    "(select MaDichVu, TenDichVu, DonGia, MaNhom,TyLe,"+
                    "SUM(SoLuong) as SoLuong, (SUM(SoLuong) * DonGia) as ThanhTien "+
                    "from DichVuChiTiet,(select MaLK from ThongTinBNChiTiet where MaCoSoKCB='"+AppConfig.CoSoKCB+"') as ThongTin " +
                    "where ThongTin.MaLK = DichVuChiTiet.MaLK and MaKhoa = '" + maKhoa+"' " +
                    "and(convert(date,NgayYLenh) between convert(date,'"+tuNgay+"') and convert(date,'"+denNgay+"')) "+
                    "group by MaDichVu, TenDichVu, DonGia, MaNhom,TyLe) "+
                    "as DichVu "+
                    "where Nhom.MaNhom = DichVu.MaNhom",
                CommandType.Text, null);
        }
        public DataTable DSDonThuoc(string maKhoa, DateTime tuNgay, DateTime denNgay)
        {
            return db.ExcuteQuery("select ROW_NUMBER() OVER (ORDER By TenThuoc) as STT," +
                "MaThuoc,TenThuoc,DonViTinh,DonGia,TyLe,SUM(SoLuong) as SoLuong,SUM(ThanhTien) as ThanhTien " +
                "from DonThuocChiTiet,(select MaLK from ThongTinBNChiTiet where MaCoSoKCB='" + AppConfig.CoSoKCB + "') as ThongTin " +
                "where ThongTin.MaLK = DonThuocChiTiet.MaLK and MaKhoa = '" + maKhoa + "' " +
                "and(convert(date,NgayYLenh) between convert(date,'" + tuNgay + "') and convert(date,'" + denNgay + "')) " +
                " group by MaThuoc,TenThuoc,DonViTinh,DonGia,TyLe",
                CommandType.Text, null);

        }
        public DataTable DSSoLuongThuoc(string maKhoa, DateTime tuNgay, DateTime denNgay)
        {
            return db.ExcuteQuery("select ROW_NUMBER() OVER (ORDER By TenThuoc) as STT," +
                "MaVatTu,TenThuoc,DonViTinh,SUM(SoLuong) as SoLuong " +
                "from DonThuocChiTiet,(select MaLK from ThongTinBNChiTiet where MaCoSoKCB='" + AppConfig.CoSoKCB + "') as ThongTin " +
                "where ThongTin.MaLK = DonThuocChiTiet.MaLK and MaKhoa = '" + maKhoa + "' " +
                "and(convert(date,NgayYLenh) between convert(date,'" + tuNgay + "') and convert(date,'" + denNgay + "')) " +
                " group by MaVatTu,TenThuoc,DonViTinh",
                CommandType.Text, null);

        }
        public DataTable DSVatTu(string maKhoa, DateTime tuNgay, DateTime denNgay)
        {
            return db.ExcuteQuery("select ROW_NUMBER() OVER (ORDER By TenVatTu) as STT," +
                "MaVT,TenVatTu,DonViTinh,DonGia,TyLe,SUM(SoLuong) as SoLuong,SUM(ThanhTien) as ThanhTien " +
                "from VatTuChiTiet,(select MaLK from ThongTinBNChiTiet where MaCoSoKCB='" + AppConfig.CoSoKCB + "') as ThongTin " +
                "where ThongTin.MaLK = VatTuChiTiet.MaLK and MaKhoa = '" + maKhoa + "' " +
                "and(convert(date,NgayYLenh) between convert(date,'" + tuNgay + "') and convert(date,'" + denNgay + "')) " +
                " group by MaVT,TenVatTu,DonViTinh,DonGia,TyLe",
                CommandType.Text, null);

        }
        public DataTable DSChiTietThuoc(string maKhoa, DateTime tuNgay, DateTime denNgay)
        {
            return db.ExcuteQuery("Select STTNgay,HoTen,SUBSTRING(NgaySinh, Len(NgaySinh)-3, 4) as NgaySinh," +
                                    "MaThe,CONVERT(VARCHAR(10),NgayThanhToan,103) as NgayThanhToan,MaBenh,TenThuoc,SoLuong " +
                                    "from ThongTinBNChiTiet,DonThuocChiTiet " +
                                    "where ThongTinBNChiTiet.MaLK = DonThuocChiTiet.MaLK " +
                                    "And MaCoSoKCB='" + AppConfig.CoSoKCB + "' and ThongTinBNChiTiet.MaKhoa = '" + maKhoa + "' " +
                                    "And (convert(date,NgayThanhToan) between convert(date,'" + tuNgay + "') and convert(date,'" + denNgay + "')) " +
                                    "order by STTNgay",
                CommandType.Text, null);

        }
        public DataTable DSMauSo7980A(string maKhoa, DateTime tuNgay, DateTime denNgay)
        {
            return db.ExcuteQuery("Select * from BaoCaoMau7980A('"+maKhoa+"','"+AppConfig.CoSoKCB+"','"+tuNgay+"','"+denNgay+"')",
                CommandType.Text, null);
        }
        public DataTable DSBenhNhan(string maKhoa, DateTime tuNgay, DateTime denNgay)
        {
            return db.ExcuteQuery("select ROW_NUMBER() OVER (ORDER By MaBN) as STT," +
                "MaBN,HoTen,NgaySinh,MucHuong,TienBNCCT,NgayThanhToan " +
                "from ThongTinBNChiTiet where TienBNCCT > 0 " +
                "and MaKhoa = '" + maKhoa + "' "+
                "and(convert(date,NgayThanhToan) between convert(date,'" + tuNgay + "') and convert(date,'" + denNgay + "'))",
                CommandType.Text, null);
        }
        public DataTable DSVienPhi(string maKhoa, DateTime tuNgay, DateTime denNgay)
        {
            string sql = "";
            sql = "EXEC SpgetVienPhi '"+maKhoa+"','" + AppConfig.CoSoKCB + "','"+tuNgay+"','"+denNgay+"'";
            return db.ExcuteQuery(sql,
                CommandType.Text, null);
        }
    }
}
