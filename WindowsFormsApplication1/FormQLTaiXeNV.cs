using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WindowsFormsApplication1
{
    public partial class FormQLTaiXeNV : Form
    {
        Database db = new Database();
        SqlConnection conn;
        public FormQLTaiXeNV()
        {
            InitializeComponent();
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            conn = new SqlConnection(connectionString);
        }

        private void FormQLTaiXeNV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_BANVEDataSet.Taixe' table. You can move, or remove it, as needed.
            this.taixeTableAdapter.Fill(this.qL_BANVEDataSet.Taixe);
            txtMaTX.Enabled = txtCCCD.Enabled = txtDiaChi.Enabled = txtEmail.Enabled = txtHoTen.Enabled = txtSDT.Enabled = cboGioiTinh.Enabled = dtpNgaySinh.Enabled = false;

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm.");
                return;
            }

            try
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("SELECT * FROM TAIXE WHERE MATX LIKE @Keyword", conn))
                {
                    cmd.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");

                    DataTable table = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(table);

                    if (table.Rows.Count > 0)
                    {
                        dgv_TaiXe.DataSource = table;
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy kết quả nào.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void dgv_TaiXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_TaiXe.Rows[e.RowIndex];
                dtpNgaySinh.Value = Convert.ToDateTime(row.Cells["nGAYSINHDataGridViewTextBoxColumn"].Value);
                txtMaTX.Text = row.Cells["maTXDataGridViewTextBoxColumn"].Value.ToString();
                txtHoTen.Text = row.Cells["tenTXDataGridViewTextBoxColumn"].Value.ToString();
                cboGioiTinh.Text = row.Cells["gIOITINHDataGridViewTextBoxColumn"].Value.ToString();
                txtSDT.Text = row.Cells["sDTDataGridViewTextBoxColumn"].Value.ToString();
                txtEmail.Text = row.Cells["eMAILDataGridViewTextBoxColumn"].Value.ToString();
                txtCCCD.Text = row.Cells["cCCDDataGridViewTextBoxColumn"].Value.ToString();
                txtDiaChi.Text = row.Cells["dIACHIDataGridViewTextBoxColumn"].Value.ToString();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormRPTaiXe dk = new FormRPTaiXe();
            dk.ShowDialog();
        }
    }
}
