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
    public partial class FrmKeDonThuoc : RibbonForm
    {
        public string MaLK { get; set; }
        public string HoTen { get; set; }
        public string TheDen { get; set; }
        private KeDonEntity kedon;
        private string maBenhChinh = null;
        DataTable dtBenh;
        Dictionary<string, bool> listThuoc;
        public FrmKeDonThuoc()
        {
            InitializeComponent();
            kedon = new KeDonEntity();
            lookUpBacSi.Properties.DataSource = kedon.DSBacSi();
            lookUpBacSi.Properties.DisplayMember = "Ten_NV";
            lookUpBacSi.Properties.ValueMember = "Ma_BS";
            lookUpMaKhoa.Properties.DataSource = kedon.DSKhoaBan(1);
            lookUpMaKhoa.Properties.ValueMember = "MaKhoa";
            lookUpMaKhoa.Properties.DisplayMember = "TenKhoa";
            dtBenh = kedon.DSBenh();
            lookUpMaBenh.Properties.DataSource = dtBenh;
            lookUpMaBenh.Properties.DisplayMember = "MaBenh";
            lookUpMaBenhKhac.Properties.DisplayMember = "MaBenh";
            lookUpMaBenhKhac.Properties.DataSource = dtBenh;
            lookUpVatTu.Properties.DisplayMember = "TenVatTu";
        }

        private void FrmKeDonThuoc_Load(object sender, EventArgs e)
        {
            lookUpMaKhoa.ItemIndex = 0;
            this.ActiveControl = lookUpMaBenh;
            if(lookUpBacSi.ItemIndex <0)
            {
                lookUpBacSi.ItemIndex = 0;
            }
            txtHoTen.Text = this.HoTen;
            lblHanThe.Text = "Hạn thẻ BHYT còn: " + (Utils.ToDateTime(this.TheDen) - DateTime.Now).Days + " ngày";
            dateYLenh.DateTime = DateTime.Now;
            cbLoaiChiPhi.SelectedIndex = 0;
            listThuoc = new Dictionary<string, bool>();
            if(!string.IsNullOrEmpty(MaLK))
            {
                kedon.MaLK = MaLK;
                if(kedon.LayThongTinMaBenh() && !string.IsNullOrEmpty(kedon.MaBenh))
                {
                    maBenhChinh = this.kedon.MaBenh;
                    txtMaBenhKhac.Text = this.kedon.MaBenhKhac;
                    txtTenBenh.Text = this.kedon.TenBenh;
                }
                // lấy danh sách thuốc
                gridControlThuoc.DataSource = kedon.DSThuoc();

            }
        }

        private void txtSoLuong_Enter(object sender, EventArgs e)
        {
            txtSoLuong.Select(0,txtSoLuong.Value.ToString().Length);
        }

        private void txtNgayUong_Enter(object sender, EventArgs e)
        {
            txtNgayUong.Select(0, txtNgayUong.Value.ToString().Length);
        }

        private void txtLanUong_Enter(object sender, EventArgs e)
        {
            txtLanUong.Select(0, txtLanUong.Value.ToString().Length);
        }

        private void txtSoLuong_ValueChanged(object sender, EventArgs e)
        {
            if(txtSoLuong.Value > 150)
            {
                XtraMessageBox.Show("Số lượng thuốc "+txtSoLuong.Value,"Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lookUpMaBenh_EditValueChanged(object sender, EventArgs e)
        {
            object dr = lookUpMaBenh.GetSelectedDataRow();
            if(dr is DataRowView)
            {
                txtMaBenhKhac.Text = null;
                maBenhChinh = (dr as DataRowView)[0].ToString();
                txtTenBenh.Text = (dr as DataRowView)[1].ToString();
            }
            else
            {
                txtMaBenhKhac.Text = null;
                txtTenBenh.Text = null;
                maBenhChinh = null;
            }
        }

        private void lookUpMaBenhKhac_EditValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(maBenhChinh))
            {
                object dr = lookUpMaBenhKhac.GetSelectedDataRow();
                if (dr is DataRowView && txtMaBenhKhac.Text.Split(';').Length < 10)
                {
                    string maBenhKhac = (dr as DataRowView)[0].ToString();
                    if (maBenhKhac != maBenhChinh && !txtMaBenhKhac.Text.Contains(maBenhKhac))
                    {
                        txtMaBenhKhac.Text += maBenhKhac + "; ";
                        txtTenBenh.Text += "; " + (dr as DataRowView)[1].ToString();
                    }
                    else
                    {
                        XtraMessageBox.Show("Mã bệnh đã được chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                XtraMessageBox.Show("Chưa chọn bệnh chính!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lookUpMaBenh.Focus();
            }
        }

        private void txtMaBenhKhac_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (!string.IsNullOrEmpty(maBenhChinh))
                {
                    List<string> list = new List<string>();
                    foreach(string item in txtMaBenhKhac.Text.Split(';'))
                    {
                        if(!string.IsNullOrEmpty(item.Trim())&&!item.Trim().Equals(maBenhChinh)
                            &&!list.Contains(item.Trim()))
                        {
                            list.Add(item.Trim());
                        }
                    }
                    txtMaBenhKhac.Text = "";
                    txtTenBenh.Text = dtBenh.Select("MaBenh = '"+maBenhChinh+"'","")[0][1].ToString();
                    foreach(string item in list)
                    {
                        txtMaBenhKhac.Text += item + "; ";
                        var dr = dtBenh.Select("MaBenh = '" + item + "'", "");
                        if (dr != null)
                            txtTenBenh.Text += "; " + dr[0][1].ToString();
                        
                    }
                    lookUpBacSi.Focus();
                }
                else
                {
                    lookUpMaBenh.Focus();
                }
            }
        }

        private void lookUpMaBenh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                lookUpMaBenhKhac.Focus();
        }

        private void lookUpMaBenhKhac_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                lookUpBacSi.Focus();
        }

        private void lookUpBacSi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                lookUpVatTu.Focus();
        }

        private void lookUpVatTu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                txtSoLuong.Focus();
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                txtNgayUong.Focus();
        }

        private void txtNgayUong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                txtLanUong.Focus();
        }

        private void txtLanUong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                btnChon.Focus();
        }

        private void cbLoaiChiPhi_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.gridViewVatTu.Columns.Clear();
            // dựa theo mã khoa để xác định kho lấy thuốc
            // Khoa khám bệnh, khoa nội, khoa ngoại,
            // vật tư nào có mã hoạt chất mới cho kê đơn
            if (cbLoaiChiPhi.SelectedIndex == 0)
            {
                this.gridViewVatTu.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
                this.MaVatTu,
                this.MaHoatChat,
                this.TenVatTu,
                this.HamLuong,
                this.DonViTinh,
                this.GiaBHYT,
                this.SoLuongTon});
                this.MaVatTu.VisibleIndex = 0;
                this.MaHoatChat.VisibleIndex = 1;
                this.TenVatTu.VisibleIndex = 2;
                this.HamLuong.VisibleIndex = 3;
                this.DonViTinh.VisibleIndex = 4;
                this.GiaBHYT.VisibleIndex = 5;
                this.SoLuongTon.VisibleIndex = 6;
                lookUpVatTu.Properties.DataSource =
                    kedon.DSKeDon(lookUpMaKhoa.EditValue.ToString(), "1");
            }
            else if (cbLoaiChiPhi.SelectedIndex == 1)
            {
                this.gridViewVatTu.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
                this.MaVatTu,
                this.MaHoatChat,
                this.TenVatTu,
                this.DonViTinh,
                this.GiaBHYT,
                this.SoLuongTon});
                this.MaVatTu.VisibleIndex = 0;
                this.MaHoatChat.VisibleIndex = 1;
                this.TenVatTu.VisibleIndex = 2;
                this.DonViTinh.VisibleIndex = 3;
                this.GiaBHYT.VisibleIndex = 4;
                this.SoLuongTon.VisibleIndex = 5;
                lookUpVatTu.Properties.DataSource =
                    kedon.DSKeDon(lookUpMaKhoa.EditValue.ToString(), "2");
            }
            else
            {
                this.gridViewVatTu.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
                this.MaVatTu,
                this.TenVatTu,
                this.GiaBHYT});
                this.MaVatTu.VisibleIndex = 0;
                this.TenVatTu.VisibleIndex = 1;
                this.GiaBHYT.VisibleIndex = 2;
                lookUpVatTu.Properties.DataSource = kedon.DSDichVuKyThuat();
            }
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            // kiểm tra nhập mã bệnh
            if(string.IsNullOrEmpty(maBenhChinh))
            {
                XtraMessageBox.Show("Chưa chọn bệnh chính!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lookUpMaBenh.Focus();
                return;
            }
            if (lookUpVatTu.EditValue is DataRowView)
            {
                DataRowView dr = (lookUpVatTu.EditValue as DataRowView);
                if (cbLoaiChiPhi.SelectedIndex == 0)
                {
                    //kiểm tra số lượng tồn thuốc

                }
                else if (cbLoaiChiPhi.SelectedIndex == 1)
                {
                    //kiểm tra số lượng tồn vật tư
                }
                else
                {
                    //dịch vụ
                }
            }
            // không cho chỉnh sửa số lượng, chỉ cho xóa rồi thêm mới,
            // thêm mới sẽ tự tìm thuốc, có thể 1 thuốc có nhiều dòng
            // xóa sẽ tìm và xóa các dòng
        }
    }
}
