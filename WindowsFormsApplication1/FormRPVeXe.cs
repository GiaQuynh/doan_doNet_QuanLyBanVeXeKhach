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
    public partial class FormRPVeXe : Form
    {
        Database db = new Database();
        SqlConnection conn;

        public string MaVe { get; set; }

        public FormRPVeXe(string maVee)
        {
            InitializeComponent();
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            conn = new SqlConnection(connectionString);
            this.MaVe = maVee;

        }

        private void FormRPVeXe_Load(object sender, EventArgs e)
        {

        }
        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
                conn.Open();

                // Retrieve ticket information based on the ticket ID
                string query = "SELECT * FROM Ve WHERE MaVe = @ticketId";
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@ticketId", MaVe);

                    DataTable dtb = new DataTable();
                    adapter.Fill(dtb);

                    if (dtb.Rows.Count > 0)
                    {
                        CrystalReportVeDaDat report = new CrystalReportVeDaDat(); // Create an instance of the Crystal Report
                        report.SetDataSource(dtb); // Set the DataTable as the data source for the report

                        crystalReportViewer1.ReportSource = report;
                        crystalReportViewer1.Refresh();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy thông tin vé.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
}