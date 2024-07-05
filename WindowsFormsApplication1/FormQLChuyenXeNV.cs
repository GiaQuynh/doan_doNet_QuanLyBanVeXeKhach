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
    public partial class FormQLChuyenXeNV : Form
    {
        Database db = new Database();
        SqlConnection conn;
        public FormQLChuyenXeNV()
        {
            InitializeComponent();
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            conn = new SqlConnection(connectionString);
        }

        private void FormQLChuyenXeNV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_BANVEDataSet.ChuyenXe' table. You can move, or remove it, as needed.
            this.chuyenXeTableAdapter.Fill(this.qL_BANVEDataSet.ChuyenXe);

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
            cboMaXe.Enabled = txtMaChuyen.Enabled = dtpNgayXP.Enabled = dtpNgayDK.Enabled = dtpGioXP.Enabled = dtpGioDK.Enabled = txtGia.Enabled = txtGheTrong.Enabled = cboMaTX.Enabled = false;
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

        private void cboMaTuyen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMaTuyen.SelectedIndex != 0)
            {
                string maTuyen = cboMaTuyen.SelectedItem.ToString();

                using (SqlCommand cmd = new SqlCommand("SELECT * FROM CHUYENXE WHERE MATUYEN = @MATUYEN", conn))
                {
                    cmd.Parameters.AddWithValue("@MATUYEN", maTuyen);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);
                    dgv_ChuyenXe.DataSource = dataTable;
                }

            }
            else
            {
                LoadData();
            }
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

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm.");
                return;
            }

            try
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("SELECT * FROM CHUYENXE WHERE MACHUYEN LIKE @Keyword", conn))
                {
                    cmd.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");

                    DataTable table = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(table);

                    if (table.Rows.Count > 0)
                    {
                        dgv_ChuyenXe.DataSource = table;
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy kết quả nào.");
                    }
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormRPChuyenXe dk = new FormRPChuyenXe();
            dk.ShowDialog();
        }

    }
}
