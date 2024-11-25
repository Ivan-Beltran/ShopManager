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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsControl));
            pictureBox1 = new PictureBox();
            Tittle = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            CantnumericUpDown = new NumericUpDown();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CantnumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(25, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(313, 273);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Tittle
            // 
            Tittle.AutoSize = true;
            Tittle.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Tittle.ForeColor = SystemColors.ControlLightLight;
            Tittle.Location = new Point(363, 12);
            Tittle.Name = "Tittle";
            Tittle.Size = new Size(183, 50);
            Tittle.TabIndex = 1;
            Tittle.Text = "Producto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(363, 74);
            label2.Name = "label2";
            label2.Size = new Size(96, 31);
            label2.TabIndex = 2;
            label2.Text = "$ precio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(363, 135);
            label3.Name = "label3";
            label3.Size = new Size(134, 31);
            label3.TabIndex = 3;
            label3.Text = "Descripcion";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(363, 246);
            button1.Name = "button1";
            button1.Size = new Size(220, 43);
            button1.TabIndex = 4;
            button1.Text = "Comprar ahora";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(604, 246);
            button2.Name = "button2";
            button2.Size = new Size(225, 43);
            button2.TabIndex = 5;
            button2.Text = "Agregar al carrito";
            button2.UseVisualStyleBackColor = true;
            // 
            // CantnumericUpDown
            // 
            CantnumericUpDown.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CantnumericUpDown.Location = new Point(526, 201);
            CantnumericUpDown.Name = "CantnumericUpDown";
            CantnumericUpDown.Size = new Size(55, 38);
            CantnumericUpDown.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(363, 198);
            label1.Name = "label1";
            label1.Size = new Size(142, 38);
            label1.TabIndex = 7;
            label1.Text = "Cantidad:";
            // 
            // ProductsControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(label1);
            Controls.Add(CantnumericUpDown);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Tittle);
            Controls.Add(pictureBox1);
            Name = "ProductsControl";
            Size = new Size(860, 310);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)CantnumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label Tittle;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        private NumericUpDown CantnumericUpDown;
        private Label label1;
    }
}
