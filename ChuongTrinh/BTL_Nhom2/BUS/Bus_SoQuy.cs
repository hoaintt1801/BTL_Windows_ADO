using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using DTO;
using System.Data;
using System.Threading.Tasks;

namespace BUS
{
    public class Bus_SoQuy
    {
        Data da = new Data();
        DTO_SoQuy L = new DTO_SoQuy();
        public DataTable ShowPhieuThu()
        {
            string sql = "select * from PhieuThu";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
        public DataTable ShowKhachHang()
        {
            string sql = "select * from KhachHang";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
        public DataTable ShowNCC()
        {
            string sql = "select * from NhaCungCap";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
        //THEM
        public void ThemPhieuThu(string MaPT, string MAKH, string NgayLap, string NguoiLapPhieu, string SoTienThu, string DiaChi, string SDT)
        {
            string sql = "insert PhieuThu values(N'" + MaPT + "',N'" + MAKH + "',N'" + NgayLap + "',N'" + NguoiLapPhieu + "',N'" + SoTienThu + "',N'" + DiaChi + "',N'" + SDT + "')";
            da.ExcuteNonQuery(sql);
        }

        //SUA
        public void SuaPhieuThu(string MaPT, string MAKH, string NgayLap, string NguoiLapPhieu, string SoTienThu, string DiaChi, string SDT)
        {
            string sql = "update PhieuThu set MaKH = N'" + MAKH + "', NgayLap = N'" + NgayLap + "', NguoiLapPhieu = N'" + NguoiLapPhieu + "', SoTienThu = N'" + SoTienThu + "', DiaChi = N'" + DiaChi + "', SDT =  N'" + SDT + "' where MaPT = N'" + MaPT + "'";
            da.ExcuteNonQuery(sql);
        }
        //XOA

        public void XoaPhieuThu(string MaPT)
        {
            string sql = "delete PhieuThu where MaPT = N'" + MaPT.Trim() + "'";
            da.ExcuteNonQuery(sql);
        }
        //THONG KE
        public DataTable ThongKeThu(string ngaybd, string ngaykt)
        {
            string sql = "select *from PhieuThu where NgayLap between N'" + ngaybd + "' and N'" + ngaykt + "'";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
        //PHIEU CHI
        public DataTable ShowPhieuChi()
        {
            string sql = "select * from PhieuChi";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
        //THEM
        public void ThemPhieuChi(string MaPC, string MaNCC, string NgayLap, string NguoiLap, string SoTienChi, string DiaChi, string SDT, string Email)
        {
            string sql = "insert dbo.PhieuChi values(N'" + MaPC + "',N'" + MaNCC + "',N'" + NgayLap + "',N'" + NguoiLap + "',N'" + SoTienChi + "',N'" + DiaChi + "',N'" + SDT + "',N'" + Email + "')";
            da.ExcuteNonQuery(sql);
        }
        //SUA
        public void SuaPhieuChi(string MaPC, string MaNCC, string NgayLap, string NguoiLap, string SoTienChi, string DiaChi, string SDT, string Email)
        {
            string sql = "update dbo.PhieuChi set MaNCC = N'" + MaNCC + "', NgayLap = N'" + NgayLap + "', NguoiLap = N'" + NguoiLap + "', SoTienChi = N'" + SoTienChi + "', DiaChi = N'" + DiaChi + "', SDT = N'" + SDT + "', Email = N'" + Email + "' where MaPC = N'" + MaPC + "'";
            da.ExcuteNonQuery(sql);
        }
        public void XoaPhieuChi(string MaPC)
        {
            string sql = "delete PhieuChi where MaPC = N'" + MaPC + "'";
            da.ExcuteNonQuery(sql);
        }
        public DataTable ThongKeChi(string ngaybd, string ngaykt)
        {
            string sql = "select *from PhieuChi where NgayLap between N'" + ngaybd + "' and N'" + ngaykt + "'";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
        //SO QUY
        public int DonHang()
        {
            int count = 0;
            string sql = "Select *from HoaDon";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            count = dt.Rows.Count;
            return count;
        }
        public int SPdaban()
        {
            int sum = 0;
            string sql = "Select * from HoaDonChiTiet";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                sum += int.Parse(dt.Rows[i][2] + "");
            }
            return sum;
        }
        public int SPdanhap()
        {
            int sum = 0;
            string sql = "Select * from PhieuNhap";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                sum += int.Parse(dt.Rows[i][2] + "");
            }
            return sum;
        }
        public double TongThu()
        {
            double sum = 0;
            string sql = "Select * from PhieuThu";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                sum += double.Parse(dt.Rows[i][4] + "");
            }
            return sum;
        }
        public double TongChi()
        {
            double sum = 0;
            string sql = "Select * from PhieuChi";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                sum += double.Parse(dt.Rows[i][4] + "");
            }
            return sum;
        }
    }
}
