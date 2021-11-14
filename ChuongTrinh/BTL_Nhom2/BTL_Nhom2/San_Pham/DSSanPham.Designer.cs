
namespace BTL_Nhom2.San_Pham
{
    partial class DSSanPham
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_dsSP = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Giaban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtphantrang = new System.Windows.Forms.TextBox();
            this.txtgiaban = new System.Windows.Forms.TextBox();
            this.txtsl = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txttensp = new System.Windows.Forms.TextBox();
            this.txtmasp = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnthoat = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.btnthem = new FontAwesome.Sharp.IconButton();
            this.btnsua = new FontAwesome.Sharp.IconButton();
            this.btnxoa = new FontAwesome.Sharp.IconButton();
            this.btnxuat = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.cbxncc = new System.Windows.Forms.ComboBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.cbxnhanhieu = new System.Windows.Forms.ComboBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.cbxloaisp = new System.Windows.Forms.ComboBox();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.btnloc = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsSP)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv_dsSP);
            this.panel2.Controls.Add(this.txtphantrang);
            this.panel2.Controls.Add(this.txtgiaban);
            this.panel2.Controls.Add(this.txtsl);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txttensp);
            this.panel2.Controls.Add(this.txtmasp);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.btnthoat);
            this.panel2.Controls.Add(this.iconButton1);
            this.panel2.Controls.Add(this.btnthem);
            this.panel2.Controls.Add(this.btnsua);
            this.panel2.Controls.Add(this.btnxoa);
            this.panel2.Controls.Add(this.btnxuat);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(270, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(951, 588);
            this.panel2.TabIndex = 9;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // dgv_dsSP
            // 
            this.dgv_dsSP.AllowUserToAddRows = false;
            this.dgv_dsSP.AllowUserToDeleteRows = false;
            this.dgv_dsSP.AllowUserToResizeColumns = false;
            this.dgv_dsSP.AllowUserToResizeRows = false;
            this.dgv_dsSP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_dsSP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_dsSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dsSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaSP,
            this.TenSP,
            this.MaLSP,
            this.MaNH,
            this.SoLuong,
            this.Giaban,
            this.MaNCC});
            this.dgv_dsSP.Location = new System.Drawing.Point(36, 135);
            this.dgv_dsSP.Name = "dgv_dsSP";
            this.dgv_dsSP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_dsSP.Size = new System.Drawing.Size(828, 290);
            this.dgv_dsSP.TabIndex = 0;
            this.dgv_dsSP.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_dsSP_RowEnter);
            this.dgv_dsSP.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgv_dsSP_RowPrePaint);
            this.dgv_dsSP.DoubleClick += new System.EventHandler(this.dgv_dsSP_DoubleClick);
            // 
            // STT
            // 
            this.STT.DataPropertyName = "STT";
            this.STT.FillWeight = 50.0457F;
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            // 
            // MaSP
            // 
            this.MaSP.DataPropertyName = "MaSP";
            this.MaSP.FillWeight = 100.2792F;
            this.MaSP.HeaderText = "Mã sản phẩm";
            this.MaSP.Name = "MaSP";
            // 
            // TenSP
            // 
            this.TenSP.DataPropertyName = "TenSP";
            this.TenSP.FillWeight = 100.2792F;
            this.TenSP.HeaderText = "Tên sản phẩm";
            this.TenSP.Name = "TenSP";
            // 
            // MaLSP
            // 
            this.MaLSP.DataPropertyName = "MaLSP";
            this.MaLSP.FillWeight = 85.27919F;
            this.MaLSP.HeaderText = "Loại";
            this.MaLSP.Name = "MaLSP";
            // 
            // MaNH
            // 
            this.MaNH.DataPropertyName = "MaNH";
            this.MaNH.FillWeight = 85.27919F;
            this.MaNH.HeaderText = "Nhãn hiệu";
            this.MaNH.Name = "MaNH";
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.FillWeight = 85.27919F;
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.Name = "SoLuong";
            // 
            // Giaban
            // 
            this.Giaban.DataPropertyName = "Giaban";
            this.Giaban.FillWeight = 85.27919F;
            this.Giaban.HeaderText = "Giá bán";
            this.Giaban.Name = "Giaban";
            // 
            // MaNCC
            // 
            this.MaNCC.DataPropertyName = "MaNCC";
            this.MaNCC.FillWeight = 85.27919F;
            this.MaNCC.HeaderText = "Nhà cung cấp";
            this.MaNCC.Name = "MaNCC";
            // 
            // txtphantrang
            // 
            this.txtphantrang.Location = new System.Drawing.Point(36, 440);
            this.txtphantrang.Name = "txtphantrang";
            this.txtphantrang.Size = new System.Drawing.Size(217, 20);
            this.txtphantrang.TabIndex = 3;
            // 
            // txtgiaban
            // 
            this.txtgiaban.Location = new System.Drawing.Point(661, 72);
            this.txtgiaban.Name = "txtgiaban";
            this.txtgiaban.Size = new System.Drawing.Size(163, 20);
            this.txtgiaban.TabIndex = 32;
            // 
            // txtsl
            // 
            this.txtsl.Location = new System.Drawing.Point(661, 30);
            this.txtsl.Name = "txtsl";
            this.txtsl.Size = new System.Drawing.Size(163, 20);
            this.txtsl.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(549, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Giá bán";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(549, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Số lượng còn";
            // 
            // txttensp
            // 
            this.txttensp.Location = new System.Drawing.Point(268, 72);
            this.txttensp.Name = "txttensp";
            this.txttensp.Size = new System.Drawing.Size(163, 20);
            this.txttensp.TabIndex = 28;
            // 
            // txtmasp
            // 
            this.txtmasp.Location = new System.Drawing.Point(268, 30);
            this.txtmasp.Name = "txtmasp";
            this.txtmasp.Size = new System.Drawing.Size(163, 20);
            this.txtmasp.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(156, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "Tên sản phẩm";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(156, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "Mã sản phẩm";
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnthoat.FlatAppearance.BorderSize = 0;
            this.btnthoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnthoat.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnthoat.IconColor = System.Drawing.Color.White;
            this.btnthoat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnthoat.IconSize = 22;
            this.btnthoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthoat.Location = new System.Drawing.Point(748, 505);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(0);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnthoat.Size = new System.Drawing.Size(76, 30);
            this.btnthoat.TabIndex = 26;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Sync;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 25;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.iconButton1.Location = new System.Drawing.Point(75, 505);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(86, 30);
            this.iconButton1.TabIndex = 25;
            this.iconButton1.Text = "ReLoad";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // btnthem
            // 
            this.btnthem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnthem.FlatAppearance.BorderSize = 0;
            this.btnthem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnthem.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnthem.IconColor = System.Drawing.Color.White;
            this.btnthem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnthem.IconSize = 25;
            this.btnthem.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnthem.Location = new System.Drawing.Point(188, 505);
            this.btnthem.Margin = new System.Windows.Forms.Padding(0);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(126, 30);
            this.btnthem.TabIndex = 24;
            this.btnthem.Text = "Thêm sản phẩm";
            this.btnthem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnsua
            // 
            this.btnsua.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnsua.FlatAppearance.BorderSize = 0;
            this.btnsua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnsua.IconChar = FontAwesome.Sharp.IconChar.PenSquare;
            this.btnsua.IconColor = System.Drawing.Color.White;
            this.btnsua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnsua.IconSize = 25;
            this.btnsua.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnsua.Location = new System.Drawing.Point(341, 505);
            this.btnsua.Margin = new System.Windows.Forms.Padding(0);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(118, 30);
            this.btnsua.TabIndex = 23;
            this.btnsua.Text = "Sửa sản phẩm";
            this.btnsua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsua.UseVisualStyleBackColor = false;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnxoa.FlatAppearance.BorderSize = 0;
            this.btnxoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnxoa.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnxoa.IconColor = System.Drawing.Color.White;
            this.btnxoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnxoa.IconSize = 25;
            this.btnxoa.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnxoa.Location = new System.Drawing.Point(488, 505);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(0);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(119, 30);
            this.btnxoa.TabIndex = 22;
            this.btnxoa.Text = "Xóa sản phẩm";
            this.btnxoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnxoa.UseVisualStyleBackColor = false;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnxuat
            // 
            this.btnxuat.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnxuat.FlatAppearance.BorderSize = 0;
            this.btnxuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnxuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxuat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnxuat.IconChar = FontAwesome.Sharp.IconChar.FileExport;
            this.btnxuat.IconColor = System.Drawing.Color.White;
            this.btnxuat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnxuat.IconSize = 25;
            this.btnxuat.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnxuat.Location = new System.Drawing.Point(635, 505);
            this.btnxuat.Margin = new System.Windows.Forms.Padding(0);
            this.btnxuat.Name = "btnxuat";
            this.btnxuat.Size = new System.Drawing.Size(89, 30);
            this.btnxuat.TabIndex = 21;
            this.btnxuat.Text = "Xuất file";
            this.btnxuat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnxuat.UseVisualStyleBackColor = false;
            this.btnxuat.Click += new System.EventHandler(this.btnxuat_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.btnloc);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 35);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(270, 588);
            this.panel3.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Controls.Add(this.cbxncc);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.cbxnhanhieu);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.cbxloaisp);
            this.groupBox1.Controls.Add(this.txttimkiem);
            this.groupBox1.Location = new System.Drawing.Point(58, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(198, 266);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(7, 200);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(94, 17);
            this.checkBox4.TabIndex = 11;
            this.checkBox4.Text = "Nhà cung cấp";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // cbxncc
            // 
            this.cbxncc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxncc.FormattingEnabled = true;
            this.cbxncc.Location = new System.Drawing.Point(30, 220);
            this.cbxncc.Name = "cbxncc";
            this.cbxncc.Size = new System.Drawing.Size(144, 21);
            this.cbxncc.TabIndex = 12;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(7, 140);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(75, 17);
            this.checkBox3.TabIndex = 9;
            this.checkBox3.Text = "Nhãn hiệu";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // cbxnhanhieu
            // 
            this.cbxnhanhieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxnhanhieu.FormattingEnabled = true;
            this.cbxnhanhieu.Location = new System.Drawing.Point(30, 160);
            this.cbxnhanhieu.Name = "cbxnhanhieu";
            this.cbxnhanhieu.Size = new System.Drawing.Size(144, 21);
            this.cbxnhanhieu.TabIndex = 10;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(7, 78);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(95, 17);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "Loại sản phẩm";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(7, 23);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(112, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Thông tin tìm kiếm";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // cbxloaisp
            // 
            this.cbxloaisp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxloaisp.FormattingEnabled = true;
            this.cbxloaisp.Location = new System.Drawing.Point(30, 98);
            this.cbxloaisp.Name = "cbxloaisp";
            this.cbxloaisp.Size = new System.Drawing.Size(144, 21);
            this.cbxloaisp.TabIndex = 8;
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(30, 42);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(144, 20);
            this.txttimkiem.TabIndex = 2;
            // 
            // btnloc
            // 
            this.btnloc.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnloc.FlatAppearance.BorderSize = 0;
            this.btnloc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnloc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnloc.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnloc.IconColor = System.Drawing.Color.White;
            this.btnloc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnloc.IconSize = 20;
            this.btnloc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnloc.Location = new System.Drawing.Point(86, 422);
            this.btnloc.Name = "btnloc";
            this.btnloc.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnloc.Size = new System.Drawing.Size(111, 38);
            this.btnloc.TabIndex = 12;
            this.btnloc.Text = "Tìm kiếm";
            this.btnloc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnloc.UseVisualStyleBackColor = false;
            this.btnloc.Click += new System.EventHandler(this.btnloc_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tìm kiếm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sản Phẩm";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1221, 35);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // DSSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 623);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "DSSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DSSanPham";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DSSanPham_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsSP)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnthoat;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.TextBox txtphantrang;
        private FontAwesome.Sharp.IconButton btnthem;
        private FontAwesome.Sharp.IconButton btnsua;
        private FontAwesome.Sharp.IconButton btnxoa;
        private FontAwesome.Sharp.IconButton btnxuat;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.ComboBox cbxncc;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.ComboBox cbxnhanhieu;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox cbxloaisp;
        private System.Windows.Forms.TextBox txttimkiem;
        private FontAwesome.Sharp.IconButton btnloc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtgiaban;
        private System.Windows.Forms.TextBox txtsl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txttensp;
        private System.Windows.Forms.TextBox txtmasp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgv_dsSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Giaban;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNCC;
    }
}