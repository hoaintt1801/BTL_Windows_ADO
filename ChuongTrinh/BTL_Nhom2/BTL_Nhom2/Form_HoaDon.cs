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
    public partial class Form_HoaDon : Form
    {
        public Form_HoaDon()
        {
            InitializeComponent();
        }

        private void Form_HoaDon_Load(object sender, EventArgs e)
        {
            Load_HoaDon();
            for (int i = 0; i < dgv_HoaDon.Columns.Count; i++)
            {
                dgv_HoaDon.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            txtphantrang.Text = "Tổng số nhân là: " + dgv_HoaDon.RowCount;
        }
        void Load_HoaDon()
        {
            dgv_HoaDon.DataSource = null;
            dbDataContext db = new dbDataContext();
            var hd1 = (from p in db.HoaDons
                       join t in db.NhanViens on p.MaNV equals t.MaNV
                       join q in db.KhachHangs on p.MaKH equals q.MaKH
                       select new
                       {
                           p.MaHD,
                           p.MaKH,
                           p.NgayLap,
                           t.MaNV,
                           TenNV = t.HoTen,
                           TenKH = q.HoTen,
                       }).ToList();
            dgv_HoaDon.DataSource = hd1;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dbDataContext db = new dbDataContext();


            dgv_HoaDon.DataSource = (from p in db.HoaDons
                                     join t in db.NhanViens on p.MaNV equals t.MaNV
                                     join q in db.KhachHangs on p.MaKH equals q.MaKH
                                     where p.MaHD.StartsWith(txtTimKiem.Text)
                                     select new
                                     {
                                         p.MaHD,
                                         p.MaKH,
                                         p.NgayLap,
                                         t.MaNV,
                                         TenNV = t.HoTen,
                                         TenKH = q.HoTen,
                                     }).ToList();
            txtphantrang.Text = "Tổng số nhân viên là: " + dgv_HoaDon.RowCount;

        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("chắc không?", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (traloi == DialogResult.Yes)
            {
                Application.Exit();

            }
        }

        private void dgv_HoaDon_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_HoaDon.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn hóa đơn cần xem!", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            String MaHD = dgv_HoaDon.SelectedRows[0].Cells[0].Value.ToString();
            new CTHD(MaHD).ShowDialog();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (dgv_HoaDon.SelectedRows.Count > 0)
            {
                dbDataContext db = new dbDataContext();
                var xoa = from hd in db.HoaDons

                          where hd.MaHD == dgv_HoaDon.SelectedRows[0].Cells[0].Value.ToString()
                          select hd;
                foreach (var i in xoa)
                {
                    db.HoaDons.DeleteOnSubmit(i);
                    db.SubmitChanges();

                }
                Load_HoaDon();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hàng cần xóa!", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            CTHD f2 = new CTHD();
            f2.ShowDialog();
            Load_HoaDon();

        }

       

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtTimKiem.ResetText();
            txtTimKiem.Focus();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Form_HoaDon_Load(sender, e);
            txtTimKiem.Clear();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            Program.exportExcel(@"D:\", "dsTK", dgv_HoaDon);
            MessageBox.Show("Xuất thành công vào D:\\dsHD.xlsx");
        }
    }
}
