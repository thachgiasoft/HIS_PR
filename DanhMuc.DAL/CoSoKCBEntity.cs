using Core.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanhMuc.DAL
{
    public class CoSoKCBEntity
    {
        Connection db;
        public CoSoKCBEntity()
        {
            db = new Connection ();
        }
        public DataTable DSCoSoKCB ()
        {
            return db.ExcuteQuery ("Select * From CoSoKCB",
                CommandType.Text, null);
        }
    }
}
