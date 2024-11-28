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
            components = new System.ComponentModel.Container();
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
            finishPurchaseButton = new FontAwesome.Sharp.IconButton();
            validationsErrorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)validationsErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nameLabel.Location = new Point(149, 86);
            nameLabel.Margin = new Padding(2, 0, 2, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(130, 37);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Nombre:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lastNameLabel.Location = new Point(135, 202);
            lastNameLabel.Margin = new Padding(2, 0, 2, 0);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(145, 37);
            lastNameLabel.TabIndex = 1;
            lastNameLabel.Text = "Apellidos:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            emailLabel.Location = new Point(729, 83);
            emailLabel.Margin = new Padding(2, 0, 2, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(94, 37);
            emailLabel.TabIndex = 2;
            emailLabel.Text = "Email:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            phoneLabel.Location = new Point(118, 332);
            phoneLabel.Margin = new Padding(2, 0, 2, 0);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(262, 37);
            phoneLabel.TabIndex = 3;
            phoneLabel.Text = "Numero de celular:";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(294, 98);
            nameTextBox.Margin = new Padding(2);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(225, 23);
            nameTextBox.TabIndex = 5;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(294, 214);
            lastNameTextBox.Margin = new Padding(2);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(225, 23);
            lastNameTextBox.TabIndex = 6;
            // 
            // phoneTextBox
            // 
            phoneTextBox.Location = new Point(392, 344);
            phoneTextBox.Margin = new Padding(2);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(225, 23);
            phoneTextBox.TabIndex = 7;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(828, 95);
            emailTextBox.Margin = new Padding(2);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(225, 23);
            emailTextBox.TabIndex = 8;
            // 
            // duiLabel
            // 
            duiLabel.AutoSize = true;
            duiLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            duiLabel.Location = new Point(729, 202);
            duiLabel.Margin = new Padding(2, 0, 2, 0);
            duiLabel.Name = "duiLabel";
            duiLabel.Size = new Size(68, 37);
            duiLabel.TabIndex = 9;
            duiLabel.Text = "Dui:";
            // 
            // duiTextBox
            // 
            duiTextBox.Location = new Point(813, 214);
            duiTextBox.Margin = new Padding(2);
            duiTextBox.Name = "duiTextBox";
            duiTextBox.Size = new Size(225, 23);
            duiTextBox.TabIndex = 10;
            // 
            // finishPurchaseButton
            // 
            finishPurchaseButton.BackColor = Color.FromArgb(0, 166, 225);
            finishPurchaseButton.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            finishPurchaseButton.ForeColor = Color.White;
            finishPurchaseButton.IconChar = FontAwesome.Sharp.IconChar.Save;
            finishPurchaseButton.IconColor = Color.White;
            finishPurchaseButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            finishPurchaseButton.IconSize = 32;
            finishPurchaseButton.ImageAlign = ContentAlignment.MiddleLeft;
            finishPurchaseButton.Location = new Point(797, 344);
            finishPurchaseButton.Name = "finishPurchaseButton";
            finishPurchaseButton.Size = new Size(309, 63);
            finishPurchaseButton.TabIndex = 11;
            finishPurchaseButton.Text = "finalizar compra";
            finishPurchaseButton.UseVisualStyleBackColor = false;
            finishPurchaseButton.Click += finishPurchaseButton_Click;
            // 
            // validationsErrorProvider
            // 
            validationsErrorProvider.BlinkRate = 5;
            validationsErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            validationsErrorProvider.ContainerControl = this;
            // 
            // RegisterClients
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1199, 445);
            Controls.Add(finishPurchaseButton);
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
            Margin = new Padding(2);
            Name = "RegisterClients";
            Text = "RegisterClients";
            ((System.ComponentModel.ISupportInitialize)validationsErrorProvider).EndInit();
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
        private FontAwesome.Sharp.IconButton finishPurchaseButton;
        private ErrorProvider validationsErrorProvider;
    }
}