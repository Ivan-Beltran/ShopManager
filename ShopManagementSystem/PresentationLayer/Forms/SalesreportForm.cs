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

        private void deteleReportButton_Click(object sender, EventArgs e)
        {
            if (salesReportDataGridView.Rows.Count > 0)
            {
                int SaleReportId = Convert.ToInt32(salesReportDataGridView.CurrentRow.Cells[0].Value);

                DialogResult result = MessageBox.Show(
                "¿Estás seguro de que deseas eliminar este reporte de venta?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);


                if (result == DialogResult.Yes)
                {
                    _salesServices.DeleteSaleReport(SaleReportId);

                    LoadSalesReport();

                    MessageBox.Show("Reporte de venta eliminado correctamente.", "Eliminación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
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
    }
}
