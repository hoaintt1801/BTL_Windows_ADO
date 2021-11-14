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
    public partial class CTHD : Form
    {
        Bus_ID Bus_ID = new Bus_ID();
        string MaHD;
        private String DetailMaHD = null;
        private Dictionary<String, int> SanPhamIndex = new Dictionary<string, int>();
        public CTHD()
        {
            InitializeComponent();
        }

        private void CTHD_Load(object sender, EventArgs e)
        {
            string a = Bus_ID.getTableID(1).Rows[0].ItemArray[0].ToString();
            string MaHD = "HD";
            for (int i = 0; i < (3 - a.ToString().Length); i++)
            {
                MaHD += "0";
            }
            MaHD += a.ToString();
            txtMaHD.Text = MaHD;
            Load_ComboboxHTTT();
            Load_ComboBoxTenNV();
            Load_ComboBoxTenKH();
            Load_ComboBoxTenSP();
            if (DetailMaHD != null)
            {
                Load_DataGridview();
                groupBox_TTChung.Enabled = false;
                groupBox_TTMatHang.Enabled = false;
                btnNhapLai.Visible = false;
                btnThem.Visible = false;
                btnXoa.Visible = false;
                Load_ThongTinHD();
            }




        }
        public CTHD(String MaHD)
        {
            InitializeComponent();
            this.DetailMaHD = MaHD;
        }

        private void Load_DataGridview()
        {
            dbDataContext db = new dbDataContext();
            var cthd = (from p in db.HoaDonChiTiets
                        join q in db.SanPhams on p.MaSP equals q.MaSP
                        //join t in db.HoaDonChiTiets on p.MaHD equals t.MaHD
                        //join q in db.KhachHangs on p.MaKH equals q.MaKH
                        //join m in db.HTTTs on t.MaHTTT equals m.MaHTTT
                        where p.MaHD == DetailMaHD
                        select new
                        {
                            p.MaSP,
                            q.TenSP,
                            p.SoLuong,
                            q.Giaban,
                            ThanhTien = p.SoLuong * q.Giaban
                        }).ToList();
            dgv_ChiTietHD.DataSource = cthd;

        }

        private bool IsDetailForm()
        {
            return this.DetailMaHD != null;
        }


       
        void Load_ThongTinHD()
        {

            dbDataContext db = new dbDataContext();
            txtMaHD.Text = DetailMaHD;
            var KH = (from KhachHang in db.KhachHangs
                      join HoaDon in db.HoaDons on KhachHang.MaKH equals HoaDon.MaKH
                      join NhanVien in db.NhanViens on HoaDon.MaNV equals NhanVien.MaNV
                      join HTTT in db.HTTTs on HoaDon.MaHTTT equals HTTT.MaHTTT


                      where HoaDon.MaHD == DetailMaHD

                      select new
                      {
                          KhachHang.MaKH,
                          NhanVien.MaNV,
                          KhachHang.DiaChi,
                          KhachHang.Sdt,
                          HoaDon.NgayLap,
                          HTTT.MaHTTT,
                      }).ToList();
            if (KH.Count > 0)
            {
                txtDiaChi.Text = KH.ElementAt(0).DiaChi;
                txtSdt.Text = KH.ElementAt(0).Sdt;
                dtpNgayLap.Value = KH.ElementAt(0).NgayLap;
                cmbHTTT.SelectedValue = KH.ElementAt(0).MaHTTT;
                cmbTenNV.SelectedValue = KH.ElementAt(0).MaNV;
                cmbTenKH.SelectedValue = KH.ElementAt(0).MaKH;
            }
            else
            {
                MessageBox.Show("Không có Khách hàng nào!", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            }
            // btnThemSP.Hide();

        }




        void Load_ComboboxHTTT()
        {
            dbDataContext db = new dbDataContext();
            var a = from t in db.HTTTs
                    select t;
            cmbHTTT.DataSource = a;
            cmbHTTT.DisplayMember = "TenHTTT";
            cmbHTTT.ValueMember = "MaHTTT";
            cmbHTTT.SelectedIndex = -1;
        }
        void Load_ComboBoxTenNV()
        {
            dbDataContext db = new dbDataContext();
            var a = from t in db.NhanViens
                    select t;
            cmbTenNV.DataSource = a;
            cmbTenNV.DisplayMember = "HoTen";
            cmbTenNV.ValueMember = "MaNV";
            cmbTenNV.SelectedIndex = -1;
        }
        void Load_ComboBoxTenKH()
        {
            dbDataContext db = new dbDataContext();
            var a = from t in db.KhachHangs
                    select t;
            cmbTenKH.DataSource = a;
            cmbTenKH.DisplayMember = "HoTen";
            cmbTenKH.ValueMember = "MaKH";
            cmbTenKH.SelectedIndex = -1;

        }
        void Load_ComboBoxTenSP()
        {
            dbDataContext db = new dbDataContext();
            var a = from t in db.SanPhams
                    select t;
            cmbTenSP.DataSource = a;
            cmbTenSP.DisplayMember = "TenSP";
            cmbTenSP.ValueMember = "MaSP";
            cmbTenSP.SelectedIndex = -1;
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtMaHD.ResetText();
            txtDiaChi.ResetText();
            txtSdt.ResetText();
            txtMaHD.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("chắc không?", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (traloi == DialogResult.Yes)
            {
                Application.Exit();

            }
        }


        void ThemThongTinSP()
        {
            dbDataContext db = new dbDataContext();
            SanPham them = new SanPham();
            them.TenSP = cmbTenSP.SelectedValue.ToString();
            them.SoLuong = Convert.ToInt32(nudSoLuong.Text);
            them.Giaban = Convert.ToInt32(txtGiaBan.Text);

            db.SanPhams.InsertOnSubmit(them);
            db.SubmitChanges();
            Load_DataGridview();
        }

        bool TaoHoaDon()
        {
            try
            {
                HoaDon hd = new HoaDon();
                hd.MaHD = txtMaHD.Text.Trim();
                hd.MaHTTT = cmbHTTT.SelectedValue.ToString();
                hd.MaKH = cmbTenKH.SelectedValue.ToString();
                hd.MaNV = cmbTenNV.SelectedValue.ToString();
                hd.NgayLap = dtpNgayLap.Value;
                dbDataContext db = new dbDataContext();
                db.HoaDons.InsertOnSubmit(hd);
                db.SubmitChanges();
                return true;
            }
            catch (System.Data.SqlClient.SqlException)
            {
                return false;
            }
        }



        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaHD.Text) || cmbTenNV.SelectedIndex < 0 || cmbTenKH.SelectedIndex < 0 || cmbHTTT.SelectedIndex < 0 || dgv_ChiTietHD.Rows.Count < 1)
            {
                MessageBox.Show("Chưa đủ thông tin để tạo hóa đơn!");
                return;

            }
            if (TaoHoaDon() == false)
            {
                MessageBox.Show("Mã hóa đơn đã tồn tại!");
                return;
            }
            for (int i = 0; i < dgv_ChiTietHD.Rows.Count; i++)
            {
                HoaDonChiTiet CTHD = new HoaDonChiTiet();
                CTHD.MaHD = txtMaHD.Text;
                CTHD.MaSP = dgv_ChiTietHD.Rows[i].Cells[0].Value.ToString();
                CTHD.SoLuong = Convert.ToInt32(dgv_ChiTietHD.Rows[i].Cells[2].Value);
                dbDataContext db = new dbDataContext();
                db.HoaDonChiTiets.InsertOnSubmit(CTHD);
                db.SubmitChanges();
            }
            this.Close();

        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            string path = @"D:\code\C#\BaiTapLon\BTL02\ThuHoai-MyPham\DanhSachDonHang";
            System.Diagnostics.Process.Start("Explorer.exe", path);

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount = dgv_ChiTietHD.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                for (int i = 0; i < selectedRowCount; i++)
                {
                    dgv_ChiTietHD.Rows.RemoveAt(dgv_ChiTietHD.SelectedRows[0].Index);
                    SanPhamIndex.Remove(dgv_ChiTietHD.SelectedRows[0].Cells[0].Value.ToString());
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hàng cần xóa!", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void dgv_ChiTietHD_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                cmbTenSP.SelectedValue = dgv_ChiTietHD.SelectedRows[0].Cells[0].Value.ToString();
                nudSoLuong.Text = dgv_ChiTietHD.SelectedRows[0].Cells[2].Value.ToString();
                txtGiaBan.Text = dgv_ChiTietHD.SelectedRows[0].Cells[3].Value.ToString();
                txtThanhTien.Text = dgv_ChiTietHD.SelectedRows[0].Cells[4].Value.ToString();
            }
            catch (Exception)
            {

            }

        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            dbDataContext db = new dbDataContext();
            if (cmbTenSP.SelectedIndex >= 0)
            {
                String id = cmbTenSP.SelectedValue.ToString();
                if (SanPhamIndex.ContainsKey(id))
                {
                    //DSSanPham[SanPhamIndex[id]].SoLuong += Convert.ToInt32(nudSoLuong.Value);
                    dgv_ChiTietHD.Rows[SanPhamIndex[id]].Cells[2].Value = (Convert.ToInt32(dgv_ChiTietHD.Rows[SanPhamIndex[id]].Cells[2].Value) + Convert.ToInt32(nudSoLuong.Value)).ToString();
                    dgv_ChiTietHD.Rows[SanPhamIndex[id]].Cells[4].Value = (Convert.ToInt32(dgv_ChiTietHD.Rows[SanPhamIndex[id]].Cells[4].Value) + Convert.ToInt32(txtThanhTien.Text)).ToString();
                }
                else
                {
                    dgv_ChiTietHD.Rows.Add(cmbTenSP.SelectedValue.ToString(), cmbTenSP.Text, Convert.ToInt32(nudSoLuong.Value), txtGiaBan.Text, txtThanhTien.Text);
                    SanPhamIndex.Add(cmbTenSP.SelectedValue.ToString(), dgv_ChiTietHD.Rows.Count - 1);
                }
                cmbTenSP.SelectedIndex = -1;
                txtGiaBan.ResetText();
                txtThanhTien.ResetText();
                nudSoLuong.Value = 1;
            }
            else
            {
                MessageBox.Show("Có gì đâu mà thêm!");
            }
        }

        private void cmbTenSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!IsDetailForm() && cmbTenSP.SelectedIndex >= 0)
            {
                dbDataContext db = new dbDataContext();
                var GiaBan = (from SanPham in db.SanPhams
                              where SanPham.MaSP == cmbTenSP.SelectedValue.ToString()
                              select SanPham.Giaban).ToList();
                if (GiaBan.Count > 0)
                {
                    txtGiaBan.Text = GiaBan.ElementAt(0).ToString();
                    txtThanhTien.Text = (Convert.ToInt32(nudSoLuong.Value) * Convert.ToDouble(txtGiaBan.Text)).ToString();
                }
            }
        }

        private void nudSoLuong_ValueChanged(object sender, EventArgs e)
        {
            if (!IsDetailForm() && string.IsNullOrWhiteSpace(txtGiaBan.Text) == false)
            {
                txtThanhTien.Text = (Convert.ToInt32(nudSoLuong.Value) * Convert.ToDouble(txtGiaBan.Text)).ToString();
            }
        }

        private void cmbTenKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTenKH.SelectedIndex >= 0)
            {
                dbDataContext db = new dbDataContext();
                var kh = (from KhachHang in db.KhachHangs
                          where KhachHang.MaKH == cmbTenKH.SelectedValue.ToString()
                          select new
                          {
                              KhachHang.DiaChi,
                              KhachHang.Sdt
                          }).ToList();
                if (kh.Count > 0)
                {
                    txtDiaChi.Text = kh.ElementAt(0).DiaChi;
                    txtSdt.Text = kh.ElementAt(0).Sdt;
                }
            }
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            var frm = new QuanLy.ThemKhachHang();
            frm.ShowDialog();
            Load_ComboBoxTenKH();
        }
    }
}
