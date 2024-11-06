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
            validationsErrorProvider = new ErrorProvider(components);
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            ShowPasswordCheckBox = new CheckBox();
            PaswordLabel = new Label();
            UserLabel = new Label();
            UserIconpictureBox = new PictureBox();
            PasworrdIconPictureBox3 = new PictureBox();
            TitleLabel = new Label();
            Registredbutton = new Button();
            UserTextBox = new TextBox();
            LoginButton = new Button();
            PasswordTextBox = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)validationsErrorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UserIconpictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PasworrdIconPictureBox3).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // validationsErrorProvider
            // 
            validationsErrorProvider.BlinkRate = 5;
            validationsErrorProvider.ContainerControl = this;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(734, 143);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(329, 275);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 166, 225);
            panel1.Controls.Add(ShowPasswordCheckBox);
            panel1.Controls.Add(PaswordLabel);
            panel1.Controls.Add(UserLabel);
            panel1.Controls.Add(UserIconpictureBox);
            panel1.Controls.Add(PasworrdIconPictureBox3);
            panel1.Controls.Add(TitleLabel);
            panel1.Controls.Add(Registredbutton);
            panel1.Controls.Add(UserTextBox);
            panel1.Controls.Add(LoginButton);
            panel1.Controls.Add(PasswordTextBox);
            panel1.Dock = DockStyle.Fill;
            panel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(3, 2);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(593, 558);
            panel1.TabIndex = 10;
            // 
            // ShowPasswordCheckBox
            // 
            ShowPasswordCheckBox.AutoSize = true;
            ShowPasswordCheckBox.CheckAlign = ContentAlignment.MiddleRight;
            ShowPasswordCheckBox.Font = new Font("Reem Kufi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ShowPasswordCheckBox.ForeColor = Color.White;
            ShowPasswordCheckBox.Location = new Point(419, 391);
            ShowPasswordCheckBox.Name = "ShowPasswordCheckBox";
            ShowPasswordCheckBox.Size = new Size(170, 32);
            ShowPasswordCheckBox.TabIndex = 13;
            ShowPasswordCheckBox.Text = "Mostrar contraseña";
            ShowPasswordCheckBox.UseVisualStyleBackColor = true;
            // 
            // PaswordLabel
            // 
            PaswordLabel.AutoSize = true;
            PaswordLabel.Font = new Font("Reem Kufi", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PaswordLabel.ForeColor = Color.White;
            PaswordLabel.Location = new Point(108, 352);
            PaswordLabel.Name = "PaswordLabel";
            PaswordLabel.Size = new Size(132, 37);
            PaswordLabel.TabIndex = 11;
            PaswordLabel.Text = "Contraseña";
            // 
            // UserLabel
            // 
            UserLabel.AutoSize = true;
            UserLabel.Font = new Font("Reem Kufi", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UserLabel.ForeColor = Color.White;
            UserLabel.Location = new Point(108, 255);
            UserLabel.Name = "UserLabel";
            UserLabel.Size = new Size(94, 37);
            UserLabel.TabIndex = 10;
            UserLabel.Text = "Usuario";
            // 
            // UserIconpictureBox
            // 
            UserIconpictureBox.BackColor = Color.Transparent;
            UserIconpictureBox.ErrorImage = null;
            UserIconpictureBox.Image = (Image)resources.GetObject("UserIconpictureBox.Image");
            UserIconpictureBox.InitialImage = null;
            UserIconpictureBox.Location = new Point(49, 304);
            UserIconpictureBox.Name = "UserIconpictureBox";
            UserIconpictureBox.Size = new Size(34, 35);
            UserIconpictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            UserIconpictureBox.TabIndex = 7;
            UserIconpictureBox.TabStop = false;
            // 
            // PasworrdIconPictureBox3
            // 
            PasworrdIconPictureBox3.BackColor = Color.Transparent;
            PasworrdIconPictureBox3.Image = (Image)resources.GetObject("PasworrdIconPictureBox3.Image");
            PasworrdIconPictureBox3.Location = new Point(49, 380);
            PasworrdIconPictureBox3.Name = "PasworrdIconPictureBox3";
            PasworrdIconPictureBox3.Size = new Size(34, 33);
            PasworrdIconPictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            PasworrdIconPictureBox3.TabIndex = 8;
            PasworrdIconPictureBox3.TabStop = false;
            // 
            // TitleLabel
            // 
            TitleLabel.Anchor = AnchorStyles.None;
            TitleLabel.BackColor = Color.Transparent;
            TitleLabel.FlatStyle = FlatStyle.Flat;
            TitleLabel.Font = new Font("Reem Kufi", 39.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TitleLabel.ForeColor = Color.White;
            TitleLabel.Location = new Point(77, -7);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(420, 85);
            TitleLabel.TabIndex = 9;
            TitleLabel.Text = "¡BIENVENIDO!\r\n";
            TitleLabel.TextAlign = ContentAlignment.TopCenter;
            TitleLabel.UseWaitCursor = true;
            // 
            // Registredbutton
            // 
            Registredbutton.BackColor = Color.Transparent;
            Registredbutton.FlatAppearance.BorderColor = Color.White;
            Registredbutton.FlatAppearance.BorderSize = 3;
            Registredbutton.FlatStyle = FlatStyle.Flat;
            Registredbutton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Registredbutton.ForeColor = Color.White;
            Registredbutton.Location = new Point(96, 494);
            Registredbutton.Margin = new Padding(3, 2, 3, 2);
            Registredbutton.Name = "Registredbutton";
            Registredbutton.Size = new Size(202, 41);
            Registredbutton.TabIndex = 5;
            Registredbutton.Text = "Registarse";
            Registredbutton.UseVisualStyleBackColor = false;
            // 
            // UserTextBox
            // 
            UserTextBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UserTextBox.Location = new Point(108, 304);
            UserTextBox.Margin = new Padding(3, 2, 3, 2);
            UserTextBox.Name = "UserTextBox";
            UserTextBox.Size = new Size(295, 26);
            UserTextBox.TabIndex = 2;
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.Transparent;
            LoginButton.FlatAppearance.BorderColor = Color.White;
            LoginButton.FlatAppearance.BorderSize = 3;
            LoginButton.FlatStyle = FlatStyle.Flat;
            LoginButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LoginButton.ForeColor = Color.White;
            LoginButton.Location = new Point(368, 494);
            LoginButton.Margin = new Padding(3, 2, 3, 2);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(202, 41);
            LoginButton.TabIndex = 4;
            LoginButton.Text = "Iniciar sesión";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PasswordTextBox.Location = new Point(108, 391);
            PasswordTextBox.Margin = new Padding(3, 2, 3, 2);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = '*';
            PasswordTextBox.Size = new Size(295, 26);
            PasswordTextBox.TabIndex = 3;
            PasswordTextBox.Text = "Contraseña";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(pictureBox1, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1199, 562);
            tableLayoutPanel1.TabIndex = 11;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.White;
            ClientSize = new Size(1199, 562);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "LoginForm";
            Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)validationsErrorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UserIconpictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)PasworrdIconPictureBox3).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ErrorProvider validationsErrorProvider;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Button Registredbutton;
        private PictureBox pictureBox3;
        private Label TitleLabel;
        private TextBox UserTextBox;
        private Button LoginButton;
        private TextBox PasswordTextBox;
        private PictureBox pictureBox1;
        private PictureBox UserIconpictureBox;
        private PictureBox PasworrdIconPictureBox3;
        private Label UserLabel;
        private Label PaswordLabel;
        private CheckBox ShowPasswordCheckBox;
    }
}