using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using System.Data.SqlClient;
using DTO;

namespace BTL_Nhom2
{
    public partial class FormPhieuNhap : Form
    {
        public FormPhieuNhap()
        {
            InitializeComponent();
        }
        DTO_PhieuNhap L = new DTO_PhieuNhap();
        BUS_PhieuNhap pn = new BUS_PhieuNhap();

        private void but_them_Click(object sender, EventArgs e)
        {
            if (tmapn.TextLength == 0) MessageBox.Show("Mã phiếu không được bỏ trống!");
            else if (tmasp.TextLength == 0) MessageBox.Show("Mã sản phẩm không được bỏ trống!");
            else if (tsln.TextLength == 0) MessageBox.Show("Số lượng không được bỏ trống!");
           else  if (tdgn.TextLength == 0) MessageBox.Show("Đơn giá không được bỏ trống!");
            else if (tngayn.TextLength == 0) MessageBox.Show("Ngày nhập không được bỏ trống!");
             else if (tmancc.TextLength == 0) MessageBox.Show("Mã NCC không được bỏ trống!");
            else
            {
                try
                {
                    L.Mapn = tmapn.Text;
                    L.Masp = tmasp.Text;
                    L.Sln = Int32.Parse(tsln.Text);
                    L.Dgn = float.Parse(tdgn.Text);
                    L.Ngayn = tngayn.Text;
                    L.Mancc = tmancc.Text;
                    DialogResult tl = MessageBox.Show("Bạn có chắc chắn muốn thêm không? ", "Thông báo", MessageBoxButtons.YesNo);
                    if (tl == DialogResult.Yes)
                    {
                        pn.InsertPN(L.Mapn, L.Masp, L.Sln, L.Dgn, L.Ngayn, L.Mancc);
                        MessageBox.Show("Thêm thành công!");
                        PhieuNhap_Load(sender, e);
                    }
                }
                catch
                {
                    MessageBox.Show("Phiếu đã tồn tại\nVui lòng tạo mã phiếu khác!", "Thông báo");
                }
            }
        }

        private void but_sua_Click(object sender, EventArgs e)
        {
            if (tmapn.TextLength == 0) MessageBox.Show("Mã phiếu không được bỏ trống!", "Thông báo");
            else if (tmasp.TextLength == 0) MessageBox.Show("Mã sản phẩm không được bỏ trống!", "Thông báo");
           else  if (tsln.TextLength == 0) MessageBox.Show("Số lượng không được bỏ trống!", "Thông báo");
            else if (tdgn.TextLength == 0) MessageBox.Show("Đơn giá không được bỏ trống!", "Thông báo");
           else  if (tngayn.TextLength == 0) MessageBox.Show("Ngày nhập không được bỏ trống!", "Thông báo");
            else if (tmancc.TextLength == 0) MessageBox.Show("Mã NCC không được bỏ trống!", "Thông báo");
            else
            {
                try
                {
                    L.Mapn = tmapn.Text;
                    L.Masp = tmasp.Text;
                    L.Sln = Int32.Parse(tsln.Text);
                    L.Dgn = float.Parse(tdgn.Text);
                    L.Ngayn = tngayn.Text;
                    L.Mancc = tmancc.Text;
                    DialogResult tl = MessageBox.Show("Bạn có chắc chắn muốn sửa không? ", "Thông báo", MessageBoxButtons.YesNo);
                    if (tl == DialogResult.Yes)
                    {
                        pn.UpdatePN(L.Mapn, L.Masp, L.Sln, L.Dgn, L.Ngayn, L.Mancc);
                        MessageBox.Show("Sửa thành công!", "Thông báo");
                        PhieuNhap_Load(sender, e);
                    }
                      
                }
                catch
                {
                    MessageBox.Show("Error!");
                }
            }
        }

        private void but_xoa_Click(object sender, EventArgs e)
        {
            if (tmapn.TextLength == 0) MessageBox.Show("Nhập mã phiếu cần xóa!", "Thông báo");
            else
            {

                L.Mapn = tmapn.Text;
                DialogResult tl = MessageBox.Show("Bạn có chắc chắn muốn xóa không? ", "Thông báo", MessageBoxButtons.YesNo);
                if (tl == DialogResult.Yes)
                {

                    pn.DeletePN(L.Mapn);
                    MessageBox.Show("Xóa thành công!", "Thông báo");
                    PhieuNhap_Load(sender, e);
                }


            }
        }

        private void but_tim_Click(object sender, EventArgs e)
        {
            if (ttim.TextLength == 0) MessageBox.Show("Nhập mã phiếu cần tìm!", "Thông báo");
            {
                if(radioButton1.Checked==true)
                {
                    dataPN.DataSource = pn.LookMPN(ttim.Text);
                    txtphantrang.Text = "Tổng số phiếu " + dataPN.Rows.Count.ToString();
                    
                }
                
                if (radioButton2.Checked == true)
                {
                    dataPN.DataSource = pn.LookMNCC(ttim.Text);
                    txtphantrang.Text = "Tổng số phiếu " + dataPN.Rows.Count.ToString();
                    
                }
                if (radioButton3.Checked == true)
                {
                    dataPN.DataSource = pn.LookTSP(ttim.Text);
                    txtphantrang.Text = "Tổng số phiếu " + dataPN.Rows.Count.ToString();
                    
                }

            }
           
            
        }

        private void reset_Click(object sender, EventArgs e)
        {
            tmapn.ResetText();
            tmasp.ResetText();
            tsln.ResetText();
            tdgn.ResetText();
            tngayn.ResetText();
            tmancc.ResetText();
            ttim.ResetText();
        }

        private void but_thoat_Click(object sender, EventArgs e)
        {
            DialogResult tl = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo);
            if (tl == DialogResult.Yes)
                this.Close();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            PhieuNhap_Load(sender, e);
            ttim.Clear();
        }

        private void btnxuat_Click(object sender, EventArgs e)
        {
            Program.exportExcel(@"D:\", "dsPN", dataPN);
            MessageBox.Show("Xuất thành công vào D:\\dsPN.xlsx");
        }

        private void PhieuNhap_Load(object sender, EventArgs e)
        {

            dataPN.DataSource = pn.ShowLop();
            txtphantrang.Text = "Tổng số phiếu là " + dataPN.RowCount;

            for (int i = 0; i < dataPN.Columns.Count; i++)
            {
                dataPN.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

     

        private void dataPN_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int d = e.RowIndex;
            tmapn.Text = dataPN.Rows[d].Cells[1].Value.ToString();
            tmasp.Text = dataPN.Rows[d].Cells[2].Value.ToString();
            tsln.Text = dataPN.Rows[d].Cells[3].Value.ToString();
            tdgn.Text = dataPN.Rows[d].Cells[4].Value.ToString();
            tngayn.Text = dataPN.Rows[d].Cells[5].Value.ToString();
            tmancc.Text = dataPN.Rows[d].Cells[6].Value.ToString();
        }

        private void dataPN_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < dataPN.RowCount; i++)
            {
                dataPN.Rows[i].Cells[0].Value = i + 1;
            }
        }

        

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
