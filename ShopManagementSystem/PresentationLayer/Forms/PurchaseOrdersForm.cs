using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinessLayer.Services.ServicersForPurchaseOrders;
using CommonLayer.Entities;
using Microsoft.Data.SqlClient;

namespace PresentationLayer.Forms
{
    public partial class PurchaseOrdersForm : Form
    {
        private IPurchaseOrdersServices _purchaseOrderServices;
        public PurchaseOrdersForm(IPurchaseOrdersServices purchaseOrders)
        {
            _purchaseOrderServices = purchaseOrders;
            InitializeComponent();
            LoadSuppliers();
            LoadPurchaseOrders();
            supplierComboBox.Click += (s, e) => purchaseOrdersErrorProvider.SetError(supplierComboBox, "");
            detailsTextBox.TextChanged += (e, s) => purchaseOrdersErrorProvider.SetError(detailsTextBox, "");

        }


        public void LoadSuppliers()
        {
            supplierComboBox.DataSource = _purchaseOrderServices.GetSuppliers();
            supplierComboBox.DisplayMember = "Proveedores";
            supplierComboBox.ValueMember = "Id";
            supplierComboBox.SelectedIndex = -1;
        }

        public void LoadPurchaseOrders()
        {
            purchaseOrderDataGridView.DataSource = _purchaseOrderServices.GetPurchaseOrders();
        }
        private void createPurchaseOrderButton_Click(object sender, EventArgs e)
        {
            if (supplierComboBox.SelectedIndex < 0 && string.IsNullOrWhiteSpace(detailsTextBox.Text))
            {
                purchaseOrdersErrorProvider.SetError(supplierComboBox, "seleccione un proveedor");
                purchaseOrdersErrorProvider.SetError(detailsTextBox, "es necesario agregar un detalle descriptivo");
            }
            else if (supplierComboBox.SelectedIndex < 0)
            {
                purchaseOrdersErrorProvider.SetError(supplierComboBox, "seleccione un proveedor");
            }
            else if (string.IsNullOrWhiteSpace(detailsTextBox.Text))
            {
                purchaseOrdersErrorProvider.SetError(detailsTextBox, "es necesario agregar un detalle descriptivo");
            }

            else
            {

                var purchaseOrder = new PurchaseOrders()
                {
                    SupplierId = Convert.ToInt32(supplierComboBox.SelectedValue),
                    Details = detailsTextBox.Text,
                    PurchaseDate = DateTime.Now,
                };

                int insertAndId = _purchaseOrderServices.AddPurchaseOrder(purchaseOrder);
                LoadPurchaseOrders();

                var shoppingListForm = new ShoppingListForm(insertAndId, _purchaseOrderServices);
                shoppingListForm.FormClosed += (s, e) => LoadPurchaseOrders();
                shoppingListForm.ShowDialog();

            }

        }

        private void deletePurchaseOrderButton_Click(object sender, EventArgs e)
        {
            if (purchaseOrderDataGridView.SelectedRows.Count > 0)
            {
                int selectedOrderId = Convert.ToInt32(purchaseOrderDataGridView.CurrentRow.Cells[0].Value);
                var confirmResult = MessageBox.Show(
                    "¿ Esta segur0 de eliminar esta orden? Si elimina esta orden de compra se eliminaran los productos relacionados",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {

                    try
                     {

                        _purchaseOrderServices.DeletePurchaseOrder(selectedOrderId);
                        MessageBox.Show("Orden de compra eliminada correctamente.");
                        LoadPurchaseOrders();
                     }
                     catch (SqlException ex) when (ex.Number == 547) 
                     {
                         MessageBox.Show("No se puede eliminar la orden de compra porque tiene elementos relacionados en la lista de compras.",
                                         "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     }
                }

            }
        }
    }
}
