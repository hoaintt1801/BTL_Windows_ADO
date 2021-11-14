
namespace BTL_Nhom2
{
    partial class FormPhieuThu
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
            this.label5 = new System.Windows.Forms.Label();
            this.reload = new FontAwesome.Sharp.IconButton();
            this.btn_NhapLai = new FontAwesome.Sharp.IconButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Thoat = new FontAwesome.Sharp.IconButton();
            this.BtnXoa = new FontAwesome.Sharp.IconButton();
            this.BtnThem = new FontAwesome.Sharp.IconButton();
            this.BtnSua = new FontAwesome.Sharp.IconButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMaPT = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbKhachHang = new System.Windows.Forms.ComboBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoTienThu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNguoiLap = new System.Windows.Forms.TextBox();
            this.txtNgayLap = new System.Windows.Forms.DateTimePicker();
            this.txtphantrang = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.dgvPhieuThu = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuThu)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(822, 89);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 201;
            this.label5.Text = "Đến ngày:";
            // 
            // reload
            // 
            this.reload.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.reload.FlatAppearance.BorderSize = 0;
            this.reload.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reload.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.reload.IconChar = FontAwesome.Sharp.IconChar.Sync;
            this.reload.IconColor = System.Drawing.Color.White;
            this.reload.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.reload.IconSize = 20;
            this.reload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reload.Location = new System.Drawing.Point(124, 102);
            this.reload.Name = "reload";
            this.reload.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.reload.Size = new System.Drawing.Size(96, 60);
            this.reload.TabIndex = 188;
            this.reload.Text = "ReLoad";
            this.reload.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.reload.UseVisualStyleBackColor = false;
            this.reload.Click += new System.EventHandler(this.reload_Click);
            // 
            // btn_NhapLai
            // 
            this.btn_NhapLai.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_NhapLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NhapLai.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_NhapLai.IconChar = FontAwesome.Sharp.IconChar.Sync;
            this.btn_NhapLai.IconColor = System.Drawing.Color.White;
            this.btn_NhapLai.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_NhapLai.IconSize = 20;
            this.btn_NhapLai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_NhapLai.Location = new System.Drawing.Point(21, 102);
            this.btn_NhapLai.Name = "btn_NhapLai";
            this.btn_NhapLai.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btn_NhapLai.Size = new System.Drawing.Size(99, 60);
            this.btn_NhapLai.TabIndex = 187;
            this.btn_NhapLai.Text = "Nhập lại";
            this.btn_NhapLai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_NhapLai.UseVisualStyleBackColor = false;
            this.btn_NhapLai.Click += new System.EventHandler(this.btn_NhapLai_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.reload);
            this.groupBox2.Controls.Add(this.btn_NhapLai);
            this.groupBox2.Controls.Add(this.btn_Thoat);
            this.groupBox2.Controls.Add(this.BtnXoa);
            this.groupBox2.Controls.Add(this.BtnThem);
            this.groupBox2.Controls.Add(this.BtnSua);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(32, 421);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(338, 172);
            this.groupBox2.TabIndex = 200;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_Thoat.FlatAppearance.BorderSize = 0;
            this.btn_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Thoat.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btn_Thoat.IconColor = System.Drawing.Color.White;
            this.btn_Thoat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Thoat.IconSize = 22;
            this.btn_Thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Thoat.Location = new System.Drawing.Point(223, 102);
            this.btn_Thoat.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btn_Thoat.Size = new System.Drawing.Size(98, 60);
            this.btn_Thoat.TabIndex = 186;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Thoat.UseVisualStyleBackColor = false;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // BtnXoa
            // 
            this.BtnXoa.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnXoa.FlatAppearance.BorderSize = 0;
            this.BtnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnXoa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnXoa.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.BtnXoa.IconColor = System.Drawing.Color.White;
            this.BtnXoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnXoa.IconSize = 22;
            this.BtnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnXoa.Location = new System.Drawing.Point(223, 29);
            this.BtnXoa.Margin = new System.Windows.Forms.Padding(0);
            this.BtnXoa.Name = "BtnXoa";
            this.BtnXoa.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.BtnXoa.Size = new System.Drawing.Size(95, 60);
            this.BtnXoa.TabIndex = 182;
            this.BtnXoa.Text = "Xóa";
            this.BtnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnXoa.UseVisualStyleBackColor = false;
            this.BtnXoa.Click += new System.EventHandler(this.BtnXoa_Click);
            // 
            // BtnThem
            // 
            this.BtnThem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnThem.FlatAppearance.BorderSize = 0;
            this.BtnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnThem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnThem.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.BtnThem.IconColor = System.Drawing.Color.White;
            this.BtnThem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnThem.IconSize = 22;
            this.BtnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnThem.Location = new System.Drawing.Point(21, 29);
            this.BtnThem.Margin = new System.Windows.Forms.Padding(0);
            this.BtnThem.Name = "BtnThem";
            this.BtnThem.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.BtnThem.Size = new System.Drawing.Size(99, 60);
            this.BtnThem.TabIndex = 180;
            this.BtnThem.Text = "Thêm";
            this.BtnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnThem.UseVisualStyleBackColor = false;
            this.BtnThem.Click += new System.EventHandler(this.BtnThem_Click);
            // 
            // BtnSua
            // 
            this.BtnSua.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnSua.FlatAppearance.BorderSize = 0;
            this.BtnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSua.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnSua.IconChar = FontAwesome.Sharp.IconChar.PenSquare;
            this.BtnSua.IconColor = System.Drawing.Color.White;
            this.BtnSua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnSua.IconSize = 22;
            this.BtnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSua.Location = new System.Drawing.Point(124, 29);
            this.BtnSua.Margin = new System.Windows.Forms.Padding(0);
            this.BtnSua.Name = "BtnSua";
            this.BtnSua.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.BtnSua.Size = new System.Drawing.Size(96, 60);
            this.BtnSua.TabIndex = 181;
            this.BtnSua.Text = "Sửa ";
            this.BtnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSua.UseVisualStyleBackColor = false;
            this.BtnSua.Click += new System.EventHandler(this.BtnSua_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMaPT);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cbKhachHang);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSoTienThu);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtNguoiLap);
            this.groupBox1.Controls.Add(this.txtNgayLap);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(32, 49);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(338, 355);
            this.groupBox1.TabIndex = 199;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phiếu thu";
            // 
            // txtMaPT
            // 
            this.txtMaPT.Location = new System.Drawing.Point(116, 36);
            this.txtMaPT.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaPT.Name = "txtMaPT";
            this.txtMaPT.Size = new System.Drawing.Size(205, 23);
            this.txtMaPT.TabIndex = 1;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(116, 219);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(2);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(205, 80);
            this.txtDiaChi.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 39);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 40;
            this.label3.Text = "Mã Phiếu Thu";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 314);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 16);
            this.label10.TabIndex = 53;
            this.label10.Text = "SĐT";
            // 
            // cbKhachHang
            // 
            this.cbKhachHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKhachHang.FormattingEnabled = true;
            this.cbKhachHang.Location = new System.Drawing.Point(116, 72);
            this.cbKhachHang.Name = "cbKhachHang";
            this.cbKhachHang.Size = new System.Drawing.Size(205, 24);
            this.cbKhachHang.TabIndex = 2;
            this.cbKhachHang.SelectedIndexChanged += new System.EventHandler(this.cbKhachHang_SelectedIndexChanged);
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(116, 311);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(2);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(205, 23);
            this.txtSDT.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 219);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 16);
            this.label8.TabIndex = 50;
            this.label8.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 75);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 42;
            this.label4.Text = "Khách hàng";
            // 
            // txtSoTienThu
            // 
            this.txtSoTienThu.Location = new System.Drawing.Point(116, 181);
            this.txtSoTienThu.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoTienThu.Name = "txtSoTienThu";
            this.txtSoTienThu.Size = new System.Drawing.Size(205, 23);
            this.txtSoTienThu.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 184);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 16);
            this.label7.TabIndex = 48;
            this.label7.Text = "Số Tiền Thu";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 110);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 16);
            this.label9.TabIndex = 52;
            this.label9.Text = "Ngày Lập";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 147);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 16);
            this.label6.TabIndex = 46;
            this.label6.Text = "Người Lập";
            // 
            // txtNguoiLap
            // 
            this.txtNguoiLap.Location = new System.Drawing.Point(116, 147);
            this.txtNguoiLap.Margin = new System.Windows.Forms.Padding(2);
            this.txtNguoiLap.Name = "txtNguoiLap";
            this.txtNguoiLap.Size = new System.Drawing.Size(205, 23);
            this.txtNguoiLap.TabIndex = 4;
            // 
            // txtNgayLap
            // 
            this.txtNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtNgayLap.Location = new System.Drawing.Point(116, 110);
            this.txtNgayLap.Margin = new System.Windows.Forms.Padding(2);
            this.txtNgayLap.Name = "txtNgayLap";
            this.txtNgayLap.Size = new System.Drawing.Size(205, 23);
            this.txtNgayLap.TabIndex = 3;
            // 
            // txtphantrang
            // 
            this.txtphantrang.Location = new System.Drawing.Point(413, 573);
            this.txtphantrang.Name = "txtphantrang";
            this.txtphantrang.Size = new System.Drawing.Size(153, 20);
            this.txtphantrang.TabIndex = 198;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(660, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(114, 22);
            this.label12.TabIndex = 197;
            this.label12.Text = "PHIẾU THU";
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThongKe.Location = new System.Drawing.Point(679, 77);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(2);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(103, 37);
            this.btnThongKe.TabIndex = 194;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // dgvPhieuThu
            // 
            this.dgvPhieuThu.AllowUserToAddRows = false;
            this.dgvPhieuThu.AllowUserToDeleteRows = false;
            this.dgvPhieuThu.AllowUserToResizeColumns = false;
            this.dgvPhieuThu.AllowUserToResizeRows = false;
            this.dgvPhieuThu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPhieuThu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhieuThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuThu.Location = new System.Drawing.Point(394, 137);
            this.dgvPhieuThu.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPhieuThu.Name = "dgvPhieuThu";
            this.dgvPhieuThu.RowHeadersWidth = 51;
            this.dgvPhieuThu.RowTemplate.Height = 24;
            this.dgvPhieuThu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhieuThu.Size = new System.Drawing.Size(894, 424);
            this.dgvPhieuThu.TabIndex = 193;
            this.dgvPhieuThu.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuThu_RowEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(404, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 192;
            this.label1.Text = "Từ ngày:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(907, 89);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(151, 20);
            this.dateTimePicker2.TabIndex = 196;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(466, 89);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(151, 20);
            this.dateTimePicker1.TabIndex = 195;
            // 
            // FormPhieuThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 621);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtphantrang);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.dgvPhieuThu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "FormPhieuThu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPhieuXuat";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPhieuThu_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuThu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton reload;
        private FontAwesome.Sharp.IconButton btn_NhapLai;
        private System.Windows.Forms.GroupBox groupBox2;
        private FontAwesome.Sharp.IconButton btn_Thoat;
        private FontAwesome.Sharp.IconButton BtnXoa;
        private FontAwesome.Sharp.IconButton BtnThem;
        private FontAwesome.Sharp.IconButton BtnSua;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMaPT;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbKhachHang;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSoTienThu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNguoiLap;
        private System.Windows.Forms.DateTimePicker txtNgayLap;
        private System.Windows.Forms.TextBox txtphantrang;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.DataGridView dgvPhieuThu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}