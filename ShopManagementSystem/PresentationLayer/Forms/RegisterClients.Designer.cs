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
            cancelPurchaseButton = new FontAwesome.Sharp.IconButton();
            registerClientLabel = new Label();
            TittlePanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)validationsErrorProvider).BeginInit();
            TittlePanel.SuspendLayout();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            nameLabel.Location = new Point(118, 127);
            nameLabel.Margin = new Padding(2, 0, 2, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(151, 36);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Nombres:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            lastNameLabel.Location = new Point(118, 275);
            lastNameLabel.Margin = new Padding(2, 0, 2, 0);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(157, 36);
            lastNameLabel.TabIndex = 1;
            lastNameLabel.Text = "Apellidos:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            emailLabel.Location = new Point(823, 119);
            emailLabel.Margin = new Padding(2, 0, 2, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(102, 36);
            emailLabel.TabIndex = 2;
            emailLabel.Text = "Email:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            phoneLabel.Location = new Point(61, 436);
            phoneLabel.Margin = new Padding(2, 0, 2, 0);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(283, 36);
            phoneLabel.TabIndex = 3;
            phoneLabel.Text = "Número de celular:";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(336, 131);
            nameTextBox.Margin = new Padding(2, 3, 2, 3);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(257, 27);
            nameTextBox.TabIndex = 5;
            nameTextBox.TextChanged += nameTextBox_TextChanged;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(336, 285);
            lastNameTextBox.Margin = new Padding(2, 3, 2, 3);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(257, 27);
            lastNameTextBox.TabIndex = 6;
            lastNameTextBox.TextChanged += lastNameTextBox_TextChanged;
            // 
            // phoneTextBox
            // 
            phoneTextBox.Location = new Point(348, 445);
            phoneTextBox.Margin = new Padding(2, 3, 2, 3);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(257, 27);
            phoneTextBox.TabIndex = 7;
            phoneTextBox.TextChanged += phoneTextBox_TextChanged;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(946, 127);
            emailTextBox.Margin = new Padding(2, 3, 2, 3);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(257, 27);
            emailTextBox.TabIndex = 8;
            emailTextBox.TextChanged += emailTextBox_TextChanged;
            // 
            // duiLabel
            // 
            duiLabel.AutoSize = true;
            duiLabel.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            duiLabel.Location = new Point(842, 277);
            duiLabel.Margin = new Padding(2, 0, 2, 0);
            duiLabel.Name = "duiLabel";
            duiLabel.Size = new Size(72, 36);
            duiLabel.TabIndex = 9;
            duiLabel.Text = "Dui:";
            // 
            // duiTextBox
            // 
            duiTextBox.Location = new Point(946, 280);
            duiTextBox.Margin = new Padding(2, 3, 2, 3);
            duiTextBox.Name = "duiTextBox";
            duiTextBox.Size = new Size(257, 27);
            duiTextBox.TabIndex = 10;
            duiTextBox.TextChanged += duiTextBox_TextChanged;
            // 
            // finishPurchaseButton
            // 
            finishPurchaseButton.BackColor = Color.FromArgb(0, 166, 225);
            finishPurchaseButton.FlatStyle = FlatStyle.Flat;
            finishPurchaseButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            finishPurchaseButton.ForeColor = Color.White;
            finishPurchaseButton.IconChar = FontAwesome.Sharp.IconChar.Save;
            finishPurchaseButton.IconColor = Color.White;
            finishPurchaseButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            finishPurchaseButton.IconSize = 32;
            finishPurchaseButton.ImageAlign = ContentAlignment.MiddleLeft;
            finishPurchaseButton.Location = new Point(929, 392);
            finishPurchaseButton.Margin = new Padding(3, 4, 3, 4);
            finishPurchaseButton.Name = "finishPurchaseButton";
            finishPurchaseButton.Size = new Size(274, 69);
            finishPurchaseButton.TabIndex = 11;
            finishPurchaseButton.Text = "Finalizar compra";
            finishPurchaseButton.UseVisualStyleBackColor = false;
            finishPurchaseButton.Click += finishPurchaseButton_Click;
            // 
            // validationsErrorProvider
            // 
            validationsErrorProvider.BlinkRate = 5;
            validationsErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            validationsErrorProvider.ContainerControl = this;
            // 
            // cancelPurchaseButton
            // 
            cancelPurchaseButton.BackColor = Color.FromArgb(0, 166, 225);
            cancelPurchaseButton.FlatStyle = FlatStyle.Flat;
            cancelPurchaseButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            cancelPurchaseButton.ForeColor = Color.White;
            cancelPurchaseButton.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            cancelPurchaseButton.IconColor = Color.White;
            cancelPurchaseButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            cancelPurchaseButton.IconSize = 32;
            cancelPurchaseButton.ImageAlign = ContentAlignment.MiddleLeft;
            cancelPurchaseButton.Location = new Point(929, 495);
            cancelPurchaseButton.Margin = new Padding(8, 4, 3, 4);
            cancelPurchaseButton.Name = "cancelPurchaseButton";
            cancelPurchaseButton.Size = new Size(274, 65);
            cancelPurchaseButton.TabIndex = 12;
            cancelPurchaseButton.Text = "Cancelar compra";
            cancelPurchaseButton.UseVisualStyleBackColor = false;
            cancelPurchaseButton.Click += cancelPurchaseButton_Click;
            // 
            // registerClientLabel
            // 
            registerClientLabel.AutoSize = true;
            registerClientLabel.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            registerClientLabel.ForeColor = Color.White;
            registerClientLabel.Location = new Point(559, 9);
            registerClientLabel.Name = "registerClientLabel";
            registerClientLabel.Size = new Size(390, 62);
            registerClientLabel.TabIndex = 13;
            registerClientLabel.Text = "Registrar Cliente";
            // 
            // TittlePanel
            // 
            TittlePanel.BackColor = Color.FromArgb(0, 166, 225);
            TittlePanel.Controls.Add(registerClientLabel);
            TittlePanel.Dock = DockStyle.Top;
            TittlePanel.Location = new Point(0, 0);
            TittlePanel.Margin = new Padding(0);
            TittlePanel.Name = "TittlePanel";
            TittlePanel.Size = new Size(1370, 85);
            TittlePanel.TabIndex = 26;
            // 
            // RegisterClients
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 593);
            ControlBox = false;
            Controls.Add(cancelPurchaseButton);
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
            Controls.Add(TittlePanel);
            Margin = new Padding(2, 3, 2, 3);
            Name = "RegisterClients";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterClients";
            ((System.ComponentModel.ISupportInitialize)validationsErrorProvider).EndInit();
            TittlePanel.ResumeLayout(false);
            TittlePanel.PerformLayout();
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
        private FontAwesome.Sharp.IconButton cancelPurchaseButton;
        private Label registerClientLabel;
        private Panel TittlePanel;
    }
}