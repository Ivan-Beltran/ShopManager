namespace PresentationLayer.Forms
{
    partial class CatalogForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CatalogForm));
            searchProductgroupBox = new GroupBox();
            productCountLabel = new Label();
            searchButton = new FontAwesome.Sharp.IconButton();
            TitleFormLabel = new Label();
            searchTextBox = new TextBox();
            shoppingcart = new PictureBox();
            productsFlowLayoutPanel = new FlowLayoutPanel();
            searchProductgroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)shoppingcart).BeginInit();
            SuspendLayout();
            // 
            // searchProductgroupBox
            // 
            searchProductgroupBox.BackColor = Color.FromArgb(0, 166, 225);
            searchProductgroupBox.Controls.Add(productCountLabel);
            searchProductgroupBox.Controls.Add(searchButton);
            searchProductgroupBox.Controls.Add(TitleFormLabel);
            searchProductgroupBox.Controls.Add(searchTextBox);
            searchProductgroupBox.Controls.Add(shoppingcart);
            searchProductgroupBox.Dock = DockStyle.Top;
            searchProductgroupBox.FlatStyle = FlatStyle.System;
            searchProductgroupBox.Location = new Point(0, 0);
            searchProductgroupBox.Margin = new Padding(0);
            searchProductgroupBox.Name = "searchProductgroupBox";
            searchProductgroupBox.Size = new Size(1924, 116);
            searchProductgroupBox.TabIndex = 0;
            searchProductgroupBox.TabStop = false;
            // 
            // productCountLabel
            // 
            productCountLabel.BackColor = Color.Orange;
            productCountLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            productCountLabel.ForeColor = SystemColors.ControlLightLight;
            productCountLabel.Location = new Point(1355, 12);
            productCountLabel.Name = "productCountLabel";
            productCountLabel.Size = new Size(34, 39);
            productCountLabel.TabIndex = 12;
            productCountLabel.Text = "0";
            productCountLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // searchButton
            // 
            searchButton.BackColor = Color.Transparent;
            searchButton.FlatStyle = FlatStyle.Flat;
            searchButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            searchButton.ForeColor = Color.Transparent;
            searchButton.IconChar = FontAwesome.Sharp.IconChar.Search;
            searchButton.IconColor = Color.White;
            searchButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            searchButton.IconSize = 64;
            searchButton.Location = new Point(1162, 30);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(112, 76);
            searchButton.TabIndex = 11;
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += searchButton_Click_2;
            // 
            // TitleFormLabel
            // 
            TitleFormLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TitleFormLabel.AutoSize = true;
            TitleFormLabel.BackColor = Color.Transparent;
            TitleFormLabel.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            TitleFormLabel.ForeColor = SystemColors.Control;
            TitleFormLabel.Location = new Point(60, 37);
            TitleFormLabel.Margin = new Padding(101, 15, 0, 0);
            TitleFormLabel.Name = "TitleFormLabel";
            TitleFormLabel.Size = new Size(308, 50);
            TitleFormLabel.TabIndex = 4;
            TitleFormLabel.Text = "Buscar producto";
            TitleFormLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // searchTextBox
            // 
            searchTextBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchTextBox.Location = new Point(389, 41);
            searchTextBox.Margin = new Padding(21, 20, 3, 3);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(755, 47);
            searchTextBox.TabIndex = 5;
            searchTextBox.TextChanged += searchTextBox_TextChanged;
            // 
            // shoppingcart
            // 
            shoppingcart.BackColor = Color.Transparent;
            shoppingcart.Image = (Image)resources.GetObject("shoppingcart.Image");
            shoppingcart.Location = new Point(1307, 30);
            shoppingcart.Margin = new Padding(30, 11, 3, 3);
            shoppingcart.Name = "shoppingcart";
            shoppingcart.Size = new Size(85, 76);
            shoppingcart.SizeMode = PictureBoxSizeMode.StretchImage;
            shoppingcart.TabIndex = 7;
            shoppingcart.TabStop = false;
            shoppingcart.Click += shoppingcart_Click_1;
            // 
            // productsFlowLayoutPanel
            // 
            productsFlowLayoutPanel.AutoScroll = true;
            productsFlowLayoutPanel.BackColor = Color.White;
            productsFlowLayoutPanel.Dock = DockStyle.Fill;
            productsFlowLayoutPanel.Location = new Point(0, 116);
            productsFlowLayoutPanel.Margin = new Padding(10, 29, 10, 5);
            productsFlowLayoutPanel.Name = "productsFlowLayoutPanel";
            productsFlowLayoutPanel.Size = new Size(1924, 939);
            productsFlowLayoutPanel.TabIndex = 1;
            // 
            // CatalogForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.Disable;
            ClientSize = new Size(1924, 1055);
            Controls.Add(productsFlowLayoutPanel);
            Controls.Add(searchProductgroupBox);
            Name = "CatalogForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CatalogForm";
            searchProductgroupBox.ResumeLayout(false);
            searchProductgroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)shoppingcart).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox searchProductgroupBox;
        private Label TitleFormLabel;
        private TextBox searchTextBox;
        private PictureBox shoppingcart;
        private FlowLayoutPanel productsFlowLayoutPanel;
        private FontAwesome.Sharp.IconButton searchButton;
        private Label productCountLabel;
    }
}