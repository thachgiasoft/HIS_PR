using Core.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanhMuc.DAL
{
    public class ThuocNgoaiDMEntity
    {
        Connection db;
        public ThuocNgoaiDMEntity()
        {
            db = new Connection();
        }
        public string MaBV { get; set; }
        public string MaThuoc { get; set; }
        public string TenThuoc { get; set; }
        public string DonViTinh { get; set; }
        public string HamLuong { get; set; }
        public string MaDuongDung { get; set; }
        public decimal DonGia { get; set; }
        public string SoDK { get; set; }
        public string TTinThau { get; set; }
        public string Ma_CS { get; set; }
        public int MaNhom { get; set; }
        public DataTable DSCoSo()
        {
            return db.ExcuteQuery("Select Ma_CS,Ten_CS From CoSoKCB Where Ma_CS = '70013' OR Ma_CS = '70074' "
                + "OR Ma_CS = '70075' OR Ma_CS = '70076' OR Ma_CS = '70077' OR Ma_CS = '70078'",
                CommandType.Text, null);
        }
        public DataTable DSDuongDung()
        {
            return db.ExcuteQuery("Select * From DuongDung",
                CommandType.Text, null);
        }
        public DataTable DSDonViTinh()
        {
            return db.ExcuteQuery("Select * From DonViTinh",
                CommandType.Text, null);
        }
        public DataTable DSThuocNgoaiDM()
        {
            return db.ExcuteQuery("Select * From ThuocNgoaiDM Where Ma_CS ='" + Ma_CS + "'", CommandType.Text, null);
        }
        public bool SpThuocNgoaiDM(ref string err, string Action)
        {
            return db.MyExecuteNonQuery("SpThuocNgoaiDM",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@Action", Action),
                new SqlParameter("@MaBV",MaBV ),
                new SqlParameter("@MaThuoc", MaThuoc),
                new SqlParameter("@TenThuoc", TenThuoc),
                new SqlParameter("@DonViTinh", DonViTinh),
                new SqlParameter("@HamLuong", HamLuong),
                new SqlParameter("@MaDuongDung", MaDuongDung),
                new SqlParameter("@DonGia", DonGia),
                new SqlParameter("@SoDK", SoDK),
                new SqlParameter("@TTinThau",TTinThau ),
                new SqlParameter("@Ma_CS",Ma_CS ),
                new SqlParameter("@MaNhom", MaNhom));
        }
    }
}
