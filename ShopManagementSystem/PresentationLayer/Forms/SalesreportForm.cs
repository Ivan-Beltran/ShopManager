using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinessLayer.Services;
using BussinessLayer.Services.ServicesForSales;

namespace PresentationLayer.Forms
{
    public partial class SalesreportForm : Form
    {
        private ISalesServices _salesServices;

        public SalesreportForm(ISalesServices salesServices)
        {
            InitializeComponent();
            _salesServices = salesServices;
            LoadSalesReport();
        }

        public void LoadSalesReport()
        {
            salesReportDataGridView.DataSource = _salesServices.GetSalesReport();
        }



        private void SearchButton_Click(object sender, EventArgs e)
        {
            DateTime searchTerm = searchReportdateTimePicker.Value.Date;
            salesReportDataGridView.DataSource = _salesServices.SearchSalesReport(searchTerm);

        }

        private void showAllReportsButton_Click(object sender, EventArgs e)
        {
            LoadSalesReport();
        }


        public void LoadSalesDeatail(int SaleId)
        {
            productsBuyingDataGridView.DataSource = _salesServices.GetSalesDetails(SaleId);
        }

        private void viewDetailsButton_Click(object sender, EventArgs e)
        {
            if (salesReportDataGridView.SelectedRows.Count > 0)
            {
                int SaleId = Convert.ToInt32(salesReportDataGridView.CurrentRow.Cells[0].Value);
                LoadSalesDeatail(SaleId);
            }
        }
    }
}
