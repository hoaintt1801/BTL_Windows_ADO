using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using DAL;

namespace BTL_Nhom2
{
    public partial class FormSoQuy : Form
    {
        public FormSoQuy()
        {
            InitializeComponent();
        }
        DTO_SoQuy L = new DTO_SoQuy();
        Bus_SoQuy loph = new Bus_SoQuy();
   
        private void btnChartMoney_Click(object sender, EventArgs e)
        {
            lblTongChi.Text = loph.TongChi().ToString();
            //string.Format("{0:c}", Convert.ToDecimal(lblTongThu.Text));
            lblTongThu.Text = loph.TongThu().ToString();
            lblDoanhSo.Text = (loph.TongThu() - loph.TongChi()).ToString();
            lblHoaDon.Text = loph.DonHang().ToString();
            lblSumSPdaban.Text = loph.SPdaban().ToString();
            lblSumSPdanhap.Text = loph.SPdanhap().ToString();
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-R1KETTP;Initial Catalog=QuanLyBanHang;Integrated Security=True");
            DataTable dt = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter("select month(NgayLap) as Ngay,SoTienThu from PhieuThu order by NgayLap ASC ", con);
            con.Open();
            ad.Fill(dt);
            con.Close();
            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Thang";
            chart1.ChartAreas["ChartArea1"].AxisY.Title = "Doanh Thu";
            chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                chart1.Series["DoanhThu"].Points.AddXY(dt.Rows[i]["Ngay"], dt.Rows[i]["SoTienThu"]);
            }
        }

        private void FormSoQuy_Load(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
