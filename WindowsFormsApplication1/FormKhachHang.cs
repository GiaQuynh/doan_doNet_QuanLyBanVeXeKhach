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
    public partial class FormKhachHang : Form
    {
        Database db = new Database();
        SqlConnection conn;
        public bool isThoat = true;
        public string MaKhachHang { get; set; }

        public FormKhachHang(string maKhachHang)
        {
            InitializeComponent();
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            conn = new SqlConnection(connectionString);
            this.MaKhachHang = maKhachHang;
            this.Load += FormKhachHang_Load;
        }

        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            using (SqlCommand cmd = new SqlCommand("SELECT TENKH FROM KHACHHANG WHERE MAKH = @MAKH", conn))
            {
                cmd.Parameters.AddWithValue("@MAKH", MaKhachHang);
                conn.Open();
                User.Text = cmd.ExecuteScalar().ToString();
                conn.Close();
            }
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

        private void button10_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormTraCuu(MaKhachHang));
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
                currentFormChild.Dispose(); //Thêm dòng này để giải phóng bộ nhớ khi đóng form
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormHuyVe(MaKhachHang));
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormDoiVeXe(MaKhachHang));
        }

        private void btnThongTin_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormThongTinKhachHang(MaKhachHang)); //Sửa thành MaKhachHang
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormThongTinVe(MaKhachHang));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormDangNhap dk = new FormDangNhap();
            dk.ShowDialog();
            this.Close();
        }
    }
}