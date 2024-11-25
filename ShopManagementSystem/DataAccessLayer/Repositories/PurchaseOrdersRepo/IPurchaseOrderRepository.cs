﻿using CommonLayer.Entities;
using System.Data;

namespace DataAccessLayer.Repositories.PurchaseOrdersRepo
{
    public interface IPurchaseOrderRepository
    {
        void AddProductsToPurchaseList(int PurchaseOrderId, int ProductId, int Quantity);
        int AddPurchaseOrder(PurchaseOrders purchaseOrder);
        DataTable GetAllProducts();
        DataTable GetPurchaseOrders();
        DataTable GetShoppingList(int PurchaseOrderId);
        DataTable GetSuppliers();
        DataTable SearchProduct(string search);
    }
}