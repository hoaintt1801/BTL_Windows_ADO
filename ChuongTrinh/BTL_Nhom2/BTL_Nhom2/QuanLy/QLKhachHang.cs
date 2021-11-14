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

namespace BTL_Nhom2.QuanLy
{
    public partial class QLKhachHang : Form
    {
        bool them;
        Bus_ID Bus_ID = new Bus_ID();
        public QLKhachHang()
        {
            InitializeComponent();
        }

        private void QLKhachHang_Load(object sender, EventArgs e)
        {
            LoadComboNKH();
            LoadKhachHang();
            LoadNKHTK();
            txtphantrang.Text = "Tổng số khách hàng là " + dgv_dsKH.RowCount;
            this.btnluu.Enabled = false;
            this.btnhuy.Enabled = false;
            this.btnthem.Enabled = true;
            this.btnsua.Enabled = true;
            this.btnxoa.Enabled = true;
            this.btnthoat.Enabled = true;
            this.btnxuat.Enabled = true;
           

        }
        public string hasNKH(string str, bool kt)
        {
            string tr = "";
            if (kt)
            {
                dbDataContext db = new dbDataContext();
                var nxb = from n in db.NhomKHs where n.MaNKH.Trim().Equals(str.Trim()) select n.TenNKH;
                tr = nxb.FirstOrDefault().ToString();
            }
            else
            {
                dbDataContext db = new dbDataContext();
                var nxb = from n in db.NhomKHs where n.TenNKH.Trim().Equals(str.Trim()) select n.MaNKH;
                tr = nxb.FirstOrDefault().ToString();
            }
            return tr;
        }
        public void LoadKhachHang()
        {
            dbDataContext db = new dbDataContext();
            var kh = from k in db.KhachHangs
                     join n in db.NhomKHs on k.MaNKH equals n.MaNKH
                     select new { k.MaKH , k.HoTen, k.DiaChi, k.Sdt, MaNKH = n.TenNKH };
            dgv_dsKH.DataSource = kh;

            for (int i = 0; i < dgv_dsKH.Columns.Count; i++)
            {
                dgv_dsKH.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            /*
            for(int i=0; i<dgv_dsKH.Rows.Count; i++) {
                dgv_dsKH.Rows[i].Cells[4].Value = hasNKH(dgv_dsKH.Rows[i].Cells[4].Value.ToString().Trim(),true);    
            }*/
        }
        
        public void LoadComboNKH()
        {
            dbDataContext db = new dbDataContext();
            var nkh = from kt in db.NhomKHs
                     select kt;
            cbxnhomkh.DataSource = nkh;
            cbxnhomkh.DisplayMember = "TenNKH";
            cbxnhomkh.ValueMember = "MaNKH";

        }
        public void LoadNKHTK()
        {
            dbDataContext db = new dbDataContext();
            var nkh = from kt in db.NhomKHs
                      select kt;
            cbxnkh.DataSource = nkh;
            cbxnkh.DisplayMember = "TenNKH";
            cbxnkh.ValueMember = "MaNKH";
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            them = true;
            string a = Bus_ID.getTableID(3).Rows[0].ItemArray[0].ToString().Trim();
            string MaKH = "KH" + a;
            this.txtmakh.Text=MaKH;
            this.txttenkh.ResetText();
            this.txtsodt.ResetText();
            this.txtdiachi.ResetText();
            LoadComboNKH();
            this.btnluu.Enabled = true;
            this.btnhuy.Enabled = true;
            this.btnthem.Enabled = false;
            this.btnsua.Enabled = false;
            this.btnxoa.Enabled = false;
            this.btnthoat.Enabled = false;
            this.btnxuat.Enabled = false;
            this.txtmakh.Focus();
        }

        private void dgv_dsKH_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txtmakh.Text = dgv_dsKH.Rows[dong].Cells[0].Value.ToString();
            txttenkh.Text = dgv_dsKH.Rows[dong].Cells[1].Value.ToString();
            txtdiachi.Text = dgv_dsKH.Rows[dong].Cells[2].Value.ToString();
            txtsodt.Text = dgv_dsKH.Rows[dong].Cells[3].Value.ToString();
           
            cbxnhomkh.SelectedValue = hasNKH(dgv_dsKH.Rows[dong].Cells[4].Value.ToString(),false);
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            them = false;
            this.btnluu.Enabled = true;
            this.btnhuy.Enabled = true;
            this.btnthem.Enabled = false;
            this.btnsua.Enabled = false;
            this.btnxoa.Enabled = false;
            this.btnthoat.Enabled = false;
            this.btnxuat.Enabled = false;
            this.txttenkh.Focus();
            this.txtmakh.Enabled = false;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtmakh.TextLength == 0)
                    MessageBox.Show("Không được bỏ trống Mã khách hàng");
                if (txtmakh.TextLength == 0)
                    MessageBox.Show("Không được bỏ trống Tên khách hàng");
                else if (them)
                {
                    bool kt = false;
                    dbDataContext db = new dbDataContext();
                    var tb = from k in db.KhachHangs select k;
                    foreach (var item in tb)
                    {
                        if (item.MaKH.Trim().Equals(txtmakh.Text.Trim()))
                        {
                            kt = true;
                            break;
                        }
                    }
                    if (kt)
                    {
                        MessageBox.Show("MaKH đã tồn tại");
                    }
                    else
                    {
                        DialogResult tl = MessageBox.Show("Bạn có chắc chắn muốn thêm sản phẩm này không?", "Thông báo", MessageBoxButtons.YesNo);
                        if (tl == DialogResult.Yes)
                        {
                            KhachHang them = new KhachHang();
                            them.MaKH = txtmakh.Text.Trim();
                            them.HoTen = txttenkh.Text.ToString();
                            them.Sdt = txtsodt.Text;
                            them.DiaChi = txtdiachi.Text.ToString();
                            them.MaNKH = cbxnhomkh.SelectedValue.ToString();
                            db.KhachHangs.InsertOnSubmit(them);
                            db.SubmitChanges();
                            QLKhachHang_Load(sender, e);
                            MessageBox.Show("Bạn đã thêm thành công");
                            Bus_ID.updateID(3);
                        }
                    }

                }
                else if (!them)
                {


                    DialogResult tl = MessageBox.Show("Bạn có chắc chắn muốn sửa sản phẩm này không?", "Thông báo", MessageBoxButtons.YesNo);
                    if (tl == DialogResult.Yes)
                    {
                        dbDataContext db = new dbDataContext();
                        int r = dgv_dsKH.CurrentCell.RowIndex;
                        string strmakh = dgv_dsKH.Rows[r].Cells[0].Value.ToString();
                        var capnhat = db.KhachHangs.Single(kh => kh.MaKH == strmakh);
                        //capnhat.MaKH = txtmakh.Text.Trim();
                        capnhat.HoTen = txttenkh.Text.ToString();
                        capnhat.Sdt = txtsodt.Text.ToString();
                        capnhat.DiaChi = txtdiachi.Text.ToString();
                        capnhat.MaNKH = cbxnhomkh.SelectedValue.ToString();
                        db.SubmitChanges();
                        QLKhachHang_Load(sender, e);
                        MessageBox.Show("Bạn đã sửa thành công");
                    }


                }
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
                DialogResult tl = MessageBox.Show("Bạn có chắc chắn muốn xoa sản phẩm này không?", "Thông báo", MessageBoxButtons.YesNo);
                if (tl == DialogResult.Yes)
                {
                    dbDataContext db = new dbDataContext();
                    var xoa = from kh in db.KhachHangs
                              where kh.MaKH == txtmakh.Text
                              select kh;
                    foreach (var i in xoa)
                    {
                        db.KhachHangs.DeleteOnSubmit(i);
                        db.SubmitChanges();
                    }
                    QLKhachHang_Load(sender, e);
                    MessageBox.Show("Xóa thành công");
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng thực hiện lại");
            }
                
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            DialogResult tl = MessageBox.Show("Bạn có chắc chắn muốn hủy?", "Thông báo", MessageBoxButtons.YesNo);
            if (tl == DialogResult.Yes)
            {
                QLKhachHang_Load(sender, e);
                this.btnluu.Enabled = false;
                this.btnhuy.Enabled = false;
                this.btnthem.Enabled = true;
                this.btnsua.Enabled = true;
                this.btnxoa.Enabled = true;
                this.btnthoat.Enabled = true;
                this.btnxuat.Enabled = true;
            }
          
           
        }

