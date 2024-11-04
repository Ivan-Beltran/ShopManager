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
        private ILoginService _loginServices;
        private IEmployeeService _employeeServices;
        public LoginForm(ILoginService loginServices, IEmployeeService employeeServices)
        {
            InitializeComponent();
            _loginServices = loginServices;
            PasswordTextBox.PasswordChar = '*';
            ShowPasswordCheckBox.CheckedChanged += ShowPasswordCheckBox_CheckedChanged;
            _employeeServices = employeeServices;
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
                    MessageBox.Show("No se encontró ningún usuario.");
                }
                else
                {
                    if (employeeSesion.PasswordEmployee == employeesInput.PasswordEmployee)
                    {
                        switch (employeeSesion.RoleId)
                        {
                            case 1:
                                this.Hide();
                                DashboardForm dashboardForm = new DashboardForm(employeeSesion,_employeeServices);
                                dashboardForm.Show();
                                break;
                            case 2:
                                MessageBox.Show("Eres cajero.");
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Contraseña incorrecta.", "Error");
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

      
    }
}