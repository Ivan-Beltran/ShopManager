namespace PresentationLayer.Forms
{
    partial class ShoppingListForm
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
            productsDataGridView = new DataGridView();
            shoppingListDataGridView = new DataGridView();
            searchProductPanel = new Panel();
            searchProductButton = new FontAwesome.Sharp.IconButton();
            searchProductTextBox = new TextBox();
            searchProductlLabel = new Label();
            productQuantityLabel = new Label();
            productQuantityTextBox = new TextBox();
            addShoppingListButton = new FontAwesome.Sharp.IconButton();
            label2 = new Label();
            deleteShoppingListButton = new FontAwesome.Sharp.IconButton();
            addPurchaseOrderButton = new FontAwesome.Sharp.IconButton();
            quantityErrorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)productsDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)shoppingListDataGridView).BeginInit();
            searchProductPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)quantityErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // productsDataGridView
            // 
            productsDataGridView.AllowUserToAddRows = false;
            productsDataGridView.AllowUserToDeleteRows = false;
            productsDataGridView.AllowUserToResizeColumns = false;
            productsDataGridView.AllowUserToResizeRows = false;
            productsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            productsDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            productsDataGridView.BackgroundColor = Color.Azure;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            productsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            productsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productsDataGridView.Location = new Point(10, 84);
            productsDataGridView.MultiSelect = false;
            productsDataGridView.Name = "productsDataGridView";
            productsDataGridView.RowHeadersVisible = false;
            productsDataGridView.RowHeadersWidth = 51;
            productsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            productsDataGridView.Size = new Size(654, 232);
            productsDataGridView.TabIndex = 25;
            // 
            // shoppingListDataGridView
            // 
            shoppingListDataGridView.AllowUserToAddRows = false;
            shoppingListDataGridView.AllowUserToDeleteRows = false;
            shoppingListDataGridView.AllowUserToResizeColumns = false;
            shoppingListDataGridView.AllowUserToResizeRows = false;
            shoppingListDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            shoppingListDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            shoppingListDataGridView.BackgroundColor = Color.Azure;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            shoppingListDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            shoppingListDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            shoppingListDataGridView.Location = new Point(697, 84);
            shoppingListDataGridView.MultiSelect = false;
            shoppingListDataGridView.Name = "shoppingListDataGridView";
            shoppingListDataGridView.RowHeadersVisible = false;
            shoppingListDataGridView.RowHeadersWidth = 51;
            shoppingListDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            shoppingListDataGridView.Size = new Size(676, 232);
            shoppingListDataGridView.TabIndex = 26;
            // 
            // searchProductPanel
            // 
            searchProductPanel.BackColor = Color.FromArgb(224, 224, 224);
            searchProductPanel.Controls.Add(searchProductButton);
            searchProductPanel.Controls.Add(searchProductTextBox);
            searchProductPanel.Controls.Add(searchProductlLabel);
            searchProductPanel.Location = new Point(10, 10);
            searchProductPanel.Name = "searchProductPanel";
            searchProductPanel.Size = new Size(654, 55);
            searchProductPanel.TabIndex = 27;
            // 
            // searchProductButton
            // 
            searchProductButton.BackColor = Color.FromArgb(0, 166, 225);
            searchProductButton.FlatAppearance.BorderColor = Color.Black;
            searchProductButton.FlatAppearance.BorderSize = 2;
            searchProductButton.FlatStyle = FlatStyle.Popup;
            searchProductButton.ForeColor = SystemColors.Control;
            searchProductButton.IconChar = FontAwesome.Sharp.IconChar.Search;
            searchProductButton.IconColor = Color.White;
            searchProductButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            searchProductButton.IconSize = 30;
            searchProductButton.Location = new Point(585, 16);
            searchProductButton.Margin = new Padding(3, 2, 3, 2);
            searchProductButton.Name = "searchProductButton";
            searchProductButton.Size = new Size(46, 27);
            searchProductButton.TabIndex = 11;
            searchProductButton.UseVisualStyleBackColor = false;
            searchProductButton.Click += searchProductButton_Click;
            // 
            // searchProductTextBox
            // 
            searchProductTextBox.BorderStyle = BorderStyle.FixedSingle;
            searchProductTextBox.Location = new Point(168, 20);
            searchProductTextBox.Margin = new Padding(3, 2, 3, 2);
            searchProductTextBox.Name = "searchProductTextBox";
            searchProductTextBox.Size = new Size(396, 23);
            searchProductTextBox.TabIndex = 10;
            searchProductTextBox.TextChanged += searchProductTextBox_TextChanged;
            // 
            // searchProductlLabel
            // 
            searchProductlLabel.AutoSize = true;
            searchProductlLabel.BackColor = Color.FromArgb(224, 224, 224);
            searchProductlLabel.Font = new Font("Microsoft Sans Serif", 12.75F);
            searchProductlLabel.ForeColor = SystemColors.ActiveCaptionText;
            searchProductlLabel.Location = new Point(11, 19);
            searchProductlLabel.Name = "searchProductlLabel";
            searchProductlLabel.Size = new Size(133, 20);
            searchProductlLabel.TabIndex = 0;
            searchProductlLabel.Text = "Buscar producto";
            // 
            // productQuantityLabel
            // 
            productQuantityLabel.AutoSize = true;
            productQuantityLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            productQuantityLabel.Location = new Point(38, 355);
            productQuantityLabel.Name = "productQuantityLabel";
            productQuantityLabel.Size = new Size(83, 21);
            productQuantityLabel.TabIndex = 28;
            productQuantityLabel.Text = "Cantidad:";
            // 
            // productQuantityTextBox
            // 
            productQuantityTextBox.Location = new Point(141, 358);
            productQuantityTextBox.Margin = new Padding(3, 2, 3, 2);
            productQuantityTextBox.Name = "productQuantityTextBox";
            productQuantityTextBox.Size = new Size(128, 23);
            productQuantityTextBox.TabIndex = 29;
            // 
            // addShoppingListButton
            // 
            addShoppingListButton.BackColor = Color.FromArgb(0, 166, 225);
            addShoppingListButton.FlatStyle = FlatStyle.Popup;
            addShoppingListButton.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addShoppingListButton.ForeColor = Color.White;
            addShoppingListButton.IconChar = FontAwesome.Sharp.IconChar.CirclePlus;
            addShoppingListButton.IconColor = Color.White;
            addShoppingListButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            addShoppingListButton.IconSize = 38;
            addShoppingListButton.ImageAlign = ContentAlignment.MiddleLeft;
            addShoppingListButton.Location = new Point(322, 345);
            addShoppingListButton.Margin = new Padding(1);
            addShoppingListButton.Name = "addShoppingListButton";
            addShoppingListButton.Size = new Size(220, 34);
            addShoppingListButton.TabIndex = 30;
            addShoppingListButton.Text = " Añadir a la lista";
            addShoppingListButton.UseVisualStyleBackColor = false;
            addShoppingListButton.Click += addShoppingListButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(992, 34);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 31;
            label2.Text = "Carrito";
            // 
            // deleteShoppingListButton
            // 
            deleteShoppingListButton.BackColor = Color.FromArgb(0, 166, 225);
            deleteShoppingListButton.FlatStyle = FlatStyle.Popup;
            deleteShoppingListButton.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteShoppingListButton.ForeColor = Color.White;
            deleteShoppingListButton.IconChar = FontAwesome.Sharp.IconChar.X;
            deleteShoppingListButton.IconColor = Color.White;
            deleteShoppingListButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            deleteShoppingListButton.IconSize = 30;
            deleteShoppingListButton.ImageAlign = ContentAlignment.MiddleLeft;
            deleteShoppingListButton.Location = new Point(749, 340);
            deleteShoppingListButton.Margin = new Padding(1);
            deleteShoppingListButton.Name = "deleteShoppingListButton";
            deleteShoppingListButton.Size = new Size(233, 33);
            deleteShoppingListButton.TabIndex = 32;
            deleteShoppingListButton.Text = "Quitar de la lista";
            deleteShoppingListButton.UseVisualStyleBackColor = false;
            deleteShoppingListButton.Click += deleteShoppingListButton_Click;
            // 
            // addPurchaseOrderButton
            // 
            addPurchaseOrderButton.BackColor = Color.FromArgb(0, 166, 225);
            addPurchaseOrderButton.FlatStyle = FlatStyle.Popup;
            addPurchaseOrderButton.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addPurchaseOrderButton.ForeColor = Color.White;
            addPurchaseOrderButton.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            addPurchaseOrderButton.IconColor = Color.White;
            addPurchaseOrderButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            addPurchaseOrderButton.IconSize = 38;
            addPurchaseOrderButton.ImageAlign = ContentAlignment.MiddleLeft;
            addPurchaseOrderButton.Location = new Point(1075, 340);
            addPurchaseOrderButton.Margin = new Padding(1);
            addPurchaseOrderButton.Name = "addPurchaseOrderButton";
            addPurchaseOrderButton.Size = new Size(213, 33);
            addPurchaseOrderButton.TabIndex = 33;
            addPurchaseOrderButton.Text = " Realizar pedido";
            addPurchaseOrderButton.UseVisualStyleBackColor = false;
            addPurchaseOrderButton.Click += addPurchaseOrderButton_Click;
            // 
            // quantityErrorProvider
            // 
            quantityErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            quantityErrorProvider.ContainerControl = this;
            // 
            // ShoppingListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1407, 479);
            Controls.Add(addPurchaseOrderButton);
            Controls.Add(deleteShoppingListButton);
            Controls.Add(label2);
            Controls.Add(addShoppingListButton);
            Controls.Add(productQuantityTextBox);
            Controls.Add(productQuantityLabel);
            Controls.Add(searchProductPanel);
            Controls.Add(shoppingListDataGridView);
            Controls.Add(productsDataGridView);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ShoppingListForm";
            Text = "ShoppingListForm";
            FormClosing += ShoppingListForm_FormClosing;
            ((System.ComponentModel.ISupportInitialize)productsDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)shoppingListDataGridView).EndInit();
            searchProductPanel.ResumeLayout(false);
            searchProductPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)quantityErrorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView productsDataGridView;
        private DataGridView shoppingListDataGridView;
        private Panel searchProductPanel;
        private FontAwesome.Sharp.IconButton searchProductButton;
        private TextBox searchProductTextBox;
        private Label searchProductlLabel;
        private Label productQuantityLabel;
        private TextBox productQuantityTextBox;
        private FontAwesome.Sharp.IconButton addShoppingListButton;
        private Label label2;
        private FontAwesome.Sharp.IconButton deleteShoppingListButton;
        private FontAwesome.Sharp.IconButton addPurchaseOrderButton;
        private ErrorProvider quantityErrorProvider;
    }
}