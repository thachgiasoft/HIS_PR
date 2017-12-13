using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DAL
{
    public class LichSuKCBChiTiet
    {
        public LichSuKCBChiTiet()
        {
            maKetQua = null;
            hoSoKCB = new HoSoKCB();
        }
        public string maKetQua { get; set; }
        public HoSoKCB hoSoKCB { get; set; }

        public string ThongBao { get; set; }
    }
}
