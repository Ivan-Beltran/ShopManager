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
            saleDataGridView = new DataGridView();
            addSaleButton = new Button();
            editSaleButton = new Button();
            deleteSaleButton = new Button();
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
            pictureBox2.Location = new Point(-34, -350);
            pictureBox2.Margin = new Padding(4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(2076, 1238);
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
            sidebarPanel.Margin = new Padding(2, 4, 2, 4);
            sidebarPanel.Name = "sidebarPanel";
            sidebarPanel.Size = new Size(1820, 91);
            sidebarPanel.TabIndex = 2;
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.ForeColor = Color.White;
            welcomeLabel.Location = new Point(813, 62);
            welcomeLabel.Margin = new Padding(4, 0, 4, 0);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(99, 25);
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
            inventarioIconButton.Location = new Point(2, 600);
            inventarioIconButton.Margin = new Padding(2, 4, 2, 4);
            inventarioIconButton.Name = "inventarioIconButton";
            inventarioIconButton.Size = new Size(319, 49);
            inventarioIconButton.TabIndex = 4;
            inventarioIconButton.Text = "Inventario";
            inventarioIconButton.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(741, -29);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(237, 116);
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
            PrincipalPanel.Margin = new Padding(4);
            PrincipalPanel.Name = "PrincipalPanel";
            PrincipalPanel.Size = new Size(1820, 580);
            PrincipalPanel.TabIndex = 3;
            // 
            // saleDataGridView
            // 
            saleDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            saleDataGridView.Location = new Point(1028, 98);
            saleDataGridView.Name = "saleDataGridView";
            saleDataGridView.RowHeadersWidth = 62;
            saleDataGridView.Size = new Size(500, 489);
            saleDataGridView.TabIndex = 4;
            // 
            // addSaleButton
            // 
            addSaleButton.Location = new Point(371, 129);
            addSaleButton.Name = "addSaleButton";
            addSaleButton.Size = new Size(353, 65);
            addSaleButton.TabIndex = 5;
            addSaleButton.Text = "Agregar";
            addSaleButton.UseVisualStyleBackColor = true;
            // 
            // editSaleButton
            // 
            editSaleButton.Location = new Point(371, 217);
            editSaleButton.Name = "editSaleButton";
            editSaleButton.Size = new Size(353, 65);
            editSaleButton.TabIndex = 6;
            editSaleButton.Text = "Editar";
            editSaleButton.UseVisualStyleBackColor = true;
            // 
            // deleteSaleButton
            // 
            deleteSaleButton.Location = new Point(371, 313);
            deleteSaleButton.Name = "deleteSaleButton";
            deleteSaleButton.Size = new Size(353, 65);
            deleteSaleButton.TabIndex = 7;
            deleteSaleButton.Text = "Eliminar";
            deleteSaleButton.UseVisualStyleBackColor = true;
            // 
            // SalesForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1820, 580);
            Controls.Add(sidebarPanel);
            Controls.Add(PrincipalPanel);
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