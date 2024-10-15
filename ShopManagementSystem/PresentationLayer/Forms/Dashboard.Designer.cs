﻿namespace PresentationLayer.Forms
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
            inventarioIconButton = new FontAwesome.Sharp.IconButton();
            ventasIconButton = new FontAwesome.Sharp.IconButton();
            personalIconButton = new FontAwesome.Sharp.IconButton();
            inicioIconButton = new FontAwesome.Sharp.IconButton();
            logoPictureBox = new PictureBox();
<<<<<<< HEAD
=======
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
>>>>>>> ff39ea49c8f7b4102066e456ffd70627c33f80ae
            sidebarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).BeginInit();
            SuspendLayout();
            // 
            // sidebarPanel
            // 
            sidebarPanel.BackColor = Color.FromArgb(249, 220, 92);
            sidebarPanel.Controls.Add(inventarioIconButton);
            sidebarPanel.Controls.Add(ventasIconButton);
            sidebarPanel.Controls.Add(personalIconButton);
            sidebarPanel.Controls.Add(inicioIconButton);
            sidebarPanel.Controls.Add(logoPictureBox);
            sidebarPanel.Dock = DockStyle.Left;
            sidebarPanel.Location = new Point(0, 0);
<<<<<<< HEAD
            sidebarPanel.Margin = new Padding(2);
            sidebarPanel.Name = "sidebarPanel";
            sidebarPanel.Size = new Size(162, 406);
=======
            sidebarPanel.Margin = new Padding(2, 2, 2, 2);
            sidebarPanel.Name = "sidebarPanel";
            sidebarPanel.Size = new Size(186, 541);
>>>>>>> ff39ea49c8f7b4102066e456ffd70627c33f80ae
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
<<<<<<< HEAD
            inventarioIconButton.Location = new Point(0, 172);
            inventarioIconButton.Margin = new Padding(2);
            inventarioIconButton.Name = "inventarioIconButton";
            inventarioIconButton.Size = new Size(162, 34);
=======
            inventarioIconButton.Location = new Point(0, 229);
            inventarioIconButton.Margin = new Padding(2, 2, 2, 2);
            inventarioIconButton.Name = "inventarioIconButton";
            inventarioIconButton.Size = new Size(186, 45);
>>>>>>> ff39ea49c8f7b4102066e456ffd70627c33f80ae
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
<<<<<<< HEAD
            ventasIconButton.Location = new Point(0, 109);
            ventasIconButton.Margin = new Padding(2);
            ventasIconButton.Name = "ventasIconButton";
            ventasIconButton.Size = new Size(162, 34);
=======
            ventasIconButton.Location = new Point(0, 146);
            ventasIconButton.Margin = new Padding(2, 2, 2, 2);
            ventasIconButton.Name = "ventasIconButton";
            ventasIconButton.Size = new Size(186, 45);
>>>>>>> ff39ea49c8f7b4102066e456ffd70627c33f80ae
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
<<<<<<< HEAD
            personalIconButton.Location = new Point(0, 140);
            personalIconButton.Margin = new Padding(2);
            personalIconButton.Name = "personalIconButton";
            personalIconButton.Size = new Size(162, 34);
=======
            personalIconButton.Location = new Point(0, 186);
            personalIconButton.Margin = new Padding(2, 2, 2, 2);
            personalIconButton.Name = "personalIconButton";
            personalIconButton.Size = new Size(186, 45);
>>>>>>> ff39ea49c8f7b4102066e456ffd70627c33f80ae
            personalIconButton.TabIndex = 2;
            personalIconButton.Text = "Personal";
            personalIconButton.UseVisualStyleBackColor = false;
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
<<<<<<< HEAD
            inicioIconButton.Location = new Point(0, 77);
            inicioIconButton.Margin = new Padding(2);
            inicioIconButton.Name = "inicioIconButton";
            inicioIconButton.Size = new Size(162, 34);
=======
            inicioIconButton.Location = new Point(0, 103);
            inicioIconButton.Margin = new Padding(2, 2, 2, 2);
            inicioIconButton.Name = "inicioIconButton";
            inicioIconButton.Size = new Size(186, 45);
>>>>>>> ff39ea49c8f7b4102066e456ffd70627c33f80ae
            inicioIconButton.TabIndex = 1;
            inicioIconButton.Text = "Inicio";
            inicioIconButton.UseVisualStyleBackColor = false;
            // 
            // logoPictureBox
            // 
            logoPictureBox.BackColor = Color.Transparent;
            logoPictureBox.BackgroundImage = (Image)resources.GetObject("logoPictureBox.BackgroundImage");
            logoPictureBox.BackgroundImageLayout = ImageLayout.Zoom;
<<<<<<< HEAD
            logoPictureBox.Location = new Point(0, -20);
            logoPictureBox.Margin = new Padding(3, 2, 3, 2);
            logoPictureBox.Name = "logoPictureBox";
            logoPictureBox.Size = new Size(172, 113);
            logoPictureBox.TabIndex = 1;
            logoPictureBox.TabStop = false;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(959, 406);
            Controls.Add(sidebarPanel);
            Margin = new Padding(2);
=======
            logoPictureBox.Location = new Point(0, -26);
            logoPictureBox.Name = "logoPictureBox";
            logoPictureBox.Size = new Size(196, 151);
            logoPictureBox.TabIndex = 1;
            logoPictureBox.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(486, 98);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(486, 146);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(486, 204);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(486, 260);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 4;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1341, 541);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(sidebarPanel);
            Margin = new Padding(2, 2, 2, 2);
>>>>>>> ff39ea49c8f7b4102066e456ffd70627c33f80ae
            Name = "Dashboard";
            Text = "Dashboard";
            sidebarPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel sidebarPanel;
        private PictureBox logoPictureBox;
        private FontAwesome.Sharp.IconButton inicioIconButton;
        private FontAwesome.Sharp.IconButton inventarioIconButton;
        private FontAwesome.Sharp.IconButton ventasIconButton;
        private FontAwesome.Sharp.IconButton personalIconButton;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
    }
}