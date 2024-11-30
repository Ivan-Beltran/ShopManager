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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            Searchlabel = new Label();
            SearchButton = new PictureBox();
            salesReportDataGridView = new DataGridView();
            searchGroupBox = new GroupBox();
            showAllReportsButton = new FontAwesome.Sharp.IconButton();
            searchReportdateTimePicker = new DateTimePicker();
            productsBuyingDataGridView = new DataGridView();
            listProductsLabel = new Label();
            viewDetailsButton = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)SearchButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)salesReportDataGridView).BeginInit();
            searchGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)productsBuyingDataGridView).BeginInit();
            SuspendLayout();
            // 
            // Searchlabel
            // 
            Searchlabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Searchlabel.AutoSize = true;
            Searchlabel.BackColor = Color.Transparent;
            Searchlabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            Searchlabel.ForeColor = SystemColors.Control;
            Searchlabel.Location = new Point(19, 20);
            Searchlabel.Margin = new Padding(88, 11, 0, 0);
            Searchlabel.Name = "Searchlabel";
            Searchlabel.Size = new Size(243, 25);
            Searchlabel.TabIndex = 0;
            Searchlabel.Text = "Buscar reporte por fecha :";
            Searchlabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SearchButton
            // 
            SearchButton.BackColor = Color.Transparent;
            SearchButton.Image = (Image)resources.GetObject("SearchButton.Image");
            SearchButton.Location = new Point(797, 13);
            SearchButton.Margin = new Padding(18, 11, 3, 2);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(47, 38);
            SearchButton.SizeMode = PictureBoxSizeMode.StretchImage;
            SearchButton.TabIndex = 2;
            SearchButton.TabStop = false;
            SearchButton.Click += SearchButton_Click;
            // 
            // salesReportDataGridView
            // 
            salesReportDataGridView.AllowUserToAddRows = false;
            salesReportDataGridView.AllowUserToDeleteRows = false;
            salesReportDataGridView.AllowUserToResizeColumns = false;
            salesReportDataGridView.AllowUserToResizeRows = false;
            salesReportDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            salesReportDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            salesReportDataGridView.BackgroundColor = Color.Azure;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            salesReportDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            salesReportDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            salesReportDataGridView.Location = new Point(25, 132);
            salesReportDataGridView.MultiSelect = false;
            salesReportDataGridView.Name = "salesReportDataGridView";
            salesReportDataGridView.RowHeadersVisible = false;
            salesReportDataGridView.RowHeadersWidth = 51;
            salesReportDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            salesReportDataGridView.Size = new Size(977, 204);
            salesReportDataGridView.TabIndex = 2;
            // 
            // searchGroupBox
            // 
            searchGroupBox.BackColor = Color.Teal;
            searchGroupBox.Controls.Add(showAllReportsButton);
            searchGroupBox.Controls.Add(searchReportdateTimePicker);
            searchGroupBox.Controls.Add(Searchlabel);
            searchGroupBox.Controls.Add(SearchButton);
            searchGroupBox.Location = new Point(25, 27);
            searchGroupBox.Margin = new Padding(3, 2, 3, 2);
            searchGroupBox.Name = "searchGroupBox";
            searchGroupBox.Padding = new Padding(3, 2, 3, 2);
            searchGroupBox.Size = new Size(1068, 66);
            searchGroupBox.TabIndex = 24;
            searchGroupBox.TabStop = false;
            // 
            // showAllReportsButton
            // 
            showAllReportsButton.BackColor = Color.Black;
            showAllReportsButton.FlatStyle = FlatStyle.Popup;
            showAllReportsButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            showAllReportsButton.ForeColor = Color.White;
            showAllReportsButton.IconChar = FontAwesome.Sharp.IconChar.Eye;
            showAllReportsButton.IconColor = Color.Gainsboro;
            showAllReportsButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            showAllReportsButton.ImageAlign = ContentAlignment.MiddleLeft;
            showAllReportsButton.Location = new Point(896, 16);
            showAllReportsButton.Margin = new Padding(3, 2, 3, 2);
            showAllReportsButton.Name = "showAllReportsButton";
            showAllReportsButton.Size = new Size(132, 34);
            showAllReportsButton.TabIndex = 18;
            showAllReportsButton.Text = "ver todo";
            showAllReportsButton.TextAlign = ContentAlignment.MiddleRight;
            showAllReportsButton.UseVisualStyleBackColor = false;
            showAllReportsButton.Click += showAllReportsButton_Click;
            // 
            // searchReportdateTimePicker
            // 
            searchReportdateTimePicker.Location = new Point(331, 23);
            searchReportdateTimePicker.Margin = new Padding(3, 2, 3, 2);
            searchReportdateTimePicker.Name = "searchReportdateTimePicker";
            searchReportdateTimePicker.Size = new Size(434, 23);
            searchReportdateTimePicker.TabIndex = 3;
            // 
            // productsBuyingDataGridView
            // 
            productsBuyingDataGridView.AllowUserToAddRows = false;
            productsBuyingDataGridView.AllowUserToDeleteRows = false;
            productsBuyingDataGridView.AllowUserToResizeColumns = false;
            productsBuyingDataGridView.AllowUserToResizeRows = false;
            productsBuyingDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            productsBuyingDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            productsBuyingDataGridView.BackgroundColor = Color.Azure;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            productsBuyingDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            productsBuyingDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productsBuyingDataGridView.Location = new Point(25, 402);
            productsBuyingDataGridView.MultiSelect = false;
            productsBuyingDataGridView.Name = "productsBuyingDataGridView";
            productsBuyingDataGridView.RowHeadersVisible = false;
            productsBuyingDataGridView.RowHeadersWidth = 51;
            productsBuyingDataGridView.Size = new Size(977, 204);
            productsBuyingDataGridView.TabIndex = 25;
            // 
            // listProductsLabel
            // 
            listProductsLabel.AutoSize = true;
            listProductsLabel.Font = new Font("Segoe UI", 14F);
            listProductsLabel.Location = new Point(405, 362);
            listProductsLabel.Name = "listProductsLabel";
            listProductsLabel.Size = new Size(196, 25);
            listProductsLabel.TabIndex = 26;
            listProductsLabel.Text = "productos comprados";
            // 
            // viewDetailsButton
            // 
            viewDetailsButton.BackColor = Color.FromArgb(0, 166, 225);
            viewDetailsButton.FlatStyle = FlatStyle.Popup;
            viewDetailsButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            viewDetailsButton.ForeColor = Color.White;
            viewDetailsButton.IconChar = FontAwesome.Sharp.IconChar.DeleteLeft;
            viewDetailsButton.IconColor = Color.White;
            viewDetailsButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            viewDetailsButton.IconSize = 38;
            viewDetailsButton.ImageAlign = ContentAlignment.MiddleLeft;
            viewDetailsButton.Location = new Point(1032, 229);
            viewDetailsButton.Name = "viewDetailsButton";
            viewDetailsButton.Size = new Size(144, 40);
            viewDetailsButton.TabIndex = 27;
            viewDetailsButton.Text = "ver detalles";
            viewDetailsButton.TextAlign = ContentAlignment.MiddleRight;
            viewDetailsButton.UseVisualStyleBackColor = false;
            viewDetailsButton.Click += viewDetailsButton_Click;
            // 
            // SalesreportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1212, 698);
            Controls.Add(viewDetailsButton);
            Controls.Add(listProductsLabel);
            Controls.Add(productsBuyingDataGridView);
            Controls.Add(searchGroupBox);
            Controls.Add(salesReportDataGridView);
            Margin = new Padding(3, 2, 3, 2);
            Name = "SalesreportForm";
            Text = "SalesreportForm";
            ((System.ComponentModel.ISupportInitialize)SearchButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)salesReportDataGridView).EndInit();
            searchGroupBox.ResumeLayout(false);
            searchGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)productsBuyingDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label Searchlabel;
        private PictureBox SearchButton;
        private DataGridView salesReportDataGridView;
        private GroupBox searchGroupBox;
        private DateTimePicker searchReportdateTimePicker;
        private FontAwesome.Sharp.IconButton showAllReportsButton;
        private DataGridView productsBuyingDataGridView;
        private Label listProductsLabel;
        private FontAwesome.Sharp.IconButton viewDetailsButton;
    }
}