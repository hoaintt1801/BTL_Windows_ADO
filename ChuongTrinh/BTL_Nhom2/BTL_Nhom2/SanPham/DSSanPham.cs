using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_Nhom5.SanPham
{
    public partial class DSSanPham : Form
    {
        public DSSanPham()
        {
            InitializeComponent();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            var frm = new SanPham.ThemSanPham();
            frm.Show();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            var frm = new SanPham.SuaSanPham();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
