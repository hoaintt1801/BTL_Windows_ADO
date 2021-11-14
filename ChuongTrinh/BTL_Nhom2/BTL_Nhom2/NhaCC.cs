using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using DTO;
using BUS;
using System.Data.SqlClient;

namespace BTL_Nhom2
{
    public partial class NhaCC : Form
    {
        public NhaCC()
        {
            InitializeComponent();
        }
        DTO_NCC L = new DTO_NCC();
        BUS_NCC pn = new BUS_NCC();
        private void NhaCC_Load(object sender, EventArgs e)
        {
            NCC.DataSource = pn.ShowLop();
            txtphantrang.Text = "Tổng số phiếu là " + NCC.RowCount;
        }

        private void tthem_Click(object sender, EventArgs e)
        {
            if (tmncc.TextLength == 0) MessageBox.Show("Mã nhà cung cấp không được bỏ trống!");
            else if (ttncc.TextLength == 0) MessageBox.Show("Tên nhà cung cấp không được bỏ trống!");
            else if (tdc.TextLength == 0) MessageBox.Show("Địa chỉ không được bỏ trống!");
            else if (tsdt.TextLength == 0) MessageBox.Show("Số điện thoại không được bỏ trống!");
            else if (te.TextLength == 0) MessageBox.Show("Email không được bỏ trống!");

            else
            {
                try
                {
                    L.Mancc = tmncc.Text;
                    L.Tenncc = ttncc.Text;
                    L.Dc = tdc.Text;
                    L.Sdt = tsdt.Text;
                    L.Email = te.Text;
                    DialogResult tl = MessageBox.Show("Bạn có chắc chắn muốn thêm không? ", "Thông báo", MessageBoxButtons.YesNo);
                        if(tl == DialogResult.Yes)
                    {
                        pn.InsertPN(L.Mancc, L.Tenncc, L.Dc, L.Sdt, L.Email);
                        MessageBox.Show("Thêm thành công!");
                        NhaCC_Load(sender, e);
                    }
                   
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
            else if (ttncc.TextLength == 0) MessageBox.Show("Tên nhà cung cấp không được bỏ trống!");
             else if (tdc.TextLength == 0) MessageBox.Show("Địa chỉ không được bỏ trống!");
           else  if (tsdt.TextLength == 0) MessageBox.Show("Số điện thoại không được bỏ trống!");
            else if (te.TextLength == 0) MessageBox.Show("Email không được bỏ trống!");
            else
            {
                try
                {
                    L.Mancc = tmncc.Text;
                    L.Tenncc = ttncc.Text;
                    L.Dc = tdc.Text;
                    L.Sdt = tsdt.Text;
                    L.Email = te.Text;
                    DialogResult tl = MessageBox.Show("Bạn có chắc chắn muốn sửa không? ", "Thông báo", MessageBoxButtons.YesNo);
                    if (tl == DialogResult.Yes)
                    {
                        pn.UpdatePN(L.Mancc, L.Tenncc, L.Dc, L.Sdt, L.Email);
                        MessageBox.Show("Sửa thành công!");
                        NhaCC_Load(sender, e);
                    }
                        
                }
                catch
                {
                    MessageBox.Show("Vui lòng thực hiện lại");
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
                    DialogResult tl = MessageBox.Show("Bạn có chắc chắn muốn xóa không? ", "Thông báo", MessageBoxButtons.YesNo);
                    if (tl == DialogResult.Yes)
                    {
                        L.Mancc = tmncc.Text;
                         pn.DeletePN(L.Mancc);
                        MessageBox.Show("Xóa thành công!", "Thông báo");
                        NhaCC_Load(sender, e);
                    }
                       
                }
                catch
                {
                    MessageBox.Show("Vui lòng thực hiện lại");
                }

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
            DialogResult tl = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo);
            if (tl == DialogResult.Yes)
                this.Close();
        }

       
       
       

        private void NCC_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < NCC.RowCount; i++)
            {
                NCC.Rows[i].Cells[0].Value = i + 1;
            }
        }

        private void NCC_RowEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            int d = e.RowIndex;
            tmncc.Text = NCC.Rows[d].Cells[1].Value.ToString();
            ttncc.Text = NCC.Rows[d].Cells[2].Value.ToString();
            tdc.Text = NCC.Rows[d].Cells[3].Value.ToString();
            tsdt.Text = NCC.Rows[d].Cells[4].Value.ToString();
            te.Text = NCC.Rows[d].Cells[5].Value.ToString();
        }

     

        private void iconButton1_Click(object sender, EventArgs e)
        {
            NhaCC_Load(sender, e);
            tt.Clear();
        }

        private void ttim_Click_1(object sender, EventArgs e)
        {
            if (tt.TextLength == 0) MessageBox.Show("Nhập mã NCC cần tìm!", "Thông báo");
            else
            {
                if (checkBox1.Checked == true)
                {
                    NCC.DataSource = pn.LookMPN(tt.Text);
                    txtphantrang.Text = "Tổng số phiếu là " + NCC.RowCount;
                }
                if (checkBox2.Checked == true)
                {
                    NCC.DataSource = pn.LookTPN(tt.Text);
                    txtphantrang.Text = "Tổng số phiếu là " + NCC.RowCount;
                }
            }
         
        }

        private void btnxuat_Click(object sender, EventArgs e)
        {
            Program.exportExcel(@"D:\", "dsNCC", NCC);
            MessageBox.Show("Xuất thành công vào D:\\dsNCC.xlsx");
        }
    }
}
