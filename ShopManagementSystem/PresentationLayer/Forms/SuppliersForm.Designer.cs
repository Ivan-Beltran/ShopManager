namespace PresentationLayer.Forms
{
    partial class RegisterSuppliersForm
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            suppliersLabel = new Label();
            nameSupplierLabel = new Label();
            nameSupplierTextBox = new TextBox();
            phoneSupplierTextBox = new TextBox();
            phoneSupplierLabel = new Label();
            emailSupplierTextBox = new TextBox();
            emailSupplierLabel = new Label();
            addressSupplierTextBox = new TextBox();
            addressSupplierLabel = new Label();
            registerSupplierButton = new FontAwesome.Sharp.IconButton();
            SupplierDataGridView = new DataGridView();
            editSupplierButton = new FontAwesome.Sharp.IconButton();
            deleteSupplierButton = new FontAwesome.Sharp.IconButton();
            clearRowButton = new FontAwesome.Sharp.IconButton();
            validationErrorProvider = new ErrorProvider(components);
            TittlePanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)SupplierDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)validationErrorProvider).BeginInit();
            TittlePanel.SuspendLayout();
            SuspendLayout();
            // 
            // suppliersLabel
            // 
            suppliersLabel.AutoSize = true;
            suppliersLabel.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            suppliersLabel.ForeColor = Color.White;
            suppliersLabel.Location = new Point(636, 9);
            suppliersLabel.Name = "suppliersLabel";
            suppliersLabel.Size = new Size(468, 62);
            suppliersLabel.TabIndex = 1;
            suppliersLabel.Text = "Registrar Proveedor";
            // 
            // nameSupplierLabel
            // 
            nameSupplierLabel.AutoSize = true;
            nameSupplierLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            nameSupplierLabel.Location = new Point(113, 209);
            nameSupplierLabel.Name = "nameSupplierLabel";
            nameSupplierLabel.Size = new Size(142, 41);
            nameSupplierLabel.TabIndex = 2;
            nameSupplierLabel.Text = "Nombre:";
            // 
            // nameSupplierTextBox
            // 
            nameSupplierTextBox.Location = new Point(277, 209);
            nameSupplierTextBox.Margin = new Padding(3, 4, 3, 4);
            nameSupplierTextBox.Name = "nameSupplierTextBox";
            nameSupplierTextBox.Size = new Size(243, 27);
            nameSupplierTextBox.TabIndex = 3;
            // 
            // phoneSupplierTextBox
            // 
            phoneSupplierTextBox.Location = new Point(277, 300);
            phoneSupplierTextBox.Margin = new Padding(3, 4, 3, 4);
            phoneSupplierTextBox.Name = "phoneSupplierTextBox";
            phoneSupplierTextBox.Size = new Size(243, 27);
            phoneSupplierTextBox.TabIndex = 5;
            // 
            // phoneSupplierLabel
            // 
            phoneSupplierLabel.AutoSize = true;
            phoneSupplierLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            phoneSupplierLabel.Location = new Point(113, 286);
            phoneSupplierLabel.Name = "phoneSupplierLabel";
            phoneSupplierLabel.Size = new Size(148, 41);
            phoneSupplierLabel.TabIndex = 4;
            phoneSupplierLabel.Text = "Teléfono:";
            // 
            // emailSupplierTextBox
            // 
            emailSupplierTextBox.Location = new Point(277, 393);
            emailSupplierTextBox.Margin = new Padding(3, 4, 3, 4);
            emailSupplierTextBox.Name = "emailSupplierTextBox";
            emailSupplierTextBox.Size = new Size(243, 27);
            emailSupplierTextBox.TabIndex = 7;
            // 
            // emailSupplierLabel
            // 
            emailSupplierLabel.AutoSize = true;
            emailSupplierLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            emailSupplierLabel.Location = new Point(113, 379);
            emailSupplierLabel.Name = "emailSupplierLabel";
            emailSupplierLabel.Size = new Size(108, 41);
            emailSupplierLabel.TabIndex = 6;
            emailSupplierLabel.Text = "Gmail:";
            // 
            // addressSupplierTextBox
            // 
            addressSupplierTextBox.Location = new Point(277, 491);
            addressSupplierTextBox.Margin = new Padding(3, 4, 3, 4);
            addressSupplierTextBox.Name = "addressSupplierTextBox";
            addressSupplierTextBox.Size = new Size(243, 27);
            addressSupplierTextBox.TabIndex = 9;
            // 
            // addressSupplierLabel
            // 
            addressSupplierLabel.AutoSize = true;
            addressSupplierLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            addressSupplierLabel.Location = new Point(103, 477);
            addressSupplierLabel.Name = "addressSupplierLabel";
            addressSupplierLabel.Size = new Size(158, 41);
            addressSupplierLabel.TabIndex = 8;
            addressSupplierLabel.Text = "Dirección:";
            // 
            // registerSupplierButton
            // 
            registerSupplierButton.BackColor = Color.FromArgb(0, 166, 225);
            registerSupplierButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            registerSupplierButton.ForeColor = Color.White;
            registerSupplierButton.IconChar = FontAwesome.Sharp.IconChar.Save;
            registerSupplierButton.IconColor = Color.White;
            registerSupplierButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            validationErrorProvider.SetIconPadding(registerSupplierButton, 5);
            registerSupplierButton.IconSize = 32;
            registerSupplierButton.ImageAlign = ContentAlignment.MiddleLeft;
            registerSupplierButton.Location = new Point(272, 696);
            registerSupplierButton.Margin = new Padding(3, 4, 3, 4);
            registerSupplierButton.Name = "registerSupplierButton";
            registerSupplierButton.Size = new Size(236, 54);
            registerSupplierButton.TabIndex = 10;
            registerSupplierButton.Text = "Guardar";
            registerSupplierButton.UseVisualStyleBackColor = false;
            registerSupplierButton.Click += registerSupplierButton_Click;
            // 
            // SupplierDataGridView
            // 
            SupplierDataGridView.AllowUserToAddRows = false;
            SupplierDataGridView.AllowUserToDeleteRows = false;
            SupplierDataGridView.AllowUserToResizeColumns = false;
            SupplierDataGridView.AllowUserToResizeRows = false;
            SupplierDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            SupplierDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            SupplierDataGridView.BackgroundColor = Color.Azure;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            SupplierDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            SupplierDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SupplierDataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            SupplierDataGridView.Location = new Point(575, 209);
            SupplierDataGridView.Margin = new Padding(3, 4, 3, 4);
            SupplierDataGridView.MultiSelect = false;
            SupplierDataGridView.Name = "SupplierDataGridView";
            SupplierDataGridView.ReadOnly = true;
            SupplierDataGridView.RowHeadersVisible = false;
            SupplierDataGridView.RowHeadersWidth = 51;
            SupplierDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            SupplierDataGridView.Size = new Size(927, 373);
            SupplierDataGridView.TabIndex = 11;
            SupplierDataGridView.SelectionChanged += SupplierDataGridView_SelectionChanged;
            // 
            // editSupplierButton
            // 
            editSupplierButton.BackColor = Color.FromArgb(0, 166, 225);
            editSupplierButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            editSupplierButton.ForeColor = Color.White;
            editSupplierButton.IconChar = FontAwesome.Sharp.IconChar.Edit;
            editSupplierButton.IconColor = Color.White;
            editSupplierButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            editSupplierButton.IconSize = 32;
            editSupplierButton.ImageAlign = ContentAlignment.MiddleLeft;
            editSupplierButton.Location = new Point(560, 696);
            editSupplierButton.Margin = new Padding(3, 4, 3, 4);
            editSupplierButton.Name = "editSupplierButton";
            editSupplierButton.Size = new Size(239, 54);
            editSupplierButton.TabIndex = 12;
            editSupplierButton.Text = "Editar";
            editSupplierButton.UseVisualStyleBackColor = false;
            editSupplierButton.Click += editSupplierButton_Click;
            // 
            // deleteSupplierButton
            // 
            deleteSupplierButton.BackColor = Color.FromArgb(0, 166, 225);
            deleteSupplierButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteSupplierButton.ForeColor = SystemColors.Window;
            deleteSupplierButton.IconChar = FontAwesome.Sharp.IconChar.DeleteLeft;
            deleteSupplierButton.IconColor = Color.White;
            deleteSupplierButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            deleteSupplierButton.IconSize = 32;
            deleteSupplierButton.ImageAlign = ContentAlignment.MiddleLeft;
            deleteSupplierButton.Location = new Point(853, 696);
            deleteSupplierButton.Margin = new Padding(3, 4, 3, 4);
            deleteSupplierButton.Name = "deleteSupplierButton";
            deleteSupplierButton.Size = new Size(235, 53);
            deleteSupplierButton.TabIndex = 13;
            deleteSupplierButton.Text = "Eliminar";
            deleteSupplierButton.UseVisualStyleBackColor = false;
            deleteSupplierButton.Click += deleteSupplierButton_Click;
            // 
            // clearRowButton
            // 
            clearRowButton.BackColor = Color.FromArgb(0, 166, 225);
            clearRowButton.FlatStyle = FlatStyle.Flat;
            clearRowButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            clearRowButton.ForeColor = Color.White;
            clearRowButton.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            clearRowButton.IconColor = Color.White;
            clearRowButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            clearRowButton.IconSize = 38;
            clearRowButton.ImageAlign = ContentAlignment.MiddleLeft;
            clearRowButton.Location = new Point(1163, 696);
            clearRowButton.Margin = new Padding(3, 4, 3, 4);
            clearRowButton.Name = "clearRowButton";
            clearRowButton.Size = new Size(274, 53);
            clearRowButton.TabIndex = 24;
            clearRowButton.Text = "Quitar selección";
            clearRowButton.TextAlign = ContentAlignment.MiddleRight;
            clearRowButton.UseVisualStyleBackColor = false;
            clearRowButton.Click += clearRowButton_Click;
            // 
            // validationErrorProvider
            // 
            validationErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            validationErrorProvider.ContainerControl = this;
            // 
            // TittlePanel
            // 
            TittlePanel.BackColor = Color.FromArgb(0, 166, 225);
            TittlePanel.Controls.Add(suppliersLabel);
            TittlePanel.Dock = DockStyle.Top;
            TittlePanel.Location = new Point(0, 0);
            TittlePanel.Margin = new Padding(0);
            TittlePanel.Name = "TittlePanel";
            TittlePanel.Size = new Size(1565, 85);
            TittlePanel.TabIndex = 25;
            // 
            // RegisterSuppliersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1565, 813);
            Controls.Add(TittlePanel);
            Controls.Add(clearRowButton);
            Controls.Add(deleteSupplierButton);
            Controls.Add(editSupplierButton);
            Controls.Add(SupplierDataGridView);
            Controls.Add(registerSupplierButton);
            Controls.Add(addressSupplierTextBox);
            Controls.Add(addressSupplierLabel);
            Controls.Add(emailSupplierTextBox);
            Controls.Add(emailSupplierLabel);
            Controls.Add(phoneSupplierTextBox);
            Controls.Add(phoneSupplierLabel);
            Controls.Add(nameSupplierTextBox);
            Controls.Add(nameSupplierLabel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "RegisterSuppliersForm";
            Text = "RegisterSuppliersForm";
            ((System.ComponentModel.ISupportInitialize)SupplierDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)validationErrorProvider).EndInit();
            TittlePanel.ResumeLayout(false);
            TittlePanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label suppliersLabel;
        private Label nameSupplierLabel;
        private TextBox nameSupplierTextBox;
        private TextBox phoneSupplierTextBox;
        private Label phoneSupplierLabel;
        private TextBox emailSupplierTextBox;
        private Label emailSupplierLabel;
        private TextBox addressSupplierTextBox;
        private Label addressSupplierLabel;
        private FontAwesome.Sharp.IconButton registerSupplierButton;
        private DataGridView SupplierDataGridView;
        private FontAwesome.Sharp.IconButton editSupplierButton;
        private FontAwesome.Sharp.IconButton deleteSupplierButton;
        private FontAwesome.Sharp.IconButton clearRowButton;
        private ErrorProvider validationErrorProvider;
        private Panel TittlePanel;
    }
}