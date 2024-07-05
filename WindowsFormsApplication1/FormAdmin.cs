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
    public partial class FormAdmin : Form
    {
        Database db = new Database();
        SqlConnection conn;

        public string MaNhanVien { get; set; }

        public FormAdmin(string maNhanVien)
        {
            InitializeComponent();
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            conn = new SqlConnection(connectionString);
            this.MaNhanVien = maNhanVien;
        }
        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(childForm);
            panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnQLKhachHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormQLKhachHang());
        }

        private void btnQLChuyenXe_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormQLChuyenXe());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void btnThongTin_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormThongTinNhanVien(MaNhanVien));
        }

        private void btnQLNhanVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormQLNhanVien());
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormRPDoanhThuTheoTuan());
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
            FormDangNhap dn = new FormDangNhap();
            dn.ShowDialog();
            
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            using (SqlCommand cmd = new SqlCommand("SELECT TENNV FROM NHANVIEN WHERE MANV = @MANV", conn))
            {
                cmd.Parameters.AddWithValue("@MANV", MaNhanVien);
                conn.Open();
                User.Text = cmd.ExecuteScalar().ToString();
                conn.Close();
            }
        }

        private void btnQLTuyenXe_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormTuyenXe());

        }

        private void panelside_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormXe());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormHangSX());

        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormLoaiXe());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormTaiXe());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormChucVu ());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormRPTongVe());

        }
    }
}
