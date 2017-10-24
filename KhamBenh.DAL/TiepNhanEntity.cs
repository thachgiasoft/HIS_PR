using Core.DAL;
using System;
using System.Collections.Generic;
using System.Data;
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
    }
}
