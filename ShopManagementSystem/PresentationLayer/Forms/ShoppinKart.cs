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
using BussinessLayer.Services.ServicesForSales;
namespace PresentationLayer.Forms
{
    public partial class ShoppinKart : Form
    {
        public DataTable ShoppingKartTable;
        public List<Products> _productsAdded;
        private ISalesServices _salesServices;
        
        public ShoppinKart(List<Products> productsAdded,ISalesServices salesServices)
        {
            _productsAdded = productsAdded;
            _salesServices = salesServices;
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

            foreach (Products product in _productsAdded)
            {
                decimal totalPriceProducts = product.ProductAmount * product.ProductPrice;

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
                    _productsAdded.RemoveAt(rowIndex);

                    decimal totalPricePurchase = 0;

                    foreach (Products product in _productsAdded)
                    {
                        decimal totalPriceProducts = product.ProductAmount * product.ProductPrice;

                        totalPricePurchase += totalPriceProducts;
                    }

                    totalLabel.Text = $"$: {totalPricePurchase}";

 
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila para eliminar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void makePurchaseButton_Click(object sender, EventArgs e)
        {
            RegisterClients registerClients= new RegisterClients(_salesServices ,_productsAdded);
            registerClients.FormClosed += (s, arg) =>
            {
                _productsAdded.Clear();
                this.Close();

            };
            registerClients.ShowDialog();

            
        }

        private void ShoppinKart_FormClosing(object sender, FormClosingEventArgs e)
        {
            string productList = _productsAdded.Count.ToString();
        }
    }
}

