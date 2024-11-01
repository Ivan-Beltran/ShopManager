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
        public LoginForm(ILoginService loginServices)
        {
            InitializeComponent();
            _loginServices = loginServices;
            PasswordTextBox.PasswordChar = '*';
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
                
                LoginButton.Enabled = true;
                return;
            }

            try
            {
                EmployeeSesion employeeSesion = await _loginServices.GetSessionAsync(employeesInput);

                if (employeeSesion == null)
                {
                    MessageBox.Show("No se encontró ningún usuario.");
                }
                else
                {
                    if (employeeSesion.PasswordEmployee == employeesInput.Password)
                    {
                        switch (employeeSesion.RoleId)
                        {
                            case 1:
                                this.Hide();
                                DashboardForm dashboardForm = new DashboardForm(employeeSesion);
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