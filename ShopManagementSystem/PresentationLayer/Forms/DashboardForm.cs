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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskBand;
using BussinessLayer.Services.ServicesForEmployees;
using FontAwesome.Sharp;
using BussinessLayer.Services.ServicesForInventory;

namespace PresentationLayer.Forms
{
    public partial class DashboardForm : Form
    {

        private Employees _employeeSesion;
        private readonly IEmployeeService _employeeService;
        private readonly IInventoryService _inventoryServies;
        private IconButton lastButton;


        public DashboardForm(Employees employeeSesion,
            IEmployeeService employeeService,
            IInventoryService inventoryServices)
        {
            InitializeComponent();

            _employeeSesion = employeeSesion;
            _employeeService = employeeService;
            _inventoryServies = inventoryServices;
            employeeNameLabel.Text = _employeeSesion.Names;
            this.PrincipalPanel.Resize += (s, e) => AdjustChildFormSize();
            Permissions();
    }

        private void openChildForm(object _childForm)
        {
            // Cierra cualquier formulario existente en el panel
            if (this.PrincipalPanel.Controls.Count > 0)
            {
                this.PrincipalPanel.Controls.RemoveAt(0);
            }

            // Agrega el nuevo formulario como hijo del panel
            Form childForm = _childForm as Form;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.PrincipalPanel.Controls.Add(childForm);
            this.PrincipalPanel.Tag = childForm;
            childForm.Show();

            AdjustChildFormSize();
        }


        private void AdjustChildFormSize()
        {
            if (PrincipalPanel.Controls.Count > 0)
            {
                var childForm = PrincipalPanel.Controls[0] as Form;
                if (childForm != null)
                {
                    childForm.Dock = DockStyle.Fill;
                    childForm.Refresh();
                }
            }
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            openChildForm(new HomeForm());
        }

        private void personalIconButton_Click(object sender, EventArgs e)
        {
            openChildForm(new EmployeesForm(_employeeService, _employeeSesion));
            ChangeButtonColor(employeesButton);

        }

        private void Permissions()
        {
            if (_employeeSesion.RoleId == 2)
            {
                inventoryButton.Enabled = false;
                inventoryButton.Visible = false;
                employeesButton.Enabled = false;
                employeesButton.Visible = false;
                shoppingOrdersButton.Enabled = false;
                shoppingOrdersButton.Visible = false;
            }
        }

        private void shopButton_Click(object sender, EventArgs e)
        {
            openChildForm(new HomeForm());
        }

        private void inventoryButton_Click(object sender, EventArgs e)
        {
            openChildForm(new InventoryForm(_inventoryServies));
            ChangeButtonColor(inventoryButton);
        }

        public void ChangeButtonColor(IconButton button)
        {
            // Si hay un botón previo seleccionado, se le restaura el color original
            if (lastButton != null)
            {
                lastButton.BackColor = Color.White; 
                lastButton.ForeColor = Color.Black;
                lastButton.IconColor = Color.Black;
            }

            // Cambiar el color del botón actual
            button.BackColor = Color.Black;
            button.ForeColor = Color.White;
            button.IconColor = Color.White;

            // Actualizar la referencia del último botón clicado
            lastButton = button;
        }

    }
}
