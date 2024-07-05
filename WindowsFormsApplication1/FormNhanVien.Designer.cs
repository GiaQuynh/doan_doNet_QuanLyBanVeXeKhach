namespace WindowsFormsApplication1
{
    partial class FormNhanVien
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
            this.panelheader = new System.Windows.Forms.Panel();
            this.btnclose = new System.Windows.Forms.Button();
            this.panelside = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.User = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.btnThongTin = new System.Windows.Forms.Button();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnQLChuyenXe = new System.Windows.Forms.Button();
            this.btnQLKhachHang = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.panelheader.SuspendLayout();
            this.panelside.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelheader
            // 
            this.panelheader.BackColor = System.Drawing.Color.MistyRose;
            this.panelheader.Controls.Add(this.btnclose);
            this.panelheader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelheader.ForeColor = System.Drawing.SystemColors.Control;
            this.panelheader.Location = new System.Drawing.Point(0, 0);
            this.panelheader.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelheader.Name = "panelheader";
            this.panelheader.Size = new System.Drawing.Size(1751, 46);
            this.panelheader.TabIndex = 17;
            // 
            // btnclose
            // 
            this.btnclose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnclose.BackColor = System.Drawing.Color.Pink;
            this.btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnclose.FlatAppearance.BorderSize = 0;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.Color.White;
            this.btnclose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclose.Location = new System.Drawing.Point(1706, 0);
            this.btnclose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(45, 46);
            this.btnclose.TabIndex = 1;
            this.btnclose.Text = "X";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // panelside
            // 
            this.panelside.BackColor = System.Drawing.Color.MistyRose;
            this.panelside.Controls.Add(this.button4);
            this.panelside.Controls.Add(this.button3);
            this.panelside.Controls.Add(this.button2);
            this.panelside.Controls.Add(this.button1);
            this.panelside.Controls.Add(this.User);
            this.panelside.Controls.Add(this.label1);
            this.panelside.Controls.Add(this.btnBaoCao);
            this.panelside.Controls.Add(this.btnThongTin);
            this.panelside.Controls.Add(this.btnDangXuat);
            this.panelside.Controls.Add(this.btnQLChuyenXe);
            this.panelside.Controls.Add(this.btnQLKhachHang);
            this.panelside.Controls.Add(this.pictureBox1);
            this.panelside.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelside.Location = new System.Drawing.Point(0, 46);
            this.panelside.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelside.Name = "panelside";
            this.panelside.Size = new System.Drawing.Size(422, 1031);
            this.panelside.TabIndex = 20;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Image = global::WindowsFormsApplication1.Properties.Resources.driver1;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(-3, 599);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(432, 43);
            this.button3.TabIndex = 13;
            this.button3.Text = "   Thông Tin Tài Xế";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Image = global::WindowsFormsApplication1.Properties.Resources.iconbus1;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(-3, 550);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(432, 43);
            this.button2.TabIndex = 12;
            this.button2.Text = "   Thông Tin Xe";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Image = global::WindowsFormsApplication1.Properties.Resources.report1;
            this.button1.Location = new System.Drawing.Point(-3, 853);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(432, 46);
            this.button1.TabIndex = 11;
            this.button1.Text = "   Doanh Thu Theo Tuyến Xe";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // User
            // 
            this.User.BackColor = System.Drawing.Color.MistyRose;
            this.User.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.User.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User.ForeColor = System.Drawing.Color.White;
            this.User.Location = new System.Drawing.Point(134, 389);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(262, 32);
            this.User.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(42, 389);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "Hello";
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnBaoCao.FlatAppearance.BorderSize = 0;
            this.btnBaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaoCao.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaoCao.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBaoCao.Image = global::WindowsFormsApplication1.Properties.Resources.report;
            this.btnBaoCao.Location = new System.Drawing.Point(-3, 801);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnBaoCao.Size = new System.Drawing.Size(432, 46);
            this.btnBaoCao.TabIndex = 6;
            this.btnBaoCao.Text = "   Doanh Thu Theo Tuần";
            this.btnBaoCao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBaoCao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBaoCao.UseVisualStyleBackColor = false;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // btnThongTin
            // 
            this.btnThongTin.BackColor = System.Drawing.Color.Snow;
            this.btnThongTin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThongTin.FlatAppearance.BorderSize = 0;
            this.btnThongTin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongTin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongTin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnThongTin.Image = global::WindowsFormsApplication1.Properties.Resources.user2;
            this.btnThongTin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongTin.Location = new System.Drawing.Point(0, 451);
            this.btnThongTin.Name = "btnThongTin";
            this.btnThongTin.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnThongTin.Size = new System.Drawing.Size(432, 77);
            this.btnThongTin.TabIndex = 1;
            this.btnThongTin.Text = "   Thông Tin Người Dùng";
            this.btnThongTin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThongTin.UseVisualStyleBackColor = false;
            this.btnThongTin.Click += new System.EventHandler(this.btnThongTin_Click_1);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDangXuat.FlatAppearance.BorderSize = 0;
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDangXuat.Image = global::WindowsFormsApplication1.Properties.Resources.logout;
            this.btnDangXuat.Location = new System.Drawing.Point(-3, 948);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(432, 71);
            this.btnDangXuat.TabIndex = 5;
            this.btnDangXuat.Text = "    Đăng Xuất";
            this.btnDangXuat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangXuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnQLChuyenXe
            // 
            this.btnQLChuyenXe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnQLChuyenXe.FlatAppearance.BorderSize = 0;
            this.btnQLChuyenXe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLChuyenXe.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLChuyenXe.ForeColor = System.Drawing.SystemColors.Control;
            this.btnQLChuyenXe.Image = global::WindowsFormsApplication1.Properties.Resources.time1;
            this.btnQLChuyenXe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLChuyenXe.Location = new System.Drawing.Point(-3, 648);
            this.btnQLChuyenXe.Name = "btnQLChuyenXe";
            this.btnQLChuyenXe.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.btnQLChuyenXe.Size = new System.Drawing.Size(432, 43);
            this.btnQLChuyenXe.TabIndex = 2;
            this.btnQLChuyenXe.Text = "   Thông Tin Chuyến Xe";
            this.btnQLChuyenXe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLChuyenXe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLChuyenXe.UseVisualStyleBackColor = false;
            this.btnQLChuyenXe.Click += new System.EventHandler(this.btnQLChuyenXe_Click);
            // 
            // btnQLKhachHang
            // 
            this.btnQLKhachHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnQLKhachHang.FlatAppearance.BorderSize = 0;
            this.btnQLKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLKhachHang.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLKhachHang.ForeColor = System.Drawing.SystemColors.Control;
            this.btnQLKhachHang.Image = global::WindowsFormsApplication1.Properties.Resources.user3;
            this.btnQLKhachHang.Location = new System.Drawing.Point(-13, 697);
            this.btnQLKhachHang.Name = "btnQLKhachHang";
            this.btnQLKhachHang.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnQLKhachHang.Size = new System.Drawing.Size(432, 46);
            this.btnQLKhachHang.TabIndex = 3;
            this.btnQLKhachHang.Text = "   Thông Tin Khách Hàng";
            this.btnQLKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLKhachHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLKhachHang.UseVisualStyleBackColor = false;
            this.btnQLKhachHang.Click += new System.EventHandler(this.btnQLKhachHang_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.logo_xe_bus_3_1030x10301;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(432, 371);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.b1;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(302, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1449, 1031);
            this.panel1.TabIndex = 19;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.Control;
            this.button4.Image = global::WindowsFormsApplication1.Properties.Resources.report1;
            this.button4.Location = new System.Drawing.Point(-13, 749);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(432, 46);
            this.button4.TabIndex = 14;
            this.button4.Text = "    Thông Tin Vé Xe";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // FormNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1751, 1077);
            this.Controls.Add(this.panelside);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelheader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormNhanVien";
            this.Text = "FormNhanVien";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormNhanVien_Load);
            this.panelheader.ResumeLayout(false);
            this.panelside.ResumeLayout(false);
            this.panelside.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelheader;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Panel panelside;
        private System.Windows.Forms.TextBox User;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBaoCao;
        private System.Windows.Forms.Button btnThongTin;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Button btnQLChuyenXe;
        private System.Windows.Forms.Button btnQLKhachHang;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;

    }
}