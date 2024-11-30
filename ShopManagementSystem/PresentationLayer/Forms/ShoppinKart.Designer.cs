namespace PresentationLayer.Forms
{
    partial class ShoppinKart
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
            label2 = new Label();
            shoppingKartDataGridView = new DataGridView();
            makePurchaseButton = new FontAwesome.Sharp.IconButton();
            deleteShoppingKartButton = new FontAwesome.Sharp.IconButton();
            totalTittleLabel = new Label();
            totalLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)shoppingKartDataGridView).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(640, 28);
            label2.Name = "label2";
            label2.Size = new Size(70, 25);
            label2.TabIndex = 33;
            label2.Text = "Carrito";
            // 
            // shoppingKartDataGridView
            // 
            shoppingKartDataGridView.AllowUserToAddRows = false;
            shoppingKartDataGridView.AllowUserToDeleteRows = false;
            shoppingKartDataGridView.AllowUserToResizeColumns = false;
            shoppingKartDataGridView.AllowUserToResizeRows = false;
            shoppingKartDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            shoppingKartDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            shoppingKartDataGridView.BackgroundColor = Color.Azure;
            shoppingKartDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            shoppingKartDataGridView.Location = new Point(67, 95);
            shoppingKartDataGridView.Margin = new Padding(3, 4, 3, 4);
            shoppingKartDataGridView.MultiSelect = false;
            shoppingKartDataGridView.Name = "shoppingKartDataGridView";
            shoppingKartDataGridView.RowHeadersVisible = false;
            shoppingKartDataGridView.RowHeadersWidth = 51;
            shoppingKartDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            shoppingKartDataGridView.Size = new Size(1200, 309);
            shoppingKartDataGridView.TabIndex = 32;
            // 
            // makePurchaseButton
            // 
            makePurchaseButton.BackColor = Color.FromArgb(0, 166, 225);
            makePurchaseButton.FlatStyle = FlatStyle.Popup;
            makePurchaseButton.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            makePurchaseButton.ForeColor = Color.White;
            makePurchaseButton.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            makePurchaseButton.IconColor = Color.White;
            makePurchaseButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            makePurchaseButton.IconSize = 38;
            makePurchaseButton.ImageAlign = ContentAlignment.MiddleLeft;
            makePurchaseButton.Location = new Point(525, 436);
            makePurchaseButton.Margin = new Padding(1);
            makePurchaseButton.Name = "makePurchaseButton";
            makePurchaseButton.Size = new Size(243, 44);
            makePurchaseButton.TabIndex = 35;
            makePurchaseButton.Text = " comprar";
            makePurchaseButton.UseVisualStyleBackColor = false;
            makePurchaseButton.Click += makePurchaseButton_Click;
            // 
            // deleteShoppingKartButton
            // 
            deleteShoppingKartButton.BackColor = Color.FromArgb(0, 166, 225);
            deleteShoppingKartButton.FlatStyle = FlatStyle.Popup;
            deleteShoppingKartButton.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteShoppingKartButton.ForeColor = Color.White;
            deleteShoppingKartButton.IconChar = FontAwesome.Sharp.IconChar.X;
            deleteShoppingKartButton.IconColor = Color.White;
            deleteShoppingKartButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            deleteShoppingKartButton.IconSize = 30;
            deleteShoppingKartButton.ImageAlign = ContentAlignment.MiddleLeft;
            deleteShoppingKartButton.Location = new Point(152, 436);
            deleteShoppingKartButton.Margin = new Padding(1);
            deleteShoppingKartButton.Name = "deleteShoppingKartButton";
            deleteShoppingKartButton.Size = new Size(266, 44);
            deleteShoppingKartButton.TabIndex = 34;
            deleteShoppingKartButton.Text = "Quitar de la lista";
            deleteShoppingKartButton.UseVisualStyleBackColor = false;
            deleteShoppingKartButton.Click += deleteShoppingKartButton_Click;
            // 
            // totalTittleLabel
            // 
            totalTittleLabel.AutoSize = true;
            totalTittleLabel.Font = new Font("Segoe UI", 14F);
            totalTittleLabel.Location = new Point(925, 441);
            totalTittleLabel.Name = "totalTittleLabel";
            totalTittleLabel.Size = new Size(77, 32);
            totalTittleLabel.TabIndex = 36;
            totalTittleLabel.Text = "Total :";
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Font = new Font("Segoe UI", 14F);
            totalLabel.Location = new Point(1024, 441);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(27, 32);
            totalLabel.TabIndex = 37;
            totalLabel.Text = "$";
            // 
            // ShoppinKart
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1384, 593);
            Controls.Add(totalLabel);
            Controls.Add(totalTittleLabel);
            Controls.Add(makePurchaseButton);
            Controls.Add(deleteShoppingKartButton);
            Controls.Add(label2);
            Controls.Add(shoppingKartDataGridView);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ShoppinKart";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ShoppinKart";
            FormClosing += ShoppinKart_FormClosing;
            ((System.ComponentModel.ISupportInitialize)shoppingKartDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private DataGridView shoppingKartDataGridView;
        private FontAwesome.Sharp.IconButton makePurchaseButton;
        private FontAwesome.Sharp.IconButton deleteShoppingKartButton;
        private Label totalTittleLabel;
        private Label totalLabel;
    }
}