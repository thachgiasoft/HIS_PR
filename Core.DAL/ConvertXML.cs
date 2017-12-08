using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Core.DAL
{
    public class ConvertXML
    {
        public static XmlDocument XML1_4210(DataRow dataRow)
        {
            XmlDocument doc = new XmlDocument();
            XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            XmlElement root = doc.DocumentElement;
            doc.InsertBefore(xmlDeclaration, root);

            XmlElement tonghop = doc.CreateElement("TONGHOP");
            doc.AppendChild(tonghop);

            XmlElement element = doc.CreateElement("MALK");
            element.AppendChild(doc.CreateTextNode(dataRow["MaLK"].ToString()));
            tonghop.AppendChild(element);

            element = doc.CreateElement("STT");
            element.AppendChild(doc.CreateTextNode(dataRow["STT"].ToString()));
            tonghop.AppendChild(element);

            element = doc.CreateElement("MA_BN");
            element.AppendChild(doc.CreateTextNode(dataRow["MaBN"].ToString()));
            tonghop.AppendChild(element);

            element = doc.CreateElement("HO_TEN");
            element.AppendChild(doc.CreateCDataSection(dataRow["HoTen"].ToString()));
            tonghop.AppendChild(element);

            element = doc.CreateElement("NGAY_SINH");
            element.AppendChild(doc.CreateTextNode(dataRow["NgaySinh"].ToString()));
            tonghop.AppendChild(element);

            element = doc.CreateElement("GIOI_TINH");
            element.AppendChild(doc.CreateTextNode(dataRow["GioiTinh"].ToString()));
            tonghop.AppendChild(element);

            element = doc.CreateElement("DIA_CHI");
            element.AppendChild(doc.CreateCDataSection(dataRow["DiaChi"].ToString()));
            tonghop.AppendChild(element);

            element = doc.CreateElement("MA_THE");
            element.AppendChild(doc.CreateTextNode(dataRow["MaThe"].ToString()));
            tonghop.AppendChild(element);

            element = doc.CreateElement("MA_DKBD");
            element.AppendChild(doc.CreateTextNode(dataRow["MaDKBD"].ToString()));
            tonghop.AppendChild(element);

            element = doc.CreateElement("GT_THE_TU");
            element.AppendChild(doc.CreateTextNode(dataRow["TheTu"].ToString()));
            tonghop.AppendChild(element);

            element = doc.CreateElement("GT_THE_DEN");
            element.AppendChild(doc.CreateTextNode(dataRow["TheDen"].ToString()));
            tonghop.AppendChild(element);

            element = doc.CreateElement("MIEN_CUNG_CT");
            element.AppendChild(doc.CreateTextNode(dataRow["MienCungCT"].ToString()));
            tonghop.AppendChild(element);

            element = doc.CreateElement("TEN_BENH");
            element.AppendChild(doc.CreateCDataSection(dataRow["TenBenh"].ToString()));
            tonghop.AppendChild(element);

            element = doc.CreateElement("MA_BENH");
            element.AppendChild(doc.CreateTextNode(dataRow["MaBenh"].ToString()));
            tonghop.AppendChild(element);

            element = doc.CreateElement("MA_BENHKHAC");
            element.AppendChild(doc.CreateTextNode(dataRow["MaBenhKhac"].ToString()));
            tonghop.AppendChild(element);

            element = doc.CreateElement("MA_LYDO_VVIEN");
            element.AppendChild(doc.CreateTextNode(dataRow["MaLyDoVaoVien"].ToString()));
            tonghop.AppendChild(element);

            element = doc.CreateElement("MA_NOI_CHUYEN");
            element.AppendChild(doc.CreateTextNode(dataRow["MaNoiChuyenDen"].ToString()));
            tonghop.AppendChild(element);

            element = doc.CreateElement("MA_TAI_NAN");
            element.AppendChild(doc.CreateTextNode(dataRow["MaTaiNan"].ToString()));
            tonghop.AppendChild(element);

            element = doc.CreateElement("NGAY_VAO");
            element.AppendChild(doc.CreateTextNode(dataRow["NgayVao"].ToString()));
            tonghop.AppendChild(element);

            element = doc.CreateElement("NGAY_RA");
            element.AppendChild(doc.CreateTextNode(dataRow["NgayRa"].ToString()));
            tonghop.AppendChild(element);

            element = doc.CreateElement("SO_NGAY_DTRI");
            element.AppendChild(doc.CreateTextNode(dataRow["SoNgayDieuTri"].ToString()));
            tonghop.AppendChild(element);

            element = doc.CreateElement("KET_QUA_DTRI");
            element.AppendChild(doc.CreateCDataSection(dataRow["KetQuaDieuTri"].ToString()));
            tonghop.AppendChild(element);

            element = doc.CreateElement("TINH_TRANG_RV");
            element.AppendChild(doc.CreateTextNode(dataRow["TinhTrangRaVien"].ToString()));
            tonghop.AppendChild(element);

            element = doc.CreateElement("NGAY_TTOAN");
            element.AppendChild(doc.CreateTextNode(dataRow["NgayThanhToan"].ToString()));
            tonghop.AppendChild(element);

            element = doc.CreateElement("T_THUOC");
            element.AppendChild(doc.CreateTextNode(dataRow["TienThuoc"].ToString()));
            tonghop.AppendChild(element);

            element = doc.CreateElement("T_VTYT");
            element.AppendChild(doc.CreateTextNode(dataRow["TienVTYT"].ToString()));
            tonghop.AppendChild(element);

            element = doc.CreateElement("T_TONGCHI");
            element.AppendChild(doc.CreateTextNode(dataRow["TongChi"].ToString()));
            tonghop.AppendChild(element);

            element = doc.CreateElement("T_BNTT");
            element.AppendChild(doc.CreateTextNode(dataRow["TienBNTT"].ToString()));
            tonghop.AppendChild(element);

            element = doc.CreateElement("T_BNCCT");
            element.AppendChild(doc.CreateTextNode(dataRow["TienBNCCT"].ToString()));
            tonghop.AppendChild(element);

            element = doc.CreateElement("T_BHTT");
            element.AppendChild(doc.CreateTextNode(dataRow["TienBHTT"].ToString()));
            tonghop.AppendChild(element);

            element = doc.CreateElement("T_NGUONKHAC");
            element.AppendChild(doc.CreateTextNode(dataRow["TienNguonKhac"].ToString()));
            tonghop.AppendChild(element);

            element = doc.CreateElement("T_NGOAIDS");
            element.AppendChild(doc.CreateTextNode(dataRow["TienNgoaiDS"].ToString()));
            tonghop.AppendChild(element);

            element = doc.CreateElement("NAM_QT");
            element.AppendChild(doc.CreateTextNode(dataRow["NamQT"].ToString()));
            tonghop.AppendChild(element);

            element = doc.CreateElement("THANG_QT");
            element.AppendChild(doc.CreateTextNode(dataRow["ThangQT"].ToString()));
            tonghop.AppendChild(element);

            element = doc.CreateElement("MA_LOAI_KCB");
            element.AppendChild(doc.CreateTextNode(dataRow["MaLoaiKCB"].ToString()));
            tonghop.AppendChild(element);

            element = doc.CreateElement("MA_KHOA");
            element.AppendChild(doc.CreateTextNode(dataRow["MaKhoa"].ToString().Split('_')[0]));
            tonghop.AppendChild(element);

            element = doc.CreateElement("MA_CSKCB");
            element.AppendChild(doc.CreateTextNode(dataRow["MaCoSoKCB"].ToString()));
            tonghop.AppendChild(element);

            element = doc.CreateElement("MA_KHUVUC");
            element.AppendChild(doc.CreateTextNode(dataRow["MaKhuVuc"].ToString()));
            tonghop.AppendChild(element);

            element = doc.CreateElement("MA_PTTT_QT");
            element.AppendChild(doc.CreateTextNode(dataRow["MaPTTTTQT"].ToString()));
            tonghop.AppendChild(element);

            element = doc.CreateElement("CAN_NANG");
            element.AppendChild(doc.CreateTextNode(dataRow["CanNang"].ToString()));
            tonghop.AppendChild(element);
            //
            return doc;
        }


        public static XmlDocument XML2_4210(DataTable dataTable, string MaBenh)
        {
            XmlDocument doc = new XmlDocument();
            XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            XmlElement root = doc.DocumentElement;
            doc.InsertBefore(xmlDeclaration, root);

            XmlElement danhsach = doc.CreateElement("DSACH_CHI_TIET_THUOC");
            doc.AppendChild(danhsach);
            foreach (DataRow dr in dataTable.Rows)
            {
                XmlElement chitiet = doc.CreateElement("CHI_TIET_THUOC");
                danhsach.AppendChild(chitiet);

                XmlElement element = doc.CreateElement("MALK");
                element.AppendChild(doc.CreateTextNode(dr["MaLK"].ToString()));
                chitiet.AppendChild(element);

                element = doc.CreateElement("STT");
                element.AppendChild(doc.CreateTextNode(dr["STT"].ToString()));
                chitiet.AppendChild(element);

                element = doc.CreateElement("MA_THUOC");
                element.AppendChild(doc.CreateTextNode(dr["MaThuoc"].ToString()));
                chitiet.AppendChild(element);

                element = doc.CreateElement("MA_NHOM");
                element.AppendChild(doc.CreateTextNode(dr["MaNhom"].ToString()));
                chitiet.AppendChild(element);

                element = doc.CreateElement("TEN_THUOC");
                element.AppendChild(doc.CreateCDataSection(dr["TenThuoc"].ToString()));
                chitiet.AppendChild(element);

                element = doc.CreateElement("DON_VI_TINH");
                element.AppendChild(doc.CreateTextNode(dr["DonViTinh"].ToString()));
                chitiet.AppendChild(element);

                element = doc.CreateElement("HAM_LUONG");
                element.AppendChild(doc.CreateCDataSection(dr["HamLuong"].ToString()));
                chitiet.AppendChild(element);

                element = doc.CreateElement("DUONG_DUNG");
                element.AppendChild(doc.CreateTextNode(dr["MaDuongDung"].ToString()));
                chitiet.AppendChild(element);

                element = doc.CreateElement("LIEU_DUNG");
                element.AppendChild(doc.CreateCDataSection(dr["LieuDung"].ToString()));
                chitiet.AppendChild(element);

                element = doc.CreateElement("SO_DANG_KY");
                element.AppendChild(doc.CreateTextNode(dr["SoDK"].ToString()));
                chitiet.AppendChild(element);

                element = doc.CreateElement("TT_THAU");
                element.AppendChild(doc.CreateTextNode(dr["TTinThau"].ToString()));
                chitiet.AppendChild(element);

                element = doc.CreateElement("PHAM_VI");
                element.AppendChild(doc.CreateTextNode(dr["PhamVi"].ToString()));
                chitiet.AppendChild(element);

                element = doc.CreateElement("SO_LUONG");
                element.AppendChild(doc.CreateTextNode(dr["SoLuong"].ToString()));
                chitiet.AppendChild(element);

                element = doc.CreateElement("DON_GIA");
                element.AppendChild(doc.CreateTextNode(dr["DonGia"].ToString()));
                chitiet.AppendChild(element);

                element = doc.CreateElement("TYLE_TT");
                element.AppendChild(doc.CreateTextNode(dr["TyLe"].ToString()));
                chitiet.AppendChild(element);

                element = doc.CreateElement("THANH_TIEN");
                element.AppendChild(doc.CreateTextNode(dr["ThanhTien"].ToString()));
                chitiet.AppendChild(element);

                element = doc.CreateElement("MUC_HUONG");
                element.AppendChild(doc.CreateTextNode(dr["MucHuong"].ToString()));
                chitiet.AppendChild(element);

                element = doc.CreateElement("T_NGUON_KHAC");
                element.AppendChild(doc.CreateTextNode(dr["TienNguonKhac"].ToString()));
                chitiet.AppendChild(element);

                element = doc.CreateElement("T_BNTT");
                element.AppendChild(doc.CreateTextNode(dr["TienBNTT"].ToString()));
                chitiet.AppendChild(element);

                element = doc.CreateElement("T_BHTT");
                element.AppendChild(doc.CreateTextNode(dr["TienBHTT"].ToString()));
                chitiet.AppendChild(element);

                element = doc.CreateElement("T_BNCCT");
                element.AppendChild(doc.CreateTextNode(dr["TienBNCCT"].ToString()));
                chitiet.AppendChild(element);

                element = doc.CreateElement("T_NGOAIDS");
                element.AppendChild(doc.CreateTextNode(dr["TienNgoaiDS"].ToString()));
                chitiet.AppendChild(element);

                element = doc.CreateElement("MA_KHOA");
                element.AppendChild(doc.CreateTextNode(dr["MaKhoa"].ToString().Split('_')[0]));
                chitiet.AppendChild(element);

                element = doc.CreateElement("MA_BAC_SI");
                element.AppendChild(doc.CreateTextNode(dr["MaBacSi"].ToString()));
                chitiet.AppendChild(element);

                element = doc.CreateElement("MA_BENH");
                element.AppendChild(doc.CreateTextNode(MaBenh));
                chitiet.AppendChild(element);

                element = doc.CreateElement("NGAY_YL");
                element.AppendChild(doc.CreateTextNode(dr["NgayYLenh"].ToString()));
                chitiet.AppendChild(element);

                element = doc.CreateElement("MA_PTTT");
                element.AppendChild(doc.CreateTextNode(dr["MaPTTT"].ToString()));
                chitiet.AppendChild(element);
            }
            //
            return doc;
        }
        public static XmlDocument XML3_4210(DataTable dataTable, string MaBenh)
        {
            XmlDocument doc = new XmlDocument();
            XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            XmlElement root = doc.DocumentElement;
            doc.InsertBefore(xmlDeclaration, root);

            XmlElement danhsach = doc.CreateElement("DSACH_CHI_TIET_DVKT");
            doc.AppendChild(danhsach);
            foreach (DataRow dr in dataTable.Rows)
            {
                XmlElement chitiet = doc.CreateElement("CHI_TIET_DVKT");
                danhsach.AppendChild(chitiet);

                XmlElement element = doc.CreateElement("MALK");
                element.AppendChild(doc.CreateTextNode(dr["MaLK"].ToString()));
                chitiet.AppendChild(element);

                element = doc.CreateElement("STT");
                element.AppendChild(doc.CreateTextNode(dr["STT"].ToString()));
                chitiet.AppendChild(element);

                element = doc.CreateElement("MA_DICH_VU");
                element.AppendChild(doc.CreateTextNode(dr["MaDichVu"].ToString()));
                chitiet.AppendChild(element);

                element = doc.CreateElement("MA_VAT_TU");
                element.AppendChild(doc.CreateTextNode(dr["MaVT"].ToString()));
                chitiet.AppendChild(element);

                element = doc.CreateElement("MA_NHOM");
                element.AppendChild(doc.CreateTextNode(dr["MaNhom"].ToString()));
                chitiet.AppendChild(element);

                element = doc.CreateElement("GOI_VTYT");
                element.AppendChild(doc.CreateTextNode(dr["GoiVTYT"].ToString()));
                chitiet.AppendChild(element);

                element = doc.CreateElement("TEN_VAT_TU");
                element.AppendChild(doc.CreateCDataSection(dr["TenVatTu"].ToString()));
                chitiet.AppendChild(element);

                element = doc.CreateElement("TEN_DICH_VU");
                element.AppendChild(doc.CreateCDataSection(dr["TenDichVu"].ToString()));
                chitiet.AppendChild(element);

                element = doc.CreateElement("DON_VI_TINH");
                element.AppendChild(doc.CreateTextNode(dr["DonViTinh"].ToString()));
                chitiet.AppendChild(element);

                element = doc.CreateElement("PHAM_VI");
                element.AppendChild(doc.CreateTextNode(dr["PhamVi"].ToString()));
                chitiet.AppendChild(element);

                element = doc.CreateElement("SO_LUONG");
                element.AppendChild(doc.CreateTextNode(dr["SoLuong"].ToString()));
                chitiet.AppendChild(element);

                element = doc.CreateElement("DON_GIA");
                element.AppendChild(doc.CreateTextNode(dr["DonGia"].ToString()));
                chitiet.AppendChild(element);

                element = doc.CreateElement("TT_THAU");
                element.AppendChild(doc.CreateTextNode(dr["TTinThau"].ToString()));
                chitiet.AppendChild(element);

                element = doc.CreateElement("TYLE_TT");
                element.AppendChild(doc.CreateTextNode(dr["TyLe"].ToString()));
                chitiet.AppendChild(element);

                element = doc.CreateElement("THANH_TIEN");
                element.AppendChild(doc.CreateTextNode(dr["ThanhTien"].ToString()));
                chitiet.AppendChild(element);

                element = doc.CreateElement("T_TRANTT");
                element.AppendChild(doc.CreateTextNode(dr["TTrantT"].ToString()));
                chitiet.AppendChild(element);

                element = doc.CreateElement("MUC_HUONG");
                element.AppendChild(doc.CreateTextNode(dr["MucHuong"].ToString()));
                chitiet.AppendChild(element);

                element = doc.CreateElement("T_NGUON_KHAC");
                element.AppendChild(doc.CreateTextNode(dr["TienNguonKhac"].ToString()));
                chitiet.AppendChild(element);

                element = doc.CreateElement("T_BNTT");
                element.AppendChild(doc.CreateTextNode(dr["TienBNTT"].ToString()));
                chitiet.AppendChild(element);

                element = doc.CreateElement("T_BHTT");
                element.AppendChild(doc.CreateTextNode(dr["TienBHTT"].ToString()));
                chitiet.AppendChild(element);

                element = doc.CreateElement("T_BNCCT");
                element.AppendChild(doc.CreateTextNode(dr["TienBNCCT"].ToString()));
                chitiet.AppendChild(element);

                element = doc.CreateElement("T_NGOAIDS");
                element.AppendChild(doc.CreateTextNode(dr["TienNgoaiDS"].ToString()));
                chitiet.AppendChild(element);

                element = doc.CreateElement("MA_KHOA");
                element.AppendChild(doc.CreateTextNode(dr["MaKhoa"].ToString().Split('_')[0]));
                chitiet.AppendChild(element);

                element = doc.CreateElement("MA_GIUONG");
                element.AppendChild(doc.CreateTextNode(dr["MaGiuong"].ToString()));
                chitiet.AppendChild(element);

                element = doc.CreateElement("MA_BAC_SI");
                element.AppendChild(doc.CreateTextNode(dr["MaBacSi"].ToString()));
                chitiet.AppendChild(element);

                element = doc.CreateElement("MA_BENH");
                element.AppendChild(doc.CreateTextNode(MaBenh));
                chitiet.AppendChild(element);

                element = doc.CreateElement("NGAY_YL");
                element.AppendChild(doc.CreateTextNode(dr["NgayYLenh"].ToString()));
                chitiet.AppendChild(element);

                element = doc.CreateElement("NGAY_KQ");
                element.AppendChild(doc.CreateTextNode(dr["NgayKQ"].ToString()));
                chitiet.AppendChild(element);

                element = doc.CreateElement("MA_PTTT");
                element.AppendChild(doc.CreateTextNode(dr["MaPTTT"].ToString()));
                chitiet.AppendChild(element);
            }
            //
            return doc;
        }
        public static XmlDocument XML4_4210(DataTable dataTable)
        {
            XmlDocument doc = new XmlDocument();
            XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            XmlElement root = doc.DocumentElement;
            doc.InsertBefore(xmlDeclaration, root);

            XmlElement danhsach = doc.CreateElement("DSACH_CHI_TIET_CLS");
            doc.AppendChild(danhsach);
            foreach (DataRow dr in dataTable.Rows)
            {
                XmlElement chitiet = doc.CreateElement("CHI_TIET_CLS");
                danhsach.AppendChild(chitiet);

                XmlElement element = doc.CreateElement("MALK");
                element.AppendChild(doc.CreateTextNode(dr["MaLK"].ToString()));
                chitiet.AppendChild(element);

                element = doc.CreateElement("STT");
                element.AppendChild(doc.CreateTextNode(dr["STT"].ToString()));
                chitiet.AppendChild(element);

                element = doc.CreateElement("MA_DICH_VU");
                element.AppendChild(doc.CreateTextNode(dr["MaDichVu"].ToString()));
                chitiet.AppendChild(element);

                element = doc.CreateElement("MA_CHI_SO");
                element.AppendChild(doc.CreateTextNode(dr["MaChiSo"].ToString()));
                chitiet.AppendChild(element);

                element = doc.CreateElement("TEN_CHI_SO");
                element.AppendChild(doc.CreateCDataSection(dr["TenChiSo"].ToString()));
                chitiet.AppendChild(element);

                element = doc.CreateElement("GIA_TRI");
                element.AppendChild(doc.CreateCDataSection(dr["GiaTri"].ToString()));
                chitiet.AppendChild(element);

                element = doc.CreateElement("MA_MAY");
                element.AppendChild(doc.CreateTextNode(dr["MaMay"].ToString()));
                chitiet.AppendChild(element);

                element = doc.CreateElement("MO_TA");
                element.AppendChild(doc.CreateCDataSection(dr["MoTa"].ToString()));
                chitiet.AppendChild(element);

                element = doc.CreateElement("KET_LUAN");
                element.AppendChild(doc.CreateCDataSection(dr["KetLuan"].ToString()));
                chitiet.AppendChild(element);

                element = doc.CreateElement("NGAY_KQ");
                element.AppendChild(doc.CreateTextNode(dr["NgayKQ"].ToString()));
                chitiet.AppendChild(element);
            }
            //
            return doc;
        }
    }
}
