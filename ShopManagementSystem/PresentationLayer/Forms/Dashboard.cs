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

namespace PresentationLayer.Forms
{
    public partial class Dashboard : Form
    {
  
        private EmployeeSesion _employeeSesion;

        public Dashboard(EmployeeSesion employeeSesion)
        {
            InitializeComponent();
            _employeeSesion = employeeSesion;
            loadData();
        }

        public void loadData()
        {
            textBox1.Text=_employeeSesion.EmployeeNames;
            textBox2.Text = _employeeSesion.EmployeeUser;
            textBox3.Text = _employeeSesion.EmployeeDUI;
            if (_employeeSesion.EmployeeRoleId == 1)
            {
                textBox4.Text = "gerente";
            }

        }
    }
}
