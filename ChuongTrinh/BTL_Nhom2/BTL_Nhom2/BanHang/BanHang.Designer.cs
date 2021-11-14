
namespace BTL_Nhom2
{
    partial class BanHang
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThemSP = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTimKiem = new FontAwesome.Sharp.IconButton();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Xoa = new FontAwesome.Sharp.IconButton();
            this.list_DonHang = new System.Windows.Forms.ListBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnThemDH = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtTienPhaiTra = new System.Windows.Forms.Label();
            this.txtChietKhau = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.Label();
            this.cbxhttt = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_KH = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnThanhToan = new FontAwesome.Sharp.IconButton();
            this.dgv_SP = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SP)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnThemSP);
            this.panel1.Controls.Add(this.iconButton3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Controls.Add(this.txtTK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1034, 77);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnThemSP
            // 
            this.btnThemSP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThemSP.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnThemSP.FlatAppearance.BorderSize = 0;
            this.btnThemSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemSP.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnThemSP.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnThemSP.IconColor = System.Drawing.Color.White;
            this.btnThemSP.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThemSP.IconSize = 25;
            this.btnThemSP.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnThemSP.Location = new System.Drawing.Point(543, 25);
            this.btnThemSP.Margin = new System.Windows.Forms.Padding(0);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.Size = new System.Drawing.Size(151, 30);
            this.btnThemSP.TabIndex = 25;
            this.btnThemSP.Text = "Thêm sản phẩm";
            this.btnThemSP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemSP.UseVisualStyleBackColor = false;
            this.btnThemSP.Click += new System.EventHandler(this.btnThemSP_Click);
            // 
            // iconButton3
            // 
            this.iconButton3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.iconButton3.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.iconButton3.IconColor = System.Drawing.Color.White;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 25;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.iconButton3.Location = new System.Drawing.Point(715, 25);
            this.iconButton3.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(102, 30);
            this.iconButton3.TabIndex = 23;
            this.iconButton3.Text = "Quét mã";
            this.iconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton3.UseVisualStyleBackColor = false;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bán Hàng";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnTimKiem.IconColor = System.Drawing.Color.Black;
            this.btnTimKiem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTimKiem.IconSize = 20;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTimKiem.Location = new System.Drawing.Point(483, 28);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(0);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(28, 24);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTK
            // 
            this.txtTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTK.Location = new System.Drawing.Point(252, 27);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(260, 26);
            this.txtTK.TabIndex = 0;
            this.txtTK.Text = "Nhập sản phẩm";
            this.txtTK.Click += new System.EventHandler(this.txtTK_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_Xoa);
            this.panel2.Controls.Add(this.list_DonHang);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(201, 414);
            this.panel2.TabIndex = 7;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Xoa.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_Xoa.FlatAppearance.BorderSize = 0;
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Xoa.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btn_Xoa.IconColor = System.Drawing.Color.White;
            this.btn_Xoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Xoa.IconSize = 22;
            this.btn_Xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Xoa.Location = new System.Drawing.Point(64, 309);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btn_Xoa.Size = new System.Drawing.Size(73, 39);
            this.btn_Xoa.TabIndex = 129;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // list_DonHang
            // 
            this.list_DonHang.BackColor = System.Drawing.SystemColors.Control;
            this.list_DonHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_DonHang.FormattingEnabled = true;
            this.list_DonHang.ItemHeight = 25;
            this.list_DonHang.Location = new System.Drawing.Point(31, 56);
            this.list_DonHang.Name = "list_DonHang";
            this.list_DonHang.Size = new System.Drawing.Size(164, 329);
            this.list_DonHang.TabIndex = 5;
            this.list_DonHang.SelectedIndexChanged += new System.EventHandler(this.list_DonHang_SelectedIndexChanged);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnThemDH);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(201, 50);
            this.panel5.TabIndex = 4;
            // 
            // btnThemDH
            // 
            this.btnThemDH.FlatAppearance.BorderSize = 0;
            this.btnThemDH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemDH.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnThemDH.IconColor = System.Drawing.Color.Black;
            this.btnThemDH.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnThemDH.IconSize = 30;
            this.btnThemDH.Location = new System.Drawing.Point(111, 10);
            this.btnThemDH.Margin = new System.Windows.Forms.Padding(0);
            this.btnThemDH.Name = "btnThemDH";
            this.btnThemDH.Size = new System.Drawing.Size(44, 35);
            this.btnThemDH.TabIndex = 1;
            this.btnThemDH.UseVisualStyleBackColor = true;
            this.btnThemDH.Click += new System.EventHandler(this.btnThemDH_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Đơn hàng";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtTienPhaiTra);
            this.panel3.Controls.Add(this.txtChietKhau);
            this.panel3.Controls.Add(this.txtTongTien);
            this.panel3.Controls.Add(this.cbxhttt);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.cb_KH);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.btnThanhToan);
            this.panel3.Controls.Add(this.dgv_SP);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(201, 77);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(833, 414);
            this.panel3.TabIndex = 8;
            // 
            // txtTienPhaiTra
            // 
            this.txtTienPhaiTra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTienPhaiTra.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtTienPhaiTra.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtTienPhaiTra.Location = new System.Drawing.Point(651, 252);
            this.txtTienPhaiTra.Margin = new System.Windows.Forms.Padding(0);
            this.txtTienPhaiTra.Name = "txtTienPhaiTra";
            this.txtTienPhaiTra.Padding = new System.Windows.Forms.Padding(1);
            this.txtTienPhaiTra.Size = new System.Drawing.Size(143, 22);
            this.txtTienPhaiTra.TabIndex = 15;
            this.txtTienPhaiTra.Text = "0";
            this.txtTienPhaiTra.Click += new System.EventHandler(this.txtChietKhau_Click);
            // 
            // txtChietKhau
            // 
            this.txtChietKhau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtChietKhau.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtChietKhau.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtChietKhau.Location = new System.Drawing.Point(651, 144);
            this.txtChietKhau.Margin = new System.Windows.Forms.Padding(0);
            this.txtChietKhau.Name = "txtChietKhau";
            this.txtChietKhau.Padding = new System.Windows.Forms.Padding(1);
            this.txtChietKhau.Size = new System.Drawing.Size(143, 22);
            this.txtChietKhau.TabIndex = 14;
            this.txtChietKhau.Text = "0";
            this.txtChietKhau.Click += new System.EventHandler(this.txtChietKhau_Click);
            // 
            // txtTongTien
            // 
            this.txtTongTien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTongTien.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtTongTien.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtTongTien.Location = new System.Drawing.Point(651, 93);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(0);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Padding = new System.Windows.Forms.Padding(1);
            this.txtTongTien.Size = new System.Drawing.Size(143, 22);
            this.txtTongTien.TabIndex = 13;
            this.txtTongTien.Text = "0";
            // 
            // cbxhttt
            // 
            this.cbxhttt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxhttt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxhttt.FormattingEnabled = true;
            this.cbxhttt.Location = new System.Drawing.Point(651, 194);
            this.cbxhttt.Name = "cbxhttt";
            this.cbxhttt.Size = new System.Drawing.Size(143, 24);
            this.cbxhttt.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(648, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 18);
            this.label7.TabIndex = 11;
            this.label7.Text = "Hình thức thanh toán";
            // 
            // cb_KH
            // 
            this.cb_KH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_KH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_KH.FormattingEnabled = true;
            this.cb_KH.Location = new System.Drawing.Point(651, 36);
            this.cb_KH.Name = "cb_KH";
            this.cb_KH.Size = new System.Drawing.Size(143, 24);
            this.cb_KH.TabIndex = 10;
            this.cb_KH.Click += new System.EventHandler(this.cb_KH_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(648, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Khách hàng";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThanhToan.BackColor = System.Drawing.Color.OrangeRed;
            this.btnThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThanhToan.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnThanhToan.IconColor = System.Drawing.Color.Black;
            this.btnThanhToan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThanhToan.Location = new System.Drawing.Point(651, 297);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(143, 80);
            this.btnThanhToan.TabIndex = 8;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // dgv_SP
            // 
            this.dgv_SP.AllowUserToAddRows = false;
            this.dgv_SP.AllowUserToDeleteRows = false;
            this.dgv_SP.AllowUserToResizeColumns = false;
            this.dgv_SP.AllowUserToResizeRows = false;
            this.dgv_SP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_SP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SP.Location = new System.Drawing.Point(28, 6);
            this.dgv_SP.Name = "dgv_SP";
            this.dgv_SP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_SP.Size = new System.Drawing.Size(580, 393);
            this.dgv_SP.TabIndex = 6;
            this.dgv_SP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_SP_CellClick);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(648, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tiền phải trả";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(648, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tổng tiền";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(648, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Chiết khấu";
            // 
            // BanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1034, 491);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "BanHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BanHang";
            this.Load += new System.EventHandler(this.BanHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnThemSP;
        private FontAwesome.Sharp.IconButton iconButton3;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnTimKiem;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox list_DonHang;
        private System.Windows.Forms.Panel panel5;
        private FontAwesome.Sharp.IconButton btnThemDH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cb_KH;
        private System.Windows.Forms.Label label6;
        private FontAwesome.Sharp.IconButton btnThanhToan;
        private System.Windows.Forms.DataGridView dgv_SP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxhttt;
        private System.Windows.Forms.Label label7;
        private FontAwesome.Sharp.IconButton btn_Xoa;
        private System.Windows.Forms.Label txtTienPhaiTra;
        private System.Windows.Forms.Label txtChietKhau;
        private System.Windows.Forms.Label txtTongTien;
    }
}