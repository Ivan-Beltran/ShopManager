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
            shoppingCartTable.Columns.Add("Id", typeof(int));
            shoppingCartTable.Columns.Add("Marca", typeof(string));
            shoppingCartTable.Columns.Add("Modelo", typeof(string));
            shoppingCartTable.Columns.Add("Version", typeof(string));
            shoppingCartTable.Columns.Add("Cantidad a comprar", typeof(int));

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
            if(string.IsNullOrWhiteSpace(productQuantityTextBox.Text) || Convert.ToInt32(productQuantityTextBox.Text)<1)
            {
                quantityErrorProvider.SetError(productQuantityTextBox, "por favor ingrese una cantidad");
            }
            else
            {
                int productId = Convert.ToInt32(productsDataGridView.CurrentRow.Cells[0].Value.ToString());
                string productBrand = productsDataGridView.CurrentRow.Cells[2].Value.ToString();
                string productModel = productsDataGridView.CurrentRow.Cells[2].Value.ToString();
                string productVersion = productsDataGridView.CurrentRow.Cells[2].Value.ToString();
                int quantity = Convert.ToInt32(productQuantityTextBox.Text);

                 shoppingCartTable.Rows.Add(productId, productBrand, productModel, productVersion, quantity);
            }


        }

        private void addPurchaseOrderButton_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in shoppingCartTable.Rows)
            {
                int productId = Convert.ToInt32(row["ProductId"]);
                int quantity = Convert.ToInt32(row["Quantity"]);


                _purchaseOrderServices.AddProductsToPurchaseList(_idOrder, productId, quantity);
            }
        }

        private void deleteShoppingListButton_Click(object sender, EventArgs e)
        {
            if (shoppingListDataGridView.CurrentRow != null)
            {

                int rowIndex = shoppingListDataGridView.CurrentRow.Index;


                var confirmResult = MessageBox.Show(
                    "¿Estás seguro de que deseas eliminar esta fila?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {

                    shoppingCartTable.Rows[rowIndex].Delete();
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila para eliminar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
