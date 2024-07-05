namespace WindowsFormsApplication1
{
    partial class FormQLChuyenXe
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
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_ChuyenXe = new System.Windows.Forms.DataGridView();
            this.maChuyenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maTuyenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayXPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayDenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioXPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioDenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sOGHETRONGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maTXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.qL_BANVEDataSet = new WindowsFormsApplication1.QL_BANVEDataSet();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGheTrong = new System.Windows.Forms.TextBox();
            this.txtMaChuyen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboMaXe = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cboMaTuyen = new System.Windows.Forms.ComboBox();
            this.dtpNgayXP = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayDK = new System.Windows.Forms.DateTimePicker();
            this.dtpGioXP = new System.Windows.Forms.DateTimePicker();
            this.dtpGioDK = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cboMaTX = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.chuyenXeTableAdapter = new WindowsFormsApplication1.QL_BANVEDataSetTableAdapters.ChuyenXeTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ChuyenXe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_BANVEDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(827, 473);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(219, 35);
            this.txtTimKiem.TabIndex = 122;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(514, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(358, 40);
            this.label3.TabIndex = 121;
            this.label3.Text = "Quản Lý Chuyến Xe";
            // 
            // dgv_ChuyenXe
            // 
            this.dgv_ChuyenXe.AutoGenerateColumns = false;
            this.dgv_ChuyenXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ChuyenXe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maChuyenDataGridViewTextBoxColumn,
            this.maxeDataGridViewTextBoxColumn,
            this.maTuyenDataGridViewTextBoxColumn,
            this.ngayXPDataGridViewTextBoxColumn,
            this.ngayDenDataGridViewTextBoxColumn,
            this.gioXPDataGridViewTextBoxColumn,
            this.gioDenDataGridViewTextBoxColumn,
            this.giaDataGridViewTextBoxColumn,
            this.sOGHETRONGDataGridViewTextBoxColumn,
            this.maTXDataGridViewTextBoxColumn});
            this.dgv_ChuyenXe.DataSource = this.bindingSource1;
            this.dgv_ChuyenXe.Location = new System.Drawing.Point(223, 546);
            this.dgv_ChuyenXe.Name = "dgv_ChuyenXe";
            this.dgv_ChuyenXe.RowTemplate.Height = 28;
            this.dgv_ChuyenXe.Size = new System.Drawing.Size(996, 299);
            this.dgv_ChuyenXe.TabIndex = 120;
            this.dgv_ChuyenXe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ChuyenXe_CellClick);
            // 
            // maChuyenDataGridViewTextBoxColumn
            // 
            this.maChuyenDataGridViewTextBoxColumn.DataPropertyName = "MaChuyen";
            this.maChuyenDataGridViewTextBoxColumn.HeaderText = "MaChuyen";
            this.maChuyenDataGridViewTextBoxColumn.Name = "maChuyenDataGridViewTextBoxColumn";
            // 
            // maxeDataGridViewTextBoxColumn
            // 
            this.maxeDataGridViewTextBoxColumn.DataPropertyName = "Maxe";
            this.maxeDataGridViewTextBoxColumn.HeaderText = "Maxe";
            this.maxeDataGridViewTextBoxColumn.Name = "maxeDataGridViewTextBoxColumn";
            // 
            // maTuyenDataGridViewTextBoxColumn
            // 
            this.maTuyenDataGridViewTextBoxColumn.DataPropertyName = "MaTuyen";
            this.maTuyenDataGridViewTextBoxColumn.HeaderText = "MaTuyen";
            this.maTuyenDataGridViewTextBoxColumn.Name = "maTuyenDataGridViewTextBoxColumn";
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
            // maTXDataGridViewTextBoxColumn
            // 
            this.maTXDataGridViewTextBoxColumn.DataPropertyName = "MaTX";
            this.maTXDataGridViewTextBoxColumn.HeaderText = "MaTX";
            this.maTXDataGridViewTextBoxColumn.Name = "maTXDataGridViewTextBoxColumn";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "ChuyenXe";
            this.bindingSource1.DataSource = this.qL_BANVEDataSet;
            // 
            // qL_BANVEDataSet
            // 
            this.qL_BANVEDataSet.DataSetName = "QL_BANVEDataSet";
            this.qL_BANVEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(234, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 29);
            this.label6.TabIndex = 116;
            this.label6.Text = "Mã chuyến";
            // 
            // txtGheTrong
            // 
            this.txtGheTrong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGheTrong.Location = new System.Drawing.Point(374, 286);
            this.txtGheTrong.Name = "txtGheTrong";
            this.txtGheTrong.Size = new System.Drawing.Size(245, 35);
            this.txtGheTrong.TabIndex = 113;
            this.txtGheTrong.TextChanged += new System.EventHandler(this.txtGheTrong_TextChanged);
            // 
            // txtMaChuyen
            // 
            this.txtMaChuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaChuyen.Location = new System.Drawing.Point(374, 120);
            this.txtMaChuyen.Name = "txtMaChuyen";
            this.txtMaChuyen.Size = new System.Drawing.Size(245, 35);
            this.txtMaChuyen.TabIndex = 112;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(751, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 29);
            this.label1.TabIndex = 109;
            this.label1.Text = "Ngày xuất phát";
            // 
            // txtGia
            // 
            this.txtGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGia.Location = new System.Drawing.Point(374, 342);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(245, 35);
            this.txtGia.TabIndex = 125;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(235, 348);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 29);
            this.label4.TabIndex = 124;
            this.label4.Text = "Giá";
            // 
            // cboMaXe
            // 
            this.cboMaXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaXe.FormattingEnabled = true;
            this.cboMaXe.Location = new System.Drawing.Point(374, 175);
            this.cboMaXe.Name = "cboMaXe";
            this.cboMaXe.Size = new System.Drawing.Size(245, 37);
            this.cboMaXe.TabIndex = 126;
            this.cboMaXe.SelectedIndexChanged += new System.EventHandler(this.cboMaXe_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(233, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 29);
            this.label7.TabIndex = 127;
            this.label7.Text = "Mã xe";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(751, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 29);
            this.label8.TabIndex = 129;
            this.label8.Text = "Mã tuyến";
            // 
            // cboMaTuyen
            // 
            this.cboMaTuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaTuyen.FormattingEnabled = true;
            this.cboMaTuyen.Location = new System.Drawing.Point(963, 113);
            this.cboMaTuyen.Name = "cboMaTuyen";
            this.cboMaTuyen.Size = new System.Drawing.Size(256, 37);
            this.cboMaTuyen.TabIndex = 128;
            this.cboMaTuyen.SelectedIndexChanged += new System.EventHandler(this.cboMaTuyen_SelectedIndexChanged);
            // 
            // dtpNgayXP
            // 
            this.dtpNgayXP.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayXP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayXP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayXP.Location = new System.Drawing.Point(963, 174);
            this.dtpNgayXP.Name = "dtpNgayXP";
            this.dtpNgayXP.Size = new System.Drawing.Size(256, 35);
            this.dtpNgayXP.TabIndex = 130;
            // 
            // dtpNgayDK
            // 
            this.dtpNgayDK.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayDK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayDK.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayDK.Location = new System.Drawing.Point(963, 227);
            this.dtpNgayDK.Name = "dtpNgayDK";
            this.dtpNgayDK.Size = new System.Drawing.Size(256, 35);
            this.dtpNgayDK.TabIndex = 131;
            // 
            // dtpGioXP
            // 
            this.dtpGioXP.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpGioXP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpGioXP.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpGioXP.Location = new System.Drawing.Point(963, 288);
            this.dtpGioXP.Name = "dtpGioXP";
            this.dtpGioXP.Size = new System.Drawing.Size(256, 35);
            this.dtpGioXP.TabIndex = 132;
            // 
            // dtpGioDK
            // 
            this.dtpGioDK.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpGioDK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpGioDK.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpGioDK.Location = new System.Drawing.Point(963, 348);
            this.dtpGioDK.Name = "dtpGioDK";
            this.dtpGioDK.Size = new System.Drawing.Size(256, 35);
            this.dtpGioDK.TabIndex = 133;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(751, 229);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(200, 29);
            this.label9.TabIndex = 134;
            this.label9.Text = "Ngày đến dự kiến";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(751, 291);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(152, 29);
            this.label10.TabIndex = 135;
            this.label10.Text = "Giờ xuất phát";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(751, 348);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(182, 29);
            this.label11.TabIndex = 136;
            this.label11.Text = "Giờ đến dự kiến";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(235, 236);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 29);
            this.label12.TabIndex = 138;
            this.label12.Text = "Mã tài xế";
            // 
            // cboMaTX
            // 
            this.cboMaTX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaTX.FormattingEnabled = true;
            this.cboMaTX.Location = new System.Drawing.Point(374, 228);
            this.cboMaTX.Name = "cboMaTX";
            this.cboMaTX.Size = new System.Drawing.Size(245, 37);
            this.cboMaTX.TabIndex = 137;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(231, 286);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(119, 29);
            this.label13.TabIndex = 139;
            this.label13.Text = "Ghế trống";
            // 
            // chuyenXeTableAdapter
            // 
            this.chuyenXeTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::WindowsFormsApplication1.Properties.Resources.icons8_print_16;
            this.button1.Location = new System.Drawing.Point(625, 467);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 46);
            this.button1.TabIndex = 140;
            this.button1.Text = "In";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Image = global::WindowsFormsApplication1.Properties.Resources.icons8_search_16;
            this.btnTimKiem.Location = new System.Drawing.Point(1072, 467);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(147, 46);
            this.btnTimKiem.TabIndex = 123;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btXoa
            // 
            this.btXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.Image = global::WindowsFormsApplication1.Properties.Resources.icons8_delete_16;
            this.btXoa.Location = new System.Drawing.Point(490, 467);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(118, 46);
            this.btXoa.TabIndex = 119;
            this.btXoa.Text = "Xóa";
            this.btXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btSua
            // 
            this.btSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSua.Image = global::WindowsFormsApplication1.Properties.Resources.icons8_edit_16;
            this.btSua.Location = new System.Drawing.Point(356, 467);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(118, 46);
            this.btSua.TabIndex = 118;
            this.btSua.Text = "Sửa";
            this.btSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = global::WindowsFormsApplication1.Properties.Resources.icons8_plus_16__1_;
            this.btnThem.Location = new System.Drawing.Point(224, 467);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(118, 46);
            this.btnThem.TabIndex = 117;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // FormQLChuyenXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 867);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cboMaTX);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtpGioDK);
            this.Controls.Add(this.dtpGioXP);
            this.Controls.Add(this.dtpNgayDK);
            this.Controls.Add(this.dtpNgayXP);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cboMaTuyen);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cboMaXe);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv_ChuyenXe);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtGheTrong);
            this.Controls.Add(this.txtMaChuyen);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormQLChuyenXe";
            this.Text = "FormQLChuyenXe";
            this.Load += new System.EventHandler(this.FormQLChuyenXe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ChuyenXe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_BANVEDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_ChuyenXe;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGheTrong;
        private System.Windows.Forms.TextBox txtMaChuyen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboMaXe;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboMaTuyen;
        private System.Windows.Forms.DateTimePicker dtpNgayXP;
        private System.Windows.Forms.DateTimePicker dtpNgayDK;
        private System.Windows.Forms.DateTimePicker dtpGioXP;
        private System.Windows.Forms.DateTimePicker dtpGioDK;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cboMaTX;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.BindingSource bindingSource1;
        private QL_BANVEDataSet qL_BANVEDataSet;
        private QL_BANVEDataSetTableAdapters.ChuyenXeTableAdapter chuyenXeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maChuyenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maTuyenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayXPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayDenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioXPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioDenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sOGHETRONGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maTXDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;

    }
}