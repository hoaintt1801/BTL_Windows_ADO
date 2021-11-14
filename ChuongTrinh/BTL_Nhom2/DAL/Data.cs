using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Data
    {
        //DataTable dt = null;
        //SqlConnection con = null;
        //SqlCommand cmd = null;
        //SqlDataAdapter da = null;
        public SqlConnection GetConnection()
        {
            return new SqlConnection(@"Data Source=DESKTOP-R1KETTP;Initial Catalog=QuanLyBanHang;Integrated Security=True");
           
            
        }
         public DataTable GetTable(string sql)
            {
                SqlConnection con = GetConnection();
                SqlDataAdapter da = new SqlDataAdapter(sql,con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return (dt);


        }
        public void ExcuteNonQuery(string sql)
        {
            SqlConnection con = GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            cmd.Clone();
        }
    }
}
