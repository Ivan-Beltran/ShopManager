using BussinessLayer.Services.ServicesForSuppliers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.Forms
{
    public partial class CatalogForm : Form
    {
        public CatalogForm()
        {
            InitializeComponent();
        }

        public CatalogForm(ISuppliersServices suppliersServices)
        {
            SuppliersServices = suppliersServices;
        }

        public ISuppliersServices SuppliersServices { get; }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logica buscador");
        }

        private void shoppingcart_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logica Carrito");
        }
    }
}
