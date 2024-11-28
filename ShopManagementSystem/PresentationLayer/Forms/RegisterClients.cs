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
    public partial class RegisterClients : Form
    {
        public List<Products> _productsAdded;
        private ISalesServices _salesServices;
        private decimal _totalProductsPrice;
        public RegisterClients(ISalesServices salesServices, List<Products> productsAdded,decimal totalProductsPrice)
        {
            InitializeComponent();
            _productsAdded = productsAdded;
            _salesServices = salesServices;
            _totalProductsPrice = totalProductsPrice;
        }

        private void finishPurchaseButton_Click(object sender, EventArgs e)
        {
            try
            {
                Clients clientAdded = new Clients()
                {
                    ClientName=nameTextBox.Text,
                    ClientLastName=lastNameTextBox.Text,
                    ClientEmail=emailTextBox.Text,
                    ClientDUI=duiTextBox.Text,
                    ClientTelephone=phoneTextBox.Text, 
                };

                int clientId=_salesServices.AddClient(clientAdded);
                DateTime actualDay= DateTime.Now;

                var SalesReport = new Sales()
                {
                    SaleClientId=clientId,
                    TotalAmount=_totalProductsPrice,
                    SaleDate=actualDay,
                };

                 int salesId= _salesServices.AddSelesReport(SalesReport);
            
                foreach(Products product in _productsAdded)
                {
                    decimal totalPrice = product.ProductAmount * product.ProductPrice;

                    _salesServices.UpdatesProducts(product);
                    _salesServices.AddIntoSalesList(salesId, product.ProductId, product.ProductAmount, totalPrice);

                    
                }

                MessageBox.Show("compra realizada con exito");
                this.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);    
            }
        }
    }
}
