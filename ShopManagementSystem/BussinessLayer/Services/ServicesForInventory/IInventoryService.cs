
using System.Data;

namespace BussinessLayer.Services.ServicesForInventory
{
    public interface IInventoryService
    {
        DataTable GetAllProduct();
        DataTable GetProductsType(string productType);
        DataTable SearchProduct(string search);
    }
}