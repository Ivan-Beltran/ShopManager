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

namespace PresentationLayer.Forms
{
    public partial class RegisterClients : Form
    {
        public List<Products> _productsAdded;
        private ISalesServices _salesServices;
        public RegisterClients(ISalesServices salesServices, List<Products> productsAdded)
        {
            InitializeComponent();
            _productsAdded = productsAdded;
            _salesServices = salesServices;
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
                RegisterClientsValidator loginValidator = new RegisterClientsValidator();
                ValidationResult result = loginValidator.Validate(clientAdded);

                if (!result.IsValid)
                {
                    DisplayValidationErrors(result);                   
                    return;
                }

                int clientId=_salesServices.AddClient(clientAdded);
                DateTime actualDay= DateTime.Now;

            
                foreach(Products product in _productsAdded)
                {
                    _salesServices.UpdatesProducts(product);

                    var SalesReport = new Sales()
                    {
                        SaleClientId=clientId,
                        SaleProductId=product.ProductId,
                        QuantitySold=product.ProductAmount,
                        TotalAmount=(product.ProductAmount * product.ProductPrice),
                        SaleDate=actualDay,
                    };

                    _salesServices.AddSelesReport(SalesReport);
                }

                MessageBox.Show("compra realizada con exito");
                this.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);    
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
}

    }