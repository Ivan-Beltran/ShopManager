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
            Registredbutton = new Button();
            PasworrdIconPictureBox3 = new PictureBox();
            TitleLabel = new Label();
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
<<<<<<< HEAD
=======
            // LoginButton
            // 
            LoginButton.BackColor = Color.Transparent;
            LoginButton.FlatAppearance.BorderColor = Color.White;
            LoginButton.FlatAppearance.BorderSize = 3;
            LoginButton.FlatStyle = FlatStyle.Flat;
            LoginButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LoginButton.ForeColor = Color.White;
            LoginButton.Location = new Point(232, 467);
            LoginButton.Margin = new Padding(3, 2, 3, 2);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(176, 31);
            LoginButton.TabIndex = 4;
            LoginButton.Text = "Iniciar session";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
>>>>>>> dac12ab0b60abd4e2202427356f6df2fbec4e3b2
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
<<<<<<< HEAD
            pictureBox1.Location = new Point(1255, 344);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(376, 367);
=======
            pictureBox1.Location = new Point(482, 2);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(329, 275);
>>>>>>> dac12ab0b60abd4e2202427356f6df2fbec4e3b2
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(0, 166, 225);
            panel1.Controls.Add(ShowPasswordCheckBox);
            panel1.Controls.Add(PaswordLabel);
            panel1.Controls.Add(UserLabel);
            panel1.Controls.Add(UserIconpictureBox);
            panel1.Controls.Add(Registredbutton);
            panel1.Controls.Add(PasworrdIconPictureBox3);
            panel1.Controls.Add(TitleLabel);
            panel1.Controls.Add(UserTextBox);
            panel1.Controls.Add(LoginButton);
            panel1.Controls.Add(PasswordTextBox);
            panel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(956, 1049);
            panel1.TabIndex = 10;
            // 
            // ShowPasswordCheckBox
            // 
            ShowPasswordCheckBox.AutoSize = true;
            ShowPasswordCheckBox.CheckAlign = ContentAlignment.MiddleRight;
            ShowPasswordCheckBox.ForeColor = Color.White;
            ShowPasswordCheckBox.Location = new Point(474, 555);
            ShowPasswordCheckBox.Name = "ShowPasswordCheckBox";
            ShowPasswordCheckBox.Size = new Size(203, 32);
            ShowPasswordCheckBox.TabIndex = 13;
            ShowPasswordCheckBox.Text = "Mostrar contraseña";
            ShowPasswordCheckBox.UseVisualStyleBackColor = true;
            // 
            // PaswordLabel
            // 
            PaswordLabel.AutoSize = true;
            PaswordLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PaswordLabel.ForeColor = Color.White;
            PaswordLabel.Location = new Point(340, 467);
            PaswordLabel.Name = "PaswordLabel";
            PaswordLabel.Size = new Size(134, 31);
            PaswordLabel.TabIndex = 11;
            PaswordLabel.Text = "Contraseña";
            // 
            // UserLabel
            // 
            UserLabel.AutoSize = true;
            UserLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UserLabel.ForeColor = Color.White;
            UserLabel.Location = new Point(340, 395);
            UserLabel.Name = "UserLabel";
            UserLabel.Size = new Size(97, 31);
            UserLabel.TabIndex = 10;
            UserLabel.Text = "Usuario";
            // 
            // UserIconpictureBox
            // 
            UserIconpictureBox.BackColor = Color.Transparent;
            UserIconpictureBox.Image = Properties.Resources.User_Icon;
            UserIconpictureBox.Location = new Point(274, 424);
            UserIconpictureBox.Name = "UserIconpictureBox";
            UserIconpictureBox.Size = new Size(34, 35);
            UserIconpictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            UserIconpictureBox.TabIndex = 7;
            UserIconpictureBox.TabStop = false;
            // 
            // Registredbutton
            // 
            Registredbutton.BackColor = Color.Transparent;
            Registredbutton.FlatAppearance.BorderColor = Color.White;
            Registredbutton.FlatAppearance.BorderSize = 3;
            Registredbutton.FlatStyle = FlatStyle.Flat;
            Registredbutton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Registredbutton.ForeColor = Color.White;
