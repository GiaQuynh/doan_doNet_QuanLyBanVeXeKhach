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
    public partial class FormThongTinNhanVien : Form
    {
        Database db = new Database();
        SqlConnection conn;
        public string MaNhanVien { get; set; }
        public FormThongTinNhanVien(string maNhanVien)
        {
            InitializeComponent();
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            conn = new SqlConnection(connectionString);
            this.MaNhanVien = maNhanVien;
            this.Load += FormThongTinNhanVien_Load;
        }

        private void txtTaiKhoan_TextChanged(object sender, EventArgs e)
        {
        }

        private void FormThongTinNhanVien_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM NHANVIEN WHERE MANV = @MANV";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@MANV", MaNhanVien);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtTaiKhoan.Text = reader["TAIKHOAN"].ToString();
                    txtMatKhau.Text = reader["MATKHAU"].ToString();
                    txtHoTen.Text = reader["TenNV"].ToString();
                    txtGioiTinh.Text = reader["GIOITINH"].ToString();
                    txtSDT.Text = reader["SDT"].ToString();
                    dtpNgaySinh.Text = reader["NGAYSINH"].ToString();
                    txtCCCD.Text = reader["CCCD"].ToString();
                    txtEmail.Text = reader["Email"].ToString();
                    txtDiaChi.Text = reader["DiaChi"].ToString();
                }
                conn.Close();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string query = "EXEC UpdateNhanVien1 @MaKhachHang, @TenNV, @NgaySinh, @GioiTinh, @DiaChi, @CCCD, @Email, @SDT, @TaiKhoan, @MatKhau";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@MaKhachHang", MaNhanVien);
                cmd.Parameters.AddWithValue("@TenNV", txtHoTen.Text);
                cmd.Parameters.AddWithValue("@NgaySinh", DateTime.Parse(dtpNgaySinh.Text));
                cmd.Parameters.AddWithValue("@GioiTinh", txtGioiTinh.Text);
                cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);
                cmd.Parameters.AddWithValue("@CCCD", txtCCCD.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@SDT", txtSDT.Text);
                cmd.Parameters.AddWithValue("@TaiKhoan", txtTaiKhoan.Text);
                cmd.Parameters.AddWithValue("@MatKhau", txtMatKhau.Text);

                conn.Open();
                int result = cmd.ExecuteNonQuery();
                conn.Close();

                if (result > 0)
                {
                    MessageBox.Show("Cập nhật thông tin thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không thể cập nhật thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
