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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShoppinKart));
            label2 = new Label();
            shoppingKartDataGridView = new DataGridView();
            makePurchaseButton = new FontAwesome.Sharp.IconButton();
            deleteShoppingKartButton = new FontAwesome.Sharp.IconButton();
            totalTittleLabel = new Label();
            totalLabel = new Label();
            panel1 = new Panel();
            shoppingcart = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)shoppingKartDataGridView).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)shoppingcart).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(170, 0);
            label2.Name = "label2";
            label2.Size = new Size(572, 81);
            label2.TabIndex = 33;
            label2.Text = "Carrito de compras";
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            shoppingKartDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            shoppingKartDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            shoppingKartDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            shoppingKartDataGridView.Location = new Point(81, 125);
            shoppingKartDataGridView.Margin = new Padding(3, 4, 3, 4);
            shoppingKartDataGridView.MultiSelect = false;
            shoppingKartDataGridView.Name = "shoppingKartDataGridView";
            shoppingKartDataGridView.RowHeadersVisible = false;
            shoppingKartDataGridView.RowHeadersWidth = 51;
            shoppingKartDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            shoppingKartDataGridView.Size = new Size(907, 353);
            shoppingKartDataGridView.TabIndex = 32;
            // 
            // makePurchaseButton
            // 
            makePurchaseButton.BackColor = Color.FromArgb(0, 166, 225);
            makePurchaseButton.FlatStyle = FlatStyle.Popup;
            makePurchaseButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            makePurchaseButton.ForeColor = Color.White;
            makePurchaseButton.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            makePurchaseButton.IconColor = Color.White;
            makePurchaseButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            makePurchaseButton.IconSize = 38;
            makePurchaseButton.ImageAlign = ContentAlignment.MiddleLeft;
            makePurchaseButton.Location = new Point(482, 498);
            makePurchaseButton.Margin = new Padding(1);
            makePurchaseButton.Name = "makePurchaseButton";
            makePurchaseButton.Size = new Size(243, 44);
            makePurchaseButton.TabIndex = 35;
            makePurchaseButton.Text = " Comprar";
            makePurchaseButton.UseVisualStyleBackColor = false;
            makePurchaseButton.Click += makePurchaseButton_Click;
            // 
            // deleteShoppingKartButton
            // 
            deleteShoppingKartButton.BackColor = Color.FromArgb(0, 166, 225);
            deleteShoppingKartButton.FlatStyle = FlatStyle.Popup;
            deleteShoppingKartButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteShoppingKartButton.ForeColor = Color.White;
            deleteShoppingKartButton.IconChar = FontAwesome.Sharp.IconChar.X;
            deleteShoppingKartButton.IconColor = Color.White;
            deleteShoppingKartButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            deleteShoppingKartButton.IconSize = 30;
            deleteShoppingKartButton.ImageAlign = ContentAlignment.MiddleLeft;
            deleteShoppingKartButton.Location = new Point(109, 498);
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
            totalTittleLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalTittleLabel.Location = new Point(784, 501);
            totalTittleLabel.Name = "totalTittleLabel";
            totalTittleLabel.Size = new Size(104, 41);
            totalTittleLabel.TabIndex = 36;
            totalTittleLabel.Text = "Total :";
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalLabel.Location = new Point(879, 501);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(35, 41);
            totalLabel.TabIndex = 37;
            totalLabel.Text = "$";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 166, 225);
            panel1.Controls.Add(shoppingcart);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1073, 85);
            panel1.TabIndex = 38;
            // 
            // shoppingcart
            // 
            shoppingcart.BackColor = Color.Transparent;
            shoppingcart.Image = (Image)resources.GetObject("shoppingcart.Image");
            shoppingcart.Location = new Point(745, 10);
            shoppingcart.Margin = new Padding(30, 11, 3, 3);
            shoppingcart.Name = "shoppingcart";
            shoppingcart.Size = new Size(70, 68);
            shoppingcart.SizeMode = PictureBoxSizeMode.StretchImage;
            shoppingcart.TabIndex = 39;
            shoppingcart.TabStop = false;
            // 
            // ShoppinKart
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1073, 593);
            Controls.Add(totalLabel);
            Controls.Add(totalTittleLabel);
            Controls.Add(makePurchaseButton);
            Controls.Add(deleteShoppingKartButton);
            Controls.Add(shoppingKartDataGridView);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ShoppinKart";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ShoppinKart";
            FormClosing += ShoppinKart_FormClosing;
            ((System.ComponentModel.ISupportInitialize)shoppingKartDataGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)shoppingcart).EndInit();
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
        private Panel panel1;
        private PictureBox shoppingcart;
    }
}