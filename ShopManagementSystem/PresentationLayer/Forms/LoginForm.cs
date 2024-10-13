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
                User=UserTextBox.Text,
                Password=PasswordTextBox.Text,
            };
            if (_employeeServices.FindEmployee(employees))
            {
                MessageBox.Show("bienvenido");
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("usuario o contraseña incorrectos");
            } 
        }
    }
}
