using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DanhMuc.GUI
{
    public partial class UC_VatTu : UserControl
    {
        DAL.VatTuEntity vattu;
        string quyen = "";
        bool them = false;
        public UC_VatTu ()
        {
            InitializeComponent ();
            vattu = new DAL.VatTuEntity ();
        }

        private void UC_VatTu_Load (object sender, EventArgs e)
        {
            lookUpLoaiVatTu.Properties.DataSource = vattu.DSLoaiVatTu ();
            lookUpLoaiVatTu.Properties.DisplayMember = "Ten";

            lookUpNhomVatTu.Properties.DisplayMember = "Ten";

            lookUpDuongDung.Properties.DataSource = vattu.DSDuongDung ();
            lookUpDuongDung.Properties.DisplayMember = "Ten";

            lookUpDonViTinh.Properties.DataSource = vattu.DSDonViTinh ();
            lookUpDonViTinh.Properties.DisplayMember = "Ten";

            lookUpNuocSX.Properties.DataSource = vattu.DSNuocSX ();
            lookUpNuocSX.Properties.DisplayMember = "Ten";

            checkButton ();
            LoadData ();
        }
        private void LoadData ()
        {
            gridControl.DataSource = vattu.DSVatTu();
        }

        private void checkButton ()
        {
            quyen = Core.DAL.Utils.GetQuyen (this.Name);
            Enabled_Them ();
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
        }
        private void Enabled_Luu ()
        {
            if (quyen.IndexOf ('2') >= 0 || them)
            {
                btnLuu.Enabled = true;
            }
            else
            {
                btnLuu.Enabled = false;
            }
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
        private void Enabled_Them ()
        {
            if (quyen.IndexOf ('1') >= 0)
            {
                btnThem.Enabled = true;
            }
            else
            {
                btnThem.Enabled = false;
            }
        }


        private void lookUpLoaiVatTu_EditValueChanged (object sender, EventArgs e)
        {
            vattu.LoaiVatTu = (lookUpLoaiVatTu.GetSelectedDataRow () as DataRowView)[0].ToString ();
            lookUpNhomVatTu.Properties.DataSource = vattu.DSNhomVatTu ();
        }

        private void btnThem_Click (object sender, EventArgs e)
        {
            them = true;

            Enabled_Luu ();
        }

        private void btnLuu_Click (object sender, EventArgs e)
        {

        }

        private void btnXoa_Click (object sender, EventArgs e)
        {

        }

        private void lookUpNhomVatTu_EditValueChanged (object sender, EventArgs e)
        {
            vattu.NhomVatTu = (lookUpNhomVatTu.GetSelectedDataRow () as DataRowView)[0].ToString ();
            LoadData ();
        }
    }
}
