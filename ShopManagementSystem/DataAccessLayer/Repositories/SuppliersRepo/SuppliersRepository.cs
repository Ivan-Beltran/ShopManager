using Dapper;
using DataAccessLayer.dbConnect;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonLayer.Entities;

namespace DataAccessLayer.Repositories.SuppliersRepo
{
    public class SuppliersRepository : ISuppliersRepository
    {
        private ISqlConnect _dbConnection;

        public SuppliersRepository(ISqlConnect dbConecction)
        {
            _dbConnection = dbConecction;
        }

        public DataTable GetAllSuppliers()
        {
            DataTable suppliersTable = new DataTable();

            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT
                                	SupplierId AS Id,
                                	SupplierName AS Nombres,
                                	SupplierPhone AS Telefono,
                                	SupplierEmail AS Email,
                                	SupplierAddres	AS Direccion
                                FROM Suppliers";

                using (var reader = connection.ExecuteReader(query))
                {

                    suppliersTable.Load(reader);
                }
            }

            return suppliersTable;
        }

        public void AddSupplier(Suppliers supliers)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"INSERT INTO Suppliers (SupplierName, SupplierPhone, SupplierEmail, SupplierAddres)
                               VALUES (@SupplierName, @SupplierPhone, @SupplierEmail, @SupplierAddres)";

                connection.Execute(query, supliers);
            }
        }

        public void EditSupplier(Suppliers supplier)
        {
            using (var connection = _dbConnection.GetConnection())
            {

                string query = @"UPDATE Suppliers
                                 SET 
                                    SupplierName = @SupplierName,
                                    SupplierPhone = @SupplierPhone,
                                    SupplierEmail = @SupplierEmail,
                                    SupplierAddres = @SupplierAddres
                                 WHERE SupplierId = @SupplierId";

                connection.Execute(query, supplier);
            }
        }

        public void DeleteSupplier(int supplierId)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"
        DELETE FROM Suppliers
        WHERE SupplierId = @SupplierId";

                connection.Execute(query, new { SupplierId = supplierId });
            }
        }



    }
}
