using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonLayer.Entities;
using DataAccessLayer.Repositories.SalesRepo;

namespace BussinessLayer.Services.ServicesForSales
{
    public class SalesServices : ISalesServices
    {
        private ISalesRepository _salesRepository;

        public SalesServices(ISalesRepository salesRepository)
        {
            _salesRepository = salesRepository;
        }

        public void UpdatesProducts(Products SoldProduct)
        {
            _salesRepository.UpdatesProducts(SoldProduct);
        }

        public int AddClient(Clients clientAdded)
        {
            return _salesRepository.AddClient(clientAdded);
        }

        public int AddSelesReport(Sales salesAdded)
        {
           return _salesRepository.AddSelesReport(salesAdded);
        }

        public DataTable GetSalesReport()
        {
            return _salesRepository.GetSalesReport();
        }
        public void DeleteSaleReport(int SaleReportId)
        {
            _salesRepository.DeleteSaleReport(SaleReportId);
        }
        public DataTable SearchSalesReport(DateTime SearchTerm)
        {
            return _salesRepository.SearchSalesReport(SearchTerm);
        }

        public void AddIntoSalesList(int SalesId, int ProductId, int QuantitySold, decimal Total)
        {
            _salesRepository.AddIntoSalesList(SalesId, ProductId, QuantitySold, Total);
        }
        public DataTable GetSalesDetails(int SalesId)
        {
            return _salesRepository.GetSalesDetails(SalesId);
        }
    }
}
