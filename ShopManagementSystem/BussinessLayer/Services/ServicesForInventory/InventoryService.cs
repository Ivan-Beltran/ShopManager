using DataAccessLayer.Repositories.EmployeesRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Repositories.invetoryRepo;
using System.Data;

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

        public DataTable GetProductsType(int productTypeId)
        {
           return  _inventoryRepository.GetProductsType(productTypeId);
        }


    }
}
