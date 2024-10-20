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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            nameLogin = new Label();
            passwordLogin = new Label();
            UserTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            LoginButton = new Button();
            validationsErrorProvider = new ErrorProvider(components);
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)validationsErrorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // nameLogin
            // 
            nameLogin.AutoSize = true;
            nameLogin.Font = new Font("Tahoma", 11.25F, FontStyle.Bold);
            nameLogin.Location = new Point(207, 69);
            nameLogin.Name = "nameLogin";
            nameLogin.Size = new Size(71, 18);
            nameLogin.TabIndex = 0;
            nameLogin.Text = "Usuario:";
            // 
            // passwordLogin
            // 
            passwordLogin.AutoSize = true;
            passwordLogin.Font = new Font("Tahoma", 11.25F, FontStyle.Bold);
            passwordLogin.Location = new Point(207, 119);
            passwordLogin.Name = "passwordLogin";
            passwordLogin.Size = new Size(98, 18);
            passwordLogin.TabIndex = 1;
            passwordLogin.Text = "Contraseña:";
            // 
            // UserTextBox
            // 
            UserTextBox.Location = new Point(313, 66);
            UserTextBox.Margin = new Padding(3, 2, 3, 2);
            UserTextBox.Name = "UserTextBox";
            UserTextBox.Size = new Size(235, 23);
            UserTextBox.TabIndex = 2;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(313, 121);
            PasswordTextBox.Margin = new Padding(3, 2, 3, 2);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(235, 23);
            PasswordTextBox.TabIndex = 3;
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.Lavender;
            LoginButton.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginButton.Location = new Point(375, 169);
            LoginButton.Margin = new Padding(3, 2, 3, 2);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(95, 35);
            LoginButton.TabIndex = 4;
            LoginButton.Text = "Entrar";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // validationsErrorProvider
            // 
            validationsErrorProvider.ContainerControl = this;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(173, 52);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(28, 37);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(173, 107);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(28, 37);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(124, 218, 249);
            ClientSize = new Size(876, 395);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(LoginButton);
            Controls.Add(PasswordTextBox);
            Controls.Add(UserTextBox);
            Controls.Add(passwordLogin);
            Controls.Add(nameLogin);
            Margin = new Padding(3, 2, 3, 2);
            Name = "LoginForm";
            Text = "LoginForm";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)validationsErrorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameLogin;
        private Label passwordLogin;
        private TextBox UserTextBox;
        private TextBox PasswordTextBox;
        private Button LoginButton;
        private ErrorProvider validationsErrorProvider;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}