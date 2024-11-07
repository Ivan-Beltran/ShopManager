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
            EmployeesDataGridView.CellClick += EmployeesDataGridView_CellClick;
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
        private void EmployeesDataGridView_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                namesTextBox.Text = EmployeesDataGridView.CurrentRow.Cells[1].Value.ToString();
                lastNamesTextBox.Text = EmployeesDataGridView.CurrentRow.Cells[2].Value.ToString();
                UserTextBox.Text = EmployeesDataGridView.CurrentRow.Cells[3].Value.ToString();
                passwordTextBox.Text = EmployeesDataGridView.CurrentRow.Cells[4].Value.ToString();
                duiTextBox.Text = EmployeesDataGridView.CurrentRow.Cells[5].Value.ToString();
                emailTextBox.Text = EmployeesDataGridView.CurrentRow.Cells[6].Value.ToString();
                rolesComboBox.Text = EmployeesDataGridView.CurrentRow.Cells[7].Value.ToString();
            }
        }
        private void addEmployeeButton_Click(object sender, EventArgs e)
        {
            Employees empleyeeAdded = new Employees()
            {
                Names = namesTextBox.Text,
                LastNames = lastNamesTextBox.Text,
                UserEmployee = UserTextBox.Text,
                PasswordEmployee = passwordTextBox.Text,
                DUI = duiTextBox.Text,
                Email = emailTextBox.Text,
                RoleId = Convert.ToInt32(rolesComboBox.SelectedValue)
            };

            try
            {
                _employeeService.AddEmployee(empleyeeAdded);
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    MessageBox.Show("nombre de usuario existente, por favor elija otro ", "error");
                }
            }
            finally
            {

                LoadEmployees();
            }
        }

        private void editEmployeeButton_Click(object sender, EventArgs e)
        {
            var employeeEdited = new Employees()
            {
                EmployeeId = Convert.ToInt32(EmployeesDataGridView.CurrentRow.Cells[0].Value.ToString()),
                Names = namesTextBox.Text,
                LastNames = lastNamesTextBox.Text,
                UserEmployee = UserTextBox.Text,
                PasswordEmployee = passwordTextBox.Text,
                DUI = duiTextBox.Text,
                Email = emailTextBox.Text,
                RoleId = Convert.ToInt32(rolesComboBox.SelectedValue)
            };

            try
            {
                _employeeService.EditEmployee(employeeEdited);
            }

            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    MessageBox.Show("nombre de usuario existente, por favor elija otro ", "error");
                }
            }
            finally
            {

                LoadEmployees();
            }
        }

        private void deteleEmployeeButton_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(EmployeesDataGridView.CurrentRow.Cells[0].Value.ToString());
            _employeeService.DeleteEmployee(Id);
            LoadEmployees();
        }
    }
}
