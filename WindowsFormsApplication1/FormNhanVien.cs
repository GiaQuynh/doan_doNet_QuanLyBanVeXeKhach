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
    public partial class FormNhanVien : Form
    {
        Database db = new Database();
        SqlConnection conn;
        public string MaNhanVien { get; set; }
        public FormNhanVien(string maNhanVien)
        {
            InitializeComponent();
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            conn = new SqlConnection(connectionString);
            this.MaNhanVien = maNhanVien;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private Form currentFormChild;

        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
                currentFormChild.Dispose(); //Thêm dòng này để giải phóng bộ nhớ khi đóng form
            }

            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(childForm);
            panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnQLChuyenXe_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormQLChuyenXeNV());
        }

        private void btnQLKhachHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormQLKhachHangNV());

        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormRPDoanhThuTheoTuan());

        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            using (SqlCommand cmd = new SqlCommand("SELECT TENNV FROM NHANVIEN WHERE MANV = @MANV", conn))
            {
                cmd.Parameters.AddWithValue("@MANV", MaNhanVien);
                conn.Open();
                User.Text = cmd.ExecuteScalar().ToString();
                conn.Close();
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            FormDangNhap dk = new FormDangNhap();
            dk.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormRPDoanhThuTheoTuyenXe());
        }

        private void btnThongTin_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new FormThongTinNhanVien(MaNhanVien));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormQLXeNV());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormQLTaiXeNV());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormRPTongVe());
        }
    }
}
