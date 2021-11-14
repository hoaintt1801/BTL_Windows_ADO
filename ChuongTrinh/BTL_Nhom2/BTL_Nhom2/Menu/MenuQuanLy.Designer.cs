
namespace BTL_Nhom2
{
    partial class MenuQuanLy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuQuanLy));
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuQL = new System.Windows.Forms.MenuStrip();
            this.IMTrangChu = new System.Windows.Forms.ToolStripMenuItem();
            this.IMBanHang = new System.Windows.Forms.ToolStripMenuItem();
            this.IMSanPham = new System.Windows.Forms.ToolStripMenuItem();
            this.IMDSSanPham = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýKhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhàCungCấpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IMQuanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IMGiaoDich = new System.Windows.Forms.ToolStripMenuItem();
            this.phiếuThuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phiếuChiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sổQuỹToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IMBaoCao = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoTàiChínhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoTồnKhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IMDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.vềChúngTôiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.menuQL.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuQL);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1034, 43);
            this.panel1.TabIndex = 0;
            // 
            // menuQL
            // 
            this.menuQL.AutoSize = false;
            this.menuQL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.menuQL.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuQL.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IMTrangChu,
            this.IMBanHang,
            this.IMSanPham,
            this.IMQuanLy,
            this.IMGiaoDich,
            this.IMBaoCao,
            this.IMDangXuat,
            this.vềChúngTôiToolStripMenuItem});
            this.menuQL.Location = new System.Drawing.Point(0, 0);
            this.menuQL.Name = "menuQL";
            this.menuQL.Padding = new System.Windows.Forms.Padding(10, 3, 0, 0);
            this.menuQL.Size = new System.Drawing.Size(1034, 43);
            this.menuQL.TabIndex = 0;
            this.menuQL.Text = "menuStrip1";
            // 
            // IMTrangChu
            // 
            this.IMTrangChu.ForeColor = System.Drawing.Color.Black;
            this.IMTrangChu.Name = "IMTrangChu";
            this.IMTrangChu.Size = new System.Drawing.Size(89, 40);
            this.IMTrangChu.Text = "Trang chủ";
            this.IMTrangChu.Click += new System.EventHandler(this.IMTrangChu_Click);
            // 
            // IMBanHang
            // 
            this.IMBanHang.ForeColor = System.Drawing.Color.Black;
            this.IMBanHang.Name = "IMBanHang";
            this.IMBanHang.Size = new System.Drawing.Size(86, 40);
            this.IMBanHang.Text = "Bán hàng";
            this.IMBanHang.Click += new System.EventHandler(this.IMBanHang_Click);
            // 
            // IMSanPham
            // 
            this.IMSanPham.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IMDSSanPham,
            this.quảnLýKhoToolStripMenuItem,
            this.nhàCungCấpToolStripMenuItem});
            this.IMSanPham.ForeColor = System.Drawing.Color.Black;
            this.IMSanPham.Name = "IMSanPham";
            this.IMSanPham.Size = new System.Drawing.Size(89, 40);
            this.IMSanPham.Text = "Sản phẩm";
            this.IMSanPham.Click += new System.EventHandler(this.IMSanPham_Click);
            // 
            // IMDSSanPham
            // 
            this.IMDSSanPham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.IMDSSanPham.Name = "IMDSSanPham";
            this.IMDSSanPham.Size = new System.Drawing.Size(219, 24);
            this.IMDSSanPham.Text = "Danh sách sản phẩm";
            this.IMDSSanPham.Click += new System.EventHandler(this.IMDSSP_Click);
            // 
            // quảnLýKhoToolStripMenuItem
            // 
            this.quảnLýKhoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.quảnLýKhoToolStripMenuItem.Name = "quảnLýKhoToolStripMenuItem";
            this.quảnLýKhoToolStripMenuItem.Size = new System.Drawing.Size(219, 24);
            this.quảnLýKhoToolStripMenuItem.Text = "Hàng Nhập";
            this.quảnLýKhoToolStripMenuItem.Click += new System.EventHandler(this.quảnLýKhoToolStripMenuItem_Click);
            // 
            // nhàCungCấpToolStripMenuItem
            // 
            this.nhàCungCấpToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.nhàCungCấpToolStripMenuItem.Name = "nhàCungCấpToolStripMenuItem";
            this.nhàCungCấpToolStripMenuItem.Size = new System.Drawing.Size(219, 24);
            this.nhàCungCấpToolStripMenuItem.Text = "Nhà cung cấp";
            this.nhàCungCấpToolStripMenuItem.Click += new System.EventHandler(this.nhàCungCấpToolStripMenuItem_Click);
            // 
            // IMQuanLy
            // 
            this.IMQuanLy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tàiKhoảnToolStripMenuItem,
            this.hóaĐơnToolStripMenuItem,
            this.kháchHàngToolStripMenuItem,
            this.nhânViênToolStripMenuItem});
            this.IMQuanLy.ForeColor = System.Drawing.Color.Black;
            this.IMQuanLy.Name = "IMQuanLy";
            this.IMQuanLy.Size = new System.Drawing.Size(74, 40);
            this.IMQuanLy.Text = "Quản lý";
            this.IMQuanLy.Click += new System.EventHandler(this.IMQuanLy_Click);
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.tàiKhoảnToolStripMenuItem.Text = "Tài khoản";
            this.tàiKhoảnToolStripMenuItem.Click += new System.EventHandler(this.tàiKhoảnToolStripMenuItem_Click);
            // 
            // hóaĐơnToolStripMenuItem
            // 
            this.hóaĐơnToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.hóaĐơnToolStripMenuItem.Name = "hóaĐơnToolStripMenuItem";
            this.hóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.hóaĐơnToolStripMenuItem.Text = "Hóa đơn";
            this.hóaĐơnToolStripMenuItem.Click += new System.EventHandler(this.hóaĐơnToolStripMenuItem_Click);
            // 
            // kháchHàngToolStripMenuItem
            // 
            this.kháchHàngToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            this.kháchHàngToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.kháchHàngToolStripMenuItem.Text = "Khách hàng";
            this.kháchHàngToolStripMenuItem.Click += new System.EventHandler(this.kháchHàngToolStripMenuItem_Click);
            // 
            // nhânViênToolStripMenuItem
            // 
            this.nhânViênToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            this.nhânViênToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.nhânViênToolStripMenuItem.Text = "Nhân Viên";
            this.nhânViênToolStripMenuItem.Click += new System.EventHandler(this.nhânViênToolStripMenuItem_Click);
            // 
            // IMGiaoDich
            // 
            this.IMGiaoDich.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.phiếuThuToolStripMenuItem,
            this.phiếuChiToolStripMenuItem,
            this.sổQuỹToolStripMenuItem});
            this.IMGiaoDich.ForeColor = System.Drawing.Color.Black;
            this.IMGiaoDich.Name = "IMGiaoDich";
            this.IMGiaoDich.Size = new System.Drawing.Size(85, 40);
            this.IMGiaoDich.Text = "Giao dịch";
            this.IMGiaoDich.Click += new System.EventHandler(this.IMGiaoDich_Click);
            // 
            // phiếuThuToolStripMenuItem
            // 
            this.phiếuThuToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.phiếuThuToolStripMenuItem.Name = "phiếuThuToolStripMenuItem";
            this.phiếuThuToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.phiếuThuToolStripMenuItem.Text = "Phiếu thu";
            this.phiếuThuToolStripMenuItem.Click += new System.EventHandler(this.phiếuThuToolStripMenuItem_Click);
            // 
            // phiếuChiToolStripMenuItem
            // 
            this.phiếuChiToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.phiếuChiToolStripMenuItem.Name = "phiếuChiToolStripMenuItem";
            this.phiếuChiToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.phiếuChiToolStripMenuItem.Text = "Phiếu chi";
            this.phiếuChiToolStripMenuItem.Click += new System.EventHandler(this.phiếuChiToolStripMenuItem_Click);
            // 
            // sổQuỹToolStripMenuItem
            // 
            this.sổQuỹToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.sổQuỹToolStripMenuItem.Name = "sổQuỹToolStripMenuItem";
            this.sổQuỹToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.sổQuỹToolStripMenuItem.Text = "Sổ quỹ";
            this.sổQuỹToolStripMenuItem.Click += new System.EventHandler(this.sổQuỹToolStripMenuItem_Click);
            // 
            // IMBaoCao
            // 
            this.IMBaoCao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.báoCáoTàiChínhToolStripMenuItem,
            this.báoCáoTồnKhoToolStripMenuItem});
            this.IMBaoCao.ForeColor = System.Drawing.Color.Black;
            this.IMBaoCao.Name = "IMBaoCao";
            this.IMBaoCao.Size = new System.Drawing.Size(75, 40);
            this.IMBaoCao.Text = "Báo cáo";
            this.IMBaoCao.Click += new System.EventHandler(this.IMBaoCao_Click);
            // 
            // báoCáoTàiChínhToolStripMenuItem
            // 
            this.báoCáoTàiChínhToolStripMenuItem.Name = "báoCáoTàiChínhToolStripMenuItem";
            this.báoCáoTàiChínhToolStripMenuItem.Size = new System.Drawing.Size(201, 24);
            this.báoCáoTàiChínhToolStripMenuItem.Text = "Báo Cáo Tài Chính";
            this.báoCáoTàiChínhToolStripMenuItem.Click += new System.EventHandler(this.báoCáoTàiChínhToolStripMenuItem_Click);
            // 
            // báoCáoTồnKhoToolStripMenuItem
            // 
            this.báoCáoTồnKhoToolStripMenuItem.Name = "báoCáoTồnKhoToolStripMenuItem";
            this.báoCáoTồnKhoToolStripMenuItem.Size = new System.Drawing.Size(201, 24);
            this.báoCáoTồnKhoToolStripMenuItem.Text = "Báo cáo tồn kho";
            this.báoCáoTồnKhoToolStripMenuItem.Click += new System.EventHandler(this.báoCáoTồnKhoToolStripMenuItem_Click);
            // 
            // IMDangXuat
            // 
            this.IMDangXuat.ForeColor = System.Drawing.Color.Black;
            this.IMDangXuat.Name = "IMDangXuat";
            this.IMDangXuat.Size = new System.Drawing.Size(92, 40);
            this.IMDangXuat.Text = "Đăng xuất";
            this.IMDangXuat.Click += new System.EventHandler(this.IMDangXuat_Click);
            // 
            // vềChúngTôiToolStripMenuItem
            // 
            this.vềChúngTôiToolStripMenuItem.Name = "vềChúngTôiToolStripMenuItem";
            this.vềChúngTôiToolStripMenuItem.Size = new System.Drawing.Size(108, 40);
            this.vềChúngTôiToolStripMenuItem.Text = "Về chúng tôi";
            this.vềChúngTôiToolStripMenuItem.Click += new System.EventHandler(this.vềChúngTôiToolStripMenuItem_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackgroundImage = global::BTL_Nhom2.Properties.Resources.f25cfe668dcd789321dc;
            this.pnlMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMenu.Location = new System.Drawing.Point(0, 43);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(1034, 568);
            this.pnlMenu.TabIndex = 2;
            // 
            // MenuQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1034, 611);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuQL;
            this.Name = "MenuQuanLy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuQuanLy";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MenuQuanLy_Load);
            this.panel1.ResumeLayout(false);
            this.menuQL.ResumeLayout(false);
            this.menuQL.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuQL;
        private System.Windows.Forms.ToolStripMenuItem IMTrangChu;
        private System.Windows.Forms.ToolStripMenuItem IMBanHang;
        private System.Windows.Forms.ToolStripMenuItem IMSanPham;
        private System.Windows.Forms.ToolStripMenuItem IMDSSanPham;
        private System.Windows.Forms.ToolStripMenuItem quảnLýKhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhàCungCấpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem IMQuanLy;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem IMGiaoDich;
        private System.Windows.Forms.ToolStripMenuItem phiếuThuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phiếuChiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sổQuỹToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem IMBaoCao;
        private System.Windows.Forms.ToolStripMenuItem báoCáoTàiChínhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoTồnKhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem IMDangXuat;
        private System.Windows.Forms.ToolStripMenuItem vềChúngTôiToolStripMenuItem;
        private System.Windows.Forms.Panel pnlMenu;
    }
}