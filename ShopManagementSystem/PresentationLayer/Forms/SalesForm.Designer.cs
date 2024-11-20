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
            PrincipalPanel = new Panel();
            generatePdfReportButton = new Button();
            categoryComboBox = new ComboBox();
            orderDateTimePicker = new DateTimePicker();
            deleteSaleButton = new Button();
            editSaleButton = new Button();
            addSaleButton = new Button();
            saleDataGridView = new DataGridView();
            sidebarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)salesPictureBox).BeginInit();
            PrincipalPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)saleDataGridView).BeginInit();
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
            sidebarPanel.Margin = new Padding(1, 3, 1, 3);
            sidebarPanel.Name = "sidebarPanel";
            sidebarPanel.Size = new Size(1539, 75);
            sidebarPanel.TabIndex = 2;
            // 
            // pictureBox
            // 
            pictureBox.BackColor = Color.Transparent;
            pictureBox.ErrorImage = null;
            pictureBox.Image = (Image)resources.GetObject("pictureBox.Image");
            pictureBox.Location = new Point(280, 0);
            pictureBox.Margin = new Padding(5, 4, 5, 4);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(101, 71);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = 1;
            pictureBox.TabStop = false;
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            welcomeLabel.ForeColor = Color.White;
            welcomeLabel.Location = new Point(793, 43);
            welcomeLabel.Margin = new Padding(5, 0, 5, 0);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(135, 31);
            welcomeLabel.TabIndex = 0;
            welcomeLabel.Text = "Bienvenido";
            // 
            // salesPictureBox
            // 
            salesPictureBox.BackColor = Color.Transparent;
            salesPictureBox.Image = (Image)resources.GetObject("salesPictureBox.Image");
            salesPictureBox.Location = new Point(734, -33);
            salesPictureBox.Margin = new Padding(5, 4, 5, 4);
            salesPictureBox.Name = "salesPictureBox";
            salesPictureBox.Size = new Size(247, 109);
            salesPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            salesPictureBox.TabIndex = 0;
            salesPictureBox.TabStop = false;
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
            PrincipalPanel.Name = "PrincipalPanel";
            PrincipalPanel.Size = new Size(1539, 840);
            PrincipalPanel.TabIndex = 3;
            // 
            // generatePdfReportButton
            // 
            generatePdfReportButton.BackColor = Color.FromArgb(0, 166, 225);
            generatePdfReportButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            generatePdfReportButton.Location = new Point(129, 633);
            generatePdfReportButton.Name = "generatePdfReportButton";
            generatePdfReportButton.Size = new Size(353, 67);
            generatePdfReportButton.TabIndex = 10;
            generatePdfReportButton.Text = "Generar Reporte PDF";
            generatePdfReportButton.UseVisualStyleBackColor = false;
            // 
            // categoryComboBox
            // 
            categoryComboBox.BackColor = Color.FromArgb(0, 166, 225);
            categoryComboBox.FormattingEnabled = true;
            categoryComboBox.Location = new Point(129, 303);
            categoryComboBox.Margin = new Padding(2, 3, 2, 3);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(353, 28);
            categoryComboBox.TabIndex = 9;
            // 
            // orderDateTimePicker
            // 
            orderDateTimePicker.CalendarFont = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            orderDateTimePicker.CalendarMonthBackground = Color.FromArgb(0, 166, 225);
            orderDateTimePicker.CalendarTitleBackColor = Color.White;
            orderDateTimePicker.Location = new Point(129, 240);
            orderDateTimePicker.Margin = new Padding(2, 3, 2, 3);
            orderDateTimePicker.Name = "orderDateTimePicker";
            orderDateTimePicker.Size = new Size(353, 27);
            orderDateTimePicker.TabIndex = 8;
            // 
            // deleteSaleButton
            // 
            deleteSaleButton.BackColor = Color.FromArgb(0, 166, 225);
            deleteSaleButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            deleteSaleButton.Location = new Point(129, 537);
            deleteSaleButton.Name = "deleteSaleButton";
            deleteSaleButton.Size = new Size(353, 67);
            deleteSaleButton.TabIndex = 7;
            deleteSaleButton.Text = "Eliminar";
            deleteSaleButton.UseVisualStyleBackColor = false;
            // 
            // editSaleButton
            // 
            editSaleButton.BackColor = Color.FromArgb(0, 166, 225);
            editSaleButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            editSaleButton.Location = new Point(129, 451);
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
            addSaleButton.Location = new Point(129, 363);
            addSaleButton.Name = "addSaleButton";
            addSaleButton.Size = new Size(353, 65);
            addSaleButton.TabIndex = 5;
            addSaleButton.Text = "Agregar";
            addSaleButton.UseVisualStyleBackColor = false;
            // 
            // saleDataGridView
            // 
            saleDataGridView.BackgroundColor = SystemColors.Control;
            saleDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            saleDataGridView.Location = new Point(875, 65);
            saleDataGridView.Margin = new Padding(1);
            saleDataGridView.Name = "saleDataGridView";
            saleDataGridView.RowHeadersWidth = 62;
            saleDataGridView.Size = new Size(664, 765);
            saleDataGridView.TabIndex = 4;
            // 
            // SalesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1539, 840);
            Controls.Add(sidebarPanel);
            Controls.Add(PrincipalPanel);
            Margin = new Padding(1);
            Name = "SalesForm";
            Text = "SaleForm";
            sidebarPanel.ResumeLayout(false);
            sidebarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)salesPictureBox).EndInit();
            PrincipalPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)saleDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel sidebarPanel;
        private Label welcomeLabel;
        private PictureBox salesPictureBox;
        private Panel PrincipalPanel;
        private DataGridView saleDataGridView;
        private Button deleteSaleButton;
        private Button editSaleButton;
        private Button addSaleButton;
        private PictureBox pictureBox;
        private ComboBox categoryComboBox;
        private DateTimePicker orderDateTimePicker;
        private Button generatePdfReportButton;
    }
}