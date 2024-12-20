﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinessLayer.Services.ServicesForEmployees;
using BussinessLayer.Services.ServicesForLogin;
using CommonLayer.Entities;
using FluentValidation.Results;
using PresentationLayer.Validations;
using BussinessLayer.Services.ServicesForInventory;
using BussinessLayer.Services.ServicesForSuppliers;
using BussinessLayer.Services.ServicersForPurchaseOrders;
using BussinessLayer.Services.ServicesForProducts;
using BussinessLayer.Services.ServicesForSales;
using BussinessLayer.Services.ServicesForClients;

namespace PresentationLayer.Forms
{
    public partial class LoginForm : Form
    {
        private ILoginService _loginServices;
        private IEmployeeService _employeeServices;
        private IInventoryService _inventoryServices;
        private ISuppliersServices _suppliersServices;
        private IPurchaseOrdersServices _purchaseOrderServices;
        private IProductsService _productsServices;
        private ISalesServices _salesServices;
        private IClientsServices _clientsServices;


        public LoginForm(ILoginService loginServices,
            IEmployeeService employeeServices,
            IInventoryService inventoryServices,
            ISuppliersServices suppliersServices,
            IPurchaseOrdersServices purchaseOrderServices,
            IProductsService productsService,
            ISalesServices salesServices,
            IClientsServices clientsServices)
        {
            InitializeComponent();
            _loginServices = loginServices;
            _inventoryServices = inventoryServices;
            _employeeServices = employeeServices;
            _suppliersServices = suppliersServices;
            _purchaseOrderServices = purchaseOrderServices;
            _productsServices = productsService;
            _salesServices = salesServices;
            PasswordTextBox.PasswordChar = '*';
            _clientsServices = clientsServices;
            ShowPasswordCheckBox.CheckedChanged += ShowPasswordCheckBox_CheckedChanged;
        }

        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPasswordCheckBox.Checked)
            {

                PasswordTextBox.PasswordChar = '\0';
            }
            else
            {
                PasswordTextBox.PasswordChar = '*';
            }
        }
        private async void LoginButton_Click(object sender, EventArgs e)
        {

            LoginButton.Enabled = false;


            Employees employeesInput = new Employees
            {
                UserEmployee = UserTextBox.Text,
                PasswordEmployee = PasswordTextBox.Text
            };

            LoginValidators loginValidator = new LoginValidators();
            ValidationResult result = loginValidator.Validate(employeesInput);

            if (!result.IsValid)
            {
                DisplayValidationErrors(result);

                LoginButton.Enabled = true;
                return;
            }

            try
            {
                Employees employeeSesion = await _loginServices.GetSessionAsync(employeesInput);

                if (employeeSesion == null)
                {
                    MessageBox.Show("No se encontró ningún usuario.", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (employeeSesion.PasswordEmployee == employeesInput.PasswordEmployee)
                    {
                        this.Hide();
                        DashboardForm dashboardForm = new DashboardForm(
                            employeeSesion,
                            _employeeServices,
                            _inventoryServices,
                            _suppliersServices,
                            _purchaseOrderServices,
                            _productsServices,
                            _salesServices,
                            _clientsServices);

                        dashboardForm.FormClosed += (s, arg) =>
                        {

                            this.Show();
                            UserTextBox.Text = "";
                            PasswordTextBox.Text = "";
                        };
                        dashboardForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Contraseña incorrecta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Se produjo un error inesperado: {ex.Message}");
            }
            finally
            {
                LoginButton.Enabled = true;
            }
        }

        private void DisplayValidationErrors(ValidationResult result)
        {
            validationsErrorProvider.Clear();

            foreach (var error in result.Errors)
            {
                switch (error.PropertyName)
                {
                    case nameof(Employees.UserEmployee):
                        validationsErrorProvider.SetError(UserTextBox, error.ErrorMessage);
                        break;
                    case nameof(Employees.PasswordEmployee):
                        validationsErrorProvider.SetError(PasswordTextBox, error.ErrorMessage);
                        break;
                }
            }

        }

        private void Registredbutton_Click(object sender, EventArgs e)
        {
            var clientSession = new Employees() { };

            this.Hide();
            DashboardForm dashboardForm = new DashboardForm(
                clientSession,
                _employeeServices,
                _inventoryServices,
                _suppliersServices,
                _purchaseOrderServices,
                _productsServices,
                _salesServices,
                _clientsServices);

            dashboardForm.FormClosed += (s, arg) =>
            {

                this.Show();
                UserTextBox.Text = "";
                PasswordTextBox.Text = "";
            };

            dashboardForm.Show();
        }

        private void UserTextBox_TextChanged(object sender, EventArgs e)
        {
            validationsErrorProvider.Clear();
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            validationsErrorProvider.Clear();
        }
    }
}