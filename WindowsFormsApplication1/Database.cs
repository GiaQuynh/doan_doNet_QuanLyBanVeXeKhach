using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    internal class Database
    {
        SqlConnection conn;
        SqlDataAdapter da;
        DataSet ds;
        public Database()
        {
            string cnn = "Data Source=DESKTOP-V6MCQL7;Initial Catalog=QL_BANVE;Integrated Security=True";
            conn = new SqlConnection(cnn);
        }

        public DataTable execute(string sql)
        {
            da = new SqlDataAdapter(sql, conn);
            ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }
        public void executenonquery(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public object executeScalar(string query)
        {
            using (SqlCommand command = new SqlCommand(query, conn))
            {
                try
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    return command.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi cập nhật dữ liệu: " + ex.Message);
                    return null;
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
            }
        }
        public void OpenConnection()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        public void CloseConnection()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
        public DataTable getDataTable(string sql)
        {
            OpenConnection();
            DataTable table = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(table);
            CloseConnection();
            return table;
        }

        //Đọc dữ liệu từ DB
        public SqlDataReader getDataReader(string sql)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable table = new DataTable();
            return reader;
        }
        public void BeginTransaction()
        {
            OpenConnection();
            SqlTransaction transaction = conn.BeginTransaction();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.Transaction = transaction;

            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật dữ liệu: " + ex.Message);
                transaction.Rollback();
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}