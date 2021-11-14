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
    public partial class FormBCTaiChinh : Form
    {
        public FormBCTaiChinh()
        {
            InitializeComponent();
        }

        private void FormBCTaiChinh_Load(object sender, EventArgs e)
        {

        }

        private void btnTaoBC_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Properties.Settings.Default.QuanLyBanHangConnectionString2;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "BCTaiChinh";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;
            cmd.Parameters.Add(new SqlParameter("@tungay", dateTimePicker1.Value.Date));
            cmd.Parameters.Add(new SqlParameter("@denngay", dateTimePicker2.Value.Date));
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            rpvTK.ProcessingMode = ProcessingMode.Local;
            rpvTK.LocalReport.ReportPath = "RptTC.rdlc";

            if (ds.Tables[0].Rows.Count > 0)
            {
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "DsTC";
                rds.Value = ds.Tables[0];
                rpvTK.LocalReport.DataSources.Clear();
                rpvTK.LocalReport.DataSources.Add(rds);
                rpvTK.RefreshReport();
            }
        }
    }
}
