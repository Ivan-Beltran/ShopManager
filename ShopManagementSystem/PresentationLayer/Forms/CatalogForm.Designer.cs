namespace PresentationLayer.Forms
{
    partial class CatalogForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CatalogForm));
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            Searchlabel = new Label();
            textBox1 = new TextBox();
            SearchButton = new PictureBox();
            shoppingcart = new PictureBox();
            productsControl1 = new Controls.ProductsControl();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SearchButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)shoppingcart).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(flowLayoutPanel2);
            flowLayoutPanel1.Controls.Add(productsControl1);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1687, 787);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = Color.Teal;
            flowLayoutPanel2.Controls.Add(Searchlabel);
            flowLayoutPanel2.Controls.Add(textBox1);
            flowLayoutPanel2.Controls.Add(SearchButton);
            flowLayoutPanel2.Controls.Add(shoppingcart);
            flowLayoutPanel2.Location = new Point(0, 0);
            flowLayoutPanel2.Margin = new Padding(0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(1701, 85);
            flowLayoutPanel2.TabIndex = 0;
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
            Searchlabel.Size = new Size(308, 58);
            Searchlabel.TabIndex = 0;
            Searchlabel.Text = "Buscar producto";
            Searchlabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(428, 20);
            textBox1.Margin = new Padding(20, 20, 3, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(755, 47);
            textBox1.TabIndex = 1;
            // 
            // SearchButton
            // 
            SearchButton.BackColor = Color.Transparent;
            SearchButton.Image = (Image)resources.GetObject("SearchButton.Image");
            SearchButton.Location = new Point(1206, 15);
            SearchButton.Margin = new Padding(20, 15, 3, 3);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(54, 50);
            SearchButton.SizeMode = PictureBoxSizeMode.StretchImage;
            SearchButton.TabIndex = 2;
            SearchButton.TabStop = false;
            SearchButton.Click += SearchButton_Click;
            // 
            // shoppingcart
            // 
            shoppingcart.BackColor = Color.Transparent;
            shoppingcart.Image = (Image)resources.GetObject("shoppingcart.Image");
            shoppingcart.Location = new Point(1293, 10);
            shoppingcart.Margin = new Padding(30, 10, 3, 3);
            shoppingcart.Name = "shoppingcart";
            shoppingcart.Size = new Size(53, 60);
            shoppingcart.SizeMode = PictureBoxSizeMode.StretchImage;
            shoppingcart.TabIndex = 3;
            shoppingcart.TabStop = false;
            shoppingcart.Click += shoppingcart_Click;
            // 
            // productsControl1
            // 
            productsControl1.BackColor = Color.FromArgb(0, 64, 64);
            productsControl1.Location = new Point(0, 85);
            productsControl1.Margin = new Padding(0);
            productsControl1.Name = "productsControl1";
            productsControl1.Size = new Size(851, 318);
            productsControl1.TabIndex = 1;
            // 
            // CatalogForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1687, 787);
            Controls.Add(flowLayoutPanel1);
            Name = "CatalogForm";
            Text = "CatalogForm";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SearchButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)shoppingcart).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label Searchlabel;
        private TextBox textBox1;
        private PictureBox SearchButton;
        private PictureBox shoppingcart;
        private Controls.ProductsControl productsControl1;
    }
}