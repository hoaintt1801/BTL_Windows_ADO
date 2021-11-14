using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using System.Data;
using System.Threading.Tasks;

namespace BUS
{
    public class Bus_ID
    {
        Data data = new Data();
        /*
         * 1 id_hoaDon
         * 2 id_sanPham
         * 3 id_khachHang
         * 
         * 
         * 
         * 
         */
        public DataTable  getTableID(int id_num)
        {
            string sql = "";
            switch (id_num)
            {
                case 1:
                    sql = "select id_hoaDon from ID";
                    break;
                case 2:
                    sql = "select id_sanPham from ID";
                    break;
                case 3:
                    sql = "select id_khachHang from ID";
                    break;
                case 4:
                    sql = "select id_NhomHang from ID";
                    break;
                case 5:
                    sql = "select id_ViTri from ID";
                    break;
                case 6:
                    sql = "select id_NguyenLieu from ID";
                    break;
                default:
                    break;
            }
            return data.GetTable(sql);

        }
        public void updateID(int id_num)
        {
            string sql = "";
            switch (id_num)
            {
                case 1:
                    sql = "update ID set id_hoaDon = (id_hoaDon + 1) where MaID = 'ID01'";
                    break;
                case 2:
                    sql = "update ID set id_sanPham = (id_sanPham + 1) where MaID = 'ID01'";
                    break;
                case 3:
                    sql = "update ID set id_khachHang = (id_khachHang + 1) where MaID = 'ID01'";
                    break;
                case 4:
                    sql = "update ID set id_NhomHang = (id_NhomHang + 1) where MaID = 'ID01'";
                    break;
                case 5:
                    sql = "update ID set id_ViTri = (id_ViTri + 1) where MaID = 'ID01'";
                    break;
                case 6:
                    sql = "update ID set id_NguyenLieu = (id_NguyenLieu + 1) where MaID = 'ID01'";
                    break;
                default:
                    break;
            }

            data.ExcuteNonQuery(sql);
        }
    }
}
