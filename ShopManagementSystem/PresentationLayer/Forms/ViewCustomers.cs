using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinessLayer.Services.ServicesForSales;

namespace PresentationLayer.Forms
{
    public partial class ViewCustomers : Form
    {
        private ISalesServices _isalesServices;
        public ViewCustomers()
        {
            InitializeComponent();
        }
    }
}
