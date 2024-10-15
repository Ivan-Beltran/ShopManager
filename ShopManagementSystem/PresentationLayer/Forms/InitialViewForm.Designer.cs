namespace PresentationLayer.Forms
{
    partial class InitialViewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InitialViewForm));
            loginPictureBox = new PictureBox();
            iniciarSesionButton = new Button();
            registarseButton = new Button();
            ((System.ComponentModel.ISupportInitialize)loginPictureBox).BeginInit();
            SuspendLayout();
            // 
            // loginPictureBox
            // 
            loginPictureBox.BackColor = Color.Transparent;
            loginPictureBox.BackgroundImage = (Image)resources.GetObject("loginPictureBox.BackgroundImage");
            loginPictureBox.BackgroundImageLayout = ImageLayout.Zoom;
            loginPictureBox.Location = new Point(636, 41);
            loginPictureBox.Margin = new Padding(2);
            loginPictureBox.Name = "loginPictureBox";
            loginPictureBox.Size = new Size(458, 382);
            loginPictureBox.TabIndex = 0;
            loginPictureBox.TabStop = false;
            // 
            // iniciarSesionButton
            // 
            iniciarSesionButton.BackColor = Color.White;
            iniciarSesionButton.Font = new Font("Segoe UI Historic", 11F, FontStyle.Bold);
            iniciarSesionButton.ForeColor = Color.Black;
            iniciarSesionButton.Location = new Point(644, 436);
            iniciarSesionButton.Margin = new Padding(2);
            iniciarSesionButton.Name = "iniciarSesionButton";
            iniciarSesionButton.Size = new Size(158, 38);
            iniciarSesionButton.TabIndex = 1;
            iniciarSesionButton.Text = "Iniciar Sesión";
            iniciarSesionButton.UseVisualStyleBackColor = false;
            iniciarSesionButton.Click += iniciarSesionButton_Click;
            // 
            // registarseButton
            // 
            registarseButton.BackColor = Color.Bisque;
            registarseButton.Font = new Font("Segoe UI Historic", 11F, FontStyle.Bold);
            registarseButton.ForeColor = SystemColors.ActiveCaptionText;
            registarseButton.Location = new Point(920, 436);
            registarseButton.Margin = new Padding(2);
            registarseButton.Name = "registarseButton";
            registarseButton.Size = new Size(158, 38);
            registarseButton.TabIndex = 2;
            registarseButton.Text = "Registrarse";
            registarseButton.UseVisualStyleBackColor = false;
            // 
            // InitialViewForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            ClientSize = new Size(1341, 541);
            Controls.Add(registarseButton);
            Controls.Add(iniciarSesionButton);
            Controls.Add(loginPictureBox);
            Margin = new Padding(2);
            Name = "InitialViewForm";
            Text = "Login";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)loginPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox loginPictureBox;
        private Button iniciarSesionButton;
        private Button registarseButton;
    }
}