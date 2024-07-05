namespace WindowsFormsApplication1
{
    partial class FormTuyenXe
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
            this.label6 = new System.Windows.Forms.Label();
            this.txtDiemDen = new System.Windows.Forms.TextBox();
            this.txtDiemDi = new System.Windows.Forms.TextBox();
            this.txtTenTuyen = new System.Windows.Forms.TextBox();
            this.txtMaTuyen = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_Tuyen = new System.Windows.Forms.DataGridView();
            this.maTuyenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenTuyenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemXPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemDenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.qL_BANVEDataSet = new WindowsFormsApplication1.QL_BANVEDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.tuyenXeTableAdapter = new WindowsFormsApplication1.QL_BANVEDataSetTableAdapters.TuyenXeTableAdapter();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Tuyen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_BANVEDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(112, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 29);
            this.label6.TabIndex = 42;
            this.label6.Text = "Mã tuyến";
            // 
            // txtDiemDen
            // 
            this.txtDiemDen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiemDen.Location = new System.Drawing.Point(735, 191);
            this.txtDiemDen.Name = "txtDiemDen";
            this.txtDiemDen.Size = new System.Drawing.Size(255, 35);
            this.txtDiemDen.TabIndex = 41;
            // 
            // txtDiemDi
            // 
            this.txtDiemDi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiemDi.Location = new System.Drawing.Point(735, 133);
            this.txtDiemDi.Name = "txtDiemDi";
            this.txtDiemDi.Size = new System.Drawing.Size(255, 35);
            this.txtDiemDi.TabIndex = 40;
            // 
            // txtTenTuyen
            // 
            this.txtTenTuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTuyen.Location = new System.Drawing.Point(253, 191);
            this.txtTenTuyen.Name = "txtTenTuyen";
            this.txtTenTuyen.Size = new System.Drawing.Size(244, 35);
            this.txtTenTuyen.TabIndex = 38;
            // 
            // txtMaTuyen
            // 
            this.txtMaTuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaTuyen.Location = new System.Drawing.Point(253, 133);
            this.txtMaTuyen.Name = "txtMaTuyen";
            this.txtMaTuyen.Size = new System.Drawing.Size(244, 35);
            this.txtMaTuyen.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(574, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 29);
            this.label5.TabIndex = 36;
            this.label5.Text = "Điểm đến";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(577, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 29);
            this.label2.TabIndex = 33;
            this.label2.Text = "Điểm đi ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 29);
            this.label1.TabIndex = 32;
            this.label1.Text = "Tuyến xe";
            // 
            // dgv_Tuyen
            // 
            this.dgv_Tuyen.AutoGenerateColumns = false;
            this.dgv_Tuyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Tuyen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maTuyenDataGridViewTextBoxColumn,
            this.tenTuyenDataGridViewTextBoxColumn,
            this.diemXPDataGridViewTextBoxColumn,
            this.diemDenDataGridViewTextBoxColumn});
            this.dgv_Tuyen.DataSource = this.bindingSource1;
            this.dgv_Tuyen.Location = new System.Drawing.Point(64, 381);
            this.dgv_Tuyen.Name = "dgv_Tuyen";
            this.dgv_Tuyen.RowTemplate.Height = 28;
            this.dgv_Tuyen.Size = new System.Drawing.Size(944, 299);
            this.dgv_Tuyen.TabIndex = 56;
            this.dgv_Tuyen.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Tuyen_CellClick);
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
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "TuyenXe";
            this.bindingSource1.DataSource = this.qL_BANVEDataSet;
            // 
            // qL_BANVEDataSet
            // 
            this.qL_BANVEDataSet.DataSetName = "QL_BANVEDataSet";
            this.qL_BANVEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(336, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(333, 40);
            this.label3.TabIndex = 57;
            this.label3.Text = "Quản Lý Tuyến Xe";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(598, 320);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(219, 35);
            this.txtTimKiem.TabIndex = 107;
            // 
            // tuyenXeTableAdapter
            // 
            this.tuyenXeTableAdapter.ClearBeforeFill = true;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Image = global::WindowsFormsApplication1.Properties.Resources.icons8_search_16;
            this.btnTimKiem.Location = new System.Drawing.Point(843, 314);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(147, 46);
            this.btnTimKiem.TabIndex = 108;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btXoa
            // 
            this.btXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.Image = global::WindowsFormsApplication1.Properties.Resources.icons8_delete_16;
            this.btXoa.Location = new System.Drawing.Point(379, 314);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(118, 46);
            this.btXoa.TabIndex = 52;
            this.btXoa.Text = "Xóa";
            this.btXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btSua
            // 
            this.btSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSua.Image = global::WindowsFormsApplication1.Properties.Resources.icons8_edit_16;
            this.btSua.Location = new System.Drawing.Point(245, 314);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(118, 46);
            this.btSua.TabIndex = 51;
            this.btSua.Text = "Sửa";
            this.btSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = global::WindowsFormsApplication1.Properties.Resources.icons8_plus_16__1_;
            this.btnThem.Location = new System.Drawing.Point(113, 314);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(118, 46);
            this.btnThem.TabIndex = 50;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // FormTuyenXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 701);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv_Tuyen);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDiemDen);
            this.Controls.Add(this.txtDiemDi);
            this.Controls.Add(this.txtTenTuyen);
            this.Controls.Add(this.txtMaTuyen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTuyenXe";
            this.Text = "FormTuyenXe";
            this.Load += new System.EventHandler(this.FormTuyenXe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Tuyen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_BANVEDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDiemDen;
        private System.Windows.Forms.TextBox txtDiemDi;
        private System.Windows.Forms.TextBox txtTenTuyen;
        private System.Windows.Forms.TextBox txtMaTuyen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_Tuyen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn maTuyenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenTuyenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemXPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemDenDataGridViewTextBoxColumn;
        private QL_BANVEDataSet qL_BANVEDataSet;
        private QL_BANVEDataSetTableAdapters.TuyenXeTableAdapter tuyenXeTableAdapter;
    }
}