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
    public partial class FormDangNhap : Form
    {
        Database db = new Database();
        SqlConnection conn;
        public FormDangNhap()
        {
            InitializeComponent();
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            conn = new SqlConnection(connectionString);
        }
        private string maNhanVien;
        private string maKhachHang; //Thêm biến maKhachHang để lưu mã khách hàng
        public string MaNhanVien { get { return maNhanVien; } }
        public string MaKhachHang { get { return maKhachHang; } }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text == "" || txtMatKhau.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Tài Khoản và Mật Khẩu", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                conn.Open();

                SqlCommand cmdNhanVien = new SqlCommand("select MaChucVu from NHANVIEN where TaiKhoan='" + txtTaiKhoan.Text + "' and MATKHAU='" + txtMatKhau.Text + "'", conn);
                string chucVuNhanVien = Convert.ToString(cmdNhanVien.ExecuteScalar());

                SqlCommand cmdKhachHang = new SqlCommand("select MAKH, TaiKhoan, MatKhau from KhachHang where TaiKhoan='" + txtTaiKhoan.Text + "' and MATKHAU='" + txtMatKhau.Text + "'", conn);
                SqlDataReader readerKhachHang = cmdKhachHang.ExecuteReader();
                
                if (chucVuNhanVien.Trim() == "CV001")
                {
                    conn.Close();
                    conn.Open();
                    SqlCommand ccmdMaNhanVien = new SqlCommand("select MANV from NHANVIEN where TaiKhoan='" + txtTaiKhoan.Text + "' and MATKHAU='" + txtMatKhau.Text + "'", conn);
                    maNhanVien = Convert.ToString(ccmdMaNhanVien.ExecuteScalar());

                    FormAdmin ad = new FormAdmin(maNhanVien);
                    ad.MaNhanVien = maNhanVien;
                    ad.ShowDialog();
                    this.Close();

                }
                else if (chucVuNhanVien.Trim() == "CV002")
                {
                    conn.Close();
                    conn.Open();
                    SqlCommand cccmdMaNhanVien = new SqlCommand("select MANV from NHANVIEN where TaiKhoan='" + txtTaiKhoan.Text + "' and MATKHAU='" + txtMatKhau.Text + "'", conn);
                    maNhanVien = Convert.ToString(cccmdMaNhanVien.ExecuteScalar());

                    FormNhanVien nv = new FormNhanVien(maNhanVien);
                    nv.MaNhanVien = maNhanVien;
                    nv.ShowDialog();
                    this.Close();
                }
                else if (readerKhachHang.Read())
                {
                    maKhachHang = readerKhachHang["MAKH"].ToString(); // Lưu mã khách hàng vào biến maKhachHang
                    FormKhachHang ttkh = new FormKhachHang(maKhachHang);
                    ttkh.MaKhachHang = maKhachHang; // Truyền mã khách hàng vào FormThongTinKhachHang
                    ttkh.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tài Khoản hoặc Mật Khẩu không tồn tại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTaiKhoan.Clear();
                    txtMatKhau.Clear();
                }

                readerKhachHang.Close(); // Close the SqlDataReader

                conn.Close();
            }
        }

        private void FormDangNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap.PerformClick();
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            FormDangKy dk = new FormDangKy();
            dk.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}