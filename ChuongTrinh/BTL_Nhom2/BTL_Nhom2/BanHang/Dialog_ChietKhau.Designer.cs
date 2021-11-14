
namespace BTL_Nhom2
{
    partial class Dialog_ChietKhau
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdoTien = new System.Windows.Forms.RadioButton();
            this.rdoPhanTram = new System.Windows.Forms.RadioButton();
            this.btnThoat = new FontAwesome.Sharp.IconButton();
            this.btn_ApDung = new FontAwesome.Sharp.IconButton();
            this.txtChietKhau = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(15, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(403, 42);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chiết khấu đơn hàng";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rdoTien);
            this.panel2.Controls.Add(this.rdoPhanTram);
            this.panel2.Controls.Add(this.btnThoat);
            this.panel2.Controls.Add(this.btn_ApDung);
            this.panel2.Controls.Add(this.txtChietKhau);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(15, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(403, 153);
            this.panel2.TabIndex = 9;
            // 
            // rdoTien
            // 
            this.rdoTien.AutoSize = true;
            this.rdoTien.Checked = true;
            this.rdoTien.Location = new System.Drawing.Point(283, 36);
            this.rdoTien.Margin = new System.Windows.Forms.Padding(0);
            this.rdoTien.Name = "rdoTien";
            this.rdoTien.Size = new System.Drawing.Size(48, 20);
            this.rdoTien.TabIndex = 4;
            this.rdoTien.TabStop = true;
            this.rdoTien.Text = "vnđ";
            this.rdoTien.UseVisualStyleBackColor = true;
            // 
            // rdoPhanTram
            // 
            this.rdoPhanTram.AutoSize = true;
            this.rdoPhanTram.Location = new System.Drawing.Point(333, 36);
            this.rdoPhanTram.Margin = new System.Windows.Forms.Padding(0);
            this.rdoPhanTram.Name = "rdoPhanTram";
            this.rdoPhanTram.Size = new System.Drawing.Size(38, 20);
            this.rdoPhanTram.TabIndex = 3;
            this.rdoPhanTram.Text = "%";
            this.rdoPhanTram.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.OrangeRed;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThoat.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnThoat.IconColor = System.Drawing.Color.Black;
            this.btnThoat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThoat.Location = new System.Drawing.Point(144, 94);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(86, 41);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btn_ApDung
            // 
            this.btn_ApDung.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_ApDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ApDung.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ApDung.IconChar = FontAwesome.Sharp.IconChar.Ad;
            this.btn_ApDung.IconColor = System.Drawing.Color.OrangeRed;
            this.btn_ApDung.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_ApDung.Location = new System.Drawing.Point(270, 94);
            this.btn_ApDung.Name = "btn_ApDung";
            this.btn_ApDung.Size = new System.Drawing.Size(87, 41);
            this.btn_ApDung.TabIndex = 0;
            this.btn_ApDung.Text = "Áp dụng";
            this.btn_ApDung.UseVisualStyleBackColor = false;
            this.btn_ApDung.Click += new System.EventHandler(this.btn_ApDung_Click);
            // 
            // txtChietKhau
            // 
            this.txtChietKhau.Location = new System.Drawing.Point(127, 33);
            this.txtChietKhau.Name = "txtChietKhau";
            this.txtChietKhau.Size = new System.Drawing.Size(153, 22);
            this.txtChietKhau.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Chiết khấu";
            // 
            // Dialog_ChietKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 222);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Dialog_ChietKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dialog_ChietKhau";
            this.Load += new System.EventHandler(this.Dialog_ChietKhau_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rdoTien;
        private System.Windows.Forms.RadioButton rdoPhanTram;
        private FontAwesome.Sharp.IconButton btnThoat;
        private FontAwesome.Sharp.IconButton btn_ApDung;
        private System.Windows.Forms.TextBox txtChietKhau;
        private System.Windows.Forms.Label label2;
    }
}