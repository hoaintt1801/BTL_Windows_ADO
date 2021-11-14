using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using System.Data.SqlClient;

namespace BUS
{
    public class BUS_DSSP
    {
        Bus_ID Bus_ID = new Bus_ID();
        Data da = new Data();
        public DataTable ShowDSSP()
        {
            string sql = "select MaSP, TenSP, MaLSP, MaNH, SoLuong, Giaban, MaNCC from SanPham";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
         }
        public DataTable getSanPham()
        {
            string sql = "select * from SanPham";
            return da.GetTable(sql);
        }
        public DataTable getSanPham(string timKiem, string loaisp, string nhanHieu, string nhaCungCap)
        {
            string sql;
            timKiem += "%";
            if (loaisp.Length > 0)
            {
                if (nhanHieu.Length > 0)
                {
                    if (nhaCungCap.Length >0)
                    {
                        sql = "select MaSP, TenSP, MaLSP, MaNH, SoLuong, Giaban, MaNCC from SanPham where (MaSP like '" + timKiem + "' or TenSP like '" + timKiem + "') and MaLSP = '" + loaisp + "' and MaNH = '" + nhanHieu + "' and MaNCC = '" + nhaCungCap + "'";
                    }
                    else
                    {
                        sql = "select MaSP, TenSP, MaLSP, MaNH, SoLuong, Giaban, MaNCC from SanPham where (MaSP like '" + timKiem + "' or TenSP like '" + timKiem + "') and MaLSP = '" + loaisp + "' and MaNH = '" + nhanHieu + "'";
                    }
                }
                else
                {
                    if (nhaCungCap.Length > 0)
                    {
                        sql = "select MaSP, TenSP, MaLSP, MaNH, SoLuong, Giaban, MaNCC from SanPham where (MaSP like '" + timKiem + "' or TenSP like '" + timKiem + "') and MaLSP = '" + loaisp + "' and MaNCC = '" + nhaCungCap + "'";
                    }
                    else
                    {
                        sql = "select MaSP, TenSP, MaLSP, MaNH, SoLuong, Giaban, MaNCC from SanPham where (MaSP like '" + timKiem + "' or TenSP like '" + timKiem + "') and MaLSP = '" + loaisp + "' ";
                    }
                }
            }
            else
            {
                if (nhanHieu.Length > 0)
                {
                    if (nhaCungCap.Length > 0)
                    {
                        sql = "select MaSP, TenSP, MaLSP, MaNH, SoLuong, Giaban, MaNCC from SanPham where (MaSP like '" + timKiem + "' or TenSP like '" + timKiem + "') and MaNH = '" + nhanHieu + "' and MaNCC = '" + nhaCungCap + "'";
                    }
                    else
                    {
                        sql = "select MaSP, TenSP, MaLSP, MaNH, SoLuong, Giaban, MaNCC from SanPham where (MaSP like '" + timKiem + "' or TenSP like '" + timKiem + "') and MaNH = '" + nhanHieu + "'";
                    }
                }
                else
                {
                    if (nhaCungCap.Length > 0)
                    {
                        sql = "select MaSP, TenSP, MaLSP, MaNH, SoLuong, Giaban, MaNCC from SanPham where (MaSP like '" + timKiem + "' or TenSP like '" + timKiem + "') and MaNCC = '" + nhaCungCap + "'";
                    }
                    else
                    {
                        sql = "select MaSP, TenSP, MaLSP, MaNH, SoLuong, Giaban, MaNCC from SanPham where (MaSP like '" + timKiem + "' or TenSP like '" + timKiem + "')";
                    }
                }
            }

            
            return da.GetTable(sql);
        }
        public DataTable getLoaiSP()
        {
            string sql = "select * from LoaiSP";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
        public DataTable getNhanHieu()
        {
            string sql = "select * from NhanHieu";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
        public DataTable getNhaCC()
        {
            string sql = "select * from NhaCungCap";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
        public void InsertSanPham(string masp, string tensp, string mavach, string loaisp, string nhanhieu, decimal giaban, int soluong, string ncc, string mota)
        {
            string sql = "insert SanPham values('" + masp + "',N'" + tensp + "','" + giaban + "','" + soluong + "',N'" + nhanhieu +
                "', N'" + loaisp + "',N'" + ncc + "',N'" + mavach + "',N'" + mota + "' )";
            da.ExcuteNonQuery(sql);
            Bus_ID.updateID(2);

        }
        public void UpdateSanPham(string masp, string tensp, string mavach, string loaisp, string nhanhieu, decimal giaban, int soluong, string ncc, string mota)
        {
            loaisp = loaisp.Trim();
            nhanhieu = nhanhieu.Trim();
            ncc = ncc.Trim();
            string sql = "update SanPham set TenSP = N'" + tensp + "', MaLSP = '" + loaisp +
                "', MaNH = '" + nhanhieu + "', GiaBan = '" + giaban + "', SoLuong = '" + soluong + "', MaNCC = '" + ncc + "', MoTa = N'" + mota +
                "', MaVach = N'" + mavach + "'  where MaSP = '" + masp+"' ";
            da.ExcuteNonQuery(sql);
        }
        public void DeleteSanPham(string masp)
        {
            string sql = "delete SanPham where MaSP = '" + masp + "'";
            da.ExcuteNonQuery(sql);
        }
        //hash Nhãn hiệu
        public string hashNhanHieu(string str, bool kt)
        {
            string st = "";
            if (kt)
            {
                DataTable dt = new DataTable();
                dt = getNhanHieu();
                for(int i=0; i<dt.Rows.Count; i++)
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
                DataTable dt = new DataTable();
                dt = getNhanHieu();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i].ItemArray[1].ToString().Trim().Equals(str.Trim()))
                    {
                        st = dt.Rows[i].ItemArray[0].ToString().Trim();
                        break;
                    }
                }
            }
            if (st.Length == 0)
            {
                return null;
            }
            return st;
        }
        public string hashLoai(string str, bool kt)
        {
            string st = "";
            if (kt)
            {
                DataTable dt = new DataTable();
                dt = getLoaiSP();
                for(int i=0; i<dt.Rows.Count; i++)
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
                DataTable dt = new DataTable();
                dt = getLoaiSP();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i].ItemArray[1].ToString().Trim().Equals(str.Trim()))
                    {
                        st = dt.Rows[i].ItemArray[0].ToString().Trim();
                        break;
                    }
                }
            }
            if (st.Length == 0)
            {
                return null;
            }
            return st;
        }
        public string hashNhaCC(string str, bool kt)
        {
            string st = "";
            if (kt)
            {
                DataTable dt = new DataTable();
                dt = getNhaCC();
                for(int i=0; i<dt.Rows.Count; i++)
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
                DataTable dt = new DataTable();
                dt = getNhaCC();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i].ItemArray[1].ToString().Trim().Equals(str.Trim()))
                    {
                        st = dt.Rows[i].ItemArray[0].ToString().Trim();
                        break;
                    }
                }
            }
            if (st.Length == 0)
            {
                return null;
            }
            return st;
        }
    }
}
