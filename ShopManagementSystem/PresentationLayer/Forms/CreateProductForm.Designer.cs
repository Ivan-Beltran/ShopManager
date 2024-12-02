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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
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
            validationErrorProvider = new ErrorProvider(components);
            TittlePanel = new Panel();
            AddProductLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)productImgPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productsDataGridView).BeginInit();
            optionsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)validationErrorProvider).BeginInit();
            TittlePanel.SuspendLayout();
            SuspendLayout();
            // 
            // productTypeLabel
            // 
            productTypeLabel.AutoSize = true;

            productTypeLabel.Font = new Font("Segoe UI Historic", 9.75F);
            productTypeLabel.Location = new Point(205, 47);
            productTypeLabel.Name = "productTypeLabel";
            productTypeLabel.Size = new Size(47, 23);

            productTypeLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            productTypeLabel.Location = new Point(192, 128);
            productTypeLabel.Name = "productTypeLabel";
            productTypeLabel.Size = new Size(68, 31);

            productTypeLabel.TabIndex = 0;
            productTypeLabel.Text = "Tipo:";
            // 
            // productBrandLabel
            // 
            productBrandLabel.AutoSize = true;

            productBrandLabel.Font = new Font("Segoe UI Historic", 9.75F);
            productBrandLabel.Location = new Point(205, 116);
            productBrandLabel.Name = "productBrandLabel";
            productBrandLabel.Size = new Size(61, 23);

            productBrandLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            productBrandLabel.Location = new Point(192, 197);
            productBrandLabel.Name = "productBrandLabel";
            productBrandLabel.Size = new Size(86, 31);

            productBrandLabel.TabIndex = 1;
            productBrandLabel.Text = "Marca:";
            // 
            // producModelLabel
            // 
            producModelLabel.AutoSize = true;

            producModelLabel.Font = new Font("Segoe UI Historic", 9.75F);
            producModelLabel.Location = new Point(205, 177);
            producModelLabel.Name = "producModelLabel";
            producModelLabel.Size = new Size(72, 23);

            producModelLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            producModelLabel.Location = new Point(192, 258);
            producModelLabel.Name = "producModelLabel";
            producModelLabel.Size = new Size(103, 31);

            producModelLabel.TabIndex = 2;
            producModelLabel.Text = "Modelo:";
            // 
            // productVersionLabel
            // 
            productVersionLabel.AutoSize = true;

            productVersionLabel.Font = new Font("Segoe UI Historic", 9.75F);
            productVersionLabel.Location = new Point(205, 243);
            productVersionLabel.Name = "productVersionLabel";
            productVersionLabel.Size = new Size(71, 23);

            productVersionLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            productVersionLabel.Location = new Point(192, 324);
            productVersionLabel.Name = "productVersionLabel";
            productVersionLabel.Size = new Size(100, 31);

            productVersionLabel.TabIndex = 3;
            productVersionLabel.Text = "Versión:";
            // 
            // productColorLabel
            // 
            productColorLabel.AutoSize = true;

            productColorLabel.Font = new Font("Segoe UI Historic", 9.75F);
            productColorLabel.Location = new Point(205, 319);
            productColorLabel.Name = "productColorLabel";
            productColorLabel.Size = new Size(55, 23);

            productColorLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            productColorLabel.Location = new Point(192, 400);
            productColorLabel.Name = "productColorLabel";
            productColorLabel.Size = new Size(79, 31);

            productColorLabel.TabIndex = 4;
            productColorLabel.Text = "Color:";
            // 
            // producPriceLabel
            // 
            producPriceLabel.AutoSize = true;

            producPriceLabel.Font = new Font("Segoe UI Historic", 9.75F);
            producPriceLabel.Location = new Point(205, 391);
            producPriceLabel.Name = "producPriceLabel";
            producPriceLabel.Size = new Size(61, 23);

            producPriceLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            producPriceLabel.Location = new Point(192, 472);
            producPriceLabel.Name = "producPriceLabel";
            producPriceLabel.Size = new Size(87, 31);

            producPriceLabel.TabIndex = 5;
            producPriceLabel.Text = "Precio:";
            // 
            // productBrandTextBox
            // 

            productBrandTextBox.Location = new Point(297, 112);

            productBrandTextBox.Location = new Point(295, 202);

            productBrandTextBox.Name = "productBrandTextBox";
            productBrandTextBox.Size = new Size(351, 27);
            productBrandTextBox.TabIndex = 6;
            // 
            // productModeltextBox
            // 

            productModeltextBox.Location = new Point(297, 176);

            productModeltextBox.Location = new Point(295, 266);

            productModeltextBox.Name = "productModeltextBox";
            productModeltextBox.Size = new Size(351, 27);
            productModeltextBox.TabIndex = 7;
            // 
            // productVersionTextBox
            // 

            productVersionTextBox.Location = new Point(297, 245);

            productVersionTextBox.Location = new Point(295, 335);

            productVersionTextBox.Name = "productVersionTextBox";
            productVersionTextBox.Size = new Size(351, 27);
            productVersionTextBox.TabIndex = 8;
            // 
            // productColorTextBox
            // 

            productColorTextBox.Location = new Point(297, 316);

            productColorTextBox.Location = new Point(295, 406);

            productColorTextBox.Name = "productColorTextBox";
            productColorTextBox.Size = new Size(351, 27);
            productColorTextBox.TabIndex = 9;
            // 
            // productPriceTextBox
            // 

            productPriceTextBox.Location = new Point(297, 388);

            productPriceTextBox.Location = new Point(295, 478);

            productPriceTextBox.Name = "productPriceTextBox";
            productPriceTextBox.Size = new Size(351, 27);
            productPriceTextBox.TabIndex = 10;
            // 
            // productTypeComboBox
            // 
            productTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            productTypeComboBox.FormattingEnabled = true;

            productTypeComboBox.Location = new Point(297, 44);

            productTypeComboBox.Location = new Point(295, 134);

            productTypeComboBox.Name = "productTypeComboBox";
            productTypeComboBox.Size = new Size(351, 28);
            productTypeComboBox.TabIndex = 11;
            // 
            // productImgPictureBox
            // 
            productImgPictureBox.BorderStyle = BorderStyle.FixedSingle;

            productImgPictureBox.Location = new Point(739, 47);

            productImgPictureBox.Location = new Point(737, 137);

            productImgPictureBox.Name = "productImgPictureBox";
            productImgPictureBox.Size = new Size(285, 239);
            productImgPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            productImgPictureBox.TabIndex = 12;
            productImgPictureBox.TabStop = false;
            // 
            // loadProductImgButton
            // 
            loadProductImgButton.BackColor = Color.FromArgb(0, 166, 225);
            loadProductImgButton.FlatStyle = FlatStyle.Flat;
            loadProductImgButton.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loadProductImgButton.ForeColor = Color.White;
            loadProductImgButton.IconChar = FontAwesome.Sharp.IconChar.CirclePlus;
            loadProductImgButton.IconColor = Color.White;
            loadProductImgButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            loadProductImgButton.IconSize = 38;
            loadProductImgButton.ImageAlign = ContentAlignment.MiddleLeft;

            loadProductImgButton.Location = new Point(763, 319);

            loadProductImgButton.Location = new Point(1054, 202);

            loadProductImgButton.Margin = new Padding(1);
            loadProductImgButton.Name = "loadProductImgButton";
            loadProductImgButton.Size = new Size(248, 53);
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            productsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            productsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productsDataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            productsDataGridView.Location = new Point(61, 536);
            productsDataGridView.Margin = new Padding(3, 4, 3, 4);
            productsDataGridView.MultiSelect = false;
            productsDataGridView.Name = "productsDataGridView";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            productsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            productsDataGridView.RowHeadersVisible = false;
            productsDataGridView.RowHeadersWidth = 51;
            productsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            productsDataGridView.Size = new Size(1093, 331);
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
            optionsGroupBox.Text = "Opciones";
            // 
            // removeSelectionButton
            // 
            removeSelectionButton.BackColor = Color.FromArgb(0, 166, 225);
            removeSelectionButton.FlatStyle = FlatStyle.Flat;
            removeSelectionButton.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold);
            removeSelectionButton.ForeColor = Color.White;
            removeSelectionButton.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            removeSelectionButton.IconColor = Color.White;
            removeSelectionButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            removeSelectionButton.IconSize = 38;
            removeSelectionButton.ImageAlign = ContentAlignment.MiddleLeft;
            removeSelectionButton.Location = new Point(24, 172);
            removeSelectionButton.Margin = new Padding(1);
            removeSelectionButton.Name = "removeSelectionButton";
            removeSelectionButton.Size = new Size(222, 53);
            removeSelectionButton.TabIndex = 25;
            removeSelectionButton.Text = "   Quitar selección";
            removeSelectionButton.UseVisualStyleBackColor = false;
            removeSelectionButton.Click += removeSelectionButton_Click;
            // 
            // editProductButton
            // 
            editProductButton.BackColor = Color.FromArgb(0, 166, 225);
            editProductButton.FlatStyle = FlatStyle.Flat;
            editProductButton.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold);
            editProductButton.ForeColor = Color.White;
            editProductButton.IconChar = FontAwesome.Sharp.IconChar.Edit;
            editProductButton.IconColor = Color.White;
            editProductButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            editProductButton.IconSize = 38;
            editProductButton.ImageAlign = ContentAlignment.MiddleLeft;
            editProductButton.Location = new Point(24, 53);
            editProductButton.Margin = new Padding(1);
            editProductButton.Name = "editProductButton";
            editProductButton.Size = new Size(222, 53);
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
            addProducButton.FlatStyle = FlatStyle.Flat;
            addProducButton.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addProducButton.ForeColor = Color.White;
            addProducButton.IconChar = FontAwesome.Sharp.IconChar.CirclePlus;
            addProducButton.IconColor = Color.White;
            addProducButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            addProducButton.IconSize = 38;
            addProducButton.ImageAlign = ContentAlignment.MiddleLeft;

            addProducButton.Location = new Point(1053, 144);

            addProducButton.Location = new Point(752, 450);

            addProducButton.Margin = new Padding(1);
            addProducButton.Name = "addProducButton";
            addProducButton.Size = new Size(234, 53);
            addProducButton.TabIndex = 26;
            addProducButton.Text = "Crear producto";
            addProducButton.UseVisualStyleBackColor = false;
            addProducButton.Click += addProducButton_Click;
            // 


            // validationErrorProvider
            // 
            validationErrorProvider.ContainerControl = this;
            // 
            // TittlePanel
            // 
            TittlePanel.BackColor = Color.FromArgb(0, 166, 225);
            TittlePanel.Controls.Add(AddProductLabel);
            TittlePanel.Dock = DockStyle.Top;
            TittlePanel.Location = new Point(0, 0);
            TittlePanel.Margin = new Padding(0);
            TittlePanel.Name = "TittlePanel";
            TittlePanel.Size = new Size(1370, 85);
            TittlePanel.TabIndex = 29;
            // 
            // AddProductLabel
            // 
            AddProductLabel.AutoSize = true;
            AddProductLabel.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddProductLabel.ForeColor = Color.White;
            AddProductLabel.Location = new Point(559, 9);
            AddProductLabel.Name = "AddProductLabel";
            AddProductLabel.Size = new Size(391, 62);
            AddProductLabel.TabIndex = 13;
            AddProductLabel.Text = "Añadir producto";
            // 
            // CreateProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;

            ClientSize = new Size(1370, 749);
          

            BackColor = Color.White;
            ClientSize = new Size(1370, 938);
            Controls.Add(TittlePanel);

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
            ((System.ComponentModel.ISupportInitialize)validationErrorProvider).EndInit();
            TittlePanel.ResumeLayout(false);
            TittlePanel.PerformLayout();
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
        private ErrorProvider validationErrorProvider;
        private Panel TittlePanel;
        private Label AddProductLabel;
    }
}