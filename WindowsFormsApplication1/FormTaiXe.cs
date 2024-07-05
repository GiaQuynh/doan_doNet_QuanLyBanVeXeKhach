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
    public partial class FormTaiXe : Form
    {
        Database db = new Database();
        SqlConnection conn;
        public FormTaiXe()
        {
            InitializeComponent();
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            conn = new SqlConnection(connectionString);
        }

        private void FormTaiXe_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_BANVEDataSet.Taixe' table. You can move, or remove it, as needed.
            this.taixeTableAdapter.Fill(this.qL_BANVEDataSet.Taixe);

            cboGioiTinh.Items.Add("Nam");
            cboGioiTinh.Items.Add("Nữ");
            cboGioiTinh.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGioiTinh.SelectedIndex = 0;

            txtMaTX.Enabled = txtCCCD.Enabled = txtDiaChi.Enabled = txtEmail.Enabled = txtHoTen.Enabled = txtSDT.Enabled = cboGioiTinh.Enabled = dtpNgaySinh.Enabled = false;

        }
        private void ResetForm()
        {
            txtHoTen.Text = "";
            cboGioiTinh.SelectedIndex = 0;
            dtpNgaySinh.Value = DateTime.Now;
            txtEmail.Text = "";
            txtSDT.Text = "";
            txtCCCD.Text = "";
            txtDiaChi.Text = "";
        }
        private void LoadData()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM TAIXE", conn))
                {
                    DataTable table = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(table);
                    dgv_TaiXe.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }

            txtMaTX.Enabled = txtCCCD.Enabled = txtDiaChi.Enabled = txtEmail.Enabled = txtHoTen.Enabled = txtSDT.Enabled = cboGioiTinh.Enabled = dtpNgaySinh.Enabled = false;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Enabled == true)
            {
                // Kiểm tra dữ liệu đầu vào
                if (string.IsNullOrEmpty(txtHoTen.Text) || string.IsNullOrEmpty(txtCCCD.Text) || string.IsNullOrEmpty(txtDiaChi.Text)
                    || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtSDT.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                    return;
                }

                try
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("insertTaiXe", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MaTX", txtMaTX.Text);
                        cmd.Parameters.AddWithValue("@TenTX", txtHoTen.Text);
                        cmd.Parameters.AddWithValue("@NgaySinh", dtpNgaySinh.Value);
                        cmd.Parameters.AddWithValue("@GioiTinh", cboGioiTinh.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);
                        cmd.Parameters.AddWithValue("@CCCD", txtCCCD.Text);
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@SDT", txtSDT.Text);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Thêm tài xế thành công.");

                        ResetForm();
                        LoadData();
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
            else
            {
                txtCCCD.Enabled = txtDiaChi.Enabled = txtEmail.Enabled = txtHoTen.Enabled = txtSDT.Enabled = cboGioiTinh.Enabled = dtpNgaySinh.Enabled = true;
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Enabled == true)
            {
                if (dgv_TaiXe.SelectedRows.Count > 0)
                {
                    try
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("UpdateTaiXe", conn);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@MaTX", txtMaTX.Text);
                        cmd.Parameters.AddWithValue("@NgaySinh", dtpNgaySinh.Value);
                        cmd.Parameters.AddWithValue("@TenKH", txtHoTen.Text);
                        cmd.Parameters.AddWithValue("@GioiTinh", cboGioiTinh.Text);
                        cmd.Parameters.AddWithValue("@SDT", txtSDT.Text);
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@CCCD", txtCCCD.Text);
                        cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Cập nhật thông tin tài xế thành công!");
                        LoadData();
                        ResetForm();
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
            else
            {
                txtCCCD.Enabled = txtDiaChi.Enabled = txtEmail.Enabled = txtHoTen.Enabled = txtSDT.Enabled = cboGioiTinh.Enabled = dtpNgaySinh.Enabled = true;
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

        private void cboGioiTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = cboGioiTinh.SelectedItem.ToString();
            if (selectedValue != "Nam" && selectedValue != "Nữ")
            {
                cboGioiTinh.SelectedIndex = 0;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maTX = txtMaTX.Text;

            if (string.IsNullOrEmpty(maTX))
            {
                MessageBox.Show("Vui lòng chọn tài xế cần xóa!");
                return;
            }

            try
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("deleteTaiXe", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaTX", maTX);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    MessageBox.Show("Xóa tài xế thành công!");
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

        private void dgv_TaiXe_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            FormRPTaiXe dk = new FormRPTaiXe();
            dk.ShowDialog();
        }

    }
}
