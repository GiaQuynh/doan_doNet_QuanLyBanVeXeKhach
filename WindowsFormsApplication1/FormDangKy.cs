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
    public partial class FormDangKy : Form
    {
        Database db = new Database();
        SqlConnection conn;
        public FormDangKy()
        {
            InitializeComponent();
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            conn = new SqlConnection(connectionString);
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string taiKhoan = txtTaiKhoan.Text;
            string matKhau = txtMatKhau.Text;
            string sdt = txtSDT.Text;
            string email = txtEmail.Text;
            string hoTen = txtHoTen.Text;

            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = conn;
                command.CommandText = "INSERT INTO KhachHang (TaiKhoan, MatKhau, SDT, Email, TenKH) VALUES (@TaiKhoan, @MatKhau, @SDT, @Email, @HoTen)";
                command.Parameters.AddWithValue("@TaiKhoan", taiKhoan);
                command.Parameters.AddWithValue("@MatKhau", matKhau);
                command.Parameters.AddWithValue("@SDT", sdt);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@HoTen", hoTen);

                command.ExecuteNonQuery();

                conn.Close();

                MessageBox.Show("Đăng ký thành công!");
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2601 || ex.Number == 2627)
                {
                    MessageBox.Show("Thông tin TAIKHOAN, SDT hoặc EMAIL đã tồn tại.");
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
                }
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            FormDangNhap dk = new FormDangNhap();
            dk.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
