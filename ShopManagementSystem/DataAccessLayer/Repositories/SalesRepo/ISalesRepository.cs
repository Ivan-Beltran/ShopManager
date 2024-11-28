using CommonLayer.Entities;
using System.Data;

namespace DataAccessLayer.Repositories.SalesRepo
{
    public interface ISalesRepository
    {
        int AddClient(Clients clientAdded);
        void AddSelesReport(Sales salesAdded);
        void DeleteSaleReport(int SaleReportId);
        DataTable GetSalesReport();
        DataTable SearchSalesReport(DateTime SearchTerm);
        void UpdatesProducts(Products SoldProduct);
    }
}