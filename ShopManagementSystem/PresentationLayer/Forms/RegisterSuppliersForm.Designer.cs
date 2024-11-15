namespace PresentationLayer.Forms
{
    partial class RegisterSuppliersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterSuppliersForm));
            suppliersLabel = new Label();
            nameSupplierLabel = new Label();
            txtNameSupplier = new TextBox();
            txtPhoneSupplier = new TextBox();
            phoneSupplierLabel = new Label();
            txtEmailSupplier = new TextBox();
            emailSupplierLabel = new Label();
            txtAddressSupplier = new TextBox();
            addressSupplierLabel = new Label();
            registerSupplierButton = new FontAwesome.Sharp.IconButton();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // suppliersLabel
            // 
            suppliersLabel.AutoSize = true;
            suppliersLabel.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            suppliersLabel.Location = new Point(520, 48);
            suppliersLabel.Name = "suppliersLabel";
            suppliersLabel.Size = new Size(198, 25);
            suppliersLabel.TabIndex = 1;
            suppliersLabel.Text = "Registrar Proveedor";
            // 
            // nameSupplierLabel
            // 
            nameSupplierLabel.AutoSize = true;
            nameSupplierLabel.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameSupplierLabel.Location = new Point(481, 146);
            nameSupplierLabel.Name = "nameSupplierLabel";
            nameSupplierLabel.Size = new Size(67, 20);
            nameSupplierLabel.TabIndex = 2;
            nameSupplierLabel.Text = "Nombre:";
            // 
            // txtNameSupplier
            // 
            txtNameSupplier.Location = new Point(617, 138);
            txtNameSupplier.Name = "txtNameSupplier";
            txtNameSupplier.Size = new Size(213, 23);
            txtNameSupplier.TabIndex = 3;
            // 
            // txtPhoneSupplier
            // 
            txtPhoneSupplier.Location = new Point(617, 206);
            txtPhoneSupplier.Name = "txtPhoneSupplier";
            txtPhoneSupplier.Size = new Size(213, 23);
            txtPhoneSupplier.TabIndex = 5;
            // 
            // phoneSupplierLabel
            // 
            phoneSupplierLabel.AutoSize = true;
            phoneSupplierLabel.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phoneSupplierLabel.Location = new Point(481, 209);
            phoneSupplierLabel.Name = "phoneSupplierLabel";
            phoneSupplierLabel.Size = new Size(71, 20);
            phoneSupplierLabel.TabIndex = 4;
            phoneSupplierLabel.Text = "Teléfono:";
            // 
            // txtEmailSupplier
            // 
            txtEmailSupplier.Location = new Point(617, 276);
            txtEmailSupplier.Name = "txtEmailSupplier";
            txtEmailSupplier.Size = new Size(213, 23);
            txtEmailSupplier.TabIndex = 7;
            // 
            // emailSupplierLabel
            // 
            emailSupplierLabel.AutoSize = true;
            emailSupplierLabel.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailSupplierLabel.Location = new Point(481, 279);
            emailSupplierLabel.Name = "emailSupplierLabel";
            emailSupplierLabel.Size = new Size(51, 20);
            emailSupplierLabel.TabIndex = 6;
            emailSupplierLabel.Text = "Gmail:";
            // 
            // txtAddressSupplier
            // 
            txtAddressSupplier.Location = new Point(617, 349);
            txtAddressSupplier.Name = "txtAddressSupplier";
            txtAddressSupplier.Size = new Size(213, 23);
            txtAddressSupplier.TabIndex = 9;
            // 
            // addressSupplierLabel
            // 
            addressSupplierLabel.AutoSize = true;
            addressSupplierLabel.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addressSupplierLabel.Location = new Point(481, 352);
            addressSupplierLabel.Name = "addressSupplierLabel";
            addressSupplierLabel.Size = new Size(75, 20);
            addressSupplierLabel.TabIndex = 8;
            addressSupplierLabel.Text = "Dirección:";
            // 
            // registerSupplierButton
            // 
            registerSupplierButton.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            registerSupplierButton.IconChar = FontAwesome.Sharp.IconChar.Save;
            registerSupplierButton.IconColor = Color.Black;
            registerSupplierButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            registerSupplierButton.IconSize = 32;
            registerSupplierButton.ImageAlign = ContentAlignment.MiddleLeft;
            registerSupplierButton.Location = new Point(566, 431);
            registerSupplierButton.Name = "registerSupplierButton";
            registerSupplierButton.Size = new Size(152, 37);
            registerSupplierButton.TabIndex = 10;
            registerSupplierButton.Text = "Guardar";
            registerSupplierButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(78, 125);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(329, 275);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // RegisterSuppliersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(994, 610);
            Controls.Add(pictureBox1);
            Controls.Add(registerSupplierButton);
            Controls.Add(txtAddressSupplier);
            Controls.Add(addressSupplierLabel);
            Controls.Add(txtEmailSupplier);
            Controls.Add(emailSupplierLabel);
            Controls.Add(txtPhoneSupplier);
            Controls.Add(phoneSupplierLabel);
            Controls.Add(txtNameSupplier);
            Controls.Add(nameSupplierLabel);
            Controls.Add(suppliersLabel);
            Name = "RegisterSuppliersForm";
            Text = "RegisterSuppliersForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label suppliersLabel;
        private Label nameSupplierLabel;
        private TextBox txtNameSupplier;
        private TextBox txtPhoneSupplier;
        private Label phoneSupplierLabel;
        private TextBox txtEmailSupplier;
        private Label emailSupplierLabel;
        private TextBox txtAddressSupplier;
        private Label addressSupplierLabel;
        private FontAwesome.Sharp.IconButton registerSupplierButton;
        private PictureBox pictureBox1;
    }
}