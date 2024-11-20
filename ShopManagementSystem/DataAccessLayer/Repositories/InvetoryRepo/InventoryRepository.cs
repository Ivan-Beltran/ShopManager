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

                string query = @"SELECT 
                            	P.ProductId AS ID,
                            	PT.ProductCategory AS Categoria,
                            	P.ProductBrand AS Marca,
                            	P.ProductModel AS Modelo,
                            	P.ProductVersion AS Version,
                            	P.ProductColor AS Color,
                            	P.ProductPrice AS Precio,
                            	P.ProductAmount AS Unidades
                            FROM Products AS P
                            INNER JOIN ProductType AS PT
                            ON P.ProductTypeId=PT.ProductTypeId
                            WHERE Availability= 1";

                using (var reader = connection.ExecuteReader(query))
                {

                    allProductsTable.Load(reader);
                }
            }

            return allProductsTable;
        }

        public DataTable GetProductsType(string productType)
        {
            DataTable allProductsTable = new DataTable();
            using (var connection = _dbConnection.GetConnection())
            {

                string query = @"SELECT 
                            	P.ProductId AS ID,
                            	PT.ProductCategory AS Categoria,
                            	P.ProductBrand AS Marca,
                            	P.ProductModel AS Modelo,
                            	P.ProductVersion AS Version,
                            	P.ProductColor AS Color,
                            	P.ProductPrice AS Precio,
                            	P.ProductAmount AS Unidades
                            FROM Products AS P
                            INNER JOIN ProductType AS PT
                            ON P.ProductTypeId=PT.ProductTypeId
                            WHERE ProductCategory=@productType";

                using (var reader = connection.ExecuteReader(query, new {productType}))
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
                            	P.ProductId AS ID,
                            	PT.ProductCategory AS Categoria,
                            	P.ProductBrand AS Marca,
                            	P.ProductModel AS Modelo,
                            	P.ProductVersion AS Version,
                            	P.ProductColor AS Color,
                            	P.ProductPrice AS Precio,
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

        public DataTable GetProductsCreated()
        {
            DataTable ProductsTable = new DataTable();
            using (var connection = _dbConnection.GetConnection())
            {

                string query = @"SELECT 
                            	P.ProductId AS ID,
                            	PT.ProductCategory AS Categoria,
                            	P.ProductBrand AS Marca,
                            	P.ProductModel AS Modelo,
                            	P.ProductVersion AS Version,
                            	P.ProductColor AS Color,
                            	P.ProductPrice AS Precio,
                                P.ImageUrl
                            FROM Products AS P
                            INNER JOIN ProductType AS PT
                            ON P.ProductTypeId=PT.ProductTypeId";

                using (var reader = connection.ExecuteReader(query))
                {

                    ProductsTable.Load(reader);
                }
            }

            return ProductsTable;
        }

        public DataTable GetProductTypes()
        {
            DataTable ProductsTypeTable = new DataTable(); 

            using(var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT ProductTypeId AS Id, ProductCategory AS Categoria FROM ProductType";

                using (var reader = connection.ExecuteReader(query))
                {

                    ProductsTypeTable.Load(reader);
                }
            }

            return ProductsTypeTable;
        }
        public void CreateProduct(Products product)
        {
            using(var connection = _dbConnection.GetConnection())
            {
                string query= @"INSERT INTO Products(ProductTypeId,ProductBrand,ProductModel,ProductVersion,ProductColor,ProductPrice,ImageUrl)
                                VALUES (@ProductTypeId, @ProductBrand, @ProductModel, @ProductVersion, @ProductColor, @ProductPrice, @ImageUrl);";

                connection.Execute(query, product);
            }
        }

        public void EditProduct(Products product)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"
            UPDATE Products
            SET 
                ProductTypeId = @ProductTypeId,
                ProductBrand = @ProductBrand,
                ProductModel = @ProductModel,
                ProductVersion = @ProductVersion,
                ProductColor = @ProductColor,
                ProductPrice = @ProductPrice,
                ImageUrl = @ImageUrl
            WHERE 
                ProductId = @ProductId;";

                connection.Execute(query, product);
            }
        }
    }
}
