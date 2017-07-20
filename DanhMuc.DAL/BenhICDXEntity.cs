using Core.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanhMuc.DAL
{
    public class BenhICDXEntity
    {
        Connection db;
        public BenhICDXEntity()
        {
            db = new Connection ();
        }
        public DataTable DSBenh ()
        {
            return db.ExcuteQuery ("Select * From BenhICD",
                CommandType.Text, null);
        }
    }
}
