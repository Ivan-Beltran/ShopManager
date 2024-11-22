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
            sidebarPanel = new Panel();
            pictureBox = new PictureBox();
            welcomeLabel = new Label();
            salesPictureBox = new PictureBox();
            saleDataGridView = new DataGridView();
            addSaleButton = new Button();
            editSaleButton = new Button();
            deleteSaleButton = new Button();
            orderDateTimePicker = new DateTimePicker();
            categoryComboBox = new ComboBox();
            generatePdfReportButton = new Button();
            PrincipalPanel = new Panel();
            sidebarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)salesPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)saleDataGridView).BeginInit();
            PrincipalPanel.SuspendLayout();
            SuspendLayout();
            // 
            // sidebarPanel
            // 
            sidebarPanel.AccessibleRole = AccessibleRole.None;
            sidebarPanel.BackColor = Color.FromArgb(0, 166, 225);
            sidebarPanel.BackgroundImageLayout = ImageLayout.None;
            sidebarPanel.Controls.Add(pictureBox);
            sidebarPanel.Controls.Add(welcomeLabel);
            sidebarPanel.Controls.Add(salesPictureBox);
            sidebarPanel.Dock = DockStyle.Top;
            sidebarPanel.Location = new Point(0, 0);
            sidebarPanel.Margin = new Padding(1, 2, 1, 2);
            sidebarPanel.Name = "sidebarPanel";
            sidebarPanel.Size = new Size(1347, 56);
            sidebarPanel.TabIndex = 2;
            // 
            // pictureBox
            // 
            pictureBox.BackColor = Color.Transparent;
            pictureBox.ErrorImage = null;
            pictureBox.Image = (Image)resources.GetObject("pictureBox.Image");
            pictureBox.Location = new Point(245, 0);
            pictureBox.Margin = new Padding(4, 3, 4, 3);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(88, 53);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = 1;
            pictureBox.TabStop = false;
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            welcomeLabel.ForeColor = Color.White;
            welcomeLabel.Location = new Point(694, 32);
            welcomeLabel.Margin = new Padding(4, 0, 4, 0);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(112, 25);
            welcomeLabel.TabIndex = 0;
            welcomeLabel.Text = "Bienvenido";
            // 
            // salesPictureBox
            // 
            salesPictureBox.BackColor = Color.Transparent;
            salesPictureBox.Image = (Image)resources.GetObject("salesPictureBox.Image");
            salesPictureBox.Location = new Point(642, -25);
            salesPictureBox.Margin = new Padding(4, 3, 4, 3);
            salesPictureBox.Name = "salesPictureBox";
            salesPictureBox.Size = new Size(216, 82);
            salesPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            salesPictureBox.TabIndex = 0;
            salesPictureBox.TabStop = false;
            // 
            // saleDataGridView
            // 
            saleDataGridView.BackgroundColor = SystemColors.Control;
            saleDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            saleDataGridView.Location = new Point(766, 49);
            saleDataGridView.Margin = new Padding(1);
            saleDataGridView.Name = "saleDataGridView";
            saleDataGridView.RowHeadersWidth = 62;
            saleDataGridView.Size = new Size(581, 574);
            saleDataGridView.TabIndex = 4;
            // 
            // addSaleButton
            // 
            addSaleButton.BackColor = Color.FromArgb(0, 166, 225);
            addSaleButton.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Bold);
            addSaleButton.ForeColor = Color.White;
            addSaleButton.Location = new Point(113, 272);
            addSaleButton.Margin = new Padding(3, 2, 3, 2);
            addSaleButton.Name = "addSaleButton";
            addSaleButton.Size = new Size(309, 49);
            addSaleButton.TabIndex = 5;
            addSaleButton.Text = "Agregar";
            addSaleButton.UseVisualStyleBackColor = false;
            // 
            // editSaleButton
            // 
            editSaleButton.BackColor = Color.FromArgb(0, 166, 225);
            editSaleButton.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Bold);
            editSaleButton.ForeColor = Color.White;
            editSaleButton.Location = new Point(113, 338);
            editSaleButton.Margin = new Padding(3, 2, 3, 2);
            editSaleButton.Name = "editSaleButton";
            editSaleButton.Size = new Size(309, 49);
            editSaleButton.TabIndex = 6;
            editSaleButton.Text = "Editar";
            editSaleButton.UseVisualStyleBackColor = false;
            // 
            // deleteSaleButton
            // 
            deleteSaleButton.BackColor = Color.FromArgb(0, 166, 225);
            deleteSaleButton.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Bold);
            deleteSaleButton.ForeColor = Color.White;
            deleteSaleButton.Location = new Point(113, 403);
            deleteSaleButton.Margin = new Padding(3, 2, 3, 2);
            deleteSaleButton.Name = "deleteSaleButton";
            deleteSaleButton.Size = new Size(309, 50);
            deleteSaleButton.TabIndex = 7;
            deleteSaleButton.Text = "Eliminar";
            deleteSaleButton.UseVisualStyleBackColor = false;
            // 
            // orderDateTimePicker
            // 
            orderDateTimePicker.CalendarFont = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            orderDateTimePicker.CalendarMonthBackground = Color.FromArgb(0, 166, 225);
            orderDateTimePicker.CalendarTitleBackColor = Color.White;
            orderDateTimePicker.Location = new Point(113, 180);
            orderDateTimePicker.Margin = new Padding(2);
            orderDateTimePicker.Name = "orderDateTimePicker";
            orderDateTimePicker.Size = new Size(309, 23);
            orderDateTimePicker.TabIndex = 8;
            // 
            // categoryComboBox
            // 
            categoryComboBox.BackColor = Color.FromArgb(0, 166, 225);
            categoryComboBox.FormattingEnabled = true;
            categoryComboBox.Location = new Point(113, 227);
            categoryComboBox.Margin = new Padding(2);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(309, 23);
            categoryComboBox.TabIndex = 9;
            // 
            // generatePdfReportButton
            // 
            generatePdfReportButton.BackColor = Color.FromArgb(0, 166, 225);
            generatePdfReportButton.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Bold);
            generatePdfReportButton.ForeColor = Color.White;
            generatePdfReportButton.Location = new Point(113, 475);
            generatePdfReportButton.Margin = new Padding(3, 2, 3, 2);
            generatePdfReportButton.Name = "generatePdfReportButton";
            generatePdfReportButton.Size = new Size(309, 50);
            generatePdfReportButton.TabIndex = 10;
            generatePdfReportButton.Text = "Generar Reporte PDF";
            generatePdfReportButton.UseVisualStyleBackColor = false;
            // 
            // PrincipalPanel
            // 
            PrincipalPanel.BackColor = Color.Transparent;
            PrincipalPanel.BackgroundImage = (Image)resources.GetObject("PrincipalPanel.BackgroundImage");
            PrincipalPanel.BackgroundImageLayout = ImageLayout.Stretch;
            PrincipalPanel.Controls.Add(generatePdfReportButton);
            PrincipalPanel.Controls.Add(categoryComboBox);
            PrincipalPanel.Controls.Add(orderDateTimePicker);
            PrincipalPanel.Controls.Add(deleteSaleButton);
            PrincipalPanel.Controls.Add(editSaleButton);
            PrincipalPanel.Controls.Add(addSaleButton);
            PrincipalPanel.Controls.Add(saleDataGridView);
            PrincipalPanel.Dock = DockStyle.Fill;
            PrincipalPanel.ForeColor = SystemColors.ActiveCaptionText;
            PrincipalPanel.Location = new Point(0, 0);
            PrincipalPanel.Margin = new Padding(3, 2, 3, 2);
            PrincipalPanel.Name = "PrincipalPanel";
            PrincipalPanel.Size = new Size(1347, 630);
            PrincipalPanel.TabIndex = 3;
            // 
            // SalesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1347, 630);
            Controls.Add(sidebarPanel);
            Controls.Add(PrincipalPanel);
            Margin = new Padding(1);
            Name = "SalesForm";
            Text = "SaleForm";
            sidebarPanel.ResumeLayout(false);
            sidebarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)salesPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)saleDataGridView).EndInit();
            PrincipalPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel sidebarPanel;
        private Label welcomeLabel;
        private PictureBox salesPictureBox;
        private PictureBox pictureBox;
        private DataGridView saleDataGridView;
        private Button addSaleButton;
        private Button editSaleButton;
        private Button deleteSaleButton;
        private DateTimePicker orderDateTimePicker;
        private ComboBox categoryComboBox;
        private Button generatePdfReportButton;
        private Panel PrincipalPanel;
    }
}