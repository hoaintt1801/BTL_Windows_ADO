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
using DAL;
using DTO;
using BUS;

namespace BTL_Nhom5
{
    public partial class NCC : Form
    {
        public NCC()
        {
            InitializeComponent();
        }
        Lop_DTO L = new Lop_DTO();
        Lop_Bus pn = new Lop_Bus();
        private void NCC_Load(object sender, EventArgs e)
        {

            dvgNCC.DataSource = pn.ShowLop();
            txtphantrang.Text = "Tổng số phiếu là " + dvgNCC.RowCount;
        }

        private void NCC_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < dvgNCC.RowCount; i++)
            {
                dvgNCC.Rows[i].Cells[0].Value = i + 1;
            }
        }

        private void NCC_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int d = e.RowIndex;
            tmncc.Text = dvgNCC.Rows[d].Cells[1].Value.ToString();
            ttncc.Text = dvgNCC.Rows[d].Cells[2].Value.ToString();
            tdc.Text = dvgNCC.Rows[d].Cells[3].Value.ToString();
            tsdt.Text = dvgNCC.Rows[d].Cells[4].Value.ToString();
            te.Text = dvgNCC.Rows[d].Cells[5].Value.ToString();

        }

        private void tthem_Click(object sender, EventArgs e)
        {
            if (tmncc.TextLength == 0) MessageBox.Show("Mã nhà cung cấp không được bỏ trống!");
            if (ttncc.TextLength == 0) MessageBox.Show("Tên nhà cung cấp không được bỏ trống!");
            if (tdc.TextLength == 0) MessageBox.Show("Địa chỉ không được bỏ trống!");
            if (tsdt.TextLength == 0) MessageBox.Show("Số điện thoại không được bỏ trống!");
            if (te.TextLength == 0) MessageBox.Show("Email không được bỏ trống!");

            else
            {
                try
                {
                    L.Mancc = tmncc.Text;
                    L.Tenncc = ttncc.Text;
                    L.Dc = tdc.Text;
                    L.Sdt = tsdt.Text;
                    L.Email = te.Text;
                    pn.InsertPN(L.Mancc, L.Tenncc, L.Dc, L.Sdt, L.Email);
                    MessageBox.Show("Thêm thành công!");
                   NCC_Load(sender, e);
                }
                catch
                {
                    MessageBox.Show("Phiếu đã tồn tại\n\nVui lòng tạo mã phiếu khác!", "Thông báo");
                }
            }
        }

        private void tsua_Click(object sender, EventArgs e)
        {

            if (tmncc.TextLength == 0) MessageBox.Show("Mã nhà cung cấp không được bỏ trống!");
            if (ttncc.TextLength == 0) MessageBox.Show("Tên nhà cung cấp không được bỏ trống!");
            if (tdc.TextLength == 0) MessageBox.Show("Địa chỉ không được bỏ trống!");
            if (tsdt.TextLength == 0) MessageBox.Show("Số điện thoại không được bỏ trống!");
            if (te.TextLength == 0) MessageBox.Show("Email không được bỏ trống!");
            else
            {
                try
                {
                    L.Mancc = tmncc.Text;
                    L.Tenncc = ttncc.Text;
                    L.Dc = tdc.Text;
                    L.Sdt = tsdt.Text;
                    L.Email = te.Text;
                    pn.UpdatePN(L.Mancc, L.Tenncc, L.Dc, L.Sdt, L.Email);
                    MessageBox.Show("Sửa thành công!");
                    NCC_Load(sender, e);
                }
                catch
                {
                    MessageBox.Show("Error!");
                }
            }
        }

        private void txoa_Click(object sender, EventArgs e)
        {
            if (tmncc.TextLength == 0) MessageBox.Show("Nhập mã NCC cần xóa!", "Thông báo");
            else
            {
                try
                {
                    L.Mancc = tmncc.Text;
                    pn.DeletePN(L.Mancc);
                    MessageBox.Show("Xóa thành công!", "Thông báo");
                    NCC_Load(sender, e);
                }
                catch
                {
                    MessageBox.Show("Không xóa đc viết cho vui thôi haha");
                }

            }
        }

        private void ttim_Click(object sender, EventArgs e)
        {

            if (tt.TextLength == 0) MessageBox.Show("Nhập mã NCC cần tìm!", "Thông báo");
            else
            {
                dvgNCC.DataSource = pn.LookMPN(tt.Text);
                txtphantrang.Text = "Tổng số phiếu là " + dvgNCC.RowCount;
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            tmncc.ResetText();
            ttncc.ResetText();
            tdc.ResetText();
            tsdt.ResetText();
            te.ResetText();
            tt.ResetText();
        }

        private void tthoat_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Thoát", "Thông báo", MessageBoxButtons.YesNoCancel);
            if (d == DialogResult.Yes) Application.Exit();
        }

        private void tex_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Thoát", "Thông báo", MessageBoxButtons.YesNoCancel);
            if (d == DialogResult.Yes) Application.Exit();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            NCC_Load(sender, e);
            tt.Clear();
        }

        private void btnxuat_Click(object sender, EventArgs e)
        {

        }
    }
}
