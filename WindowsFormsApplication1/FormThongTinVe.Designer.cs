namespace WindowsFormsApplication1
{
    partial class FormThongTinVe
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cboMaVe = new System.Windows.Forms.ComboBox();
            this.dgv_ThongTinVe = new System.Windows.Forms.DataGridView();
            this.maVeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maChuyenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhTienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sOLUONGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nGAYDATVEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maTuyenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayXPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayDenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioXPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioDenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenTuyenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bIENSOXEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENHANGSXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.qL_BANVEDataSet = new WindowsFormsApplication1.QL_BANVEDataSet();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboTenTuyen = new System.Windows.Forms.ComboBox();
            this.dtpNgayXP = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayDen = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDiemXP = new System.Windows.Forms.TextBox();
            this.txtDiemDen = new System.Windows.Forms.TextBox();
            this.txtGioXP = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtGioDen = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.getVeInformationTableAdapter = new WindowsFormsApplication1.QL_BANVEDataSetTableAdapters.GetVeInformationTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThongTinVe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_BANVEDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(825, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 29);
            this.label8.TabIndex = 67;
            this.label8.Text = "Điểm đến";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(185, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 29);
            this.label10.TabIndex = 69;
            this.label10.Text = "Mã vé";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(823, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 29);
            this.label3.TabIndex = 62;
            this.label3.Text = "Tên tuyến";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(185, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 29);
            this.label7.TabIndex = 66;
            this.label7.Text = "Điểm xuất phát";
            // 
            // cboMaVe
            // 
            this.cboMaVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaVe.FormattingEnabled = true;
            this.cboMaVe.Location = new System.Drawing.Point(403, 113);
            this.cboMaVe.Name = "cboMaVe";
            this.cboMaVe.Size = new System.Drawing.Size(279, 37);
            this.cboMaVe.TabIndex = 77;
            this.cboMaVe.SelectedIndexChanged += new System.EventHandler(this.cboMaVe_SelectedIndexChanged);
            // 
            // dgv_ThongTinVe
            // 
            this.dgv_ThongTinVe.AutoGenerateColumns = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ThongTinVe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_ThongTinVe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ThongTinVe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maVeDataGridViewTextBoxColumn,
            this.maChuyenDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.thanhTienDataGridViewTextBoxColumn,
            this.sOLUONGDataGridViewTextBoxColumn,
            this.nGAYDATVEDataGridViewTextBoxColumn,
            this.maTuyenDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn2,
            this.ngayXPDataGridViewTextBoxColumn,
            this.ngayDenDataGridViewTextBoxColumn,
            this.gioXPDataGridViewTextBoxColumn,
            this.gioDenDataGridViewTextBoxColumn,
            this.giaDataGridViewTextBoxColumn,
            this.tenTuyenDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.tenKHDataGridViewTextBoxColumn,
            this.bIENSOXEDataGridViewTextBoxColumn,
            this.tENHANGSXDataGridViewTextBoxColumn});
            this.dgv_ThongTinVe.DataSource = this.bindingSource1;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_ThongTinVe.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_ThongTinVe.Location = new System.Drawing.Point(173, 475);
            this.dgv_ThongTinVe.Name = "dgv_ThongTinVe";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ThongTinVe.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_ThongTinVe.RowHeadersWidth = 62;
            this.dgv_ThongTinVe.RowTemplate.Height = 28;
            this.dgv_ThongTinVe.Size = new System.Drawing.Size(1147, 268);
            this.dgv_ThongTinVe.TabIndex = 80;
            this.dgv_ThongTinVe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ThongTinVe_CellClick);
            // 
            // maVeDataGridViewTextBoxColumn
            // 
            this.maVeDataGridViewTextBoxColumn.DataPropertyName = "MaVe";
            this.maVeDataGridViewTextBoxColumn.HeaderText = "MaVe";
            this.maVeDataGridViewTextBoxColumn.Name = "maVeDataGridViewTextBoxColumn";
            // 
            // maChuyenDataGridViewTextBoxColumn
            // 
            this.maChuyenDataGridViewTextBoxColumn.DataPropertyName = "MaChuyen";
            this.maChuyenDataGridViewTextBoxColumn.HeaderText = "MaChuyen";
            this.maChuyenDataGridViewTextBoxColumn.Name = "maChuyenDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaKh";
            this.dataGridViewTextBoxColumn1.HeaderText = "MaKh";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // thanhTienDataGridViewTextBoxColumn
            // 
            this.thanhTienDataGridViewTextBoxColumn.DataPropertyName = "ThanhTien";
            this.thanhTienDataGridViewTextBoxColumn.HeaderText = "ThanhTien";
            this.thanhTienDataGridViewTextBoxColumn.Name = "thanhTienDataGridViewTextBoxColumn";
            // 
            // sOLUONGDataGridViewTextBoxColumn
            // 
            this.sOLUONGDataGridViewTextBoxColumn.DataPropertyName = "SOLUONG";
            this.sOLUONGDataGridViewTextBoxColumn.HeaderText = "SOLUONG";
            this.sOLUONGDataGridViewTextBoxColumn.Name = "sOLUONGDataGridViewTextBoxColumn";
            // 
            // nGAYDATVEDataGridViewTextBoxColumn
            // 
            this.nGAYDATVEDataGridViewTextBoxColumn.DataPropertyName = "NGAYDATVE";
            this.nGAYDATVEDataGridViewTextBoxColumn.HeaderText = "NGAYDATVE";
            this.nGAYDATVEDataGridViewTextBoxColumn.Name = "nGAYDATVEDataGridViewTextBoxColumn";
            // 
            // maTuyenDataGridViewTextBoxColumn
            // 
            this.maTuyenDataGridViewTextBoxColumn.DataPropertyName = "MaTuyen";
            this.maTuyenDataGridViewTextBoxColumn.HeaderText = "MaTuyen";
            this.maTuyenDataGridViewTextBoxColumn.Name = "maTuyenDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Maxe";
            this.dataGridViewTextBoxColumn2.HeaderText = "Maxe";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
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
            // tenTuyenDataGridViewTextBoxColumn
            // 
            this.tenTuyenDataGridViewTextBoxColumn.DataPropertyName = "TenTuyen";
            this.tenTuyenDataGridViewTextBoxColumn.HeaderText = "TenTuyen";
            this.tenTuyenDataGridViewTextBoxColumn.Name = "tenTuyenDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DiemDen";
            this.dataGridViewTextBoxColumn3.HeaderText = "DiemDen";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DiemXP";
            this.dataGridViewTextBoxColumn4.HeaderText = "DiemXP";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // tenKHDataGridViewTextBoxColumn
            // 
            this.tenKHDataGridViewTextBoxColumn.DataPropertyName = "TenKH";
            this.tenKHDataGridViewTextBoxColumn.HeaderText = "TenKH";
            this.tenKHDataGridViewTextBoxColumn.Name = "tenKHDataGridViewTextBoxColumn";
            // 
            // bIENSOXEDataGridViewTextBoxColumn
            // 
            this.bIENSOXEDataGridViewTextBoxColumn.DataPropertyName = "BIENSOXE";
            this.bIENSOXEDataGridViewTextBoxColumn.HeaderText = "BIENSOXE";
            this.bIENSOXEDataGridViewTextBoxColumn.Name = "bIENSOXEDataGridViewTextBoxColumn";
            // 
            // tENHANGSXDataGridViewTextBoxColumn
            // 
            this.tENHANGSXDataGridViewTextBoxColumn.DataPropertyName = "TENHANGSX";
            this.tENHANGSXDataGridViewTextBoxColumn.HeaderText = "TENHANGSX";
            this.tENHANGSXDataGridViewTextBoxColumn.Name = "tENHANGSXDataGridViewTextBoxColumn";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "GetVeInformation";
            this.bindingSource1.DataSource = this.qL_BANVEDataSet;
            // 
            // qL_BANVEDataSet
            // 
            this.qL_BANVEDataSet.DataSetName = "QL_BANVEDataSet";
            this.qL_BANVEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(185, 319);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 29);
            this.label9.TabIndex = 68;
            this.label9.Text = "Số lượng vé";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(185, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 29);
            this.label6.TabIndex = 65;
            this.label6.Text = "Ngày xuất phát";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(825, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 29);
            this.label4.TabIndex = 63;
            this.label4.Text = "Giờ xuất phát";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(589, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 40);
            this.label1.TabIndex = 79;
            this.label1.Text = "Thông Tin Đặt Vé";
            // 
            // cboTenTuyen
            // 
            this.cboTenTuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTenTuyen.FormattingEnabled = true;
            this.cboTenTuyen.Location = new System.Drawing.Point(1030, 113);
            this.cboTenTuyen.Name = "cboTenTuyen";
            this.cboTenTuyen.Size = new System.Drawing.Size(279, 37);
            this.cboTenTuyen.TabIndex = 70;
            this.cboTenTuyen.SelectedIndexChanged += new System.EventHandler(this.cboTenTuyen_SelectedIndexChanged);
            // 
            // dtpNgayXP
            // 
            this.dtpNgayXP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayXP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayXP.Location = new System.Drawing.Point(403, 216);
            this.dtpNgayXP.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dtpNgayXP.Name = "dtpNgayXP";
            this.dtpNgayXP.Size = new System.Drawing.Size(279, 35);
            this.dtpNgayXP.TabIndex = 81;
            // 
            // dtpNgayDen
            // 
            this.dtpNgayDen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayDen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayDen.Location = new System.Drawing.Point(403, 267);
            this.dtpNgayDen.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dtpNgayDen.Name = "dtpNgayDen";
            this.dtpNgayDen.Size = new System.Drawing.Size(279, 35);
            this.dtpNgayDen.TabIndex = 83;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(185, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 29);
            this.label2.TabIndex = 82;
            this.label2.Text = "Ngày đến dự kiến";
            // 
            // txtDiemXP
            // 
            this.txtDiemXP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiemXP.Location = new System.Drawing.Point(403, 166);
            this.txtDiemXP.Name = "txtDiemXP";
            this.txtDiemXP.Size = new System.Drawing.Size(279, 35);
            this.txtDiemXP.TabIndex = 84;
            // 
            // txtDiemDen
            // 
            this.txtDiemDen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiemDen.Location = new System.Drawing.Point(1030, 166);
            this.txtDiemDen.Name = "txtDiemDen";
            this.txtDiemDen.Size = new System.Drawing.Size(279, 35);
            this.txtDiemDen.TabIndex = 85;
            // 
            // txtGioXP
            // 
            this.txtGioXP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGioXP.Location = new System.Drawing.Point(1030, 217);
            this.txtGioXP.Name = "txtGioXP";
            this.txtGioXP.Size = new System.Drawing.Size(279, 35);
            this.txtGioXP.TabIndex = 86;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(403, 319);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(279, 35);
            this.txtSoLuong.TabIndex = 87;
            // 
            // txtGioDen
            // 
            this.txtGioDen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGioDen.Location = new System.Drawing.Point(1030, 268);
            this.txtGioDen.Name = "txtGioDen";
            this.txtGioDen.Size = new System.Drawing.Size(279, 35);
            this.txtGioDen.TabIndex = 89;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(825, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 29);
            this.label5.TabIndex = 88;
            this.label5.Text = "Giờ đến dự kiến";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(709, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 58);
            this.button1.TabIndex = 90;
            this.button1.Text = "In Vé";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // getVeInformationTableAdapter
            // 
            this.getVeInformationTableAdapter.ClearBeforeFill = true;
            // 
            // FormThongTinVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(1402, 779);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtGioDen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.txtGioXP);
            this.Controls.Add(this.txtDiemDen);
            this.Controls.Add(this.txtDiemXP);
            this.Controls.Add(this.dtpNgayDen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpNgayXP);
            this.Controls.Add(this.dgv_ThongTinVe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboMaVe);
            this.Controls.Add(this.cboTenTuyen);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormThongTinVe";
            this.Text = "FormThongTinVe";
            this.Load += new System.EventHandler(this.FormThongTinVe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThongTinVe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_BANVEDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboMaVe;
        private System.Windows.Forms.DataGridViewTextBoxColumn hangSXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgv_ThongTinVe;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboTenTuyen;
        private System.Windows.Forms.DateTimePicker dtpNgayXP;
        private System.Windows.Forms.DateTimePicker dtpNgayDen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDiemXP;
        private System.Windows.Forms.TextBox txtDiemDen;
        private System.Windows.Forms.TextBox txtGioXP;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtGioDen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemXPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemDenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maXeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENXEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAHANGSXDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bindingSource1;
        private QL_BANVEDataSet qL_BANVEDataSet;
        private QL_BANVEDataSetTableAdapters.GetVeInformationTableAdapter getVeInformationTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maVeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maChuyenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhTienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sOLUONGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nGAYDATVEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maTuyenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayXPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayDenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioXPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioDenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenTuyenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bIENSOXEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENHANGSXDataGridViewTextBoxColumn;
    }
}