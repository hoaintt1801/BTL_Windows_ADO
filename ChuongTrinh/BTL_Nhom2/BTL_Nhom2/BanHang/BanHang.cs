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

namespace BTL_Nhom2
{
    public partial class BanHang : Form
    {
        DataTable dt = null;

        Bus_BanHang bus = new Bus_BanHang();
        public BanHang()
        {
            InitializeComponent();
        }

        private void btnThemDH_Click(object sender, EventArgs e)
        {
            var frm = new DialogThemDH();
            frm.ShowDialog();
            load_dgvDonHang();
        }

        private void BanHang_Load(object sender, EventArgs e)
        {
            txtChietKhau.Text = "0";
            load_cbKH();
            load_dgvDonHang();
            load_httt();
        }
        public void load_dgvDonHang()
        {
            dt = new DataTable();
            dt = bus.getHoaDon();
            for(int i= dt.Rows.Count-1; i>=0; i--)
            {
                if (dt.Rows[i].ItemArray[5].Equals(true))
                {
                    dt.Rows.RemoveAt(i);
                }
            }
            list_DonHang.DataSource = dt;
            list_DonHang.DisplayMember = "MaHD";
            list_DonHang.ValueMember = "MaHD";
        }

        private void load_cbKH()
        {
            dt = new DataTable();
            dt = bus.getKhachHang();
            cb_KH.DataSource = dt;
            cb_KH.DisplayMember = "HoTen";
            cb_KH.ValueMember = "MaKH";
        }

        private void load_httt()
        {
            dt = new DataTable();
            dt = bus.getHTTT();
            cbxhttt.DataSource = dt;
            cbxhttt.DisplayMember = "TenHTTT";
            cbxhttt.ValueMember = "MaHTTT";
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vui lòng kết nối scanner");
        }

        private void list_DonHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            //load_cbKH();
            txtChietKhau.Text = "0";
            dt = new DataTable();
            dt = bus.getHoaDon();
            /*if (cb_KH.DropDownStyle == ComboBoxStyle.DropDownList)
            {
                cb_KH.DropDownStyle = ComboBoxStyle.DropDown;
            }*/
            cb_KH.SelectedValue = dt.Rows[list_DonHang.SelectedIndex].ItemArray[1].ToString().Trim();
            dt = bus.getHoaDonChiTiet(dt.Rows[list_DonHang.SelectedIndex].ItemArray[0].ToString().Trim());
            dt.Columns.Add("Sửa ", typeof(Icon));

            dgv_SP.DataSource = dt;
            for (int i = 0; i < dgv_SP.Columns.Count; i++)
            {
                dgv_SP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            /*Icon icon = new Icon("C:\\Users\\Andy\\Desktop\\bin\\bin\\BTL_Nhom5\\packages\\edit.png");
            icon.ToBitmap();
            for (int i = 0; i < dgv_SP.Rows.Count; i++)
            {
                dgv_SP.Rows[i].Cells[5].Value = icon;
            }*/
            //MessageBox.Show("" + dt.Rows[list_DonHang.SelectedIndex].ItemArray[1].ToString().Trim());
            double tt = 0;
            for (int i = 0; i < dgv_SP.RowCount; i++)
            {
                tt += Double.Parse(dgv_SP.Rows[i].Cells[2].Value.ToString()) * Double.Parse(dgv_SP.Rows[i].Cells[3].Value.ToString());
                
            }
            txtTongTien.Text = tt.ToString();
            
            if (txtChietKhau.Text.Equals("0")|| txtChietKhau.Text.Equals(""))
            {
                txtTienPhaiTra.Text = txtTongTien.Text;
            }
            else
            {
                double a = (Double.Parse(txtTongTien.Text) - Double.Parse(txtChietKhau.Text));
                txtTienPhaiTra.Text = a.ToString();
            }
        }

