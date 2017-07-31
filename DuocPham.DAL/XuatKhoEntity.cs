using Core.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuocPham.DAL
{
    public class XuatKhoEntity
    {
        Connection db;
        public XuatKhoEntity()
        {
            db = new Connection ();
        }
        public int SoPhieu
        {
            get;
            set;
        }
        public string TKCo
        {
            get;
            set;
        }
        public string NgayXuat { get; set; }
        public string KhoXuat { get; set; }
        public string KhoNhan { get; set; }
        public string NguoiNhan { get; set; }
        public string NoiDung { get; set; }
        public string PheDuyet { get; set; }
        public string NguoiTao { get; set; }
        public string NgayCapNhat { get; set; }
        public string NguoiCapNhat { get; set; }
        public DataTable DSKhoXuat ()
        {
            return db.ExcuteQuery ("Select MaKhoa,TenKhoa From KhoaBan Where TinhTrang = 1 And KhoVatTu = 1 And LoaiKho = 1",
                CommandType.Text, null);
        }
        public DataTable DSKhoNhan ()
        {
            return db.ExcuteQuery ("Select MaKhoa,TenKhoa From KhoaBan Where TinhTrang = 1 And KhoVatTu = 1 And LoaiKho = 2",
                CommandType.Text, null);
        }
        public DataTable DSVatTu (string LoaiVatTu)
        {
            return db.ExcuteQuery ("Select MaBV,TenVatTu,DonViTinh From VatTu Where TinhTrang = 1 And LoaiVatTu = '" + LoaiVatTu + "'",
                CommandType.Text, null);
        }
    }
}
