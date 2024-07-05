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
    public partial class FormDoiVeXe : Form
    {
        Database db = new Database();
        SqlConnection conn;
        public string MaKhachHang { get; set; }
        public FormDoiVeXe(string maKhachHang)
        {
            InitializeComponent();
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            conn = new SqlConnection(connectionString);
            this.MaKhachHang = maKhachHang;
            this.Load += FormDoiVeXe_Load;
        }

        private void FormDoiVeXe_Load(object sender, EventArgs e)
        {
            LoadData();
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
            
            
            List<string> tenTuyenList = new List<string>();
            string query = "SELECT TENTUYEN FROM TUYENXE";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    tenTuyenList.Add(reader["TENTUYEN"].ToString());
                }
                conn.Close();
                cboTenTuyen.DataSource = tenTuyenList; 
                
            }
           
            
        }
        private void cboTenTuyen_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tenTuyen = cboTenTuyen.SelectedItem.ToString();
            if (!string.IsNullOrEmpty(tenTuyen))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM GetTuyenChuyenInfo() WHERE TenTuyen = @TenTuyen", conn))
                {
                    cmd.Parameters.AddWithValue("@TenTuyen", tenTuyen);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);
                    dgv_Chuyen.DataSource = dataTable;
                }
            }
        }

        private void btnDoi_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string maVe = cboMaVe.Text;
                string maChuyen = cboMaChuyen.Text;

                float thanhtien;
                bool isSuccess = float.TryParse(txtThanhTien.Text, out thanhtien);
                string soluong = txtSoLuong.Text;
                DateTime ngaydatve = DateTime.Now;

                using (SqlCommand cmd = new SqlCommand("CapNhatVe", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaVe", maVe);
                    cmd.Parameters.AddWithValue("@MaChuyen", maChuyen);
                    cmd.Parameters.AddWithValue("@MaKH", MaKhachHang);
                    cmd.Parameters.AddWithValue("@ThanhTien", thanhtien);
                    cmd.Parameters.AddWithValue("@SoLuong", soluong);
                    cmd.Parameters.AddWithValue("@NgayDatVe", ngaydatve);

                    int rowsAffected = cmd.ExecuteNonQuery();


                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Đặt vé thành công!");
                        LoadData();
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
        private void LoadData()
        {
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM GetVeInformation() WHERE MAKH = @MaKhachHang", conn))
            {
                cmd.Parameters.AddWithValue("@MaKhachHang", MaKhachHang);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();

                adapter.Fill(dataTable);

                dgv_KhachHang.DataSource = dataTable;
            }
            txtThanhTien.Enabled = txtThanhTienKH.Enabled= cboMaChuyen.Enabled = cboMaChuyenKH.Enabled = cboTenTuyenKH.Enabled = dtpNgayXPKH.Enabled = dtpNgayXPKH.Enabled = false;
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

        private void dgv_KhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_KhachHang.Rows[e.RowIndex];
                cboMaVe.Text = row.Cells["maVeDataGridViewTextBoxColumn"].Value.ToString();
                cboMaChuyenKH.Text = row.Cells["maChuyenDataGridViewTextBoxColumn"].Value.ToString();
                cboTenTuyenKH.Text = row.Cells["tenTuyenDataGridViewTextBoxColumn"].Value.ToString();
                dtpNgayXPKH.Text = row.Cells["ngayXPDataGridViewTextBoxColumn"].Value.ToString();
                txtSoLuongKH.Text = row.Cells["sOLUONGDataGridViewTextBoxColumn"].Value.ToString();
                txtThanhTienKH.Text = row.Cells["thanhTienDataGridViewTextBoxColumn"].Value.ToString();

            }
        }

        private void dgv_Chuyen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_Chuyen.Rows[e.RowIndex];
                cboMaChuyen.Text = row.Cells["maChuyenDataGridViewTextBoxColumn1"].Value.ToString();
                cboTenTuyen.Text = row.Cells["tenTuyenDataGridViewTextBoxColumn1"].Value.ToString();
                dtpNgayXP.Text = row.Cells["ngayXPDataGridViewTextBoxColumn1"].Value.ToString();
            }
        }
    }
}
