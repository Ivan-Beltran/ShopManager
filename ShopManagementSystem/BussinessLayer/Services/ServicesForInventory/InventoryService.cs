using DataAccessLayer.Repositories.EmployeesRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Repositories.invetoryRepo;
using System.Data;
using CommonLayer.Entities;

namespace BussinessLayer.Services.ServicesForInventory
{
    public class InventoryService : IInventoryService
    {
        private IInventoryRepository _inventoryRepository;

        public InventoryService(IInventoryRepository inventoryRepository)
        {
            _inventoryRepository = inventoryRepository;
        }

        public DataTable GetAllProduct()
        {
            return _inventoryRepository.GetAllProducts();
        }

        public DataTable GetProductsType(string productType)
        {
           return  _inventoryRepository.GetProductsType(productType);
        }

        public DataTable SearchProduct(string search)
        {
            return _inventoryRepository.SearchProduct(search);
        }

        public void CreateProduct(Products product)
        {
            _inventoryRepository.CreateProduct(product);
        }

        public DataTable GetProductsType()
        {
            return _inventoryRepository.GetProductTypes();
        }

        public DataTable GetProductCreated()
        {
            return _inventoryRepository.GetProductsCreated();
        }

        public void EditProduct(Products product)
        {
            _inventoryRepository.EditProduct(product);
        }



    }
}
