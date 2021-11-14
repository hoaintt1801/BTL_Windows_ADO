using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BUS;
using System.Windows.Forms;

namespace BTL_Nhom2.QuanLy
{
    public partial class ThemKhachHang : Form
    {
        DataTable dt = null;
        Bus_BanHang bus = new Bus_BanHang();
        public ThemKhachHang()
        {
            InitializeComponent();
        }

        public void load_cbNKH()
        {
            dt = new DataTable();
            dt = bus.getNhomKhachHang();
            cbxnhomkh.DataSource = dt;
            cbxnhomkh.DisplayMember = "TenNKH";
            cbxnhomkh.ValueMember = "MaNKH";
        }
        private void ThemKhachHang_Load(object sender, EventArgs e)
        {
            load_cbNKH();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnnhaplai_Click(object sender, EventArgs e)
        {
            txtmakh.Clear();
            txttenkh.Clear();
            txtsodt.Clear();
            txtdiachi.Clear();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtmakh.TextLength == 0 || txttenkh.TextLength == 0)
                {
                    MessageBox.Show("Vui lòng nhâp đầy đủ thông tin");
                }
                else
                {
                    dt = new DataTable();
                    dt = bus.getKhachHang();
                    bool c = false;
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if (txtmakh.Text.Trim().Equals(dt.Rows[i].ItemArray[0].ToString().Trim()))
                        {
                            c = true;
                            break;
                        }
                    }
                    if (c)
                    {
                        MessageBox.Show("MaKH đã tồn tại");
                    }
                    else
                    {
                        DialogResult tl = MessageBox.Show("Bạn có chắc chắn thêm khách hàng này không? ", "Thông báo", MessageBoxButtons.YesNo);
                        if(tl == DialogResult.Yes)
                        {
                            bus.insertKhachHang(txtmakh.Text, txttenkh.Text, txtdiachi.Text, txtsodt.Text, cbxnhomkh.SelectedValue.ToString());
                            MessageBox.Show("Thêm thành công!");
                            this.Close();
                        }
                       
                    }
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng thực hiện lại");
            }
        }
    }
}
