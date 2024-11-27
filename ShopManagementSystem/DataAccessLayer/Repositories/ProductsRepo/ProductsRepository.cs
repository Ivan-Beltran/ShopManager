using DataAccessLayer.dbConnect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonLayer.Entities;
using Dapper;

namespace DataAccessLayer.Repositories.ProductsRepo
{
    public class ProductsRepository : IProductsRepository
    {
        ISqlConnect _dbConnection;

        public ProductsRepository(ISqlConnect dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public List<Products> GetAllProduct()
        {
         
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT
                                	ProductId,
                                	ProductBrand,
                                	ProductModel,
                                	ProductVersion,
                                	ProductColor,
                                	ProductPrice,
									ImageUrl
                                FROM Products
                                WHERE Availability=1";

                return connection.Query<Products>(query).ToList();
            }
        }

        public List<Products> SearchProduct(string searchTerm)
        {

            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT
                                    ProductId,
                                    ProductBrand,
                                    ProductModel,
                                    ProductVersion,
                                    ProductColor,
                                    ProductPrice,
                                    ImageUrl
                                FROM Products
                                WHERE ProductBrand LIKE @searchTerm
                                OR ProductModel LIKE @searchTerm
                                OR ProductVersion LIKE @searchTerm
                                OR ProductColor LIKE @searchTerm
                                AND Availability = 1 ";

                return connection.Query<Products>(query, new {searchTerm= "%" + searchTerm+ "%" }).ToList();
            }
        }

        // consultas para vender productos 

       

    }
}
