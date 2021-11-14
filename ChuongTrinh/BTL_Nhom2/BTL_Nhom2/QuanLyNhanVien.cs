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
    public partial class QuanLyNhanVien : Form
    {
        public QuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            Load_NhanVien();
            Load_comboBoxMaCV();
            txtphantrang.Text = "Tổng số nhân viên là: " + dgv_QLNhanVien.RowCount;
        }

        void Load_NhanVien()
        {
            dbDataContext db = new dbDataContext();
            var nv1 = (from p in db.NhanViens
                       join t in db.ChucVus on p.MaCV equals t.MaCV
                       select new
                       {
                           p.MaNV,
                           p.HoTen,
                           p.DiaChi,
                           p.Sdt,
                           t.TenCV
                       }).ToList();
            dgv_QLNhanVien.DataSource = nv1;

        }
        void Load_comboBoxMaCV()
        {
            dbDataContext db = new dbDataContext();
            var cv = from t in db.ChucVus
                     select t;
            cmbMaCV.DataSource = cv;
            cmbMaCV.DisplayMember = "TenCV";
            cmbMaCV.ValueMember = "MaCV";
          

        }
        public string hasCV(string str, bool kt)
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
        private void btn_NhapLai_Click(object sender, EventArgs e)
        {
            txtMaNV.ResetText();
            txtHoTen.ResetText();
            txtDiaChi.ResetText();
            txtSdt.ResetText();
            txtMaNV.Focus();
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
            NhanVien them = new NhanVien();
            them.MaNV = txtMaNV.Text.Trim();
            them.HoTen = txtHoTen.Text;
            them.DiaChi = txtDiaChi.Text;
            them.Sdt = txtSdt.Text;
            them.MaCV = cmbMaCV.SelectedValue.ToString();
            try
            {

                if (them.MaNV.Equals(""))
                {
                    MessageBox.Show("Mã nhân viên không được để trống!", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (them.HoTen.Equals(""))
                {
                    MessageBox.Show("Tên nhân viên không được để trống!", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    DialogResult tl = MessageBox.Show("Bạn có chắc chắn muốn thêm không?", "Thông báo?", MessageBoxButtons.YesNo);
                    if (tl == DialogResult.Yes)
                    {
                        db.NhanViens.InsertOnSubmit(them);
                        db.SubmitChanges();
                        Load_NhanVien();
                        MessageBox.Show("Thêm thành công", "Thông báo");
                    }
                }
                
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Mã" + them.MaNV + " đã tồn tại", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            dbDataContext db = new dbDataContext();
            var capnhat = db.NhanViens.Single(nv => nv.MaNV == txtMaNV.Text);
            capnhat.HoTen = txtHoTen.Text;
            capnhat.DiaChi = txtDiaChi.Text;
            capnhat.Sdt = txtSdt.Text;
            capnhat.MaCV = cmbMaCV.SelectedValue.ToString();

            if (capnhat.HoTen.Equals(""))
            {
                MessageBox.Show("Tên nhân viên không được để trống!", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult tl = MessageBox.Show("Bạn có chắc chắn muốn sửa không?", "Thông báo?", MessageBoxButtons.YesNo);
            if (tl == DialogResult.Yes)
            {
                db.SubmitChanges();
                Load_NhanVien();
                MessageBox.Show("Sửa thành công", "Thông báo");
            }
               
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                dbDataContext db = new dbDataContext();
                var xoa = from tk in db.NhanViens

                          where tk.MaNV == dgv_QLNhanVien.SelectedRows[0].Cells[0].Value.ToString()
                          select tk;
                DialogResult tl = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo);
                if (tl == DialogResult.Yes)
                {
                    foreach (var i in xoa)
                    {
                        db.NhanViens.DeleteOnSubmit(i);
                        db.SubmitChanges();
                        Load_NhanVien();
                        MessageBox.Show("Xóa thành công", "Thông báo");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn hàng cần xóa!", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }



        private void btnPreview_Click(object sender, EventArgs e)
        {
            Program.exportExcel(@"D:\", "dsTK",dgv_QLNhanVien);
            MessageBox.Show("Xuất thành công vào D:\\dsNV.xlsx");

        }

        private void btnTimKiem_Click_1(object sender, EventArgs e)
        {
            dbDataContext db = new dbDataContext();
            if (RdMaNV.Checked)
            {
                // dgv_QLTaiKhoan.DataSource = db.TaiKhoans.Where(p => p.MaCV.Equals(comboBoxChucVu.SelectedValue.ToString()));
                dgv_QLNhanVien.DataSource = (from p in db.NhanViens
                                             join t in db.ChucVus on p.MaCV equals t.MaCV
                                             where p.MaNV.StartsWith(txtTimKiem.Text)
                                             select new
                                             {
                                                 p.MaNV,
                                                 p.HoTen,
                                                 p.DiaChi,
                                                 p.Sdt,
                                                 t.TenCV
                                             }).ToList();
                txtphantrang.Text = "Tổng số nhân viên là: " + dgv_QLNhanVien.RowCount;
            }
            else if(RdHoTen.Checked)
            {
                dgv_QLNhanVien.DataSource = (from p in db.NhanViens
                                             join t in db.ChucVus on p.MaCV equals t.MaCV
                                             where p.HoTen.Contains(txtTimKiem.Text)
                                             select new
                                             {
                                                 p.MaNV,
                                                 p.HoTen,
                                                 p.DiaChi,
                                                 p.Sdt,
                                                 t.TenCV
                                             }).ToList();
                txtphantrang.Text = "Tổng số nhân viên là: " + dgv_QLNhanVien.RowCount;
            }
        }

        private void dgv_QLNhanVien_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_QLNhanVien.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn Nhân viên cần xem!", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                txtMaNV.Text = dgv_QLNhanVien.SelectedRows[0].Cells["MaNV"].Value.ToString();
                txtHoTen.Text = dgv_QLNhanVien.SelectedRows[0].Cells["HoTen"].Value.ToString();
                txtDiaChi.Text = dgv_QLNhanVien.SelectedRows[0].Cells["DiaChi"].Value.ToString();
                txtSdt.Text = dgv_QLNhanVien.SelectedRows[0].Cells["Sdt"].Value.ToString();
                cmbMaCV.SelectedValue = dgv_QLNhanVien.SelectedRows[0].Cells[5].Value.ToString();
            }
            catch (Exception) { }


        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            QuanLyNhanVien_Load(sender, e);
            txtTimKiem.Clear();
        }

        private void dgv_QLNhanVien_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txtMaNV.Text = dgv_QLNhanVien.Rows[dong].Cells[0].Value.ToString().Trim();
            txtHoTen.Text = dgv_QLNhanVien.Rows[dong].Cells[1].Value.ToString().Trim();
            txtDiaChi.Text = dgv_QLNhanVien.Rows[dong].Cells[2].Value.ToString().Trim();
            txtSdt.Text = dgv_QLNhanVien.Rows[dong].Cells[3].Value.ToString().Trim();
            cmbMaCV.SelectedValue = hasCV(dgv_QLNhanVien.Rows[dong].Cells[4].Value.ToString().Trim(),false);
           }

       
    }
}
