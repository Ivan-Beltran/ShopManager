﻿namespace PresentationLayer.Forms
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
            ((System.ComponentModel.ISupportInitialize)validationsErrorProvider).BeginInit();
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
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(336, 285);
            lastNameTextBox.Margin = new Padding(2, 3, 2, 3);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(257, 27);
            lastNameTextBox.TabIndex = 6;
            // 
            // phoneTextBox
            // 
            phoneTextBox.Location = new Point(336, 444);
            phoneTextBox.Margin = new Padding(2, 3, 2, 3);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(257, 27);
            phoneTextBox.TabIndex = 7;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(946, 127);
            emailTextBox.Margin = new Padding(2, 3, 2, 3);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(257, 27);
            emailTextBox.TabIndex = 8;
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
            finishPurchaseButton.Location = new Point(929, 392);
            finishPurchaseButton.Margin = new Padding(3, 4, 3, 4);
            finishPurchaseButton.Name = "finishPurchaseButton";
            finishPurchaseButton.Size = new Size(231, 69);
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
            cancelPurchaseButton.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cancelPurchaseButton.ForeColor = Color.White;
            cancelPurchaseButton.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            cancelPurchaseButton.IconColor = Color.White;
            cancelPurchaseButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            cancelPurchaseButton.IconSize = 32;
            cancelPurchaseButton.ImageAlign = ContentAlignment.MiddleLeft;
            cancelPurchaseButton.Location = new Point(929, 495);
            cancelPurchaseButton.Margin = new Padding(3, 4, 3, 4);
            cancelPurchaseButton.Name = "cancelPurchaseButton";
            cancelPurchaseButton.Size = new Size(231, 65);
            cancelPurchaseButton.TabIndex = 12;
            cancelPurchaseButton.Text = "Cancelar compra";
            cancelPurchaseButton.UseVisualStyleBackColor = false;
            cancelPurchaseButton.Click += cancelPurchaseButton_Click;
            // 
            // registerClientLabel
            // 
            registerClientLabel.AutoSize = true;
            registerClientLabel.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            registerClientLabel.Location = new Point(561, 31);
            registerClientLabel.Name = "registerClientLabel";
            registerClientLabel.Size = new Size(253, 36);
            registerClientLabel.TabIndex = 13;
            registerClientLabel.Text = "Registrar Cliente";
            // 
            // RegisterClients
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 593);
            ControlBox = false;
            Controls.Add(registerClientLabel);
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
            Margin = new Padding(2, 3, 2, 3);
            Name = "RegisterClients";
            StartPosition = FormStartPosition.CenterScreen;
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
        private FontAwesome.Sharp.IconButton cancelPurchaseButton;
        private Label registerClientLabel;
    }
}