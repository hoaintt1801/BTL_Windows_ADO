
namespace BTL_Nhom2
{
    partial class CTHD
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
            this.btnNhapLai = new FontAwesome.Sharp.IconButton();
            this.btnThem = new FontAwesome.Sharp.IconButton();
            this.groupBox_TTChung = new System.Windows.Forms.GroupBox();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.cmbTenKH = new System.Windows.Forms.ComboBox();
            this.cmbHTTT = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cmbTenNV = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.dtpNgayLap = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.btnThoat = new FontAwesome.Sharp.IconButton();
            this.dgv_ChiTietHD = new System.Windows.Forms.DataGridView();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nudSoLuong = new System.Windows.Forms.NumericUpDown();
            this.cmbTenSP = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox_TTMatHang = new System.Windows.Forms.GroupBox();
            this.btnThemSP = new FontAwesome.Sharp.IconButton();
            this.btnXoa = new FontAwesome.Sharp.IconButton();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox_TTChung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ChiTietHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).BeginInit();
            this.groupBox_TTMatHang.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNhapLai
            // 
            this.btnNhapLai.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnNhapLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapLai.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNhapLai.IconChar = FontAwesome.Sharp.IconChar.Sync;
            this.btnNhapLai.IconColor = System.Drawing.Color.White;
            this.btnNhapLai.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNhapLai.IconSize = 20;
            this.btnNhapLai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhapLai.Location = new System.Drawing.Point(413, 533);
            this.btnNhapLai.Name = "btnNhapLai";
            this.btnNhapLai.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnNhapLai.Size = new System.Drawing.Size(99, 38);
            this.btnNhapLai.TabIndex = 146;
            this.btnNhapLai.Text = "Nhập lại";
            this.btnNhapLai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNhapLai.UseVisualStyleBackColor = false;
            this.btnNhapLai.Click += new System.EventHandler(this.btnNhapLai_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnThem.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnThem.IconColor = System.Drawing.Color.White;
            this.btnThem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThem.IconSize = 22;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(234, 532);
            this.btnThem.Margin = new System.Windows.Forms.Padding(0);
            this.btnThem.Name = "btnThem";
            this.btnThem.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnThem.Size = new System.Drawing.Size(82, 39);
            this.btnThem.TabIndex = 145;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox_TTChung
            // 
            this.groupBox_TTChung.Controls.Add(this.iconButton5);
            this.groupBox_TTChung.Controls.Add(this.cmbTenKH);
            this.groupBox_TTChung.Controls.Add(this.cmbHTTT);
            this.groupBox_TTChung.Controls.Add(this.label17);
            this.groupBox_TTChung.Controls.Add(this.cmbTenNV);
            this.groupBox_TTChung.Controls.Add(this.label9);
            this.groupBox_TTChung.Controls.Add(this.txtSdt);
            this.groupBox_TTChung.Controls.Add(this.dtpNgayLap);
            this.groupBox_TTChung.Controls.Add(this.label6);
            this.groupBox_TTChung.Controls.Add(this.txtDiaChi);
            this.groupBox_TTChung.Controls.Add(this.label5);
            this.groupBox_TTChung.Controls.Add(this.label4);
            this.groupBox_TTChung.Controls.Add(this.label3);
            this.groupBox_TTChung.Controls.Add(this.label1);
            this.groupBox_TTChung.Controls.Add(this.txtMaHD);
            this.groupBox_TTChung.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_TTChung.Location = new System.Drawing.Point(24, 24);
            this.groupBox_TTChung.Name = "groupBox_TTChung";
            this.groupBox_TTChung.Size = new System.Drawing.Size(899, 210);
            this.groupBox_TTChung.TabIndex = 143;
            this.groupBox_TTChung.TabStop = false;
            this.groupBox_TTChung.Text = "Thông tin chung";
            // 
            // iconButton5
            // 
            this.iconButton5.BackColor = System.Drawing.SystemColors.Control;
            this.iconButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.iconButton5.FlatAppearance.BorderSize = 0;
            this.iconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconButton5.IconColor = System.Drawing.Color.ForestGreen;
            this.iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton5.IconSize = 25;
            this.iconButton5.Location = new System.Drawing.Point(773, 30);
            this.iconButton5.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Size = new System.Drawing.Size(27, 27);
            this.iconButton5.TabIndex = 148;
            this.iconButton5.UseVisualStyleBackColor = false;
            this.iconButton5.Click += new System.EventHandler(this.iconButton5_Click);
            // 
            // cmbTenKH
            // 
            this.cmbTenKH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTenKH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTenKH.FormattingEnabled = true;
            this.cmbTenKH.Location = new System.Drawing.Point(593, 27);
            this.cmbTenKH.Name = "cmbTenKH";
            this.cmbTenKH.Size = new System.Drawing.Size(175, 27);
            this.cmbTenKH.TabIndex = 2;
            this.cmbTenKH.SelectedIndexChanged += new System.EventHandler(this.cmbTenKH_SelectedIndexChanged);
            // 
            // cmbHTTT
            // 
            this.cmbHTTT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHTTT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbHTTT.FormattingEnabled = true;
            this.cmbHTTT.Location = new System.Drawing.Point(138, 154);
            this.cmbHTTT.Name = "cmbHTTT";
            this.cmbHTTT.Size = new System.Drawing.Size(181, 27);
            this.cmbHTTT.TabIndex = 5;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(23, 157);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(90, 19);
            this.label17.TabIndex = 147;
            this.label17.Text = "Hình thức TT";
            // 
            // cmbTenNV
            // 
            this.cmbTenNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTenNV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTenNV.FormattingEnabled = true;
            this.cmbTenNV.Location = new System.Drawing.Point(138, 115);
            this.cmbTenNV.Name = "cmbTenNV";
            this.cmbTenNV.Size = new System.Drawing.Size(181, 27);
            this.cmbTenNV.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(479, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 19);
            this.label9.TabIndex = 140;
            this.label9.Text = "Điện thoại";
            // 
            // txtSdt
            // 
            this.txtSdt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSdt.Location = new System.Drawing.Point(593, 110);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.ReadOnly = true;
            this.txtSdt.Size = new System.Drawing.Size(175, 26);
            this.txtSdt.TabIndex = 7;
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpNgayLap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayLap.Location = new System.Drawing.Point(136, 74);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(110, 26);
            this.dtpNgayLap.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(478, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 19);
            this.label6.TabIndex = 137;
            this.label6.Text = "Địa chỉ";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(592, 74);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.ReadOnly = true;
            this.txtDiaChi.Size = new System.Drawing.Size(176, 26);
            this.txtDiaChi.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(477, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 19);
            this.label5.TabIndex = 135;
            this.label5.Text = "Tên khách hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 19);
            this.label4.TabIndex = 133;
            this.label4.Text = "Tên nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 19);
            this.label3.TabIndex = 132;
            this.label3.Text = "Ngày lập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 19);
            this.label1.TabIndex = 131;
            this.label1.Text = "Mã hóa đơn";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Enabled = false;
            this.txtMaHD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHD.Location = new System.Drawing.Point(136, 31);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(110, 26);
            this.txtMaHD.TabIndex = 1;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnThoat.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnThoat.IconColor = System.Drawing.Color.White;
            this.btnThoat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThoat.IconSize = 22;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(607, 532);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(0);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnThoat.Size = new System.Drawing.Size(83, 39);
            this.btnThoat.TabIndex = 147;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dgv_ChiTietHD
            // 
            this.dgv_ChiTietHD.AllowUserToAddRows = false;
            this.dgv_ChiTietHD.AllowUserToDeleteRows = false;
            this.dgv_ChiTietHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ChiTietHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ChiTietHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSP,
            this.TenSP,
            this.SoLuong,
            this.GiaBan,
            this.ThanhTien});
            this.dgv_ChiTietHD.Location = new System.Drawing.Point(24, 378);
            this.dgv_ChiTietHD.MultiSelect = false;
            this.dgv_ChiTietHD.Name = "dgv_ChiTietHD";
            this.dgv_ChiTietHD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ChiTietHD.Size = new System.Drawing.Size(899, 117);
            this.dgv_ChiTietHD.TabIndex = 142;
            this.dgv_ChiTietHD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ChiTietHD_CellDoubleClick);
            this.dgv_ChiTietHD.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ChiTietHD_CellDoubleClick);
            // 
            // MaSP
            // 
            this.MaSP.DataPropertyName = "MaSP";
            this.MaSP.HeaderText = "Mã sản phẩm";
            this.MaSP.Name = "MaSP";
            // 
            // TenSP
            // 
            this.TenSP.DataPropertyName = "TenSP";
            this.TenSP.HeaderText = "Tên SP";
            this.TenSP.Name = "TenSP";
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.Name = "SoLuong";
            // 
            // GiaBan
            // 
            this.GiaBan.DataPropertyName = "GiaBan";
            this.GiaBan.HeaderText = "Giá bán";
            this.GiaBan.Name = "GiaBan";
            // 
            // ThanhTien
            // 
            this.ThanhTien.DataPropertyName = "ThanhTien";
            this.ThanhTien.HeaderText = "Thành tiền";
            this.ThanhTien.Name = "ThanhTien";
            // 
            // nudSoLuong
            // 
            this.nudSoLuong.Location = new System.Drawing.Point(136, 64);
            this.nudSoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSoLuong.Name = "nudSoLuong";
            this.nudSoLuong.Size = new System.Drawing.Size(120, 26);
            this.nudSoLuong.TabIndex = 9;
            this.nudSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSoLuong.ValueChanged += new System.EventHandler(this.nudSoLuong_ValueChanged);
            // 
            // cmbTenSP
            // 
            this.cmbTenSP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTenSP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTenSP.FormattingEnabled = true;
            this.cmbTenSP.Location = new System.Drawing.Point(136, 20);
            this.cmbTenSP.Name = "cmbTenSP";
            this.cmbTenSP.Size = new System.Drawing.Size(181, 27);
            this.cmbTenSP.TabIndex = 8;
            this.cmbTenSP.SelectedIndexChanged += new System.EventHandler(this.cmbTenSP_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(454, 65);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(71, 19);
            this.label16.TabIndex = 137;
            this.label16.Text = "Thành tiền";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(21, 66);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 19);
            this.label14.TabIndex = 133;
            this.label14.Text = "Số lượng";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThanhTien.Location = new System.Drawing.Point(569, 66);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.ReadOnly = true;
            this.txtThanhTien.Size = new System.Drawing.Size(110, 26);
            this.txtThanhTien.TabIndex = 136;
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaBan.Location = new System.Drawing.Point(569, 17);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.ReadOnly = true;
            this.txtGiaBan.Size = new System.Drawing.Size(110, 26);
            this.txtGiaBan.TabIndex = 134;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(23, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 19);
            this.label13.TabIndex = 131;
            this.label13.Text = "Tên sản phẩm";
            // 
            // groupBox_TTMatHang
            // 
            this.groupBox_TTMatHang.Controls.Add(this.btnThemSP);
            this.groupBox_TTMatHang.Controls.Add(this.nudSoLuong);
            this.groupBox_TTMatHang.Controls.Add(this.cmbTenSP);
            this.groupBox_TTMatHang.Controls.Add(this.label16);
            this.groupBox_TTMatHang.Controls.Add(this.btnXoa);
            this.groupBox_TTMatHang.Controls.Add(this.txtThanhTien);
            this.groupBox_TTMatHang.Controls.Add(this.label15);
            this.groupBox_TTMatHang.Controls.Add(this.txtGiaBan);
            this.groupBox_TTMatHang.Controls.Add(this.label14);
            this.groupBox_TTMatHang.Controls.Add(this.label13);
            this.groupBox_TTMatHang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_TTMatHang.Location = new System.Drawing.Point(25, 249);
            this.groupBox_TTMatHang.Name = "groupBox_TTMatHang";
            this.groupBox_TTMatHang.Size = new System.Drawing.Size(899, 108);
            this.groupBox_TTMatHang.TabIndex = 144;
            this.groupBox_TTMatHang.TabStop = false;
            this.groupBox_TTMatHang.Text = "Thông tin các mặt hàng";
            // 
            // btnThemSP
            // 
            this.btnThemSP.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnThemSP.FlatAppearance.BorderSize = 0;
            this.btnThemSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemSP.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnThemSP.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnThemSP.IconColor = System.Drawing.Color.White;
            this.btnThemSP.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThemSP.IconSize = 22;
            this.btnThemSP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemSP.Location = new System.Drawing.Point(760, 17);
            this.btnThemSP.Margin = new System.Windows.Forms.Padding(0);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnThemSP.Size = new System.Drawing.Size(106, 32);
            this.btnThemSP.TabIndex = 142;
            this.btnThemSP.Text = "Thêm SP";
            this.btnThemSP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemSP.UseVisualStyleBackColor = false;
            this.btnThemSP.Click += new System.EventHandler(this.btnThemSP_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnXoa.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnXoa.IconColor = System.Drawing.Color.White;
            this.btnXoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXoa.IconSize = 22;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(777, 65);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(0);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnXoa.Size = new System.Drawing.Size(73, 34);
            this.btnXoa.TabIndex = 139;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(453, 20);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 19);
            this.label15.TabIndex = 135;
            this.label15.Text = "Giá bán";
            // 
            // CTHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 629);
            this.Controls.Add(this.btnNhapLai);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox_TTChung);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.dgv_ChiTietHD);
            this.Controls.Add(this.groupBox_TTMatHang);
            this.Name = "CTHD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CTHD";
            this.Load += new System.EventHandler(this.CTHD_Load);
            this.groupBox_TTChung.ResumeLayout(false);
            this.groupBox_TTChung.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ChiTietHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).EndInit();
            this.groupBox_TTMatHang.ResumeLayout(false);
            this.groupBox_TTMatHang.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnNhapLai;
        private FontAwesome.Sharp.IconButton btnThem;
        private System.Windows.Forms.GroupBox groupBox_TTChung;
        private System.Windows.Forms.ComboBox cmbTenKH;
        private System.Windows.Forms.ComboBox cmbHTTT;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cmbTenNV;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.DateTimePicker dtpNgayLap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaHD;
        private FontAwesome.Sharp.IconButton btnThoat;
        private System.Windows.Forms.DataGridView dgv_ChiTietHD;
        private System.Windows.Forms.NumericUpDown nudSoLuong;
        private System.Windows.Forms.ComboBox cmbTenSP;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox_TTMatHang;
        private FontAwesome.Sharp.IconButton btnThemSP;
        private FontAwesome.Sharp.IconButton btnXoa;
        private System.Windows.Forms.Label label15;
        private FontAwesome.Sharp.IconButton iconButton5;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
    }
}