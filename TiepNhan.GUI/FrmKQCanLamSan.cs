using Core.DAL;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using KhamBenh.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace TiepNhan.GUI
{
    public partial class FrmKQCanLamSan : RibbonForm
    {
        CanLamSanEntity canLamSan;
        DataView dvDichVu;
        Dictionary<string, int> listDichVu;
        public FrmKQCanLamSan()
        {
            InitializeComponent();
            canLamSan = new CanLamSanEntity();
            lookUpMaKhoa.Properties.DataSource = canLamSan.DSKhoaBan(1);
            lookUpMaKhoa.Properties.ValueMember = "MaKhoa";
            lookUpMaKhoa.Properties.DisplayMember = "TenKhoa";
            lookUpBacSi.Properties.DataSource = canLamSan.DSBacSi();
            lookUpBacSi.Properties.ValueMember = "Ma_BS";
            lookUpBacSi.Properties.DisplayMember = "Ten_NV";
        }
        public string HoTen { get; set; }
        public string TenCanLamSan { get; set; }
        public string ChuanDoan { get; set; }
        public string YeuCau { get; set; }
        public int MaNhom { get; set; }
        public string MaLK { get; set; }
        public string MaCSL { get; set; }
        public string MaBacSi { get; set; }
        public string MaMay { get; set; }

        private void FrmKQCanLamSan_Load(object sender, EventArgs e)
        {
            canLamSan.MaCLS = this.MaCSL;
            canLamSan.MaLK = this.MaLK;
            lookUpMaKhoa.ItemIndex = 0;
            txtHoTen.Text = this.HoTen;
            txtCanLamSan.Text = this.TenCanLamSan;
            txtYeuCau.Text = this.YeuCau;
            txtChuanDoan.Text = this.ChuanDoan;
            lookUpDichVu.Properties.DataSource = canLamSan.DSDichVu(this.MaNhom);

            this.ActiveControl = this.lookUpDichVu;
            // load data
            dvDichVu = canLamSan.DSDichVuChiTiet().AsDataView();
            gridControl.DataSource = dvDichVu;
            listDichVu = new Dictionary<string, int>();
            foreach(DataRowView dr in dvDichVu)
            {
                // 0. xóa, 1. đã có, 2. thêm mới
                listDichVu.Add(dr["MaDichVu"].ToString(), 1);
            }
            lookUpBacSi.EditValue = this.MaBacSi;
        }

        private void txtSoLuong_Enter(object sender, EventArgs e)
        {
            txtSoLuong.Select(0, txtSoLuong.Value.ToString().Length);
        }

        private void lookUpDichVu_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if(e.KeyChar==13)
            {
                txtSoLuong.Focus();
            }
        }

        private void txtSoLuong_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if(e.KeyChar==13)
            {
                txtGiaTri.Focus();
            }
        }

        private void txtGiaTri_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if(e.KeyChar==13)
            {
                txtMoTa.Focus();
            }
        }

        private void txtMoTa_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if(e.KeyChar==13)
            {
                txtKetLuan.Focus();
            }
        }

        private void txtKetLuan_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if(e.KeyChar==13)
            {
                btnChon.Focus();
            }
        }

        private void repBtnXoa_ButtonClick(object sender, 
            DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int index = gridView.GetFocusedDataSourceRowIndex();
            if (index > -1)
            {
                // 0. xóa
                listDichVu[(dvDichVu.ToTable().Rows[index]["MaDichVu"].ToString())] = 0;
                (gridControl.DataSource as DataView).Delete(index);
            }
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            if (lookUpDichVu.EditValue is DataRowView)
            {
                DataRowView dr = (lookUpDichVu.EditValue as DataRowView);
                string maDichVu = dr["MaDVKT"].ToString();
                if (listDichVu.ContainsKey(maDichVu) && listDichVu[maDichVu] >0)
                {// đã có và 1 hoặc 2
                    XtraMessageBox.Show(Library.DichVuDaDuocChon, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lookUpDichVu.Focus();
                    return;
                }
                if (listDichVu.ContainsKey(maDichVu) && listDichVu[maDichVu] ==0)
                {
                    listDichVu[maDichVu] = 1;// đã có và đánh dấu 0. xóa, cập nhật lại
                }else
                {
                    listDichVu.Add(maDichVu, 2);// 2. thêm mới
                }
                DataRowView drvNew = (gridControl.DataSource as DataView).AddNew();
                drvNew["MaDichVu"] = maDichVu;
                drvNew["TenDichVu"] = dr["TenDVKT"];
                drvNew["SoLuong"] = txtSoLuong.Value;
                drvNew["DonGia"] = dr["DonGia"];
                drvNew["ThanhTien"] = txtSoLuong.Value * Utils.ToDecimal(dr["DonGia"]);
                drvNew["NgayKQ"] = DateTime.Now;
                drvNew["GiaTri"] = txtGiaTri.Text;
                drvNew["MoTa"] = txtMoTa.Text;
                drvNew["KetLuan"] = txtKetLuan.Text;
                drvNew["NgayYLenh"] = DateTime.Now;
                drvNew["MaChiSo"] = dr["TT50"];

                lookUpDichVu.Focus();
                txtGiaTri.Text = "";
                txtMoTa.Text = "";
                txtKetLuan.Text = "";
            }
        }

        private void txtKetLuan_Enter(object sender, EventArgs e)
        {
            txtKetLuan.Text = "Bình thường";
        }

        private void gridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if(e.Column.Name =="SoLuong")
            {
                this.gridView.CellValueChanged -= new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView_CellValueChanged);
                var dongia = gridView.GetRowCellValue(e.RowHandle, gridView.Columns["DonGia"]);
                gridView.SetFocusedRowCellValue("ThanhTien", Utils.ToInt(e.Value) * Utils.ToDecimal(dongia));
                this.gridView.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView_CellValueChanged);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string err = "";
            if(dvDichVu.Count>0)
            {
                //cập nhật đã cận lâm sàn
                canLamSan.CapNhatCDCanLamSan(ref err, 1);
            }
            else
            {
                canLamSan.CapNhatCDCanLamSan(ref err, 0);
            }
            List<string> keys = new List<string>(listDichVu.Keys);
            canLamSan.MaLK = this.MaLK;
            canLamSan.MaCLS = this.MaCSL;
            canLamSan.MaNhom = this.MaNhom;
            canLamSan.MaBacSi = Utils.ToString(lookUpBacSi.EditValue);
            canLamSan.MaMay = this.MaMay;
            foreach(string key in keys)
            {
                if(listDichVu[key]==0)
                {
                    // xóa
                    err = "";
                    canLamSan.MaDichVu = key;
                    canLamSan.NgayKQ = DateTime.Now;
                    canLamSan.NgayYLenh = DateTime.Now;
                    if (canLamSan.SpDichVuChiTiet(ref err, "DELETE"))
                    {
                        listDichVu.Remove(key);
                    }
                }
            }
            foreach(DataRowView drv in dvDichVu)
            {
                err = "";
          
                canLamSan.MaDichVu = drv["MaDichVu"].ToString();
                canLamSan.TenDichVu = drv["TenDichVu"].ToString();
                canLamSan.DonViTinh = "Lần";
                canLamSan.SoLuong = Utils.ToInt(drv["SoLuong"]);
                canLamSan.DonGia = Utils.ToDecimal(drv["DonGia"]);
                canLamSan.TyLe = 100;
                canLamSan.ThanhTien = Utils.ToDecimal(drv["ThanhTien"]);
                canLamSan.MaKhoa = Utils.ToString(lookUpMaKhoa.EditValue);
                canLamSan.NgayYLenh = Utils.ToDateTime(drv["NgayYLenh"].ToString());
                canLamSan.NgayKQ = Utils.ToDateTime(drv["NgayKQ"].ToString());
                canLamSan.MaPTTT = 0;
                canLamSan.MaChiSo = drv["MaChiSo"].ToString(); ;
                canLamSan.GiaTri = drv["GiaTri"].ToString();
                canLamSan.MoTa = drv["MoTa"].ToString();
                canLamSan.KetLuan = drv["KetLuan"].ToString();
                if(listDichVu[canLamSan.MaDichVu] ==1)
                {
                    // cập nhật
                    canLamSan.SpDichVuChiTiet(ref err, "UPDATE");
                }
                else if(listDichVu[canLamSan.MaDichVu] ==2)
                {
                    // thêm mới
                    if (canLamSan.SpDichVuChiTiet(ref err, "INSERT"))
                        listDichVu[canLamSan.MaDichVu] = 1;
                }
                if(!string.IsNullOrEmpty(err))
                {
                    XtraMessageBox.Show(err, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
