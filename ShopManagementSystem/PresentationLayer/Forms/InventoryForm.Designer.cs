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
            invetoryDataGridView = new DataGridView();
            categoryGroupBox = new GroupBox();
            accesoriesGroupBox = new GroupBox();
            showAccesoriesButton = new FontAwesome.Sharp.IconButton();
            label20 = new Label();
            AccesoryLabel = new Label();
            accesoriesPictureBox = new PictureBox();
            label22 = new Label();
            totalAccesoriesLabel = new Label();
            quantityAccesoriesLabel = new Label();
            pcGroupBox = new GroupBox();
            showPcButton = new FontAwesome.Sharp.IconButton();
            pcDownLabel = new Label();
            pcLabel = new Label();
            pcPictureBox = new PictureBox();
            pcTopLineLabel = new Label();
            pcTotalLabel = new Label();
            pcQuantityLabel = new Label();
            LaptopGroupBox = new GroupBox();
            showLaptopsButton = new FontAwesome.Sharp.IconButton();
            laptosLineDownLabel = new Label();
            laptosLabel = new Label();
            laptopPictureBox = new PictureBox();
            laptosLineUpLabel = new Label();
            totalLaptosLabel = new Label();
            quntaityLaptopsLabel = new Label();
            movilGroupBox = new GroupBox();
            showMovilesButton = new FontAwesome.Sharp.IconButton();
            label5 = new Label();
            movilesLabel = new Label();
            movilPictureBox = new PictureBox();
            label7 = new Label();
            totalMovilesLabel = new Label();
            quantityMovilesLabel = new Label();
            TabletsGroupBox = new GroupBox();
            showTabletsButton = new FontAwesome.Sharp.IconButton();
            label4 = new Label();
            tabletsLabel = new Label();
            tabletsPictureBox = new PictureBox();
            tabletsLineUPlabel = new Label();
            totalTabletsLabel = new Label();
            quantityTabletsLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)invetoryDataGridView).BeginInit();
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
            SuspendLayout();
            // 
            // invetoryDataGridView
            // 
            invetoryDataGridView.BackgroundColor = Color.Azure;
            invetoryDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            invetoryDataGridView.Location = new Point(31, 430);
            invetoryDataGridView.Margin = new Padding(3, 4, 3, 4);
            invetoryDataGridView.Name = "invetoryDataGridView";
            invetoryDataGridView.RowHeadersWidth = 51;
            invetoryDataGridView.Size = new Size(1372, 331);
            invetoryDataGridView.TabIndex = 0;
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
            categoryGroupBox.Size = new Size(1488, 323);
            categoryGroupBox.TabIndex = 9;
            categoryGroupBox.TabStop = false;
            categoryGroupBox.Enter += groupBoxInventory_Enter;
            // 
            // accesoriesGroupBox
            // 
            accesoriesGroupBox.BackColor = Color.White;
            accesoriesGroupBox.Controls.Add(showAccesoriesButton);
            accesoriesGroupBox.Controls.Add(label20);
            accesoriesGroupBox.Controls.Add(AccesoryLabel);
            accesoriesGroupBox.Controls.Add(accesoriesPictureBox);
            accesoriesGroupBox.Controls.Add(label22);
            accesoriesGroupBox.Controls.Add(totalAccesoriesLabel);
            accesoriesGroupBox.Controls.Add(quantityAccesoriesLabel);
            accesoriesGroupBox.Location = new Point(1236, 27);
            accesoriesGroupBox.Name = "accesoriesGroupBox";
            accesoriesGroupBox.Size = new Size(216, 247);
            accesoriesGroupBox.TabIndex = 21;
            accesoriesGroupBox.TabStop = false;
            // 
            // showAccesoriesButton
            // 
            showAccesoriesButton.BackColor = Color.FromArgb(0, 166, 225);
            showAccesoriesButton.FlatStyle = FlatStyle.Popup;
            showAccesoriesButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            showAccesoriesButton.ForeColor = Color.White;
            showAccesoriesButton.IconChar = FontAwesome.Sharp.IconChar.Eye;
            showAccesoriesButton.IconColor = Color.Gainsboro;
            showAccesoriesButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            showAccesoriesButton.ImageAlign = ContentAlignment.MiddleLeft;
            showAccesoriesButton.Location = new Point(0, 199);
            showAccesoriesButton.Name = "showAccesoriesButton";
            showAccesoriesButton.Size = new Size(216, 47);
            showAccesoriesButton.TabIndex = 19;
            showAccesoriesButton.Text = "ver detalles";
            showAccesoriesButton.UseVisualStyleBackColor = false;
            // 
            // label20
            // 
            label20.BorderStyle = BorderStyle.FixedSingle;
            label20.Location = new Point(0, 164);
            label20.Name = "label20";
            label20.Size = new Size(216, 2);
            label20.TabIndex = 18;
            // 
            // AccesoryLabel
            // 
            AccesoryLabel.BackColor = Color.White;
            AccesoryLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            AccesoryLabel.Location = new Point(0, 134);
            AccesoryLabel.Name = "AccesoryLabel";
            AccesoryLabel.Size = new Size(216, 31);
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
            // label22
            // 
            label22.BorderStyle = BorderStyle.FixedSingle;
            label22.Location = new Point(0, 131);
            label22.Name = "label22";
            label22.Size = new Size(216, 2);
            label22.TabIndex = 17;
            // 
            // totalAccesoriesLabel
            // 
            totalAccesoriesLabel.BackColor = Color.White;
            totalAccesoriesLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            totalAccesoriesLabel.Location = new Point(123, 166);
            totalAccesoriesLabel.Name = "totalAccesoriesLabel";
            totalAccesoriesLabel.Size = new Size(62, 30);
            totalAccesoriesLabel.TabIndex = 1;
            totalAccesoriesLabel.Text = "50";
            totalAccesoriesLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // quantityAccesoriesLabel
            // 
            quantityAccesoriesLabel.BackColor = Color.White;
            quantityAccesoriesLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            quantityAccesoriesLabel.Location = new Point(26, 166);
            quantityAccesoriesLabel.Name = "quantityAccesoriesLabel";
            quantityAccesoriesLabel.Size = new Size(107, 30);
            quantityAccesoriesLabel.TabIndex = 0;
            quantityAccesoriesLabel.Text = "Cantidad : ";
            quantityAccesoriesLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pcGroupBox
            // 
            pcGroupBox.BackColor = Color.White;
            pcGroupBox.Controls.Add(showPcButton);
            pcGroupBox.Controls.Add(pcDownLabel);
            pcGroupBox.Controls.Add(pcLabel);
            pcGroupBox.Controls.Add(pcPictureBox);
            pcGroupBox.Controls.Add(pcTopLineLabel);
            pcGroupBox.Controls.Add(pcTotalLabel);
            pcGroupBox.Controls.Add(pcQuantityLabel);
            pcGroupBox.Location = new Point(28, 27);
            pcGroupBox.Name = "pcGroupBox";
            pcGroupBox.Size = new Size(216, 247);
            pcGroupBox.TabIndex = 20;
            pcGroupBox.TabStop = false;
            // 
            // showPcButton
            // 
            showPcButton.BackColor = Color.FromArgb(0, 166, 225);
            showPcButton.FlatStyle = FlatStyle.Popup;
            showPcButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            showPcButton.ForeColor = Color.White;
            showPcButton.IconChar = FontAwesome.Sharp.IconChar.Eye;
            showPcButton.IconColor = Color.Gainsboro;
            showPcButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            showPcButton.ImageAlign = ContentAlignment.MiddleLeft;
            showPcButton.Location = new Point(0, 199);
            showPcButton.Name = "showPcButton";
            showPcButton.Size = new Size(216, 47);
            showPcButton.TabIndex = 16;
            showPcButton.Text = "ver detalles";
            showPcButton.UseVisualStyleBackColor = false;
            // 
            // pcDownLabel
            // 
            pcDownLabel.BorderStyle = BorderStyle.FixedSingle;
            pcDownLabel.Location = new Point(0, 164);
            pcDownLabel.Name = "pcDownLabel";
            pcDownLabel.Size = new Size(216, 2);
            pcDownLabel.TabIndex = 18;
            // 
            // pcLabel
            // 
            pcLabel.BackColor = Color.White;
            pcLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            pcLabel.Location = new Point(0, 134);
            pcLabel.Name = "pcLabel";
            pcLabel.Size = new Size(216, 31);
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
            pcPictureBox.Size = new Size(217, 128);
            pcPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pcPictureBox.TabIndex = 12;
            pcPictureBox.TabStop = false;
            // 
            // pcTopLineLabel
            // 
            pcTopLineLabel.BorderStyle = BorderStyle.FixedSingle;
            pcTopLineLabel.Location = new Point(0, 131);
            pcTopLineLabel.Name = "pcTopLineLabel";
            pcTopLineLabel.Size = new Size(216, 2);
            pcTopLineLabel.TabIndex = 17;
            // 
            // pcTotalLabel
            // 
            pcTotalLabel.BackColor = Color.White;
            pcTotalLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            pcTotalLabel.Location = new Point(123, 166);
            pcTotalLabel.Name = "pcTotalLabel";
            pcTotalLabel.Size = new Size(62, 30);
            pcTotalLabel.TabIndex = 1;
            pcTotalLabel.Text = "50";
            pcTotalLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pcQuantityLabel
            // 
            pcQuantityLabel.BackColor = Color.White;
            pcQuantityLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            pcQuantityLabel.Location = new Point(26, 166);
            pcQuantityLabel.Name = "pcQuantityLabel";
            pcQuantityLabel.Size = new Size(107, 30);
            pcQuantityLabel.TabIndex = 0;
            pcQuantityLabel.Text = "Cantidad : ";
            pcQuantityLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LaptopGroupBox
            // 
            LaptopGroupBox.BackColor = Color.White;
            LaptopGroupBox.Controls.Add(showLaptopsButton);
            LaptopGroupBox.Controls.Add(laptosLineDownLabel);
            LaptopGroupBox.Controls.Add(laptosLabel);
            LaptopGroupBox.Controls.Add(laptopPictureBox);
            LaptopGroupBox.Controls.Add(laptosLineUpLabel);
            LaptopGroupBox.Controls.Add(totalLaptosLabel);
            LaptopGroupBox.Controls.Add(quntaityLaptopsLabel);
            LaptopGroupBox.Location = new Point(305, 28);
            LaptopGroupBox.Name = "LaptopGroupBox";
            LaptopGroupBox.Size = new Size(216, 247);
            LaptopGroupBox.TabIndex = 19;
            LaptopGroupBox.TabStop = false;
            // 
            // showLaptopsButton
            // 
            showLaptopsButton.BackColor = Color.FromArgb(0, 166, 225);
            showLaptopsButton.FlatStyle = FlatStyle.Popup;
            showLaptopsButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            showLaptopsButton.ForeColor = Color.White;
            showLaptopsButton.IconChar = FontAwesome.Sharp.IconChar.Eye;
            showLaptopsButton.IconColor = Color.Gainsboro;
            showLaptopsButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            showLaptopsButton.ImageAlign = ContentAlignment.MiddleLeft;
            showLaptopsButton.Location = new Point(0, 200);
            showLaptopsButton.Name = "showLaptopsButton";
            showLaptopsButton.Size = new Size(216, 47);
            showLaptopsButton.TabIndex = 19;
            showLaptopsButton.Text = "ver detalles";
            showLaptopsButton.UseVisualStyleBackColor = false;
            // 
            // laptosLineDownLabel
            // 
            laptosLineDownLabel.BorderStyle = BorderStyle.FixedSingle;
            laptosLineDownLabel.Location = new Point(0, 164);
            laptosLineDownLabel.Name = "laptosLineDownLabel";
            laptosLineDownLabel.Size = new Size(216, 2);
            laptosLineDownLabel.TabIndex = 18;
            // 
            // laptosLabel
            // 
            laptosLabel.BackColor = Color.White;
            laptosLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            laptosLabel.Location = new Point(0, 134);
            laptosLabel.Name = "laptosLabel";
            laptosLabel.Size = new Size(216, 31);
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
            laptopPictureBox.Size = new Size(217, 128);
            laptopPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            laptopPictureBox.TabIndex = 12;
            laptopPictureBox.TabStop = false;
            // 
            // laptosLineUpLabel
            // 
            laptosLineUpLabel.BorderStyle = BorderStyle.FixedSingle;
            laptosLineUpLabel.Location = new Point(0, 131);
            laptosLineUpLabel.Name = "laptosLineUpLabel";
            laptosLineUpLabel.Size = new Size(216, 2);
            laptosLineUpLabel.TabIndex = 17;
            // 
            // totalLaptosLabel
            // 
            totalLaptosLabel.BackColor = Color.White;
            totalLaptosLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            totalLaptosLabel.Location = new Point(123, 166);
            totalLaptosLabel.Name = "totalLaptosLabel";
            totalLaptosLabel.Size = new Size(62, 30);
            totalLaptosLabel.TabIndex = 1;
            totalLaptosLabel.Text = "50";
            totalLaptosLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // quntaityLaptopsLabel
            // 
            quntaityLaptopsLabel.BackColor = Color.White;
            quntaityLaptopsLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            quntaityLaptopsLabel.Location = new Point(26, 166);
            quntaityLaptopsLabel.Name = "quntaityLaptopsLabel";
            quntaityLaptopsLabel.Size = new Size(107, 30);
            quntaityLaptopsLabel.TabIndex = 0;
            quntaityLaptopsLabel.Text = "Cantidad : ";
            quntaityLaptopsLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // movilGroupBox
            // 
            movilGroupBox.BackColor = Color.White;
            movilGroupBox.Controls.Add(showMovilesButton);
            movilGroupBox.Controls.Add(label5);
            movilGroupBox.Controls.Add(movilesLabel);
            movilGroupBox.Controls.Add(movilPictureBox);
            movilGroupBox.Controls.Add(label7);
            movilGroupBox.Controls.Add(totalMovilesLabel);
            movilGroupBox.Controls.Add(quantityMovilesLabel);
            movilGroupBox.Location = new Point(621, 28);
            movilGroupBox.Name = "movilGroupBox";
            movilGroupBox.Size = new Size(216, 247);
            movilGroupBox.TabIndex = 18;
            movilGroupBox.TabStop = false;
            // 
            // showMovilesButton
            // 
            showMovilesButton.BackColor = Color.FromArgb(0, 166, 225);
            showMovilesButton.FlatStyle = FlatStyle.Popup;
            showMovilesButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            showMovilesButton.ForeColor = Color.White;
            showMovilesButton.IconChar = FontAwesome.Sharp.IconChar.Eye;
            showMovilesButton.IconColor = Color.Gainsboro;
            showMovilesButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            showMovilesButton.ImageAlign = ContentAlignment.MiddleLeft;
            showMovilesButton.Location = new Point(0, 198);
            showMovilesButton.Name = "showMovilesButton";
            showMovilesButton.Size = new Size(216, 47);
            showMovilesButton.TabIndex = 19;
            showMovilesButton.Text = "ver detalles";
            showMovilesButton.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Location = new Point(0, 164);
            label5.Name = "label5";
            label5.Size = new Size(216, 2);
            label5.TabIndex = 18;
            // 
            // movilesLabel
            // 
            movilesLabel.BackColor = Color.White;
            movilesLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            movilesLabel.Location = new Point(0, 134);
            movilesLabel.Name = "movilesLabel";
            movilesLabel.Size = new Size(216, 31);
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
            // label7
            // 
            label7.BorderStyle = BorderStyle.FixedSingle;
            label7.Location = new Point(0, 131);
            label7.Name = "label7";
            label7.Size = new Size(216, 2);
            label7.TabIndex = 17;
            // 
            // totalMovilesLabel
            // 
            totalMovilesLabel.BackColor = Color.White;
            totalMovilesLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            totalMovilesLabel.Location = new Point(123, 166);
            totalMovilesLabel.Name = "totalMovilesLabel";
            totalMovilesLabel.Size = new Size(62, 30);
            totalMovilesLabel.TabIndex = 1;
            totalMovilesLabel.Text = "50";
            totalMovilesLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // quantityMovilesLabel
            // 
            quantityMovilesLabel.BackColor = Color.White;
            quantityMovilesLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            quantityMovilesLabel.Location = new Point(26, 166);
            quantityMovilesLabel.Name = "quantityMovilesLabel";
            quantityMovilesLabel.Size = new Size(107, 30);
            quantityMovilesLabel.TabIndex = 0;
            quantityMovilesLabel.Text = "Cantidad : ";
            quantityMovilesLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TabletsGroupBox
            // 
            TabletsGroupBox.BackColor = Color.White;
            TabletsGroupBox.Controls.Add(showTabletsButton);
            TabletsGroupBox.Controls.Add(label4);
            TabletsGroupBox.Controls.Add(tabletsLabel);
            TabletsGroupBox.Controls.Add(tabletsPictureBox);
            TabletsGroupBox.Controls.Add(tabletsLineUPlabel);
            TabletsGroupBox.Controls.Add(totalTabletsLabel);
            TabletsGroupBox.Controls.Add(quantityTabletsLabel);
            TabletsGroupBox.Location = new Point(945, 28);
            TabletsGroupBox.Name = "TabletsGroupBox";
            TabletsGroupBox.Size = new Size(216, 247);
            TabletsGroupBox.TabIndex = 17;
            TabletsGroupBox.TabStop = false;
            // 
            // showTabletsButton
            // 
            showTabletsButton.BackColor = Color.FromArgb(0, 166, 225);
            showTabletsButton.FlatStyle = FlatStyle.Popup;
            showTabletsButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            showTabletsButton.ForeColor = Color.White;
            showTabletsButton.IconChar = FontAwesome.Sharp.IconChar.Eye;
            showTabletsButton.IconColor = Color.Gainsboro;
            showTabletsButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            showTabletsButton.ImageAlign = ContentAlignment.MiddleLeft;
            showTabletsButton.Location = new Point(0, 198);
            showTabletsButton.Name = "showTabletsButton";
            showTabletsButton.Size = new Size(216, 47);
            showTabletsButton.TabIndex = 19;
            showTabletsButton.Text = "ver detalles";
            showTabletsButton.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Location = new Point(0, 164);
            label4.Name = "label4";
            label4.Size = new Size(216, 2);
            label4.TabIndex = 18;
            // 
            // tabletsLabel
            // 
            tabletsLabel.BackColor = Color.White;
            tabletsLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            tabletsLabel.Location = new Point(0, 134);
            tabletsLabel.Name = "tabletsLabel";
            tabletsLabel.Size = new Size(216, 31);
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
            // tabletsLineUPlabel
            // 
            tabletsLineUPlabel.BorderStyle = BorderStyle.FixedSingle;
            tabletsLineUPlabel.Location = new Point(0, 131);
            tabletsLineUPlabel.Name = "tabletsLineUPlabel";
            tabletsLineUPlabel.Size = new Size(216, 2);
            tabletsLineUPlabel.TabIndex = 17;
            // 
            // totalTabletsLabel
            // 
            totalTabletsLabel.BackColor = Color.White;
            totalTabletsLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            totalTabletsLabel.Location = new Point(123, 166);
            totalTabletsLabel.Name = "totalTabletsLabel";
            totalTabletsLabel.Size = new Size(62, 30);
            totalTabletsLabel.TabIndex = 1;
            totalTabletsLabel.Text = "50";
            totalTabletsLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // quantityTabletsLabel
            // 
            quantityTabletsLabel.BackColor = Color.White;
            quantityTabletsLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            quantityTabletsLabel.Location = new Point(26, 166);
            quantityTabletsLabel.Name = "quantityTabletsLabel";
            quantityTabletsLabel.Size = new Size(107, 30);
            quantityTabletsLabel.TabIndex = 0;
            quantityTabletsLabel.Text = "Cantidad : ";
            quantityTabletsLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // InventoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1531, 956);
            Controls.Add(categoryGroupBox);
            Controls.Add(invetoryDataGridView);
            Margin = new Padding(3, 4, 3, 4);
            Name = "InventoryForm";
            Text = "InventoryForm";
            ((System.ComponentModel.ISupportInitialize)invetoryDataGridView).EndInit();
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
            ResumeLayout(false);
        }

        #endregion

        private DataGridView invetoryDataGridView;
        private GroupBox categoryGroupBox;
        private PictureBox tabletsPictureBox;
        private GroupBox TabletsGroupBox;
        private Label tabletsLabel;
        private Label totalTabletsLabel;
        private Label quantityTabletsLabel;
        private Label label4;
        private Label tabletsLineUPlabel;
        private GroupBox pcGroupBox;
        private Label pcDownLabel;
        private Label pcLabel;
        private PictureBox pcPictureBox;
        private Label pcTopLineLabel;
        private Label pcTotalLabel;
        private Label pcQuantityLabel;
        private GroupBox LaptopGroupBox;
        private Label laptosLineDownLabel;
        private Label laptosLabel;
        private PictureBox laptopPictureBox;
        private Label laptosLineUpLabel;
        private Label totalLaptosLabel;
        private Label quntaityLaptopsLabel;
        private GroupBox movilGroupBox;
        private Label label5;
        private Label movilesLabel;
        private PictureBox movilPictureBox;
        private Label label7;
        private Label totalMovilesLabel;
        private Label quantityMovilesLabel;
        private GroupBox accesoriesGroupBox;
        private Label label20;
        private Label AccesoryLabel;
        private PictureBox accesoriesPictureBox;
        private Label label22;
        private Label totalAccesoriesLabel;
        private Label quantityAccesoriesLabel;
        private FontAwesome.Sharp.IconButton showPcButton;
        private FontAwesome.Sharp.IconButton showAccesoriesButton;
        private FontAwesome.Sharp.IconButton showLaptopsButton;
        private FontAwesome.Sharp.IconButton showMovilesButton;
        private FontAwesome.Sharp.IconButton showTabletsButton;
    }
}