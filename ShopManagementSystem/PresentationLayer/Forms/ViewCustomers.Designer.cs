﻿namespace PresentationLayer.Forms
{
    partial class ViewCustomers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            viewCustomersDataGridView = new DataGridView();
            registerClientsLabel = new Label();
            TittlePanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)viewCustomersDataGridView).BeginInit();
            TittlePanel.SuspendLayout();
            SuspendLayout();
            // 
            // viewCustomersDataGridView
            // 
            viewCustomersDataGridView.AllowUserToDeleteRows = false;
            viewCustomersDataGridView.AllowUserToResizeColumns = false;
            viewCustomersDataGridView.AllowUserToResizeRows = false;
            viewCustomersDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            viewCustomersDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            viewCustomersDataGridView.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            viewCustomersDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            viewCustomersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            viewCustomersDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            viewCustomersDataGridView.Location = new Point(111, 154);
            viewCustomersDataGridView.Margin = new Padding(3, 4, 3, 4);
            viewCustomersDataGridView.Name = "viewCustomersDataGridView";
            viewCustomersDataGridView.RowHeadersVisible = false;
            viewCustomersDataGridView.RowHeadersWidth = 51;
            viewCustomersDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            viewCustomersDataGridView.Size = new Size(1221, 603);
            viewCustomersDataGridView.TabIndex = 0;
            // 
            // registerClientsLabel
            // 
            registerClientsLabel.AutoSize = true;
            registerClientsLabel.Font = new Font("Segoe UI Black", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            registerClientsLabel.ForeColor = Color.White;
            registerClientsLabel.Location = new Point(520, 9);
            registerClientsLabel.Name = "registerClientsLabel";
            registerClientsLabel.Size = new Size(496, 62);
            registerClientsLabel.TabIndex = 1;
            registerClientsLabel.Text = "Clientes Registrados";
            // 
            // TittlePanel
            // 
            TittlePanel.BackColor = Color.FromArgb(0, 166, 225);
            TittlePanel.Controls.Add(registerClientsLabel);
            TittlePanel.Dock = DockStyle.Top;
            TittlePanel.Location = new Point(0, 0);
            TittlePanel.Margin = new Padding(0);
            TittlePanel.Name = "TittlePanel";
            TittlePanel.Size = new Size(1332, 85);
            TittlePanel.TabIndex = 26;
            // 
            // ViewCustomers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1332, 889);
            Controls.Add(TittlePanel);
            Controls.Add(viewCustomersDataGridView);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ViewCustomers";
            Text = "ViewCustomers";
            ((System.ComponentModel.ISupportInitialize)viewCustomersDataGridView).EndInit();
            TittlePanel.ResumeLayout(false);
            TittlePanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView viewCustomersDataGridView;
        private Label registerClientsLabel;
        private Panel TittlePanel;
    }
}