<<<<<<< HEAD
            Registredbutton.Location = new Point(482, 608);
            Registredbutton.Name = "Registredbutton";
            Registredbutton.Size = new Size(195, 41);
=======
            Registredbutton.Location = new Point(414, 467);
            Registredbutton.Margin = new Padding(3, 2, 3, 2);
            Registredbutton.Name = "Registredbutton";
            Registredbutton.Size = new Size(171, 31);
>>>>>>> dac12ab0b60abd4e2202427356f6df2fbec4e3b2
            Registredbutton.TabIndex = 5;
            Registredbutton.Text = "Registarse";
            Registredbutton.UseVisualStyleBackColor = false;
            // 
            // PasworrdIconPictureBox3
            // 
<<<<<<< HEAD
            PasworrdIconPictureBox3.BackColor = Color.Transparent;
            PasworrdIconPictureBox3.Image = Properties.Resources.Password_Icon;
            PasworrdIconPictureBox3.Location = new Point(274, 498);
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
            TitleLabel.Font = new Font("Segoe UI", 40.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TitleLabel.ForeColor = Color.White;
            TitleLabel.Location = new Point(239, 235);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(506, 85);
            TitleLabel.TabIndex = 9;
            TitleLabel.Text = "¡BIENVENIDO!\r\n";
            TitleLabel.TextAlign = ContentAlignment.TopCenter;
            TitleLabel.UseWaitCursor = true;
=======
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = Properties.Resources.Password_Icon;
            pictureBox3.Location = new Point(232, 384);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(29, 25);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
>>>>>>> dac12ab0b60abd4e2202427356f6df2fbec4e3b2
            // 
            // UserTextBox
            // 
            UserTextBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
<<<<<<< HEAD
            UserTextBox.Location = new Point(340, 429);
            UserTextBox.Name = "UserTextBox";
            UserTextBox.Size = new Size(337, 30);
=======
            UserTextBox.Location = new Point(290, 332);
            UserTextBox.Margin = new Padding(3, 2, 3, 2);
            UserTextBox.Name = "UserTextBox";
            UserTextBox.Size = new Size(295, 26);
>>>>>>> dac12ab0b60abd4e2202427356f6df2fbec4e3b2
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
            LoginButton.Location = new Point(274, 608);
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
<<<<<<< HEAD
            PasswordTextBox.Location = new Point(340, 501);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(337, 30);
            PasswordTextBox.TabIndex = 3;
=======
            PasswordTextBox.Location = new Point(290, 386);
            PasswordTextBox.Margin = new Padding(3, 2, 3, 2);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(295, 26);
            PasswordTextBox.TabIndex = 3;
            PasswordTextBox.Text = "Contraseña";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.User_Icon;
            pictureBox2.Location = new Point(232, 329);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(29, 26);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 40.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(27, -54);
            label1.Name = "label1";
            label1.Size = new Size(442, 64);
            label1.TabIndex = 9;
            label1.Text = "¡BIENVENIDO!\r\n";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.UseWaitCursor = true;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(0, 166, 225);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(Registredbutton);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(UserTextBox);
            panel1.Controls.Add(LoginButton);
            panel1.Controls.Add(PasswordTextBox);
            panel1.Location = new Point(3, 2);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(473, 445);
            panel1.TabIndex = 10;
>>>>>>> dac12ab0b60abd4e2202427356f6df2fbec4e3b2
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
<<<<<<< HEAD
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1924, 1055);
=======
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(959, 449);
>>>>>>> dac12ab0b60abd4e2202427356f6df2fbec4e3b2
            tableLayoutPanel1.TabIndex = 11;
            // 
            // LoginForm
            // 
<<<<<<< HEAD
            AutoScaleDimensions = new SizeF(8F, 20F);
=======
            AutoScaleDimensions = new SizeF(7F, 15F);
>>>>>>> dac12ab0b60abd4e2202427356f6df2fbec4e3b2
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.White;
<<<<<<< HEAD
            ClientSize = new Size(1924, 1055);
            Controls.Add(tableLayoutPanel1);
=======
            ClientSize = new Size(959, 449);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 2, 3, 2);
>>>>>>> dac12ab0b60abd4e2202427356f6df2fbec4e3b2
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