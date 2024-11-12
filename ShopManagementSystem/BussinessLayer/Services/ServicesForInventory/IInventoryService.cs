
using System.Data;

namespace BussinessLayer.Services.ServicesForInventory
{
    public interface IInventoryService
    {
        DataTable GetAllProduct();
        DataTable GetProductsType(int productTypeId);
    }
}