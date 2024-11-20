namespace PresentationLayer.Forms
{
    partial class CreateProductForm
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
            productTypeLabel = new Label();
            productBrandLabel = new Label();
            producModelLabel = new Label();
            productVersionLabel = new Label();
            productColorLabel = new Label();
            producPriceLabel = new Label();
            productBrandTextBox = new TextBox();
            productModeltextBox = new TextBox();
            productVersionTextBox = new TextBox();
            productColorTextBox = new TextBox();
            productPriceTextBox = new TextBox();
            productTypeComboBox = new ComboBox();
            productImgPictureBox = new PictureBox();
            loadProductImgButton = new FontAwesome.Sharp.IconButton();
            productsDataGridView = new DataGridView();
            optionsGroupBox = new GroupBox();
            removeSelectionButton = new FontAwesome.Sharp.IconButton();
            editProductButton = new FontAwesome.Sharp.IconButton();
            openFileImgDialog = new OpenFileDialog();
            addProducButton = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)productImgPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productsDataGridView).BeginInit();
            optionsGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // productTypeLabel
            // 
            productTypeLabel.AutoSize = true;
            productTypeLabel.Location = new Point(205, 47);
            productTypeLabel.Name = "productTypeLabel";
            productTypeLabel.Size = new Size(36, 20);
            productTypeLabel.TabIndex = 0;
            productTypeLabel.Text = "tipo";
            // 
            // productBrandLabel
            // 
            productBrandLabel.AutoSize = true;
            productBrandLabel.Location = new Point(205, 116);
            productBrandLabel.Name = "productBrandLabel";
            productBrandLabel.Size = new Size(50, 20);
            productBrandLabel.TabIndex = 1;
            productBrandLabel.Text = "marca";
            // 
            // producModelLabel
            // 
            producModelLabel.AutoSize = true;
            producModelLabel.Location = new Point(205, 177);
            producModelLabel.Name = "producModelLabel";
            producModelLabel.Size = new Size(61, 20);
            producModelLabel.TabIndex = 2;
            producModelLabel.Text = "modelo";
            // 
            // productVersionLabel
            // 
            productVersionLabel.AutoSize = true;
            productVersionLabel.Location = new Point(205, 243);
            productVersionLabel.Name = "productVersionLabel";
            productVersionLabel.Size = new Size(56, 20);
            productVersionLabel.TabIndex = 3;
            productVersionLabel.Text = "version";
            // 
            // productColorLabel
            // 
            productColorLabel.AutoSize = true;
            productColorLabel.Location = new Point(205, 319);
            productColorLabel.Name = "productColorLabel";
            productColorLabel.Size = new Size(43, 20);
            productColorLabel.TabIndex = 4;
            productColorLabel.Text = "color";
            // 
            // producPriceLabel
            // 
            producPriceLabel.AutoSize = true;
            producPriceLabel.Location = new Point(205, 391);
            producPriceLabel.Name = "producPriceLabel";
            producPriceLabel.Size = new Size(51, 20);
            producPriceLabel.TabIndex = 5;
            producPriceLabel.Text = "precio";
            // 
            // productBrandTextBox
            // 
            productBrandTextBox.Location = new Point(297, 112);
            productBrandTextBox.Name = "productBrandTextBox";
            productBrandTextBox.Size = new Size(351, 27);
            productBrandTextBox.TabIndex = 6;
            // 
            // productModeltextBox
            // 
            productModeltextBox.Location = new Point(297, 176);
            productModeltextBox.Name = "productModeltextBox";
            productModeltextBox.Size = new Size(351, 27);
            productModeltextBox.TabIndex = 7;
            // 
            // productVersionTextBox
            // 
            productVersionTextBox.Location = new Point(297, 245);
            productVersionTextBox.Name = "productVersionTextBox";
            productVersionTextBox.Size = new Size(351, 27);
            productVersionTextBox.TabIndex = 8;
            // 
            // productColorTextBox
            // 
            productColorTextBox.Location = new Point(297, 316);
            productColorTextBox.Name = "productColorTextBox";
            productColorTextBox.Size = new Size(351, 27);
            productColorTextBox.TabIndex = 9;
            // 
            // productPriceTextBox
            // 
            productPriceTextBox.Location = new Point(297, 388);
            productPriceTextBox.Name = "productPriceTextBox";
            productPriceTextBox.Size = new Size(351, 27);
            productPriceTextBox.TabIndex = 10;
            // 
            // productTypeComboBox
            // 
            productTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            productTypeComboBox.FormattingEnabled = true;
            productTypeComboBox.Location = new Point(297, 44);
            productTypeComboBox.Name = "productTypeComboBox";
            productTypeComboBox.Size = new Size(351, 28);
            productTypeComboBox.TabIndex = 11;
            // 
            // productImgPictureBox
            // 
            productImgPictureBox.BorderStyle = BorderStyle.FixedSingle;
            productImgPictureBox.Location = new Point(739, 47);
            productImgPictureBox.Name = "productImgPictureBox";
            productImgPictureBox.Size = new Size(285, 239);
            productImgPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            productImgPictureBox.TabIndex = 12;
            productImgPictureBox.TabStop = false;
            // 
            // loadProductImgButton
            // 
            loadProductImgButton.BackColor = Color.FromArgb(0, 166, 225);
            loadProductImgButton.FlatStyle = FlatStyle.Popup;
            loadProductImgButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loadProductImgButton.ForeColor = Color.White;
            loadProductImgButton.IconChar = FontAwesome.Sharp.IconChar.CirclePlus;
            loadProductImgButton.IconColor = Color.White;
            loadProductImgButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            loadProductImgButton.IconSize = 38;
            loadProductImgButton.ImageAlign = ContentAlignment.MiddleLeft;
            loadProductImgButton.Location = new Point(777, 322);
            loadProductImgButton.Margin = new Padding(1);
            loadProductImgButton.Name = "loadProductImgButton";
            loadProductImgButton.Size = new Size(222, 53);
            loadProductImgButton.TabIndex = 23;
            loadProductImgButton.Text = " cargar imagen";
            loadProductImgButton.UseVisualStyleBackColor = false;
            loadProductImgButton.Click += loadProductImgButton_Click;
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
            productsDataGridView.Location = new Point(61, 536);
            productsDataGridView.Margin = new Padding(3, 4, 3, 4);
            productsDataGridView.MultiSelect = false;
            productsDataGridView.Name = "productsDataGridView";
            productsDataGridView.RowHeadersVisible = false;
            productsDataGridView.RowHeadersWidth = 51;
            productsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            productsDataGridView.Size = new Size(1092, 331);
            productsDataGridView.TabIndex = 24;
            productsDataGridView.SelectionChanged += productsDataGridView_SelectionChanged;
            // 
            // optionsGroupBox
            // 
            optionsGroupBox.Controls.Add(removeSelectionButton);
            optionsGroupBox.Controls.Add(editProductButton);
            optionsGroupBox.Location = new Point(1195, 536);
            optionsGroupBox.Name = "optionsGroupBox";
            optionsGroupBox.Size = new Size(264, 300);
            optionsGroupBox.TabIndex = 25;
            optionsGroupBox.TabStop = false;
            optionsGroupBox.Text = "opciones";
            // 
            // removeSelectionButton
            // 
            removeSelectionButton.BackColor = Color.FromArgb(0, 166, 225);
            removeSelectionButton.FlatStyle = FlatStyle.Popup;
            removeSelectionButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            removeSelectionButton.ForeColor = Color.White;
            removeSelectionButton.IconChar = FontAwesome.Sharp.IconChar.CirclePlus;
            removeSelectionButton.IconColor = Color.White;
            removeSelectionButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            removeSelectionButton.IconSize = 38;
            removeSelectionButton.ImageAlign = ContentAlignment.MiddleLeft;
            removeSelectionButton.Location = new Point(24, 172);
            removeSelectionButton.Margin = new Padding(1);
            removeSelectionButton.Name = "removeSelectionButton";
            removeSelectionButton.Size = new Size(222, 53);
            removeSelectionButton.TabIndex = 25;
            removeSelectionButton.Text = "quitar seleccion";
            removeSelectionButton.UseVisualStyleBackColor = false;
            removeSelectionButton.Click += removeSelectionButton_Click;
            // 
            // editProductButton
            // 
            editProductButton.BackColor = Color.FromArgb(0, 166, 225);
            editProductButton.FlatStyle = FlatStyle.Popup;
            editProductButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            editProductButton.ForeColor = Color.White;
            editProductButton.IconChar = FontAwesome.Sharp.IconChar.CirclePlus;
            editProductButton.IconColor = Color.White;
            editProductButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            editProductButton.IconSize = 38;
            editProductButton.ImageAlign = ContentAlignment.MiddleLeft;
            editProductButton.Location = new Point(24, 53);
            editProductButton.Margin = new Padding(1);
            editProductButton.Name = "editProductButton";
            editProductButton.Size = new Size(222, 53);
            editProductButton.TabIndex = 24;
            editProductButton.Text = "editar";
            editProductButton.UseVisualStyleBackColor = false;
            editProductButton.Click += editProductButton_Click;
            // 
            // openFileImgDialog
            // 
            openFileImgDialog.FileName = "openFileDialog1";
            // 
            // addProducButton
            // 
            addProducButton.BackColor = Color.FromArgb(0, 166, 225);
            addProducButton.FlatStyle = FlatStyle.Popup;
            addProducButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addProducButton.ForeColor = Color.White;
            addProducButton.IconChar = FontAwesome.Sharp.IconChar.CirclePlus;
            addProducButton.IconColor = Color.White;
            addProducButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            addProducButton.IconSize = 38;
            addProducButton.ImageAlign = ContentAlignment.MiddleLeft;
            addProducButton.Location = new Point(1101, 144);
            addProducButton.Margin = new Padding(1);
            addProducButton.Name = "addProducButton";
            addProducButton.Size = new Size(222, 53);
            addProducButton.TabIndex = 26;
            addProducButton.Text = "crear producto";
            addProducButton.UseVisualStyleBackColor = false;
            addProducButton.Click += addProducButton_Click;
            // 
            // CreateProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1503, 911);
            Controls.Add(addProducButton);
            Controls.Add(optionsGroupBox);
            Controls.Add(productsDataGridView);
            Controls.Add(loadProductImgButton);
            Controls.Add(productImgPictureBox);
            Controls.Add(productTypeComboBox);
            Controls.Add(productPriceTextBox);
            Controls.Add(productColorTextBox);
            Controls.Add(productVersionTextBox);
            Controls.Add(productModeltextBox);
            Controls.Add(productBrandTextBox);
            Controls.Add(producPriceLabel);
            Controls.Add(productColorLabel);
            Controls.Add(productVersionLabel);
            Controls.Add(producModelLabel);
            Controls.Add(productBrandLabel);
            Controls.Add(productTypeLabel);
            Name = "CreateProductForm";
            Text = "CreateProductForm";
            ((System.ComponentModel.ISupportInitialize)productImgPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)productsDataGridView).EndInit();
            optionsGroupBox.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label productTypeLabel;
        private Label productBrandLabel;
        private Label producModelLabel;
        private Label productVersionLabel;
        private Label productColorLabel;
        private Label producPriceLabel;
        private TextBox productBrandTextBox;
        private TextBox productModeltextBox;
        private TextBox productVersionTextBox;
        private TextBox productColorTextBox;
        private TextBox productPriceTextBox;
        private ComboBox productTypeComboBox;
        private PictureBox productImgPictureBox;
        private FontAwesome.Sharp.IconButton loadProductImgButton;
        private DataGridView productsDataGridView;
        private GroupBox optionsGroupBox;
        private FontAwesome.Sharp.IconButton removeSelectionButton;
        private FontAwesome.Sharp.IconButton editProductButton;
        private OpenFileDialog openFileImgDialog;
        private FontAwesome.Sharp.IconButton addProducButton;
    }
}