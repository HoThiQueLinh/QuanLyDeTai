using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace QLDeTai
{
    class ModifyDT
    {
        SqlDataAdapter dataAdapter;
        SqlCommand sqlCommand;
        public ModifyDT()
        {
        }
        public DataTable XemDL(string sql)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection sqlConnection = Connection.getConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(sql, sqlConnection);
                dataAdapter.Fill(dataTable);
                sqlConnection.Close();
            }
            return dataTable;
        }

        public DataTable getAllDeTai()
        {
            DataTable dataTable = new DataTable();
            string query = "select * from DeTai";
            using (SqlConnection sqlConnection = Connection.getConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(dataTable);
                sqlConnection.Close();
            }
            return dataTable;
        }

        public bool insertDeTai(DeTai deTai)
        {
            SqlConnection sqlConnection = Connection.getConnection();
            String query = "insert into DeTai values(@madt,@tendt,@ngaybd,@ngaykt,@macd)";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@madt", SqlDbType.NVarChar).Value = deTai.Madt;
                sqlCommand.Parameters.Add("@tendt", SqlDbType.NVarChar).Value = deTai.Tendt;
                sqlCommand.Parameters.Add("@ngaybd", SqlDbType.DateTime).Value = deTai.Ngaybd.ToShortDateString();
                sqlCommand.Parameters.Add("@ngaykt", SqlDbType.DateTime).Value = deTai.Ngaykt.ToShortDateString();
                sqlCommand.Parameters.Add("@macd", SqlDbType.NVarChar).Value = deTai.Macd;
                sqlCommand.ExecuteNonQuery();


            }
            catch
            {
                return false;
            }
            finally
            {
                sqlConnection.Close();

            }
            return true;
        }
        public bool updateDeTai(DeTai deTai)
        {
            SqlConnection sqlConnection = Connection.getConnection();
            String query = "update DeTai set tendt=@tendt,ngaybd=@ngaybd,ngaykt=@ngaykt,macd=@macd where madt=@madt";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@madt", SqlDbType.NVarChar).Value = deTai.Madt;
                sqlCommand.Parameters.Add("@tendt", SqlDbType.NVarChar).Value = deTai.Tendt;
                sqlCommand.Parameters.Add("@ngaybd", SqlDbType.DateTime).Value = deTai.Ngaybd.ToString("yyyy/MM/dd");
                sqlCommand.Parameters.Add("@ngaykt", SqlDbType.DateTime).Value = deTai.Ngaykt.ToString("yyyy/MM/dd");
                sqlCommand.Parameters.Add("@macd", SqlDbType.NVarChar).Value = deTai.Macd;
                sqlCommand.ExecuteNonQuery();

            }
            catch
            {
                return false;
            }
            finally
            {
                sqlConnection.Close();

            }
            return true;
        }
        public bool deleteDeTai(String madt)
        {
            SqlConnection sqlConnection = Connection.getConnection();
            String query = "delete DeTai  where madt=@madt";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@madt", SqlDbType.NVarChar).Value = madt;
                sqlCommand.ExecuteNonQuery();

            }
            catch
            {
                return false;
            }
            finally
            {
                sqlConnection.Close();

            }
            return true;
        }
    }
}
