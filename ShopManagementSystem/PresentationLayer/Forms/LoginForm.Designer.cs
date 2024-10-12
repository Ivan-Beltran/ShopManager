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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            loginPictureBox = new PictureBox();
            iniciarSesionButton = new Button();
            registarseButton = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)loginPictureBox).BeginInit();
            SuspendLayout();
            // 
            // loginPictureBox
            // 
            loginPictureBox.BackColor = Color.Transparent;
            loginPictureBox.BackgroundImage = (Image)resources.GetObject("loginPictureBox.BackgroundImage");
            loginPictureBox.BackgroundImageLayout = ImageLayout.Zoom;
            loginPictureBox.Location = new Point(334, 11);
            loginPictureBox.Margin = new Padding(2);
            loginPictureBox.Name = "loginPictureBox";
            loginPictureBox.Size = new Size(384, 382);
            loginPictureBox.TabIndex = 0;
            loginPictureBox.TabStop = false;
            // 
            // iniciarSesionButton
            // 
            iniciarSesionButton.BackColor = Color.Gold;
            iniciarSesionButton.Font = new Font("Segoe UI Historic", 11F, FontStyle.Bold);
            iniciarSesionButton.ForeColor = Color.Black;
            iniciarSesionButton.Location = new Point(291, 460);
            iniciarSesionButton.Margin = new Padding(2);
            iniciarSesionButton.Name = "iniciarSesionButton";
            iniciarSesionButton.Size = new Size(158, 38);
            iniciarSesionButton.TabIndex = 1;
            iniciarSesionButton.Text = "empleado";
            iniciarSesionButton.UseVisualStyleBackColor = false;
            // 
            // registarseButton
            // 
            registarseButton.BackColor = Color.Gold;
            registarseButton.Font = new Font("Segoe UI Historic", 11F, FontStyle.Bold);
            registarseButton.Location = new Point(590, 460);
            registarseButton.Margin = new Padding(2);
            registarseButton.Name = "registarseButton";
            registarseButton.Size = new Size(158, 38);
            registarseButton.TabIndex = 2;
            registarseButton.Text = "cliente";
            registarseButton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(482, 404);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 3;
            label1.Text = "iniciar como ";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(1060, 539);
            Controls.Add(label1);
            Controls.Add(registarseButton);
            Controls.Add(iniciarSesionButton);
            Controls.Add(loginPictureBox);
            Margin = new Padding(2);
            Name = "LoginForm";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)loginPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox loginPictureBox;
        private Button iniciarSesionButton;
        private Button registarseButton;
        private Label label1;
    }
}