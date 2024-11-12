using BussinessLayer.Services.ServicesForInventory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.Forms
{
    public partial class InventoryForm : Form
    {
        private IInventoryService _inventoryServices;
        public InventoryForm(IInventoryService inventoryServices)
        {

            InitializeComponent();
            _inventoryServices = inventoryServices;
            LoadAllProducts();
            LoadTotalProductsLabels();

        }

        public void LoadAllProducts()
        {
            inventoryDataGridView.DataSource = _inventoryServices.GetAllProduct();

        }

        public void TotalProductLabels(Label totalLabel, int productTypeId)
        {
            int totalProduct = 0;

            foreach (DataGridViewRow row in inventoryDataGridView.Rows)
            {
                if (row.Cells["ProductTypeId"].Value != null && Convert.ToInt32(row.Cells["ProductTypeId"].Value) == productTypeId)
                {
                    if (row.Cells["ProductAmount"].Value != null)
                    {
                        totalProduct += Convert.ToInt32(row.Cells["ProductAmount"].Value);
                    }
                }
            }
            totalLabel.Text = "Total : " + totalProduct.ToString();
        }

        public void LoadTotalProductsLabels()
        {
            TotalProductLabels(pcTotalLabel, 1);
            TotalProductLabels(totalLaptosLabel, 2);
            TotalProductLabels(totalMovilesLabel, 3);
            TotalProductLabels(totalTabletsLabel, 4);
            TotalProductLabels(totalAccesoriesLabel, 5);
        }

        private void showPcButton_Click(object sender, EventArgs e)
        {
            int productTypeId = 1;

            inventoryDataGridView.DataSource = _inventoryServices.GetProductsType(productTypeId);

        }

        private void showLaptopsButton_Click(object sender, EventArgs e)
        {
            int productTypeId = 2;

            inventoryDataGridView.DataSource = _inventoryServices.GetProductsType(productTypeId);
        }

        private void showMovilesButton_Click(object sender, EventArgs e)
        {
            int productTypeId = 3;

            inventoryDataGridView.DataSource = _inventoryServices.GetProductsType(productTypeId);
        }

        private void showTabletsButton_Click(object sender, EventArgs e)
        {
            int productTypeId = 4;

            inventoryDataGridView.DataSource = _inventoryServices.GetProductsType(productTypeId);
        }

        private void showAccesoriesButton_Click(object sender, EventArgs e)
        {
            int productTypeId = 5;

            inventoryDataGridView.DataSource = _inventoryServices.GetProductsType(productTypeId);
        }

        private void showAllProductsButton_Click(object sender, EventArgs e)
        {
            LoadAllProducts();
        }
    }
}
