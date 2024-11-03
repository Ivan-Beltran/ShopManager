﻿namespace PresentationLayer.Forms
{
    partial class SalesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesForm));
            sidebarPanel = new Panel();
            welcomeLabel = new Label();
            inventarioIconButton = new FontAwesome.Sharp.IconButton();
            salesPictureBox = new PictureBox();
            PrincipalPanel = new Panel();
            deleteSaleButton = new Button();
            editSaleButton = new Button();
            addSaleButton = new Button();
            saleDataGridView = new DataGridView();
<<<<<<< HEAD
=======
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
>>>>>>> 1f4d60de9e59f82bc672b3b16d7ee7322c4366b9
            sidebarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)salesPictureBox).BeginInit();
            PrincipalPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)saleDataGridView).BeginInit();
            SuspendLayout();
            // 
<<<<<<< HEAD
=======
            // pictureBox2
            // 
            pictureBox2.Enabled = false;
            pictureBox2.Location = new Point(-27, -280);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1661, 990);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
>>>>>>> 1f4d60de9e59f82bc672b3b16d7ee7322c4366b9
            // sidebarPanel
            // 
            sidebarPanel.BackColor = Color.FromArgb(0, 166, 225);
            sidebarPanel.Controls.Add(welcomeLabel);
            sidebarPanel.Controls.Add(inventarioIconButton);
            sidebarPanel.Controls.Add(salesPictureBox);
            sidebarPanel.Dock = DockStyle.Top;
            sidebarPanel.Location = new Point(0, 0);
            sidebarPanel.Margin = new Padding(2, 3, 2, 3);
            sidebarPanel.Name = "sidebarPanel";
            sidebarPanel.Size = new Size(1456, 73);
            sidebarPanel.TabIndex = 2;
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            welcomeLabel.ForeColor = Color.White;
<<<<<<< HEAD
            welcomeLabel.Location = new Point(782, 49);
            welcomeLabel.Margin = new Padding(4, 0, 4, 0);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(164, 38);
=======
            welcomeLabel.Location = new Point(608, 40);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(83, 20);
