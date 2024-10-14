using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinessLayer.Services;
using CommonLayer.Entities;
using FluentValidation.Results;
using PresentationLayer.Validations;

namespace PresentationLayer.Forms
{
    public partial class LoginForm : Form
    {
        private EmployeesServices _employeeServices;
        public LoginForm()
        {
            InitializeComponent();
            _employeeServices = new EmployeesServices();
        }


        private void LoginButton_Click(object sender, EventArgs e)
        {
            Employees employees = new Employees()
            {
                User = UserTextBox.Text,
                Password = PasswordTextBox.Text,
            };
            LoginValidators loginValidator = new LoginValidators();
            ValidationResult result = loginValidator.Validate(employees);

            if (!result.IsValid)
            {
                DisplayValidationErrors(result);

            }
            else if (_employeeServices.FindEmployee(employees))
            {

                Dashboard dashboard = new Dashboard();
                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("usuario o contraseña incorrectos");
            }
        }
            private void DisplayValidationErrors(ValidationResult result)
            {
            validationsErrorProvider.Clear();

                foreach (var error in result.Errors)
                {
                    switch (error.PropertyName)
                    {
                        case nameof(Employees.User):
                            validationsErrorProvider.SetError(UserTextBox, error.ErrorMessage);
                            break;
                        case nameof(Employees.Password):
                            validationsErrorProvider.SetError(PasswordTextBox, error.ErrorMessage);
                            break;
                    }
                }
            }
        }
    }
