namespace PresentationLayer.Forms
{
    partial class DashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            sidebarPanel = new Panel();
            dashBoardFlowLayoutPanel = new FlowLayoutPanel();
            CatalogButton = new FontAwesome.Sharp.IconButton();
            employeesButton = new FontAwesome.Sharp.IconButton();
            clientsButton = new FontAwesome.Sharp.IconButton();
            suppliersButton = new FontAwesome.Sharp.IconButton();
            createProductsButton = new FontAwesome.Sharp.IconButton();
            shoppingOrdersButton = new FontAwesome.Sharp.IconButton();
            inventoryButton = new FontAwesome.Sharp.IconButton();
            salesReportButton = new FontAwesome.Sharp.IconButton();
            exitSesionButton = new FontAwesome.Sharp.IconButton();
            employeeNameLabel = new Label();
            welcomeLabel = new Label();
            logoPictureBox = new PictureBox();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            PrincipalPanel = new Panel();
            pictureBox1 = new PictureBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            sidebarPanel.SuspendLayout();
            dashBoardFlowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).BeginInit();
            PrincipalPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // sidebarPanel
            // 
            sidebarPanel.BackColor = Color.FromArgb(0, 166, 225);
            sidebarPanel.Controls.Add(dashBoardFlowLayoutPanel);
            sidebarPanel.Controls.Add(exitSesionButton);
            sidebarPanel.Controls.Add(employeeNameLabel);
            sidebarPanel.Controls.Add(welcomeLabel);
            sidebarPanel.Controls.Add(logoPictureBox);
            sidebarPanel.Dock = DockStyle.Left;
            sidebarPanel.Location = new Point(0, 0);
            sidebarPanel.Margin = new Padding(1, 2, 1, 2);
            sidebarPanel.Name = "sidebarPanel";
            sidebarPanel.Size = new Size(252, 791);
            sidebarPanel.TabIndex = 0;
            // 
            // dashBoardFlowLayoutPanel
            // 
            dashBoardFlowLayoutPanel.Controls.Add(CatalogButton);
            dashBoardFlowLayoutPanel.Controls.Add(employeesButton);
            dashBoardFlowLayoutPanel.Controls.Add(clientsButton);
            dashBoardFlowLayoutPanel.Controls.Add(suppliersButton);
            dashBoardFlowLayoutPanel.Controls.Add(createProductsButton);
            dashBoardFlowLayoutPanel.Controls.Add(shoppingOrdersButton);
            dashBoardFlowLayoutPanel.Controls.Add(inventoryButton);
            dashBoardFlowLayoutPanel.Controls.Add(salesReportButton);
            dashBoardFlowLayoutPanel.Location = new Point(6, 238);
            dashBoardFlowLayoutPanel.Name = "dashBoardFlowLayoutPanel";
            dashBoardFlowLayoutPanel.Size = new Size(242, 292);
            dashBoardFlowLayoutPanel.TabIndex = 7;
            // 
            // CatalogButton
            // 
            CatalogButton.BackColor = Color.White;
            CatalogButton.FlatAppearance.BorderSize = 0;
            CatalogButton.FlatStyle = FlatStyle.Flat;
            CatalogButton.Font = new Font("Segoe UI Historic", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CatalogButton.ForeColor = SystemColors.ActiveCaptionText;
            CatalogButton.IconChar = FontAwesome.Sharp.IconChar.ListDots;
            CatalogButton.IconColor = Color.Black;
            CatalogButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            CatalogButton.IconSize = 32;
            CatalogButton.ImageAlign = ContentAlignment.MiddleLeft;
            CatalogButton.Location = new Point(1, 2);
            CatalogButton.Margin = new Padding(1, 2, 1, 2);
            CatalogButton.Name = "CatalogButton";
            CatalogButton.Size = new Size(256, 31);
            CatalogButton.TabIndex = 9;
            CatalogButton.Text = "Catalogo";
            CatalogButton.UseVisualStyleBackColor = false;
            CatalogButton.Click += CatalogButton_Click;
            // 
            // employeesButton
            // 
            employeesButton.BackColor = Color.White;
            employeesButton.FlatAppearance.BorderSize = 0;
            employeesButton.FlatStyle = FlatStyle.Flat;
            employeesButton.Font = new Font("Segoe UI Historic", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            employeesButton.ForeColor = SystemColors.ActiveCaptionText;
            employeesButton.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            employeesButton.IconColor = Color.Black;
            employeesButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            employeesButton.IconSize = 32;
            employeesButton.ImageAlign = ContentAlignment.MiddleLeft;
            employeesButton.Location = new Point(1, 37);
            employeesButton.Margin = new Padding(1, 2, 1, 2);
            employeesButton.Name = "employeesButton";
            employeesButton.Size = new Size(242, 31);
            employeesButton.TabIndex = 10;
            employeesButton.Text = "Personal";
            employeesButton.UseVisualStyleBackColor = false;
            employeesButton.Click += personalIconButton_Click;
            // 
            // clientsButton
            // 
            clientsButton.BackColor = Color.White;
            clientsButton.FlatAppearance.BorderSize = 0;
            clientsButton.FlatStyle = FlatStyle.Flat;
            clientsButton.Font = new Font("Segoe UI Historic", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clientsButton.ForeColor = SystemColors.ActiveCaptionText;
            clientsButton.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            clientsButton.IconColor = Color.Black;
            clientsButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            clientsButton.IconSize = 32;
            clientsButton.ImageAlign = ContentAlignment.MiddleLeft;
            clientsButton.Location = new Point(1, 72);
            clientsButton.Margin = new Padding(1, 2, 1, 2);
            clientsButton.Name = "clientsButton";
            clientsButton.Size = new Size(242, 31);
            clientsButton.TabIndex = 16;
            clientsButton.Text = "Clientes";
            clientsButton.UseVisualStyleBackColor = false;
            clientsButton.Click += clientsButton_Click;
            // 
            // suppliersButton
            // 
            suppliersButton.BackColor = Color.White;
            suppliersButton.FlatAppearance.BorderSize = 0;
            suppliersButton.FlatStyle = FlatStyle.Flat;
            suppliersButton.Font = new Font("Segoe UI Historic", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            suppliersButton.ForeColor = SystemColors.ActiveCaptionText;
            suppliersButton.IconChar = FontAwesome.Sharp.IconChar.Truck;
            suppliersButton.IconColor = Color.Black;
            suppliersButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            suppliersButton.IconSize = 32;
            suppliersButton.ImageAlign = ContentAlignment.MiddleLeft;
            suppliersButton.Location = new Point(1, 107);
            suppliersButton.Margin = new Padding(1, 2, 1, 2);
            suppliersButton.Name = "suppliersButton";
            suppliersButton.Size = new Size(252, 31);
            suppliersButton.TabIndex = 15;
            suppliersButton.Text = "Proveedores";
            suppliersButton.UseVisualStyleBackColor = false;
            suppliersButton.Click += suppliersButton_Click;
            // 
            // createProductsButton
            // 
            createProductsButton.BackColor = Color.White;
            createProductsButton.FlatAppearance.BorderSize = 0;
            createProductsButton.FlatStyle = FlatStyle.Flat;
            createProductsButton.Font = new Font("Segoe UI Historic", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createProductsButton.ForeColor = SystemColors.ActiveCaptionText;
            createProductsButton.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            createProductsButton.IconColor = Color.Black;
            createProductsButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            createProductsButton.IconSize = 32;
            createProductsButton.ImageAlign = ContentAlignment.MiddleLeft;
            createProductsButton.Location = new Point(1, 142);
            createProductsButton.Margin = new Padding(1, 2, 1, 2);
            createProductsButton.Name = "createProductsButton";
            createProductsButton.Size = new Size(252, 31);
            createProductsButton.TabIndex = 14;
            createProductsButton.Text = "Añadir productos";
            createProductsButton.UseVisualStyleBackColor = false;
            createProductsButton.Click += createProductsButton_Click;
            // 
            // shoppingOrdersButton
            // 
            shoppingOrdersButton.BackColor = Color.White;
            shoppingOrdersButton.FlatAppearance.BorderSize = 0;
            shoppingOrdersButton.FlatStyle = FlatStyle.Flat;
            shoppingOrdersButton.Font = new Font("Segoe UI Historic", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            shoppingOrdersButton.ForeColor = SystemColors.ActiveCaptionText;
            shoppingOrdersButton.IconChar = FontAwesome.Sharp.IconChar.Shopify;
            shoppingOrdersButton.IconColor = Color.Black;
            shoppingOrdersButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            shoppingOrdersButton.IconSize = 32;
            shoppingOrdersButton.ImageAlign = ContentAlignment.MiddleLeft;
            shoppingOrdersButton.Location = new Point(1, 177);
            shoppingOrdersButton.Margin = new Padding(1, 2, 1, 2);
            shoppingOrdersButton.Name = "shoppingOrdersButton";
            shoppingOrdersButton.Size = new Size(252, 31);
            shoppingOrdersButton.TabIndex = 13;
            shoppingOrdersButton.Text = "Pedidos Realizados";
            shoppingOrdersButton.UseVisualStyleBackColor = false;
            shoppingOrdersButton.Click += shoppingOrdersButton_Click;
            // 
            // inventoryButton
            // 
            inventoryButton.BackColor = Color.White;
            inventoryButton.FlatAppearance.BorderSize = 0;
            inventoryButton.FlatStyle = FlatStyle.Flat;
            inventoryButton.Font = new Font("Segoe UI Historic", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            inventoryButton.ForeColor = SystemColors.ActiveCaptionText;
            inventoryButton.IconChar = FontAwesome.Sharp.IconChar.Newspaper;
            inventoryButton.IconColor = Color.Black;
            inventoryButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            inventoryButton.IconSize = 32;
            inventoryButton.ImageAlign = ContentAlignment.MiddleLeft;
            inventoryButton.Location = new Point(1, 212);
            inventoryButton.Margin = new Padding(1, 2, 1, 2);
            inventoryButton.Name = "inventoryButton";
            inventoryButton.Size = new Size(252, 31);
            inventoryButton.TabIndex = 12;
            inventoryButton.Text = "Inventario";
            inventoryButton.UseVisualStyleBackColor = false;
            inventoryButton.Click += inventoryButton_Click;
            // 
            // salesReportButton
            // 
            salesReportButton.BackColor = Color.White;
            salesReportButton.FlatAppearance.BorderSize = 0;
            salesReportButton.FlatStyle = FlatStyle.Flat;
            salesReportButton.Font = new Font("Segoe UI Historic", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            salesReportButton.ForeColor = Color.Black;
            salesReportButton.IconChar = FontAwesome.Sharp.IconChar.MoneyBillTrendUp;
            salesReportButton.IconColor = Color.Black;
            salesReportButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            salesReportButton.IconSize = 32;
            salesReportButton.ImageAlign = ContentAlignment.MiddleLeft;
            salesReportButton.Location = new Point(1, 247);
            salesReportButton.Margin = new Padding(1, 2, 1, 2);
            salesReportButton.Name = "salesReportButton";
            salesReportButton.Size = new Size(256, 31);
            salesReportButton.TabIndex = 11;
            salesReportButton.Text = "Reporte de ventas";
            salesReportButton.UseVisualStyleBackColor = false;
            salesReportButton.Click += salesReportButton_Click;
            // 
            // exitSesionButton
            // 
            exitSesionButton.BackColor = Color.White;
            exitSesionButton.Dock = DockStyle.Bottom;
            exitSesionButton.FlatAppearance.BorderSize = 0;
            exitSesionButton.FlatStyle = FlatStyle.Flat;
            exitSesionButton.Font = new Font("Segoe UI Historic", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exitSesionButton.ForeColor = SystemColors.ActiveCaptionText;
            exitSesionButton.IconChar = FontAwesome.Sharp.IconChar.ChevronCircleLeft;
            exitSesionButton.IconColor = Color.Black;
            exitSesionButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            exitSesionButton.IconSize = 32;
            exitSesionButton.ImageAlign = ContentAlignment.MiddleLeft;
            exitSesionButton.Location = new Point(0, 760);
            exitSesionButton.Margin = new Padding(1, 2, 1, 2);
            exitSesionButton.Name = "exitSesionButton";
            exitSesionButton.Size = new Size(252, 31);
            exitSesionButton.TabIndex = 6;
            exitSesionButton.Text = "Cerrar Sesión";
            exitSesionButton.UseVisualStyleBackColor = false;
            exitSesionButton.Click += exitSesionButton_Click;
            // 
            // employeeNameLabel
            // 
            employeeNameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            employeeNameLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            employeeNameLabel.ForeColor = Color.White;
            employeeNameLabel.Location = new Point(2, 161);
            employeeNameLabel.Margin = new Padding(4, 0, 4, 0);
            employeeNameLabel.Name = "employeeNameLabel";
            employeeNameLabel.Size = new Size(246, 36);
            employeeNameLabel.TabIndex = 1;
            employeeNameLabel.Text = "josue ivan";
            employeeNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // welcomeLabel
            // 
            welcomeLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            welcomeLabel.ForeColor = Color.White;
            welcomeLabel.Location = new Point(4, 130);
            welcomeLabel.Margin = new Padding(4, 0, 4, 0);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(252, 29);
            welcomeLabel.TabIndex = 0;
            welcomeLabel.Text = "Bienvenido";
            welcomeLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // logoPictureBox
            // 
            logoPictureBox.BackColor = Color.Transparent;
            logoPictureBox.Image = (Image)resources.GetObject("logoPictureBox.Image");
            logoPictureBox.Location = new Point(0, 0);
            logoPictureBox.Margin = new Padding(4, 2, 4, 2);
            logoPictureBox.Name = "logoPictureBox";
            logoPictureBox.Size = new Size(246, 159);
            logoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            logoPictureBox.TabIndex = 0;
            logoPictureBox.TabStop = false;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // PrincipalPanel
            // 
            PrincipalPanel.BackColor = Color.White;
            PrincipalPanel.Controls.Add(pictureBox1);
            PrincipalPanel.Dock = DockStyle.Fill;
            PrincipalPanel.Location = new Point(252, 0);
            PrincipalPanel.Margin = new Padding(4, 2, 4, 2);
            PrincipalPanel.Name = "PrincipalPanel";
            PrincipalPanel.Size = new Size(1362, 791);
            PrincipalPanel.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, -1);
            pictureBox1.Margin = new Padding(4, 2, 4, 2);
            pictureBox1.MaximumSize = new Size(1632, 974);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1459, 790);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1614, 791);
            Controls.Add(PrincipalPanel);
            Controls.Add(sidebarPanel);
            IsMdiContainer = true;
            Margin = new Padding(1, 2, 1, 2);
            Name = "DashboardForm";
            Text = "Dashboard";
            WindowState = FormWindowState.Maximized;
            sidebarPanel.ResumeLayout(false);
            dashBoardFlowLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).EndInit();
            PrincipalPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel sidebarPanel;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Panel PrincipalPanel;
        private PictureBox logoPictureBox;
        private Label employeeNameLabel;
        private Label welcomeLabel;
        private FontAwesome.Sharp.IconButton exitSesionButton;
        private PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private FlowLayoutPanel dashBoardFlowLayoutPanel;
        private FontAwesome.Sharp.IconButton suppliersButton;
        private FontAwesome.Sharp.IconButton createProductsButton;
        private FontAwesome.Sharp.IconButton shoppingOrdersButton;
        private FontAwesome.Sharp.IconButton inventoryButton;
        private FontAwesome.Sharp.IconButton salesReportButton;
        private FontAwesome.Sharp.IconButton employeesButton;
        private FontAwesome.Sharp.IconButton CatalogButton;
        private FontAwesome.Sharp.IconButton clientsButton;
    }
}