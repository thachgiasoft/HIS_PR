using Core.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThong.DAL
{
    public class PhanQuyenEntity
    {
        Connection db;
        public PhanQuyenEntity()
        {
            db = new Connection ();
        }
        public string MaNV
        {
            get;
            set;
        }
        public string Ma_CN
        {
            get;
            set;
        }
        public string MaQuyen
        {
            get;
            set;
        }
        public DataTable DSNhanVien ()
        {
            return db.ExcuteQuery ("Select Ma_NV,Ten_NV,TenKhoa From KhoaBan,NhanVien Where NhanVien.MaKhoa = KhoaBan.MaKhoa",
                CommandType.Text, null);
        }
        public DataTable GetDSChucNang ()
        {
            return db.ExcuteQuery ("Select * From getDSChucNang('"+MaNV+"')",
                CommandType.Text, null);
        }
        public DataTable DSQuyen ()
        {
            return db.ExcuteQuery ("Select Ma_NV,DanhSachQuyen.Ma_CN,MaQuyen,Ten_CN From DanhSachQuyen,ChucNang Where Ma_NV = '" + MaNV
                + "' AND DanhSachQuyen.Ma_CN = ChucNang.Ma_CN",
                CommandType.Text, null);
        }
        public bool ThemQuyen (ref string err)
        {
            return db.MyExecuteNonQuery ("SpThemQuyen",
                CommandType.StoredProcedure, ref err,
                new SqlParameter ("@Ma_NV", MaNV),
                new SqlParameter ("@Ma_CN", Ma_CN),
                new SqlParameter ("@MaQuyen", MaQuyen));
        }
        public bool SuaQuyen (ref string err)
        {
            return db.MyExecuteNonQuery ("SpSuaQuyen",
                CommandType.StoredProcedure, ref err,
                new SqlParameter ("@Ma_NV", MaNV),
                new SqlParameter ("@Ma_CN", Ma_CN),
                new SqlParameter ("@MaQuyen", MaQuyen));
        }
        public bool XoaQuyen (ref string err)
        {
            return db.MyExecuteNonQuery ("SpXoaQuyen",
                CommandType.StoredProcedure, ref err,
                new SqlParameter ("@Ma_NV", MaNV),
                new SqlParameter ("@Ma_CN", Ma_CN));
        }
    }
}
