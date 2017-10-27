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
    public class TiepNhanEntity
    {
        Connection db;
        public TiepNhanEntity()
        {
            db = new Connection();
        }
        // Thông Tin Thẻ
        public string MaBN { get; set; }
        public bool CoThe { get; set; }
        public string MaThe { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public int GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public DateTime TheTu { get; set; }
        public DateTime TheDen { get; set; }
        public string MaCS { get; set; }
        public DateTime Du5Nam { get; set; }
        public string MaKhuVuc { get; set; }
        // Thông tin hồ sơ bệnh nhân
        public string MaLK { get; set; }
        public DataTable DSTaiNan()
        {
            return db.ExcuteQuery("Select * From TaiNan ",
                CommandType.Text, null);
        }
        public DataTable DSCoSoKCB()
        {
            return db.ExcuteQuery("Select Ma_CS,Ten_CS From CoSoKCB ",
                CommandType.Text, null);
        }
        public DataTable DSKhoaBan(int loaiPhong)
        {
            string sql = "";
            sql = "EXEC SpGetKhoaBan '"+AppConfig.CoSoKCB+"'," +loaiPhong;
            return db.ExcuteQuery(sql,
                CommandType.Text, null);
        }
        public DataTable DSMucHuong()
        {
            return db.ExcuteQuery("Select Ma, MaHieu, TyLe From MucHuong ",
                CommandType.Text, null);
        }
        public DataTable DSTinh()
        {
            return db.ExcuteQuery("Select Ma From MaTinh ",
                CommandType.Text, null);
        }
        public bool ThongTinBN(ref string err, string Action)
        {
            return db.MyExecuteNonQuery("SpThongTinBN",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@Action", Action),
                new SqlParameter("@MaBN", MaBN),
                new SqlParameter("@CoThe", CoThe),
                new SqlParameter("@MaThe", MaThe),
                new SqlParameter("@HoTen", HoTen),
                new SqlParameter("@NgaySinh", NgaySinh),
                new SqlParameter("@DiaChi", DiaChi),
                new SqlParameter("@TheTu", TheTu),
                new SqlParameter("@TheDen", TheDen),
                new SqlParameter("@MaCS", MaCS),
                new SqlParameter("@Du5Nam", Du5Nam),
                new SqlParameter("@MaKhuVuc", MaKhuVuc));
        }
        public void LayThongTinCoThe(string maThe, string ngayVao)
        {
            DataTable data = db.ExcuteQuery("Select * From LayThongTinCoThe('" + maThe + "','" + ngayVao + "')",
               CommandType.Text, null);
            this.MaBN = null;
            this.MaLK = null;
            if(data!=null && data.Rows.Count>0)
            {
                this.MaBN = data.Rows[0]["MaBN"].ToString();
                this.MaLK = data.Rows[0]["MaLK"].ToString();
                this.HoTen = data.Rows[0]["HoTen"].ToString();
                this.NgaySinh =Utils.ToDateTime( data.Rows[0]["NgaySinh"].ToString());
                this.GioiTinh =Utils.ToInt( data.Rows[0]["GioiTinh"].ToString());
                this.DiaChi = data.Rows[0]["DiaChi"].ToString();
                this.TheTu = Utils.ToDateTime(data.Rows[0]["TheTu"].ToString());
                this.TheDen = Utils.ToDateTime(data.Rows[0]["TheDen"].ToString());
                this.MaCS = data.Rows[0]["MaCS"].ToString();
                this.Du5Nam = Utils.ToDateTime( data.Rows[0]["Du5Nam"].ToString());
                this.MaKhuVuc = data.Rows[0]["MaKhuVuc"].ToString();
            }
        }
        public bool LayThongTinKhongThe(string maBN)
        {
            this.MaBN = null;
            DataTable data = db.ExcuteQuery("Select MaBN,HoTen,NgaySinh,GioiTinh,DiaChi From ThongTinBN Where MaBN = '" + maBN + "'",
               CommandType.Text, null);
            if (data != null && data.Rows.Count > 0)
            {
                this.MaBN = data.Rows[0]["MaBN"].ToString();
                this.HoTen = data.Rows[0]["HoTen"].ToString();
                this.NgaySinh = Utils.ToDateTime(data.Rows[0]["NgaySinh"].ToString());
                this.GioiTinh = Utils.ToInt(data.Rows[0]["GioiTinh"].ToString());
                this.DiaChi = data.Rows[0]["DiaChi"].ToString();
                return true;
            }
            return false;
        }
    }
}
