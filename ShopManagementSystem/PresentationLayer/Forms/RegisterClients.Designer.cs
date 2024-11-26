namespace PresentationLayer.Forms
{
    partial class RegisterClients
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
            nameLabel = new Label();
            lastNameLabel = new Label();
            emailLabel = new Label();
            phoneLabel = new Label();
            nameTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            phoneTextBox = new TextBox();
            emailTextBox = new TextBox();
            duiLabel = new Label();
            duiTextBox = new TextBox();
            paymentMethodComboBox = new ComboBox();
            paymentMethodLabel = new Label();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nameLabel.Location = new Point(212, 142);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(190, 54);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Nombre:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lastNameLabel.Location = new Point(193, 337);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(209, 54);
            lastNameLabel.TabIndex = 1;
            lastNameLabel.Text = "Apellidos:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            emailLabel.Location = new Point(1041, 139);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(136, 54);
            emailLabel.TabIndex = 2;
            emailLabel.Text = "Email:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            phoneLabel.Location = new Point(169, 554);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(385, 54);
            phoneLabel.TabIndex = 3;
            phoneLabel.Text = "Numero de celular:";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(420, 162);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(320, 31);
            nameTextBox.TabIndex = 5;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(420, 357);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(320, 31);
            lastNameTextBox.TabIndex = 6;
            // 
            // phoneTextBox
            // 
            phoneTextBox.Location = new Point(560, 574);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(320, 31);
            phoneTextBox.TabIndex = 7;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(1183, 159);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(320, 31);
            emailTextBox.TabIndex = 8;
            // 
            // duiLabel
            // 
            duiLabel.AutoSize = true;
            duiLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            duiLabel.Location = new Point(1041, 337);
            duiLabel.Name = "duiLabel";
            duiLabel.Size = new Size(99, 54);
            duiLabel.TabIndex = 9;
            duiLabel.Text = "Dui:";
            // 
            // duiTextBox
            // 
            duiTextBox.Location = new Point(1161, 357);
            duiTextBox.Name = "duiTextBox";
            duiTextBox.Size = new Size(320, 31);
            duiTextBox.TabIndex = 10;
            // 
            // paymentMethodComboBox
            // 
            paymentMethodComboBox.FormattingEnabled = true;
            paymentMethodComboBox.Location = new Point(1313, 575);
            paymentMethodComboBox.Name = "paymentMethodComboBox";
            paymentMethodComboBox.Size = new Size(331, 33);
            paymentMethodComboBox.TabIndex = 11;
            // 
            // paymentMethodLabel
            // 
            paymentMethodLabel.AutoSize = true;
            paymentMethodLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            paymentMethodLabel.Location = new Point(977, 555);
            paymentMethodLabel.Name = "paymentMethodLabel";
            paymentMethodLabel.Size = new Size(348, 54);
            paymentMethodLabel.TabIndex = 12;
            paymentMethodLabel.Text = "Metodo de pago:";
            // 
            // RegisterClients
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1730, 741);
            Controls.Add(paymentMethodLabel);
            Controls.Add(paymentMethodComboBox);
            Controls.Add(duiTextBox);
            Controls.Add(duiLabel);
            Controls.Add(emailTextBox);
            Controls.Add(phoneTextBox);
            Controls.Add(lastNameTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(phoneLabel);
            Controls.Add(emailLabel);
            Controls.Add(lastNameLabel);
            Controls.Add(nameLabel);
            Name = "RegisterClients";
            Text = "RegisterClients";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameLabel;
        private Label lastNameLabel;
        private Label emailLabel;
        private Label phoneLabel;
        private TextBox nameTextBox;
        private TextBox lastNameTextBox;
        private TextBox phoneTextBox;
        private TextBox emailTextBox;
        private Label duiLabel;
        private TextBox duiTextBox;
        private ComboBox paymentMethodComboBox;
        private Label paymentMethodLabel;
    }
}