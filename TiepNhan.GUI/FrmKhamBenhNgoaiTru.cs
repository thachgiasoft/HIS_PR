using Core.DAL;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
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
    public partial class FrmKhamBenhNgoaiTru : RibbonForm
    {
        DataTable dataDanhSach;
        KhamBenhEntity khambenh;
        string quyen = "";
        private List<int> listPhongKham = new List<int>();
        public FrmKhamBenhNgoaiTru()
        {
            InitializeComponent();
            khambenh = new KhamBenhEntity();
            DataTable phongkham = khambenh.DSKhoaBan(2);
            checkButton();
            if (phongkham != null)
            {
                foreach (DataRow dr in phongkham.Rows)
                {
                    SimpleButton b = new SimpleButton();
                    b.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    b.Appearance.Options.UseFont = true;
                    b.ImageUri.Uri = "Forward;Size16x16;Office2013";
                    b.Name = dr["MaKhoa"].ToString();
                    b.Size = new System.Drawing.Size(120, 23);
                    b.Text = dr["TenKhoa"].ToString();
                    b.Click += btnNew_Click;
                    flowLayoutPanelChuyenPhong.Controls.Add(b);
                    listPhongKham.Add(Utils.ToInt(b.Name.Substring(b.Name.Length - 2, 2)));
                    if (quyen.IndexOf('2') >= 0 && b.Name != AppConfig.MaKhoa)// mã khoa khác mã kha của nhân viên
                    {
                        b.Enabled = true;
                    }
                    else
                    {
                        b.Enabled = false;
                    }
                }
            }
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.WindowState = FormWindowState.Maximized;
        }
        private void checkButton()
        {
            quyen = Core.DAL.Utils.GetQuyen(this.Name);
        }
        private void FrmKhamBenhNgoaiTru_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            dataDanhSach = khambenh.DSTiepNhan(DateTime.Now.ToShortDateString());
            GanSoLuongPhongKham(dataDanhSach);
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
                SimpleButton clickedButton = (SimpleButton)sender;
                //ChuyenPhong(Utils.ToInt(clickedButton.Name.Substring(clickedButton.Name.Length - 2, 2)));
        }
        private void GanSoLuongPhongKham(DataTable data)
        {
            lblPhongKham.Text = "";
            if (data != null && data.Rows.Count > 0)
            {
                foreach (var t in listPhongKham)
                {
                    lblPhongKham.Text += "Phòng khám " + t + ": " + data.Select("Phong = " + t).Length + "     ";
                }
            }
            else
            {

                foreach (var t in listPhongKham)
                {
                    lblPhongKham.Text += "Phòng khám " + t + ": 0     ";
                }
            }
            gridControl.DataSource = data;
        }
        private void checkTatCa_CheckedChanged(object sender, EventArgs e)
        {
            if(checkTatCa.Checked)
            {

            }
        }

        private void checkChoKham_CheckedChanged(object sender, EventArgs e)
        {
            if(checkChoKham.Checked)
            {

            }
        }

        private void checkDaKham_CheckedChanged(object sender, EventArgs e)
        {
            if(checkDaKham.Checked)
            {

            }
        }

        private void checkChuyenTuyen_CheckedChanged(object sender, EventArgs e)
        {
            if(checkChuyenTuyen.Checked)
            {

            }
        }

        private void checkNhapVien_CheckedChanged(object sender, EventArgs e)
        {
            if(checkNhapVien.Checked)
            {

            }
        }

        private void checkRaVien_CheckedChanged(object sender, EventArgs e)
        {
            if(checkRaVien.Checked)
            {

            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadData();
            checkTatCa.Checked = true;
        }
    }
}
