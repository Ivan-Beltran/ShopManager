using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BussinessLayer.Services.ServicesForClients;

namespace PresentationLayer.Forms
{
    public partial class ViewCustomers : Form
    {
        private IClientsServices _clientsServices;
        public ViewCustomers(IClientsServices clientsServices)
        {
            InitializeComponent();
            _clientsServices = clientsServices;
            LoadClients();
            viewCustomersDataGridView.Columns[0].Visible = false;
        }

        public void LoadClients()
        {
            viewCustomersDataGridView.DataSource=_clientsServices.GetClients();
        }
    }
}
