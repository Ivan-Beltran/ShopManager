using CommonLayer.Entities;

namespace BussinessLayer.Services.ServicesForProducts
{
    public interface IProductsService
    {
        List<Products> GetAllProduct();
        List<Products> SearchProduct(string searchTerm);
    }
}