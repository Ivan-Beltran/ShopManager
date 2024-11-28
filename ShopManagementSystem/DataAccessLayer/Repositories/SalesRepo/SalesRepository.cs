using DataAccessLayer.dbConnect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonLayer.Entities;
using Dapper;
using System.Data;
using System.Reflection;

namespace DataAccessLayer.Repositories.SalesRepo
{
    public class SalesRepository : ISalesRepository
    {
        ISqlConnect _dbConnection;

        public SalesRepository(ISqlConnect dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public void UpdatesProducts(Products SoldProduct)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @" UPDATE Products SET ProductAmount-=@ProductAmount WHERE ProductId=@ProductId";

                connection.Execute(query, SoldProduct);
            }
        }

        public int AddClient(Clients clientAdded)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string checkQuery = @"SELECT ClientId 
                              FROM Clients 
                              WHERE ClientName = @ClientName
                                AND ClientLastName = @ClientLastName
                                AND ClientEmail = @ClientEmail
                                AND ClientDUI = @ClientDUI
                                AND ClientTelephone = @ClientTelephone";

                var existingClientId = connection.QuerySingleOrDefault<int?>(checkQuery, clientAdded);

                if (existingClientId.HasValue)
                {
                    return existingClientId.Value;
                }

                string insertQuery = @"INSERT INTO Clients (ClientName,ClientLastName,ClientEmail,ClientDUI,ClientTelephone)
                               OUTPUT INSERTED.ClientId
                               VALUES(@ClientName,@ClientLastName,@ClientEmail,@ClientDUI,@ClientTelephone)";

                return connection.QuerySingle<int>(insertQuery, clientAdded);
            }
        }

        public void AddSelesReport(Sales salesAdded)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"INSERT INTO Sales
                                VALUES(@SaleClientId,@SaleProductId,@QuantitySold,@TotalAmount,@SaleDate)";

                connection.Execute(query, salesAdded);
            }
        }

        public DataTable GetSalesReport()
        {
            DataTable SalesReportTable= new DataTable();
            using(var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT 
                                	SA.SaleId AS Id,
                                	CONCAT(CL.ClientName,' ',CL.ClientLastName) AS Cliente,
                                    PR.ProductBrand AS Marca,
                                	PR.ProductModel AS Modelo,
                                	PR.ProductVersion AS Version,
                                	PR.ProductColor AS Color,
                                	SA.QuantitySold AS 'Unidades vendidas',
                                	SA.TotalAmount AS 'Total a pagar',
                                	CONVERT(VARCHAR(16), SA.SaleDate, 120) AS Fecha
                                FROM Sales AS SA
                                INNER JOIN Clients AS CL ON SA.SaleClientId=CL.ClientId
                                INNER JOIN Products AS PR ON SA.SaleProductId=PR.ProductId";

                using (var reader = connection.ExecuteReader(query))
                {
                    SalesReportTable.Load(reader);
                }
            }
            return SalesReportTable;
        }
        public DataTable SearchSalesReport(DateTime SearchTerm)
        {
            DataTable SalesReportTable = new DataTable();
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT 
                                	SA.SaleId,
                                	CONCAT(CL.ClientName,' ',CL.ClientLastName) AS Cliente,
                                    PR.ProductBrand AS Marca,
                                	PR.ProductModel AS Modelo,
                                	PR.ProductVersion AS Version,
                                	PR.ProductColor AS Color,
                                	SA.QuantitySold AS 'Unidades vendidas',
                                	SA.TotalAmount AS 'Total a pagar',
                                	CONVERT(VARCHAR(16), SA.SaleDate, 120) AS Fecha
                                FROM Sales AS SA
                                INNER JOIN Clients AS CL ON SA.SaleClientId=CL.ClientId
                                INNER JOIN Products AS PR ON SA.SaleProductId=PR.ProductId
                                WHERE CAST(SA.SaleDate AS DATE) = @SearchTerm;";


                using (var reader = connection.ExecuteReader(query, new { SearchTerm }))
                {
                    SalesReportTable.Load(reader);
                }
            }
            return SalesReportTable;
        }

        
        public void DeleteSaleReport(int SaleReportId)
        {
            using (var connection=_dbConnection.GetConnection())
            {
                string query = @"DELETE FROM Sales
                                WHERE SaleId = @SaleReportId";

                connection.Execute(query, new { SaleReportId });
            }
        }

    }
}
