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
    public partial class FormRPDoanhThuTheoTuyenXe : Form
    {
        Database db = new Database();
        SqlConnection conn;
        public FormRPDoanhThuTheoTuyenXe()
        {
            InitializeComponent();
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            conn = new SqlConnection(connectionString);
        }

        private void FormRPDoanhThuTheoTuyenXe_Load(object sender, EventArgs e)
        {
            string queryMATUYEN = "SELECT TENTUYEN FROM TUYENXE";
            List<string> listMATUYEN = new List<string>();
            using (SqlDataReader readerMATUYEN = db.getDataReader(queryMATUYEN))
            {
                listMATUYEN.Add("");
                while (readerMATUYEN.Read())
                {
                    listMATUYEN.Add(readerMATUYEN["TENTUYEN"].ToString());
                }
            }
            cboTuyenXe.DataSource = listMATUYEN;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tenTuyen = cboTuyenXe.SelectedItem.ToString(); // Get the selected item's text instead of the index

            string query = "SELECT * FROM VE JOIN CHUYENXE ON CHUYENXE.MACHUYEN = VE.MACHUYEN JOIN XE_TUYENXE ON CHUYENXE.MATUYEN = XE_TUYENXE.MATUYEN JOIN TUYENXE ON XE_TUYENXE.MATUYEN = TUYENXE.MATUYEN WHERE TENTUYEN = @TENTUYEN";

            conn.Open();

            using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
            {
                adapter.SelectCommand.CommandType = CommandType.Text;
                adapter.SelectCommand.Parameters.AddWithValue("@TENTUYEN", tenTuyen);

                DataTable dtb = new DataTable("BaoCaoPhieuNhap");
                adapter.Fill(dtb);

                if (dtb.Rows.Count > 0)
                {
                    CrystalReportBaoCaoDanhThuTheoTuyenDuong baocao = new CrystalReportBaoCaoDanhThuTheoTuyenDuong();
                    baocao.SetDataSource(dtb);

                    crystalReportViewer1.ReportSource = baocao;
                    crystalReportViewer1.DisplayStatusBar = false;
                    crystalReportViewer1.DisplayToolbar = true;
                    crystalReportViewer1.Refresh();
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu cho tuyến đã chọn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            conn.Close();
        }
    }
}
