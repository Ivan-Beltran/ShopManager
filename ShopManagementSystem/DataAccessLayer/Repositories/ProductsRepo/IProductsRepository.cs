using CommonLayer.Entities;

namespace DataAccessLayer.Repositories.ProductsRepo
{
    public interface IProductsRepository
    {
        List<Products> GetAllProduct();
        List<Products> SearchProduct(string searchTerm);
    }
}