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
    public static class DateTimeExtensions
    {
        public static DateTime StartOfWeek(this DateTime dt, DayOfWeek startOfWeek)
        {
            int diff = (7 + (dt.DayOfWeek - startOfWeek)) % 7;
            return dt.AddDays(-1 * diff).Date;
        }
    }
    public partial class FormRPDoanhThuTheoTuan : Form
    {
        Database db = new Database();
        SqlConnection conn;
        public FormRPDoanhThuTheoTuan()
        {
            InitializeComponent();
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            conn = new SqlConnection(connectionString);
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = dtpNgay.Value.Date;
            DateTime startDate = selectedDate.StartOfWeek(DayOfWeek.Monday); // Lấy ngày đầu tuần
            DateTime endDate = startDate.AddDays(6); // Lấy ngày cuối tuần

            string query = "SELECT * FROM VE WHERE NGAYDATVE >= @StartDate AND NGAYDATVE <= @EndDate";

            conn.Open();

            using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
            {
                adapter.SelectCommand.CommandType = CommandType.Text;
                adapter.SelectCommand.Parameters.AddWithValue("@StartDate", startDate);
                adapter.SelectCommand.Parameters.AddWithValue("@EndDate", endDate);

                DataTable dtb = new DataTable("BaoCaoPhieuNhap");
                adapter.Fill(dtb);

                if (dtb.Rows.Count > 0)
                {
                    CrystalReportDoanhThuTheoTuan baocao = new CrystalReportDoanhThuTheoTuan();
                    baocao.SetDataSource(dtb);

                    crystalReportViewer1.ReportSource = baocao;
                    crystalReportViewer1.DisplayStatusBar = false;
                    crystalReportViewer1.DisplayToolbar = true;
                    crystalReportViewer1.Refresh();
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu cho tuần đã chọn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            conn.Close();
        }

        private void FormRPDoanhThuTheoTuan_Load(object sender, EventArgs e)
        {
        }
    }
}
