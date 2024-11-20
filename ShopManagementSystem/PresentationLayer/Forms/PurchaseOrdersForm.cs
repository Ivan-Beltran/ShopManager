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
    public partial class PurchaseOrdersForm : Form
    {
        public PurchaseOrdersForm()
        {
            InitializeComponent();
        }

        private void buyProductsButton_Click(object sender, EventArgs e)
        {
            var shoppingListForm=new ShoppingListForm();

            shoppingListForm.ShowDialog();
        }
    }
}
