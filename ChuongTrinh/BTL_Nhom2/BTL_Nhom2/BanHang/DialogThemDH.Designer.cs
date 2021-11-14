
namespace BTL_Nhom2
{
    partial class DialogThemDH
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
            this.cbHTTT = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.cb_NV = new System.Windows.Forms.ComboBox();
            this.cb_KH = new System.Windows.Forms.ComboBox();
            this.btnThoat = new FontAwesome.Sharp.IconButton();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_Luu = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaDH = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(481, 42);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thêm mới đơn hàng";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtMaDH);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cbHTTT);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.iconButton5);
            this.panel2.Controls.Add(this.cb_NV);
            this.panel2.Controls.Add(this.cb_KH);
            this.panel2.Controls.Add(this.btnThoat);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.btn_Luu);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(12, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(481, 272);
            this.panel2.TabIndex = 7;
            // 
            // cbHTTT
            // 
            this.cbHTTT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHTTT.FormattingEnabled = true;
            this.cbHTTT.Location = new System.Drawing.Point(188, 150);
            this.cbHTTT.Name = "cbHTTT";
            this.cbHTTT.Size = new System.Drawing.Size(232, 24);
            this.cbHTTT.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Hình thức thanh toán";
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
            this.iconButton5.IconSize = 22;
            this.iconButton5.Location = new System.Drawing.Point(423, 67);
            this.iconButton5.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Size = new System.Drawing.Size(27, 27);
            this.iconButton5.TabIndex = 18;
            this.iconButton5.UseVisualStyleBackColor = false;
            this.iconButton5.Click += new System.EventHandler(this.iconButton5_Click);
            // 
            // cb_NV
            // 
            this.cb_NV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_NV.FormattingEnabled = true;
            this.cb_NV.Location = new System.Drawing.Point(188, 109);
            this.cb_NV.Name = "cb_NV";
            this.cb_NV.Size = new System.Drawing.Size(232, 24);
            this.cb_NV.TabIndex = 16;
            // 
            // cb_KH
            // 
            this.cb_KH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_KH.FormattingEnabled = true;
            this.cb_KH.Location = new System.Drawing.Point(188, 67);
            this.cb_KH.Name = "cb_KH";
            this.cb_KH.Size = new System.Drawing.Size(232, 24);
            this.cb_KH.TabIndex = 15;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.OrangeRed;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThoat.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnThoat.IconColor = System.Drawing.Color.Black;
            this.btnThoat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThoat.Location = new System.Drawing.Point(279, 211);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(76, 41);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(37, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 16);
            this.label9.TabIndex = 14;
            this.label9.Text = "Tên khách hàng";
            // 
            // btn_Luu
            // 
            this.btn_Luu.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_Luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Luu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Luu.IconChar = FontAwesome.Sharp.IconChar.Ad;
            this.btn_Luu.IconColor = System.Drawing.Color.OrangeRed;
            this.btn_Luu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Luu.Location = new System.Drawing.Point(148, 211);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(79, 41);
            this.btn_Luu.TabIndex = 0;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = false;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Mã đơn hàng";
            // 
            // txtMaDH
            // 
            this.txtMaDH.Enabled = false;
            this.txtMaDH.Location = new System.Drawing.Point(188, 28);
            this.txtMaDH.Name = "txtMaDH";
            this.txtMaDH.Size = new System.Drawing.Size(232, 22);
            this.txtMaDH.TabIndex = 22;
            // 
            // DialogThemDH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 342);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "DialogThemDH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DialogThemDH";
            this.Load += new System.EventHandler(this.DialogThemDH_Load);
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
        private FontAwesome.Sharp.IconButton iconButton5;
        private System.Windows.Forms.ComboBox cb_NV;
        private System.Windows.Forms.ComboBox cb_KH;
        private FontAwesome.Sharp.IconButton btnThoat;
        private System.Windows.Forms.Label label9;
        private FontAwesome.Sharp.IconButton btn_Luu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbHTTT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaDH;
    }
}