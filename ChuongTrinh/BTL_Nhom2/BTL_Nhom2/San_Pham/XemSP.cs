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
    public partial class XemSP : Form
    {
        BUS_DSSP dssp = new BUS_DSSP();
        DataTable dt = null;
        string masp, tenSP, maVach, loaiSP, nhaHieu, giaBan, soLuong, nhaCungCap, moTa;
        public XemSP()
        {
            InitializeComponent();
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

        private void XemSP_Load(object sender, EventArgs e)
        {
            loadcbLoaiSP();
            loadcbxNCC();
            loadcbxNhanHieu();
            txtmavach.Text = maVach;
            txtmasp.Text = masp;
            txtgiaban.Text = giaBan;
            txtsoluong.Text = soLuong;
            txttensp.Text = tenSP;
            if (loaiSP != null)
                cbxloaisp.SelectedValue = loaiSP;
            if (nhaCungCap != null)
                cbxncc.SelectedValue = nhaCungCap;
            if (nhaHieu != null)
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
        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult tl = MessageBox.Show("Bạn có chắn chắn muốn thoát không? ", "Thông báo", MessageBoxButtons.YesNo);
            if (tl == DialogResult.Yes)
                this.Close();
        }
    }
}
