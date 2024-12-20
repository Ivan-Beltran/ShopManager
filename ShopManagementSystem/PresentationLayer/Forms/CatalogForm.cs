﻿using BussinessLayer.Services.ServicesForProducts;
using BussinessLayer.Services.ServicesForSales;
using BussinessLayer.Services.ServicesForSuppliers;
using CommonLayer.Entities;
using PresentationLayer.Controls;
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
    public partial class CatalogForm : Form
    {

        private IProductsService _productsServices;
        private ISalesServices _salesServices;

        public List<Products> ProductList;

        private List<Products> _shoppingCart = new List<Products>();




        public CatalogForm(IProductsService productsService,ISalesServices salesServices)
        {
            InitializeComponent();
            _productsServices = productsService;
            _salesServices = salesServices;
            productsFlowLayoutPanel.FlowDirection = FlowDirection.LeftToRight;  // Dirección de los controles de izquierda a derecha
            productsFlowLayoutPanel.WrapContents = true;  // Habilitar el ajuste de los controles a la siguiente línea
            productsFlowLayoutPanel.AutoScroll = true; // Permite desplazamiento si el contenido excede el panel
            productCountLabel.Visible = false;
            LoadProductList();
            LoadProductGrid();
            LoadProductsOnShoppingKart();

        }

        public void LoadProductList()
        {
            ProductList = _productsServices.GetAllProduct();
        }

        public void LoadProductGrid()
        {
            productsFlowLayoutPanel.Controls.Clear();

            foreach (var product in ProductList)
            {
                var ProductControl = new ProductsControl(product);
                ProductControl.ProductAddedToCart += OnProductAddedToCart;

                productsFlowLayoutPanel.Controls.Add(ProductControl);

            }
        }

        public void LoadSearchProducts(string searchTerm)
        {
            // Verifica si el término de búsqueda no está vacío
            if (!string.IsNullOrEmpty(searchTerm))
            {
                ProductList = _productsServices.SearchProduct(searchTerm);
            }
            else
            {
                // Si el término de búsqueda está vacío, carga todos los productos
                ProductList = _productsServices.GetAllProduct();
            }
        }


        private void searchButton_Click_2(object sender, EventArgs e)
        {
            string searchTerm = searchTextBox.Text.Trim();  // Elimina espacios al principio y final

            LoadSearchProducts(searchTerm);

            // Limpia los controles anteriores del FlowLayoutPanel
            productsFlowLayoutPanel.Controls.Clear();

            // Ahora agrega los controles actualizados
            foreach (var product in ProductList)
            {
                var ProductControl = new ProductsControl(product);
                productsFlowLayoutPanel.Controls.Add(ProductControl);
            }


        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(searchTextBox.Text))
            {
                productsFlowLayoutPanel.Controls.Clear();

                LoadProductList();
                LoadProductGrid();
            }
        }

        private void shoppingcart_Click_1(object sender, EventArgs e)
        {
            ShoppinKart shoppinKart = new ShoppinKart(_shoppingCart,_salesServices);
            shoppinKart.FormClosed += (s, args) =>
            {
                LoadProductsOnShoppingKart();
                LoadProductList(); 
                LoadProductGrid();
            };
            shoppinKart.ShowDialog();
        }

        private void OnProductAddedToCart(object sender, Products product)
        {
            if (!_shoppingCart.Any(p => p.ProductId == product.ProductId))
            {
                MessageBox.Show("producto agregado al carrito","informacion",MessageBoxButtons.OK, MessageBoxIcon.Information);
                _shoppingCart.Add(product); // Agregar al carrito solo si no existe
                LoadProductsOnShoppingKart(); // Actualizar el contador del carrito
            }
            else
            {
                MessageBox.Show("El producto ya se encuentra en el carrito");
            }
        }

        private void LoadProductsOnShoppingKart()
        {
            if (_shoppingCart.Count > 0)
            {
                productCountLabel.Visible = true;
                productCountLabel.Text = _shoppingCart.Count().ToString();
            }
            else if (_shoppingCart.Count == 0)
            {
                productCountLabel.Visible = false;
            }



        }

        
    }
}
