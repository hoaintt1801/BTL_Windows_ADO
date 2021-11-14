using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

//using Microsoft.Office.Interop.Excel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BUS;
using app = Microsoft.Office.Interop.Excel.Application;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BTL_Nhom2.San_Pham
{
    public partial class DSSanPham : Form
    {
        public DSSanPham()
        {
            InitializeComponent();
        }
        BUS_DSSP dssp = new BUS_DSSP();
        DataTable dt = null;

        private void DSSanPham_Load(object sender, EventArgs e)
        {
            loadcbLoaiSP();
            loadcbxNCC();
            loadcbxNhanHieu();
         
            DataTable dt = new DataTable();
            dt = dssp.ShowDSSP();
            dgv_dsSP.DataSource = dt;
            
            for(int i=0; i<dgv_dsSP.Rows.Count; i++)
            {
                dgv_dsSP.Rows[i].Cells[4].Value = dssp.hashNhanHieu(dgv_dsSP.Rows[i].Cells[4].Value.ToString().Trim(),true);
                dgv_dsSP.Rows[i].Cells[3].Value = dssp.hashLoai(dgv_dsSP.Rows[i].Cells[3].Value.ToString().Trim(),true);
                dgv_dsSP.Rows[i].Cells[7].Value = dssp.hashNhaCC(dgv_dsSP.Rows[i].Cells[7].Value.ToString().Trim(), true);

            }

            for (int i = 0; i < dgv_dsSP.Columns.Count; i++)
            {
                dgv_dsSP.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            loadtxtphantrang();
        }

        private void dgv_dsSP_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            
            for (int i = 0; i < dgv_dsSP.RowCount; i++)
                dgv_dsSP.Rows[i].Cells[0].Value = i;
        }

        private void dgv_dsSP_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txtmasp.Text = dgv_dsSP.Rows[dong].Cells[1].Value.ToString();
            txttensp.Text = dgv_dsSP.Rows[dong].Cells[2].Value.ToString();
            txtsl.Text = dgv_dsSP.Rows[dong].Cells[5].Value.ToString();
            txtgiaban.Text = dgv_dsSP.Rows[dong].Cells[6].Value.ToString();

        }
        public void loadcbLoaiSP()
        {
            dt = new DataTable();
            dt = dssp.getLoaiSP();
            this.cbxloaisp.DataSource = dt;
            this.cbxloaisp.DisplayMember = "TenLSP";
            this.cbxloaisp.ValueMember = "MaLSP";
        }
        public void loadcbxNhanHieu()
        {
            dt = new DataTable();
            dt = dssp.getNhanHieu();
            this.cbxnhanhieu.DataSource = dt;
            this.cbxnhanhieu.DisplayMember = "TenNH";
            this.cbxnhanhieu.ValueMember = "MaNH";
        }
        public void loadcbxNCC()
        {
            dt = new DataTable();
            dt = dssp.getNhaCC();
            this.cbxncc.DataSource = dt;
            this.cbxncc.DisplayMember = "TenNCC";
            this.cbxncc.ValueMember = "MaNCC";
        }
       
        public void loadtxtphantrang()
        {
            txtphantrang.Text = "Tổng số sản phẩm là "+ dgv_dsSP.RowCount;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                var frm = new ThemSanPham();
                frm.ShowDialog();
                DSSanPham_Load(sender, e);
            }
            catch
            {
                MessageBox.Show("Vui lòng thực hiện lại");
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                int r = dgv_dsSP.CurrentCell.RowIndex;
                string strMaSP = dgv_dsSP.Rows[r].Cells[1].Value.ToString();
                DialogResult tl = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo);
                if (tl == DialogResult.Yes)
                {
                    dssp.DeleteSanPham(strMaSP);
                    DSSanPham_Load(sender, e);
                    MessageBox.Show("Xóa thành công");
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng thực hiện lại");
            }
           
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            try
            {
                var frm = new SuaSanPham();
                dt = new DataTable();
                dt = dssp.getSanPham();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i].ItemArray[0].ToString().Trim().Equals(dgv_dsSP.Rows[dgv_dsSP.CurrentRow.Index].Cells[1].Value.ToString().Trim()))
                    {
                        frm.getmasp = dt.Rows[i].ItemArray[0].ToString().Trim();
                        frm.gettenSP = dt.Rows[i].ItemArray[1].ToString().Trim();
                        frm.getgiaBan = dt.Rows[i].ItemArray[2].ToString().Trim();
                        frm.getsoLuong = dt.Rows[i].ItemArray[3].ToString().Trim();
                        frm.getnhaHieu = dt.Rows[i].ItemArray[4].ToString().Trim();
                        frm.getloaiSP = dt.Rows[i].ItemArray[5].ToString().Trim();
                        frm.getnhaCungCap = dt.Rows[i].ItemArray[6].ToString().Trim();
                        frm.getmaVach = dt.Rows[i].ItemArray[7].ToString().Trim();
                        frm.getmoTa = dt.Rows[i].ItemArray[8].ToString().Trim();

                        break;
                    }
                }
                frm.ShowDialog();
                dt = new DataTable();
                dt = dssp.ShowDSSP();
                dgv_dsSP.DataSource = dt;
                for (int i = 0; i < dgv_dsSP.Rows.Count; i++)
                {
                    dgv_dsSP.Rows[i].Cells[4].Value = dssp.hashNhanHieu(dgv_dsSP.Rows[i].Cells[4].Value.ToString().Trim(), true);
                    dgv_dsSP.Rows[i].Cells[3].Value = dssp.hashLoai(dgv_dsSP.Rows[i].Cells[3].Value.ToString().Trim(), true);
                    dgv_dsSP.Rows[i].Cells[7].Value = dssp.hashNhaCC(dgv_dsSP.Rows[i].Cells[7].Value.ToString().Trim(), true);

                }
                for (int i = 0; i < dgv_dsSP.Columns.Count; i++)
                {
                    dgv_dsSP.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng thực hiện lại");
            }
        }

        private void btnloc_Click(object sender, EventArgs e)
        {
            string timKiem = txttimkiem.Text;
            string loaiSP = cbxloaisp.SelectedValue.ToString().Trim();
            string nhaHieu = cbxnhanhieu.SelectedValue.ToString().Trim();
            string nhaCC = cbxncc.SelectedValue.ToString().Trim();

            dt = new DataTable();
            if (checkBox1.Checked)
            {
                if (checkBox2.Checked)
                {
                    if (checkBox3.Checked)
                    {
                        if (checkBox4.Checked)
                        {
                            dt = dssp.getSanPham(timKiem, loaiSP, nhaHieu, nhaCC);
                            dgv_dsSP.DataSource = dt;
                        }
                        else
                        {
                            dt = dssp.getSanPham(timKiem, loaiSP, nhaHieu, "");
                            dgv_dsSP.DataSource = dt;
                        }
                    }
                    else
                    {
                        if (checkBox4.Checked)
                        {
                            dt = dssp.getSanPham(timKiem, loaiSP, "", nhaCC);
                            dgv_dsSP.DataSource = dt;
                        }
                        else
                        {
                            dt = dssp.getSanPham(timKiem, loaiSP, "", "");
                            dgv_dsSP.DataSource = dt;
                        }
                    }
                }
                else
                {
                    if (checkBox3.Checked)
                    {
                        if (checkBox4.Checked)
                        {
                            dt = dssp.getSanPham(timKiem, "", nhaHieu, nhaCC);
                            dgv_dsSP.DataSource = dt;
                        }
                        else
                        {
                            dt = dssp.getSanPham(timKiem, "", nhaHieu, "");
                            dgv_dsSP.DataSource = dt;
                        }
                    }
                    else
                    {
                        if (checkBox4.Checked)
                        {
                            dt = dssp.getSanPham(timKiem, "", "", nhaCC);
                            dgv_dsSP.DataSource = dt;
                        }
                        else
                        {
                            dt = dssp.getSanPham(timKiem, "", "", "");
                            dgv_dsSP.DataSource = dt;
                        }
                    }
                }
            }
            else
            {
                if (checkBox2.Checked)
                {
                    if (checkBox3.Checked)
                    {
                        if (checkBox4.Checked)
                        {
                            dt = dssp.getSanPham("", loaiSP, nhaHieu, nhaCC);
                            dgv_dsSP.DataSource = dt;
                        }
                        else
                        {
                            dt = dssp.getSanPham("", loaiSP, nhaHieu, "");
                            dgv_dsSP.DataSource = dt;
                        }
                    }
                    else
                    {
                        if (checkBox4.Checked)
                        {
                            dt = dssp.getSanPham("", loaiSP, "", nhaCC);
                            dgv_dsSP.DataSource = dt;
                        }
                        else
                        {
                            dt = dssp.getSanPham("", loaiSP, "", "");
                            dgv_dsSP.DataSource = dt;
                        }
                    }
                }
                else
                {
                    if (checkBox3.Checked)
                    {
                        if (checkBox4.Checked)
                        {
                            dt = dssp.getSanPham("", "", nhaHieu, nhaCC);
                            dgv_dsSP.DataSource = dt;
                        }
                        else
                        {
                            dt = dssp.getSanPham("", "", nhaHieu, "");
                            dgv_dsSP.DataSource = dt;
                        }
                    }
                    else
                    {
                        if (checkBox4.Checked)
                        {
                            dt = dssp.getSanPham("", "", "", nhaCC);
                            dgv_dsSP.DataSource = dt;
                        }
                        else
                        {
                            dt = dssp.getSanPham("", "", "", "");
                            dgv_dsSP.DataSource = dt;
                        }
                    }
                }
            }
            txtphantrang.Text = "Tổng số sản phẩm là " + dgv_dsSP.Rows.Count.ToString();
            for (int i = 0; i < dgv_dsSP.Rows.Count; i++)
            {
                dgv_dsSP.Rows[i].Cells[4].Value = dssp.hashNhanHieu(dgv_dsSP.Rows[i].Cells[4].Value.ToString().Trim(), true);
                dgv_dsSP.Rows[i].Cells[3].Value = dssp.hashLoai(dgv_dsSP.Rows[i].Cells[3].Value.ToString().Trim(), true);
                dgv_dsSP.Rows[i].Cells[7].Value = dssp.hashNhaCC(dgv_dsSP.Rows[i].Cells[7].Value.ToString().Trim(), true);
            }

            for (int i = 0; i < dgv_dsSP.Columns.Count; i++)
            {
                dgv_dsSP.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            DSSanPham_Load(sender, e);
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            txttimkiem.Clear();
        }

       

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult tl = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo);
            if (tl == DialogResult.Yes)
                this.Close();
        }
        private void exportExcel(string duongdan, string tentep, DataGridView dgv)
        {
            app obj = new app();
            obj.Application.Workbooks.Add(Type.Missing);
            obj.Columns.ColumnWidth = 25;
            for(int i=1; i< dgv.Columns.Count+1; i++)
            {
                obj.Cells[1, i] = dgv.Columns[i - 1].HeaderText;
            }
            for(int i=0; i< dgv.Rows.Count; i++)
            {
                for(int j=0; j< dgv.Columns.Count; j++)
                {
                    if(dgv.Rows[i].Cells[j].Value != null)
                    {
                        obj.Cells[i + 2, j + 1] = dgv.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }
            obj.ActiveWorkbook.SaveAs(duongdan + tentep + ".xlsx");
            obj.ActiveWorkbook.Saved = true;
        }
        private void btnxuat_Click(object sender, EventArgs e)
        {

            Program.exportExcel(@"D:\","dsSP",dgv_dsSP);
            MessageBox.Show("Xuất thành công vào D:\\dsSP.xlsx");
        }

        private void dgv_dsSP_DoubleClick(object sender, EventArgs e)
        {
            var frm = new XemSP();
            
            dt = dssp.getSanPham();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i].ItemArray[0].ToString().Trim().Equals(dgv_dsSP.Rows[dgv_dsSP.CurrentRow.Index].Cells[1].Value.ToString().Trim()))
                {
                    frm.getmasp = dt.Rows[i].ItemArray[0].ToString().Trim();
                    frm.gettenSP = dt.Rows[i].ItemArray[1].ToString().Trim();
                    frm.getgiaBan = dt.Rows[i].ItemArray[2].ToString().Trim();
                    frm.getsoLuong = dt.Rows[i].ItemArray[3].ToString().Trim();
                    frm.getnhaHieu = dt.Rows[i].ItemArray[4].ToString().Trim();
                    frm.getloaiSP = dt.Rows[i].ItemArray[5].ToString().Trim();
                    frm.getnhaCungCap = dt.Rows[i].ItemArray[6].ToString().Trim();
                    frm.getmaVach = dt.Rows[i].ItemArray[7].ToString().Trim();
                    frm.getmoTa = dt.Rows[i].ItemArray[8].ToString().Trim();

                    break;
                }
            }
            frm.ShowDialog();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
