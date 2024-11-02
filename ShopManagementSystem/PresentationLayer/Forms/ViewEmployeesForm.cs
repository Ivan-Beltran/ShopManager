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
    public partial class ViewEmployeesForm : Form
    {
        private readonly IEmployeeService _employeeService;
        public ViewEmployeesForm(IEmployeeService employeeService)
        {
            InitializeComponent();
            _employeeService = employeeService;
            LoadEmployees();
           
        }

        public void LoadEmployees()
        {
           EmployeesDataGridView.DataSource= _employeeService.GetEmployees();
            
        }
        
    }
}
