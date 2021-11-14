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
    public partial class FormPhieuChi : Form
    {
        public FormPhieuChi()
        {
            InitializeComponent();
        }

        private void FormPhieuChi_Load(object sender, EventArgs e)
        {
            dgvPhieuChi.DataSource = loph.ShowPhieuChi();
            LoadCBNCC();

        }
        private void LoadCBNCC()
        {
            DataTable dt = new DataTable();
            dt = loph.ShowNCC();
            cbNCC.DataSource = dt;
            cbNCC.DisplayMember = "TenNCC";
            cbNCC.ValueMember = "MaNCC";
        }
        DTO_SoQuy L = new DTO_SoQuy();
        Bus_SoQuy loph = new Bus_SoQuy();


        private void BtnThem_Click(object sender, EventArgs e)
        {
            if (txtMaPhieuChi.TextLength == 0|| txtNguoiLap.TextLength == 0)
                MessageBox.Show("Không được bỏ trống");
            else
            {
                try
                {
                    L.MaPC1 = txtMaPhieuChi.Text;
                    L.MaNCC1 = cbNCC.SelectedValue.ToString().Trim();
                    L.NgayLap1 = txtNgayLap.Value.ToString();
                    L.NguoiLapPhieu1 = txtNguoiLap.Text;
                    L.SoTienChi1 = txtSoTienChi.Text;
                    L.DiaChi1 = txtDiaChi.Text;
                    L.SDT1 = txtSDT.Text;
                    L.Email1 = txtEmail.Text;
                    DialogResult tl = MessageBox.Show("Bạn có chắc chắn muốn thêm không?", "Thông báo?", MessageBoxButtons.YesNo);
                    if (tl == DialogResult.Yes)
                    {
                        loph.ThemPhieuChi(L.MaPC1, L.MaNCC1, L.NgayLap1, L.NguoiLapPhieu1, L.SoTienChi1, L.DiaChi1, L.SDT1, L.Email1);
                        MessageBox.Show("Thêm thành công");
                        FormPhieuChi_Load(sender, e);
                    }
                   
                }
                catch
                {
                    MessageBox.Show("Bạn vui lòng thực hiện lại");
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            if (txtMaPhieuChi.TextLength == 0 || txtNguoiLap.TextLength == 0)
                MessageBox.Show("Không được bỏ trống");
            else
            {
                try
                {
                    L.MaPC1 = txtMaPhieuChi.Text;
                    L.MaNCC1 = cbNCC.SelectedValue.ToString().Trim();
                    L.NgayLap1 = txtNgayLap.Value.ToString();
                    L.NguoiLapPhieu1 = txtNguoiLap.Text;
                    L.SoTienChi1 = txtSoTienChi.Text;
                    L.DiaChi1 = txtDiaChi.Text;
                    L.SDT1 = txtSDT.Text;
                    L.Email1 = txtEmail.Text;
                    DialogResult tl = MessageBox.Show("Bạn có chắc chắn muốn sửa không?", "Thông báo?", MessageBoxButtons.YesNo);
                    if (tl == DialogResult.Yes)
                    {
                        loph.SuaPhieuChi(L.MaPC1, L.MaNCC1, L.NgayLap1, L.NguoiLapPhieu1, L.SoTienChi1, L.DiaChi1, L.SDT1, L.Email1);
                        MessageBox.Show("Sửa thành công");
                        FormPhieuChi_Load(sender, e);
                    }
                        
                }
                catch
                {
                    MessageBox.Show("Vui lòng thực hiện lại");
                }
            }
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaPhieuChi.TextLength == 0)
                MessageBox.Show("Khong duoc bo trong");
            try
            {
                L.MaPC1 = txtMaPhieuChi.Text;
                DialogResult tl = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo?", MessageBoxButtons.YesNo);
                if (tl == DialogResult.Yes)
                {
                    loph.XoaPhieuChi(L.MaPC1);
                    MessageBox.Show("Xóa thành công");
                    FormPhieuChi_Load(sender, e);
                }
                   
            }
            catch
            {
                MessageBox.Show("Mời bạn thực hiện lại");
            }
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            dgvPhieuChi.DataSource = loph.ThongKeThu(dateTimePickerBD.Value.ToString(), dateTimePickerKT.Value.ToString());
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult hoi = MessageBox.Show("Bạn có muốn thoát không", "Thông báo!", MessageBoxButtons.YesNo);
            if(hoi == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            FormPhieuChi_Load(sender, e);
        }

        private void btn_NhapLai_Click(object sender, EventArgs e)
        {
            txtDiaChi.Clear();
            txtEmail.Clear(); 
            cbNCC.SelectedText = "";
            txtMaPhieuChi.Clear();
            txtNguoiLap.Clear();
            txtNguoiLap.Clear();
            txtSDT.Clear();
            txtSoTienChi.Clear();
            
        }

        private void dgvPhieuChi_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txtMaPhieuChi.Text = dgvPhieuChi.Rows[dong].Cells[0].Value.ToString();
            cbNCC.SelectedValue = dgvPhieuChi.Rows[dong].Cells[1].Value.ToString();
            txtNgayLap.Text = dgvPhieuChi.Rows[dong].Cells[2].Value.ToString();
            txtNguoiLap.Text = dgvPhieuChi.Rows[dong].Cells[3].Value.ToString();
            txtSoTienChi.Text = dgvPhieuChi.Rows[dong].Cells[4].Value.ToString();
            txtDiaChi.Text = dgvPhieuChi.Rows[dong].Cells[5].Value.ToString();
            txtSDT.Text = dgvPhieuChi.Rows[dong].Cells[6].Value.ToString();
            txtEmail.Text = dgvPhieuChi.Rows[dong].Cells[7].Value.ToString();
        }
    }
}
