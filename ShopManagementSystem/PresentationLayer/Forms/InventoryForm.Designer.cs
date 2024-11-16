namespace PresentationLayer.Forms
{
    partial class InventoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryForm));
            inventoryDataGridView = new DataGridView();
            categoryGroupBox = new GroupBox();
            accesoriesGroupBox = new GroupBox();
            showAccesoriesButton = new FontAwesome.Sharp.IconButton();
            AccesoryLabel = new Label();
            accesoriesPictureBox = new PictureBox();
            totalAccesoriesLabel = new Label();
            pcGroupBox = new GroupBox();
            showPcButton = new FontAwesome.Sharp.IconButton();
            pcLabel = new Label();
            pcPictureBox = new PictureBox();
            pcTotalLabel = new Label();
            LaptopGroupBox = new GroupBox();
            showLaptopsButton = new FontAwesome.Sharp.IconButton();
            laptosLabel = new Label();
            laptopPictureBox = new PictureBox();
            totalLaptosLabel = new Label();
            movilGroupBox = new GroupBox();
            showMovilesButton = new FontAwesome.Sharp.IconButton();
            movilesLabel = new Label();
            movilPictureBox = new PictureBox();
            totalMovilesLabel = new Label();
            TabletsGroupBox = new GroupBox();
            showTabletsButton = new FontAwesome.Sharp.IconButton();
            tabletsLabel = new Label();
            tabletsPictureBox = new PictureBox();
            totalTabletsLabel = new Label();
            searchProductPanel = new Panel();
            searchProductButton = new FontAwesome.Sharp.IconButton();
            searchProductTextBox = new TextBox();
            searchProductlLabel = new Label();
            showAllProductsButton = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)inventoryDataGridView).BeginInit();
            categoryGroupBox.SuspendLayout();
            accesoriesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)accesoriesPictureBox).BeginInit();
            pcGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcPictureBox).BeginInit();
            LaptopGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)laptopPictureBox).BeginInit();
            movilGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)movilPictureBox).BeginInit();
            TabletsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tabletsPictureBox).BeginInit();
            searchProductPanel.SuspendLayout();
            SuspendLayout();
            // 
            // inventoryDataGridView
            // 
            inventoryDataGridView.AllowUserToAddRows = false;
            inventoryDataGridView.AllowUserToDeleteRows = false;
            inventoryDataGridView.AllowUserToResizeColumns = false;
            inventoryDataGridView.AllowUserToResizeRows = false;
            inventoryDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            inventoryDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            inventoryDataGridView.BackgroundColor = Color.Azure;
            inventoryDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            inventoryDataGridView.Location = new Point(134, 442);
            inventoryDataGridView.Margin = new Padding(3, 4, 3, 4);
            inventoryDataGridView.MultiSelect = false;
            inventoryDataGridView.Name = "inventoryDataGridView";
            inventoryDataGridView.RowHeadersVisible = false;
            inventoryDataGridView.RowHeadersWidth = 51;
            inventoryDataGridView.Size = new Size(1431, 331);
            inventoryDataGridView.TabIndex = 0;
            // 
            // categoryGroupBox
            // 
            categoryGroupBox.Controls.Add(accesoriesGroupBox);
            categoryGroupBox.Controls.Add(pcGroupBox);
            categoryGroupBox.Controls.Add(LaptopGroupBox);
            categoryGroupBox.Controls.Add(movilGroupBox);
            categoryGroupBox.Controls.Add(TabletsGroupBox);
            categoryGroupBox.Location = new Point(31, 12);
            categoryGroupBox.Margin = new Padding(3, 4, 3, 4);
            categoryGroupBox.Name = "categoryGroupBox";
            categoryGroupBox.Padding = new Padding(3, 4, 3, 4);
            categoryGroupBox.Size = new Size(1488, 280);
            categoryGroupBox.TabIndex = 9;
            categoryGroupBox.TabStop = false;
            // 
            // accesoriesGroupBox
            // 
            accesoriesGroupBox.BackColor = Color.White;
            accesoriesGroupBox.Controls.Add(showAccesoriesButton);
            accesoriesGroupBox.Controls.Add(AccesoryLabel);
            accesoriesGroupBox.Controls.Add(accesoriesPictureBox);
            accesoriesGroupBox.Controls.Add(totalAccesoriesLabel);
            accesoriesGroupBox.Location = new Point(1236, 27);
            accesoriesGroupBox.Name = "accesoriesGroupBox";
            accesoriesGroupBox.Size = new Size(203, 227);
            accesoriesGroupBox.TabIndex = 21;
            accesoriesGroupBox.TabStop = false;
            // 
            // showAccesoriesButton
            // 
            showAccesoriesButton.BackColor = Color.FromArgb(0, 166, 225);
            showAccesoriesButton.FlatStyle = FlatStyle.Popup;
            showAccesoriesButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            showAccesoriesButton.ForeColor = Color.White;
            showAccesoriesButton.IconChar = FontAwesome.Sharp.IconChar.Eye;
            showAccesoriesButton.IconColor = Color.Gainsboro;
            showAccesoriesButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            showAccesoriesButton.IconSize = 38;
            showAccesoriesButton.ImageAlign = ContentAlignment.MiddleLeft;
            showAccesoriesButton.Location = new Point(0, 199);
            showAccesoriesButton.Name = "showAccesoriesButton";
            showAccesoriesButton.Size = new Size(203, 28);
            showAccesoriesButton.TabIndex = 19;
            showAccesoriesButton.Text = "ver detalles";
            showAccesoriesButton.UseVisualStyleBackColor = false;
            showAccesoriesButton.Click += showAccesoriesButton_Click;
            // 
            // AccesoryLabel
            // 
            AccesoryLabel.BackColor = Color.White;
            AccesoryLabel.BorderStyle = BorderStyle.FixedSingle;
            AccesoryLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            AccesoryLabel.Location = new Point(0, 134);
            AccesoryLabel.Name = "AccesoryLabel";
            AccesoryLabel.Size = new Size(203, 31);
            AccesoryLabel.TabIndex = 16;
            AccesoryLabel.Text = "Accesorios";
            AccesoryLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // accesoriesPictureBox
            // 
            accesoriesPictureBox.BackColor = Color.White;
            accesoriesPictureBox.Image = (Image)resources.GetObject("accesoriesPictureBox.Image");
            accesoriesPictureBox.Location = new Point(0, 0);
            accesoriesPictureBox.Margin = new Padding(3, 4, 3, 4);
            accesoriesPictureBox.Name = "accesoriesPictureBox";
            accesoriesPictureBox.Size = new Size(217, 128);
            accesoriesPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            accesoriesPictureBox.TabIndex = 12;
            accesoriesPictureBox.TabStop = false;
            // 
            // totalAccesoriesLabel
            // 
            totalAccesoriesLabel.BackColor = Color.White;
            totalAccesoriesLabel.BorderStyle = BorderStyle.FixedSingle;
            totalAccesoriesLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            totalAccesoriesLabel.Location = new Point(0, 166);
            totalAccesoriesLabel.Name = "totalAccesoriesLabel";
            totalAccesoriesLabel.Size = new Size(203, 30);
            totalAccesoriesLabel.TabIndex = 1;
            totalAccesoriesLabel.Text = "50";
            totalAccesoriesLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pcGroupBox
            // 
            pcGroupBox.BackColor = Color.White;
            pcGroupBox.Controls.Add(showPcButton);
            pcGroupBox.Controls.Add(pcLabel);
            pcGroupBox.Controls.Add(pcPictureBox);
            pcGroupBox.Controls.Add(pcTotalLabel);
            pcGroupBox.Location = new Point(28, 27);
            pcGroupBox.Name = "pcGroupBox";
            pcGroupBox.Size = new Size(203, 227);
            pcGroupBox.TabIndex = 20;
            pcGroupBox.TabStop = false;
            // 
            // showPcButton
            // 
            showPcButton.BackColor = Color.FromArgb(0, 166, 225);
            showPcButton.FlatStyle = FlatStyle.Popup;
            showPcButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            showPcButton.ForeColor = Color.White;
            showPcButton.IconChar = FontAwesome.Sharp.IconChar.Eye;
            showPcButton.IconColor = Color.Gainsboro;
            showPcButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            showPcButton.IconSize = 38;
            showPcButton.ImageAlign = ContentAlignment.MiddleLeft;
            showPcButton.Location = new Point(0, 199);
            showPcButton.Name = "showPcButton";
            showPcButton.Size = new Size(203, 28);
            showPcButton.TabIndex = 16;
            showPcButton.Text = "ver detalles";
            showPcButton.UseVisualStyleBackColor = false;
            showPcButton.Click += showPcButton_Click;
            // 
            // pcLabel
            // 
            pcLabel.BackColor = Color.White;
            pcLabel.BorderStyle = BorderStyle.FixedSingle;
            pcLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            pcLabel.Location = new Point(0, 132);
            pcLabel.Name = "pcLabel";
            pcLabel.Size = new Size(203, 30);
            pcLabel.TabIndex = 16;
            pcLabel.Text = "Ordenadores";
            pcLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pcPictureBox
            // 
            pcPictureBox.BackColor = Color.White;
            pcPictureBox.Image = (Image)resources.GetObject("pcPictureBox.Image");
            pcPictureBox.Location = new Point(0, 0);
            pcPictureBox.Margin = new Padding(3, 4, 3, 4);
            pcPictureBox.Name = "pcPictureBox";
            pcPictureBox.Size = new Size(203, 128);
            pcPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pcPictureBox.TabIndex = 12;
            pcPictureBox.TabStop = false;
            // 
            // pcTotalLabel
            // 
            pcTotalLabel.BackColor = Color.White;
            pcTotalLabel.BorderStyle = BorderStyle.FixedSingle;
            pcTotalLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            pcTotalLabel.Location = new Point(0, 166);
            pcTotalLabel.Name = "pcTotalLabel";
            pcTotalLabel.Size = new Size(203, 30);
            pcTotalLabel.TabIndex = 1;
            pcTotalLabel.Text = "total : 50";
            pcTotalLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LaptopGroupBox
            // 
            LaptopGroupBox.BackColor = Color.White;
            LaptopGroupBox.Controls.Add(showLaptopsButton);
            LaptopGroupBox.Controls.Add(laptosLabel);
            LaptopGroupBox.Controls.Add(laptopPictureBox);
            LaptopGroupBox.Controls.Add(totalLaptosLabel);
            LaptopGroupBox.Location = new Point(305, 28);
            LaptopGroupBox.Name = "LaptopGroupBox";
            LaptopGroupBox.Size = new Size(203, 227);
            LaptopGroupBox.TabIndex = 19;
            LaptopGroupBox.TabStop = false;
            // 
            // showLaptopsButton
            // 
            showLaptopsButton.BackColor = Color.FromArgb(0, 166, 225);
            showLaptopsButton.FlatStyle = FlatStyle.Popup;
            showLaptopsButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            showLaptopsButton.ForeColor = Color.White;
            showLaptopsButton.IconChar = FontAwesome.Sharp.IconChar.Eye;
            showLaptopsButton.IconColor = Color.Gainsboro;
            showLaptopsButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            showLaptopsButton.IconSize = 38;
            showLaptopsButton.ImageAlign = ContentAlignment.MiddleLeft;
            showLaptopsButton.Location = new Point(0, 198);
            showLaptopsButton.Name = "showLaptopsButton";
            showLaptopsButton.Size = new Size(203, 28);
            showLaptopsButton.TabIndex = 19;
            showLaptopsButton.Text = "ver detalles";
            showLaptopsButton.UseVisualStyleBackColor = false;
            showLaptopsButton.Click += showLaptopsButton_Click;
            // 
            // laptosLabel
            // 
            laptosLabel.BackColor = Color.White;
            laptosLabel.BorderStyle = BorderStyle.FixedSingle;
            laptosLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            laptosLabel.Location = new Point(0, 134);
            laptosLabel.Name = "laptosLabel";
            laptosLabel.Size = new Size(203, 30);
            laptosLabel.TabIndex = 16;
            laptosLabel.Text = "Laptops";
            laptosLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // laptopPictureBox
            // 
            laptopPictureBox.BackColor = Color.White;
            laptopPictureBox.Image = (Image)resources.GetObject("laptopPictureBox.Image");
            laptopPictureBox.Location = new Point(0, 0);
            laptopPictureBox.Margin = new Padding(3, 4, 3, 4);
            laptopPictureBox.Name = "laptopPictureBox";
            laptopPictureBox.Size = new Size(203, 128);
            laptopPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            laptopPictureBox.TabIndex = 12;
            laptopPictureBox.TabStop = false;
            // 
            // totalLaptosLabel
            // 
            totalLaptosLabel.BackColor = Color.White;
            totalLaptosLabel.BorderStyle = BorderStyle.FixedSingle;
            totalLaptosLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            totalLaptosLabel.Location = new Point(0, 166);
            totalLaptosLabel.Name = "totalLaptosLabel";
            totalLaptosLabel.Size = new Size(203, 29);
            totalLaptosLabel.TabIndex = 1;
            totalLaptosLabel.Text = "50";
            totalLaptosLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // movilGroupBox
            // 
            movilGroupBox.BackColor = Color.White;
            movilGroupBox.Controls.Add(showMovilesButton);
            movilGroupBox.Controls.Add(movilesLabel);
            movilGroupBox.Controls.Add(movilPictureBox);
            movilGroupBox.Controls.Add(totalMovilesLabel);
            movilGroupBox.Location = new Point(621, 28);
            movilGroupBox.Name = "movilGroupBox";
            movilGroupBox.Size = new Size(203, 227);
            movilGroupBox.TabIndex = 18;
            movilGroupBox.TabStop = false;
            // 
            // showMovilesButton
            // 
            showMovilesButton.BackColor = Color.FromArgb(0, 166, 225);
            showMovilesButton.FlatStyle = FlatStyle.Popup;
            showMovilesButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            showMovilesButton.ForeColor = Color.White;
            showMovilesButton.IconChar = FontAwesome.Sharp.IconChar.Eye;
            showMovilesButton.IconColor = Color.Gainsboro;
            showMovilesButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            showMovilesButton.IconSize = 38;
            showMovilesButton.ImageAlign = ContentAlignment.MiddleLeft;
            showMovilesButton.Location = new Point(0, 198);
            showMovilesButton.Name = "showMovilesButton";
            showMovilesButton.Size = new Size(203, 28);
            showMovilesButton.TabIndex = 19;
            showMovilesButton.Text = "ver detalles";
            showMovilesButton.UseVisualStyleBackColor = false;
            showMovilesButton.Click += showMovilesButton_Click;
            // 
            // movilesLabel
            // 
            movilesLabel.BackColor = Color.White;
            movilesLabel.BorderStyle = BorderStyle.FixedSingle;
            movilesLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            movilesLabel.Location = new Point(0, 134);
            movilesLabel.Name = "movilesLabel";
            movilesLabel.Size = new Size(203, 31);
            movilesLabel.TabIndex = 16;
            movilesLabel.Text = "Moviles";
            movilesLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // movilPictureBox
            // 
            movilPictureBox.BackColor = Color.White;
            movilPictureBox.Image = (Image)resources.GetObject("movilPictureBox.Image");
            movilPictureBox.Location = new Point(0, 0);
            movilPictureBox.Margin = new Padding(3, 4, 3, 4);
            movilPictureBox.Name = "movilPictureBox";
            movilPictureBox.Size = new Size(217, 128);
            movilPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            movilPictureBox.TabIndex = 12;
            movilPictureBox.TabStop = false;
            // 
            // totalMovilesLabel
            // 
            totalMovilesLabel.BackColor = Color.White;
            totalMovilesLabel.BorderStyle = BorderStyle.FixedSingle;
            totalMovilesLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            totalMovilesLabel.Location = new Point(0, 166);
            totalMovilesLabel.Name = "totalMovilesLabel";
            totalMovilesLabel.Size = new Size(203, 29);
            totalMovilesLabel.TabIndex = 1;
            totalMovilesLabel.Text = "50";
            totalMovilesLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TabletsGroupBox
            // 
            TabletsGroupBox.BackColor = Color.White;
            TabletsGroupBox.Controls.Add(showTabletsButton);
            TabletsGroupBox.Controls.Add(tabletsLabel);
            TabletsGroupBox.Controls.Add(tabletsPictureBox);
            TabletsGroupBox.Controls.Add(totalTabletsLabel);
            TabletsGroupBox.Location = new Point(945, 28);
            TabletsGroupBox.Name = "TabletsGroupBox";
            TabletsGroupBox.Size = new Size(203, 227);
            TabletsGroupBox.TabIndex = 17;
            TabletsGroupBox.TabStop = false;
            // 
            // showTabletsButton
            // 
            showTabletsButton.BackColor = Color.FromArgb(0, 166, 225);
            showTabletsButton.FlatStyle = FlatStyle.Popup;
            showTabletsButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            showTabletsButton.ForeColor = Color.White;
            showTabletsButton.IconChar = FontAwesome.Sharp.IconChar.Eye;
            showTabletsButton.IconColor = Color.Gainsboro;
            showTabletsButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            showTabletsButton.IconSize = 38;
            showTabletsButton.ImageAlign = ContentAlignment.MiddleLeft;
            showTabletsButton.Location = new Point(0, 198);
            showTabletsButton.Name = "showTabletsButton";
            showTabletsButton.Size = new Size(203, 28);
            showTabletsButton.TabIndex = 19;
            showTabletsButton.Text = "ver detalles";
            showTabletsButton.UseVisualStyleBackColor = false;
            showTabletsButton.Click += showTabletsButton_Click;
            // 
            // tabletsLabel
            // 
            tabletsLabel.BackColor = Color.White;
            tabletsLabel.BorderStyle = BorderStyle.FixedSingle;
            tabletsLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            tabletsLabel.Location = new Point(0, 134);
            tabletsLabel.Name = "tabletsLabel";
            tabletsLabel.Size = new Size(203, 31);
            tabletsLabel.TabIndex = 16;
            tabletsLabel.Text = "Tablets";
            tabletsLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabletsPictureBox
            // 
            tabletsPictureBox.BackColor = Color.White;
            tabletsPictureBox.Image = (Image)resources.GetObject("tabletsPictureBox.Image");
            tabletsPictureBox.Location = new Point(0, 0);
            tabletsPictureBox.Margin = new Padding(3, 4, 3, 4);
            tabletsPictureBox.Name = "tabletsPictureBox";
            tabletsPictureBox.Size = new Size(217, 128);
            tabletsPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            tabletsPictureBox.TabIndex = 12;
            tabletsPictureBox.TabStop = false;
            // 
            // totalTabletsLabel
            // 
            totalTabletsLabel.BackColor = Color.White;
            totalTabletsLabel.BorderStyle = BorderStyle.FixedSingle;
            totalTabletsLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            totalTabletsLabel.Location = new Point(0, 166);
            totalTabletsLabel.Name = "totalTabletsLabel";
            totalTabletsLabel.Size = new Size(203, 29);
            totalTabletsLabel.TabIndex = 1;
            totalTabletsLabel.Text = "50";
            totalTabletsLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // searchProductPanel
            // 
            searchProductPanel.BackColor = Color.FromArgb(224, 224, 224);
            searchProductPanel.Controls.Add(searchProductButton);
            searchProductPanel.Controls.Add(searchProductTextBox);
            searchProductPanel.Controls.Add(searchProductlLabel);
            searchProductPanel.Location = new Point(287, 316);
            searchProductPanel.Margin = new Padding(3, 4, 3, 4);
            searchProductPanel.Name = "searchProductPanel";
            searchProductPanel.Size = new Size(1065, 75);
            searchProductPanel.TabIndex = 10;
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
            searchProductButton.Location = new Point(953, 24);
            searchProductButton.Name = "searchProductButton";
            searchProductButton.Size = new Size(52, 36);
            searchProductButton.TabIndex = 11;
            searchProductButton.UseVisualStyleBackColor = false;
            searchProductButton.Click += searchProductButton_Click;
            // 
            // searchProductTextBox
            // 
            searchProductTextBox.BorderStyle = BorderStyle.FixedSingle;
            searchProductTextBox.Location = new Point(255, 33);
            searchProductTextBox.Name = "searchProductTextBox";
            searchProductTextBox.Size = new Size(664, 27);
            searchProductTextBox.TabIndex = 10;
            searchProductTextBox.TextChanged += searchProductTextBox_TextChanged;
            searchProductTextBox.KeyDown += searchProductTextBox_KeyDown;
            // 
            // searchProductlLabel
            // 
            searchProductlLabel.AutoSize = true;
            searchProductlLabel.BackColor = Color.FromArgb(224, 224, 224);
            searchProductlLabel.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchProductlLabel.ForeColor = SystemColors.ActiveCaptionText;
            searchProductlLabel.Location = new Point(22, 29);
            searchProductlLabel.Name = "searchProductlLabel";
            searchProductlLabel.Size = new Size(215, 31);
            searchProductlLabel.TabIndex = 0;
            searchProductlLabel.Text = "Buscar Producto";
            // 
            // showAllProductsButton
            // 
            showAllProductsButton.BackColor = Color.FromArgb(0, 166, 225);
            showAllProductsButton.FlatStyle = FlatStyle.Popup;
            showAllProductsButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            showAllProductsButton.ForeColor = Color.White;
            showAllProductsButton.IconChar = FontAwesome.Sharp.IconChar.Eye;
            showAllProductsButton.IconColor = Color.Gainsboro;
            showAllProductsButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            showAllProductsButton.ImageAlign = ContentAlignment.MiddleLeft;
            showAllProductsButton.Location = new Point(59, 316);
            showAllProductsButton.Name = "showAllProductsButton";
            showAllProductsButton.Size = new Size(151, 45);
            showAllProductsButton.TabIndex = 17;
            showAllProductsButton.Text = "ver todo";
            showAllProductsButton.TextAlign = ContentAlignment.MiddleRight;
            showAllProductsButton.UseVisualStyleBackColor = false;
            showAllProductsButton.Click += showAllProductsButton_Click;
            // 
            // InventoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1588, 1055);
            Controls.Add(showAllProductsButton);
            Controls.Add(searchProductPanel);
            Controls.Add(categoryGroupBox);
            Controls.Add(inventoryDataGridView);
            Margin = new Padding(3, 4, 3, 4);
            Name = "InventoryForm";
            Text = "InventoryForm";
            ((System.ComponentModel.ISupportInitialize)inventoryDataGridView).EndInit();
            categoryGroupBox.ResumeLayout(false);
            accesoriesGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)accesoriesPictureBox).EndInit();
            pcGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pcPictureBox).EndInit();
            LaptopGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)laptopPictureBox).EndInit();
            movilGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)movilPictureBox).EndInit();
            TabletsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tabletsPictureBox).EndInit();
            searchProductPanel.ResumeLayout(false);
            searchProductPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView inventoryDataGridView;
        private GroupBox categoryGroupBox;
        private PictureBox tabletsPictureBox;
        private GroupBox TabletsGroupBox;
        private Label tabletsLabel;
        private Label totalTabletsLabel;
        private GroupBox pcGroupBox;
        private Label pcLabel;
        private PictureBox pcPictureBox;
        private Label pcTotalLabel;
        private GroupBox LaptopGroupBox;
        private Label laptosLabel;
        private PictureBox laptopPictureBox;
        private Label totalLaptosLabel;
        private GroupBox movilGroupBox;
        private Label movilesLabel;
        private PictureBox movilPictureBox;
        private Label totalMovilesLabel;
        private GroupBox accesoriesGroupBox;
        private Label AccesoryLabel;
        private PictureBox accesoriesPictureBox;
        private Label totalAccesoriesLabel;
        private FontAwesome.Sharp.IconButton showAccesoriesButton;
        private FontAwesome.Sharp.IconButton showLaptopsButton;
        private FontAwesome.Sharp.IconButton showMovilesButton;
        private FontAwesome.Sharp.IconButton showTabletsButton;
        private Panel searchProductPanel;
        private FontAwesome.Sharp.IconButton searchProductButton;
        private TextBox searchProductTextBox;
        private Label searchProductlLabel;
        private FontAwesome.Sharp.IconButton showPcButton;
        private FontAwesome.Sharp.IconButton showAllProductsButton;
    }
}