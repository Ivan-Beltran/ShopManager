using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommonLayer.Entities;
using BussinessLayer.Services.ServicesForSuppliers;

namespace PresentationLayer.Forms
{
    public partial class RegisterSuppliersForm : Form
    {
        private ISuppliersServices _supplierServices;
        public RegisterSuppliersForm(ISuppliersServices supplierServices)
        {
            InitializeComponent();
            _supplierServices = supplierServices;
            LoadSuppliers();
            this.Shown += (s, e) => SupplierDataGridView.ClearSelection();
            ClearParameters();
        }

        public void LoadSuppliers()
        {
            SupplierDataGridView.DataSource = _supplierServices.GetAllSuppliers();
        }

        private void registerSupplierButton_Click(object sender, EventArgs e)
        {

            if(SupplierDataGridView.SelectedRows.Count > 0 )
            {
                MessageBox.Show("no se puede agregar mientras una fila este seleccionada",
                   "Advertencia",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
            }
            else
            {
                var supplier = new Suppliers()
                {
                    SupplierName = nameSupplierTextBox.Text,
                    SupplierPhone = phoneSupplierTextBox.Text,
                    SupplierEmail = emailSupplierTextBox.Text,
                    SupplierAddres = addressSupplierTextBox.Text,
                };

                _supplierServices.AddSupplier(supplier);
                LoadSuppliers();
                this.Shown += (s, e) => SupplierDataGridView.ClearSelection();
                ClearParameters();
            }

        }

        private void editSupplierButton_Click(object sender, EventArgs e)
        {

            if (SupplierDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona una fila para editar.",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {

                var supplier = new Suppliers()
                {
                    SupplierId = Convert.ToInt32(SupplierDataGridView.CurrentRow.Cells[0].Value.ToString()),
                    SupplierName = nameSupplierTextBox.Text,
                    SupplierPhone = phoneSupplierTextBox.Text,
                    SupplierEmail = emailSupplierTextBox.Text,
                    SupplierAddres = addressSupplierTextBox.Text
                };

                _supplierServices.EditSupplier(supplier);
                LoadSuppliers();
                this.Shown += (s, e) => SupplierDataGridView.ClearSelection();
                ClearParameters();
            }
        }

        private void deleteSupplierButton_Click(object sender, EventArgs e)
        {
            if (SupplierDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un proveedor a eliminar",
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
                    int Id = Convert.ToInt32(SupplierDataGridView.CurrentRow.Cells[0].Value.ToString());

                    _supplierServices.DeleteSupplier(Id);
                    LoadSuppliers();
                    this.Shown += (s, e) => SupplierDataGridView.ClearSelection();
                    ClearParameters();


                }
            }
        }

        private void SupplierDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            ClearParameters();
            if (SupplierDataGridView.SelectedRows.Count > 0)
            {
                nameSupplierTextBox.Text = SupplierDataGridView.CurrentRow.Cells[1].Value.ToString();
                phoneSupplierTextBox.Text = SupplierDataGridView.CurrentRow.Cells[2].Value.ToString();
                emailSupplierTextBox.Text = SupplierDataGridView.CurrentRow.Cells[3].Value.ToString();
                addressSupplierTextBox.Text = SupplierDataGridView.CurrentRow.Cells[4].Value.ToString();

            }
        }

        private void clearRowButton_Click(object sender, EventArgs e)
        {
            if (SupplierDataGridView.Rows.Count > 0)
            {

                this.Shown += (s, e) => SupplierDataGridView.ClearSelection();
                SupplierDataGridView.ClearSelection();
                ClearParameters();
            }
            else
            {
                MessageBox.Show("ninguna fila seleccionada",
                            "informacion",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
            }
        }

        public void ClearParameters()
        {
            nameSupplierTextBox.Text = "";
            phoneSupplierTextBox.Text = "";
            emailSupplierTextBox.Text = "";
            addressSupplierTextBox.Text = "";
        }
    }
}
