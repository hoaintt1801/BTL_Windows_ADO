using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using BUS;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_Nhom2
{
    public partial class Dialog_ThemSP : Form
    {
     
            Bus_BanHang bus = new Bus_BanHang();
            string maHD;
            public Dialog_ThemSP()
            {
                InitializeComponent();
            }

            private void btnThoat_Click(object sender, EventArgs e)
            {
                this.Close();
            }

            public string getMaHD
            {
                get
                {
                    return maHD;
                }
                set
                {
                    maHD = value;
                }
            }

            private void btn_Them_Click(object sender, EventArgs e)
            {
                try
                {
                    DataTable dt = new DataTable();
                    dt = bus.getHoaDonChiTiet(maHD);

                    int sl = Int32.Parse(txtSoLuong.Text);
                    string maSP = cb_SP.SelectedValue.ToString();
                    bool check = false;
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if (dt.Rows[i].ItemArray[0].ToString().Equals(maSP))
                        {
                            check = true;
                            break;
                        }
                    }
                    if (!check)
                    {
                        bus.insertHoaDonChiTiet(maHD, maSP, sl);
                        MessageBox.Show("Thêm thành công");
                        this.Close();
                    }
                    else
                    {
                    bus.updateHoaDonChiTiet1(maHD, maSP, sl);
                    MessageBox.Show("Thêm thành công");
                    this.Close();
                }
                }
                catch
                {
                    MessageBox.Show("Vui lòng nhập đúng thông tin");
                }
            }

            private void Dialog_ThemSP_Load(object sender, EventArgs e)
            {
                DataTable dt = new DataTable();
                dt = bus.getSanPham();
                cb_SP.DataSource = dt;
                cb_SP.DisplayMember = "TenSP";
                cb_SP.ValueMember = "MaSP";
            }
        }
    }
