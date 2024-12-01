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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            Searchlabel = new Label();
            SearchButton = new PictureBox();
            salesReportDataGridView = new DataGridView();
            searchGroupBox = new GroupBox();
            showAllReportsButton = new FontAwesome.Sharp.IconButton();
            searchReportdateTimePicker = new DateTimePicker();
            productsBuyingDataGridView = new DataGridView();
            listProductsLabel = new Label();
            tittleLabel = new Label();
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
            Searchlabel.Location = new Point(22, 27);
            Searchlabel.Margin = new Padding(101, 15, 0, 0);
            Searchlabel.Name = "Searchlabel";
            Searchlabel.Size = new Size(312, 32);
            Searchlabel.TabIndex = 0;
            Searchlabel.Text = "Buscar reporte por fecha :";
            Searchlabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SearchButton
            // 
            SearchButton.BackColor = Color.Transparent;
            SearchButton.Image = (Image)resources.GetObject("SearchButton.Image");
            SearchButton.Location = new Point(911, 17);
            SearchButton.Margin = new Padding(21, 15, 3, 3);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(54, 51);
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
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            salesReportDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            salesReportDataGridView.Location = new Point(28, 247);
            salesReportDataGridView.Margin = new Padding(3, 4, 3, 4);
            salesReportDataGridView.MultiSelect = false;
            salesReportDataGridView.Name = "salesReportDataGridView";
            salesReportDataGridView.RowHeadersVisible = false;
            salesReportDataGridView.RowHeadersWidth = 51;
            salesReportDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            salesReportDataGridView.Size = new Size(1117, 234);
            salesReportDataGridView.TabIndex = 2;
            salesReportDataGridView.SelectionChanged += salesReportDataGridView_SelectionChanged;
            // 
            // searchGroupBox
            // 
            searchGroupBox.BackColor = Color.Teal;
            searchGroupBox.Controls.Add(showAllReportsButton);
            searchGroupBox.Controls.Add(searchReportdateTimePicker);
            searchGroupBox.Controls.Add(Searchlabel);
            searchGroupBox.Controls.Add(SearchButton);
            searchGroupBox.Location = new Point(29, 36);
            searchGroupBox.Name = "searchGroupBox";
            searchGroupBox.Size = new Size(1221, 88);
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
            showAllReportsButton.Location = new Point(1024, 21);
            showAllReportsButton.Name = "showAllReportsButton";
            showAllReportsButton.Size = new Size(151, 45);
            showAllReportsButton.TabIndex = 18;
            showAllReportsButton.Text = "ver todo";
            showAllReportsButton.TextAlign = ContentAlignment.MiddleRight;
            showAllReportsButton.UseVisualStyleBackColor = false;
            showAllReportsButton.Click += showAllReportsButton_Click;
            // 
            // searchReportdateTimePicker
            // 
            searchReportdateTimePicker.Location = new Point(378, 31);
            searchReportdateTimePicker.Name = "searchReportdateTimePicker";
            searchReportdateTimePicker.Size = new Size(495, 27);
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
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            productsBuyingDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            productsBuyingDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            productsBuyingDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            productsBuyingDataGridView.Location = new Point(34, 562);
            productsBuyingDataGridView.Margin = new Padding(3, 4, 3, 4);
            productsBuyingDataGridView.MultiSelect = false;
            productsBuyingDataGridView.Name = "productsBuyingDataGridView";
            productsBuyingDataGridView.RowHeadersVisible = false;
            productsBuyingDataGridView.RowHeadersWidth = 51;
            productsBuyingDataGridView.Size = new Size(1117, 217);
            productsBuyingDataGridView.TabIndex = 25;
            // 
            // listProductsLabel
            // 
            listProductsLabel.AutoSize = true;
            listProductsLabel.Font = new Font("Segoe UI", 14F);
            listProductsLabel.Location = new Point(468, 509);
            listProductsLabel.Name = "listProductsLabel";
            listProductsLabel.Size = new Size(329, 32);
            listProductsLabel.TabIndex = 26;
            listProductsLabel.Text = "lista de productos comprados";
            // 
            // tittleLabel
            // 
            tittleLabel.AutoSize = true;
            tittleLabel.Font = new Font("Segoe UI", 14F);
            tittleLabel.Location = new Point(447, 160);
            tittleLabel.Name = "tittleLabel";
            tittleLabel.Size = new Size(182, 32);
            tittleLabel.TabIndex = 27;
            tittleLabel.Text = "ventas realizdas";
            // 
            // SalesreportForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1385, 931);
            Controls.Add(tittleLabel);
            Controls.Add(listProductsLabel);
            Controls.Add(productsBuyingDataGridView);
            Controls.Add(searchGroupBox);
            Controls.Add(salesReportDataGridView);
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
        private Label tittleLabel;
    }
}