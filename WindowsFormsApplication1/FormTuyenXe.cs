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
    public partial class FormTuyenXe : Form
    {
        Database db = new Database();
        SqlConnection conn;
        public FormTuyenXe()
        {
            InitializeComponent();
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            conn = new SqlConnection(connectionString);
        }

        private void FormTuyenXe_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_BANVEDataSet.TuyenXe' table. You can move, or remove it, as needed.
            this.tuyenXeTableAdapter.Fill(this.qL_BANVEDataSet.TuyenXe);
        }

        private void ResetForm()
        {
            txtMaTuyen.Text = "";
            txtDiemDi.Text = "";
            txtDiemDen.Text = "";
            txtTenTuyen.Text = "";
        }
        private void LoadData()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM TUYENXE", conn))
                {
                    DataTable table = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(table);
                    dgv_Tuyen.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            txtMaTuyen.Enabled = txtDiemDen.Enabled = txtDiemDi.Enabled = txtTenTuyen.Enabled = false;
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (txtTenTuyen.Enabled == true)
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("updateTuyenXe", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@MaTuyen", txtMaTuyen.Text);
                        cmd.Parameters.AddWithValue("@TenTuyen", txtTenTuyen.Text);
                        cmd.Parameters.AddWithValue("@DiemXP", txtDiemDi.Text);
                        cmd.Parameters.AddWithValue("@DiemDen", txtDiemDen.Text);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();

                        MessageBox.Show("Cập nhật tuyến xe thành công.");
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
                txtDiemDen.Enabled = txtDiemDi.Enabled = txtTenTuyen.Enabled = true;
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            string maTuyenXe = txtMaTuyen.Text;

            if (string.IsNullOrEmpty(maTuyenXe))
            {
                MessageBox.Show("Vui lòng chọn tuyến xe cần xóa!");
                return;
            }

            try
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("deleteTuyenXe", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaTuyen", maTuyenXe);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    MessageBox.Show("Xóa tuyến xe thành công!");
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

        private void dgv_Tuyen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_Tuyen.Rows[e.RowIndex];
                txtMaTuyen.Text = row.Cells["maTuyenDataGridViewTextBoxColumn"].Value.ToString();
                txtTenTuyen.Text = row.Cells["tenTuyenDataGridViewTextBoxColumn"].Value.ToString();
                txtDiemDi.Text = row.Cells["diemXPDataGridViewTextBoxColumn"].Value.ToString();
                txtDiemDen.Text = row.Cells["diemDenDataGridViewTextBoxColumn"].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenTuyen.Enabled == true)
            {
                try
                {
                    if (string.IsNullOrWhiteSpace(txtMaTuyen.Text) || string.IsNullOrWhiteSpace(txtTenTuyen.Text) || string.IsNullOrWhiteSpace(txtDiemDi.Text) || string.IsNullOrWhiteSpace(txtDiemDen.Text))
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin tuyến xe");
                        return;
                    }

                    conn.Open();

                    SqlCommand cmd = new SqlCommand("insertTuyenXe", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@MaTuyen", txtMaTuyen.Text);
                    cmd.Parameters.AddWithValue("@TenTuyen", txtTenTuyen.Text);
                    cmd.Parameters.AddWithValue("@DiemXP", txtDiemDi.Text);
                    cmd.Parameters.AddWithValue("@DiemDen", txtDiemDen.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Thêm tuyến xe thành công");

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
                txtMaTuyen.Enabled = txtDiemDen.Enabled = txtDiemDi.Enabled = txtTenTuyen.Enabled = true;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                string maTuyen = txtMaTuyen.Text;
                using (SqlCommand cmd = new SqlCommand("findTuyen", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaTuyen", maTuyen);

                    DataTable table = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(table);
                    dgv_Tuyen.DataSource = table;

                    if (table.Rows.Count >= 0)
                    {
                        MessageBox.Show("Tìm kiếm thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy tuyến xe!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
