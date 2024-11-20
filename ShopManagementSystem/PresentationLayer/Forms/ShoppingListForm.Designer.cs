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
            ((System.ComponentModel.ISupportInitialize)productsDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)shoppingListDataGridView).BeginInit();
            searchProductPanel.SuspendLayout();
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
            productsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productsDataGridView.Location = new Point(12, 112);
            productsDataGridView.Margin = new Padding(3, 4, 3, 4);
            productsDataGridView.MultiSelect = false;
            productsDataGridView.Name = "productsDataGridView";
            productsDataGridView.RowHeadersVisible = false;
            productsDataGridView.RowHeadersWidth = 51;
            productsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            productsDataGridView.Size = new Size(748, 309);
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
            shoppingListDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            shoppingListDataGridView.Location = new Point(797, 112);
            shoppingListDataGridView.Margin = new Padding(3, 4, 3, 4);
            shoppingListDataGridView.MultiSelect = false;
            shoppingListDataGridView.Name = "shoppingListDataGridView";
            shoppingListDataGridView.RowHeadersVisible = false;
            shoppingListDataGridView.RowHeadersWidth = 51;
            shoppingListDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            shoppingListDataGridView.Size = new Size(772, 309);
            shoppingListDataGridView.TabIndex = 26;
            // 
            // searchProductPanel
            // 
            searchProductPanel.BackColor = Color.FromArgb(224, 224, 224);
            searchProductPanel.Controls.Add(searchProductButton);
            searchProductPanel.Controls.Add(searchProductTextBox);
            searchProductPanel.Controls.Add(searchProductlLabel);
            searchProductPanel.Location = new Point(12, 13);
            searchProductPanel.Margin = new Padding(3, 4, 3, 4);
            searchProductPanel.Name = "searchProductPanel";
            searchProductPanel.Size = new Size(748, 73);
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
            searchProductButton.Location = new Point(669, 21);
            searchProductButton.Name = "searchProductButton";
            searchProductButton.Size = new Size(52, 36);
            searchProductButton.TabIndex = 11;
            searchProductButton.UseVisualStyleBackColor = false;
            // 
            // searchProductTextBox
            // 
            searchProductTextBox.BorderStyle = BorderStyle.FixedSingle;
            searchProductTextBox.Location = new Point(192, 26);
            searchProductTextBox.Name = "searchProductTextBox";
            searchProductTextBox.Size = new Size(452, 27);
            searchProductTextBox.TabIndex = 10;
            // 
            // searchProductlLabel
            // 
            searchProductlLabel.AutoSize = true;
            searchProductlLabel.BackColor = Color.FromArgb(224, 224, 224);
            searchProductlLabel.Font = new Font("Microsoft Sans Serif", 12.75F);
            searchProductlLabel.ForeColor = SystemColors.ActiveCaptionText;
            searchProductlLabel.Location = new Point(13, 25);
            searchProductlLabel.Name = "searchProductlLabel";
            searchProductlLabel.Size = new Size(173, 26);
            searchProductlLabel.TabIndex = 0;
            searchProductlLabel.Text = "Buscar Producto";
            // 
            // productQuantityLabel
            // 
            productQuantityLabel.AutoSize = true;
            productQuantityLabel.Font = new Font("Segoe UI", 11F);
            productQuantityLabel.Location = new Point(44, 473);
            productQuantityLabel.Name = "productQuantityLabel";
            productQuantityLabel.Size = new Size(85, 25);
            productQuantityLabel.TabIndex = 28;
            productQuantityLabel.Text = "cantidad";
            // 
            // productQuantityTextBox
            // 
            productQuantityTextBox.Location = new Point(165, 471);
            productQuantityTextBox.Name = "productQuantityTextBox";
            productQuantityTextBox.Size = new Size(146, 27);
            productQuantityTextBox.TabIndex = 29;
            // 
            // addShoppingListButton
            // 
            addShoppingListButton.BackColor = Color.FromArgb(0, 166, 225);
            addShoppingListButton.FlatStyle = FlatStyle.Popup;
            addShoppingListButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addShoppingListButton.ForeColor = Color.White;
            addShoppingListButton.IconChar = FontAwesome.Sharp.IconChar.CirclePlus;
            addShoppingListButton.IconColor = Color.White;
            addShoppingListButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            addShoppingListButton.IconSize = 38;
            addShoppingListButton.ImageAlign = ContentAlignment.MiddleLeft;
            addShoppingListButton.Location = new Point(379, 463);
            addShoppingListButton.Margin = new Padding(1);
            addShoppingListButton.Name = "addShoppingListButton";
            addShoppingListButton.Size = new Size(188, 44);
            addShoppingListButton.TabIndex = 30;
            addShoppingListButton.Text = " añadir";
            addShoppingListButton.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(1134, 45);
            label2.Name = "label2";
            label2.Size = new Size(67, 25);
            label2.TabIndex = 31;
            label2.Text = "carrito";
            // 
            // deleteShoppingListButton
            // 
            deleteShoppingListButton.BackColor = Color.FromArgb(0, 166, 225);
            deleteShoppingListButton.FlatStyle = FlatStyle.Popup;
            deleteShoppingListButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deleteShoppingListButton.ForeColor = Color.White;
            deleteShoppingListButton.IconChar = FontAwesome.Sharp.IconChar.CirclePlus;
            deleteShoppingListButton.IconColor = Color.White;
            deleteShoppingListButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            deleteShoppingListButton.IconSize = 38;
            deleteShoppingListButton.ImageAlign = ContentAlignment.MiddleLeft;
            deleteShoppingListButton.Location = new Point(846, 460);
            deleteShoppingListButton.Margin = new Padding(1);
            deleteShoppingListButton.Name = "deleteShoppingListButton";
            deleteShoppingListButton.Size = new Size(247, 44);
            deleteShoppingListButton.TabIndex = 32;
            deleteShoppingListButton.Text = "eliminar seleccion";
            deleteShoppingListButton.UseVisualStyleBackColor = false;
            // 
            // addPurchaseOrderButton
            // 
            addPurchaseOrderButton.BackColor = Color.FromArgb(0, 166, 225);
            addPurchaseOrderButton.FlatStyle = FlatStyle.Popup;
            addPurchaseOrderButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addPurchaseOrderButton.ForeColor = Color.White;
            addPurchaseOrderButton.IconChar = FontAwesome.Sharp.IconChar.CirclePlus;
            addPurchaseOrderButton.IconColor = Color.White;
            addPurchaseOrderButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            addPurchaseOrderButton.IconSize = 38;
            addPurchaseOrderButton.ImageAlign = ContentAlignment.MiddleLeft;
            addPurchaseOrderButton.Location = new Point(1220, 463);
            addPurchaseOrderButton.Margin = new Padding(1);
            addPurchaseOrderButton.Name = "addPurchaseOrderButton";
            addPurchaseOrderButton.Size = new Size(256, 44);
            addPurchaseOrderButton.TabIndex = 33;
            addPurchaseOrderButton.Text = " realizar pedido";
            addPurchaseOrderButton.UseVisualStyleBackColor = false;
            // 
            // ShoppingListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1608, 639);
            Controls.Add(addPurchaseOrderButton);
            Controls.Add(deleteShoppingListButton);
            Controls.Add(label2);
            Controls.Add(addShoppingListButton);
            Controls.Add(productQuantityTextBox);
            Controls.Add(productQuantityLabel);
            Controls.Add(searchProductPanel);
            Controls.Add(shoppingListDataGridView);
            Controls.Add(productsDataGridView);
            Name = "ShoppingListForm";
            Text = "ShoppingListForm";
            ((System.ComponentModel.ISupportInitialize)productsDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)shoppingListDataGridView).EndInit();
            searchProductPanel.ResumeLayout(false);
            searchProductPanel.PerformLayout();
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
    }
}