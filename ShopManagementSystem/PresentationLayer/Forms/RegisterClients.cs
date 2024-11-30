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
using PresentationLayer.Validations;
using FluentValidation.Results;
using PresentationLayer.PdfGenerator;

namespace PresentationLayer.Forms
{
    public partial class RegisterClients : Form
    {
        
        public List<Products> _productsAdded;
        private ISalesServices _salesServices;
        private decimal _totalProductsPrice;
        public event EventHandler ReturnForm;
        public RegisterClients(ISalesServices salesServices, List<Products> productsAdded, decimal totalProductsPrice)
        {
            InitializeComponent();
            _productsAdded = productsAdded;
            _salesServices = salesServices;
            _totalProductsPrice = totalProductsPrice;
           
        }

        private void finishPurchaseButton_Click(object sender, EventArgs e)
        {
            if (_productsAdded.Count > 0)
            {

                try
                {
                    Clients clientAdded = new Clients()
                    {
                        ClientName = nameTextBox.Text,
                        ClientLastName = lastNameTextBox.Text,
                        ClientEmail = emailTextBox.Text,
                        ClientDUI = duiTextBox.Text,
                        ClientTelephone = phoneTextBox.Text,
                    };
                    RegisterClientsValidator loginValidator = new RegisterClientsValidator();
                    ValidationResult result = loginValidator.Validate(clientAdded);

                    if (!result.IsValid)
                    {
                        DisplayValidationErrors(result);
                        return;
                    }

                    int clientId = _salesServices.AddClient(clientAdded);
                    DateTime actualDay = DateTime.Now;

                    var SalesReport = new Sales()
                    {
                        SaleClientId = clientId,
                        TotalAmount = _totalProductsPrice,
                        SaleDate = actualDay,
                    };

                    int salesId = _salesServices.AddSelesReport(SalesReport);

                    foreach (Products product in _productsAdded)
                    {
                        decimal totalPrice = product.ProductAmount * product.ProductPrice;

                        _salesServices.UpdatesProducts(product);
                        _salesServices.AddIntoSalesList(salesId, product.ProductId, product.ProductAmount, totalPrice);


                    }

                    MessageBox.Show("compra realizada con exito");
                    PdfGenerate pdfGenerator = new PdfGenerate();
                    pdfGenerator.GenerateClientsTickets(_productsAdded,clientAdded,salesId,_totalProductsPrice);
                    this.Close();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("en carrito de compras esta vacio",
                    "notificacion",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                
            }
        }
        private void DisplayValidationErrors(ValidationResult result)
        {
            validationsErrorProvider.Clear();

            foreach (var error in result.Errors)
            {
                switch (error.PropertyName)
                {
                    case nameof(Clients.ClientName):
                        validationsErrorProvider.SetError(nameTextBox, error.ErrorMessage);
                        break;
                    case nameof(Clients.ClientLastName):
                        validationsErrorProvider.SetError(lastNameTextBox, error.ErrorMessage);
                        break;
                    case nameof(Clients.ClientTelephone):
                        validationsErrorProvider.SetError(phoneTextBox, error.ErrorMessage);
                        break;
                    case nameof(Clients.ClientEmail):
                        validationsErrorProvider.SetError(emailTextBox, error.ErrorMessage);
                        break;
                    case nameof(Clients.ClientDUI):
                        validationsErrorProvider.SetError(duiTextBox, error.ErrorMessage);
                        break;
                }
            }

        }

        private void cancelPurchaseButton_Click(object sender, EventArgs e)
        {
            OnReturnForm();
        }

        private void RegisterClients_VisibleChanged(object sender, EventArgs e)
        {
            
        }

        protected virtual void OnReturnForm()
        {
            ReturnForm?.Invoke(this, EventArgs.Empty);
            this.Hide();
        }
    }

}