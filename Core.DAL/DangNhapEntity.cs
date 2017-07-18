﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DAL
{
    public class DangNhapEntity
    {
        Connection db;
        public DangNhapEntity()
        {
            db = new Connection ();
        }
        public string MaNV
        {
            get;
            set;
        }
        public string MatKhau
        {
            get;
            set;
        }
        public string CoSoKCB
        {
            get;
            set;
        }
        public bool CheckLogin ()
        {
            DataTable data = db.ExcuteQuery ("Select * From NhanVien Where Ma_NV = '"+MaNV+"' And MatKhau = '"+MatKhau+"'",
                CommandType.Text, null);

            if(data == null || data.Rows.Count == 0)
            {
                return false;
            }

            AppConfig.MaNV = data.Rows[0]["Ma_NV"].ToString ();
            AppConfig.MatKhau = data.Rows[0]["MatKhau"].ToString ();
            AppConfig.CoSoKCB = data.Rows[0]["CoSoKCB"].ToString ();

            return true;
        }
        public bool CheckMenu(string MaCN)
        {
            DataTable data = db.ExcuteQuery ("Select * From DanhSachQuyen Where Ma_NV = '" + AppConfig.MaNV + "' And Ma_CN = '" + MaCN + "'",
                CommandType.Text, null);
            if (data == null || data.Rows.Count == 0)
            {
                return false;
            }
            return true;
        }
    }
}
