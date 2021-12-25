using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QLDeTai
{
    class Connection
    {
        private static string stringConnection = @"Data Source=LINHBLACK\SQLEXPRESS;Initial Catalog=QLDeTai;User ID=sa;Password=0905608763";
        public static SqlConnection getConnection()
        {
            return new SqlConnection(stringConnection);
        }
    }
}
