﻿namespace PresentationLayer.Forms
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
            ((System.ComponentModel.ISupportInitialize)SupplierDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)validationErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // suppliersLabel
            // 
            suppliersLabel.AutoSize = true;
            suppliersLabel.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            suppliersLabel.Location = new Point(145, 67);
            suppliersLabel.Name = "suppliersLabel";
            suppliersLabel.Size = new Size(198, 25);
            suppliersLabel.TabIndex = 1;
            suppliersLabel.Text = "Registrar Proveedor";
            // 
            // nameSupplierLabel
            // 
            nameSupplierLabel.AutoSize = true;
            nameSupplierLabel.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameSupplierLabel.Location = new Point(106, 165);
            nameSupplierLabel.Name = "nameSupplierLabel";
            nameSupplierLabel.Size = new Size(67, 20);
            nameSupplierLabel.TabIndex = 2;
            nameSupplierLabel.Text = "Nombre:";
            // 
            // nameSupplierTextBox
            // 
            nameSupplierTextBox.Location = new Point(242, 157);
            nameSupplierTextBox.Name = "nameSupplierTextBox";
            nameSupplierTextBox.Size = new Size(213, 23);
            nameSupplierTextBox.TabIndex = 3;
            // 
            // phoneSupplierTextBox
            // 
            phoneSupplierTextBox.Location = new Point(242, 225);
            phoneSupplierTextBox.Name = "phoneSupplierTextBox";
            phoneSupplierTextBox.Size = new Size(213, 23);
            phoneSupplierTextBox.TabIndex = 5;
            // 
            // phoneSupplierLabel
            // 
            phoneSupplierLabel.AutoSize = true;
            phoneSupplierLabel.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phoneSupplierLabel.Location = new Point(106, 228);
            phoneSupplierLabel.Name = "phoneSupplierLabel";
            phoneSupplierLabel.Size = new Size(71, 20);
            phoneSupplierLabel.TabIndex = 4;
            phoneSupplierLabel.Text = "Teléfono:";
            // 
            // emailSupplierTextBox
            // 
            emailSupplierTextBox.Location = new Point(242, 295);
            emailSupplierTextBox.Name = "emailSupplierTextBox";
            emailSupplierTextBox.Size = new Size(213, 23);
            emailSupplierTextBox.TabIndex = 7;
            // 
            // emailSupplierLabel
            // 
            emailSupplierLabel.AutoSize = true;
            emailSupplierLabel.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailSupplierLabel.Location = new Point(106, 298);
            emailSupplierLabel.Name = "emailSupplierLabel";
            emailSupplierLabel.Size = new Size(51, 20);
            emailSupplierLabel.TabIndex = 6;
            emailSupplierLabel.Text = "Gmail:";
            // 
            // addressSupplierTextBox
            // 
            addressSupplierTextBox.Location = new Point(242, 368);
            addressSupplierTextBox.Name = "addressSupplierTextBox";
            addressSupplierTextBox.Size = new Size(213, 23);
            addressSupplierTextBox.TabIndex = 9;
            // 
            // addressSupplierLabel
            // 
            addressSupplierLabel.AutoSize = true;
            addressSupplierLabel.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addressSupplierLabel.Location = new Point(106, 371);
            addressSupplierLabel.Name = "addressSupplierLabel";
            addressSupplierLabel.Size = new Size(75, 20);
            addressSupplierLabel.TabIndex = 8;
            addressSupplierLabel.Text = "Dirección:";
            // 
            // registerSupplierButton
            // 
            registerSupplierButton.BackColor = Color.FromArgb(0, 166, 225);
            registerSupplierButton.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            registerSupplierButton.ForeColor = Color.White;
            registerSupplierButton.IconChar = FontAwesome.Sharp.IconChar.Save;
            registerSupplierButton.IconColor = Color.White;
            registerSupplierButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            registerSupplierButton.IconSize = 32;
            registerSupplierButton.ImageAlign = ContentAlignment.MiddleLeft;
            registerSupplierButton.Location = new Point(71, 513);
            registerSupplierButton.Name = "registerSupplierButton";
            registerSupplierButton.Size = new Size(152, 37);
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
            SupplierDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SupplierDataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            SupplierDataGridView.Location = new Point(503, 157);
            SupplierDataGridView.MultiSelect = false;
            SupplierDataGridView.Name = "SupplierDataGridView";
            SupplierDataGridView.ReadOnly = true;
            SupplierDataGridView.RowHeadersVisible = false;
            SupplierDataGridView.RowHeadersWidth = 51;
            SupplierDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            SupplierDataGridView.Size = new Size(811, 280);
            SupplierDataGridView.TabIndex = 11;
            SupplierDataGridView.SelectionChanged += SupplierDataGridView_SelectionChanged;
            // 
            // editSupplierButton
            // 
            editSupplierButton.BackColor = Color.FromArgb(0, 166, 225);
            editSupplierButton.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editSupplierButton.ForeColor = Color.White;
            editSupplierButton.IconChar = FontAwesome.Sharp.IconChar.Edit;
            editSupplierButton.IconColor = Color.White;
            editSupplierButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            editSupplierButton.IconSize = 32;
            editSupplierButton.ImageAlign = ContentAlignment.MiddleLeft;
            editSupplierButton.Location = new Point(257, 513);
            editSupplierButton.Name = "editSupplierButton";
            editSupplierButton.Size = new Size(152, 37);
            editSupplierButton.TabIndex = 12;
            editSupplierButton.Text = "Editar";
            editSupplierButton.UseVisualStyleBackColor = false;
            editSupplierButton.Click += editSupplierButton_Click;
            // 
            // deleteSupplierButton
            // 
            deleteSupplierButton.BackColor = Color.FromArgb(0, 166, 225);
            deleteSupplierButton.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteSupplierButton.ForeColor = SystemColors.Window;
            deleteSupplierButton.IconChar = FontAwesome.Sharp.IconChar.DeleteLeft;
            deleteSupplierButton.IconColor = Color.White;
            deleteSupplierButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            deleteSupplierButton.IconSize = 32;
            deleteSupplierButton.ImageAlign = ContentAlignment.MiddleLeft;
            deleteSupplierButton.Location = new Point(452, 513);
            deleteSupplierButton.Name = "deleteSupplierButton";
            deleteSupplierButton.Size = new Size(152, 37);
            deleteSupplierButton.TabIndex = 13;
            deleteSupplierButton.Text = "Eliminar";
            deleteSupplierButton.UseVisualStyleBackColor = false;
            deleteSupplierButton.Click += deleteSupplierButton_Click;
            // 
            // clearRowButton
            // 
            clearRowButton.BackColor = Color.FromArgb(0, 166, 225);
            clearRowButton.FlatStyle = FlatStyle.Popup;
            clearRowButton.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clearRowButton.ForeColor = Color.White;
            clearRowButton.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            clearRowButton.IconColor = Color.White;
            clearRowButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            clearRowButton.IconSize = 38;
            clearRowButton.ImageAlign = ContentAlignment.MiddleLeft;
            clearRowButton.Location = new Point(658, 510);
            clearRowButton.Name = "clearRowButton";
            clearRowButton.Size = new Size(178, 40);
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
            // RegisterSuppliersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1369, 610);
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
            Controls.Add(suppliersLabel);
            Name = "RegisterSuppliersForm";
            Text = "RegisterSuppliersForm";
            ((System.ComponentModel.ISupportInitialize)SupplierDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)validationErrorProvider).EndInit();
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
    }
}