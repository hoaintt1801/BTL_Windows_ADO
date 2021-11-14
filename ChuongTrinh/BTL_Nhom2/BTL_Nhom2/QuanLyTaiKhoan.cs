using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_Nhom2
{
    public partial class QuanLyTaiKhoan : Form
    {
        public QuanLyTaiKhoan()
        {
            InitializeComponent();
        }

        private void QuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            Load_TaiKhoan();
            Load_comboBoxChucVu();
            txtphantrang.Text = "Tổng số tài khoản là: " + dgv_QLTaiKhoan.RowCount;
        }

        public string hasTK(string str, bool kt)
        {
            string tr = "";
            if (kt)
            {
                dbDataContext db = new dbDataContext();
                var nxb = from n in db.ChucVus where n.MaCV.Trim().Equals(str.Trim()) select n.TenCV;
                tr = nxb.FirstOrDefault().ToString();
            }
            else
            {
                dbDataContext db = new dbDataContext();
                var nxb = from n in db.ChucVus where n.TenCV.Trim().Equals(str.Trim()) select n.MaCV;
                tr = nxb.FirstOrDefault().ToString();
            }
            return tr;
        }
        void Load_TaiKhoan()
        {
            dbDataContext db = new dbDataContext();
            var tk1 = from p in db.TaiKhoans
                      join t in db.ChucVus
                      on p.MaCV equals t.MaCV
                      select new
                      {
                          p.MaTaiKhoan,
                          p.MatKhau,
                          p.MaCV,
                          t.TenCV
                      };

            dgv_QLTaiKhoan.DataSource = tk1;

        }
        void Load_comboBoxChucVu()
        {
            dbDataContext db = new dbDataContext();
            var cv = from t in db.ChucVus
                     select t;
            cmbChucVu.DataSource = cv;
            cmbChucVu.DisplayMember = "TenCV";
            cmbChucVu.ValueMember = "MaCV";
            

        }

        private void btn_NhapLai_Click(object sender, EventArgs e)
        {
            txtMaTK.ResetText();
            txtMK.ResetText();
            txtMaTK.Focus();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult tl = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo);
            if (tl == DialogResult.Yes)
                this.Close();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            dbDataContext db = new dbDataContext();

            TaiKhoan them = new TaiKhoan();
            them.MaTaiKhoan = txtMaTK.Text.Trim();
            them.MatKhau = txtMK.Text;
            them.MaCV = cmbChucVu.SelectedValue.ToString();


            try
            {

                if (them.MaTaiKhoan.Equals(""))
                {
                    MessageBox.Show("Mã Tài khoản không được để trống!", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (them.MatKhau.Equals(""))
                {
                    MessageBox.Show("Mật khẩu không được để trống!", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //if(them.MaCV.Equals(" "))
                //{
                //    MessageBox.Show("Vui lòng chọn Chức vụ!", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    return;
                //}
                else if (them.MaCV.Equals(null))
                {
                    MessageBox.Show("Vui lòng chọn Chức vụ!", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DialogResult tl = MessageBox.Show("Bạn có chắc chắn muốn thêm không?", "Thông báo?", MessageBoxButtons.YesNo);
                if (tl == DialogResult.Yes)
                {

                    db.TaiKhoans.InsertOnSubmit(them);
                    db.SubmitChanges();
                    Load_TaiKhoan();
                    MessageBox.Show("Thêm thành công", "Thông báo");
                }
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Mã" + them.MaTaiKhoan + " đã tồn tại", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btn_Sua_Click(object sender, EventArgs e)
           
        {
            try
            {
                DialogResult tl = MessageBox.Show("Bạn có chắc chắn muốn thêm không?", "Thông báo?", MessageBoxButtons.YesNo);
                if (tl == DialogResult.Yes)
                {
                    dbDataContext db = new dbDataContext();
                    var capnhat = db.TaiKhoans.Single(tk => tk.MaTaiKhoan == txtMaTK.Text);
                    capnhat.MatKhau = txtMK.Text;
                    capnhat.MaCV = cmbChucVu.SelectedValue.ToString();
                    db.SubmitChanges();
                    Load_TaiKhoan();
                }
                    
            }
            catch
            {
                MessageBox.Show("Vui lòng thực hiện lại");
            }
           

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try{
                dbDataContext db = new dbDataContext();
                var xoa = from tk in db.TaiKhoans

                          where tk.MaTaiKhoan.Trim() == dgv_QLTaiKhoan.SelectedRows[0].Cells[0].Value.ToString().Trim()
                          select tk;
                DialogResult tl = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo);
                if (tl == DialogResult.Yes)
                {
                    foreach (var i in xoa)
                    {
                        db.TaiKhoans.DeleteOnSubmit(i);
                        db.SubmitChanges();
                        Load_TaiKhoan();
                        MessageBox.Show("Xóa thành công", "Thông báo");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn hàng cần xóa!", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTimKiem_Click_1(object sender, EventArgs e)
        {
            dbDataContext db = new dbDataContext();
            if (rdMaCV.Checked)
            {
                rdMaTK.Checked = false;
                dgv_QLTaiKhoan.DataSource = (from p in db.TaiKhoans
                                             join t in db.ChucVus on p.MaCV equals t.MaCV
                                             where p.MaCV.StartsWith(txtTimKiem.Text)
                                             select new
                                             {
                                                 p.MaTaiKhoan,
                                                 p.MatKhau,
                                                 p.MaCV,
                                                 t.TenCV
                                             }).ToList(); txtphantrang.Text = "Tổng số tài khoản là: " + dgv_QLTaiKhoan.RowCount;
            }
            else if(rdMaTK.Checked)
            {
                rdMaCV.Checked = false;
                dgv_QLTaiKhoan.DataSource = (from p in db.TaiKhoans
                                             join t in db.ChucVus on p.MaCV equals t.MaCV
                                             where p.MaTaiKhoan.StartsWith(txtTimKiem.Text)
                                             select new
                                             {
                                                 p.MaTaiKhoan,
                                                 p.MatKhau,
                                                 p.MaCV,
                                                 t.TenCV
                                             }).ToList(); txtphantrang.Text = "Tổng số tài khoản là: " + dgv_QLTaiKhoan.RowCount;
            }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            Program.exportExcel(@"D:\", "dsTK", dgv_QLTaiKhoan);
            MessageBox.Show("Xuất thành công vào D:\\dsTK.xlsx");
        }

        private void dgv_QLTaiKhoan_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_QLTaiKhoan.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xem!", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            txtMaTK.Text = dgv_QLTaiKhoan.SelectedRows[0].Cells[0].Value.ToString();
            txtMK.Text = dgv_QLTaiKhoan.SelectedRows[0].Cells[1].Value.ToString();
            cmbChucVu.SelectedValue = dgv_QLTaiKhoan.SelectedRows[0].Cells[3].Value.ToString();




            //DataContextDB db = new DataContextDB();
        }
        private void dgv_QLTaiKhoan_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txtMaTK.Text = dgv_QLTaiKhoan.Rows[dong].Cells[0].Value.ToString();
            txtMK.Text = dgv_QLTaiKhoan.Rows[dong].Cells[1].Value.ToString();
            cmbChucVu.SelectedValue = hasTK(dgv_QLTaiKhoan.Rows[dong].Cells[3].Value.ToString().Trim(), false);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            QuanLyTaiKhoan_Load(sender, e);
            txtTimKiem.Clear();
        }

        
    }
}
