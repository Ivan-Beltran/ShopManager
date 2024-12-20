﻿using CommonLayer.Entities;
using System.Data;

namespace BussinessLayer.Services.ServicersForPurchaseOrders
{
    public interface IPurchaseOrdersServices
    {
        void AddProductsToPurchaseList(int PurchaseOrderId, int ProductId, int Quantity);
        int AddPurchaseOrder(PurchaseOrders purchaseOrders);
        void DeletePurchaseOrder(int purchaseOrderId);
        DataTable GetAllProducts();
        DataTable GetPurchaseOrders();
        DataTable GetShoppingList(int PurchaseOrderId);
        DataTable GetSuppliers();
        void OrderReceived(int PurchaseOrderId);
        DataTable SearchProducts(string search);
    }
}