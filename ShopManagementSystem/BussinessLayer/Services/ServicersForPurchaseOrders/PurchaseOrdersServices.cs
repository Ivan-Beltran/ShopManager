using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonLayer.Entities;
using DataAccessLayer.Repositories.PurchaseOrdersRepo;

namespace BussinessLayer.Services.ServicersForPurchaseOrders
{
    public class PurchaseOrdersServices : IPurchaseOrdersServices
    {
        IPurchaseOrderRepository _purchaseOrderRepository;

        public PurchaseOrdersServices(IPurchaseOrderRepository purchaseOrderRepository)
        {
            _purchaseOrderRepository = purchaseOrderRepository;
        }

        public DataTable GetSuppliers()
        {
            return _purchaseOrderRepository.GetSuppliers();
        }

        public DataTable GetPurchaseOrders()
        {
            return _purchaseOrderRepository.GetPurchaseOrders();
        }

        public int AddPurchaseOrder(PurchaseOrders purchaseOrders)
        {
            return _purchaseOrderRepository.AddPurchaseOrder(purchaseOrders);
        }

        public void DeletePurchaseOrder(int purchaseOrderId)
        {
            _purchaseOrderRepository.DeletePurchaseOrder(purchaseOrderId);
        }

        public void OrderReceived(int PurchaseOrderId)
        {
            _purchaseOrderRepository.OrderReceived(PurchaseOrderId);
        }

        ///---------metodos para ShoppingListForm--------------/
        public DataTable GetAllProducts()
        {
            return _purchaseOrderRepository.GetAllProducts();
        }

        public DataTable SearchProducts(string search)
        {
            return _purchaseOrderRepository.SearchProduct(search);
        }

        public DataTable GetShoppingList(int PurchaseOrderId)
        {
            return _purchaseOrderRepository.GetShoppingList(PurchaseOrderId);
        }

        public void AddProductsToPurchaseList(int PurchaseOrderId, int ProductId, int Quantity)
        {
            _purchaseOrderRepository.AddProductsToPurchaseList(PurchaseOrderId, ProductId, Quantity);
        }
    }
}
