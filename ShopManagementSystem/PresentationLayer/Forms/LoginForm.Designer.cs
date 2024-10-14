namespace PresentationLayer.Forms
{
    partial class LoginForm
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
            label1 = new Label();
            label2 = new Label();
            UserTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            LoginButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(187, 91);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(187, 168);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // UserTextBox
            // 
            UserTextBox.Location = new Point(358, 88);
            UserTextBox.Name = "UserTextBox";
            UserTextBox.Size = new Size(268, 27);
            UserTextBox.TabIndex = 2;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(358, 161);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(268, 27);
            PasswordTextBox.TabIndex = 3;
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(433, 275);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(94, 29);
            LoginButton.TabIndex = 4;
            LoginButton.Text = "button1";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1001, 527);
            Controls.Add(LoginButton);
            Controls.Add(PasswordTextBox);
            Controls.Add(UserTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox UserTextBox;
        private TextBox PasswordTextBox;
        private Button LoginButton;
    }
}