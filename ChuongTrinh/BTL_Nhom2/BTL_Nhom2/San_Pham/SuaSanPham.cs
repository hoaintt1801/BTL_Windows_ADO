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

namespace BTL_Nhom2.San_Pham
{
    public partial class SuaSanPham : Form
    {
        BUS_DSSP dssp = new BUS_DSSP();
        DataTable dt = null;
        string masp, tenSP, maVach, loaiSP, nhaHieu, giaBan, soLuong, nhaCungCap, moTa;
        public SuaSanPham()
        {
            InitializeComponent();
        }

        private void SuaSanPham_Load(object sender, EventArgs e)
        {
            loadcbLoaiSP();
            loadcbxNCC();
            loadcbxNhanHieu();
            txtmavach.Text = maVach;
            txtmasp.Text = masp;
            txtgiaban.Text = giaBan;
            txtsoluong.Text = soLuong;
            txttensp.Text = tenSP;
            if (loaiSP.Length > 0) 
                cbxloaisp.SelectedValue = loaiSP;
            if (nhaCungCap.Length > 0) 
                cbxncc.SelectedValue = nhaCungCap;
            if (nhaHieu.Length > 0) 
                cbxnhanhieu.SelectedValue = nhaHieu;
            rtmota.Text = moTa;
        }
        public void loadcbLoaiSP()
        {
            dt = new DataTable();
            dt = dssp.getLoaiSP();
            this.cbxloaisp.DataSource = dt;
            this.cbxloaisp.DisplayMember = "TenLSP";
            this.cbxloaisp.ValueMember = "MaLSP";
        }
        public void loadcbxNhanHieu()
        {
            dt = new DataTable();
            dt = dssp.getNhanHieu();
            this.cbxnhanhieu.DataSource = dt;
            this.cbxnhanhieu.DisplayMember = "TenNH";
            this.cbxnhanhieu.ValueMember = "MaNH";
        }
        public void loadcbxNCC()
        {
            dt = new DataTable();
            dt = dssp.getNhaCC();
            this.cbxncc.DataSource = dt;
            this.cbxncc.DisplayMember = "TenNCC";
            this.cbxncc.ValueMember = "MaNCC";
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (txtmasp.TextLength == 0)
                MessageBox.Show("Bạn chưa nhập mã sản phẩm");
            else if (txttensp.TextLength == 0)
                MessageBox.Show("Bạn chưa nhập tên sản phẩm");
            else if (txtmavach.TextLength == 0)
                MessageBox.Show("Bạn chưa nhập mã vạch");
            else if (txtsoluong.TextLength == 0)
                MessageBox.Show("Bạn chưa nhập số lượng");
            else if (txtgiaban.TextLength == 0)
                MessageBox.Show("Bạn chưa nhập đơn giá");
            else
            {
                DialogResult tl = MessageBox.Show("Bạn có chắc chắn sửa sản phẩm này không?", "Thông báo", MessageBoxButtons.YesNo);
                if (tl == DialogResult.Yes) { 
                    dssp.UpdateSanPham(txtmasp.Text,txttensp.Text, txtmavach.Text, cbxloaisp.SelectedValue.ToString(),
                    cbxnhanhieu.SelectedValue.ToString(), decimal.Parse(txtgiaban.Text), Int32.Parse(txtsoluong.Text),
                    cbxncc.SelectedValue.ToString(), rtmota.Text);

                     MessageBox.Show("Bạn đã sửa thành công sản phẩm!");
                    this.Close();
                }
                    
            }
        }
        public string getmasp
        {
            get
            {
                return masp;
            }
            set
            {
                masp = value;
            }
        }

        private void btnnhaplai_Click(object sender, EventArgs e)
        {
            txttensp.Clear(); txtmavach.Clear(); txtgiaban.Clear(); txtsoluong.Clear(); rtmota.Clear();
            txtmasp.Focus();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult tl = MessageBox.Show("Bạn có chắc chắn muốn thoát? ", "Thông báo", MessageBoxButtons.YesNo);
            if (tl == DialogResult.Yes)
                this.Close();
        }

        public string gettenSP
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
        public string getmaVach
        {
            get
            {
                return maVach;
            }
            set
            {
                maVach = value;
            }
        }
        public string getloaiSP
        {
            get
            {
                return loaiSP;
            }
            set
            {
                loaiSP = value;
            }
        }
        public string getnhaHieu
        {
            get
            {
                return nhaHieu;
            }
            set
            {
                nhaHieu = value;
            }
        }
        public string getgiaBan
        {
            get
            {
                return giaBan;
            }
            set
            {
                giaBan = value;
            }
        }
        public string getsoLuong
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
        public string getnhaCungCap
        {
            get
            {
                return nhaCungCap;
            }
            set
            {
                nhaCungCap = value;
            }
        }
        public string getmoTa
        {
            get
            {
                return moTa;
            }
            set
            {
                moTa = value;
            }
        }
    }
}
