using CommonLayer.Entities;
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

namespace PresentationLayer.Forms
{
    public partial class DashboardForm : Form
    {

        private Employees _employeeSesion;
        private readonly IEmployeeService employeeService;
        

        public DashboardForm(Employees employeeSesion,IEmployeeService _employeeService)
        {
            InitializeComponent();
            _employeeSesion = employeeSesion;
            employeeNameLabel.Text = _employeeSesion.Names;
            employeeService=_employeeService;
            

        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            PrincipalPanel.Controls.Add(childForm);
            PrincipalPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            openChildForm(new HomeForm());
        }

       
        
        private void personalIconButton_Click(object sender, EventArgs e)
        {
              

              openChildForm(new ViewEmployeesForm(employeeService,_employeeSesion));
        }
    }
}
