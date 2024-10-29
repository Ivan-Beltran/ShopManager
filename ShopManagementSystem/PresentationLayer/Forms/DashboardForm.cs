﻿using CommonLayer.Entities;
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
    public partial class DashboardForm : Form
    {

        private EmployeeSesion _employeeSesion;

        public DashboardForm(EmployeeSesion employeeSesion)
        {
            InitializeComponent();
            _employeeSesion = employeeSesion;

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


    }
}