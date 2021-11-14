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
    public partial class Dialog_EditSP : Form
    {
        Bus_BanHang bus = new Bus_BanHang();
        string maHD, maSP, tenSP, soLuong;

        public Dialog_EditSP()
        {
            InitializeComponent();
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                int sl = Int32.Parse(txtSoLuong.Text);
                bus.updateHoaDonChiTiet(maHD, maSP, sl);
                MessageBox.Show("Sửa thành công");
                this.Close();
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập đúng thông tin");
            }
        }


        private void Dialog_EditSP_Load(object sender, EventArgs e)
        {
            txtTenSP.Text = tenSP;
            txtSoLuong.Text = soLuong;

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                bus.delHoaDonChiTiet(maHD, maSP);
                MessageBox.Show("Xóa thành công");
                this.Close();
            }
            catch
            {
                MessageBox.Show("Vui lòng thực hiện lai!");
            }
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
        public string getMaSp
        {
            get
            {
                return maSP;
            }
            set
            {
                maSP = value;
            }
        }
        public string getTenSp
        {
            get
            {
                return tenSP;
            }
            set
            {
                tenSP = value;
            }
        }
        public string getSoLuong
        {
            get
            {
                return soLuong;
            }
            set
            {
                soLuong = value;
            }
        }
    }
}
