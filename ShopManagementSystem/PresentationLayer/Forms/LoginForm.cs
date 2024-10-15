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
        private LoginService _loginServices;
        public LoginForm()
        {
            InitializeComponent();
            _loginServices = new LoginService();
        }


        private void LoginButton_Click(object sender, EventArgs e)
        {
            EmployeesInput employeesInput = new EmployeesInput
            {
                User = UserTextBox.Text,
                Password = PasswordTextBox.Text
            };

            LoginValidators loginValidator = new LoginValidators();
            ValidationResult result = loginValidator.Validate(employeesInput);

            if (!result.IsValid)
            {
                DisplayValidationErrors(result);
            }
            else
            {
                try
                {
                    EmployeeSesion employeeSesion = _loginServices.GetSesion(employeesInput);

                    if (employeeSesion != null)
                    {
                        if (employeeSesion.EmployeeRoleId == 1)
                        {
                            Dashboard dashboard = new Dashboard(employeeSesion);
                            this.Hide();
                            dashboard.Show();
                        }
                        else if (employeeSesion.EmployeeRoleId == 2)
                        {
                            EmployeeForm employeeForm = new EmployeeForm();
                            this.Hide();
                            employeeForm.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Credenciales no válidas");
                    }
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message); // Manejo de argumento vacío
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Se produjo un error inesperado: {ex.Message}"); // Manejo de errores inesperados
                }
            }
        }

        private void DisplayValidationErrors(ValidationResult result)
        {
            validationsErrorProvider.Clear();

            foreach (var error in result.Errors)
            {
                switch (error.PropertyName)
                {
                    case nameof(EmployeesInput.User):
                        validationsErrorProvider.SetError(UserTextBox, error.ErrorMessage);
                        break;
                    case nameof(EmployeesInput.Password):
                        validationsErrorProvider.SetError(PasswordTextBox, error.ErrorMessage);
                        break;
                }
            }

        }

    }
}