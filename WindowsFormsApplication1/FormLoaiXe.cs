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
    public partial class FormLoaiXe : Form
    {
        Database db = new Database();
        SqlConnection conn;
        public FormLoaiXe()
        {
            InitializeComponent();
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            conn = new SqlConnection(connectionString);
        }

        private void FormLoaiXe_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_BANVEDataSet.LOAIXE' table. You can move, or remove it, as needed.
            this.lOAIXETableAdapter.Fill(this.qL_BANVEDataSet.LOAIXE);
            txtMaLoaiXe.Enabled = txtTenLoaiXe.Enabled = txtSoGhe.Enabled = false;

        }
        private void ResetForm()
        {
            txtMaLoaiXe.Text = "";
            txtTenLoaiXe.Text = "";
            txtSoGhe.Text = "";

        }
        private void LoadData()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM LOAIXE", conn))
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
            txtMaLoaiXe.Enabled = txtTenLoaiXe.Enabled = txtSoGhe.Enabled = false;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenLoaiXe.Enabled == true)
            {
                try
                {
                    if (string.IsNullOrWhiteSpace(txtMaLoaiXe.Text) || string.IsNullOrWhiteSpace(txtTenLoaiXe.Text) || string.IsNullOrWhiteSpace(txtSoGhe.Text))
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                        return;
                    }

                    conn.Open();

                    SqlCommand cmd = new SqlCommand("insertLoaiXe", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@MALOAIXE", txtMaLoaiXe.Text);
                    cmd.Parameters.AddWithValue("@TENLOAIXE", txtTenLoaiXe.Text);
                    cmd.Parameters.AddWithValue("@SOGHE", txtSoGhe.Text);

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
                txtMaLoaiXe.Enabled = txtTenLoaiXe.Enabled = txtSoGhe.Enabled = true;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtTenLoaiXe.Enabled == true)
            {

                try
                {
                    if (string.IsNullOrWhiteSpace(txtMaLoaiXe.Text) || string.IsNullOrWhiteSpace(txtTenLoaiXe.Text) || string.IsNullOrWhiteSpace(txtSoGhe.Text))
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                        return;
                    }
                    using (SqlCommand cmd = new SqlCommand("updateLoaiXe", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@MALOAIXE", txtMaLoaiXe.Text);
                        cmd.Parameters.AddWithValue("@TENLOAIXE", txtTenLoaiXe.Text); 
                        cmd.Parameters.AddWithValue("@SOGHE", txtSoGhe.Text);

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
                txtTenLoaiXe.Enabled = txtSoGhe.Enabled = true;
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
                using (SqlCommand cmd = new SqlCommand("deleteLoaiXe", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MALOAIXE", maLoaiXe);

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

        private void dgv_LoaiXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_LoaiXe.Rows[e.RowIndex];
                txtMaLoaiXe.Text = row.Cells["mALOAIXEDataGridViewTextBoxColumn"].Value.ToString();
                txtTenLoaiXe.Text = row.Cells["tENLOAIXEDataGridViewTextBoxColumn"].Value.ToString();
                txtSoGhe.Text = row.Cells["sOGHEDataGridViewTextBoxColumn"].Value.ToString();
            }
        }

        private void btnTimKiem_Click_1(object sender, EventArgs e)
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

                using (SqlCommand cmd = new SqlCommand("SELECT * FROM LOAIXE WHERE MALOAIXE LIKE @Keyword", conn))
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
    }
}
