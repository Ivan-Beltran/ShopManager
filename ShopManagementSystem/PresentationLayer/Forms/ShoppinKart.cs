using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommonLayer.Entities;

namespace PresentationLayer.Forms
{
    public partial class ShoppinKart : Form
    {
        public DataTable ShoppingKartTable;
        private List<Products> _productsAdded;
        public ShoppinKart(List<Products> productsAdded)
        {
            _productsAdded = productsAdded;
            InitializeComponent();
            LoadShoppingKart();
            shoppingKartDataGridView.Columns["Precio"].DefaultCellStyle.Format = "C";
        }

        public void LoadShoppingKart()
        {
            ShoppingKartTable = new DataTable();
            ShoppingKartTable.Columns.Add("Id", typeof(int));
            ShoppingKartTable.Columns.Add("Marca", typeof(string));
            ShoppingKartTable.Columns.Add("Modelo", typeof(string));
            ShoppingKartTable.Columns.Add("Version", typeof(string));
            ShoppingKartTable.Columns.Add("Color", typeof(string));
            ShoppingKartTable.Columns.Add("Cantidad a comprar", typeof(int));
            ShoppingKartTable.Columns.Add("Precio", typeof(decimal)); // Tipo decimal para manejo de precios

            // Llenar la tabla con los datos de la lista de productos
            foreach (Products product in _productsAdded)
            {
                ShoppingKartTable.Rows.Add(
                    product.ProductId,
                    product.ProductBrand,
                    product.ProductModel,
                    product.ProductVersion,
                    product.ProductColor,
                    product.ProductAmount,
                    product.ProductPrice
                );
            }


            shoppingKartDataGridView.DataSource = ShoppingKartTable;

            decimal totalPricePurchase = 0;

            foreach(Products product in _productsAdded)
            {
                decimal totalPriceProducts= product.ProductAmount * product.ProductPrice;

                totalPricePurchase += totalPriceProducts;
            }

            totalLabel.Text = $"$: {totalPricePurchase}";
        }

        private void deleteShoppingKartButton_Click(object sender, EventArgs e)
        {
            if (shoppingKartDataGridView.SelectedRows.Count > 0)
            {
                int rowIndex = shoppingKartDataGridView.CurrentRow.Index;


                var confirmResult = MessageBox.Show(
                    "¿Estás seguro de que deseas eliminar esta producto de la lista?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {

                    ShoppingKartTable.Rows[rowIndex].Delete();
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila para eliminar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void makePurchaseButton_Click(object sender, EventArgs e)
        {

        }
    }
}

