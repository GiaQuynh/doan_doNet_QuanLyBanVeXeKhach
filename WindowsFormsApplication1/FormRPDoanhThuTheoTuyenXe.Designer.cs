namespace WindowsFormsApplication1
{
    partial class FormRPDoanhThuTheoTuyenXe
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
            this.label1 = new System.Windows.Forms.Label();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.cboTuyenXe = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.crystalReportBaoCaoDanhThuTheoTuyenDuong1 = new WindowsFormsApplication1.CrystalReportBaoCaoDanhThuTheoTuyenDuong();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(331, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(632, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Báo Cáo Doanh Thu Theo Tuyến Xe";
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(73, 226);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1175, 429);
            this.crystalReportViewer1.TabIndex = 1;
            // 
            // cboTuyenXe
            // 
            this.cboTuyenXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTuyenXe.FormattingEnabled = true;
            this.cboTuyenXe.Location = new System.Drawing.Point(419, 143);
            this.cboTuyenXe.Name = "cboTuyenXe";
            this.cboTuyenXe.Size = new System.Drawing.Size(296, 37);
            this.cboTuyenXe.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(755, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 37);
            this.button1.TabIndex = 3;
            this.button1.Text = "In";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormRPDoanhThuTheoTuyenXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 701);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cboTuyenXe);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRPDoanhThuTheoTuyenXe";
            this.Text = "FormRPDoanhThuTheoTuyenXe";
            this.Load += new System.EventHandler(this.FormRPDoanhThuTheoTuyenXe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.ComboBox cboTuyenXe;
        private System.Windows.Forms.Button button1;
        private CrystalReportBaoCaoDanhThuTheoTuyenDuong crystalReportBaoCaoDanhThuTheoTuyenDuong1;
    }
}