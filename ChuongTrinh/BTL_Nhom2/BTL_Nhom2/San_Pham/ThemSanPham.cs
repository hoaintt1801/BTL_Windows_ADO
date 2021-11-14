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
    public partial class ThemSanPham : Form
    {
        string MaSP;
        Bus_ID bus_ID = new Bus_ID();
        BUS_DSSP dssp = new BUS_DSSP();
        DataTable dt = null;
        public ThemSanPham()
        {
            InitializeComponent();
        }
        public string propetyMaSP
        {
            get
            {
                return MaSP;
            }
            set
            {
                MaSP = value;
            }
        }
        private void ThemSanPham_Load(object sender, EventArgs e)
        {
            string a = bus_ID.getTableID(2).Rows[0].ItemArray[0].ToString();
            string MaSP = "H";
            /*for (int i = 0; i < (3 - a.ToString().Length); i++)
            {
                MaSP += "0";
            }*/
            MaSP += a;
            txtMaSP.Text = MaSP;

            loadcbLoaiSP();
            loadcbxNCC();
            loadcbxNhanHieu();
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
            if (txttensp.TextLength == 0)
                MessageBox.Show("Bạn chưa nhập tên sản phẩm");
            else if (txtmavach.TextLength == 0)
                MessageBox.Show("Bạn chưa nhập mã vạch");
            else if (txtsoluong.TextLength == 0)
                MessageBox.Show("Bạn chưa nhập số lượng");
            else if (txtgiaban.TextLength == 0)
                MessageBox.Show("Bạn chưa nhập đơn giá");
            else
            {

                //bool kt = false;
                dt = new DataTable();
                dt = dssp.ShowDSSP();
                /*for(int i=0; i<dt.Rows.Count; i++)
                {
                    if (txtmasp.Text.Trim().Equals(dt.Rows[i].ItemArray[0].ToString().Trim()))
                    {
                        kt = true;
                        break;
                    }
                }
                if (kt)
                {
                    MessageBox.Show("Mã sp đã tồn tại");
                }
                else
                {
                 */   
                    DialogResult tl = MessageBox.Show("Bạn có chắc chắn thêm sản phẩm này không?", "Thông báo", MessageBoxButtons.YesNo);
                    
                if (tl == DialogResult.Yes)
                    {
                    

                    dssp.InsertSanPham(txtMaSP.Text, txttensp.Text, txtmavach.Text, cbxloaisp.SelectedValue.ToString(),
                    cbxnhanhieu.SelectedValue.ToString(), decimal.Parse(txtgiaban.Text), Int32.Parse(txtsoluong.Text), cbxncc.SelectedValue.ToString(),
                    rtmota.Text);
                        MessageBox.Show("Bạn đã thêm thành công sản phẩm!");
                        this.Close();
                    }
                       
                   
                        
                //}
            }
            
        }

        private void btnnhaplai_Click(object sender, EventArgs e)
        {
            txttensp.Clear(); txtmavach.Clear(); txtgiaban.Clear(); txtsoluong.Clear(); rtmota.Clear();
           
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult tl = MessageBox.Show("Bạn có chắc chắn muốn thoát? ", "Thông báo", MessageBoxButtons.YesNo);
            if (tl == DialogResult.Yes)
                this.Close();
           
        }
    }
}
