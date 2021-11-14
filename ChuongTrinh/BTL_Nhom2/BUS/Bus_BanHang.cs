using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using System.Data;
using System.Threading.Tasks;

namespace BUS
{
    public class Bus_BanHang
    {

        Data data = new Data();
        Bus_ID Bus_ID = new Bus_ID();
        //Hóa Đơn
        public DataTable getHoaDon()
        {
            string sql = "select * from HoaDon";
            return data.GetTable(sql);
        }
        public void updateHoaDon(string MaHD)
        {
            string sql = "update HoaDon set TrangThai = 1 where MaHD = '"+MaHD+"'";
            data.ExcuteNonQuery(sql);
        }
        public void insertHoaDon(string MaHD, string MaKH, string MaNV, string MaHTTT)
        {
            DateTime NgayLap = new DateTime();
            NgayLap = DateTime.Now;
            string sql = "Insert into HoaDon values('" + MaHD + "', '" + MaKH + "', N'" + NgayLap + "', '" + MaNV + "', '" + MaHTTT + "',0)";
            data.ExcuteNonQuery(sql);
            Bus_ID.updateID(1);
        }
        //insert KH
        public void insertKhachHang(string MaKH, string TenKH, string DiaChi, string sdt, string MaNKH)
        {
            string sql = "";
            if (DiaChi.Length > 0)
            {
                if (sdt.Length > 0)
                {
                    sql = "insert into KhachHang values('" + MaKH + "',N'" + TenKH + "', N'" + DiaChi + "','" + sdt + "' , '" + MaNKH.Trim() + "')";
                }
                else
                {
                    sql = "insert into KhachHang values('" + MaKH + "',N'" + TenKH + "', N'" + DiaChi + "', null , '" + MaNKH.Trim() + "')";
                }
            }
            else
            {
                if (sdt.Length > 0)
                {
                    sql = "insert into KhachHang values('" + MaKH + "',N'" + TenKH + "', null,'" + sdt + "' , '" + MaNKH.Trim() + "')";
                }
                else
                {
                    sql = "insert into KhachHang values('" + MaKH + "',N'" + TenKH + "', null, null, '" + MaNKH.Trim() + "')";
                }
            }
            data.ExcuteNonQuery(sql);
        }
        //sản phẩm
        public DataTable getSanPham()
        {
            string sql = "select * from SanPham";
            return data.GetTable(sql);
        }
        //Hóa đơn chi tiết
        public DataTable getHoaDonChiTiet(string maHD)
        {
            string sql = "select SanPham.MaSP as N'Mã SP', TenSP as N'Tên SP',HoaDonChiTiet.SoLuong as N'Số lượng', Giaban as N'Giá bán',MoTa as N'Mô tả' from HoaDon, HoaDonChiTiet, SanPham where HoaDon.MaHD = HoaDonChiTiet.MaHD and HoaDonChiTiet.MaSP = SanPham.MaSP and HoaDon.MaHD = '" + maHD + "'";
            return data.GetTable(sql);
        }
        public void delHoaDon(string maHD)
        {
            string sql = "delete from HoaDonChiTiet where MaHD = '" + maHD + "'";
            data.ExcuteNonQuery(sql);
            sql = "delete from HoaDon where MaHD = '" + maHD + "'";
            data.ExcuteNonQuery(sql);
        }
            //xóa SP Hóa đơn chi tiết
            public void delHoaDonChiTiet(string maHD, string maSP)
        {
            string sql = "delete from HoaDonChiTiet where MaHD = '" + maHD + "' and MaSP = '" + maSP + "'";
            data.ExcuteNonQuery(sql);
        }//chèn SP Hóa đơn chi tiết
        public void insertHoaDonChiTiet(string maHD, string maSP, int soLuong)
        {
            string sql = "insert into HoaDonChiTiet values('" + maHD + "','" + maSP + "'," + soLuong + ")";
            data.ExcuteNonQuery(sql);
        }
        //update SP Hóa đơn chi tiết
        public void updateHoaDonChiTiet(string maHD, string maSP, int soLuong)
        {
            string sql = "update HoaDonChiTiet set SoLuong = " + soLuong + " where MaHD = '" + maHD + "' and MaSP = '" + maSP + "'";
            data.ExcuteNonQuery(sql);
        }
        //update SP Hóa đơn chi tiết
        public void updateHoaDonChiTiet1(string maHD, string maSP, int soLuong)
        {
            string sql = "update HoaDonChiTiet set SoLuong = SoLuong+ " + soLuong + " where MaHD = '" + maHD + "' and MaSP = '" + maSP + "'";
            data.ExcuteNonQuery(sql);
        }
        //Khách hàng
        public DataTable getKhachHang()
        {
            string sql = "select * from KhachHang";
            return data.GetTable(sql);
        } //Nhom Khách hàng

        public DataTable getHTTT()
        {
            string sql = "select * from HTTT";
            return data.GetTable(sql);
        }

        public DataTable getNhomKhachHang()
        {
            string sql = "select * from NhomKH";
            return data.GetTable(sql);
        }
        //Nhân viên
        public DataTable getNhanVien()
        {
            string sql = "select * from NhanVien";
            return data.GetTable(sql);
        }
        //hash Khách hàng
        public string hashKH(string str, bool kt)
        {
            string st = "";
            try
            {
                DataTable dt = new DataTable();
                dt = getKhachHang();
                if (kt)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if (dt.Rows[i].ItemArray[0].ToString().Trim().Equals(str.Trim()))
                        {
                            st = dt.Rows[i].ItemArray[1].ToString().Trim();
                            break;
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if (dt.Rows[i].ItemArray[1].ToString().Trim().Equals(str.Trim()))
                        {
                            st = dt.Rows[i].ItemArray[0].ToString().Trim();
                            break;
                        }
                    }
                }

            }
            catch
            {

            }
            return st;

        }

    }
}
