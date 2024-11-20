
using CommonLayer.Entities;
using System.Data;

namespace DataAccessLayer.Repositories.invetoryRepo
{
    public interface IInventoryRepository
    {
        void CreateProduct(Products product);
        void EditProduct(Products product);
        DataTable GetAllProducts();
        DataTable GetProductsCreated();
        DataTable GetProductsType(string productType);
        DataTable GetProductTypes();
        DataTable SearchProduct(string search);
    }
}