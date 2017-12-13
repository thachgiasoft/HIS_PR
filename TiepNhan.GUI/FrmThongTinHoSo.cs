using Core.DAL;
using DevExpress.XtraBars.Ribbon;
using KhamBenh.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TiepNhan.GUI
{
    public partial class FrmThongTinHoSo : RibbonForm
    {
        public List<XML2> XML2;
        public List<XML3> XML3;
        public bool BHYT;
        ThongTinHoSoEntity thongTinHoSo;
        public string MaHoSo { get; set; }
        public FrmThongTinHoSo()
        {
            InitializeComponent();
            thongTinHoSo = new ThongTinHoSoEntity();
        }

        private void FrmThongTinHoSo_Load(object sender, EventArgs e)
        {
            gridControlXML2.DataSource = null;
            gridControlXML3.DataSource = null;
            if (BHYT)
            {
                DataTable dataxml2 = new DataTable();
                dataxml2.Columns.Add("Stt", typeof(string));
                dataxml2.Columns.Add("MaThuoc", typeof(string));
                dataxml2.Columns.Add("TenThuoc", typeof(string));
                dataxml2.Columns.Add("HamLuong", typeof(string));
                dataxml2.Columns.Add("DonViTinh", typeof(string));
                dataxml2.Columns.Add("SoLuong", typeof(string));
                dataxml2.Columns.Add("DonGia", typeof(string));
                dataxml2.Columns.Add("ThanhTien", typeof(string));
                dataxml2.Columns.Add("LieuDung", typeof(string));
                foreach (XML2 thuoc in XML2)
                {
                    DataRow dr = dataxml2.NewRow();
                    dr["Stt"] = thuoc.Stt;
                    dr["MaThuoc"] = thuoc.MaThuoc;
                    dr["TenThuoc"] = thuoc.TenThuoc;
                    dr["HamLuong"] = thuoc.HamLuong;
                    dr["DonViTinh"] = thuoc.DonViTinh;
                    dr["SoLuong"] = thuoc.SoLuong;
                    dr["DonGia"] = thuoc.DonGia;
                    dr["ThanhTien"] = thuoc.ThanhTien;
                    dr["LieuDung"] = thuoc.LieuDung;
                    dataxml2.Rows.Add(dr);

                }
                gridControlXML2.DataSource = dataxml2;
                //
                DataTable dataxml3 = new DataTable();
                dataxml3.Columns.Add("Stt", typeof(string));
                dataxml3.Columns.Add("MaDichVu", typeof(string));
                dataxml3.Columns.Add("TenDichVu", typeof(string));
                dataxml3.Columns.Add("DonViTinh", typeof(string));
                dataxml3.Columns.Add("SoLuong", typeof(string));
                dataxml3.Columns.Add("DonGia", typeof(string));
                dataxml3.Columns.Add("ThanhTien", typeof(string));
                foreach (XML3 vtdv in XML3)
                {
                    DataRow dr = dataxml3.NewRow();
                    dr["Stt"] = vtdv.Stt;
                    dr["MaDichVu"] = vtdv.MaDichVu;
                    dr["TenDichVu"] = vtdv.TenDichVu;
                    dr["DonViTinh"] = vtdv.DonViTinh;
                    dr["SoLuong"] = vtdv.SoLuong;
                    dr["DonGia"] = vtdv.DonGia;
                    dr["ThanhTien"] = vtdv.ThanhTien;
                    dataxml3.Rows.Add(dr);
                }
                gridControlXML3.DataSource = dataxml3;
            }
            else
            {
                thongTinHoSo.MaLK = MaHoSo;
                // từ phần mềm
                gridControlXML2.DataSource = thongTinHoSo.DSThuoc();
                gridControlXML3.DataSource = thongTinHoSo.DSDichVu(); ;
            }
        }
    }
}
