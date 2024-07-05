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
    public partial class FormXe : Form
    {
        Database db = new Database();
        SqlConnection conn;
        public FormXe()
        {
            InitializeComponent();
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            conn = new SqlConnection(connectionString);
        }

        private void FormXe_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_BANVEDataSet.XE' table. You can move, or remove it, as needed.
            this.xETableAdapter.Fill(this.qL_BANVEDataSet.XE);
            txtMaXe.Enabled = txtBSX.Enabled = txtTenXe.Enabled = cboMaHSX.Enabled = cboLoaiXe.Enabled = false;

            string queryMAHANGSX = "SELECT MAHANGSX FROM HANGSX";
            List<string> listMAHANGSX = new List<string>();
            using (SqlDataReader readerMATUYEN = db.getDataReader(queryMAHANGSX))
            {
                listMAHANGSX.Add("");
                while (readerMATUYEN.Read())
                {
                    listMAHANGSX.Add(readerMATUYEN["MAHANGSX"].ToString());
                }
            }
            cboMaHSX.DataSource = listMAHANGSX;

            string queryMALOAIXE = "SELECT MALOAIXE FROM LOAIXE";
            List<string> listMALOAIXE = new List<string>();
            using (SqlDataReader readerMALOAIXE = db.getDataReader(queryMALOAIXE))
            {
                listMALOAIXE.Add("");
                while (readerMALOAIXE.Read())
                {
                    listMALOAIXE.Add(readerMALOAIXE["MALOAIXE"].ToString());
                }
            }
            cboLoaiXe.DataSource = listMALOAIXE;
        }
        private void ResetForm()
        {
            txtMaXe.Text = "";
            txtBSX.Text = "";
            txtTenXe.Text = "";
            cboMaHSX.Text = "";
            cboLoaiXe.Text = "";
        }
        private void LoadData()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM XE", conn))
                {
                    DataTable table = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(table);
                    dgv_Xe.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            txtMaXe.Enabled = txtBSX.Enabled = txtTenXe.Enabled = cboMaHSX.Enabled = cboLoaiXe.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenXe.Enabled == true)
            {
                try
                {
                    if (string.IsNullOrWhiteSpace(txtMaXe.Text) || string.IsNullOrWhiteSpace(txtBSX.Text) || string.IsNullOrWhiteSpace(txtTenXe.Text) || string.IsNullOrWhiteSpace(cboMaHSX.Text) || string.IsNullOrWhiteSpace(cboLoaiXe.Text))
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                        return;
                    }

                    conn.Open();

                    SqlCommand cmd = new SqlCommand("insertXe", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@MaXe", txtMaXe.Text);
                    cmd.Parameters.AddWithValue("@TENXE", txtTenXe.Text);
                    cmd.Parameters.AddWithValue("@BIENSOXE", txtBSX.Text);
                    cmd.Parameters.AddWithValue("@MALOAIXE", cboLoaiXe.Text);
                    cmd.Parameters.AddWithValue("@MAHANGSX", cboMaHSX.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Thêm tuyến xe thành công");

                    ResetForm();
                    LoadData();
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
            else
            {
                txtMaXe.Enabled = txtBSX.Enabled = txtTenXe.Enabled = cboMaHSX.Enabled = cboLoaiXe.Enabled = true;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtTenXe.Enabled == true)
            {

                try
                {
                    if (string.IsNullOrWhiteSpace(txtMaXe.Text) || string.IsNullOrWhiteSpace(txtBSX.Text) || string.IsNullOrWhiteSpace(txtTenXe.Text) || string.IsNullOrWhiteSpace(cboMaHSX.Text) || string.IsNullOrWhiteSpace(cboLoaiXe.Text))
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin tuyến xe");
                        return;
                    }
                    using (SqlCommand cmd = new SqlCommand("updateXe", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@MaXe", txtMaXe.Text);
                        cmd.Parameters.AddWithValue("@TENXE", txtTenXe.Text);
                        cmd.Parameters.AddWithValue("@BIENSOXE", txtBSX.Text);
                        cmd.Parameters.AddWithValue("@MALOAIXE", cboLoaiXe.Text);
                        cmd.Parameters.AddWithValue("@MAHANGSX", cboMaHSX.Text);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();

                        MessageBox.Show("Cập nhật tuyến xe thành công.");
                        LoadData();
                        ResetForm();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
            else
            {
                txtBSX.Enabled = txtTenXe.Enabled = cboMaHSX.Enabled = cboLoaiXe.Enabled = true;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maXe = txtMaXe.Text;

            if (string.IsNullOrEmpty(maXe))
            {
                MessageBox.Show("Vui lòng chọn chuyến xe cần xóa!");
                return;
            }

            try
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("deleteXe", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaXe", maXe);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa xe thành công!");
                    ResetForm();
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            conn.Close();
        }

        private void dgv_Xe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_Xe.Rows[e.RowIndex];
                txtMaXe.Text = row.Cells["maxeDataGridViewTextBoxColumn"].Value.ToString();
                txtBSX.Text = row.Cells["bIENSOXEDataGridViewTextBoxColumn"].Value.ToString();
                txtTenXe.Text = row.Cells["tENXEDataGridViewTextBoxColumn"].Value.ToString();
                cboMaHSX.Text = row.Cells["mAHANGSXDataGridViewTextBoxColumn"].Value.ToString();
                cboLoaiXe.Text = row.Cells["mALOAIXEDataGridViewTextBoxColumn"].Value.ToString();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                string maXe = txtMaXe.Text;
                using (SqlCommand cmd = new SqlCommand("findXe", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaXe", maXe);

                    DataTable table = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(table);
                    dgv_Xe.DataSource = table;

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

        private void button1_Click(object sender, EventArgs e)
        {
            FormRPXe dk = new FormRPXe();
            dk.ShowDialog();
        }
    }
}
