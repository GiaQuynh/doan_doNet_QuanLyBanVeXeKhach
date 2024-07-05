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
    public partial class FormQLKhachHang : Form
    {
        Database db = new Database();
        SqlConnection conn;
        public FormQLKhachHang()
        {
            InitializeComponent();
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            conn = new SqlConnection(connectionString);
        }

        private void FormQLKhachHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_BANVEDataSet.KhachHang' table. You can move, or remove it, as needed.
            this.khachHangTableAdapter.Fill(this.qL_BANVEDataSet.KhachHang);


            cboGioiTinh.Items.Add("Nam");
            cboGioiTinh.Items.Add("Nữ");
            cboGioiTinh.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGioiTinh.SelectedIndex = 0;

            txtCCCD.Enabled = txtDiaChi.Enabled = txtEmail.Enabled = txtHoTen.Enabled = txtMatKhau.Enabled = txtSDT.Enabled = txtTaiKhoan.Enabled = cboGioiTinh.Enabled = dtpNgaySinh.Enabled = false;
        }
        private void ResetForm()
        {
            txtHoTen.Text = "";
            cboGioiTinh.SelectedIndex = 0;
            dtpNgaySinh.Value = DateTime.Now;
            txtEmail.Text = "";
            txtSDT.Text = "";
            txtCCCD.Text = "";
            txtTaiKhoan.Text = "";
            txtMatKhau.Text = "";
            txtDiaChi.Text = "";
        }
        private void LoadData()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM KHACHHANG", conn))
                {
                    DataTable table = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(table);
                    dgv_KhachHang.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }

           txtCCCD.Enabled = txtDiaChi.Enabled = txtEmail.Enabled = txtHoTen.Enabled = txtMatKhau.Enabled = txtSDT.Enabled = txtTaiKhoan.Enabled = cboGioiTinh.Enabled = dtpNgaySinh.Enabled = false;
        }


        private void cboGioiTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = cboGioiTinh.SelectedItem.ToString();
            if (selectedValue != "Nam" && selectedValue != "Nữ")
            {
                cboGioiTinh.SelectedIndex = 0;
            }
        }
        
        private void dgv_KhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_KhachHang.Rows[e.RowIndex];
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Enabled == true)
            {
                if (string.IsNullOrEmpty(txtHoTen.Text) || string.IsNullOrEmpty(txtCCCD.Text) || string.IsNullOrEmpty(txtDiaChi.Text)
                    || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtMatKhau.Text) || string.IsNullOrEmpty(txtSDT.Text)
                    || string.IsNullOrEmpty(txtTaiKhoan.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin khách hàng.");
                    return;
                }

                try
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("insertKhachHang", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@TenKH", txtHoTen.Text);
                        cmd.Parameters.AddWithValue("@NgaySinh", dtpNgaySinh.Value);
                        cmd.Parameters.AddWithValue("@GioiTinh", cboGioiTinh.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);
                        cmd.Parameters.AddWithValue("@CCCD", txtCCCD.Text);
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@SDT", txtSDT.Text);
                        cmd.Parameters.AddWithValue("@TaiKhoan", txtTaiKhoan.Text);
                        cmd.Parameters.AddWithValue("@MatKhau", txtMatKhau.Text);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Thêm khách hàng thành công.");

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
                txtCCCD.Enabled = txtDiaChi.Enabled = txtEmail.Enabled = txtHoTen.Enabled = txtMatKhau.Enabled = txtSDT.Enabled = txtTaiKhoan.Enabled = cboGioiTinh.Enabled = dtpNgaySinh.Enabled = true;
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Enabled == true)
            {
                if (dgv_KhachHang.SelectedRows.Count > 0)
                {
                    int maKh = Convert.ToInt32(dgv_KhachHang.SelectedRows[0].Cells["maKhDataGridViewTextBoxColumn"].Value);
                    try
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("UpdateKhachHang", conn);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@MaKhachHang", maKh);
                        cmd.Parameters.AddWithValue("@TaiKhoan", txtTaiKhoan.Text);
                        cmd.Parameters.AddWithValue("@MatKhau", txtMatKhau.Text);
                        cmd.Parameters.AddWithValue("@NgaySinh", dtpNgaySinh.Value);
                        cmd.Parameters.AddWithValue("@TenKH", txtHoTen.Text);
                        cmd.Parameters.AddWithValue("@GioiTinh", cboGioiTinh.Text);
                        cmd.Parameters.AddWithValue("@SDT", txtSDT.Text);
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@CCCD", txtCCCD.Text);
                        cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Cập nhật thông tin khách hàng thành công!");
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
                txtCCCD.Enabled = txtDiaChi.Enabled = txtEmail.Enabled = txtHoTen.Enabled = txtMatKhau.Enabled = txtSDT.Enabled = txtTaiKhoan.Enabled = cboGioiTinh.Enabled = dtpNgaySinh.Enabled = true;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgv_KhachHang.SelectedRows.Count > 0)
            {
                int maKh = Convert.ToInt32(dgv_KhachHang.SelectedRows[0].Cells["maKhDataGridViewTextBoxColumn"].Value);

                try
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("deleteKhachHang", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MaKh", maKh);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Xóa khách hàng thành công.");
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
                MessageBox.Show("Vui lòng chọn khách hàng cần xóa.");
            }
        }

        private void dgv_KhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_KhachHang.Rows[e.RowIndex];
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

    }
}
