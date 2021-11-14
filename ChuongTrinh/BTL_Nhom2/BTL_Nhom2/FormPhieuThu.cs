using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using DTO;
using BUS;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_Nhom2
{
    public partial class FormPhieuThu : Form
    {
        public FormPhieuThu()
        {
            InitializeComponent();
        }

        private void FormPhieuThu_Load(object sender, EventArgs e)
        {
            dgvPhieuThu.DataSource = loph.ShowPhieuThu();
            txtphantrang.Text = "Tổng số phiếu là: " + dgvPhieuThu.RowCount;
            DataTable dt = new DataTable();
            dt = loph.ShowKhachHang();
            cbKhachHang.DataSource = dt;
            cbKhachHang.DisplayMember = "HoTen";
            cbKhachHang.ValueMember = "MaKH";
        }
        DTO_SoQuy L = new DTO_SoQuy();
        Bus_SoQuy loph = new Bus_SoQuy();
        private void Form1_Load(object sender, EventArgs e)
        {
            dgvPhieuThu.DataSource = loph.ShowPhieuThu();
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            if (txtMaPT.TextLength == 0 || txtNguoiLap.TextLength == 0)
                MessageBox.Show("Không được bỏ trống");
            else
            {
                try
                {
                    L.MaPT1 = txtMaPT.Text;
                    L.MaKH1 = cbKhachHang.SelectedValue.ToString().Trim();
                    L.NgayLap1 = txtNgayLap.Value.ToString();
                    L.NguoiLapPhieu1 = txtNguoiLap.Text;
                    L.SoTienThu1 = txtSoTienThu.Text;
                    L.DiaChi1 = txtDiaChi.Text;
                    L.SDT1 = txtSDT.Text;
                    DialogResult tl = MessageBox.Show("Bạn có chắc chắn muốn thêm không?", "Thông báo?", MessageBoxButtons.YesNo);
                    if (tl == DialogResult.Yes)
                    {

                        loph.ThemPhieuThu(L.MaPT1, L.MaKH1, L.NgayLap1, L.NguoiLapPhieu1, L.SoTienThu1, L.DiaChi1, L.SDT1);
                        MessageBox.Show("Thêm thành công");
                        FormPhieuThu_Load(sender, e);
                    }
                }
                catch
                {
                    MessageBox.Show("Bạn vui lòng thực hiện lại");
                }
            }
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            if (txtMaPT.TextLength == 0 ||  txtNguoiLap.TextLength == 0)
                MessageBox.Show("Không được bỏ trống");
            try
            {
                L.MaPT1 = txtMaPT.Text;
                L.MaKH1 = cbKhachHang.SelectedValue.ToString().Trim();
                L.NgayLap1 = txtNgayLap.Value.ToString();
                L.NguoiLapPhieu1 = txtNguoiLap.Text;
                L.SoTienThu1 = txtSoTienThu.Text;
                L.DiaChi1 = txtDiaChi.Text;
                L.SDT1 = txtSoTienThu.Text;
                DialogResult tl = MessageBox.Show("Bạn có chắc chắn muốn sửa không?", "Thông báo?", MessageBoxButtons.YesNo);
                if (tl == DialogResult.Yes)
                {

                    loph.SuaPhieuThu(L.MaPT1, L.MaKH1, L.NgayLap1, L.NguoiLapPhieu1, L.SoTienThu1, L.DiaChi1, L.SDT1);
                    MessageBox.Show("Sửa thành công");
                    FormPhieuThu_Load(sender, e);
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng thực hiệ lại");
            }
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaPT.TextLength == 0)
                MessageBox.Show("Khong duoc bo trong");
            try
            {
                L.MaPT1 = txtMaPT.Text;
                DialogResult tl = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo?", MessageBoxButtons.YesNo);
                if (tl == DialogResult.Yes)
                {
                    loph.XoaPhieuThu(L.MaPT1);
                    MessageBox.Show("Xóa thành công");
                    FormPhieuThu_Load(sender, e);
                }
                    
            }
            catch
            {
                MessageBox.Show("Vui lòng thực hiện lại");
            }
        }
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            dgvPhieuThu.DataSource = loph.ThongKeThu(dateTimePicker1.Value.ToString(), dateTimePicker2.Value.ToString());
            txtphantrang.Text = "Tổng số phiếu là: " + dgvPhieuThu.RowCount;
        }

        private void btn_NhapLai_Click(object sender, EventArgs e)
        {
            txtDiaChi.Clear();
            txtMaPT.Clear();
            txtNguoiLap.Clear();
            txtSDT.Clear();
            txtSoTienThu.Clear();
            
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult hoi = MessageBox.Show("Bạn có muốn thoát không", "Thông báo!", MessageBoxButtons.YesNo);
            if (hoi == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void reload_Click(object sender, EventArgs e)
        {
            FormPhieuThu_Load(sender, e);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dgvPhieuThu_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txtMaPT.Text = dgvPhieuThu.Rows[dong].Cells[0].Value.ToString().Trim();
            cbKhachHang.SelectedValue = dgvPhieuThu.Rows[dong].Cells[1].Value.ToString().Trim();
            txtNgayLap.Text = dgvPhieuThu.Rows[dong].Cells[2].Value.ToString().Trim();
            txtNguoiLap.Text = dgvPhieuThu.Rows[dong].Cells[3].Value.ToString().Trim();
            txtSoTienThu.Text = dgvPhieuThu.Rows[dong].Cells[4].Value.ToString().Trim();
            txtDiaChi.Text = dgvPhieuThu.Rows[dong].Cells[5].Value.ToString().Trim();
            txtSDT.Text = dgvPhieuThu.Rows[dong].Cells[6].Value.ToString().Trim();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void cbKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
