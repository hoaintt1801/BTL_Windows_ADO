using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BTL_Nhom2
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        public void load_Combo()
        {
            dbDataContext db = new dbDataContext();
            var nv = from p in db.ChucVus
                     select p;
            cboChucVu.DataSource = nv;
            cboChucVu.DisplayMember = "TenCV";
            cboChucVu.ValueMember = "MaCV";

        }
        

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes) Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strConnectionString = @"Data Source=DESKTOP-R1KETTP;Initial Catalog=QuanLyBanHang;Integrated Security=True";
           
            SqlConnection conn = new SqlConnection(strConnectionString);
            string sqlSelect = "Select *from TaiKhoan where MaTaiKhoan ='" + txtMaTK.Text + "' and MatKhau ='" + txtMatKhau.Text + "' and MaCV='" + cboChucVu.SelectedValue.ToString() + "'";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (txtMaTK.Text == "") MessageBox.Show("Nhập mã tài khoản");
            else if (txtMatKhau.Text == "") MessageBox.Show("Nhập mật khẩu");

            else if (reader.Read() == true)
            {
                if (cboChucVu.Text.ToString().Trim().Equals("Admin"))
                {
                    
                    Form main = new MenuQuanLy();
                    this.Hide();
                    main.ShowDialog();
                    this.Show();
                    //main.Show();

                }
                else if (cboChucVu.Text.ToString().Trim().Equals("Quản lý"))
                {
           
                    Form main = new MenuQuanLy();
                    this.Hide();
                    main.ShowDialog();
                    this.Show();
                    //main.Show();

                }
                else if (cboChucVu.Text.ToString().Trim().Equals("Nhân viên"))
                {
              
                    Form main = new Menu.MenuNhanVien();
                    this.Hide();
                    main.ShowDialog();
                    this.Show();
                    //main.Show();
                }
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại");
                txtMaTK.ResetText();
                txtMatKhau.ResetText();
                cboChucVu.ResetText();
                txtMaTK.Focus();
            }
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            load_Combo();
            txtMaTK.ForeColor = Color.LightGray;
            txtMaTK.Text = "Nhập tên tài khoản";
            this.txtMaTK.Leave += new System.EventHandler(this.txtMaTK_Leave);
            this.txtMaTK.Enter += new System.EventHandler(this.txtMatKhau_Enter);

            txtMatKhau.ForeColor = Color.LightGray;
            txtMatKhau.Text = "Nhập mật khẩu";
            this.txtMatKhau.Leave += new System.EventHandler(this.txtMatKhau_Leave);
            this.txtMatKhau.Enter += new System.EventHandler(this.txtMatKhau_Enter);
        }

        private void DangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

      

        private void iconButton1_MouseHover(object sender, EventArgs e)
        {
            //txtMatKhau.UseSystemPasswordChar = false;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            //txtMatKhau.UseSystemPasswordChar = true;
            if(txtMatKhau.UseSystemPasswordChar == true)
            {
                txtMatKhau.UseSystemPasswordChar = false;
                iconButton1.IconChar = FontAwesome.Sharp.IconChar.Eye;

            }
            else
            {
                txtMatKhau.UseSystemPasswordChar = true;
                iconButton1.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            }
        }

        private void txtMaTK_Enter(object sender, EventArgs e)
        {
            if (txtMaTK.Text == "Nhập tên tài khoản")
            {
                txtMaTK.Text = "";
                txtMaTK.ForeColor = Color.Black;
            }
        }

        private void txtMaTK_Leave(object sender, EventArgs e)
        {
            if (txtMaTK.Text == "")
            {
                txtMaTK.Text = "Nhập tên tài khoản";
                txtMaTK.ForeColor = Color.Gray;
            }
        }

        private void txtMatKhau_Enter(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == "Nhập mật khẩu")
            {
                txtMatKhau.Text = "";
                txtMatKhau.ForeColor = Color.Black;
            }
        }

        private void txtMatKhau_Leave(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == "")
            {
                txtMatKhau.Text = "Nhập mật khẩu";
                txtMatKhau.ForeColor = Color.Gray;
            }
        }
    }
}
