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
            inventoryDataGridView.Columns["ID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            inventoryDataGridView.Columns["Unidades"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            inventoryDataGridView.Columns["Precio"].DefaultCellStyle.Format = "C2";

        }

        public void TotalProductLabels(Label totalLabel, string productType)
        {
            int totalProduct = 0;

            foreach (DataGridViewRow row in inventoryDataGridView.Rows)
            {
                if (row.Cells["Categoria"].Value != null && row.Cells["Categoria"].Value.ToString() == productType)
                {
                    if (row.Cells["Unidades"].Value != null)
                    {
                        totalProduct += Convert.ToInt32(row.Cells["Unidades"].Value);
                    }
                }
            }
            totalLabel.Text = "Total : " + totalProduct.ToString();
        }

        public void LoadTotalProductsLabels()
        {
            TotalProductLabels(pcTotalLabel, "Ordenadores");
            TotalProductLabels(totalLaptosLabel, "Laptops");
            TotalProductLabels(totalMovilesLabel, "Moviles");
            TotalProductLabels(totalTabletsLabel, "Tablets");
            TotalProductLabels(totalAccesoriesLabel, "Accesorios");
        }

        private void showPcButton_Click(object sender, EventArgs e)
        {
            string productType = "Ordenadores";

            inventoryDataGridView.DataSource = _inventoryServices.GetProductsType(productType);

        }

        private void showLaptopsButton_Click(object sender, EventArgs e)
        {
            string productType = "Laptops";

            inventoryDataGridView.DataSource = _inventoryServices.GetProductsType(productType);
        }

        private void showMovilesButton_Click(object sender, EventArgs e)
        {
            string productType = "Moviles";

            inventoryDataGridView.DataSource = _inventoryServices.GetProductsType(productType);
        }

        private void showTabletsButton_Click(object sender, EventArgs e)
        {
            string productType = "Tablets";

            inventoryDataGridView.DataSource = _inventoryServices.GetProductsType(productType);
        }

        private void showAccesoriesButton_Click(object sender, EventArgs e)
        {
            string productType = "Accesorios";

            inventoryDataGridView.DataSource = _inventoryServices.GetProductsType(productType);
        }

        private void showAllProductsButton_Click(object sender, EventArgs e)
        {
            LoadAllProducts();
        }

        private void searchProductButton_Click(object sender, EventArgs e)
        {
            string searchProductTerm = searchProductTextBox.Text;

            inventoryDataGridView.DataSource = _inventoryServices.SearchProduct(searchProductTerm);

        }

        private void searchProductTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchProductTextBox.Text))
            {

                LoadAllProducts();
            }
        }

        private void searchProductTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string searchProductTerm = searchProductTextBox.Text;

                inventoryDataGridView.DataSource = _inventoryServices.SearchProduct(searchProductTerm);
            }
        }
    }
}
