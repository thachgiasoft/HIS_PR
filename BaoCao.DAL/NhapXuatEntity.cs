﻿using Core.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaoCao.DAL
{
    public class NhapXuatEntity
    {
        Connection db;
        public NhapXuatEntity()
        {
            db = new Connection ();
        }
        public string LoaiVatTu { get; set; }
        public DateTime TuNgay { get; set; }
        public DateTime DenNgay { get; set; }
        public DataTable DSLoaiVatTu ()
        {
            return db.ExcuteQuery ("Select Ma,Ten From LoaiVattu Where TinhTrang = 1 ",
                CommandType.Text, null);
        }
        public DataTable DSVatTu ()
        {
            string sql = "";
            if (LoaiVatTu == null)
            {
                sql = "Select *,((GTT+GTN)/(SLT + SLN)) AS DonGia,((SLT + SLN) - SLX) AS SoLuongTon, ((GTT+GTN)-GTX) AS GiaTriTon From BaoCaoNhapXuat('" + TuNgay.ToString("MM/dd/yyyy") + "','" + DenNgay.ToString("MM/dd/yyyy") + "') ORDER BY MaBV ASC";
            }
            else
            {
                sql = "Select *,((GTT+GTN)/(SLT + SLN)) AS DonGia,((SLT + SLN) - SLX) AS SoLuongTon, ((GTT+GTN)-GTX) AS GiaTriTon From BaoCaoNhapXuat('" + TuNgay.ToString("MM/dd/yyyy") + "','" + DenNgay.ToString("MM/dd/yyyy") + "') WHERE LoaiVatTu = '"+LoaiVatTu+"'";
            }
            return db.ExcuteQuery (sql,
                CommandType.Text, null);
        }
        public DataTable DSTongHopXuat(int loaiBC, int thang1, int thang2, int thang3 ,int year)
        {
            string sql = "EXEC SpTongHopXuatKho " + loaiBC + " ," + thang1 + "," + thang2 + "," + thang3 + "," + year;
            return db.ExcuteQuery(sql,
                CommandType.Text, null);
        }
    }
}
