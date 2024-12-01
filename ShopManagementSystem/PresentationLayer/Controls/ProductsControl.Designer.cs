namespace PresentationLayer.Controls
{
    partial class ProductsControl
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            productPictureBox = new PictureBox();
            brandLabel = new Label();
            priceLabel = new Label();
            modelLabel = new Label();
            addShoppingCarButton = new Button();
            quantitynumericUpDown = new NumericUpDown();
            quntatityLabel = new Label();
            versionLabel = new Label();
            colorLabel = new Label();
            colorTittleLabel = new Label();
            brandTittlelabel = new Label();
            modelTittleLabel = new Label();
            priceTittleLabel = new Label();
            tittleenableQuantityLabel = new Label();
            enableQuanatityLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)productPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)quantitynumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // productPictureBox
            // 
            productPictureBox.BackColor = Color.Honeydew;
            productPictureBox.Location = new Point(17, 17);
            productPictureBox.Name = "productPictureBox";
            productPictureBox.Size = new Size(281, 241);
            productPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            productPictureBox.TabIndex = 0;
            productPictureBox.TabStop = false;
            // 
            // brandLabel
            // 
            brandLabel.AutoSize = true;
            brandLabel.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            brandLabel.ForeColor = SystemColors.ControlLightLight;
            brandLabel.Location = new Point(327, 4);
            brandLabel.Name = "brandLabel";
            brandLabel.Size = new Size(183, 50);
            brandLabel.TabIndex = 1;
            brandLabel.Text = "Producto";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            priceLabel.ForeColor = SystemColors.ControlLightLight;
            priceLabel.Location = new Point(427, 207);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(96, 31);
            priceLabel.TabIndex = 2;
            priceLabel.Text = "$ precio";
            // 
            // modelLabel
            // 
            modelLabel.AutoSize = true;
            modelLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            modelLabel.ForeColor = SystemColors.ControlLightLight;
            modelLabel.Location = new Point(431, 54);
            modelLabel.Name = "modelLabel";
            modelLabel.Size = new Size(92, 31);
            modelLabel.TabIndex = 3;
            modelLabel.Text = "modelo";
            // 
            // addShoppingCarButton
            // 
            addShoppingCarButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addShoppingCarButton.ForeColor = Color.Teal;
            addShoppingCarButton.Location = new Point(462, 280);
            addShoppingCarButton.Name = "addShoppingCarButton";
            addShoppingCarButton.Size = new Size(273, 48);
            addShoppingCarButton.TabIndex = 5;
            addShoppingCarButton.Text = "Agregar al carrito";
            addShoppingCarButton.UseVisualStyleBackColor = true;
            addShoppingCarButton.Click += addShoppingCarButton_Click;
            // 
            // quantitynumericUpDown
            // 
            quantitynumericUpDown.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            quantitynumericUpDown.Location = new Point(151, 284);
            quantitynumericUpDown.Name = "quantitynumericUpDown";
            quantitynumericUpDown.Size = new Size(55, 38);
            quantitynumericUpDown.TabIndex = 6;
            // 
            // quntatityLabel
            // 
            quntatityLabel.AutoSize = true;
            quntatityLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            quntatityLabel.ForeColor = SystemColors.ControlLightLight;
            quntatityLabel.Location = new Point(3, 280);
            quntatityLabel.Name = "quntatityLabel";
            quntatityLabel.Size = new Size(142, 38);
            quntatityLabel.TabIndex = 7;
            quntatityLabel.Text = "Cantidad:";
            // 
            // versionLabel
            // 
            versionLabel.AutoSize = true;
            versionLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            versionLabel.ForeColor = SystemColors.ControlLightLight;
            versionLabel.Location = new Point(431, 106);
            versionLabel.Name = "versionLabel";
            versionLabel.Size = new Size(87, 31);
            versionLabel.TabIndex = 8;
            versionLabel.Text = "version";
            // 
            // colorLabel
            // 
            colorLabel.AutoSize = true;
            colorLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            colorLabel.ForeColor = SystemColors.ControlLightLight;
            colorLabel.Location = new Point(431, 157);
            colorLabel.Name = "colorLabel";
            colorLabel.Size = new Size(65, 31);
            colorLabel.TabIndex = 9;
            colorLabel.Text = "color";
            // 
            // colorTittleLabel
            // 
            colorTittleLabel.AutoSize = true;
            colorTittleLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            colorTittleLabel.ForeColor = SystemColors.ControlLightLight;
            colorTittleLabel.Location = new Point(331, 157);
            colorTittleLabel.Name = "colorTittleLabel";
            colorTittleLabel.Size = new Size(79, 31);
            colorTittleLabel.TabIndex = 13;
            colorTittleLabel.Text = "Color :";
            // 
            // brandTittlelabel
            // 
            brandTittlelabel.AutoSize = true;
            brandTittlelabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            brandTittlelabel.ForeColor = SystemColors.ControlLightLight;
            brandTittlelabel.Location = new Point(331, 106);
            brandTittlelabel.Name = "brandTittlelabel";
            brandTittlelabel.Size = new Size(100, 31);
            brandTittlelabel.TabIndex = 12;
            brandTittlelabel.Text = "Version :";
            // 
            // modelTittleLabel
            // 
            modelTittleLabel.AutoSize = true;
            modelTittleLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            modelTittleLabel.ForeColor = SystemColors.ControlLightLight;
            modelTittleLabel.Location = new Point(327, 54);
            modelTittleLabel.Name = "modelTittleLabel";
            modelTittleLabel.Size = new Size(104, 31);
            modelTittleLabel.TabIndex = 11;
            modelTittleLabel.Text = "Modelo :";
            // 
            // priceTittleLabel
            // 
            priceTittleLabel.AutoSize = true;
            priceTittleLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            priceTittleLabel.ForeColor = SystemColors.ControlLightLight;
            priceTittleLabel.Location = new Point(327, 207);
            priceTittleLabel.Name = "priceTittleLabel";
            priceTittleLabel.Size = new Size(88, 31);
            priceTittleLabel.TabIndex = 10;
            priceTittleLabel.Text = "Precio :";
            // 
            // tittleenableQuantityLabel
            // 
            tittleenableQuantityLabel.AutoSize = true;
            tittleenableQuantityLabel.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold);
            tittleenableQuantityLabel.ForeColor = SystemColors.ControlLightLight;
            tittleenableQuantityLabel.Location = new Point(219, 287);
            tittleenableQuantityLabel.Name = "tittleenableQuantityLabel";
            tittleenableQuantityLabel.Size = new Size(191, 32);
            tittleenableQuantityLabel.TabIndex = 15;
            tittleenableQuantityLabel.Text = "Disponibles :";
            // 
            // enableQuanatityLabel
            // 
            enableQuanatityLabel.AutoSize = true;
            enableQuanatityLabel.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold);
            enableQuanatityLabel.ForeColor = SystemColors.ControlLightLight;
            enableQuanatityLabel.Location = new Point(416, 291);
            enableQuanatityLabel.Name = "enableQuanatityLabel";
            enableQuanatityLabel.Size = new Size(31, 32);
            enableQuanatityLabel.TabIndex = 14;
            enableQuanatityLabel.Text = "0";
            // 
            // ProductsControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            Controls.Add(tittleenableQuantityLabel);
            Controls.Add(enableQuanatityLabel);
            Controls.Add(colorTittleLabel);
            Controls.Add(brandTittlelabel);
            Controls.Add(modelTittleLabel);
            Controls.Add(priceTittleLabel);
            Controls.Add(colorLabel);
            Controls.Add(versionLabel);
            Controls.Add(quntatityLabel);
            Controls.Add(quantitynumericUpDown);
            Controls.Add(addShoppingCarButton);
            Controls.Add(modelLabel);
            Controls.Add(priceLabel);
            Controls.Add(brandLabel);
            Controls.Add(productPictureBox);
            Margin = new Padding(20, 10, 20, 10);
            MaximumSize = new Size(750, 350);
            MinimumSize = new Size(750, 350);
            Name = "ProductsControl";
            Size = new Size(750, 350);
            ((System.ComponentModel.ISupportInitialize)productPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)quantitynumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox productPictureBox;
        private Label brandLabel;
        private Label priceLabel;
        private Label modelLabel;
        private Button addShoppingCarButton;
        private NumericUpDown quantitynumericUpDown;
        private Label quntatityLabel;
        private Label versionLabel;
        private Label colorLabel;
        private Label colorTittleLabel;
        private Label brandTittlelabel;
        private Label modelTittleLabel;
        private Label priceTittleLabel;
        private Label tittleenableQuantityLabel;
        private Label enableQuanatityLabel;
    }
}
