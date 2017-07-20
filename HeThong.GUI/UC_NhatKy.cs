using DevExpress.XtraEditors;
using HeThong.DAL;
using System;
using System.Data;
using System.Windows.Forms;

namespace HeThong.GUI
{
    public partial class UC_NhatKy : UserControl
    {
        NhatKyEntity nhatky;
        DataRow dr;
        string quyen = "";
        public UC_NhatKy ()
        {
            InitializeComponent ();
            nhatky = new NhatKyEntity ();
        }
        private void LoadData(string tuNgay, string denNgay)
        {
            gridControl.DataSource = nhatky.DSHoatDong (tuNgay,denNgay);
        }
        private void UC_NhatKy_Load (object sender, EventArgs e)
        {
            quyen = Core.DAL.Utils.GetQuyen (this.Name);
            Enabled_Xoa ();
            dateTuNgay.Text = DateTime.Now.ToShortDateString ();
            dateDenNgay.Text = DateTime.Now.ToShortDateString ();
            LoadData (DateTime.Now.ToShortDateString(), DateTime.Now.ToShortDateString ());
        }
        private void Enabled_Xoa ()
        {
            if (quyen.IndexOf ('3') >= 0)
            {
                btnXoa.Enabled = true;
            }
            else
            {
                btnXoa.Enabled = false;
            }
        }
        private void btnTim_Click (object sender, EventArgs e)
        {
            LoadData (dateTuNgay.Text, dateDenNgay.Text);
        }

        private void btnXoa_ButtonClick (object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            dr = gridView.GetFocusedDataRow ();
            if (dr != null)
            {
                nhatky.MaNV = dr["Ma_NV"].ToString ();
                nhatky.Ngay = DateTime.Parse(dr["Ngay"].ToString ());
                string err = "";
                nhatky.XoaHoatDong (ref err);
                (gridControl.DataSource as DataTable).AsDataView ().Delete (gridView.GetFocusedDataSourceRowIndex ());
            }
        }

        private void btnXoaHet_Click (object sender, EventArgs e)
        {
            DialogResult traloi;
            string err = "";
            traloi = XtraMessageBox.Show ("Chắc chắn bạn muốn xóa mục này?", "Trả lời",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
            {
                if (!nhatky.XoaTatCa (ref err, dateTuNgay.Text, dateDenNgay.Text))
                {
                    MessageBox.Show (err, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                LoadData (dateTuNgay.Text, dateDenNgay.Text);
            }
        }
    }
}
