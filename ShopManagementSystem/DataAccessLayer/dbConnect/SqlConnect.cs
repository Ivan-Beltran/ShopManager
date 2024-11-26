  using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.dbConnect
{
    public class SqlConnect : ISqlConnect
    {
        private readonly string _connectionString;

        public SqlConnect()
        {

<<<<<<< HEAD

            _connectionString = "Data Source=THVST24\\SQLEXPRESS01;Initial Catalog=StoreDB;Integrated Security=True;Encrypt=False";

            
=======
            _connectionString = "Data Source=MARISOL-LAPTOP;Initial Catalog=StoreDB;Integrated Security=True;Encrypt=False";
>>>>>>> b29f3a954b1041fd52d62ec49c7add618de28a31
        }
            public IDbConnection GetConnection()
            {
                return new SqlConnection(_connectionString);
            }


        }
    }
