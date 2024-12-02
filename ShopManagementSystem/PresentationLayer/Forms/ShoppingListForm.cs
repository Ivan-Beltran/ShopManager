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
        private bool _isOrderConfirmed = false;
        public ShoppingListForm(int idOrder, IPurchaseOrdersServices purchaseOrderServices)
        {
            _purchaseOrderServices = purchaseOrderServices;
            _idOrder = idOrder;
            InitializeComponent();
            LoadAllProducts();
            InitializeShoppingCartTable();
            productQuantityTextBox.TextChanged += (s, e) => quantityErrorProvider.SetError(productQuantityTextBox, "");

        }
        public void InitializeShoppingCartTable()
        {
            shoppingCartTable = new DataTable();
            shoppingCartTable.Columns.Add("Id", typeof(int));
            shoppingCartTable.Columns.Add("Marca", typeof(string));
            shoppingCartTable.Columns.Add("Modelo", typeof(string));
            shoppingCartTable.Columns.Add("Version", typeof(string));
            shoppingCartTable.Columns.Add("Color", typeof(string));
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

        private void addPurchaseOrderButton_Click(object sender, EventArgs e)
        {
            if (shoppingCartTable.Rows.Count == 0)
            {
                MessageBox.Show("seleccione al menos un producto para realizar el pedido",
                                "advertencia",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }

            foreach (DataRow row in shoppingCartTable.Rows)
            {
                int productId = Convert.ToInt32(row["Id"]);
                int quantity = Convert.ToInt32(row["Cantidad a comprar"]);


                _purchaseOrderServices.AddProductsToPurchaseList(_idOrder, productId, quantity);
                _isOrderConfirmed = true;
                this.Close();
            }
        }
        private void addShoppingListButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(productQuantityTextBox.Text) ||
                !int.TryParse(productQuantityTextBox.Text, out int quantiti) ||
                quantiti <= 0)
            {
                quantityErrorProvider.SetError(productQuantityTextBox, "Por favor, ingrese una cantidad válida (entero mayor a 0).");
                return;
            }
            else
            {
                int productId = Convert.ToInt32(productsDataGridView.CurrentRow.Cells[0].Value.ToString());
                string productBrand = productsDataGridView.CurrentRow.Cells[2].Value.ToString();
                string productModel = productsDataGridView.CurrentRow.Cells[3].Value.ToString();
                string productVersion = productsDataGridView.CurrentRow.Cells[4].Value.ToString();
                string productColor = productsDataGridView.CurrentRow.Cells[5].Value.ToString();
                int quantity = Convert.ToInt32(productQuantityTextBox.Text);

                shoppingCartTable.Rows.Add(productId, productBrand, productModel, productVersion, productColor, quantity);
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

        private void ShoppingListForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_isOrderConfirmed)
            {
                var confirmResult = MessageBox.Show(
                   "si cierra esta ventana no se creara la orden de compra",
                   "Confirmar eliminación",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    _purchaseOrderServices.DeletePurchaseOrder(_idOrder);
                }

                else
                {
                    e.Cancel = true;
                }

            }


        }

        private void productQuantityTextBox_TextChanged(object sender, EventArgs e)
        {
            quantityErrorProvider.Clear();
        }
    }
}
