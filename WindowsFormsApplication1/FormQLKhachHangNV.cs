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
    public partial class FormQLKhachHangNV : Form
    {
        Database db = new Database();
        SqlConnection conn;
        public FormQLKhachHangNV()
        {
            InitializeComponent();
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            conn = new SqlConnection(connectionString);
        }

        private void FormQLKhachHangNV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_BANVEDataSet.KhachHang' table. You can move, or remove it, as needed.
            this.khachHangTableAdapter.Fill(this.qL_BANVEDataSet.KhachHang);
            txtMaKH.Enabled = txtCCCD.Enabled = txtDiaChi.Enabled = txtEmail.Enabled = txtHoTen.Enabled = txtMatKhau.Enabled = txtSDT.Enabled = txtTaiKhoan.Enabled = cboGioiTinh.Enabled = dtpNgaySinh.Enabled = false;

        }

        private void dgv_KhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_KhachHang.Rows[e.RowIndex];
                txtMaKH.Text = row.Cells["maKhDataGridViewTextBoxColumn"].Value.ToString();
                txtTaiKhoan.Text = row.Cells["tAIKHOANDataGridViewTextBoxColumn"].Value.ToString();
                txtMatKhau.Text = row.Cells["mATKHAUDataGridViewTextBoxColumn"].Value.ToString();
                dtpNgaySinh.Value = Convert.ToDateTime(row.Cells["nGAYSINHDataGridViewTextBoxColumn"].Value);
                txtHoTen.Text = row.Cells["tenKHDataGridViewTextBoxColumn"].Value.ToString();
                cboGioiTinh.Text = row.Cells["gIOITINHDataGridViewTextBoxColumn"].Value.ToString();
                txtSDT.Text = row.Cells["sDTDataGridViewTextBoxColumn"].Value.ToString();
                txtEmail.Text = row.Cells["eMAILDataGridViewTextBoxColumn"].Value.ToString();
                txtCCCD.Text = row.Cells["cCCDDataGridViewTextBoxColumn"].Value.ToString();
                txtDiaChi.Text = row.Cells["dIACHIDataGridViewTextBoxColumn"].Value.ToString();

            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

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

                using (SqlCommand cmd = new SqlCommand("SELECT * FROM KHACHHANG WHERE TenKH LIKE @Keyword", conn))
                {
                    cmd.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");

                    DataTable table = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(table);

                    if (table.Rows.Count > 0)
                    {
                        dgv_KhachHang.DataSource = table;
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
    }
}
