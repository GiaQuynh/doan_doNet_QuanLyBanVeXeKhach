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
    public partial class FormTraCuu : Form
    {
        Database db = new Database();
        SqlConnection conn;
        public string MaKhachHang { get; set; }
        public FormTraCuu(string maKhachHang)
        {
            db = new Database();
            InitializeComponent();
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            conn = new SqlConnection(connectionString);
            this.MaKhachHang = maKhachHang;
        }

        private void cboTuyenXe_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tenTuyen = cboTuyenXe.SelectedItem.ToString();
            if (!string.IsNullOrEmpty(tenTuyen))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM GetTuyenChuyenInfo() WHERE TenTuyen = @TenTuyen", conn))
                {
                    cmd.Parameters.AddWithValue("@TenTuyen", tenTuyen);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);

                    dgv_Tuyen.DataSource = dataTable;
                }
            }
        }

        private void FormTraCuu_Load(object sender, EventArgs e)
        {
            this.getTuyenChuyenInfoTableAdapter.Fill(this.qL_BANVEDataSet.GetTuyenChuyenInfo);

            List<string> tenTuyenList = new List<string>();
            string query = "SELECT TENTUYEN FROM TUYENXE";
            using (SqlDataReader reader = db.getDataReader(query))
            {
                while (reader.Read())
                {
                    tenTuyenList.Add(reader["TENTUYEN"].ToString());
                }
                cboTuyenXe.DataSource = tenTuyenList;
            }
            txtThanhTien.Enabled = true;
        }

        private void dtpNgaySinh_ValueChanged(object sender, EventArgs e)
        {
            string ngayXP = dtpNgayXP.Value.ToString("yyyy-MM-dd");
            string tenTuyen = cboTuyenXe.SelectedItem.ToString();

            if (!string.IsNullOrEmpty(tenTuyen))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM GetTuyenChuyenInfo() WHERE TenTuyen = @TenTuyen AND NgayXP = @NgayXP", conn))
                {
                    cmd.Parameters.AddWithValue("@TenTuyen", tenTuyen);
                    cmd.Parameters.AddWithValue("@NgayXP", ngayXP);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);

                    dgv_Tuyen.DataSource = dataTable;
                }
            }
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            if (cboMaChuyen.Text != null && !string.IsNullOrEmpty(txtSoLuong.Text))
            {
                string maChuyen = cboMaChuyen.Text;
                int soLuong;
                if (int.TryParse(txtSoLuong.Text, out soLuong))
                {
                    int giaVe = 0;
                    using (SqlCommand cmd = new SqlCommand("SELECT GIA FROM GetTuyenChuyenInfo() WHERE MACHUYEN = @MACHUYEN", conn))
                    {
                        cmd.Parameters.AddWithValue("@MACHUYEN", maChuyen);
                        conn.Open();
                        object result = cmd.ExecuteScalar();
                        int gia;
                        if (result != null && int.TryParse(result.ToString(), out gia))
                        {
                            giaVe = gia;
                        }
                        conn.Close();
                    }
                    int thanhTien = soLuong * giaVe;
                    txtThanhTien.Text = thanhTien.ToString("N0");
                }
                else
                {
                    txtThanhTien.Text = "";
                }
            }
        }

        private void btnDatVe_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string maChuyen = cboMaChuyen.Text;

                float thanhtien;
                bool isSuccess = float.TryParse(txtThanhTien.Text, out thanhtien);
                string soluong = txtSoLuong.Text;

                DateTime ngaydatve = DateTime.Now;
                using (SqlCommand cmd = new SqlCommand("InsertVe", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaChuyen", maChuyen);
                    cmd.Parameters.AddWithValue("@MaKH", MaKhachHang);
                    cmd.Parameters.AddWithValue("@ThanhTien", thanhtien);
                    cmd.Parameters.AddWithValue("@SoLuong", soluong);
                    cmd.Parameters.AddWithValue("@NgayDatVe", ngaydatve);

                    int rowsAffected = cmd.ExecuteNonQuery();


                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Đặt vé thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Đặt vé thất bại!");
                    }
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void dgv_Tuyen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy thông tin của dòng được chọn
                DataGridViewRow row = dgv_Tuyen.Rows[e.RowIndex];
                cboMaChuyen.Text = row.Cells["maChuyenDataGridViewTextBoxColumn"].Value.ToString();
                cboTuyenXe.Text = row.Cells["tenTuyenDataGridViewTextBoxColumn"].Value.ToString();
                dtpNgayXP.Text = row.Cells["ngayXPDataGridViewTextBoxColumn"].Value.ToString();
            }
        }
    }
}
