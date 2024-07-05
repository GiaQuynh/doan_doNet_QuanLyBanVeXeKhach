namespace WindowsFormsApplication1
{
    partial class FormLoaiXe
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
            this.dgv_LoaiXe = new System.Windows.Forms.DataGridView();
            this.mALOAIXEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENLOAIXEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sOGHEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.qL_BANVEDataSet = new WindowsFormsApplication1.QL_BANVEDataSet();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoGhe = new System.Windows.Forms.TextBox();
            this.txtTenLoaiXe = new System.Windows.Forms.TextBox();
            this.txtMaLoaiXe = new System.Windows.Forms.TextBox();
            this.lOAIXETableAdapter = new WindowsFormsApplication1.QL_BANVEDataSetTableAdapters.LOAIXETableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LoaiXe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_BANVEDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_LoaiXe
            // 
            this.dgv_LoaiXe.AutoGenerateColumns = false;
            this.dgv_LoaiXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_LoaiXe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mALOAIXEDataGridViewTextBoxColumn,
            this.tENLOAIXEDataGridViewTextBoxColumn,
            this.sOGHEDataGridViewTextBoxColumn});
            this.dgv_LoaiXe.DataSource = this.bindingSource1;
            this.dgv_LoaiXe.Location = new System.Drawing.Point(97, 375);
            this.dgv_LoaiXe.Name = "dgv_LoaiXe";
            this.dgv_LoaiXe.RowTemplate.Height = 28;
            this.dgv_LoaiXe.Size = new System.Drawing.Size(922, 229);
            this.dgv_LoaiXe.TabIndex = 172;
            this.dgv_LoaiXe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_LoaiXe_CellClick);
            // 
            // mALOAIXEDataGridViewTextBoxColumn
            // 
            this.mALOAIXEDataGridViewTextBoxColumn.DataPropertyName = "MALOAIXE";
            this.mALOAIXEDataGridViewTextBoxColumn.HeaderText = "MALOAIXE";
            this.mALOAIXEDataGridViewTextBoxColumn.Name = "mALOAIXEDataGridViewTextBoxColumn";
            // 
            // tENLOAIXEDataGridViewTextBoxColumn
            // 
            this.tENLOAIXEDataGridViewTextBoxColumn.DataPropertyName = "TENLOAIXE";
            this.tENLOAIXEDataGridViewTextBoxColumn.HeaderText = "TENLOAIXE";
            this.tENLOAIXEDataGridViewTextBoxColumn.Name = "tENLOAIXEDataGridViewTextBoxColumn";
            // 
            // sOGHEDataGridViewTextBoxColumn
            // 
            this.sOGHEDataGridViewTextBoxColumn.DataPropertyName = "SOGHE";
            this.sOGHEDataGridViewTextBoxColumn.HeaderText = "SOGHE";
            this.sOGHEDataGridViewTextBoxColumn.Name = "sOGHEDataGridViewTextBoxColumn";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "LOAIXE";
            this.bindingSource1.DataSource = this.qL_BANVEDataSet;
            // 
            // qL_BANVEDataSet
            // 
            this.qL_BANVEDataSet.DataSetName = "QL_BANVEDataSet";
            this.qL_BANVEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Image = global::WindowsFormsApplication1.Properties.Resources.icons8_search_16;
            this.btnTimKiem.Location = new System.Drawing.Point(876, 305);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(143, 38);
            this.btnTimKiem.TabIndex = 171;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click_1);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(649, 307);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(219, 35);
            this.txtTimKiem.TabIndex = 170;
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = global::WindowsFormsApplication1.Properties.Resources.icons8_delete_16;
            this.btnXoa.Location = new System.Drawing.Point(345, 300);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(109, 42);
            this.btnXoa.TabIndex = 169;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = global::WindowsFormsApplication1.Properties.Resources.icons8_edit_16;
            this.btnSua.Location = new System.Drawing.Point(220, 300);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(109, 42);
            this.btnSua.TabIndex = 168;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = global::WindowsFormsApplication1.Properties.Resources.icons8_plus_16__1_;
            this.btnThem.Location = new System.Drawing.Point(97, 300);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(109, 42);
            this.btnThem.TabIndex = 167;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(642, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 29);
            this.label5.TabIndex = 165;
            this.label5.Text = "Số Ghế";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(91, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 29);
            this.label3.TabIndex = 163;
            this.label3.Text = "Tên loại xe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(91, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 29);
            this.label2.TabIndex = 162;
            this.label2.Text = "Mã loại xe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(403, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 40);
            this.label1.TabIndex = 161;
            this.label1.Text = "Quản Lý Loại Xe";
            // 
            // txtSoGhe
            // 
            this.txtSoGhe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoGhe.Location = new System.Drawing.Point(774, 118);
            this.txtSoGhe.Name = "txtSoGhe";
            this.txtSoGhe.Size = new System.Drawing.Size(245, 35);
            this.txtSoGhe.TabIndex = 160;
            // 
            // txtTenLoaiXe
            // 
            this.txtTenLoaiXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenLoaiXe.Location = new System.Drawing.Point(278, 174);
            this.txtTenLoaiXe.Name = "txtTenLoaiXe";
            this.txtTenLoaiXe.Size = new System.Drawing.Size(250, 35);
            this.txtTenLoaiXe.TabIndex = 159;
            // 
            // txtMaLoaiXe
            // 
            this.txtMaLoaiXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLoaiXe.Location = new System.Drawing.Point(278, 118);
            this.txtMaLoaiXe.Name = "txtMaLoaiXe";
            this.txtMaLoaiXe.Size = new System.Drawing.Size(250, 35);
            this.txtMaLoaiXe.TabIndex = 158;
            // 
            // lOAIXETableAdapter
            // 
            this.lOAIXETableAdapter.ClearBeforeFill = true;
            // 
            // FormLoaiXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 663);
            this.Controls.Add(this.dgv_LoaiXe);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSoGhe);
            this.Controls.Add(this.txtTenLoaiXe);
            this.Controls.Add(this.txtMaLoaiXe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLoaiXe";
            this.Text = "FormLoaiXe";
            this.Load += new System.EventHandler(this.FormLoaiXe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LoaiXe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_BANVEDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_LoaiXe;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoGhe;
        private System.Windows.Forms.TextBox txtTenLoaiXe;
        private System.Windows.Forms.TextBox txtMaLoaiXe;
        private System.Windows.Forms.BindingSource bindingSource1;
        private QL_BANVEDataSet qL_BANVEDataSet;
        private QL_BANVEDataSetTableAdapters.LOAIXETableAdapter lOAIXETableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mALOAIXEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENLOAIXEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sOGHEDataGridViewTextBoxColumn;
    }
}