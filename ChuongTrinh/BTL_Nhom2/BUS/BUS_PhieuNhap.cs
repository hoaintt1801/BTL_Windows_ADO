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
    public class BUS_PhieuNhap
    {
        Data da = new Data();
        //lấy thông tin lớp đổ ra datagirlview
        public DataTable ShowLop()
        {
            String sql = "select *from PhieuNhap";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
        public void InsertPN(string mapn, string masp, int sln, float dgn, string ngayn, string mancc)
        {
            string sql = "insert PhieuNhap values(N'" + mapn + "',N'" + masp + "',N'" + sln + "',N'" + dgn + "',N'" + ngayn + "',N'" + mancc + "')";
            //lệnh thực thi không trả về bảng đã viết bên lớp DAL
            da.ExcuteNonQuery(sql);
        }
        public void UpdatePN(string mapn, string masp, int sln, float dgn, string ngayn, string mancc)
        {
            string sql = "update PhieuNhap set SoLuongNhap=N'" + sln + "'," +
                "DonGiaNhap=N'" + dgn + "',MaNCC=N'" + mancc + "',MaSP=N'" + masp + "',NgayNhap=N'" + ngayn + "'where MaPn=N'" + mapn + "'";
            //lệnh thực thi không trả về bảng đã viết bên lớp DAL
            da.ExcuteNonQuery(sql);
        }
        public void DeletePN(string mapn)
        {
            string sql = "delete PhieuNhap where MaPN=N'" + mapn + "'";
            //lệnh thực thi không trả về bảng đã viết bên lớp DAL
            da.ExcuteNonQuery(sql);
        }
        public DataTable LookMPN(String dk)
        {
            string sql = "select *from PhieuNhap where MaPN like N'" + dk + "%'";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
        public DataTable LookMNCC(String dk)
        {
            string sql = "select *from PhieuNhap where MaNCC like N'" + dk + "%'";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
        public DataTable LookTSP(String dk)
        {
            string sql = "select *from PhieuNhap where MaSP like N'" + dk + "%'";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
    }
}
