namespace PresentationLayer.Forms
{
    partial class SalesreportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesreportForm));
            flowLayoutPanel2 = new FlowLayoutPanel();
            Searchlabel = new Label();
            textBox1 = new TextBox();
            SearchButton = new PictureBox();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SearchButton).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = Color.Teal;
            flowLayoutPanel2.Controls.Add(Searchlabel);
            flowLayoutPanel2.Controls.Add(textBox1);
            flowLayoutPanel2.Controls.Add(SearchButton);
            flowLayoutPanel2.Dock = DockStyle.Top;
            flowLayoutPanel2.Location = new Point(0, 0);
            flowLayoutPanel2.Margin = new Padding(0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(1370, 81);
            flowLayoutPanel2.TabIndex = 1;
            // 
            // Searchlabel
            // 
            Searchlabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Searchlabel.AutoSize = true;
            Searchlabel.BackColor = Color.Transparent;
            Searchlabel.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            Searchlabel.ForeColor = SystemColors.Control;
            Searchlabel.Location = new Point(100, 15);
            Searchlabel.Margin = new Padding(100, 15, 0, 0);
            Searchlabel.Name = "Searchlabel";
            Searchlabel.Size = new Size(278, 55);
            Searchlabel.TabIndex = 0;
            Searchlabel.Text = "Buscar reporte";
            Searchlabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(398, 20);
            textBox1.Margin = new Padding(20, 20, 3, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(755, 47);
            textBox1.TabIndex = 1;
            // 
            // SearchButton
            // 
            SearchButton.BackColor = Color.Transparent;
            SearchButton.Image = (Image)resources.GetObject("SearchButton.Image");
            SearchButton.Location = new Point(1176, 15);
            SearchButton.Margin = new Padding(20, 15, 3, 3);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(54, 50);
            SearchButton.SizeMode = PictureBoxSizeMode.StretchImage;
            SearchButton.TabIndex = 2;
            SearchButton.TabStop = false;
            // 
            // SalesreportForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 733);
            Controls.Add(flowLayoutPanel2);
            Name = "SalesreportForm";
            Text = "SalesreportForm";
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SearchButton).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel2;
        private Label Searchlabel;
        private TextBox textBox1;
        private PictureBox SearchButton;
    }
}