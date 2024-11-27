﻿namespace PresentationLayer.Forms
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
            label1 = new Label();
            searchButton = new FontAwesome.Sharp.IconButton();
            Searchlabel = new Label();
            searchTextBox = new TextBox();
            shoppingcart = new PictureBox();
            productsFlowLayoutPanel = new FlowLayoutPanel();
            productsCountPictureBox = new PictureBox();
            productCountLabel = new Label();
            searchProductgroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)shoppingcart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productsCountPictureBox).BeginInit();
            SuspendLayout();
            // 
            // searchProductgroupBox
            // 
            searchProductgroupBox.BackColor = Color.Teal;
            searchProductgroupBox.Controls.Add(productCountLabel);
            searchProductgroupBox.Controls.Add(productsCountPictureBox);
            searchProductgroupBox.Controls.Add(label1);
            searchProductgroupBox.Controls.Add(searchButton);
            searchProductgroupBox.Controls.Add(Searchlabel);
            searchProductgroupBox.Controls.Add(searchTextBox);
            searchProductgroupBox.Controls.Add(shoppingcart);
            searchProductgroupBox.Dock = DockStyle.Top;
            searchProductgroupBox.Location = new Point(0, 0);
            searchProductgroupBox.Margin = new Padding(5, 10, 5, 10);
            searchProductgroupBox.Name = "searchProductgroupBox";
            searchProductgroupBox.Size = new Size(1924, 134);
            searchProductgroupBox.TabIndex = 0;
            searchProductgroupBox.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 9);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // searchButton
            // 
            searchButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            searchButton.IconChar = FontAwesome.Sharp.IconChar.Search;
            searchButton.IconColor = Color.Black;
            searchButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            searchButton.IconSize = 64;
            searchButton.Location = new Point(1163, 28);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(112, 76);
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
            Searchlabel.Location = new Point(60, 42);
            Searchlabel.Margin = new Padding(100, 15, 0, 0);
            Searchlabel.Name = "Searchlabel";
            Searchlabel.Size = new Size(308, 50);
            Searchlabel.TabIndex = 4;
            Searchlabel.Text = "Buscar producto";
            Searchlabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // searchTextBox
            // 
            searchTextBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchTextBox.Location = new Point(388, 46);
            searchTextBox.Margin = new Padding(20, 20, 3, 3);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(755, 47);
            searchTextBox.TabIndex = 5;
            searchTextBox.TextChanged += searchTextBox_TextChanged;
            // 
            // shoppingcart
            // 
            shoppingcart.BackColor = Color.Transparent;
            shoppingcart.Image = (Image)resources.GetObject("shoppingcart.Image");
            shoppingcart.Location = new Point(1332, 42);
            shoppingcart.Margin = new Padding(30, 10, 3, 3);
            shoppingcart.Name = "shoppingcart";
            shoppingcart.Size = new Size(87, 73);
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
            productsFlowLayoutPanel.Location = new Point(0, 134);
            productsFlowLayoutPanel.Margin = new Padding(10, 30, 10, 5);
            productsFlowLayoutPanel.Name = "productsFlowLayoutPanel";
            productsFlowLayoutPanel.Size = new Size(1924, 921);
            productsFlowLayoutPanel.TabIndex = 1;
            // 
            // productsCountPictureBox
            // 
            productsCountPictureBox.BackColor = Color.Transparent;
            productsCountPictureBox.Image = (Image)resources.GetObject("productsCountPictureBox.Image");
            productsCountPictureBox.Location = new Point(1411, 9);
            productsCountPictureBox.Name = "productsCountPictureBox";
            productsCountPictureBox.Size = new Size(65, 61);
            productsCountPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            productsCountPictureBox.TabIndex = 0;
            productsCountPictureBox.TabStop = false;
            // 
            // productCountLabel
            // 
            productCountLabel.BackColor = Color.Orange;
            productCountLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            productCountLabel.ForeColor = SystemColors.ControlLightLight;
            productCountLabel.Location = new Point(1432, 23);
            productCountLabel.Name = "productCountLabel";
            productCountLabel.Size = new Size(23, 29);
            productCountLabel.TabIndex = 12;
            productCountLabel.Text = "0";
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
            Text = "CatalogForm";
            searchProductgroupBox.ResumeLayout(false);
            searchProductgroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)shoppingcart).EndInit();
            ((System.ComponentModel.ISupportInitialize)productsCountPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox searchProductgroupBox;
        private Label Searchlabel;
        private TextBox searchTextBox;
        private PictureBox shoppingcart;
        private FlowLayoutPanel productsFlowLayoutPanel;
        private FontAwesome.Sharp.IconButton searchButton;
        private Label label1;
        private Label productCountLabel;
        private PictureBox productsCountPictureBox;
    }
}