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
            Searchlabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Searchlabel.ForeColor = SystemColors.Control;
            Searchlabel.Location = new Point(258, 24);
            Searchlabel.Margin = new Padding(101, 15, 0, 0);
            Searchlabel.Name = "Searchlabel";
            Searchlabel.Size = new Size(381, 41);
            Searchlabel.TabIndex = 0;
            Searchlabel.Text = "Buscar reporte por fecha :";
            Searchlabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SearchButton
            // 
            SearchButton.BackColor = Color.Transparent;
            SearchButton.Image = (Image)resources.GetObject("SearchButton.Image");
            SearchButton.Location = new Point(1171, 20);
            SearchButton.Margin = new Padding(21, 15, 3, 3);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(52, 51);
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
            salesReportDataGridView.Location = new Point(78, 259);
            salesReportDataGridView.Margin = new Padding(3, 4, 3, 4);
            salesReportDataGridView.MultiSelect = false;
            salesReportDataGridView.Name = "salesReportDataGridView";
            salesReportDataGridView.RowHeadersVisible = false;
            salesReportDataGridView.RowHeadersWidth = 51;
            salesReportDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            salesReportDataGridView.Size = new Size(1117, 192);
            salesReportDataGridView.TabIndex = 2;
            salesReportDataGridView.SelectionChanged += salesReportDataGridView_SelectionChanged;
            // 
            // searchGroupBox
            // 
            searchGroupBox.BackColor = Color.FromArgb(0, 166, 225);
            searchGroupBox.Controls.Add(showAllReportsButton);
            searchGroupBox.Controls.Add(searchReportdateTimePicker);
            searchGroupBox.Controls.Add(Searchlabel);
            searchGroupBox.Controls.Add(SearchButton);
            searchGroupBox.Dock = DockStyle.Top;
            searchGroupBox.Location = new Point(0, 0);
            searchGroupBox.Name = "searchGroupBox";
            searchGroupBox.Size = new Size(1676, 88);
            searchGroupBox.TabIndex = 24;
            searchGroupBox.TabStop = false;
            // 
            // showAllReportsButton
            // 
            showAllReportsButton.BackColor = Color.Transparent;
            showAllReportsButton.FlatStyle = FlatStyle.Popup;
            showAllReportsButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            showAllReportsButton.ForeColor = Color.White;
            showAllReportsButton.IconChar = FontAwesome.Sharp.IconChar.Eye;
            showAllReportsButton.IconColor = Color.White;
            showAllReportsButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            showAllReportsButton.ImageAlign = ContentAlignment.MiddleLeft;
            showAllReportsButton.Location = new Point(1245, 20);
            showAllReportsButton.Name = "showAllReportsButton";
            showAllReportsButton.Size = new Size(247, 45);
            showAllReportsButton.TabIndex = 18;
            showAllReportsButton.Text = "ver todo";
            showAllReportsButton.UseVisualStyleBackColor = false;
            showAllReportsButton.Click += showAllReportsButton_Click;
            // 
            // searchReportdateTimePicker
            // 
            searchReportdateTimePicker.CalendarFont = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchReportdateTimePicker.Location = new Point(652, 34);
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
            productsBuyingDataGridView.Location = new Point(83, 570);
            productsBuyingDataGridView.Margin = new Padding(3, 4, 3, 4);
            productsBuyingDataGridView.MultiSelect = false;
            productsBuyingDataGridView.Name = "productsBuyingDataGridView";
            productsBuyingDataGridView.RowHeadersVisible = false;
            productsBuyingDataGridView.RowHeadersWidth = 51;
            productsBuyingDataGridView.Size = new Size(1117, 200);
            productsBuyingDataGridView.TabIndex = 25;
            // 
            // listProductsLabel
            // 
            listProductsLabel.AutoSize = true;
            listProductsLabel.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listProductsLabel.Location = new Point(295, 484);
            listProductsLabel.Name = "listProductsLabel";
            listProductsLabel.Size = new Size(693, 62);
            listProductsLabel.TabIndex = 26;
            listProductsLabel.Text = "Lista de productos comprados";
            // 
            // tittleLabel
            // 
            tittleLabel.AutoSize = true;
            tittleLabel.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tittleLabel.Location = new Point(447, 166);
            tittleLabel.Name = "tittleLabel";
            tittleLabel.Size = new Size(403, 62);
            tittleLabel.TabIndex = 27;
            tittleLabel.Text = "Ventas realizadas";
            // 
            // SalesreportForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1676, 931);
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