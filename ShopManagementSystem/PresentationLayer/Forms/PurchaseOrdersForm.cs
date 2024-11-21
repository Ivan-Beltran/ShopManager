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

        }

        
        public void LoadSuppliers()
        {
            supplierComboBox.DataSource=_purchaseOrderServices.GetSuppliers();
            supplierComboBox.DisplayMember = "Proveedores";
            supplierComboBox.ValueMember = "Id";
        }

        public void LoadPurchaseOrders()
        {
            purchaseOrderDataGridView.DataSource = _purchaseOrderServices.GetPurchaseOrders();
        }
        private void createPurchaseOrderButton_Click(object sender, EventArgs e)
        {
            var purchaseOrder = new PurchaseOrders()
            {
                SupplierId = Convert.ToInt32(supplierComboBox.SelectedValue),
                Details = detailsTextBox.Text,
                PurchaseDate = DateTime.Now,
            };

            int insertAndId= _purchaseOrderServices.AddPurchaseOrder(purchaseOrder);
            LoadPurchaseOrders();

            var shoppingListForm = new ShoppingListForm(insertAndId,_purchaseOrderServices);

            shoppingListForm.ShowDialog();
        }
    }
}
