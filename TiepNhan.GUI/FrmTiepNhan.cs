using DevExpress.XtraBars.Ribbon;
using KhamBenh.DAL;
using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Core.DAL;
namespace TiepNhan.GUI
{
    public partial class FrmTiepNhan : RibbonForm
    {
        TiepNhanEntity tiepnhan;
        DataTable dataCoso;
        public FrmTiepNhan()
        {
            InitializeComponent();
            tiepnhan = new TiepNhanEntity();

            lookUpTaiNan.Properties.DataSource = tiepnhan.DSTaiNan();
            lookUpTaiNan.Properties.DisplayMember = "Ten";
            lookUpTaiNan.Properties.ValueMember = "Ma";
            dataCoso = tiepnhan.DSCoSoKCB();
            lookUpNoiChuyenDen.Properties.DataSource = dataCoso;
            lookUpNoiChuyenDen.Properties.ValueMember = "Ma_CS";
            lookUpNoiChuyenDen.Properties.DisplayMember = "Ten_CS";
            cbLoaiKCB.SelectedIndex = 0;

            DataTable phongkham = tiepnhan.DSKhoaBan(2);
            if(phongkham!=null)
            {
                foreach(DataRow dr in phongkham.Rows)
                {
                    SimpleButton b = new SimpleButton();
                    b.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    b.Appearance.Options.UseFont = true;
                    b.ImageUri.Uri = "Forward;Size16x16;Office2013";
                    b.Name = dr["MaKhoa"].ToString();
                    b.Size = new System.Drawing.Size(120, 27);
                    b.Text = dr["TenKhoa"].ToString();
                    b.Click += btnNew_Click;
                    flowLayoutPanel.Controls.Add(b);
                }
            }
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                SimpleButton clickedButton = (SimpleButton)sender;
                ChuyenPhong(Utils.ToInt(clickedButton.Name.ToLower().Replace("phongkham", "")));
            }
            catch { }
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.WindowState = FormWindowState.Maximized;
        }
        private void FrmTiepNhan_Load(object sender, EventArgs e)
        {
            ResetForm();

        }
        private void ResetForm()
        {
            checkBHYT.Checked = true;
            txtNgayTN.Text = DateTime.Now.ToString("dd/MM/yyyyy");
            cbGioiTinh.SelectedIndex = 0;
            cbLyDoVaoVien.SelectedIndex = 0;
            lookUpTaiNan.ItemIndex = 0;
        }
        private void checkBHYT_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBHYT.Checked == true)
            {
                txtMaQR.ReadOnly = false;
                txtTheBHYT.ReadOnly = false;
                txtTheTu.ReadOnly = false;
                txtTheDen.ReadOnly = false;
                txtMaDKKCB.ReadOnly = false;
                txtTenDKKCB.ReadOnly = false;
                txtDu5Nam.ReadOnly = false;
                cbKhuVuc.ReadOnly = false;
            }
            else
            {
                txtMaQR.ReadOnly = true;
                txtMaQR.Text = null;
                txtTheBHYT.ReadOnly = true;
                txtTheBHYT.Text = null;
                txtTheTu.ReadOnly = true;
                txtTheTu.Text = null;
                txtTheDen.ReadOnly = true;
                txtTheDen.Text = null;
                txtMaDKKCB.ReadOnly = true;
                txtMaDKKCB.Text = null;
                txtTenDKKCB.ReadOnly = true;
                txtTenDKKCB.Text = null;
                txtDu5Nam.ReadOnly = true;
                txtDu5Nam.Text = null;
                cbKhuVuc.ReadOnly = true;
            }
        }

        private void checkCapCuu_CheckedChanged(object sender, EventArgs e)
        {
            if(checkCapCuu.Checked == true)
            {
                checkUuTien.Checked = false;
                cbLyDoVaoVien.SelectedIndex = 1;
            }
            else
            {
                cbLyDoVaoVien.SelectedIndex = 0;
            }
        }

        private void checkUuTien_CheckedChanged(object sender, EventArgs e)
        {
            if(checkUuTien.Checked == true)
            {
                checkCapCuu.Checked = false;
            }
        }
        private void ChuyenPhong(int phongKham)
        {
            XtraMessageBox.Show("Chuyển phòng: "+phongKham);
        }
    }
}
