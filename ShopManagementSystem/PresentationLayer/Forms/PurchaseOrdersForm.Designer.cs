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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            purchaeOrderGroupBox = new GroupBox();
            purchaseDetailsLabel = new Label();
            purchaseListDataGridView = new DataGridView();
            addOrdergroupBox = new GroupBox();
            supplierLabel = new Label();
            createPurchaseOrderButton = new FontAwesome.Sharp.IconButton();
            detailsTextBox = new TextBox();
            supplierComboBox = new ComboBox();
            detailLabel = new Label();
            purchaseOrderTittleLabel = new Label();
            groupBox2 = new GroupBox();
            deletePurchaseOrderButton = new FontAwesome.Sharp.IconButton();
            addProductsButton = new FontAwesome.Sharp.IconButton();
            purchaseOrderDataGridView = new DataGridView();
            purchaseOrdersErrorProvider = new ErrorProvider(components);
            TittlePanel = new Panel();
            OrdersTittleLabel = new Label();
            purchaeOrderGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)purchaseListDataGridView).BeginInit();
            addOrdergroupBox.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)purchaseOrderDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)purchaseOrdersErrorProvider).BeginInit();
            TittlePanel.SuspendLayout();
            SuspendLayout();
            // 
            // purchaeOrderGroupBox
            // 
            purchaeOrderGroupBox.BackColor = Color.White;
            purchaeOrderGroupBox.Controls.Add(purchaseDetailsLabel);
            purchaeOrderGroupBox.Controls.Add(purchaseListDataGridView);
            purchaeOrderGroupBox.Controls.Add(addOrdergroupBox);
            purchaeOrderGroupBox.Controls.Add(purchaseOrderTittleLabel);
            purchaeOrderGroupBox.Controls.Add(groupBox2);
            purchaeOrderGroupBox.Controls.Add(purchaseOrderDataGridView);
            purchaeOrderGroupBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            purchaeOrderGroupBox.Location = new Point(12, 89);
            purchaeOrderGroupBox.Name = "purchaeOrderGroupBox";
            purchaeOrderGroupBox.Size = new Size(1471, 1004);
            purchaeOrderGroupBox.TabIndex = 0;
            purchaeOrderGroupBox.TabStop = false;
            purchaeOrderGroupBox.Text = "Ordenes de compra";
            // 
            // purchaseDetailsLabel
            // 
            purchaseDetailsLabel.AutoSize = true;
            purchaseDetailsLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            purchaseDetailsLabel.Location = new Point(452, 662);
            purchaseDetailsLabel.Name = "purchaseDetailsLabel";
            purchaseDetailsLabel.Size = new Size(242, 32);
            purchaseDetailsLabel.TabIndex = 35;
            purchaseDetailsLabel.Text = "Detalles de la orden";
            // 
            // purchaseListDataGridView
            // 
            purchaseListDataGridView.AllowUserToAddRows = false;
            purchaseListDataGridView.AllowUserToResizeColumns = false;
            purchaseListDataGridView.AllowUserToResizeRows = false;
            purchaseListDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            purchaseListDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            purchaseListDataGridView.BackgroundColor = Color.Azure;
            purchaseListDataGridView.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            purchaseListDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            purchaseListDataGridView.ColumnHeadersHeight = 29;
            purchaseListDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            purchaseListDataGridView.Cursor = Cursors.Hand;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 166, 225);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            purchaseListDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            purchaseListDataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            purchaseListDataGridView.Location = new Point(49, 698);
            purchaseListDataGridView.Margin = new Padding(3, 4, 3, 4);
            purchaseListDataGridView.MultiSelect = false;
            purchaseListDataGridView.Name = "purchaseListDataGridView";
            purchaseListDataGridView.ReadOnly = true;
            purchaseListDataGridView.RowHeadersVisible = false;
            purchaseListDataGridView.RowHeadersWidth = 35;
            purchaseListDataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            purchaseListDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            purchaseListDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            purchaseListDataGridView.ShowCellToolTips = false;
            purchaseListDataGridView.Size = new Size(1066, 255);
            purchaseListDataGridView.TabIndex = 34;
            // 
            // addOrdergroupBox
            // 
            addOrdergroupBox.Controls.Add(supplierLabel);
            addOrdergroupBox.Controls.Add(createPurchaseOrderButton);
            addOrdergroupBox.Controls.Add(detailsTextBox);
            addOrdergroupBox.Controls.Add(supplierComboBox);
            addOrdergroupBox.Controls.Add(detailLabel);
            addOrdergroupBox.Location = new Point(39, 59);
            addOrdergroupBox.Name = "addOrdergroupBox";
            addOrdergroupBox.Size = new Size(1178, 190);
            addOrdergroupBox.TabIndex = 33;
            addOrdergroupBox.TabStop = false;
            addOrdergroupBox.Text = "Crear nueva orden de compra";
            // 
            // supplierLabel
            // 
            supplierLabel.AutoSize = true;
            supplierLabel.Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            supplierLabel.Location = new Point(56, 53);
            supplierLabel.Name = "supplierLabel";
            supplierLabel.Size = new Size(92, 23);
            supplierLabel.TabIndex = 29;
            supplierLabel.Text = "Proveedor:";
            // 
            // createPurchaseOrderButton
            // 
            createPurchaseOrderButton.BackColor = Color.FromArgb(0, 166, 225);
            createPurchaseOrderButton.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createPurchaseOrderButton.ForeColor = Color.White;
            createPurchaseOrderButton.IconChar = FontAwesome.Sharp.IconChar.ShoppingBag;
            createPurchaseOrderButton.IconColor = Color.White;
            createPurchaseOrderButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            createPurchaseOrderButton.IconSize = 32;
            createPurchaseOrderButton.ImageAlign = ContentAlignment.MiddleLeft;
            createPurchaseOrderButton.Location = new Point(750, 72);
            createPurchaseOrderButton.Margin = new Padding(3, 4, 3, 4);
            createPurchaseOrderButton.Name = "createPurchaseOrderButton";
            createPurchaseOrderButton.Size = new Size(316, 73);
            createPurchaseOrderButton.TabIndex = 12;
            createPurchaseOrderButton.Text = "Seleccionar productos ";
            createPurchaseOrderButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            createPurchaseOrderButton.UseVisualStyleBackColor = false;
            createPurchaseOrderButton.Click += createPurchaseOrderButton_Click;
            // 
            // detailsTextBox
            // 
            detailsTextBox.Location = new Point(229, 118);
            detailsTextBox.Name = "detailsTextBox";
            detailsTextBox.Size = new Size(441, 29);
            detailsTextBox.TabIndex = 32;
            // 
            // supplierComboBox
            // 
            supplierComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            supplierComboBox.FormattingEnabled = true;
            supplierComboBox.Location = new Point(213, 48);
            supplierComboBox.Name = "supplierComboBox";
            supplierComboBox.Size = new Size(441, 29);
            supplierComboBox.TabIndex = 31;
            // 
            // detailLabel
            // 
            detailLabel.AutoSize = true;
            detailLabel.Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            detailLabel.Location = new Point(56, 122);
            detailLabel.Name = "detailLabel";
            detailLabel.Size = new Size(166, 23);
            detailLabel.TabIndex = 30;
            detailLabel.Text = "Detalles de la orden:";
            // 
            // purchaseOrderTittleLabel
            // 
            purchaseOrderTittleLabel.AutoSize = true;
            purchaseOrderTittleLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            purchaseOrderTittleLabel.Location = new Point(452, 275);
            purchaseOrderTittleLabel.Name = "purchaseOrderTittleLabel";
            purchaseOrderTittleLabel.Size = new Size(236, 32);
            purchaseOrderTittleLabel.TabIndex = 28;
            purchaseOrderTittleLabel.Text = "Compras realizadas";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(deletePurchaseOrderButton);
            groupBox2.Controls.Add(addProductsButton);
            groupBox2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            groupBox2.Location = new Point(1144, 321);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(288, 264);
            groupBox2.TabIndex = 27;
            groupBox2.TabStop = false;
            groupBox2.Text = "Opciones";
            // 
            // deletePurchaseOrderButton
            // 
            deletePurchaseOrderButton.BackColor = Color.FromArgb(0, 166, 225);
            deletePurchaseOrderButton.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold);
            deletePurchaseOrderButton.ForeColor = Color.White;
            deletePurchaseOrderButton.IconChar = FontAwesome.Sharp.IconChar.DeleteLeft;
            deletePurchaseOrderButton.IconColor = Color.White;
            deletePurchaseOrderButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            deletePurchaseOrderButton.IconSize = 32;
            deletePurchaseOrderButton.ImageAlign = ContentAlignment.MiddleLeft;
            deletePurchaseOrderButton.Location = new Point(6, 180);
            deletePurchaseOrderButton.Margin = new Padding(3, 4, 3, 4);
            deletePurchaseOrderButton.Name = "deletePurchaseOrderButton";
            deletePurchaseOrderButton.Size = new Size(276, 49);
            deletePurchaseOrderButton.TabIndex = 12;
            deletePurchaseOrderButton.Text = "Quitar de la lista";
            deletePurchaseOrderButton.UseVisualStyleBackColor = false;
            deletePurchaseOrderButton.Click += deletePurchaseOrderButton_Click;
            // 
            // addProductsButton
            // 
            addProductsButton.BackColor = Color.FromArgb(0, 166, 225);
            addProductsButton.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold);
            addProductsButton.ForeColor = Color.White;
            addProductsButton.IconChar = FontAwesome.Sharp.IconChar.CirclePlus;
            addProductsButton.IconColor = Color.White;
            addProductsButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            addProductsButton.IconSize = 32;
            addProductsButton.ImageAlign = ContentAlignment.MiddleLeft;
            addProductsButton.Location = new Point(6, 65);
            addProductsButton.Margin = new Padding(3, 4, 3, 4);
            addProductsButton.Name = "addProductsButton";
            addProductsButton.Size = new Size(276, 49);
            addProductsButton.TabIndex = 11;
            addProductsButton.Text = "Añadir productos";
            addProductsButton.UseVisualStyleBackColor = false;
            addProductsButton.Click += addProductsButton_Click;
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
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(0, 166, 225);
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            purchaseOrderDataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            purchaseOrderDataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            purchaseOrderDataGridView.Location = new Point(39, 321);
            purchaseOrderDataGridView.Margin = new Padding(3, 4, 3, 4);
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
            purchaseOrderDataGridView.Size = new Size(1066, 313);
            purchaseOrderDataGridView.TabIndex = 26;
            purchaseOrderDataGridView.SelectionChanged += purchaseOrderDataGridView_SelectionChanged;
            // 
            // purchaseOrdersErrorProvider
            // 
            purchaseOrdersErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            purchaseOrdersErrorProvider.ContainerControl = this;
            // 
            // TittlePanel
            // 
            TittlePanel.BackColor = Color.FromArgb(0, 166, 225);
            TittlePanel.Controls.Add(OrdersTittleLabel);
            TittlePanel.Dock = DockStyle.Top;
            TittlePanel.Location = new Point(0, 0);
            TittlePanel.Margin = new Padding(0);
            TittlePanel.Name = "TittlePanel";
            TittlePanel.Size = new Size(1589, 85);
            TittlePanel.TabIndex = 27;
            // 
            // OrdersTittleLabel
            // 
            OrdersTittleLabel.AutoSize = true;
            OrdersTittleLabel.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OrdersTittleLabel.ForeColor = Color.White;
            OrdersTittleLabel.Location = new Point(559, 9);
            OrdersTittleLabel.Name = "OrdersTittleLabel";
            OrdersTittleLabel.Size = new Size(436, 62);
            OrdersTittleLabel.TabIndex = 13;
            OrdersTittleLabel.Text = "Pedidos realizados";
            // 
            // PurchaseOrdersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1589, 1055);
            Controls.Add(TittlePanel);
            Controls.Add(purchaeOrderGroupBox);
            Name = "PurchaseOrdersForm";
            Text = "purchaseOrders";
            purchaeOrderGroupBox.ResumeLayout(false);
            purchaeOrderGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)purchaseListDataGridView).EndInit();
            addOrdergroupBox.ResumeLayout(false);
            addOrdergroupBox.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)purchaseOrderDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)purchaseOrdersErrorProvider).EndInit();
            TittlePanel.ResumeLayout(false);
            TittlePanel.PerformLayout();
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
        private ErrorProvider purchaseOrdersErrorProvider;
        private GroupBox addOrdergroupBox;
        private DataGridView purchaseListDataGridView;
        private Label purchaseDetailsLabel;
        private Panel TittlePanel;
        private Label OrdersTittleLabel;
    }
}