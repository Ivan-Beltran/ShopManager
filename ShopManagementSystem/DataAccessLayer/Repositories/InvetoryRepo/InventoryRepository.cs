using CommonLayer.Entities;
using Dapper;
using DataAccessLayer.dbConnect;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.invetoryRepo
{
    public class InventoryRepository : IInventoryRepository
    {
        private ISqlConnect _dbConnection;

        public InventoryRepository(ISqlConnect dbconnection)
        {
            _dbConnection = dbconnection;
        }

        public DataTable GetAllProducts()
        {
            DataTable allProductsTable = new DataTable();
            using (var connection = _dbConnection.GetConnection())
            {

                string query = "SELECT * FROM Products";

                using (var reader = connection.ExecuteReader(query))
                {

                    allProductsTable.Load(reader);
                }
            }

            return allProductsTable;
        }

        public DataTable GetProductsType(int productTypeId)
        {
            DataTable allProductsTable = new DataTable();
            using (var connection = _dbConnection.GetConnection())
            {

                string query = "SELECT * FROM Products WHERE ProductTypeId=@productTypeId ";

                using (var reader = connection.ExecuteReader(query, new {productTypeId}))
                {

                    allProductsTable.Load(reader);
                }
            }

            return allProductsTable;
        }
    }
}
