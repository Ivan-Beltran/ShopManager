using CommonLayer.Entities;
using System.Data;

namespace DataAccessLayer.Repositories.SalesRepo
{
    public interface ISalesRepository
    {
        int AddClient(Clients clientAdded);
        void AddIntoSalesList(int SalesId, int ProductId, int QuantitySold, decimal Total);
        int AddSelesReport(Sales salesAdded);
        void DeleteSaleReport(int SaleReportId);
        DataTable GetSalesDetails(int SalesId);
        DataTable GetSalesReport();
        DataTable SearchSalesReport(DateTime SearchTerm);
        void UpdatesProducts(Products SoldProduct);
    }
}