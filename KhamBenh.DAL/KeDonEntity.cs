using Core.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhamBenh.DAL
{
    public class KeDonEntity
    {
        Connection db;
        public KeDonEntity()
        {
            db = new Connection();
        }
        public string MaLK { get; set; }
        public string MaBenh { get; set; }
        public string MaBenhKhac { get; set; }
        public string TenBenh { get; set; }
        public DataTable DSBacSi()
        {
            return db.ExcuteQuery("Select Ma_BS, Ten_NV From NhanVien Where TinhTrang=1 And CoSoKCB = '"
                + AppConfig.CoSoKCB + "' And LEN(Ma_BS) > 0",
                CommandType.Text, null);
        }
        public DataTable DSBenh()
        {
            return db.ExcuteQuery("Select MaBenh,TenBenh From BenhICD ",
                CommandType.Text, null);
        }
        public DataTable DSKhoaBan(int loaiPhong)
        {
            string sql = "";
            sql = "EXEC SpGetKhoaBan '" + AppConfig.CoSoKCB + "'," + loaiPhong;
            return db.ExcuteQuery(sql,
                CommandType.Text, null);
        }
        public DataTable DSKeDon(string khoNhan,string loaiVatTu)
        {
            return db.ExcuteQuery("Select * From DSKeDonThuoc('"+loaiVatTu+"','"+khoNhan+"')",
                CommandType.Text, null);
        }
        public DataTable DSThuoc()
        {
            return db.ExcuteQuery("Select MaVatTu, MaThuoc, TenThuoc, HamLuong, DonViTinh, DonGia, "
                +"LieuDung, SUM(SoLuong) as SoLuong, SUM(ThanhTien) as ThanhTien "
                +"From DonThuocChiTiet Where MaLK = '' GROUP BY MaVatTu, MaThuoc, "
                +"TenThuoc, HamLuong, DonViTinh, DonGia, LieuDung",
                CommandType.Text, null);
        }
        public DataTable DSDichVuKyThuat()
        {
            return db.ExcuteQuery("Select MaDVKT As MaVatTu,TenDVKT As TenVatTu,DonGia As GiaBHYT,MaNhom "
                + " From DichVuKyThuat Where Ma_CS = '" + AppConfig.CoSoKCB + "' And TinhTrang = 1",
                CommandType.Text, null);
        }
        public bool LayThongTinMaBenh()
        {
            DataTable dt  = db.ExcuteQuery("Select MaBenh,MaBenhKhac,TenBenh From ThongTinBNChiTiet Where MaLK = '"+this.MaLK+"'",
                CommandType.Text, null);
            
            if(dt!=null && dt.Rows.Count>0)
            {
                this.MaBenh = dt.Rows[0]["MaBenh"].ToString();
                this.MaBenhKhac = dt.Rows[0]["MaBenhKhac"].ToString();
                this.TenBenh = dt.Rows[0]["TenBenh"].ToString();
                return true;
            }
            else
            {
                this.MaBenh = null;
                this.MaBenhKhac = null;
                this.TenBenh = null;
                return false;
            }
        }
    }
}
