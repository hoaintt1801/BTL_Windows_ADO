using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;

namespace BTL_Nhom2
{
    public partial class FormBaoCaoTK : Form
    {
        public FormBaoCaoTK()
        {
            InitializeComponent();
        }

        private void FormBaoCaoTK_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QuanLyBanHangDataSet1.BCTonKho' table. You can move, or remove it, as needed.
         //   this.BCTonKhoTableAdapter.Fill(this.QuanLyBanHangDataSet1.BCTonKho, null, null);

            this.rpvTK.RefreshReport();
        }

        private void btnTaoBC_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Properties.Settings.Default.QuanLyBanHangConnectionString2;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "BCTonKho";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;
            cmd.Parameters.Add(new SqlParameter("@tungay", dateTimePicker1.Value.Date));
            cmd.Parameters.Add(new SqlParameter("@denngay", dateTimePicker2.Value.Date));
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            rpvTK.ProcessingMode = ProcessingMode.Local;
            rpvTK.LocalReport.ReportPath = "RptTK.rdlc";
           
            if (ds.Tables[0].Rows.Count > 0)
            {
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "DataSet1";
                rds.Value = ds.Tables[0];
                rpvTK.LocalReport.DataSources.Clear();
                rpvTK.LocalReport.DataSources.Add(rds);
                rpvTK.RefreshReport();
            }
        }
    }
}
