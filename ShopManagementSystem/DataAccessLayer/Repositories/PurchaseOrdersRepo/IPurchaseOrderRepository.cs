using CommonLayer.Entities;
using System.Data;

namespace DataAccessLayer.Repositories.PurchaseOrdersRepo
{
    public interface IPurchaseOrderRepository
    {
        void AddProductsToPurchaseList(int PurchaseOrderId, int ProductId, int Quantity);
        int AddPurchaseOrder(PurchaseOrders purchaseOrder);
        void DeletePurchaseOrder(int purchaseOrderId);
        DataTable GetAllProducts();
        DataTable GetPurchaseOrders();
        DataTable GetShoppingList(int PurchaseOrderId);
        DataTable GetSuppliers();
        void OrderReceived(int PurchaseOrderId);
        DataTable SearchProduct(string search);
    }
}