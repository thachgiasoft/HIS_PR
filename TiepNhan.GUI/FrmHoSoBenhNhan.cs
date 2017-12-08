using DevExpress.Data;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraGrid.Columns;
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
    public partial class FrmHoSoBenhNhan : RibbonForm
    {
        DanhSachEntity danhSach;
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
            dateDenNgay.DateTime = DateTime.Now;
            dateTuNgay.DateTime = DateTime.Now;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            gridControl.DataSource = danhSach.DSBenhNhan(dateTuNgay.DateTime, dateDenNgay.DateTime);
        }

        private void btnBHYT_Click(object sender, EventArgs e)
        {
            // tạo file gửi lên cổng và lưu 
            DataRow[] dr = (gridControl.DataSource as DataTable).Select("Chon = True", "");
            for(int i=0;i<dr.Length;i++)
            {
                //thêm _ vào Mã khoa, đúng dịnh dạng ngày vào ngày ra, thanh toán...
                // dr xml 1, data thuoc xml 2, data vat tu dich vu xml3, data can lam san xml4 
            }
        }

    }
}
