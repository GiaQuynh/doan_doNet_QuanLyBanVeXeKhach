namespace WindowsFormsApplication1
{
    partial class FormTraCuu
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
            this.components = new System.ComponentModel.Container();
            this.dtpNgayXP = new System.Windows.Forms.DateTimePicker();
            this.btnDatVe = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboTuyenXe = new System.Windows.Forms.ComboBox();
            this.dgv_Tuyen = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.cboMaChuyen = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.qL_BANVEDataSet = new WindowsFormsApplication1.QL_BANVEDataSet();
            this.getTuyenChuyenInfoTableAdapter = new WindowsFormsApplication1.QL_BANVEDataSetTableAdapters.GetTuyenChuyenInfoTableAdapter();
            this.maTuyenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenTuyenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maChuyenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemXPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemDenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayXPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayDenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioXPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioDenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sOGHETRONGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenTXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENXEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENHANGSXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Tuyen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_BANVEDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpNgayXP
            // 
            this.dtpNgayXP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayXP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayXP.Location = new System.Drawing.Point(982, 121);
            this.dtpNgayXP.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dtpNgayXP.Name = "dtpNgayXP";
            this.dtpNgayXP.Size = new System.Drawing.Size(278, 35);
            this.dtpNgayXP.TabIndex = 77;
            this.dtpNgayXP.ValueChanged += new System.EventHandler(this.dtpNgaySinh_ValueChanged);
            // 
            // btnDatVe
            // 
            this.btnDatVe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDatVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatVe.ForeColor = System.Drawing.Color.Maroon;
            this.btnDatVe.Location = new System.Drawing.Point(651, 296);
            this.btnDatVe.Name = "btnDatVe";
            this.btnDatVe.Size = new System.Drawing.Size(154, 49);
            this.btnDatVe.TabIndex = 76;
            this.btnDatVe.Text = "Đặt Vé";
            this.btnDatVe.UseVisualStyleBackColor = false;
            this.btnDatVe.Click += new System.EventHandler(this.btnDatVe_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(793, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(170, 29);
            this.label9.TabIndex = 70;
            this.label9.Text = "Ngày xuất phát";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(193, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 29);
            this.label1.TabIndex = 62;
            this.label1.Text = "Tuyến xe";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label4.Location = new System.Drawing.Point(657, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 46);
            this.label4.TabIndex = 78;
            this.label4.Text = "Đặt Vé";
            // 
            // cboTuyenXe
            // 
            this.cboTuyenXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTuyenXe.FormattingEnabled = true;
            this.cboTuyenXe.Items.AddRange(new object[] {
            " ."});
            this.cboTuyenXe.Location = new System.Drawing.Point(345, 117);
            this.cboTuyenXe.Name = "cboTuyenXe";
            this.cboTuyenXe.Size = new System.Drawing.Size(278, 37);
            this.cboTuyenXe.TabIndex = 79;
            this.cboTuyenXe.SelectedIndexChanged += new System.EventHandler(this.cboTuyenXe_SelectedIndexChanged);
            // 
            // dgv_Tuyen
            // 
            this.dgv_Tuyen.AutoGenerateColumns = false;
            this.dgv_Tuyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Tuyen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maTuyenDataGridViewTextBoxColumn,
            this.tenTuyenDataGridViewTextBoxColumn,
            this.maChuyenDataGridViewTextBoxColumn,
            this.diemXPDataGridViewTextBoxColumn,
            this.diemDenDataGridViewTextBoxColumn,
            this.ngayXPDataGridViewTextBoxColumn,
            this.ngayDenDataGridViewTextBoxColumn,
            this.gioXPDataGridViewTextBoxColumn,
            this.gioDenDataGridViewTextBoxColumn,
            this.giaDataGridViewTextBoxColumn,
            this.sOGHETRONGDataGridViewTextBoxColumn,
            this.tenTXDataGridViewTextBoxColumn,
            this.tENXEDataGridViewTextBoxColumn,
            this.tENHANGSXDataGridViewTextBoxColumn});
            this.dgv_Tuyen.DataSource = this.bindingSource1;
            this.dgv_Tuyen.Location = new System.Drawing.Point(174, 380);
            this.dgv_Tuyen.Name = "dgv_Tuyen";
            this.dgv_Tuyen.RowTemplate.Height = 28;
            this.dgv_Tuyen.Size = new System.Drawing.Size(1133, 329);
            this.dgv_Tuyen.TabIndex = 80;
            this.dgv_Tuyen.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Tuyen_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(793, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 29);
            this.label2.TabIndex = 83;
            this.label2.Text = "Số lượng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(193, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 29);
            this.label3.TabIndex = 81;
            this.label3.Text = "Thành tiền";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(982, 173);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(278, 35);
            this.txtSoLuong.TabIndex = 84;
            this.txtSoLuong.TextChanged += new System.EventHandler(this.txtSoLuong_TextChanged);
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThanhTien.Location = new System.Drawing.Point(345, 219);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(278, 35);
            this.txtThanhTien.TabIndex = 85;
            // 
            // cboMaChuyen
            // 
            this.cboMaChuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaChuyen.FormattingEnabled = true;
            this.cboMaChuyen.Location = new System.Drawing.Point(345, 167);
            this.cboMaChuyen.Name = "cboMaChuyen";
            this.cboMaChuyen.Size = new System.Drawing.Size(278, 37);
            this.cboMaChuyen.TabIndex = 89;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(193, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 29);
            this.label6.TabIndex = 88;
            this.label6.Text = "Mã chuyến";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "GetTuyenChuyenInfo";
            this.bindingSource1.DataSource = this.qL_BANVEDataSet;
            // 
            // qL_BANVEDataSet
            // 
            this.qL_BANVEDataSet.DataSetName = "QL_BANVEDataSet";
            this.qL_BANVEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getTuyenChuyenInfoTableAdapter
            // 
            this.getTuyenChuyenInfoTableAdapter.ClearBeforeFill = true;
            // 
            // maTuyenDataGridViewTextBoxColumn
            // 
            this.maTuyenDataGridViewTextBoxColumn.DataPropertyName = "MaTuyen";
            this.maTuyenDataGridViewTextBoxColumn.HeaderText = "MaTuyen";
            this.maTuyenDataGridViewTextBoxColumn.Name = "maTuyenDataGridViewTextBoxColumn";
            // 
            // tenTuyenDataGridViewTextBoxColumn
            // 
            this.tenTuyenDataGridViewTextBoxColumn.DataPropertyName = "TenTuyen";
            this.tenTuyenDataGridViewTextBoxColumn.HeaderText = "TenTuyen";
            this.tenTuyenDataGridViewTextBoxColumn.Name = "tenTuyenDataGridViewTextBoxColumn";
            // 
            // maChuyenDataGridViewTextBoxColumn
            // 
            this.maChuyenDataGridViewTextBoxColumn.DataPropertyName = "MaChuyen";
            this.maChuyenDataGridViewTextBoxColumn.HeaderText = "MaChuyen";
            this.maChuyenDataGridViewTextBoxColumn.Name = "maChuyenDataGridViewTextBoxColumn";
            // 
            // diemXPDataGridViewTextBoxColumn
            // 
            this.diemXPDataGridViewTextBoxColumn.DataPropertyName = "DiemXP";
            this.diemXPDataGridViewTextBoxColumn.HeaderText = "DiemXP";
            this.diemXPDataGridViewTextBoxColumn.Name = "diemXPDataGridViewTextBoxColumn";
            // 
            // diemDenDataGridViewTextBoxColumn
            // 
            this.diemDenDataGridViewTextBoxColumn.DataPropertyName = "DiemDen";
            this.diemDenDataGridViewTextBoxColumn.HeaderText = "DiemDen";
            this.diemDenDataGridViewTextBoxColumn.Name = "diemDenDataGridViewTextBoxColumn";
            // 
            // ngayXPDataGridViewTextBoxColumn
            // 
            this.ngayXPDataGridViewTextBoxColumn.DataPropertyName = "NgayXP";
            this.ngayXPDataGridViewTextBoxColumn.HeaderText = "NgayXP";
            this.ngayXPDataGridViewTextBoxColumn.Name = "ngayXPDataGridViewTextBoxColumn";
            // 
            // ngayDenDataGridViewTextBoxColumn
            // 
            this.ngayDenDataGridViewTextBoxColumn.DataPropertyName = "NgayDen";
            this.ngayDenDataGridViewTextBoxColumn.HeaderText = "NgayDen";
            this.ngayDenDataGridViewTextBoxColumn.Name = "ngayDenDataGridViewTextBoxColumn";
            // 
            // gioXPDataGridViewTextBoxColumn
            // 
            this.gioXPDataGridViewTextBoxColumn.DataPropertyName = "GioXP";
            this.gioXPDataGridViewTextBoxColumn.HeaderText = "GioXP";
            this.gioXPDataGridViewTextBoxColumn.Name = "gioXPDataGridViewTextBoxColumn";
            // 
            // gioDenDataGridViewTextBoxColumn
            // 
            this.gioDenDataGridViewTextBoxColumn.DataPropertyName = "GioDen";
            this.gioDenDataGridViewTextBoxColumn.HeaderText = "GioDen";
            this.gioDenDataGridViewTextBoxColumn.Name = "gioDenDataGridViewTextBoxColumn";
            // 
            // giaDataGridViewTextBoxColumn
            // 
            this.giaDataGridViewTextBoxColumn.DataPropertyName = "Gia";
            this.giaDataGridViewTextBoxColumn.HeaderText = "Gia";
            this.giaDataGridViewTextBoxColumn.Name = "giaDataGridViewTextBoxColumn";
            // 
            // sOGHETRONGDataGridViewTextBoxColumn
            // 
            this.sOGHETRONGDataGridViewTextBoxColumn.DataPropertyName = "SOGHETRONG";
            this.sOGHETRONGDataGridViewTextBoxColumn.HeaderText = "SOGHETRONG";
            this.sOGHETRONGDataGridViewTextBoxColumn.Name = "sOGHETRONGDataGridViewTextBoxColumn";
            // 
            // tenTXDataGridViewTextBoxColumn
            // 
            this.tenTXDataGridViewTextBoxColumn.DataPropertyName = "TenTX";
            this.tenTXDataGridViewTextBoxColumn.HeaderText = "TenTX";
            this.tenTXDataGridViewTextBoxColumn.Name = "tenTXDataGridViewTextBoxColumn";
            // 
            // tENXEDataGridViewTextBoxColumn
            // 
            this.tENXEDataGridViewTextBoxColumn.DataPropertyName = "TENXE";
            this.tENXEDataGridViewTextBoxColumn.HeaderText = "TENXE";
            this.tENXEDataGridViewTextBoxColumn.Name = "tENXEDataGridViewTextBoxColumn";
            // 
            // tENHANGSXDataGridViewTextBoxColumn
            // 
            this.tENHANGSXDataGridViewTextBoxColumn.DataPropertyName = "TENHANGSX";
            this.tENHANGSXDataGridViewTextBoxColumn.HeaderText = "TENHANGSX";
            this.tENHANGSXDataGridViewTextBoxColumn.Name = "tENHANGSXDataGridViewTextBoxColumn";
            // 
            // FormTraCuu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1416, 746);
            this.Controls.Add(this.cboMaChuyen);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtThanhTien);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv_Tuyen);
            this.Controls.Add(this.cboTuyenXe);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpNgayXP);
            this.Controls.Add(this.btnDatVe);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTraCuu";
            this.Text = "FormTraCuu";
            this.Load += new System.EventHandler(this.FormTraCuu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Tuyen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_BANVEDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpNgayXP;
        private System.Windows.Forms.Button btnDatVe;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboTuyenXe;
        private System.Windows.Forms.DataGridView dgv_Tuyen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.ComboBox cboMaChuyen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn hANGSXDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bindingSource1;
        private QL_BANVEDataSet qL_BANVEDataSet;
        private QL_BANVEDataSetTableAdapters.GetTuyenChuyenInfoTableAdapter getTuyenChuyenInfoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maTuyenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenTuyenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maChuyenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemXPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemDenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayXPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayDenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioXPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioDenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sOGHETRONGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenTXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENXEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENHANGSXDataGridViewTextBoxColumn;
    }
}