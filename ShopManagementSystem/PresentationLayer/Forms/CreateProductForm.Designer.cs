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
            components = new System.ComponentModel.Container();
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
            textBox1 = new TextBox();
            validationErrorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)productImgPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productsDataGridView).BeginInit();
            optionsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)validationErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // productTypeLabel
            // 
            productTypeLabel.AutoSize = true;
            productTypeLabel.Font = new Font("Segoe UI Historic", 9.75F);
            productTypeLabel.Location = new Point(179, 35);
            productTypeLabel.Name = "productTypeLabel";
            productTypeLabel.Size = new Size(37, 17);
            productTypeLabel.TabIndex = 0;
            productTypeLabel.Text = "Tipo:";
            // 
            // productBrandLabel
            // 
            productBrandLabel.AutoSize = true;
            productBrandLabel.Font = new Font("Segoe UI Historic", 9.75F);
            productBrandLabel.Location = new Point(179, 87);
            productBrandLabel.Name = "productBrandLabel";
            productBrandLabel.Size = new Size(48, 17);
            productBrandLabel.TabIndex = 1;
            productBrandLabel.Text = "Marca:";
            // 
            // producModelLabel
            // 
            producModelLabel.AutoSize = true;
            producModelLabel.Font = new Font("Segoe UI Historic", 9.75F);
            producModelLabel.Location = new Point(179, 133);
            producModelLabel.Name = "producModelLabel";
            producModelLabel.Size = new Size(57, 17);
            producModelLabel.TabIndex = 2;
            producModelLabel.Text = "Modelo:";
            // 
            // productVersionLabel
            // 
            productVersionLabel.AutoSize = true;
            productVersionLabel.Font = new Font("Segoe UI Historic", 9.75F);
            productVersionLabel.Location = new Point(179, 182);
            productVersionLabel.Name = "productVersionLabel";
            productVersionLabel.Size = new Size(55, 17);
            productVersionLabel.TabIndex = 3;
            productVersionLabel.Text = "Versión:";
            // 
            // productColorLabel
            // 
            productColorLabel.AutoSize = true;
            productColorLabel.Font = new Font("Segoe UI Historic", 9.75F);
            productColorLabel.Location = new Point(179, 239);
            productColorLabel.Name = "productColorLabel";
            productColorLabel.Size = new Size(43, 17);
            productColorLabel.TabIndex = 4;
            productColorLabel.Text = "Color:";
            // 
            // producPriceLabel
            // 
            producPriceLabel.AutoSize = true;
            producPriceLabel.Font = new Font("Segoe UI Historic", 9.75F);
            producPriceLabel.Location = new Point(179, 293);
            producPriceLabel.Name = "producPriceLabel";
            producPriceLabel.Size = new Size(47, 17);
            producPriceLabel.TabIndex = 5;
            producPriceLabel.Text = "Precio:";
            // 
            // productBrandTextBox
            // 
            productBrandTextBox.Location = new Point(260, 84);
            productBrandTextBox.Margin = new Padding(3, 2, 3, 2);
            productBrandTextBox.Name = "productBrandTextBox";
            productBrandTextBox.Size = new Size(308, 23);
            productBrandTextBox.TabIndex = 6;
            // 
            // productModeltextBox
            // 
            productModeltextBox.Location = new Point(260, 132);
            productModeltextBox.Margin = new Padding(3, 2, 3, 2);
            productModeltextBox.Name = "productModeltextBox";
            productModeltextBox.Size = new Size(308, 23);
            productModeltextBox.TabIndex = 7;
            // 
            // productVersionTextBox
            // 
            productVersionTextBox.Location = new Point(260, 184);
            productVersionTextBox.Margin = new Padding(3, 2, 3, 2);
            productVersionTextBox.Name = "productVersionTextBox";
            productVersionTextBox.Size = new Size(308, 23);
            productVersionTextBox.TabIndex = 8;
            // 
            // productColorTextBox
            // 
            productColorTextBox.Location = new Point(260, 237);
            productColorTextBox.Margin = new Padding(3, 2, 3, 2);
            productColorTextBox.Name = "productColorTextBox";
            productColorTextBox.Size = new Size(308, 23);
            productColorTextBox.TabIndex = 9;
            // 
            // productPriceTextBox
            // 
            productPriceTextBox.Location = new Point(260, 291);
            productPriceTextBox.Margin = new Padding(3, 2, 3, 2);
            productPriceTextBox.Name = "productPriceTextBox";
            productPriceTextBox.Size = new Size(308, 23);
            productPriceTextBox.TabIndex = 10;
            // 
            // productTypeComboBox
            // 
            productTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            productTypeComboBox.FormattingEnabled = true;
            productTypeComboBox.Location = new Point(260, 33);
            productTypeComboBox.Margin = new Padding(3, 2, 3, 2);
            productTypeComboBox.Name = "productTypeComboBox";
            productTypeComboBox.Size = new Size(308, 23);
            productTypeComboBox.TabIndex = 11;
            // 
            // productImgPictureBox
            // 
            productImgPictureBox.BorderStyle = BorderStyle.FixedSingle;
            productImgPictureBox.Location = new Point(647, 35);
            productImgPictureBox.Margin = new Padding(3, 2, 3, 2);
            productImgPictureBox.Name = "productImgPictureBox";
            productImgPictureBox.Size = new Size(250, 180);
            productImgPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            productImgPictureBox.TabIndex = 12;
            productImgPictureBox.TabStop = false;
            // 
            // loadProductImgButton
            // 
            loadProductImgButton.BackColor = Color.FromArgb(0, 166, 225);
            loadProductImgButton.FlatStyle = FlatStyle.Popup;
            loadProductImgButton.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loadProductImgButton.ForeColor = Color.White;
            loadProductImgButton.IconChar = FontAwesome.Sharp.IconChar.CirclePlus;
            loadProductImgButton.IconColor = Color.White;
            loadProductImgButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            loadProductImgButton.IconSize = 38;
            loadProductImgButton.ImageAlign = ContentAlignment.MiddleLeft;
            loadProductImgButton.Location = new Point(668, 239);
            loadProductImgButton.Margin = new Padding(1);
            loadProductImgButton.Name = "loadProductImgButton";
            loadProductImgButton.Size = new Size(217, 40);
            loadProductImgButton.TabIndex = 23;
            loadProductImgButton.Text = " Cargar imagen";
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
            productsDataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            productsDataGridView.Location = new Point(53, 402);
            productsDataGridView.MultiSelect = false;
            productsDataGridView.Name = "productsDataGridView";
            productsDataGridView.RowHeadersVisible = false;
            productsDataGridView.RowHeadersWidth = 51;
            productsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            productsDataGridView.Size = new Size(956, 248);
            productsDataGridView.TabIndex = 24;
            productsDataGridView.SelectionChanged += productsDataGridView_SelectionChanged;
            // 
            // optionsGroupBox
            // 
            optionsGroupBox.Controls.Add(removeSelectionButton);
            optionsGroupBox.Controls.Add(editProductButton);
            optionsGroupBox.Location = new Point(1046, 402);
            optionsGroupBox.Margin = new Padding(3, 2, 3, 2);
            optionsGroupBox.Name = "optionsGroupBox";
            optionsGroupBox.Padding = new Padding(3, 2, 3, 2);
            optionsGroupBox.Size = new Size(231, 225);
            optionsGroupBox.TabIndex = 25;
            optionsGroupBox.TabStop = false;
            optionsGroupBox.Text = "opciones";
            // 
            // removeSelectionButton
            // 
            removeSelectionButton.BackColor = Color.FromArgb(0, 166, 225);
            removeSelectionButton.FlatStyle = FlatStyle.Popup;
            removeSelectionButton.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold);
            removeSelectionButton.ForeColor = Color.White;
            removeSelectionButton.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            removeSelectionButton.IconColor = Color.White;
            removeSelectionButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            removeSelectionButton.IconSize = 38;
            removeSelectionButton.ImageAlign = ContentAlignment.MiddleLeft;
            removeSelectionButton.Location = new Point(21, 129);
            removeSelectionButton.Margin = new Padding(1);
            removeSelectionButton.Name = "removeSelectionButton";
            removeSelectionButton.Size = new Size(194, 40);
            removeSelectionButton.TabIndex = 25;
            removeSelectionButton.Text = "   Quitar selección";
            removeSelectionButton.UseVisualStyleBackColor = false;
            removeSelectionButton.Click += removeSelectionButton_Click;
            // 
            // editProductButton
            // 
            editProductButton.BackColor = Color.FromArgb(0, 166, 225);
            editProductButton.FlatStyle = FlatStyle.Popup;
            editProductButton.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold);
            editProductButton.ForeColor = Color.White;
            editProductButton.IconChar = FontAwesome.Sharp.IconChar.Edit;
            editProductButton.IconColor = Color.White;
            editProductButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            editProductButton.IconSize = 38;
            editProductButton.ImageAlign = ContentAlignment.MiddleLeft;
            editProductButton.Location = new Point(21, 40);
            editProductButton.Margin = new Padding(1);
            editProductButton.Name = "editProductButton";
            editProductButton.Size = new Size(194, 40);
            editProductButton.TabIndex = 24;
            editProductButton.Text = "Editar";
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
            addProducButton.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addProducButton.ForeColor = Color.White;
            addProducButton.IconChar = FontAwesome.Sharp.IconChar.CirclePlus;
            addProducButton.IconColor = Color.White;
            addProducButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            addProducButton.IconSize = 38;
            addProducButton.ImageAlign = ContentAlignment.MiddleLeft;
            addProducButton.Location = new Point(921, 108);
            addProducButton.Margin = new Padding(1);
            addProducButton.Name = "addProducButton";
            addProducButton.Size = new Size(205, 40);
            addProducButton.TabIndex = 26;
            addProducButton.Text = "Crear producto";
            addProducButton.UseVisualStyleBackColor = false;
            addProducButton.Click += addProducButton_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(53, 666);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(970, 23);
            textBox1.TabIndex = 28;
            // 
            // validationErrorProvider
            // 
            validationErrorProvider.ContainerControl = this;
            // 
            // CreateProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1199, 562);
            Controls.Add(textBox1);
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
            Margin = new Padding(3, 2, 3, 2);
            Name = "CreateProductForm";
            Text = "CreateProductForm";
            ((System.ComponentModel.ISupportInitialize)productImgPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)productsDataGridView).EndInit();
            optionsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)validationErrorProvider).EndInit();
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
        private TextBox textBox1;
        private ErrorProvider validationErrorProvider;
    }
}