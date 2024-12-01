using BussinessLayer.Services.ServicesForEmployees;
using CommonLayer.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using PresentationLayer.Validations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using FluentValidation;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FluentValidation.Results;
using System.Security.Cryptography;

namespace PresentationLayer.Forms
{
    public partial class EmployeesForm : Form
    {
        private readonly IEmployeeService _employeeService;
        private Employees _employeeSession;
    
        public EmployeesForm(IEmployeeService employeeService, Employees employeeSession)
        {
            InitializeComponent();
            _employeeService = employeeService;
            _employeeSession = employeeSession;
            LoadEmployees();
            LoadRoles();
            this.Shown += (s, e) => EmployeesDataGridView.ClearSelection();
        }

        public void LoadEmployees()
        {
           
            EmployeesDataGridView.DataSource = _employeeService.GetEmployees();
            EmployeesDataGridView.Columns["ID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            

            foreach (DataGridViewRow row in EmployeesDataGridView.Rows)
            {
                if (row.Cells["Contraseña"].Value != null)
                {
                    row.Cells["Contraseña"].Value = "********"; // Reemplaza por asteriscos
                }
            }


            foreach (DataGridViewColumn column in EmployeesDataGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        

        public void LoadRoles()
        {
            rolesComboBox.DataSource = _employeeService.GetRoles();
            rolesComboBox.DisplayMember = "Cargos";
            rolesComboBox.ValueMember = "RoleId";
            rolesComboBox.SelectedIndex = -1;
        }

        //metodos con la funciones de cada boton

        private void addEmployeeButton_Click(object sender, EventArgs e)
        {

            Employees employeeAdded = new Employees()
            {
                Names = namesTextBox.Text,
                LastNames = lastNamesTextBox.Text,
                UserEmployee = UserTextBox.Text,
                PasswordEmployee = passwordTextBox.Text,
                DUI = duiTextBox.Text,
                Email = emailTextBox.Text,
                RoleId = Convert.ToInt32(rolesComboBox.SelectedValue)
            };
            if (EmployeesDataGridView.SelectedRows.Count > 0)
            {
                MessageBox.Show("no se puede agregar mientras una fila esta seleccionada");
            }
            else
            {

                try
                {
                    EmployeesValidator employeesValidator = new EmployeesValidator();
                    ValidationResult result= employeesValidator.Validate(employeeAdded);
                    if (!result.IsValid)
                    {
                        DisplayValidationErrors(result);
                        return;
                    }

                    _employeeService.AddEmployee(employeeAdded);
                    MessageBox.Show("Empleado agregado exitosamente", "Mensaje");
                    LoadEmployees();
                    this.Shown += (s, e) => EmployeesDataGridView.ClearSelection();
 

                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627)
                    {
                        MessageBox.Show("Ya hay un usuario que ocupa el mismo username,correo o DUI",
                            "error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void DisplayValidationErrors(ValidationResult result)
        {
            validationErrorProvider.Clear();

            foreach (var error in result.Errors)
            {
                switch (error.PropertyName)
                {
                    case nameof(Employees.Names):
                        validationErrorProvider.SetError(namesTextBox, error.ErrorMessage);
                        break;
                    case nameof(Employees.LastNames):
                        validationErrorProvider.SetError(lastNamesTextBox, error.ErrorMessage);
                        break;
                    case nameof(Employees.UserEmployee):
                        validationErrorProvider.SetError(UserTextBox, error.ErrorMessage);
                        break;
                    case nameof(Employees.PasswordEmployee):
                               validationErrorProvider.SetError(passwordTextBox, error.ErrorMessage);
                        break;
                    case nameof(Employees.Email):
                        validationErrorProvider.SetError(emailTextBox, error.ErrorMessage);
                        break;
                    case nameof(Employees.DUI):
                        validationErrorProvider.SetError(duiTextBox, error.ErrorMessage);
                        break;
                    case nameof(Employees.RoleId):
                        validationErrorProvider.SetError(rolesComboBox, error.ErrorMessage);
                        break;



                }
            }

        }
            private void editEmployeeButton_Click(object sender, EventArgs e)
        {
            if (EmployeesDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona una fila para editar.",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
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
                EmployeesValidator employeesValidator = new EmployeesValidator();
                ValidationResult result = employeesValidator.Validate(employeeEdited);
                if (!result.IsValid)
                {
                    DisplayValidationErrors(result);
                    return;
                }
                try
                {
                    _employeeService.EditEmployee(employeeEdited);
                    LoadEmployees();
                    this.Shown += (s, e) => EmployeesDataGridView.ClearSelection();
                    ClearParameters();

                }

                catch (SqlException ex)
                {
                    if (ex.Number == 2627)
                    {
                        MessageBox.Show("Ya hay un usuario que ocupa el mismo username,correo o DUI",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
                
            }
        }

        private void deteleEmployeeButton_Click(object sender, EventArgs e)
        {
            if (EmployeesDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un empleado a eliminar",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("¿Está seguro de eliminar este dato?",
                    "Warning",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    int Id = Convert.ToInt32(EmployeesDataGridView.CurrentRow.Cells[0].Value.ToString());
                    if (_employeeSession.EmployeeId == Id)
                    {
                        MessageBox.Show("No puede eliminar su propio usuario",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    else
                    {
                        _employeeService.DeleteEmployee(Id);
                        LoadEmployees();
                        this.Shown += (s, e) => EmployeesDataGridView.ClearSelection();
                        ClearParameters();
                    }
                }
            }
        }

        private void searchEmployeeButton_Click(object sender, EventArgs e)
        {
            if (searchEmployeeTextBox.Text.IsNullOrEmpty())
            {
                LoadEmployees();
                this.Shown += (s, e) => EmployeesDataGridView.ClearSelection();
                EmployeesDataGridView.ClearSelection();
                ClearParameters();
            }
            else
            {
                string search = searchEmployeeTextBox.Text;
                EmployeesDataGridView.DataSource = _employeeService.SearchEmployee(search);
                if (EmployeesDataGridView.Rows.Count == 0)
                {
                    EmployeesDataGridView.Visible=false;
                    noFoundPictureBox.Visible = true;
                }
                this.Shown += (s, e) => EmployeesDataGridView.ClearSelection();
                EmployeesDataGridView.ClearSelection();
                ClearParameters();


            }
        }

        private void searchEmployeeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchEmployeeTextBox.Text))
            {

                LoadEmployees();
                noFoundPictureBox.Visible = false;
                EmployeesDataGridView.Visible = true;
                this.Shown += (s, e) => EmployeesDataGridView.ClearSelection();
                EmployeesDataGridView.ClearSelection();
                ClearParameters();
            }
        }

        private void clearRowButton_Click(object sender, EventArgs e)
        {
            if (EmployeesDataGridView.Rows.Count > 0)
            {

                this.Shown += (s, e) => EmployeesDataGridView.ClearSelection();
                EmployeesDataGridView.ClearSelection();
                ClearParameters();
            }
            else
            {
                MessageBox.Show("Ninguna fila seleccionada",
                            "Informacion",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
            }
        }

        private void ClearParameters()
        {
            namesTextBox.Text = "";
            lastNamesTextBox.Text = "";
            UserTextBox.Text = "";
            passwordTextBox.Text = "";
            emailTextBox.Text = "";
            duiTextBox.Text = "";
            rolesComboBox.SelectedIndex = -1;
        }

        private void EmployeesDataGridView_SelectionChanged_1(object sender, EventArgs e)
        {
            ClearParameters();
            if (EmployeesDataGridView.SelectedRows.Count > 0)
            {
                int EmployeeId = Convert.ToInt32(EmployeesDataGridView.CurrentRow.Cells[0].Value);

                namesTextBox.Text = EmployeesDataGridView.CurrentRow.Cells[1].Value.ToString();
                lastNamesTextBox.Text = EmployeesDataGridView.CurrentRow.Cells[2].Value.ToString();
                UserTextBox.Text = EmployeesDataGridView.CurrentRow.Cells[3].Value.ToString();
                passwordTextBox.Text = _employeeService.GetEmployeePassword(EmployeeId);
                duiTextBox.Text = EmployeesDataGridView.CurrentRow.Cells[5].Value.ToString();
                emailTextBox.Text = EmployeesDataGridView.CurrentRow.Cells[6].Value.ToString();
                rolesComboBox.Text = EmployeesDataGridView.CurrentRow.Cells[7].Value.ToString();
               
               
            }
        }

        
    }
}
