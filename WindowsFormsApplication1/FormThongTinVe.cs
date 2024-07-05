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
    public partial class FormThongTinVe : Form
    {
        Database db = new Database();
        SqlConnection conn;
        private string maVee;
        public string MaVee { get { return maVee; } }
        
        public string MaKhachHang { get; set; }
        public FormThongTinVe(string maKhachHang)
        {
            InitializeComponent();
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            conn = new SqlConnection(connectionString);
            this.MaKhachHang = maKhachHang;
            this.Load += FormThongTinVe_Load;

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

            List<string> maVeList1 = new List<string>();
            string query11 = "SELECT DISTINCT TENTUYEN FROM GetVeInformation() WHERE MAKH = @MaKhachHang";

            using (SqlCommand cmd = new SqlCommand(query11, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@MaKhachHang", MaKhachHang);
                SqlDataReader reader1 = cmd.ExecuteReader();

                while (reader1.Read())
                {
                    maVeList1.Add(reader1["TENTUYEN"].ToString());
                }
                conn.Close();
                cboTenTuyen.DataSource = maVeList1;

            }
        }

        private void FormThongTinVe_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_BANVEDataSet.GetVeInformation' table. You can move, or remove it, as needed.
            this.getVeInformationTableAdapter.Fill(this.qL_BANVEDataSet.GetVeInformation);
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM GetVeInformation() WHERE MAKH = @MaKhachHang", conn))
            {
                cmd.Parameters.AddWithValue("@MaKhachHang", MaKhachHang);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();

                adapter.Fill(dataTable);

                dgv_ThongTinVe.DataSource = dataTable;
            }
            cboTenTuyen.Enabled = txtDiemDen.Enabled = txtDiemXP.Enabled = dtpNgayDen.Enabled = dtpNgayXP.Enabled = txtGioDen.Enabled = txtGioXP.Enabled = txtSoLuong.Enabled = false;
        }

        private void dgv_ThongTinVe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
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
            maVee = cboMaVe.Text;
        }

        private void cboMaVe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboTenTuyen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormRPVeXe dk = new FormRPVeXe(MaVee);
            dk.ShowDialog();
        }
    }
}
