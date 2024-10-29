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
<<<<<<< HEAD
            _connectionString = "Data Source=YONATAN-CHICAS\\SQLEXPRESS;Initial Catalog=StoreDB;Integrated Security=True;Trust Server Certificate=True";
=======
            _connectionString = "Data Source=DESKTOP-NFDMETJ\\SQLEXPRESS;Initial Catalog=StoreDB﻿;Integrated Security=True;Encrypt=False";
>>>>>>> dac12ab0b60abd4e2202427356f6df2fbec4e3b2
        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }

    }
}
