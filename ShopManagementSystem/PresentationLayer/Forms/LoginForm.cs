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
            Employees employee = new Employees();
            employee.User=UserTextBox.Text;
            employee.Password=PasswordTextBox.Text;

            LoginValidators loginValidator= new LoginValidators();
            ValidationResult result= loginValidator.Validate(employee);

            if (!result.IsValid)
            {
                DisplayValidationErrors(result);
            }
            else
            {
                if (_loginServices.FindEmployee(employee))
                {
                    EmployeeSesion employeeSesion1 = new EmployeeSesion();
                    employeeSesion1 = _loginServices.GetEmployeeSesion(employee);
                    if (employeeSesion1.EmployeeRoleId == 1)
                    {
                        Dashboard dashboard = new Dashboard();

                        this.Hide();
                        dashboard.Show();
                    }
                    else if (employeeSesion1.EmployeeRoleId == 2)
                    {
                        employeeForm employeeForm = new employeeForm();
                        this.Hide();
                        employeeForm.Show();
                    }
                }
                else
                {
                    MessageBox.Show("credenciales invalidas");
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