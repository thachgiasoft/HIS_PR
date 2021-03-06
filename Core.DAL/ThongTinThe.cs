﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DAL
{
    public class ThongTinThe
    {
        public string MaBN { get; set; }
        public string MaThe { get; set; }
        public string TheTu { get; set; }
        public string TheDen { get; set; }
        public string Du5Nam { get; set; }
        public string HoTen { get; set; }
        public string NgaySinh { get; set; }
        public int GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string MaCoSoDKKCB { get; set; }
        public string Code { get; set; }
        public string ThongBao { get; set; }
        public string XML1 { get; set; }
        public string XML2 { get; set; }
        public string XML3 { get; set; }
        public string XML4 { get; set; }
        // thông tin từ phần mềm
        public System.Data.DataTable LichSuPhanMem { get; set; }
    }
}
