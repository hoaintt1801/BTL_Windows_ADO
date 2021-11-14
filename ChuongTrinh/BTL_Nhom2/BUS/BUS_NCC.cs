using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace BUS
{
    public class BUS_NCC
    {
         
        Data da = new Data();
       
        //lấy thông tin lớp đổ ra datagirlview
        public DataTable ShowLop()
        {
            String sql = "select *from NhaCungCap";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
        public void InsertPN(string mancc, string tenncc, string dc, string sdt, string email)
        {
            string sql = "insert NhaCungCap values(N'" + mancc + "',N'" + tenncc + "',N'" + dc + "',N'" + sdt + "',N'" + email + "')";
            //lệnh thực thi không trả về bảng đã viết bên lớp DAL
            da.ExcuteNonQuery(sql);
        }
        public void UpdatePN(string mancc, string tenncc, string dc, string sdt, string email)
        {
            string sql = "update NhaCungCap set TenNCC=N'" + tenncc + "'," +
                "DiaChi=N'" + dc + "',Sdt=N'" + sdt + "',Email=N'" + email + "' where MaNCC=N'" + mancc + "'";
            //lệnh thực thi không trả về bảng đã viết bên lớp DAL
            da.ExcuteNonQuery(sql);
        }
        public void DeletePN(string mancc)
        {
            string sql = "delete NhaCungCap where MaNCC=N'" + mancc + "'";
            //lệnh thực thi không trả về bảng đã viết bên lớp DAL
            da.ExcuteNonQuery(sql);
        }
        public DataTable LookMPN(String dk)
        {
            string sql = "select *from NhaCungCap where MaNCC like N'" + dk + "%'";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
        public DataTable LookTPN(String dk)
        {
            string sql = "select *from NhaCungCap where TenNCC like N'" + dk + "%'";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
    }
}
