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
            finishPurchaseButton = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nameLabel.Location = new Point(170, 114);
            nameLabel.Margin = new Padding(2, 0, 2, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(161, 46);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Nombre:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lastNameLabel.Location = new Point(154, 270);
            lastNameLabel.Margin = new Padding(2, 0, 2, 0);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(179, 46);
            lastNameLabel.TabIndex = 1;
            lastNameLabel.Text = "Apellidos:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            emailLabel.Location = new Point(833, 111);
            emailLabel.Margin = new Padding(2, 0, 2, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(116, 46);
            emailLabel.TabIndex = 2;
            emailLabel.Text = "Email:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            phoneLabel.Location = new Point(135, 443);
            phoneLabel.Margin = new Padding(2, 0, 2, 0);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(326, 46);
            phoneLabel.TabIndex = 3;
            phoneLabel.Text = "Numero de celular:";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(336, 130);
            nameTextBox.Margin = new Padding(2);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(257, 27);
            nameTextBox.TabIndex = 5;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(336, 286);
            lastNameTextBox.Margin = new Padding(2);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(257, 27);
            lastNameTextBox.TabIndex = 6;
            // 
            // phoneTextBox
            // 
            phoneTextBox.Location = new Point(448, 459);
            phoneTextBox.Margin = new Padding(2);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(257, 27);
            phoneTextBox.TabIndex = 7;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(946, 127);
            emailTextBox.Margin = new Padding(2);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(257, 27);
            emailTextBox.TabIndex = 8;
            // 
            // duiLabel
            // 
            duiLabel.AutoSize = true;
            duiLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            duiLabel.Location = new Point(833, 270);
            duiLabel.Margin = new Padding(2, 0, 2, 0);
            duiLabel.Name = "duiLabel";
            duiLabel.Size = new Size(85, 46);
            duiLabel.TabIndex = 9;
            duiLabel.Text = "Dui:";
            // 
            // duiTextBox
            // 
            duiTextBox.Location = new Point(929, 286);
            duiTextBox.Margin = new Padding(2);
            duiTextBox.Name = "duiTextBox";
            duiTextBox.Size = new Size(257, 27);
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
            finishPurchaseButton.Location = new Point(911, 459);
            finishPurchaseButton.Margin = new Padding(3, 4, 3, 4);
            finishPurchaseButton.Name = "finishPurchaseButton";
            finishPurchaseButton.Size = new Size(353, 84);
            finishPurchaseButton.TabIndex = 11;
            finishPurchaseButton.Text = "finalizar compra";
            finishPurchaseButton.UseVisualStyleBackColor = false;
            finishPurchaseButton.Click += finishPurchaseButton_Click;
            // 
            // RegisterClients
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1384, 593);
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
    }
}