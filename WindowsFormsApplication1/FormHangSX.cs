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
    public partial class FormHangSX : Form
    {
        Database db = new Database();
        SqlConnection conn;
        public FormHangSX()
        {
            InitializeComponent();
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            conn = new SqlConnection(connectionString);
        }

        private void FormHangSX_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_BANVEDataSet.HANGSX' table. You can move, or remove it, as needed.
            this.hANGSXTableAdapter.Fill(this.qL_BANVEDataSet.HANGSX);
            txtMaLoaiXe.Enabled = txtTenLoaiXe.Enabled = false;

        }

        private void ResetForm()
        {
            txtMaLoaiXe.Text = "";
            txtTenLoaiXe.Text = "";

        }
        private void LoadData()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM HANGSX", conn))
                {
                    DataTable table = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(table);
                    dgv_LoaiXe.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            txtMaLoaiXe.Enabled = txtTenLoaiXe.Enabled = false;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenLoaiXe.Enabled == true)
            {
                try
                {
                    if (string.IsNullOrWhiteSpace(txtMaLoaiXe.Text) || string.IsNullOrWhiteSpace(txtTenLoaiXe.Text))
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                        return;
                    }

                    conn.Open();

                    SqlCommand cmd = new SqlCommand("insertHangSX", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@MAHANGSX", txtMaLoaiXe.Text);
                    cmd.Parameters.AddWithValue("@TENHANGSX", txtTenLoaiXe.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Thêm thành công");

                    ResetForm();
                    LoadData();
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
            else
            {
                txtMaLoaiXe.Enabled = txtTenLoaiXe.Enabled = true;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtTenLoaiXe.Enabled == true)
            {

                try
                {
                    if (string.IsNullOrWhiteSpace(txtMaLoaiXe.Text) || string.IsNullOrWhiteSpace(txtTenLoaiXe.Text))
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                        return;
                    }
                    using (SqlCommand cmd = new SqlCommand("updateHangSX", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@MAHANGSX", txtMaLoaiXe.Text);
                        cmd.Parameters.AddWithValue("@TENHANGSX", txtTenLoaiXe.Text);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();

                        MessageBox.Show("Cập nhật thành công.");
                        LoadData();
                        ResetForm();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
            else
            {
                txtTenLoaiXe.Enabled = true;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maLoaiXe = txtMaLoaiXe.Text;

            if (string.IsNullOrEmpty(maLoaiXe))
            {
                MessageBox.Show("Vui lòng chọn loại xe cần xóa!");
                return;
            }

            try
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("deleteHangSX", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MAHANGSX", maLoaiXe);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công!");
                    ResetForm();
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            conn.Close();
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

                using (SqlCommand cmd = new SqlCommand("SELECT * FROM HANGSX WHERE MAHANGSX LIKE @Keyword", conn))
                {
                    cmd.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");

                    DataTable table = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(table);

                    if (table.Rows.Count > 0)
                    {
                        dgv_LoaiXe.DataSource = table;
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

        private void dgv_LoaiXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_LoaiXe.Rows[e.RowIndex];
                txtMaLoaiXe.Text = row.Cells["mAHANGSXDataGridViewTextBoxColumn"].Value.ToString();
                txtTenLoaiXe.Text = row.Cells["tENHANGSXDataGridViewTextBoxColumn"].Value.ToString();
            }
        }
    }
}
