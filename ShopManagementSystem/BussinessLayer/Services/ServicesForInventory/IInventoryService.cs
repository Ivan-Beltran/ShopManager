
using CommonLayer.Entities;
using System.Data;

namespace BussinessLayer.Services.ServicesForInventory
{
    public interface IInventoryService
    {
        void CreateProduct(Products product);
        void EditProduct(Products product);
        DataTable GetAllProduct();
        DataTable GetProductCreated();
        DataTable GetProductsType(string productType);
        DataTable GetProductsType();
        DataTable SearchProduct(string search);
    }
}