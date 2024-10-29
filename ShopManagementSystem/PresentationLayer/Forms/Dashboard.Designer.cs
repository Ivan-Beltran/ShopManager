namespace PresentationLayer.Forms
{
    partial class Dashboard
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
            sidebarPanel = new Panel();
            inventarioIconButton = new FontAwesome.Sharp.IconButton();
            ventasIconButton = new FontAwesome.Sharp.IconButton();
            personalIconButton = new FontAwesome.Sharp.IconButton();
            HomeButton = new FontAwesome.Sharp.IconButton();
            pictureBox1 = new PictureBox();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            PrincipalPanel = new Panel();
            pictureBox2 = new PictureBox();
            sidebarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            PrincipalPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // sidebarPanel
            // 
            sidebarPanel.BackColor = Color.FromArgb(0, 166, 225);
            sidebarPanel.Controls.Add(inventarioIconButton);
            sidebarPanel.Controls.Add(ventasIconButton);
            sidebarPanel.Controls.Add(personalIconButton);
            sidebarPanel.Controls.Add(HomeButton);
            sidebarPanel.Controls.Add(pictureBox1);
            sidebarPanel.Dock = DockStyle.Left;
            sidebarPanel.Location = new Point(0, 0);
            sidebarPanel.Margin = new Padding(2, 3, 2, 3);
            sidebarPanel.Name = "sidebarPanel";
            sidebarPanel.Size = new Size(255, 990);
            sidebarPanel.TabIndex = 0;
            // 
            // inventarioIconButton
            // 
            inventarioIconButton.BackColor = Color.Transparent;
            inventarioIconButton.FlatAppearance.BorderSize = 0;
            inventarioIconButton.FlatStyle = FlatStyle.Flat;
            inventarioIconButton.Font = new Font("Segoe UI Historic", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            inventarioIconButton.ForeColor = SystemColors.ActiveCaptionText;
            inventarioIconButton.IconChar = FontAwesome.Sharp.IconChar.Newspaper;
            inventarioIconButton.IconColor = Color.Black;
            inventarioIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            inventarioIconButton.IconSize = 32;
            inventarioIconButton.ImageAlign = ContentAlignment.MiddleLeft;
            inventarioIconButton.Location = new Point(2, 329);
            inventarioIconButton.Margin = new Padding(2, 3, 2, 3);
            inventarioIconButton.Name = "inventarioIconButton";
            inventarioIconButton.Size = new Size(255, 39);
            inventarioIconButton.TabIndex = 4;
            inventarioIconButton.Text = "Inventario";
            inventarioIconButton.UseVisualStyleBackColor = false;
            // 
            // ventasIconButton
            // 
            ventasIconButton.BackColor = Color.Transparent;
            ventasIconButton.FlatAppearance.BorderSize = 0;
            ventasIconButton.FlatStyle = FlatStyle.Flat;
            ventasIconButton.Font = new Font("Segoe UI Historic", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ventasIconButton.ForeColor = SystemColors.ActiveCaptionText;
            ventasIconButton.IconChar = FontAwesome.Sharp.IconChar.MoneyBillTrendUp;
            ventasIconButton.IconColor = Color.Black;
            ventasIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ventasIconButton.IconSize = 32;
            ventasIconButton.ImageAlign = ContentAlignment.MiddleLeft;
            ventasIconButton.Location = new Point(2, 247);
            ventasIconButton.Margin = new Padding(2, 3, 2, 3);
            ventasIconButton.Name = "ventasIconButton";
            ventasIconButton.Size = new Size(253, 39);
            ventasIconButton.TabIndex = 3;
            ventasIconButton.Text = "Ventas";
            ventasIconButton.UseVisualStyleBackColor = false;
            // 
            // personalIconButton
            // 
            personalIconButton.BackColor = Color.Transparent;
            personalIconButton.FlatAppearance.BorderSize = 0;
            personalIconButton.FlatStyle = FlatStyle.Flat;
            personalIconButton.Font = new Font("Segoe UI Historic", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            personalIconButton.ForeColor = SystemColors.ActiveCaptionText;
            personalIconButton.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            personalIconButton.IconColor = Color.Black;
            personalIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            personalIconButton.IconSize = 32;
            personalIconButton.ImageAlign = ContentAlignment.MiddleLeft;
            personalIconButton.Location = new Point(2, 287);
            personalIconButton.Margin = new Padding(2, 3, 2, 3);
            personalIconButton.Name = "personalIconButton";
            personalIconButton.Size = new Size(255, 39);
            personalIconButton.TabIndex = 2;
            personalIconButton.Text = "Personal";
            personalIconButton.UseVisualStyleBackColor = false;
            // 
            // HomeButton
            // 
            HomeButton.BackColor = Color.Black;
            HomeButton.FlatAppearance.BorderSize = 0;
            HomeButton.FlatStyle = FlatStyle.Flat;
            HomeButton.Font = new Font("Segoe UI Historic", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HomeButton.ForeColor = SystemColors.ButtonHighlight;
            HomeButton.IconChar = FontAwesome.Sharp.IconChar.HomeUser;
            HomeButton.IconColor = Color.White;
            HomeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            HomeButton.IconSize = 32;
            HomeButton.ImageAlign = ContentAlignment.MiddleLeft;
            HomeButton.Location = new Point(2, 191);
            HomeButton.Margin = new Padding(2, 3, 2, 3);
            HomeButton.Name = "HomeButton";
            HomeButton.Size = new Size(253, 50);
            HomeButton.TabIndex = 1;
            HomeButton.Text = "Inicio";
            HomeButton.UseVisualStyleBackColor = false;
            HomeButton.Click += HomeButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.ClickZy;
            pictureBox1.Location = new Point(2, -23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(257, 249);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // PrincipalPanel
            // 
            PrincipalPanel.Controls.Add(pictureBox2);
            PrincipalPanel.Dock = DockStyle.Fill;
            PrincipalPanel.Location = new Point(255, 0);
            PrincipalPanel.Name = "PrincipalPanel";
            PrincipalPanel.Size = new Size(1669, 990);
            PrincipalPanel.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Home__1669_x_858_px_;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1754, 997);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1924, 990);
            Controls.Add(PrincipalPanel);
            Controls.Add(sidebarPanel);
            Margin = new Padding(2, 3, 2, 3);
            Name = "Dashboard";
            Text = "Dashboard";
            WindowState = FormWindowState.Maximized;
            sidebarPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            PrincipalPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel sidebarPanel;
        private FontAwesome.Sharp.IconButton HomeButton;
        private FontAwesome.Sharp.IconButton inventarioIconButton;
        private FontAwesome.Sharp.IconButton ventasIconButton;
        private FontAwesome.Sharp.IconButton personalIconButton;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Panel PrincipalPanel;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}