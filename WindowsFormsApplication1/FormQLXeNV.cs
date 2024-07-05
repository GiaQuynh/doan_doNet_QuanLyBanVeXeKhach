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
    public partial class FormQLXeNV : Form
    {
        Database db = new Database();
        SqlConnection conn;
        public FormQLXeNV()
        {
            InitializeComponent();
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            conn = new SqlConnection(connectionString);
        }

        private void FormQLXeNV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_BANVEDataSet.XE' table. You can move, or remove it, as needed.
            this.xETableAdapter.Fill(this.qL_BANVEDataSet.XE);
            txtMaXe.Enabled = txtBSX.Enabled = txtTenXe.Enabled = cboMaHSX.Enabled = cboLoaiXe.Enabled = false;
        }

        private void dgv_Xe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_Xe.Rows[e.RowIndex];
                txtMaXe.Text = row.Cells["maxeDataGridViewTextBoxColumn"].Value.ToString();
                txtBSX.Text = row.Cells["bIENSOXEDataGridViewTextBoxColumn"].Value.ToString();
                txtTenXe.Text = row.Cells["tENXEDataGridViewTextBoxColumn"].Value.ToString();
                cboMaHSX.Text = row.Cells["mAHANGSXDataGridViewTextBoxColumn"].Value.ToString();
                cboLoaiXe.Text = row.Cells["mALOAIXEDataGridViewTextBoxColumn"].Value.ToString();
            }
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

                using (SqlCommand cmd = new SqlCommand("SELECT * FROM XE WHERE MAXE LIKE @Keyword", conn))
                {
                    cmd.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");

                    DataTable table = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(table);

                    if (table.Rows.Count > 0)
                    {
                        dgv_Xe.DataSource = table;
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

        private void button1_Click(object sender, EventArgs e)
        {
            FormRPXe dk = new FormRPXe();
            dk.ShowDialog();
        }
    }
}
