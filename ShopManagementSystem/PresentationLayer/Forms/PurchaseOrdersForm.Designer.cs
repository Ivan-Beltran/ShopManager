namespace PresentationLayer.Forms
{
    partial class PurchaseOrdersForm
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            purchaeOrderGroupBox = new GroupBox();
            detailsTextBox = new TextBox();
            supplierComboBox = new ComboBox();
            detailLabel = new Label();
            supplierLabel = new Label();
            createPurchaseOrderButton = new FontAwesome.Sharp.IconButton();
            purchaseOrderTittleLabel = new Label();
            groupBox2 = new GroupBox();
            deletePurchaseOrderButton = new FontAwesome.Sharp.IconButton();
            addProductsButton = new FontAwesome.Sharp.IconButton();
            purchaseOrderDataGridView = new DataGridView();
            purchaeOrderGroupBox.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)purchaseOrderDataGridView).BeginInit();
            SuspendLayout();
            // 
            // purchaeOrderGroupBox
            // 
            purchaeOrderGroupBox.Controls.Add(detailsTextBox);
            purchaeOrderGroupBox.Controls.Add(supplierComboBox);
            purchaeOrderGroupBox.Controls.Add(detailLabel);
            purchaeOrderGroupBox.Controls.Add(supplierLabel);
            purchaeOrderGroupBox.Controls.Add(createPurchaseOrderButton);
            purchaeOrderGroupBox.Controls.Add(purchaseOrderTittleLabel);
            purchaeOrderGroupBox.Controls.Add(groupBox2);
            purchaeOrderGroupBox.Controls.Add(purchaseOrderDataGridView);
            purchaeOrderGroupBox.Location = new Point(22, 9);
            purchaeOrderGroupBox.Margin = new Padding(3, 2, 3, 2);
            purchaeOrderGroupBox.Name = "purchaeOrderGroupBox";
            purchaeOrderGroupBox.Padding = new Padding(3, 2, 3, 2);
            purchaeOrderGroupBox.Size = new Size(1287, 724);
            purchaeOrderGroupBox.TabIndex = 0;
            purchaeOrderGroupBox.TabStop = false;
            purchaeOrderGroupBox.Text = "ordenes de compra";
            // 
            // detailsTextBox
            // 
            detailsTextBox.Location = new Point(215, 151);
            detailsTextBox.Margin = new Padding(3, 2, 3, 2);
            detailsTextBox.Name = "detailsTextBox";
            detailsTextBox.Size = new Size(386, 23);
            detailsTextBox.TabIndex = 32;
            // 
            // supplierComboBox
            // 
            supplierComboBox.FormattingEnabled = true;
            supplierComboBox.Location = new Point(215, 55);
            supplierComboBox.Margin = new Padding(3, 2, 3, 2);
            supplierComboBox.Name = "supplierComboBox";
            supplierComboBox.Size = new Size(386, 23);
            supplierComboBox.TabIndex = 31;
            // 
            // detailLabel
            // 
            detailLabel.AutoSize = true;
            detailLabel.Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            detailLabel.Location = new Point(78, 156);
            detailLabel.Name = "detailLabel";
            detailLabel.Size = new Size(129, 17);
            detailLabel.TabIndex = 30;
            detailLabel.Text = "Detalles de la orden:";
            // 
            // supplierLabel
            // 
            supplierLabel.AutoSize = true;
            supplierLabel.Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            supplierLabel.Location = new Point(98, 61);
            supplierLabel.Name = "supplierLabel";
            supplierLabel.Size = new Size(72, 17);
            supplierLabel.TabIndex = 29;
            supplierLabel.Text = "Proveedor:";
            // 
            // createPurchaseOrderButton
            // 
            createPurchaseOrderButton.BackColor = Color.FromArgb(0, 166, 225);
            createPurchaseOrderButton.Font = new Font("Segoe UI Historic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createPurchaseOrderButton.ForeColor = Color.White;
            createPurchaseOrderButton.IconChar = FontAwesome.Sharp.IconChar.ShoppingBag;
            createPurchaseOrderButton.IconColor = Color.White;
            createPurchaseOrderButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            createPurchaseOrderButton.IconSize = 32;
            createPurchaseOrderButton.ImageAlign = ContentAlignment.MiddleLeft;
            createPurchaseOrderButton.Location = new Point(98, 247);
            createPurchaseOrderButton.Name = "createPurchaseOrderButton";
            createPurchaseOrderButton.Size = new Size(206, 37);
            createPurchaseOrderButton.TabIndex = 12;
            createPurchaseOrderButton.Text = "Comprar productos";
            createPurchaseOrderButton.UseVisualStyleBackColor = false;
            createPurchaseOrderButton.Click += createPurchaseOrderButton_Click;
            // 
            // purchaseOrderTittleLabel
            // 
            purchaseOrderTittleLabel.AutoSize = true;
            purchaseOrderTittleLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            purchaseOrderTittleLabel.Location = new Point(404, 365);
            purchaseOrderTittleLabel.Name = "purchaseOrderTittleLabel";
            purchaseOrderTittleLabel.Size = new Size(187, 25);
            purchaseOrderTittleLabel.TabIndex = 28;
            purchaseOrderTittleLabel.Text = "Compras Realizadas";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(deletePurchaseOrderButton);
            groupBox2.Controls.Add(addProductsButton);
            groupBox2.Location = new Point(1008, 417);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(252, 275);
            groupBox2.TabIndex = 27;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // deletePurchaseOrderButton
            // 
            deletePurchaseOrderButton.BackColor = Color.FromArgb(0, 166, 225);
            deletePurchaseOrderButton.Font = new Font("Segoe UI Historic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deletePurchaseOrderButton.ForeColor = Color.White;
            deletePurchaseOrderButton.IconChar = FontAwesome.Sharp.IconChar.DeleteLeft;
            deletePurchaseOrderButton.IconColor = Color.White;
            deletePurchaseOrderButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            deletePurchaseOrderButton.IconSize = 32;
            deletePurchaseOrderButton.ImageAlign = ContentAlignment.MiddleLeft;
            deletePurchaseOrderButton.Location = new Point(25, 135);
            deletePurchaseOrderButton.Name = "deletePurchaseOrderButton";
            deletePurchaseOrderButton.Size = new Size(206, 37);
            deletePurchaseOrderButton.TabIndex = 12;
            deletePurchaseOrderButton.Text = "Eliminar compra";
            deletePurchaseOrderButton.UseVisualStyleBackColor = false;
            // 
            // addProductsButton
            // 
            addProductsButton.BackColor = Color.FromArgb(0, 166, 225);
            addProductsButton.Font = new Font("Segoe UI Historic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addProductsButton.ForeColor = Color.White;
            addProductsButton.IconChar = FontAwesome.Sharp.IconChar.CirclePlus;
            addProductsButton.IconColor = Color.White;
            addProductsButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            addProductsButton.IconSize = 32;
            addProductsButton.ImageAlign = ContentAlignment.MiddleLeft;
            addProductsButton.Location = new Point(25, 49);
            addProductsButton.Name = "addProductsButton";
            addProductsButton.Size = new Size(206, 37);
            addProductsButton.TabIndex = 11;
            addProductsButton.Text = "Añadir productos";
            addProductsButton.UseVisualStyleBackColor = false;
            // 
            // purchaseOrderDataGridView
            // 
            purchaseOrderDataGridView.AllowUserToAddRows = false;
            purchaseOrderDataGridView.AllowUserToResizeColumns = false;
            purchaseOrderDataGridView.AllowUserToResizeRows = false;
            purchaseOrderDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            purchaseOrderDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            purchaseOrderDataGridView.BackgroundColor = Color.Azure;
            purchaseOrderDataGridView.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            purchaseOrderDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            purchaseOrderDataGridView.ColumnHeadersHeight = 29;
            purchaseOrderDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            purchaseOrderDataGridView.Cursor = Cursors.Hand;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(0, 166, 225);
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            purchaseOrderDataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            purchaseOrderDataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            purchaseOrderDataGridView.Location = new Point(34, 417);
            purchaseOrderDataGridView.MultiSelect = false;
            purchaseOrderDataGridView.Name = "purchaseOrderDataGridView";
            purchaseOrderDataGridView.ReadOnly = true;
            purchaseOrderDataGridView.RowHeadersVisible = false;
            purchaseOrderDataGridView.RowHeadersWidth = 35;
            purchaseOrderDataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            purchaseOrderDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle6;
            purchaseOrderDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            purchaseOrderDataGridView.ShowCellToolTips = false;
            purchaseOrderDataGridView.Size = new Size(933, 275);
            purchaseOrderDataGridView.TabIndex = 26;
            // 
            // PurchaseOrdersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1390, 791);
            Controls.Add(purchaeOrderGroupBox);
            Margin = new Padding(3, 2, 3, 2);
            Name = "PurchaseOrdersForm";
            Text = "purchaseOrders";
            purchaeOrderGroupBox.ResumeLayout(false);
            purchaeOrderGroupBox.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)purchaseOrderDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox purchaeOrderGroupBox;
        private GroupBox groupBox2;
        private DataGridView purchaseOrderDataGridView;
        private FontAwesome.Sharp.IconButton addProductsButton;
        private Label purchaseOrderTittleLabel;
        private FontAwesome.Sharp.IconButton deletePurchaseOrderButton;
        private FontAwesome.Sharp.IconButton createPurchaseOrderButton;
        private TextBox detailsTextBox;
        private ComboBox supplierComboBox;
        private Label detailLabel;
        private Label supplierLabel;
    }
}