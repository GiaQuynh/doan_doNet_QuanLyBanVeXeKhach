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
    public partial class FormHuyVe : Form
    {
        Database db = new Database();
        SqlConnection conn;
        public string MaKhachHang { get; set; }
        public FormHuyVe(string maKhachHang)
        {
            InitializeComponent();
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            conn = new SqlConnection(connectionString);
            this.MaKhachHang = maKhachHang;
            this.Load += FormHuyVe_Load;

            List<string> maVeList = new List<string>();
            string query1 = "SELECT MAVE FROM GetVeInformation() WHERE MAKH = @MaKhachHang";

            using (SqlCommand cmd = new SqlCommand(query1, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@MaKhachHang", MaKhachHang);
                SqlDataReader reader1 = cmd.ExecuteReader();

                while (reader1.Read())
                {
                    maVeList.Add(reader1["MAVE"].ToString());
                }
                conn.Close();
                cboMaVe.DataSource = maVeList;

            }
        }

        private void FormHuyVe_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM GetVeInformation() WHERE MAKH = @MaKhachHang", conn))
            {
                cmd.Parameters.AddWithValue("@MaKhachHang", MaKhachHang);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();

                adapter.Fill(dataTable);

                dgv_ThongTinVe.DataSource = dataTable;
            }
            cboMaVe.Enabled = cboTenTuyen.Enabled = txtDiemDen.Enabled = txtDiemXP.Enabled = dtpNgayDen.Enabled = dtpNgayXP.Enabled = txtGioXP.Enabled = txtGioDen.Enabled = txtSoLuong.Enabled = false;
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string maVe = cboMaVe.Text;

                using (SqlCommand cmd = new SqlCommand("HuyVe", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaVe", maVe);

                    int rowsAffected = cmd.ExecuteNonQuery();


                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Hủy vé thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Hủy vé thất bại!");
                    }
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            LoadData();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

        }

        private void dgv_ThongTinVe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy thông tin của dòng được chọn
                DataGridViewRow row = dgv_ThongTinVe.Rows[e.RowIndex];
                cboMaVe.Text = row.Cells["maVeDataGridViewTextBoxColumn"].Value.ToString();
                cboTenTuyen.Text = row.Cells["tenTuyenDataGridViewTextBoxColumn"].Value.ToString();
                txtDiemXP.Text = row.Cells["dataGridViewTextBoxColumn4"].Value.ToString();
                txtDiemDen.Text = row.Cells["dataGridViewTextBoxColumn3"].Value.ToString();
                txtGioXP.Text = row.Cells["gioXPDataGridViewTextBoxColumn"].Value.ToString();
                txtGioDen.Text = row.Cells["gioDenDataGridViewTextBoxColumn"].Value.ToString();
                dtpNgayXP.Value = Convert.ToDateTime(row.Cells["ngayXPDataGridViewTextBoxColumn"].Value);
                dtpNgayDen.Value = Convert.ToDateTime(row.Cells["ngayDenDataGridViewTextBoxColumn"].Value);
                txtSoLuong.Text = row.Cells["sOLUONGDataGridViewTextBoxColumn"].Value.ToString();
            }
        }

        private void cboMaVe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboTenTuyen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