>>>>>>> 1f4d60de9e59f82bc672b3b16d7ee7322c4366b9
            welcomeLabel.TabIndex = 0;
            welcomeLabel.Text = "Bienvenido";
            // 
            // inventarioIconButton
            // 
            inventarioIconButton.BackColor = Color.White;
            inventarioIconButton.FlatAppearance.BorderSize = 0;
            inventarioIconButton.FlatStyle = FlatStyle.Flat;
            inventarioIconButton.Font = new Font("Segoe UI Historic", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            inventarioIconButton.ForeColor = SystemColors.ActiveCaptionText;
            inventarioIconButton.IconChar = FontAwesome.Sharp.IconChar.Newspaper;
            inventarioIconButton.IconColor = Color.Black;
            inventarioIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            inventarioIconButton.IconSize = 32;
            inventarioIconButton.ImageAlign = ContentAlignment.MiddleLeft;
            inventarioIconButton.Location = new Point(2, 480);
            inventarioIconButton.Margin = new Padding(2, 3, 2, 3);
            inventarioIconButton.Name = "inventarioIconButton";
            inventarioIconButton.Size = new Size(255, 39);
            inventarioIconButton.TabIndex = 4;
            inventarioIconButton.Text = "Inventario";
            inventarioIconButton.UseVisualStyleBackColor = false;
            // 
            // salesPictureBox
            // 
<<<<<<< HEAD
            salesPictureBox.BackColor = Color.Transparent;
            salesPictureBox.Image = (Image)resources.GetObject("salesPictureBox.Image");
            salesPictureBox.Location = new Point(741, -29);
            salesPictureBox.Margin = new Padding(4);
            salesPictureBox.Name = "salesPictureBox";
            salesPictureBox.Size = new Size(237, 116);
            salesPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            salesPictureBox.TabIndex = 0;
            salesPictureBox.TabStop = false;
=======
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(593, -23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 93);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
>>>>>>> 1f4d60de9e59f82bc672b3b16d7ee7322c4366b9
            // 
            // PrincipalPanel
            // 
            PrincipalPanel.Controls.Add(deleteSaleButton);
            PrincipalPanel.Controls.Add(editSaleButton);
            PrincipalPanel.Controls.Add(addSaleButton);
            PrincipalPanel.Controls.Add(saleDataGridView);
            PrincipalPanel.Dock = DockStyle.Fill;
            PrincipalPanel.Location = new Point(0, 0);
            PrincipalPanel.Name = "PrincipalPanel";
            PrincipalPanel.Size = new Size(1456, 464);
            PrincipalPanel.TabIndex = 3;
            // 
            // deleteSaleButton
            // 
<<<<<<< HEAD
            deleteSaleButton.BackColor = Color.FromArgb(0, 166, 225);
            deleteSaleButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            deleteSaleButton.Location = new Point(442, 419);
            deleteSaleButton.Name = "deleteSaleButton";
            deleteSaleButton.Size = new Size(353, 65);
            deleteSaleButton.TabIndex = 7;
            deleteSaleButton.Text = "Eliminar";
            deleteSaleButton.UseVisualStyleBackColor = false;
            // 
            // editSaleButton
            // 
            editSaleButton.BackColor = Color.FromArgb(0, 166, 225);
            editSaleButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            editSaleButton.Location = new Point(442, 323);
            editSaleButton.Name = "editSaleButton";
            editSaleButton.Size = new Size(353, 65);
            editSaleButton.TabIndex = 6;
            editSaleButton.Text = "Editar";
            editSaleButton.UseVisualStyleBackColor = false;
            // 
            // addSaleButton
            // 
            addSaleButton.BackColor = Color.FromArgb(0, 166, 225);
            addSaleButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            addSaleButton.Location = new Point(442, 235);
            addSaleButton.Name = "addSaleButton";
            addSaleButton.Size = new Size(353, 65);
            addSaleButton.TabIndex = 5;
            addSaleButton.Text = "Agregar";
            addSaleButton.UseVisualStyleBackColor = false;
=======
            deleteSaleButton.Location = new Point(297, 250);
            deleteSaleButton.Margin = new Padding(2, 2, 2, 2);
            deleteSaleButton.Name = "deleteSaleButton";
            deleteSaleButton.Size = new Size(282, 52);
            deleteSaleButton.TabIndex = 7;
            deleteSaleButton.Text = "Eliminar";
            deleteSaleButton.UseVisualStyleBackColor = true;
            // 
            // editSaleButton
            // 
            editSaleButton.Location = new Point(297, 174);
            editSaleButton.Margin = new Padding(2, 2, 2, 2);
            editSaleButton.Name = "editSaleButton";
            editSaleButton.Size = new Size(282, 52);
            editSaleButton.TabIndex = 6;
            editSaleButton.Text = "Editar";
            editSaleButton.UseVisualStyleBackColor = true;
            // 
            // addSaleButton
            // 
            addSaleButton.Location = new Point(297, 103);
            addSaleButton.Margin = new Padding(2, 2, 2, 2);
            addSaleButton.Name = "addSaleButton";
            addSaleButton.Size = new Size(282, 52);
            addSaleButton.TabIndex = 5;
            addSaleButton.Text = "Agregar";
            addSaleButton.UseVisualStyleBackColor = true;
>>>>>>> 1f4d60de9e59f82bc672b3b16d7ee7322c4366b9
            // 
            // saleDataGridView
            // 
            saleDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
<<<<<<< HEAD
            saleDataGridView.Location = new Point(1028, 98);
            saleDataGridView.Name = "saleDataGridView";
            saleDataGridView.RowHeadersWidth = 62;
            saleDataGridView.Size = new Size(616, 489);
=======
            saleDataGridView.Location = new Point(822, 78);
            saleDataGridView.Margin = new Padding(2, 2, 2, 2);
            saleDataGridView.Name = "saleDataGridView";
            saleDataGridView.RowHeadersWidth = 62;
            saleDataGridView.Size = new Size(400, 391);
>>>>>>> 1f4d60de9e59f82bc672b3b16d7ee7322c4366b9
            saleDataGridView.TabIndex = 4;
            // 
            // SalesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1456, 464);
            Controls.Add(sidebarPanel);
            Controls.Add(PrincipalPanel);
            Margin = new Padding(2, 2, 2, 2);
            Name = "SalesForm";
            Text = "SaleForm";
            sidebarPanel.ResumeLayout(false);
            sidebarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)salesPictureBox).EndInit();
            PrincipalPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)saleDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel sidebarPanel;
        private Label welcomeLabel;
        private FontAwesome.Sharp.IconButton inventarioIconButton;
        private PictureBox salesPictureBox;
        private Panel PrincipalPanel;
        private DataGridView saleDataGridView;
        private Button deleteSaleButton;
        private Button editSaleButton;
        private Button addSaleButton;
    }
}