        private void btntimkhiem_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                if (txtthongtin.TextLength == 0)
                    MessageBox.Show("Bạn chưa nhập thông tin tìm kiếm");
                else
                {
                    dbDataContext db = new dbDataContext();
                    var dt = from k in db.KhachHangs
                             join n in db.NhomKHs on k.MaNKH equals n.MaNKH

                             where k.MaKH.Contains(txtthongtin.Text) || k.HoTen.Contains(txtthongtin.Text)
                                            || k.DiaChi.Contains(txtthongtin.Text)
                             select new { k.MaKH, k.HoTen, k.DiaChi, k.Sdt, MaNKH = n.TenNKH };
                    dgv_dsKH.DataSource = dt;
                    //QLKhachHang_Load(sender, e);
                    //LoadKhachHang();

                }

            }
            else if (radioButton2.Checked){
                dbDataContext db = new dbDataContext();
                var dt = from k in db.KhachHangs
                         join n in db.NhomKHs on k.MaNKH equals n.MaNKH
                         where k.MaNKH.Equals(cbxnkh.SelectedValue.ToString().Trim())
                         select new { k.MaKH, k.HoTen, k.DiaChi, k.Sdt, MaNKH = n.TenNKH };
                dgv_dsKH.DataSource = dt;
               // QLKhachHang_Load(sender, e);
            }
            txtphantrang.Text = "Tổng số Khách hàng " + dgv_dsKH.Rows.Count.ToString();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult tl = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông báo?", MessageBoxButtons.YesNo);
            if (tl == DialogResult.Yes)
                this.Close();
        }

        private void txtthongtin_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == false)
            {
                radioButton1.Checked = true;
            }
        }

        private void cbxnkh_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked == false)
            {
                radioButton2.Checked = true;
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            QLKhachHang_Load(sender,e);
            txtthongtin.Clear();
        }

        private void btnnhaplai_Click(object sender, EventArgs e)
        {
            string a = Bus_ID.getTableID(3).Rows[0].ItemArray[0].ToString().Trim();
            string MaKH = "KH" + a;
            this.txtmakh.Text = MaKH;
            txtmakh.Text = MaKH;
            txttenkh.Clear();
            txtdiachi.Clear();
            txtsodt.Clear();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnxuat_Click(object sender, EventArgs e)
        {
            Program.exportExcel(@"D:\", "dsKH", dgv_dsKH);
            MessageBox.Show("Xuất thành công vào D:\\dsKH.xlsx");
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
