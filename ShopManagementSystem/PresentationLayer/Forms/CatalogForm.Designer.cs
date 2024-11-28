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
            Searchlabel = new Label();
            searchTextBox = new TextBox();
            shoppingcart = new PictureBox();
            productsFlowLayoutPanel = new FlowLayoutPanel();
            searchProductgroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)shoppingcart).BeginInit();
            SuspendLayout();
            // 
            // searchProductgroupBox
            // 
            searchProductgroupBox.BackColor = Color.Teal;
            searchProductgroupBox.Controls.Add(productCountLabel);
            searchProductgroupBox.Controls.Add(searchButton);
            searchProductgroupBox.Controls.Add(Searchlabel);
            searchProductgroupBox.Controls.Add(searchTextBox);
            searchProductgroupBox.Controls.Add(shoppingcart);
            searchProductgroupBox.Dock = DockStyle.Top;
            searchProductgroupBox.Location = new Point(0, 0);
            searchProductgroupBox.Margin = new Padding(4, 8, 4, 8);
            searchProductgroupBox.Name = "searchProductgroupBox";
            searchProductgroupBox.Padding = new Padding(3, 2, 3, 2);
            searchProductgroupBox.Size = new Size(1684, 100);
            searchProductgroupBox.TabIndex = 0;
            searchProductgroupBox.TabStop = false;
            // 
            // productCountLabel
            // 
            productCountLabel.BackColor = Color.Orange;
            productCountLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            productCountLabel.ForeColor = SystemColors.ControlLightLight;
            productCountLabel.Location = new Point(1181, 11);
            productCountLabel.Name = "productCountLabel";
            productCountLabel.Size = new Size(30, 29);
            productCountLabel.TabIndex = 12;
            productCountLabel.Text = "0";
            productCountLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
<<<<<<< HEAD
=======
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 7);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 0;
            label1.Text = "ClickZY";
            // 
>>>>>>> ae7a16b970b3978c1082e4de21a22b8087faec5d
            // searchButton
            // 
            searchButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            searchButton.IconChar = FontAwesome.Sharp.IconChar.Search;
            searchButton.IconColor = Color.Black;
            searchButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            searchButton.IconSize = 64;
            searchButton.Location = new Point(1018, 21);
            searchButton.Margin = new Padding(3, 2, 3, 2);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(98, 57);
            searchButton.TabIndex = 11;
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click_2;
            // 
            // Searchlabel
            // 
            Searchlabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Searchlabel.AutoSize = true;
            Searchlabel.BackColor = Color.Transparent;
            Searchlabel.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            Searchlabel.ForeColor = SystemColors.Control;
            Searchlabel.Location = new Point(52, 32);
            Searchlabel.Margin = new Padding(88, 11, 0, 0);
            Searchlabel.Name = "Searchlabel";
            Searchlabel.Size = new Size(248, 41);
            Searchlabel.TabIndex = 4;
            Searchlabel.Text = "Buscar producto";
            Searchlabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // searchTextBox
            // 
            searchTextBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchTextBox.Location = new Point(340, 34);
            searchTextBox.Margin = new Padding(18, 15, 3, 2);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(661, 39);
            searchTextBox.TabIndex = 5;
            searchTextBox.TextChanged += searchTextBox_TextChanged;
            // 
            // shoppingcart
            // 
            shoppingcart.BackColor = Color.Transparent;
            shoppingcart.Image = (Image)resources.GetObject("shoppingcart.Image");
            shoppingcart.Location = new Point(1144, 32);
            shoppingcart.Margin = new Padding(26, 8, 3, 2);
            shoppingcart.Name = "shoppingcart";
            shoppingcart.Size = new Size(66, 50);
            shoppingcart.SizeMode = PictureBoxSizeMode.StretchImage;
            shoppingcart.TabIndex = 7;
            shoppingcart.TabStop = false;
            shoppingcart.Click += shoppingcart_Click_1;
            // 
            // productsFlowLayoutPanel
            // 
            productsFlowLayoutPanel.AutoScroll = true;
            productsFlowLayoutPanel.BackColor = SystemColors.ControlDark;
            productsFlowLayoutPanel.Dock = DockStyle.Fill;
            productsFlowLayoutPanel.Location = new Point(0, 100);
            productsFlowLayoutPanel.Margin = new Padding(9, 22, 9, 4);
            productsFlowLayoutPanel.Name = "productsFlowLayoutPanel";
            productsFlowLayoutPanel.Size = new Size(1684, 691);
            productsFlowLayoutPanel.TabIndex = 1;
            // 
            // CatalogForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.Disable;
            ClientSize = new Size(1684, 791);
            Controls.Add(productsFlowLayoutPanel);
            Controls.Add(searchProductgroupBox);
            Margin = new Padding(3, 2, 3, 2);
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
        private Label Searchlabel;
        private TextBox searchTextBox;
        private PictureBox shoppingcart;
        private FlowLayoutPanel productsFlowLayoutPanel;
        private FontAwesome.Sharp.IconButton searchButton;
        private Label productCountLabel;
    }
}