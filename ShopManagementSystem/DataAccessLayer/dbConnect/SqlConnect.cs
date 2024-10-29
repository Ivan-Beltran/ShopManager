using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.dbConnect
{
    public class SqlConnect
    {
        private readonly string _connectionString;

        public SqlConnect()
        {
            _connectionString = "Data Source=YONATAN-CHICAS\\SQLEXPRESS;Initial Catalog=StoreDB;Integrated Security=True;Trust Server Certificate=True";
        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }

    }
}
