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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            sidebarPanel = new Panel();
            logoPictureBox = new PictureBox();
            inicioIconButton = new FontAwesome.Sharp.IconButton();
            personalIconButton = new FontAwesome.Sharp.IconButton();
            ventasIconButton = new FontAwesome.Sharp.IconButton();
            inventarioIconButton = new FontAwesome.Sharp.IconButton();
            sidebarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).BeginInit();
            SuspendLayout();
            // 
            // sidebarPanel
            // 
            sidebarPanel.BackColor = Color.Goldenrod;
            sidebarPanel.Controls.Add(inventarioIconButton);
            sidebarPanel.Controls.Add(ventasIconButton);
            sidebarPanel.Controls.Add(personalIconButton);
            sidebarPanel.Controls.Add(inicioIconButton);
            sidebarPanel.Controls.Add(logoPictureBox);
            sidebarPanel.Dock = DockStyle.Left;
            sidebarPanel.Location = new Point(0, 0);
            sidebarPanel.Name = "sidebarPanel";
            sidebarPanel.Size = new Size(232, 676);
            sidebarPanel.TabIndex = 0;
            // 
            // logoPictureBox
            // 
            logoPictureBox.BackColor = Color.Transparent;
            logoPictureBox.BackgroundImage = (Image)resources.GetObject("logoPictureBox.BackgroundImage");
            logoPictureBox.BackgroundImageLayout = ImageLayout.Zoom;
            logoPictureBox.Location = new Point(0, -33);
            logoPictureBox.Margin = new Padding(4);
            logoPictureBox.Name = "logoPictureBox";
            logoPictureBox.Size = new Size(245, 189);
            logoPictureBox.TabIndex = 1;
            logoPictureBox.TabStop = false;
            // 
            // inicioIconButton
            // 
            inicioIconButton.BackColor = Color.Black;
            inicioIconButton.FlatAppearance.BorderSize = 0;
            inicioIconButton.FlatStyle = FlatStyle.Flat;
            inicioIconButton.Font = new Font("Segoe UI Historic", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            inicioIconButton.ForeColor = SystemColors.ButtonHighlight;
            inicioIconButton.IconChar = FontAwesome.Sharp.IconChar.HomeUser;
            inicioIconButton.IconColor = Color.White;
            inicioIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            inicioIconButton.IconSize = 32;
            inicioIconButton.ImageAlign = ContentAlignment.MiddleLeft;
            inicioIconButton.Location = new Point(0, 129);
            inicioIconButton.Name = "inicioIconButton";
            inicioIconButton.Size = new Size(232, 56);
            inicioIconButton.TabIndex = 1;
            inicioIconButton.Text = "Inicio";
            inicioIconButton.UseVisualStyleBackColor = false;
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
            personalIconButton.Location = new Point(0, 233);
            personalIconButton.Name = "personalIconButton";
            personalIconButton.Size = new Size(232, 56);
            personalIconButton.TabIndex = 2;
            personalIconButton.Text = "Personal";
            personalIconButton.UseVisualStyleBackColor = false;
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
            ventasIconButton.Location = new Point(0, 182);
            ventasIconButton.Name = "ventasIconButton";
            ventasIconButton.Size = new Size(232, 56);
            ventasIconButton.TabIndex = 3;
            ventasIconButton.Text = "Ventas";
            ventasIconButton.UseVisualStyleBackColor = false;
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
            inventarioIconButton.Location = new Point(0, 286);
            inventarioIconButton.Name = "inventarioIconButton";
            inventarioIconButton.Size = new Size(232, 56);
            inventarioIconButton.TabIndex = 4;
            inventarioIconButton.Text = "Inventario";
            inventarioIconButton.UseVisualStyleBackColor = false;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1676, 676);
            Controls.Add(sidebarPanel);
            Name = "Dashboard";
            Text = "Dashboard";
            sidebarPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel sidebarPanel;
        private PictureBox logoPictureBox;
        private FontAwesome.Sharp.IconButton inicioIconButton;
        private FontAwesome.Sharp.IconButton inventarioIconButton;
        private FontAwesome.Sharp.IconButton ventasIconButton;
        private FontAwesome.Sharp.IconButton personalIconButton;
    }
}