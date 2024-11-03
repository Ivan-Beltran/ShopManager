namespace PresentationLayer.Forms
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
            pictureBox2 = new PictureBox();
            sidebarPanel = new Panel();
            welcomeLabel = new Label();
            inventarioIconButton = new FontAwesome.Sharp.IconButton();
            pictureBox1 = new PictureBox();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            PrincipalPanel = new Panel();
            deleteSaleButton = new Button();
            editSaleButton = new Button();
            addSaleButton = new Button();
            saleDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            sidebarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            PrincipalPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)saleDataGridView).BeginInit();
            SuspendLayout();
            // 
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
            // sidebarPanel
            // 
            sidebarPanel.BackColor = Color.FromArgb(0, 166, 225);
            sidebarPanel.Controls.Add(welcomeLabel);
            sidebarPanel.Controls.Add(inventarioIconButton);
            sidebarPanel.Controls.Add(pictureBox1);
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
            welcomeLabel.ForeColor = Color.White;
            welcomeLabel.Location = new Point(608, 40);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(83, 20);
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
            // pictureBox1
            // 
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
            // 
            // PrincipalPanel
            // 
            PrincipalPanel.Controls.Add(deleteSaleButton);
            PrincipalPanel.Controls.Add(editSaleButton);
            PrincipalPanel.Controls.Add(addSaleButton);
            PrincipalPanel.Controls.Add(saleDataGridView);
            PrincipalPanel.Controls.Add(pictureBox2);
            PrincipalPanel.Dock = DockStyle.Fill;
            PrincipalPanel.Location = new Point(0, 0);
            PrincipalPanel.Name = "PrincipalPanel";
            PrincipalPanel.Size = new Size(1456, 464);
            PrincipalPanel.TabIndex = 3;
            // 
            // deleteSaleButton
            // 
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
            // 
            // saleDataGridView
            // 
            saleDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            saleDataGridView.Location = new Point(822, 78);
            saleDataGridView.Margin = new Padding(2, 2, 2, 2);
            saleDataGridView.Name = "saleDataGridView";
            saleDataGridView.RowHeadersWidth = 62;
            saleDataGridView.Size = new Size(400, 391);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            sidebarPanel.ResumeLayout(false);
            sidebarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            PrincipalPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)saleDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox2;
        private Panel sidebarPanel;
        private Label welcomeLabel;
        private FontAwesome.Sharp.IconButton inventarioIconButton;
        private PictureBox pictureBox1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Panel PrincipalPanel;
        private DataGridView saleDataGridView;
        private Button deleteSaleButton;
        private Button editSaleButton;
        private Button addSaleButton;
    }
}