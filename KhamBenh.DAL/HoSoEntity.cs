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
    public class HoSoEntity
    {
        Connection db;
        public HoSoEntity()
        {
            db = new Connection();
        }
        public string MaLK { get; set; }
        public string MaDichVu { get; set; }
        public int MaNhom { get; set; }
        public string TenDichVu { get; set; }
        public string DonViTinh { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public int TyLe { get; set; }
        public decimal ThanhTien { get; set; }
        public string MaKhoa { get; set; }
        public string MaGiuong { get; set; }
        public string MaBacSi { get; set; }
        public DateTime NgayYLenh { get; set; }
        public DateTime NgayKQ { get; set; }

        public DataTable DSGiuong()
        {
            return db.ExcuteQuery("Select Ma,Ten,DonGia,MaNhom From GiuongBenh Where TinhTrang =1 And Ma_CS ='" + 
                AppConfig.CoSoKCB + "'", CommandType.Text, null);
        }
        public DataTable DSDichVuGiuongBenh()
        {
            return db.ExcuteQuery("Select MaDichVu,TenDichVu,DonViTinh,SoLuong,DonGia," +
                "ThanhTien,MaKhoa,MaGiuong,MaBacSi,NgayYLenh,NgayKQ " +
                " From DichVuChiTiet Where MaNhom = 15 And MaLK ='" +
                this.MaLK + "'", CommandType.Text, null);
        }
        public bool SpDichVuChiTiet(ref string err, string Action)
        {
            return db.MyExecuteNonQuery("SpDichVuChiTiet",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@Action", Action),
                new SqlParameter("@MaLK", MaLK),
                new SqlParameter("@MaDichVu", MaDichVu),
                new SqlParameter("@MaNhom", MaNhom),
                new SqlParameter("@TenDichVu", TenDichVu),
                new SqlParameter("@DonViTinh", DonViTinh),
                new SqlParameter("@SoLuong", SoLuong),
                new SqlParameter("@DonGia", DonGia),
                new SqlParameter("@TyLe", TyLe),
                new SqlParameter("@ThanhTien", ThanhTien),
                //new SqlParameter("@MucHuong", ),
                //new SqlParameter("@TienNguonKhac", ),
                //new SqlParameter("@TienBNTT", ),
                //new SqlParameter("@TienBHTT", ),
                //new SqlParameter("@TienBNCCT", ),
                //new SqlParameter("@TienNgoaiDS", ),
                new SqlParameter("@MaKhoa", MaKhoa),
                new SqlParameter("@MaGiuong", MaGiuong),
                new SqlParameter("@MaBacSi", MaBacSi),
                new SqlParameter("@NgayYLenh", NgayYLenh),
                new SqlParameter("@NgayKQ", NgayKQ));
        }
    }
}
