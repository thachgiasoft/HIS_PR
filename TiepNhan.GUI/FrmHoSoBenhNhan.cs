﻿using Core.DAL;
using DevExpress.Data;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using KhamBenh.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace TiepNhan.GUI
{
    public partial class FrmHoSoBenhNhan : RibbonForm
    {
        DanhSachEntity danhSach;
        DataTable dataDanhSach;
        string filePath = "D:\\BHYT\\XML_4210\\";
        public FrmHoSoBenhNhan()
        {
            InitializeComponent();
            danhSach = new DanhSachEntity();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.WindowState = FormWindowState.Maximized;
        }
        private void FrmHoSoBenhNhan_Load(object sender, EventArgs e)
        {
            //        gridView.SortInfo.ClearAndAddRange(new[] {
            //new GridMergedColumnSortInfo(
            //    new[] {
            //        HoTen, GioiTinh, DiaChi},
            //    new[] {
            //        ColumnSortOrder.Ascending, ColumnSortOrder.Descending, ColumnSortOrder.Ascending })//,
            //    //new GridColumnSortInfo(NamSinh, ColumnSortOrder.Descending)
            //    }, 2);

            //        gridControl.DataSource = danhSach.DSBenhNhan();
            //    }
            lblTinhTrang.Text = "";
            dateDenNgay.DateTime = DateTime.Now;
            dateTuNgay.DateTime = DateTime.Now;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            dataDanhSach = danhSach.DSBenhNhan(dateTuNgay.DateTime, dateDenNgay.DateTime);
            gridControl.DataSource = dataDanhSach;
        }

        private async void btnBHYT_ClickAsync(object sender, EventArgs e)
        {
            lblTinhTrang.Text = "Đang tổng hợp file...";
            btnBHYT.Enabled = false;
            // tạo file gửi lên cổng và lưu 
            DataRow[] dr = (dataDanhSach).Select("Chon = True And CoThe = True", "");
            DanhSachHoSo danhSachHoSo = new DanhSachHoSo();
            
            for(int i=0;i<dr.Length;i++)
            {
                //thêm _ vào Mã khoa, đúng dịnh dạng ngày vào ngày ra, thanh toán...
                // dr xml 1, data thuoc xml 2, data vat tu dich vu xml3, data can lam san xml4 
                string maLK = dr[i]["MaLK"].ToString();
                string maBenh = string.IsNullOrEmpty(dr[i]["MaBenhKhac"].ToString()) ? dr[i]["MaBenh"].ToString() :
                    dr[i]["MaBenh"] + ";" + dr[i]["MaBenhKhac"];
                //
                DataTable dataXML3 = danhSach.DSDichVu(maLK);
                foreach(DataRow dtrow in danhSach.DSVatTu(maLK).Rows)
                {
                    dataXML3.Rows.Add(dtrow.ItemArray);
                }
                //
                XmlDocument XML1 = ConvertXML.XML1_4210(dr[i]);// xem lại cd kết quả điều trị
                XmlDocument XML2 = ConvertXML.XML2_4210(danhSach.DSThuoc(maLK), maBenh);
                XmlDocument XML4 = ConvertXML.XML4_4210(danhSach.DSHoSoCanLamSan(maLK));
                XmlDocument XML3 = ConvertXML.XML3_4210(dataXML3, maBenh);
                //
                HoSo hoSo = new HoSo();
                hoSo.Add(new FileHoSo { LoaiHoSo = "XML1", NoiDungFile = Convert.ToBase64String(Utils.XmlToByte(XML1)) });
                if (XML2 != null)
                    hoSo.Add(new FileHoSo { LoaiHoSo = "XML2", NoiDungFile = Convert.ToBase64String(Utils.XmlToByte(XML2)) });
                if (XML3 != null)
                    hoSo.Add(new FileHoSo { LoaiHoSo = "XML3", NoiDungFile = Convert.ToBase64String(Utils.XmlToByte(XML3)) });
                if (XML4 != null)
                    hoSo.Add(new FileHoSo { LoaiHoSo = "XML4", NoiDungFile = Convert.ToBase64String(Utils.XmlToByte(XML4)) });
                danhSachHoSo.Add(hoSo);
            }
            if (danhSachHoSo.Count > 0)
            {
                XmlDocument giamDinhHoSo = ConvertXML.GIAMDINH(danhSachHoSo);
                //giamDinhHoSo.Save("Test.xml");
                lblTinhTrang.Text = "Đang gửi...";
                KQGuiHoSo kqGuiHoSo = await Utils.GuiHoSo4210(Utils.XmlToByte(giamDinhHoSo));
                string name = DateTime.Now.ToString("yyyyMMdd_HHmmss");
                switch (kqGuiHoSo.maKetQua)
                {
                    case "200":
                        lblTinhTrang.Text = "Đã gửi thành công.";
                        name = kqGuiHoSo.maGiaoDich;
                        LuuGui(dr);
                        break;
                    case "400":
                        lblTinhTrang.Text = "Dữ liệu nhập vào không đúng cú pháp.";
                        break;
                    case "401":
                        lblTinhTrang.Text = "Lỗi không được xác thực.";
                        break;
                    case "500":
                        lblTinhTrang.Text = "An unexpected error occurred.";
                        break;
                    default:
                        lblTinhTrang.Text = kqGuiHoSo.maGiaoDich;
                        break;
                }
                try
                {
                    if (!Directory.Exists(filePath))
                    {
                        Directory.CreateDirectory(filePath);
                    }
                    giamDinhHoSo.Save(filePath + "FileHS_" +name+ ".xml");
                }
                catch (IOException ex)
                {
                    XtraMessageBox.Show(ex.Message);
                }
            }
            else
                lblTinhTrang.Text = "Không có hồ sơ.";
            btnBHYT.Enabled = true;
        }
        private void LuuGui(DataRow[] dr)
        {
            string err = "";
            for(int i=0;i<dr.Length;i++)
            {
                err = "";
                if(!
                danhSach.CapNhatDaGui(ref err,dr[i]["MaLK"].ToString()))
                {
                    XtraMessageBox.Show(err);
                }
            }
        }
    }
}
