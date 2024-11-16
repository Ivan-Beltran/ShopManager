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
            suppliersLabel = new Label();
            nameSupplierLabel = new Label();
            nameSupplierTextBox = new TextBox();
            phoneSupplierTextBox = new TextBox();
            phoneSupplierLabel = new Label();
            emailSupplierTextBox = new TextBox();
            emailSupplierLabel = new Label();
            addressSupplierTextBox = new TextBox();
            addressSupplierLabel = new Label();
            registerSupplierButton = new FontAwesome.Sharp.IconButton();
            SupplierDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)SupplierDataGridView).BeginInit();
            SuspendLayout();
            // 
            // suppliersLabel
            // 
            suppliersLabel.AutoSize = true;
            suppliersLabel.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            suppliersLabel.Location = new Point(145, 67);
            suppliersLabel.Name = "suppliersLabel";
            suppliersLabel.Size = new Size(198, 25);
            suppliersLabel.TabIndex = 1;
            suppliersLabel.Text = "Registrar Proveedor";
            // 
            // nameSupplierLabel
            // 
            nameSupplierLabel.AutoSize = true;
            nameSupplierLabel.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameSupplierLabel.Location = new Point(106, 165);
            nameSupplierLabel.Name = "nameSupplierLabel";
            nameSupplierLabel.Size = new Size(67, 20);
            nameSupplierLabel.TabIndex = 2;
            nameSupplierLabel.Text = "Nombre:";
            // 
            // nameSupplierTextBox
            // 
            nameSupplierTextBox.Location = new Point(242, 157);
            nameSupplierTextBox.Name = "nameSupplierTextBox";
            nameSupplierTextBox.Size = new Size(213, 23);
            nameSupplierTextBox.TabIndex = 3;
            // 
            // phoneSupplierTextBox
            // 
            phoneSupplierTextBox.Location = new Point(242, 225);
            phoneSupplierTextBox.Name = "phoneSupplierTextBox";
            phoneSupplierTextBox.Size = new Size(213, 23);
            phoneSupplierTextBox.TabIndex = 5;
            // 
            // phoneSupplierLabel
            // 
            phoneSupplierLabel.AutoSize = true;
            phoneSupplierLabel.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phoneSupplierLabel.Location = new Point(106, 228);
            phoneSupplierLabel.Name = "phoneSupplierLabel";
            phoneSupplierLabel.Size = new Size(71, 20);
            phoneSupplierLabel.TabIndex = 4;
            phoneSupplierLabel.Text = "Teléfono:";
            // 
            // emailSupplierTextBox
            // 
            emailSupplierTextBox.Location = new Point(242, 295);
            emailSupplierTextBox.Name = "emailSupplierTextBox";
            emailSupplierTextBox.Size = new Size(213, 23);
            emailSupplierTextBox.TabIndex = 7;
            // 
            // emailSupplierLabel
            // 
            emailSupplierLabel.AutoSize = true;
            emailSupplierLabel.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailSupplierLabel.Location = new Point(106, 298);
            emailSupplierLabel.Name = "emailSupplierLabel";
            emailSupplierLabel.Size = new Size(51, 20);
            emailSupplierLabel.TabIndex = 6;
            emailSupplierLabel.Text = "Gmail:";
            // 
            // addressSupplierTextBox
            // 
            addressSupplierTextBox.Location = new Point(242, 368);
            addressSupplierTextBox.Name = "addressSupplierTextBox";
            addressSupplierTextBox.Size = new Size(213, 23);
            addressSupplierTextBox.TabIndex = 9;
            // 
            // addressSupplierLabel
            // 
            addressSupplierLabel.AutoSize = true;
            addressSupplierLabel.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addressSupplierLabel.Location = new Point(106, 371);
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
            registerSupplierButton.Location = new Point(191, 450);
            registerSupplierButton.Name = "registerSupplierButton";
            registerSupplierButton.Size = new Size(152, 37);
            registerSupplierButton.TabIndex = 10;
            registerSupplierButton.Text = "Guardar";
            registerSupplierButton.UseVisualStyleBackColor = true;
            // 
            // SupplierDataGridView
            // 
            SupplierDataGridView.BackgroundColor = Color.Azure;
            SupplierDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SupplierDataGridView.Location = new Point(503, 157);
            SupplierDataGridView.Name = "SupplierDataGridView";
            SupplierDataGridView.Size = new Size(811, 280);
            SupplierDataGridView.TabIndex = 11;
            // 
            // RegisterSuppliersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1369, 610);
            Controls.Add(SupplierDataGridView);
            Controls.Add(registerSupplierButton);
            Controls.Add(addressSupplierTextBox);
            Controls.Add(addressSupplierLabel);
            Controls.Add(emailSupplierTextBox);
            Controls.Add(emailSupplierLabel);
            Controls.Add(phoneSupplierTextBox);
            Controls.Add(phoneSupplierLabel);
            Controls.Add(nameSupplierTextBox);
            Controls.Add(nameSupplierLabel);
            Controls.Add(suppliersLabel);
            Name = "RegisterSuppliersForm";
            Text = "RegisterSuppliersForm";
            ((System.ComponentModel.ISupportInitialize)SupplierDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label suppliersLabel;
        private Label nameSupplierLabel;
        private TextBox nameSupplierTextBox;
        private TextBox phoneSupplierTextBox;
        private Label phoneSupplierLabel;
        private TextBox emailSupplierTextBox;
        private Label emailSupplierLabel;
        private TextBox addressSupplierTextBox;
        private Label addressSupplierLabel;
        private FontAwesome.Sharp.IconButton registerSupplierButton;
        private DataGridView SupplierDataGridView;
    }
}