        private void cb_KH_Click(object sender, EventArgs e)
        {
            if (cb_KH.DropDownStyle == ComboBoxStyle.DropDown)
            {
                cb_KH.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }

        private void dgv_SP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_SP.CurrentCell.ColumnIndex == 5)
            {
                dt = new DataTable();
                dt = bus.getHoaDon();
                var frm = new Dialog_EditSP();
                frm.getMaHD = dt.Rows[list_DonHang.SelectedIndex].ItemArray[0].ToString().Trim();
                frm.getMaSp = dgv_SP.Rows[dgv_SP.CurrentRow.Index].Cells[0].Value.ToString().Trim();
                frm.getTenSp = dgv_SP.Rows[dgv_SP.CurrentRow.Index].Cells[1].Value.ToString().Trim();
                frm.getSoLuong = dgv_SP.Rows[dgv_SP.CurrentRow.Index].Cells[2].Value.ToString().Trim();
                frm.ShowDialog();
                //load data san phẩm
                dt = bus.getHoaDonChiTiet(dt.Rows[list_DonHang.SelectedIndex].ItemArray[0].ToString().Trim());
                dt.Columns.Add("edit", typeof(PictureBox));

                dgv_SP.DataSource = dt;
                for (int i = 0; i < dgv_SP.Columns.Count; i++)
                {
                    dgv_SP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                //tính lại tổng tiền
                double tt = 0;
                for (int i = 0; i < dgv_SP.RowCount; i++)
                {
                    tt += Double.Parse(dgv_SP.Rows[i].Cells[2].Value.ToString()) * Double.Parse(dgv_SP.Rows[i].Cells[3].Value.ToString());
                }
                txtTongTien.Text = tt.ToString();
                //tính lại chiết khấu và tiền trả
                if (txtChietKhau.Text.Length == 0)
                {
                    txtTienPhaiTra.Text = txtTongTien.Text;
                }
                else
                {
                    txtTienPhaiTra.Text = (Double.Parse(txtTienPhaiTra.Text) - Double.Parse(txtChietKhau.Text)).ToString();
                }
            }
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            var frm = new Dialog_ThemSP();
            dt = new DataTable();
            dt = bus.getHoaDon();
            frm.getMaHD = dt.Rows[list_DonHang.SelectedIndex].ItemArray[0].ToString().Trim();
            frm.ShowDialog();

            //load data san phẩm
            dt = bus.getHoaDonChiTiet(dt.Rows[list_DonHang.SelectedIndex].ItemArray[0].ToString().Trim());
            dt.Columns.Add("edit", typeof(PictureBox));

            dgv_SP.DataSource = dt;
            for (int i = 0; i < dgv_SP.Columns.Count; i++)
            {
                dgv_SP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            //tính lại tổng tiền
            double tt = 0;
            for (int i = 0; i < dgv_SP.RowCount; i++)
            {
                tt += Double.Parse(dgv_SP.Rows[i].Cells[2].Value.ToString()) * Double.Parse(dgv_SP.Rows[i].Cells[3].Value.ToString());
            }
            txtTongTien.Text = tt.ToString();
        }

        private void txtChietKhau_Click(object sender, EventArgs e)
        {
            var frm = new Dialog_ChietKhau();
            frm.getTongTien = Double.Parse(txtTongTien.Text);
            frm.ShowDialog();
            if (frm.getCheck)
            {
                txtChietKhau.Text = frm.getCK.ToString();
                txtTienPhaiTra.Text = (Double.Parse(txtTongTien.Text) - frm.getCK).ToString();
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (dgv_SP.Rows.Count > 0)
            {
                string MaHD = list_DonHang.SelectedValue.ToString().Trim();
                bus.updateHoaDon(MaHD);
                load_dgvDonHang();
                MessageBox.Show("Bạn đã thanh toán thành công đơn hàng");
            }
            else {
                MessageBox.Show("Bạn vui lòng thêm sản phẩm vào hóa đơn");
            }
        }

        private void cb_KH_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn chắc chắn xóa đơn hàng này không?", "thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                try
                {

                    string maHD = list_DonHang.SelectedValue.ToString().Trim();
                    bus.delHoaDon(maHD);
                    BanHang_Load(sender, e);
                    MessageBox.Show("Xóa thành công");

                }
                catch
                {
                    MessageBox.Show("Vui lòng thực hiện lai!");
                }
            }
        }

        private void txtTK_Click(object sender, EventArgs e)
        {
            txtTK.Clear();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
