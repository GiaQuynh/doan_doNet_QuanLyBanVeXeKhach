namespace WindowsFormsApplication1
{
    partial class FormKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKhachHang));
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelheader = new System.Windows.Forms.Panel();
            this.btnclose = new System.Windows.Forms.Button();
            this.panelside = new System.Windows.Forms.Panel();
            this.button11 = new System.Windows.Forms.Button();
            this.btnThongTin = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.User = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelheader.SuspendLayout();
            this.panelside.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(-357, 263);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(308, 56);
            this.button5.TabIndex = 12;
            this.button5.Text = "Đăng xuất";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(-357, 201);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(308, 56);
            this.button4.TabIndex = 11;
            this.button4.Text = "Đổi vé";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(-357, 139);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(308, 56);
            this.button3.TabIndex = 10;
            this.button3.Text = "Hủy vé";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(-357, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(308, 53);
            this.button2.TabIndex = 9;
            this.button2.Text = "Đặt vé";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(-357, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(308, 62);
            this.button1.TabIndex = 8;
            this.button1.Text = "Chuyến xe";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panelheader
            // 
            this.panelheader.BackColor = System.Drawing.Color.Lavender;
            this.panelheader.Controls.Add(this.btnclose);
            this.panelheader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelheader.ForeColor = System.Drawing.SystemColors.Control;
            this.panelheader.Location = new System.Drawing.Point(0, 0);
            this.panelheader.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelheader.Name = "panelheader";
            this.panelheader.Size = new System.Drawing.Size(1774, 46);
            this.panelheader.TabIndex = 18;
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnclose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnclose.FlatAppearance.BorderSize = 0;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.Color.White;
            this.btnclose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclose.Location = new System.Drawing.Point(1729, 0);
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
            this.panelside.BackColor = System.Drawing.Color.Lavender;
            this.panelside.Controls.Add(this.User);
            this.panelside.Controls.Add(this.label1);
            this.panelside.Controls.Add(this.pictureBox2);
            this.panelside.Controls.Add(this.button11);
            this.panelside.Controls.Add(this.btnThongTin);
            this.panelside.Controls.Add(this.button6);
            this.panelside.Controls.Add(this.button10);
            this.panelside.Controls.Add(this.button7);
            this.panelside.Controls.Add(this.button8);
            this.panelside.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelside.Location = new System.Drawing.Point(0, 46);
            this.panelside.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelside.Name = "panelside";
            this.panelside.Size = new System.Drawing.Size(422, 986);
            this.panelside.TabIndex = 19;
            // 
            // button11
            // 
            this.button11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button11.BackColor = System.Drawing.Color.GhostWhite;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.Color.Navy;
            this.button11.Image = global::WindowsFormsApplication1.Properties.Resources.history;
            this.button11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button11.Location = new System.Drawing.Point(2, 560);
            this.button11.Name = "button11";
            this.button11.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.button11.Size = new System.Drawing.Size(420, 72);
            this.button11.TabIndex = 13;
            this.button11.Text = "   Lịch Sử Đặt Vé";
            this.button11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button11.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // btnThongTin
            // 
            this.btnThongTin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnThongTin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThongTin.FlatAppearance.BorderSize = 0;
            this.btnThongTin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongTin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongTin.ForeColor = System.Drawing.SystemColors.Control;
            this.btnThongTin.Image = global::WindowsFormsApplication1.Properties.Resources.user11;
            this.btnThongTin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongTin.Location = new System.Drawing.Point(-2, 448);
            this.btnThongTin.Name = "btnThongTin";
            this.btnThongTin.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnThongTin.Size = new System.Drawing.Size(424, 81);
            this.btnThongTin.TabIndex = 12;
            this.btnThongTin.Text = "    Thông Tin Người Dùng";
            this.btnThongTin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongTin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThongTin.UseVisualStyleBackColor = false;
            this.btnThongTin.Click += new System.EventHandler(this.btnThongTin_Click);
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.Control;
            this.button6.Image = global::WindowsFormsApplication1.Properties.Resources.logout1;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(-1, 902);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.button6.Size = new System.Drawing.Size(423, 75);
            this.button6.TabIndex = 11;
            this.button6.Text = "   Đăng xuất";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button10
            // 
            this.button10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button10.BackColor = System.Drawing.Color.GhostWhite;
            this.button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.Navy;
            this.button10.Image = global::WindowsFormsApplication1.Properties.Resources.booking;
            this.button10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.Location = new System.Drawing.Point(0, 641);
            this.button10.Name = "button10";
            this.button10.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.button10.Size = new System.Drawing.Size(420, 81);
            this.button10.TabIndex = 7;
            this.button10.Text = "   Đặt vé";
            this.button10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button7
            // 
            this.button7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button7.BackColor = System.Drawing.Color.GhostWhite;
            this.button7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.Navy;
            this.button7.Image = global::WindowsFormsApplication1.Properties.Resources.change;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(0, 809);
            this.button7.Name = "button7";
            this.button7.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.button7.Size = new System.Drawing.Size(420, 75);
            this.button7.TabIndex = 10;
            this.button7.Text = "   Đổi vé";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button8.BackColor = System.Drawing.Color.GhostWhite;
            this.button8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.Navy;
            this.button8.Image = global::WindowsFormsApplication1.Properties.Resources.delete;
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(2, 728);
            this.button8.Name = "button8";
            this.button8.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.button8.Size = new System.Drawing.Size(420, 75);
            this.button8.TabIndex = 9;
            this.button8.Text = "   Hủy vé";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(240, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1534, 986);
            this.panel1.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-357, -140);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(308, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApplication1.Properties.Resources.logo_xe_bus_3_1030x10301;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(432, 371);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // User
            // 
            this.User.BackColor = System.Drawing.Color.Lavender;
            this.User.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.User.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User.ForeColor = System.Drawing.Color.White;
            this.User.Location = new System.Drawing.Point(135, 390);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(262, 32);
            this.User.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(43, 390);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 32);
            this.label1.TabIndex = 15;
            this.label1.Text = "Hello";
            // 
            // FormKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1774, 1032);
            this.Controls.Add(this.panelside);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelheader);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormKhachHang";
            this.Text = "FormKhachHang";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormKhachHang_Load);
            this.panelheader.ResumeLayout(false);
            this.panelside.ResumeLayout(false);
            this.panelside.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelheader;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Panel panelside;
        private System.Windows.Forms.Button btnThongTin;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox User;
        private System.Windows.Forms.Label label1;
    }
}