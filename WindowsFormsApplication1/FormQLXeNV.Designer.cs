namespace WindowsFormsApplication1
{
    partial class FormQLXeNV
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
            this.button1 = new System.Windows.Forms.Button();
            this.cboLoaiXe = new System.Windows.Forms.ComboBox();
            this.cboMaHSX = new System.Windows.Forms.ComboBox();
            this.dgv_Xe = new System.Windows.Forms.DataGridView();
            this.maxeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENXEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bIENSOXEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mALOAIXEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAHANGSXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.qL_BANVEDataSet = new WindowsFormsApplication1.QL_BANVEDataSet();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBSX = new System.Windows.Forms.TextBox();
            this.txtTenXe = new System.Windows.Forms.TextBox();
            this.txtMaXe = new System.Windows.Forms.TextBox();
            this.xETableAdapter = new WindowsFormsApplication1.QL_BANVEDataSetTableAdapters.XETableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Xe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_BANVEDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::WindowsFormsApplication1.Properties.Resources.icons8_print_16;
            this.button1.Location = new System.Drawing.Point(1021, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 38);
            this.button1.TabIndex = 176;
            this.button1.Text = "In";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cboLoaiXe
            // 
            this.cboLoaiXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLoaiXe.FormattingEnabled = true;
            this.cboLoaiXe.Location = new System.Drawing.Point(885, 181);
            this.cboLoaiXe.Name = "cboLoaiXe";
            this.cboLoaiXe.Size = new System.Drawing.Size(245, 37);
            this.cboLoaiXe.TabIndex = 175;
            // 
            // cboMaHSX
            // 
            this.cboMaHSX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaHSX.FormattingEnabled = true;
            this.cboMaHSX.Location = new System.Drawing.Point(389, 239);
            this.cboMaHSX.Name = "cboMaHSX";
            this.cboMaHSX.Size = new System.Drawing.Size(245, 37);
            this.cboMaHSX.TabIndex = 174;
            // 
            // dgv_Xe
            // 
            this.dgv_Xe.AutoGenerateColumns = false;
            this.dgv_Xe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Xe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maxeDataGridViewTextBoxColumn,
            this.tENXEDataGridViewTextBoxColumn,
            this.bIENSOXEDataGridViewTextBoxColumn,
            this.mALOAIXEDataGridViewTextBoxColumn,
            this.mAHANGSXDataGridViewTextBoxColumn});
            this.dgv_Xe.DataSource = this.bindingSource1;
            this.dgv_Xe.Location = new System.Drawing.Point(208, 382);
            this.dgv_Xe.Name = "dgv_Xe";
            this.dgv_Xe.RowTemplate.Height = 28;
            this.dgv_Xe.Size = new System.Drawing.Size(922, 229);
            this.dgv_Xe.TabIndex = 173;
            this.dgv_Xe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Xe_CellClick);
            // 
            // maxeDataGridViewTextBoxColumn
            // 
            this.maxeDataGridViewTextBoxColumn.DataPropertyName = "Maxe";
            this.maxeDataGridViewTextBoxColumn.HeaderText = "Maxe";
            this.maxeDataGridViewTextBoxColumn.Name = "maxeDataGridViewTextBoxColumn";
            // 
            // tENXEDataGridViewTextBoxColumn
            // 
            this.tENXEDataGridViewTextBoxColumn.DataPropertyName = "TENXE";
            this.tENXEDataGridViewTextBoxColumn.HeaderText = "TENXE";
            this.tENXEDataGridViewTextBoxColumn.Name = "tENXEDataGridViewTextBoxColumn";
            // 
            // bIENSOXEDataGridViewTextBoxColumn
            // 
            this.bIENSOXEDataGridViewTextBoxColumn.DataPropertyName = "BIENSOXE";
            this.bIENSOXEDataGridViewTextBoxColumn.HeaderText = "BIENSOXE";
            this.bIENSOXEDataGridViewTextBoxColumn.Name = "bIENSOXEDataGridViewTextBoxColumn";
            // 
            // mALOAIXEDataGridViewTextBoxColumn
            // 
            this.mALOAIXEDataGridViewTextBoxColumn.DataPropertyName = "MALOAIXE";
            this.mALOAIXEDataGridViewTextBoxColumn.HeaderText = "MALOAIXE";
            this.mALOAIXEDataGridViewTextBoxColumn.Name = "mALOAIXEDataGridViewTextBoxColumn";
            // 
            // mAHANGSXDataGridViewTextBoxColumn
            // 
            this.mAHANGSXDataGridViewTextBoxColumn.DataPropertyName = "MAHANGSX";
            this.mAHANGSXDataGridViewTextBoxColumn.HeaderText = "MAHANGSX";
            this.mAHANGSXDataGridViewTextBoxColumn.Name = "mAHANGSXDataGridViewTextBoxColumn";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "XE";
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
            this.btnTimKiem.Location = new System.Drawing.Point(871, 304);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(143, 38);
            this.btnTimKiem.TabIndex = 172;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(644, 306);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(219, 35);
            this.txtTimKiem.TabIndex = 171;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(753, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 29);
            this.label6.TabIndex = 167;
            this.label6.Text = "Loại xe";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(753, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 29);
            this.label5.TabIndex = 166;
            this.label5.Text = "Biển số xe";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(202, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 29);
            this.label4.TabIndex = 165;
            this.label4.Text = "Hãng sản xuất";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(202, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 29);
            this.label3.TabIndex = 164;
            this.label3.Text = "Tên xe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(202, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 29);
            this.label2.TabIndex = 163;
            this.label2.Text = "Mã xe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(585, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 40);
            this.label1.TabIndex = 162;
            this.label1.Text = "Quản Lý Xe";
            // 
            // txtBSX
            // 
            this.txtBSX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBSX.Location = new System.Drawing.Point(885, 125);
            this.txtBSX.Name = "txtBSX";
            this.txtBSX.Size = new System.Drawing.Size(245, 35);
            this.txtBSX.TabIndex = 161;
            // 
            // txtTenXe
            // 
            this.txtTenXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenXe.Location = new System.Drawing.Point(389, 181);
            this.txtTenXe.Name = "txtTenXe";
            this.txtTenXe.Size = new System.Drawing.Size(250, 35);
            this.txtTenXe.TabIndex = 160;
            // 
            // txtMaXe
            // 
            this.txtMaXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaXe.Location = new System.Drawing.Point(389, 125);
            this.txtMaXe.Name = "txtMaXe";
            this.txtMaXe.Size = new System.Drawing.Size(250, 35);
            this.txtMaXe.TabIndex = 159;
            // 
            // xETableAdapter
            // 
            this.xETableAdapter.ClearBeforeFill = true;
            // 
            // FormQLXeNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 635);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cboLoaiXe);
            this.Controls.Add(this.cboMaHSX);
            this.Controls.Add(this.dgv_Xe);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBSX);
            this.Controls.Add(this.txtTenXe);
            this.Controls.Add(this.txtMaXe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormQLXeNV";
            this.Text = "FormQLXeNV";
            this.Load += new System.EventHandler(this.FormQLXeNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Xe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_BANVEDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cboLoaiXe;
        private System.Windows.Forms.ComboBox cboMaHSX;
        private System.Windows.Forms.DataGridView dgv_Xe;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBSX;
        private System.Windows.Forms.TextBox txtTenXe;
        private System.Windows.Forms.TextBox txtMaXe;
        private System.Windows.Forms.BindingSource bindingSource1;
        private QL_BANVEDataSet qL_BANVEDataSet;
        private QL_BANVEDataSetTableAdapters.XETableAdapter xETableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENXEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bIENSOXEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mALOAIXEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAHANGSXDataGridViewTextBoxColumn;
    }
}