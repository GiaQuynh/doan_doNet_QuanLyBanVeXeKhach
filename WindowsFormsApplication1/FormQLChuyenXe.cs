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
    public partial class FormQLChuyenXe : Form
    {
        Database db = new Database();
        SqlConnection conn;
        public FormQLChuyenXe()
        {
            InitializeComponent();
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            conn = new SqlConnection(connectionString);
        }

        private void FormQLChuyenXe_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_BANVEDataSet.ChuyenXe' table. You can move, or remove it, as needed.
            this.chuyenXeTableAdapter.Fill(this.qL_BANVEDataSet.ChuyenXe);
            string queryMATX = "SELECT MATX FROM TAIXE";
            List<string> listMATX = new List<string>();
            using (SqlDataReader readerMATX = db.getDataReader(queryMATX))
            {
                listMATX.Add("");
                while (readerMATX.Read())
                {
                    listMATX.Add(readerMATX["MATX"].ToString());
                }
            }
            cboMaTX.DataSource = listMATX;

            string queryMATUYEN = "SELECT MATUYEN FROM TUYENXE";
            List<string> listMATUYEN = new List<string>();
            using (SqlDataReader readerMATUYEN = db.getDataReader(queryMATUYEN))
            {
                listMATUYEN.Add("");
                while (readerMATUYEN.Read())
                {
                    listMATUYEN.Add(readerMATUYEN["MATUYEN"].ToString());
                }
            }
            cboMaTuyen.DataSource = listMATUYEN;
            txtMaChuyen.Enabled = dtpNgayXP.Enabled = dtpNgayDK.Enabled = dtpGioXP.Enabled = dtpGioDK.Enabled = txtGia.Enabled = txtGheTrong.Enabled = cboMaTX.Enabled = false;

            string queryMAXE = "SELECT MAXE FROM XE";
            List<string> listMAXE = new List<string>();
            using (SqlDataReader readerMAXE = db.getDataReader(queryMAXE))
            {
                listMAXE.Add("");
                while (readerMAXE.Read())
                {
                    listMAXE.Add(readerMAXE["MAXE"].ToString());
                }
            }
            cboMaXe.DataSource = listMAXE;
        }
        private void ResetForm()
        {
            txtMaChuyen.Text = "";
            cboMaTuyen.SelectedIndex = 0;
            dtpNgayXP.Value = DateTime.Now;
            dtpNgayDK.Value = DateTime.Now;
            dtpGioXP.Value = DateTime.Now;
            dtpGioDK.Value = DateTime.Now;
            cboMaTX.SelectedIndex = 0;
            txtGia.Text = "";
            txtGheTrong.Text = "";
        }
        private void LoadData()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM CHUYENXE", conn))
                {
                    DataTable table = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(table);
                    dgv_ChuyenXe.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }

            txtMaChuyen.Enabled = dtpNgayXP.Enabled = dtpNgayDK.Enabled = dtpGioXP.Enabled = dtpGioDK.Enabled = txtGia.Enabled = txtGheTrong.Enabled = cboMaTX.Enabled = false;
        }

        private void cboMaTuyen_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cboMaTuyen.SelectedIndex != 0)
            //{
            //    string maTuyen = cboMaTuyen.SelectedItem.ToString();

            //    using (SqlCommand cmd = new SqlCommand("SELECT * FROM CHUYENXE WHERE MATUYEN = @MATUYEN", conn))
            //    {
            //        cmd.Parameters.AddWithValue("@MATUYEN", maTuyen);

            //        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            //        DataTable dataTable = new DataTable();

            //        adapter.Fill(dataTable);
            //        dgv_ChuyenXe.DataSource = dataTable;

            //    }

            //}
            //else
            //{
            //    LoadData();
            //}
        }

        private void dgv_ChuyenXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_ChuyenXe.Rows[e.RowIndex];
                txtMaChuyen.Text = row.Cells["maChuyenDataGridViewTextBoxColumn"].Value.ToString();
                while (txtMaChuyen.Text != "")
                {
                    cboMaXe.Text = row.Cells["maxeDataGridViewTextBoxColumn"].Value.ToString();
                    cboMaTuyen.Text = row.Cells["maTuyenDataGridViewTextBoxColumn"].Value.ToString();
                    dtpNgayXP.Value = Convert.ToDateTime(row.Cells["ngayXPDataGridViewTextBoxColumn"].Value);
                    dtpNgayDK.Value = Convert.ToDateTime(row.Cells["ngayDenDataGridViewTextBoxColumn"].Value);
                    TimeSpan gioXP = (TimeSpan)row.Cells["gioXPDataGridViewTextBoxColumn"].Value;
                    dtpGioXP.Value = DateTime.Today.Add(gioXP);
                    TimeSpan gioDK = (TimeSpan)row.Cells["gioDenDataGridViewTextBoxColumn"].Value;
                    dtpGioDK.Value = DateTime.Today.Add(gioDK);
                    cboMaTX.Text = row.Cells["maTXDataGridViewTextBoxColumn"].Value.ToString();
                    txtGia.Text = row.Cells["giaDataGridViewTextBoxColumn"].Value.ToString();
                    txtGheTrong.Text = row.Cells["sOGHETRONGDataGridViewTextBoxColumn"].Value.ToString();
                    break;
                }

            }
        }

        private void txtGheTrong_TextChanged(object sender, EventArgs e)
        {
            string maXe = cboMaXe.SelectedItem.ToString();

            if (!string.IsNullOrEmpty(maXe))
            {
                int soGheTrong = GetSoGheByMaXe(maXe);
                txtGheTrong.Text = soGheTrong.ToString();
            }
        }
        private int GetSoGheByMaXe(string maXe)
        {
            int soGheTrong = 0;

            try
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT dbo.GetSoGheByMaXe(@MaXe)", conn))
                {
                    cmd.Parameters.AddWithValue("@MaXe", maXe);

                    soGheTrong = Convert.ToInt32(cmd.ExecuteScalar());
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

            return soGheTrong;
        }
        private void btSua_Click(object sender, EventArgs e)
        {
            string maChuyen = txtMaChuyen.Text;
            string maTuyen = cboMaTuyen.SelectedItem.ToString();
            string maXe = cboMaXe.SelectedItem.ToString();
            DateTime ngayXP = dtpNgayXP.Value;
            DateTime ngayDK = dtpNgayDK.Value;
            TimeSpan gioXP = dtpGioXP.Value.TimeOfDay;
            TimeSpan gioDK = dtpGioDK.Value.TimeOfDay;
            string maTX = cboMaTX.SelectedItem.ToString();
            float gia;
            bool isSuccess = float.TryParse(txtGia.Text, out gia);
            int soGheTrong;
            bool isSuccess1 = int.TryParse(txtGheTrong.Text, out soGheTrong);


            if (txtGia.Enabled == true)
            {
                if (string.IsNullOrEmpty(maChuyen) || string.IsNullOrEmpty(maTuyen) || string.IsNullOrEmpty(maTX))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin chuyến xe!");
                    return;
                }

                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("updateChuyen", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@MaChuyen", maChuyen);
                        cmd.Parameters.AddWithValue("@MaTuyen", maTuyen);
                        cmd.Parameters.AddWithValue("@MaXe", maXe);
                        cmd.Parameters.AddWithValue("@NgayXP", ngayXP);
                        cmd.Parameters.AddWithValue("@NgayDen", ngayDK);
                        cmd.Parameters.AddWithValue("@GioXP", gioXP);
                        cmd.Parameters.AddWithValue("@GioDen", gioDK);
                        cmd.Parameters.AddWithValue("@MaTX", maTX);
                        cmd.Parameters.AddWithValue("@Gia", gia);
                        cmd.Parameters.AddWithValue("@SoGheTrong", soGheTrong);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cập nhật chuyến xe thành công!");
                            ResetForm();
                            LoadData();
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật chuyến xe thất bại!");
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
                dtpNgayXP.Enabled = dtpNgayDK.Enabled = dtpGioXP.Enabled = dtpGioDK.Enabled = txtGia.Enabled = cboMaTX.Enabled = cboMaXe.Enabled = true;
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            string maChuyen = txtMaChuyen.Text;

            if (string.IsNullOrEmpty(maChuyen))
            {
                MessageBox.Show("Vui lòng chọn chuyến xe cần xóa!");
                return;
            }

            try
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("deleteChuyen", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaChuyen", maChuyen);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Xóa chuyến xe thành công!");
                        ResetForm();
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Xóa chuyến xe thất bại!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            conn.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maChuyen = txtMaChuyen.Text;
            string maTuyen = cboMaTuyen.SelectedItem.ToString();
            string maXe = cboMaXe.SelectedItem.ToString();
            DateTime ngayXP = dtpNgayXP.Value;
            DateTime ngayDK = dtpNgayDK.Value;
            TimeSpan gioXP = dtpGioXP.Value.TimeOfDay;
            TimeSpan gioDK = dtpGioDK.Value.TimeOfDay;
            string maTX = cboMaTX.SelectedItem.ToString();
            float gia;
            bool isSuccess = float.TryParse(txtGia.Text, out gia);
            int soGheTrong;
            bool isSuccess1 = int.TryParse(txtGheTrong.Text, out soGheTrong);

            if (txtMaChuyen.Enabled == true)
            {
                if (string.IsNullOrEmpty(maChuyen) || string.IsNullOrEmpty(maTuyen) || string.IsNullOrEmpty(maXe) || string.IsNullOrEmpty(maTX))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin chuyến xe!");
                    return;
                }
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("InsertChuyen", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MaChuyen", maChuyen);
                        cmd.Parameters.AddWithValue("@MaTuyen", maTuyen);
                        cmd.Parameters.AddWithValue("@MaXe", maXe);
                        cmd.Parameters.AddWithValue("@NgayXP", ngayXP);
                        cmd.Parameters.AddWithValue("@NgayDen", ngayDK);
                        cmd.Parameters.AddWithValue("@GioXP", gioXP);
                        cmd.Parameters.AddWithValue("@GioDen", gioDK);
                        cmd.Parameters.AddWithValue("@MaTX", maTX);
                        cmd.Parameters.AddWithValue("@Gia", gia);
                        cmd.Parameters.AddWithValue("@SoGheTrong", soGheTrong);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Thêm chuyến xe thành công!");
                            ResetForm();
                            LoadData();
                        }
                        else
                        {
                            MessageBox.Show("Thêm chuyến xe thất bại!");
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
                txtMaChuyen.Enabled = dtpNgayXP.Enabled = dtpNgayDK.Enabled = dtpGioXP.Enabled = dtpGioDK.Enabled = txtGia.Enabled = cboMaTX.Enabled = true;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                string maChuyen = txtMaChuyen.Text;
                using (SqlCommand cmd = new SqlCommand("findXe", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaXe", maChuyen);

                    DataTable table = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(table);
                    dgv_ChuyenXe.DataSource = table;

                    if (table.Rows.Count > 0)
                    {
                        MessageBox.Show("Tìm kiếm thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy tuyến xe!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void cboMaXe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMaXe.SelectedIndex != 0)
            {
                string maXe = cboMaXe.SelectedItem.ToString();

                using (SqlCommand cmd = new SqlCommand("SELECT * FROM CHUYENXE WHERE MAXE = @MAXE", conn))
                {
                    cmd.Parameters.AddWithValue("@MAXE", maXe);

                    //SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    //DataTable dataTable = new DataTable();

                    //adapter.Fill(dataTable);
                    //dgv_ChuyenXe.DataSource = dataTable;

                    int soGheTrong = GetSoGheByMaXe(maXe);
                    txtGheTrong.Text = soGheTrong.ToString();

                }

            }
            else
            {
                LoadData();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormRPChuyenXe dk = new FormRPChuyenXe();
            dk.ShowDialog();
        }
    }
}
