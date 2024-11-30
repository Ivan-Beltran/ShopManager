using CommonLayer.Entities;
using Dapper;
using DataAccessLayer.dbConnect;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.PurchaseOrdersRepo
{
    public class PurchaseOrderRepository : IPurchaseOrderRepository
    {
        private ISqlConnect _dbConnection;

        public PurchaseOrderRepository(ISqlConnect dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public DataTable GetSuppliers()
        {
            var suppliersTable = new DataTable();

            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT
                                	SupplierId AS Id,
                                	CONCAT(SupplierName,': ',SupplierAddres)AS Proveedores
                                FROM Suppliers";

                using (var reader = connection.ExecuteReader(query))
                {

                    suppliersTable.Load(reader);
                }
            }

            return suppliersTable;
        }

        public DataTable GetPurchaseOrders()
        {
            var purchaseOrdersTable = new DataTable();

            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT 
                            	PO.PurchaseOrderId AS 'Numero de orden',
                            	CONCAT(SU.SupplierName, ': ', SU.SupplierAddres) AS Proveedor,
                            	PO.Details AS Detalles,
                            	FORMAT(PO.PurchaseDate, 'dd/MM/yyyy') AS Fecha,
                            	CASE 
                            		WHEN PO.PurchaseState = 0 THEN 'Pendiente'
                            		WHEN PO.PurchaseState = 1 THEN 'Recibida'
                            		ELSE 'Desconocido'
                            	END AS Estado
                            FROM PurchaseOrders AS PO
                            INNER JOIN Suppliers AS SU 
                            ON PO.SupplierId = SU.SupplierId";

                using (var reader = connection.ExecuteReader(query))
                {
                    purchaseOrdersTable.Load(reader);
                }
            }
            return purchaseOrdersTable;
        }

        public int AddPurchaseOrder(PurchaseOrders purchaseOrder)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"
            INSERT INTO PurchaseOrders (SupplierId, Details, PurchaseDate)
            OUTPUT INSERTED.PurchaseOrderId
            VALUES (@SupplierId, @Details, @PurchaseDate)";

              
                return connection.QuerySingle<int>(query, purchaseOrder);
            }
        }

        public void DeletePurchaseOrder(int purchaseOrderId)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                // Eliminar primero los detalles de la lista de compras
                string deleteDetailsQuery = @"
                                            DELETE FROM PurchaseList
                                            WHERE PurchaseOrderId = @PurchaseOrderId";

                connection.Execute(deleteDetailsQuery, new { PurchaseOrderId = purchaseOrderId });

                // Luego eliminar la orden de compra
                string deleteOrderQuery = @"
                                            DELETE FROM PurchaseOrders
                                            WHERE PurchaseOrderId = @PurchaseOrderId";

                connection.Execute(deleteOrderQuery, new { purchaseOrderId });
            }
        }

        public void OrderReceived(int PurchaseOrderId)
        {
            using(var connection = _dbConnection.GetConnection())
            {
                string query = @"OrdenProcessed";

                connection.Execute(query, new { PurchaseOrderId }, commandType: CommandType.StoredProcedure);
            }
        }


        ///-------------------- metodos para ShoppingLIstForm-----------------------
        public DataTable GetAllProducts()
        {
            DataTable allProductsTable = new DataTable();
            using (var connection = _dbConnection.GetConnection())
            {

                string query = @"SELECT 
                            	P.ProductId AS Id,
                            	PT.ProductCategory AS Categoria,
                            	P.ProductBrand AS Marca,
                            	P.ProductModel AS Modelo,
                            	P.ProductVersion AS Version,
                            	P.ProductColor AS Color,
                            	P.ProductAmount AS Unidades
                            FROM Products AS P
                            INNER JOIN ProductType AS PT
                            ON P.ProductTypeId=PT.ProductTypeId";

                using (var reader = connection.ExecuteReader(query))
                {

                    allProductsTable.Load(reader);
                }
            }

            return allProductsTable;
        }
        public DataTable SearchProduct(string search)
        {
            DataTable searchProductTable = new DataTable();

            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT 
                            	P.ProductId AS Id,
                            	PT.ProductCategory AS Categoria,
                            	P.ProductBrand AS Marca,
                            	P.ProductModel AS Modelo,
                            	P.ProductVersion AS Version,
                            	P.ProductColor AS Color,
                            	P.ProductAmount AS Unidades
                            FROM Products AS P
                            INNER JOIN ProductType AS PT
                            ON P.ProductTypeId=PT.ProductTypeId
                            WHERE P.ProductBrand LIKE @search 
                            OR P.ProductModel LIKE @search
                            OR P.ProductVersion LIKE @search
                            OR P.ProductColor LIKE @search";

                using (var reader = connection.ExecuteReader(query, new { search = "%" + search + "%" }))
                {
                    searchProductTable.Load(reader);
                }
            }
            return searchProductTable;
        }

        public DataTable GetShoppingList(int PurchaseOrderId)
        {
            DataTable ShoppingListTable = new DataTable();

            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT
                                	PS.PurchaseOrderId AS 'Numero de orden',
                                	PT.ProductCategory AS Tipo,
                                	P.ProductBrand AS Marca,
                                	P.ProductModel AS Modelo,
                                	P.ProductVersion AS Version,
                                	P.ProductColor AS Color,
                                	PS.Quantity AS Cantidad
                                FROM PurchaseList AS PS
                                INNER JOIN Products AS P ON PS.ProductId=P.ProductId
                                INNER JOIN ProductType AS PT ON P.ProductTypeId=PT.ProductTypeId
                                WHERE PS.PurchaseOrderId=@PurchaseOrderId";

                using (var reader = connection.ExecuteReader(query, new { PurchaseOrderId }))
                {
                    ShoppingListTable.Load(reader);
                }
            }
            return ShoppingListTable;
        }

        public void AddProductsToPurchaseList(int PurchaseOrderId, int ProductId,int Quantity)
        {
            using(var connection = _dbConnection.GetConnection())
            {
                string query = @"INSERT INTO PurchaseList(PurchaseOrderId,ProductId,Quantity)
                                VALUES(@PurchaseOrderId,@ProductId,@Quantity)";

                connection.Execute(query, new{PurchaseOrderId,ProductId,Quantity});
            }
        }
    
    }
}
