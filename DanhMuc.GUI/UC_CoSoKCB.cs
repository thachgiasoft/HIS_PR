using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DanhMuc.DAL;
using Core.DAL;
using DevExpress.XtraEditors;

namespace DanhMuc.GUI
{
    public partial class UC_CoSoKCB : UserControl
    {
        CoSoKCBEntity cosoKCB;
        BackgroundWorker bw = new BackgroundWorker();
        public UC_CoSoKCB ()
        {
            InitializeComponent ();
            cosoKCB = new CoSoKCBEntity ();
            bw.WorkerSupportsCancellation = true;
            bw.WorkerReportsProgress = true;
            bw.DoWork += new DoWorkEventHandler(bw_DoWork);
            bw.ProgressChanged += new ProgressChangedEventHandler(bw_ProgressChanged);
            bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bw_RunWorkerCompleted);
        }

        private void UC_CoSoKCB_Load (object sender, EventArgs e)
        {
            gridControl.DataSource = cosoKCB.DSCoSoKCB ();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            DialogResult dr = ImportExcel.OpenDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    if (bw.IsBusy != true)
                    {
                        btnNhap.Enabled = false;
                        bw.RunWorkerAsync();
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    return;
                }
            }
        }
        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            layoutProcess.Text = "Hoàn thành";
            btnNhap.Enabled = true;
            gridControl.DataSource = cosoKCB.DSCoSoKCB();
        }
        private void bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            layoutProcess.Text = "Tiến trình: " + e.ProgressPercentage + "%";
            progressBarControl.Position = (e.ProgressPercentage);
        }
        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                DataTable data = ImportExcel.OpenFile();
                string err;
                int len = data.Rows.Count - 1;
                int i = 0;
                foreach (DataRow dtRow in data.Rows)
                {
                    cosoKCB.MaCS = dtRow.ItemArray[1].ToString();
                    cosoKCB.TenCS = dtRow.ItemArray[2].ToString();
                    cosoKCB.DiaChi = dtRow.ItemArray[3].ToString();
                    err = "";
                    if (cosoKCB.MaCS.Length > 0)
                    {
                        cosoKCB.ThemCoSoKCB(ref err);
                    }
                    i++;
                    bw.ReportProgress((int)(100.0 / len * i));
                }
            }
            catch (Exception ex)
            {
                bw.CancelAsync();
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
    }
}
