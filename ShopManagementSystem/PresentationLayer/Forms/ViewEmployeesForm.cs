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
using Microsoft.Data.SqlClient;

namespace PresentationLayer.Forms
{
    public partial class ViewEmployeesForm : Form
    {
        private readonly IEmployeeService _employeeService;
        public ViewEmployeesForm(IEmployeeService employeeService)
        {
            InitializeComponent();
            _employeeService = employeeService;
            LoadEmployees();
            LoadRoles();
        }

        public void LoadEmployees()
        {
            EmployeesDataGridView.DataSource = _employeeService.GetEmployees();

        }

        public void LoadRoles()
        {
            rolesComboBox.DataSource = _employeeService.GetRoles();
            rolesComboBox.DisplayMember = "Cargos";
            rolesComboBox.ValueMember = "RoleId";
            rolesComboBox.SelectedIndex = -1;
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            Employees empleyeeAdded = new Employees()
            {
                Names=namesTextBox.Text,
                LastNames=lastNamesTextBox.Text,
                UserEmployee=UserTextBox.Text,
                PasswordEmployee=passwordTextBox.Text,
                DUI=duiTextBox.Text,
                Email=emailTextBox.Text,
                RoleId=Convert.ToInt32( rolesComboBox.SelectedValue)
            };

            try
            {
            _employeeService.AddEmployee(empleyeeAdded);
            }
            catch (SqlException ex)
            {
                if(ex.Number == 2627)
                {
                    MessageBox.Show("nombre de usuario existente, por favor elija otro ", "error");
                }   
            }
            finally
            {

            LoadEmployees();
            }
        }
    }
}
