using BussinessLayer.Services.ServicersForPurchaseOrders;
using Microsoft.IdentityModel.Tokens;
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
    public partial class ShoppingListForm : Form
    {
        private int _idOrder;
        private IPurchaseOrdersServices _purchaseOrderServices;
        private DataTable shoppingCartTable;
        public ShoppingListForm(int idOrder, IPurchaseOrdersServices purchaseOrderServices)
        {
            _purchaseOrderServices = purchaseOrderServices;
            _idOrder = idOrder;
            InitializeComponent();
            LoadAllProducts();
            InitializeShoppingCartTable();
        }
        public void InitializeShoppingCartTable()
        {
            shoppingCartTable = new DataTable();
            shoppingCartTable.Columns.Add("ProductId", typeof(int));
            shoppingCartTable.Columns.Add("ProductName", typeof(string));
            shoppingCartTable.Columns.Add("Quantity", typeof(int));

            // Asocia la tabla temporal al DataGridView para mostrar los productos seleccionados
            shoppingListDataGridView.DataSource = shoppingCartTable;
        }
        public void LoadAllProducts()
        {
            productsDataGridView.DataSource = _purchaseOrderServices.GetAllProducts();
        }

        public void LoadShoppingList()
        {

            shoppingListDataGridView.DataSource = _purchaseOrderServices.GetShoppingList(_idOrder);
        }

        private void searchProductButton_Click(object sender, EventArgs e)
        {
            if (searchProductTextBox.Text.IsNullOrEmpty())
            {
                LoadAllProducts();
            }
            else
            {
                string searchTerm = searchProductTextBox.Text;
                productsDataGridView.DataSource = _purchaseOrderServices.SearchProducts(searchTerm);
            }
        }

        private void searchProductTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchProductTextBox.Text))
            {

                LoadAllProducts();
            }
        }

        private void addShoppingListButton_Click(object sender, EventArgs e)
        {
            int productId = Convert.ToInt32(productsDataGridView.CurrentRow.Cells[0].Value.ToString());
            string productName = productsDataGridView.CurrentRow.Cells[1].Value.ToString(); // Suponiendo que la columna 1 es el nombre
            int quantity = Convert.ToInt32(productQuantityTextBox.Text);

            // Agregar el producto a la tabla temporal
            shoppingCartTable.Rows.Add(productId, productName, quantity);
        }

        private void addPurchaseOrderButton_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in shoppingCartTable.Rows)
            {
                int productId = Convert.ToInt32(row["ProductId"]);
                int quantity = Convert.ToInt32(row["Quantity"]);

                // Agregar producto a la lista de compras en la base de datos
                _purchaseOrderServices.AddProductsToPurchaseList(_idOrder, productId, quantity);
            }
        }
    }
}
