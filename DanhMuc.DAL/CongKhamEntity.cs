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
    public class CongKhamEntity
    {
        Connection db;
        public CongKhamEntity()
        {
            db = new Connection();
        }
        public string Ma { get; set; }
        public string Ten { get; set; }
        public decimal DonGia { get; set; }
        public string MaCK { get; set; }
        public string Ma_CS { get; set; }
        public bool TinhTrang { get; set; }
        public int MaNhom { get; set; }
        public DataTable DSCoSo()
        {
            return db.ExcuteQuery ("Select Ma_CS,Ten_CS From CoSoKCB Where Ma_CS = '70013' OR Ma_CS = '70074' "
                + "OR Ma_CS = '70075' OR Ma_CS = '70076' OR Ma_CS = '70077' OR Ma_CS = '70078'",
                CommandType.Text, null);
        }
        public DataTable DSCongKham()
        {
            return db.ExcuteQuery("Select * From CongKham Where Ma_CS ='" + Ma_CS + "'", CommandType.Text, null);
        }
        public DataTable DSChuyenKhoa()
        {
            return db.ExcuteQuery("Select * From ChuyenKhoa", CommandType.Text, null);
        }
        public bool SpCongKham(ref string err, string Action)
        {
            return db.MyExecuteNonQuery("SpCongKham",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@Action", Action),
                new SqlParameter("@Ma", Ma),
                new SqlParameter("@Ten", Ten),
                new SqlParameter("@DonGia", DonGia),
                new SqlParameter("@MaCK", MaCK),
                new SqlParameter("@Ma_CS", Ma_CS),
                new SqlParameter("@TinhTrang", TinhTrang),
                new SqlParameter("@MaNhom", MaNhom));
        }
    }
}
