using Core.DAL;
using DevExpress.XtraBars.Ribbon;
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
    public partial class FrmLichSuKCB : RibbonForm
    {
        public ThongTinThe ThongTin = new ThongTinThe();
        public FrmLichSuKCB()
        {
            InitializeComponent();
        }

        private void FrmLichSuKCB_Load(object sender, EventArgs e)
        {
            gridControl.DataSource = null;
            lblHoTen.Text = ThongTin.HoTen;
            lblNamSinh.Text = ThongTin.NgaySinh;
            if(ThongTin.GioiTinh ==0)
            {
                lblGioiTinh.Text = "Nam";
            }
            else
            {
                lblGioiTinh.Text = "Nữ";
            }
            // lịch sử
            if(ThongTin.MaBN == null)
            {
                switch (ThongTin.Code)
                {
                    case "000":
                        this.lblThongTin.ForeColor = System.Drawing.Color.Blue;
                        lblThongTin.Text = "Thông tin thẻ chính xác.";
                        break;
                    case "001":
                        this.lblThongTin.ForeColor = System.Drawing.Color.DarkRed;
                        lblThongTin.Text = "Thẻ do BHXH Bộ Quốc Phòng quản lý, đề nghị kiểm tra thẻ và thông tin giấy tờ tùy thân.";
                        break;
                    case "002":
                        this.lblThongTin.ForeColor = System.Drawing.Color.DarkRed;
                        lblThongTin.Text = "Thẻ do BHXH Bộ Công An quản lý, đề nghị kiểm tra thẻ và thông tin giấy tờ tùy thân.";
                        break;
                    case "010":
                        this.lblThongTin.ForeColor = System.Drawing.Color.DarkRed;
                        lblThongTin.Text = "Thẻ hết hạn sử dụng.";
                        break;
                    case "051":
                        this.lblThongTin.ForeColor = System.Drawing.Color.DarkRed;
                        lblThongTin.Text = "Mã thẻ không đúng.";
                        break;
                    case "052":
                        this.lblThongTin.ForeColor = System.Drawing.Color.DarkRed;
                        lblThongTin.Text = "Mã tỉnh cấp thẻ (ký tự thứ 4,5 của mã thẻ) không đúng.";
                        break;
                    case "053":
                        this.lblThongTin.ForeColor = System.Drawing.Color.DarkRed;
                        lblThongTin.Text = "Mã quyền lợi thẻ (ký tự 3 của mã thẻ) không đúng.";
                        break;
                    case "050":
                        this.lblThongTin.ForeColor = System.Drawing.Color.DarkRed;
                        lblThongTin.Text = "Không thấy thông tin thẻ BHXH.";
                        break;
                    case "060":
                        this.lblThongTin.ForeColor = System.Drawing.Color.DarkRed;
                        lblThongTin.Text = "Thẻ sai họ tên";
                        break;
                    case "061":
                        this.lblThongTin.ForeColor = System.Drawing.Color.DarkRed;
                        lblThongTin.Text = "Thẻ sai họ tên (đúng ký tự đầu)";
                        break;
                    case "070":
                        this.lblThongTin.ForeColor = System.Drawing.Color.DarkRed;
                        lblThongTin.Text = "Thẻ sai ngày sinh.";
                        break;
                    case "080":
                        this.lblThongTin.ForeColor = System.Drawing.Color.DarkRed;
                        lblThongTin.Text = "Thẻ sai giới tính";
                        break;
                    case "090":
                        this.lblThongTin.ForeColor = System.Drawing.Color.DarkRed;
                        lblThongTin.Text = "Thẻ sai nơi đăng ký KCB ban đầu.";
                        break;
                    case "100":
                        this.lblThongTin.ForeColor = System.Drawing.Color.DarkRed;
                        lblThongTin.Text = "Lỗi khi lấy dữ liệu sổ thẻ.";
                        break;
                    case "101":
                        this.lblThongTin.ForeColor = System.Drawing.Color.DarkRed;
                        lblThongTin.Text = "Lỗi server.";
                        break;
                    case "110":
                        this.lblThongTin.ForeColor = System.Drawing.Color.DarkRed;
                        lblThongTin.Text = "Thẻ đã thu hồi.";
                        break;
                    case "120":
                        this.lblThongTin.ForeColor = System.Drawing.Color.DarkRed;
                        lblThongTin.Text = "Thẻ báo giảm.";
                        break;
                    case "121":
                        this.lblThongTin.ForeColor = System.Drawing.Color.DarkRed;
                        lblThongTin.Text = "Thẻ báo giảm. Giảm chuyển ngoại tỉnh.";
                        break;
                    case "122":
                        this.lblThongTin.ForeColor = System.Drawing.Color.DarkRed;
                        lblThongTin.Text = "Thẻ báo giảm. Giảm chuyển nội tỉnh.";
                        break;
                    case "123":
                        this.lblThongTin.ForeColor = System.Drawing.Color.DarkRed;
                        lblThongTin.Text = "Thẻ báo giảm. Thu hồi do tăng lại cùng đơn vị.";
                        break;
                    case "124":
                        this.lblThongTin.ForeColor = System.Drawing.Color.DarkRed;
                        lblThongTin.Text = "Thẻ báo giảm. Ngừng tham gia.";
                        break;
                    case "130":
                        this.lblThongTin.ForeColor = System.Drawing.Color.DarkRed;
                        lblThongTin.Text = "Trẻ em không xuất trình thẻ.";
                        break;
                    default:
                        lblThongTin.Text = "Mã kết quả: " + ThongTin.Code;
                        break;
                }
                if (ThongTin.ThongBao.IndexOf('[') > 0)
                {
                    ThongTin.ThongBao = ThongTin.ThongBao.Substring(ThongTin.ThongBao.IndexOf('['),
                        ThongTin.ThongBao.IndexOf(']')).Replace("]", "").Replace("[", "");
                    string[] danhsach = ThongTin.ThongBao.Split('}');
                    DataTable data = new DataTable();
                    data.Columns.Add("maHoSo", typeof(string));
                    data.Columns.Add("maCSKCB", typeof(string));
                    data.Columns.Add("tuNgay", typeof(string));
                    data.Columns.Add("denNgay", typeof(string));
                    data.Columns.Add("tenBenh", typeof(string));
                    data.Columns.Add("tinhTrang", typeof(string));
                    data.Columns.Add("kqDieuTri", typeof(string));
                    foreach (string hoso in danhsach)
                    {
                        if (hoso.Length > 0)
                        {
                            string[] dulieu = hoso.Replace("}", "").Replace("{", "").Split(',');
                            DataRow dr = data.NewRow();
                            foreach (string column in dulieu)
                            {
                                if (column.Split(':').Length > 1)
                                {
                                    dr[column.Split(':')[0]] = column.Split(':')[1];
                                }
                            }
                            data.Rows.Add(dr);
                        }
                    }
                    gridControl.DataSource = data;
                }
            }
            else
            {
                this.lblThongTin.ForeColor = System.Drawing.Color.Blue;
                lblThongTin.Text = "Thông tin lịch sử khám chữa bệnh tại bệnh viện.";
            }
        }
    }
}
