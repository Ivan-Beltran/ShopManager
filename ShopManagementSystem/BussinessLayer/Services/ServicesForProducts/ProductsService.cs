using CommonLayer.Entities;
using DataAccessLayer.Repositories.ProductsRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Services.ServicesForProducts
{
    public class ProductsService : IProductsService
    {
        private IProductsRepository _productsRepository;

        public ProductsService(IProductsRepository productsRepository)
        {
            _productsRepository = productsRepository;
        }

        public List<Products> GetAllProduct()
        {
            return _productsRepository.GetAllProduct();
        }

        public List<Products> SearchProduct(string searchTerm)
        {
            return _productsRepository.SearchProduct(searchTerm);
        }
    }
}
