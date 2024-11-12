
using System.Data;

namespace DataAccessLayer.Repositories.invetoryRepo
{
    public interface IInventoryRepository
    {
        DataTable GetAllProducts();
        DataTable GetProductsType(int productTypeId);
    }
}