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
    public partial class Dialog_ChietKhau : Form
    {
        double ck = 0, tongTien;
        bool check = false;

        public Dialog_ChietKhau()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ApDung_Click(object sender, EventArgs e)
        {
            try
            {
                if (rdoPhanTram.Checked)
                {
                    ck = Double.Parse(txtChietKhau.Text);
                    if (ck > 100)
                    {
                        MessageBox.Show("Chiết khấu lớn hơn đơn hàng");
                    }
                    else if (ck < 0)
                    {
                        MessageBox.Show("Chiết khấu không hợp lệ");
                    }
                    else
                    {
                        ck = Double.Parse(txtChietKhau.Text) / 100 * tongTien;
                        check = true;
                        this.Close();
                    }

                }
                else if (rdoTien.Checked)
                {
                    ck = Double.Parse(txtChietKhau.Text);
                    if (ck > tongTien)
                    {
                        MessageBox.Show("Chiết khấu lớn hơn đơn hàng");
                    }
                    else if (ck < 0)
                    {
                        MessageBox.Show("Chiết khấu không hợp lệ");
                    }
                    else
                    {
                        ck = Double.Parse(txtChietKhau.Text);
                        check = true;
                        this.Close();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập lại");
            }

        }
        public double getCK
        {
            get
            {
                return ck;
            }
            set
            {
                ck = value;
            }
        }
        public bool getCheck
        {
            get
            {
                return check;
            }
            set
            {
                check = value;
            }
        }

        private void Dialog_ChietKhau_Load(object sender, EventArgs e)
        {

        }

        public double getTongTien
        {
            get
            {
                return tongTien;
            }
            set
            {
                tongTien = value;
            }
        }
    }
}
