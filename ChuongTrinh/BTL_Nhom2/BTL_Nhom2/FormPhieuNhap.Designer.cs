
namespace BTL_Nhom2
{
    partial class FormPhieuNhap
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
            this.NgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.tngayn = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tmancc = new System.Windows.Forms.TextBox();
            this.tmapn = new System.Windows.Forms.TextBox();
            this.tmasp = new System.Windows.Forms.TextBox();
            this.tsln = new System.Windows.Forms.TextBox();
            this.tdgn = new System.Windows.Forms.TextBox();
            this.MaNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataPN = new System.Windows.Forms.DataGridView();
            this.but_thoat = new FontAwesome.Sharp.IconButton();
            this.but_them = new FontAwesome.Sharp.IconButton();
            this.but_sua = new FontAwesome.Sharp.IconButton();
            this.but_xoa = new FontAwesome.Sharp.IconButton();
            this.btnxuat = new FontAwesome.Sharp.IconButton();
            this.reset = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.txtphantrang = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.but_tim = new System.Windows.Forms.Button();
            this.ttim = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataPN)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NgayNhap
            // 
            this.NgayNhap.DataPropertyName = "NgayNhap";
            this.NgayNhap.HeaderText = "Ngày nhập";
            this.NgayNhap.Name = "NgayNhap";
            // 
            // SoLuongNhap
            // 
            this.SoLuongNhap.DataPropertyName = "SoLuongNhap";
            this.SoLuongNhap.HeaderText = "Số lượng";
            this.SoLuongNhap.Name = "SoLuongNhap";
            // 
            // MaSP
            // 
            this.MaSP.DataPropertyName = "MaSP";
            this.MaSP.HeaderText = "Mã sản phẩm";
            this.MaSP.Name = "MaSP";
            // 
            // MaPN
            // 
            this.MaPN.DataPropertyName = "MaPN";
            this.MaPN.HeaderText = "Mã phiếu";
            this.MaPN.Name = "MaPN";
            // 
            // STT
            // 
            this.STT.DataPropertyName = "STT";
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            // 
            // DonGiaNhap
            // 
            this.DonGiaNhap.DataPropertyName = "DonGiaNhap";
            this.DonGiaNhap.HeaderText = "Đơn giá";
            this.DonGiaNhap.Name = "DonGiaNhap";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(467, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 62;
            this.label5.Text = "Ngày nhập";
            // 
            // tngayn
            // 
            this.tngayn.Location = new System.Drawing.Point(568, 139);
            this.tngayn.Name = "tngayn";
            this.tngayn.Size = new System.Drawing.Size(161, 20);
            this.tngayn.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(128, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 59;
            this.label6.Text = "Mã NCC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(467, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 58;
            this.label3.Text = "Đơn giá";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(467, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 57;
            this.label4.Text = "Số lượng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 56;
            this.label2.Text = "Mã SP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "Mã phiếu";
            // 
            // tmancc
            // 
            this.tmancc.Location = new System.Drawing.Point(229, 142);
            this.tmancc.Name = "tmancc";
            this.tmancc.Size = new System.Drawing.Size(161, 20);
            this.tmancc.TabIndex = 3;
            // 
            // tmapn
            // 
            this.tmapn.Location = new System.Drawing.Point(229, 64);
            this.tmapn.Name = "tmapn";
            this.tmapn.Size = new System.Drawing.Size(161, 20);
            this.tmapn.TabIndex = 1;
            // 
            // tmasp
            // 
            this.tmasp.Location = new System.Drawing.Point(229, 100);
            this.tmasp.Name = "tmasp";
            this.tmasp.Size = new System.Drawing.Size(161, 20);
            this.tmasp.TabIndex = 2;
            // 
            // tsln
            // 
            this.tsln.Location = new System.Drawing.Point(568, 61);
            this.tsln.Name = "tsln";
            this.tsln.Size = new System.Drawing.Size(161, 20);
            this.tsln.TabIndex = 4;
            // 
            // tdgn
            // 
            this.tdgn.Location = new System.Drawing.Point(568, 98);
            this.tdgn.Name = "tdgn";
            this.tdgn.Size = new System.Drawing.Size(161, 20);
            this.tdgn.TabIndex = 5;
            // 
            // MaNCC
            // 
            this.MaNCC.DataPropertyName = "MaNCC";
            this.MaNCC.HeaderText = "Mã NCC";
            this.MaNCC.Name = "MaNCC";
            // 
            // dataPN
            // 
            this.dataPN.AllowUserToAddRows = false;
            this.dataPN.AllowUserToDeleteRows = false;
            this.dataPN.AllowUserToResizeColumns = false;
            this.dataPN.AllowUserToResizeRows = false;
            this.dataPN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataPN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaPN,
            this.MaSP,
            this.SoLuongNhap,
            this.DonGiaNhap,
            this.NgayNhap,
            this.MaNCC});
            this.dataPN.Location = new System.Drawing.Point(107, 221);
            this.dataPN.Name = "dataPN";
            this.dataPN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataPN.Size = new System.Drawing.Size(1094, 229);
            this.dataPN.TabIndex = 42;
            this.dataPN.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataPN_RowEnter);
            this.dataPN.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataPN_RowPrePaint);
            // 
            // but_thoat
            // 
            this.but_thoat.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.but_thoat.FlatAppearance.BorderSize = 0;
            this.but_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_thoat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.but_thoat.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.but_thoat.IconColor = System.Drawing.Color.White;
            this.but_thoat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.but_thoat.IconSize = 22;
            this.but_thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_thoat.Location = new System.Drawing.Point(1069, 516);
            this.but_thoat.Margin = new System.Windows.Forms.Padding(0);
            this.but_thoat.Name = "but_thoat";
            this.but_thoat.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.but_thoat.Size = new System.Drawing.Size(83, 39);
            this.but_thoat.TabIndex = 70;
            this.but_thoat.Text = "Thoát";
            this.but_thoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_thoat.UseVisualStyleBackColor = false;
            this.but_thoat.Click += new System.EventHandler(this.but_thoat_Click);
            // 
            // but_them
            // 
            this.but_them.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.but_them.FlatAppearance.BorderSize = 0;
            this.but_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_them.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.but_them.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.but_them.IconColor = System.Drawing.Color.White;
            this.but_them.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.but_them.IconSize = 22;
            this.but_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_them.Location = new System.Drawing.Point(144, 516);
            this.but_them.Margin = new System.Windows.Forms.Padding(0);
            this.but_them.Name = "but_them";
            this.but_them.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.but_them.Size = new System.Drawing.Size(115, 39);
            this.but_them.TabIndex = 64;
            this.but_them.Text = "Thêm mới ";
            this.but_them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_them.UseVisualStyleBackColor = false;
            this.but_them.Click += new System.EventHandler(this.but_them_Click);
            // 
            // but_sua
            // 
            this.but_sua.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.but_sua.FlatAppearance.BorderSize = 0;
            this.but_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_sua.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.but_sua.IconChar = FontAwesome.Sharp.IconChar.PenSquare;
            this.but_sua.IconColor = System.Drawing.Color.White;
            this.but_sua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.but_sua.IconSize = 22;
            this.but_sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_sua.Location = new System.Drawing.Point(314, 517);
            this.but_sua.Margin = new System.Windows.Forms.Padding(0);
            this.but_sua.Name = "but_sua";
            this.but_sua.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.but_sua.Size = new System.Drawing.Size(116, 39);
            this.but_sua.TabIndex = 65;
            this.but_sua.Text = "Sửa phiếu";
            this.but_sua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_sua.UseVisualStyleBackColor = false;
            this.but_sua.Click += new System.EventHandler(this.but_sua_Click);
            // 
            // but_xoa
            // 
            this.but_xoa.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.but_xoa.FlatAppearance.BorderSize = 0;
            this.but_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_xoa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.but_xoa.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.but_xoa.IconColor = System.Drawing.Color.White;
            this.but_xoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.but_xoa.IconSize = 22;
            this.but_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_xoa.Location = new System.Drawing.Point(475, 517);
            this.but_xoa.Margin = new System.Windows.Forms.Padding(0);
            this.but_xoa.Name = "but_xoa";
            this.but_xoa.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.but_xoa.Size = new System.Drawing.Size(115, 39);
            this.but_xoa.TabIndex = 66;
            this.but_xoa.Text = "Xóa phiếu";
            this.but_xoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_xoa.UseVisualStyleBackColor = false;
            this.but_xoa.Click += new System.EventHandler(this.but_xoa_Click);
            // 
            // btnxuat
            // 
            this.btnxuat.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnxuat.FlatAppearance.BorderSize = 0;
            this.btnxuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxuat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnxuat.IconChar = FontAwesome.Sharp.IconChar.FileExport;
            this.btnxuat.IconColor = System.Drawing.Color.White;
            this.btnxuat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnxuat.IconSize = 22;
            this.btnxuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnxuat.Location = new System.Drawing.Point(922, 516);
            this.btnxuat.Margin = new System.Windows.Forms.Padding(0);
            this.btnxuat.Name = "btnxuat";
            this.btnxuat.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnxuat.Size = new System.Drawing.Size(104, 39);
            this.btnxuat.TabIndex = 69;
            this.btnxuat.Text = "Xuất file";
            this.btnxuat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnxuat.UseVisualStyleBackColor = false;
            this.btnxuat.Click += new System.EventHandler(this.btnxuat_Click);
            // 
            // reset
            // 
            this.reset.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.reset.IconChar = FontAwesome.Sharp.IconChar.Sync;
            this.reset.IconColor = System.Drawing.Color.White;
            this.reset.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.reset.IconSize = 20;
            this.reset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reset.Location = new System.Drawing.Point(635, 517);
            this.reset.Name = "reset";
            this.reset.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.reset.Size = new System.Drawing.Size(104, 38);
            this.reset.TabIndex = 71;
            this.reset.Text = "Nhập lại";
            this.reset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.reset.UseVisualStyleBackColor = false;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Sync;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 20;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(775, 516);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.iconButton1.Size = new System.Drawing.Size(101, 37);
            this.iconButton1.TabIndex = 72;
            this.iconButton1.Text = "ReLoad";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // txtphantrang
            // 
            this.txtphantrang.Location = new System.Drawing.Point(107, 468);
            this.txtphantrang.Name = "txtphantrang";
            this.txtphantrang.Size = new System.Drawing.Size(188, 20);
            this.txtphantrang.TabIndex = 73;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 24);
            this.label8.TabIndex = 74;
            this.label8.Text = "Phiếu Nhập";
            // 
            // but_tim
            // 
            this.but_tim.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.but_tim.Location = new System.Drawing.Point(152, 94);
            this.but_tim.Name = "but_tim";
            this.but_tim.Size = new System.Drawing.Size(75, 32);
            this.but_tim.TabIndex = 47;
            this.but_tim.Text = "Tìm kiếm";
            this.but_tim.UseVisualStyleBackColor = false;
            this.but_tim.Click += new System.EventHandler(this.but_tim_Click);
            // 
            // ttim
            // 
            this.ttim.Location = new System.Drawing.Point(98, 39);
            this.ttim.Name = "ttim";
            this.ttim.Size = new System.Drawing.Size(160, 20);
            this.ttim.TabIndex = 49;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 54;
            this.label7.Text = "Nhập thông tin";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.ttim);
            this.groupBox1.Controls.Add(this.but_tim);
            this.groupBox1.Location = new System.Drawing.Point(817, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 152);
            this.groupBox1.TabIndex = 63;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(19, 120);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(89, 17);
            this.radioButton3.TabIndex = 58;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Mã sản phẩm";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(19, 97);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(65, 17);
            this.radioButton2.TabIndex = 57;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Mã NCC";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(19, 73);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(96, 17);
            this.radioButton1.TabIndex = 56;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Mã phiếu nhập";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // FormPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 623);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtphantrang);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.but_thoat);
            this.Controls.Add(this.but_them);
            this.Controls.Add(this.but_sua);
            this.Controls.Add(this.but_xoa);
            this.Controls.Add(this.btnxuat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tngayn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tmancc);
            this.Controls.Add(this.tmapn);
            this.Controls.Add(this.tmasp);
            this.Controls.Add(this.tsln);
            this.Controls.Add(this.tdgn);
            this.Controls.Add(this.dataPN);
            this.Name = "FormPhieuNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PhieuNhap";
            this.Load += new System.EventHandler(this.PhieuNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataPN)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn NgayNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPN;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGiaNhap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tngayn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tmancc;
        private System.Windows.Forms.TextBox tmapn;
        private System.Windows.Forms.TextBox tmasp;
        private System.Windows.Forms.TextBox tsln;
        private System.Windows.Forms.TextBox tdgn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNCC;
        private System.Windows.Forms.DataGridView dataPN;
        private FontAwesome.Sharp.IconButton but_thoat;
        private FontAwesome.Sharp.IconButton but_them;
        private FontAwesome.Sharp.IconButton but_sua;
        private FontAwesome.Sharp.IconButton but_xoa;
        private FontAwesome.Sharp.IconButton btnxuat;
        private FontAwesome.Sharp.IconButton reset;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.TextBox txtphantrang;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button but_tim;
        private System.Windows.Forms.TextBox ttim;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}