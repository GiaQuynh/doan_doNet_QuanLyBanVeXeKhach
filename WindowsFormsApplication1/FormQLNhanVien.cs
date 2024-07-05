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
    public partial class FormQLNhanVien : Form
    {
        Database db = new Database();
        SqlConnection conn;
        public FormQLNhanVien()
        {
            InitializeComponent();
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            conn = new SqlConnection(connectionString);
        }

        private void FormQLNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_BANVEDataSet.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.qL_BANVEDataSet.NhanVien);
            
            string queryMACV = "SELECT MACHUCVU FROM CHUCVU";
            List<string> listMACV = new List<string>();
            using (SqlDataReader readerMAPB = db.getDataReader(queryMACV))
            {
                while (readerMAPB.Read())
                {
                    listMACV.Add(readerMAPB["MACHUCVU"].ToString());
                }
            }
            cboMaCV.DataSource = listMACV;

            cboGioiTinh.Items.Add("Nam");
            cboGioiTinh.Items.Add("Nữ");
            cboGioiTinh.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGioiTinh.SelectedIndex = 0;

            cboMaCV.SelectedIndex = -1;

            txtMaNV.Enabled = txtCCCD.Enabled = txtDiaChi.Enabled = txtEmail.Enabled = txtHoTen.Enabled = txtMatKhau.Enabled = txtSDT.Enabled = txtTaiKhoan.Enabled = cboGioiTinh.Enabled =  dtpNgaySinh.Enabled = false;
        }
        private void ResetForm()
        {
            txtMaNV.Text = "";
            txtHoTen.Text = "";
            cboGioiTinh.SelectedIndex = 0;
            dtpNgaySinh.Value = DateTime.Now;
            txtEmail.Text = "";
            txtSDT.Text = "";
            txtCCCD.Text = "";
            cboMaCV.SelectedIndex = -1;
            txtTaiKhoan.Text = "";
            txtMatKhau.Text = "";
            txtDiaChi.Text = "";
        }
        private void LoadData()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM NHANVIEN", conn))
                {
                    DataTable table = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(table);
                    dgv_QLNhanVien.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }

            txtMaNV.Enabled = txtCCCD.Enabled = txtDiaChi.Enabled = txtEmail.Enabled = txtHoTen.Enabled = txtMatKhau.Enabled = txtSDT.Enabled = txtTaiKhoan.Enabled = cboGioiTinh.Enabled = dtpNgaySinh.Enabled = false;
        }
        private void cboMaCV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMaCV.SelectedIndex != -1)
            {
                string maCV = cboMaCV.SelectedItem.ToString();

                using (SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.GetNhanVienByChucVu(@MACHUCVU)", conn))
                {
                    cmd.Parameters.AddWithValue("@MACHUCVU", maCV);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);
                    dgv_QLNhanVien.DataSource = dataTable;
                }
            }
            else
            {

                using (SqlCommand cmd = new SqlCommand("SELECT * FROM NHANVIEN", conn))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);
                    dgv_QLNhanVien.DataSource = dataTable;
                }
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
        private void dgv_QLNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_QLNhanVien.Rows[e.RowIndex];
                txtMaNV.Text = row.Cells["maNVDataGridViewTextBoxColumn"].Value.ToString();
                cboMaCV.Text = row.Cells["mACHUCVUDataGridViewTextBoxColumn"].Value.ToString();
                txtTaiKhoan.Text = row.Cells["tAIKHOANDataGridViewTextBoxColumn"].Value.ToString();
                txtMatKhau.Text = row.Cells["mATKHAUDataGridViewTextBoxColumn"].Value.ToString();
                dtpNgaySinh.Value = Convert.ToDateTime(row.Cells["nGAYSINHDataGridViewTextBoxColumn"].Value);
                txtHoTen.Text = row.Cells["tenNVDataGridViewTextBoxColumn"].Value.ToString();
                cboGioiTinh.Text = row.Cells["gIOITINHDataGridViewTextBoxColumn"].Value.ToString();
                txtSDT.Text = row.Cells["sDTDataGridViewTextBoxColumn"].Value.ToString();
                txtEmail.Text = row.Cells["eMAILDataGridViewTextBoxColumn"].Value.ToString();
                txtCCCD.Text = row.Cells["cCCDDataGridViewTextBoxColumn"].Value.ToString();
                txtDiaChi.Text = row.Cells["dIACHIDataGridViewTextBoxColumn"].Value.ToString();

            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Enabled == true) // Thêm
            { 
                try
                {
                    conn.Open();
                    string manv = txtMaNV.Text;
                    string tenvn = txtHoTen.Text;
                    string gioitinh = cboGioiTinh.SelectedItem.ToString();
                    DateTime ngaysinh = dtpNgaySinh.Value;
                    string email = txtEmail.Text;
                    string sdt = txtSDT.Text;
                    string cccd = txtCCCD.Text;
                    string macv = cboMaCV.SelectedItem.ToString();
                    string taikhoan = txtTaiKhoan.Text;
                    string matkhau = txtMatKhau.Text;
                    string diachi = txtDiaChi.Text;
                    using (SqlCommand cmd = new SqlCommand("InsertNhanVien", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MaNV", manv);
                        cmd.Parameters.AddWithValue("@TenNV", tenvn);
                        cmd.Parameters.AddWithValue("@GioiTinh", gioitinh);
                        cmd.Parameters.AddWithValue("@NgaySinh", ngaysinh);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@SDT", sdt);
                        cmd.Parameters.AddWithValue("@CCCD", cccd);
                        cmd.Parameters.AddWithValue("@MaChucVu", macv);
                        cmd.Parameters.AddWithValue("@TaiKhoan", taikhoan);
                        cmd.Parameters.AddWithValue("@MatKhau", matkhau);
                        cmd.Parameters.AddWithValue("@DiaChi", diachi);


                        int rowsAffected = cmd.ExecuteNonQuery();


                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Thêm nhân viên thành công!");
                            ResetForm();
                            LoadData();

                        }
                        else
                        {
                            MessageBox.Show("Thêm nhân viên thất bại!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
                conn.Close();

            }
            else
            {
                txtMaNV.Enabled = txtCCCD.Enabled = txtDiaChi.Enabled = txtEmail.Enabled = txtHoTen.Enabled = txtMatKhau.Enabled = txtSDT.Enabled = txtTaiKhoan.Enabled = cboGioiTinh.Enabled = cboMaCV.Enabled = dtpNgaySinh.Enabled = true;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text != "" && txtHoTen.Enabled == true)
            {            
                try
                {
                    conn.Open();
                    string manv = txtMaNV.Text;
                    string tenvn = txtHoTen.Text;
                    string gioitinh = cboGioiTinh.SelectedItem.ToString();
                    DateTime ngaysinh = dtpNgaySinh.Value;
                    string email = txtEmail.Text;
                    string sdt = txtSDT.Text;
                    string cccd = txtCCCD.Text;
                    string macv = cboMaCV.SelectedItem.ToString();
                    string taikhoan = txtTaiKhoan.Text;
                    string matkhau = txtMatKhau.Text;
                    string diachi = txtDiaChi.Text;

                    using (SqlCommand cmd = new SqlCommand("UpdateNhanVien", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MaNV", manv);
                        cmd.Parameters.AddWithValue("@TenNV", tenvn);
                        cmd.Parameters.AddWithValue("@GioiTinh", gioitinh);
                        cmd.Parameters.AddWithValue("@NgaySinh", ngaysinh);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@SDT", sdt);
                        cmd.Parameters.AddWithValue("@CCCD", cccd);
                        cmd.Parameters.AddWithValue("@MaChucVu", macv);
                        cmd.Parameters.AddWithValue("@TaiKhoan", taikhoan);
                        cmd.Parameters.AddWithValue("@MatKhau", matkhau);
                        cmd.Parameters.AddWithValue("@DiaChi", diachi);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cập nhật nhân viên thành công!");
                            ResetForm();
                            LoadData();
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật nhân viên thất bại!");
                        }
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
            else
            {
                txtCCCD.Enabled = txtDiaChi.Enabled = txtEmail.Enabled = txtHoTen.Enabled = txtMatKhau.Enabled = txtSDT.Enabled = txtTaiKhoan.Enabled = cboGioiTinh.Enabled = cboMaCV.Enabled = dtpNgaySinh.Enabled = true;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMaNV.Text))
            {
                try
                {
                    conn.Open();
                    string manv = txtMaNV.Text;

                    using (SqlCommand cmd = new SqlCommand("DeleteNhanVien", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MaNV", manv);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Xóa nhân viên thành công!");
                            ResetForm();
                            LoadData();
                        }
                        else
                        {
                            MessageBox.Show("Xóa nhân viên thất bại!");
                        }
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void dgv_QLNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_QLNhanVien.Rows[e.RowIndex];
                txtMaNV.Text = row.Cells["maNVDataGridViewTextBoxColumn"].Value.ToString();
                cboMaCV.Text = row.Cells["mACHUCVUDataGridViewTextBoxColumn"].Value.ToString();
                txtTaiKhoan.Text = row.Cells["tAIKHOANDataGridViewTextBoxColumn"].Value.ToString();
                txtMatKhau.Text = row.Cells["mATKHAUDataGridViewTextBoxColumn"].Value.ToString();
                dtpNgaySinh.Value = Convert.ToDateTime(row.Cells["nGAYSINHDataGridViewTextBoxColumn"].Value);
                txtHoTen.Text = row.Cells["tenNVDataGridViewTextBoxColumn"].Value.ToString();
                cboGioiTinh.Text = row.Cells["gIOITINHDataGridViewTextBoxColumn"].Value.ToString();
                txtSDT.Text = row.Cells["sDTDataGridViewTextBoxColumn"].Value.ToString();
                txtEmail.Text = row.Cells["eMAILDataGridViewTextBoxColumn"].Value.ToString();
                txtCCCD.Text = row.Cells["cCCDDataGridViewTextBoxColumn"].Value.ToString();
                txtDiaChi.Text = row.Cells["dIACHIDataGridViewTextBoxColumn"].Value.ToString();

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

                using (SqlCommand cmd = new SqlCommand("SELECT * FROM NHANVIEN WHERE MaNV LIKE @Keyword", conn))
                {
                    cmd.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");

                    DataTable table = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(table);

                    if (table.Rows.Count > 0)
                    {
                        dgv_QLNhanVien.DataSource = table;
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
            FormRPNhanVien dk = new FormRPNhanVien();
            dk.ShowDialog();
        }
    }
}
