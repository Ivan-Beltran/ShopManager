using CommonLayer.Entities;
using System.Data;

namespace BussinessLayer.Services.ServicesForSales
{
    public interface ISalesServices
    {
        int AddClient(Clients clientAdded);
        void AddSelesReport(Sales salesAdded);
        void DeleteSaleReport(int SaleReportId);
        DataTable GetSalesReport();
        DataTable SearchSalesReport(DateTime SearchTerm);
        void UpdatesProducts(Products SoldProduct);
    }
}