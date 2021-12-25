using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace QLDeTai
{
    class ModifyCD
    {
        SqlDataAdapter dataAdapter;
        SqlCommand sqlCommand;
        public ModifyCD()
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
        public DataTable getAllChuDe()
        {
            DataTable dataTable = new DataTable();
            string query = "select * from ChuDe";
            using (SqlConnection sqlConnection = Connection.getConnection()) 
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(dataTable);
                sqlConnection.Close();
            }
            return dataTable;
        }
        public bool insert(ChuDe chuDe)
        {
            SqlConnection sqlConnection = Connection.getConnection();
            String query = "insert into ChuDe values(@macd,@tencd)";
            try{
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@macd", SqlDbType.NVarChar).Value = chuDe.Macd;
                sqlCommand.Parameters.Add("@tencd", SqlDbType.NVarChar).Value = chuDe.Tencd;
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
        public bool update(ChuDe chuDe)
        {
            SqlConnection sqlConnection = Connection.getConnection();
            String query = "update ChuDe set tencd=@tencd where macd=@macd";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@macd", SqlDbType.NVarChar).Value = chuDe.Macd;
                sqlCommand.Parameters.Add("@tencd", SqlDbType.NVarChar).Value = chuDe.Tencd;
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
        public bool deleteChuDe(String macd)
        {
            SqlConnection sqlConnection = Connection.getConnection();
            String query = "delete ChuDe  where macd=@macd";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@macd", SqlDbType.NVarChar).Value = macd;
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
