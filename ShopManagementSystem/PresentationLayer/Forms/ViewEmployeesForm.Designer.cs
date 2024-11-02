namespace PresentationLayer.Forms
{
    partial class ViewEmployeesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewEmployeesForm));
            panel1 = new Panel();
            emplyeesIconPictureBox = new PictureBox();
            searchEmployeeTextBox = new ComboBox();
            searchEmployeeLabel = new Label();
            EmployeesDataGridView = new DataGridView();
            btnAddEmployee = new Button();
            btnEditEmployee = new Button();
            btnDeteleEmployee = new Button();
            addEmployeeTextBox = new TextBox();
            boxEditEmployee = new ComboBox();
            boxDeteleEmployee = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)emplyeesIconPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EmployeesDataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(emplyeesIconPictureBox);
            panel1.Controls.Add(searchEmployeeTextBox);
            panel1.Controls.Add(searchEmployeeLabel);
            panel1.Location = new Point(-35, -3);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1431, 85);
            panel1.TabIndex = 1;
            // 
            // emplyeesIconPictureBox
            // 
            emplyeesIconPictureBox.BackColor = Color.FromArgb(224, 224, 224);
            emplyeesIconPictureBox.Image = (Image)resources.GetObject("emplyeesIconPictureBox.Image");
            emplyeesIconPictureBox.Location = new Point(112, 15);
            emplyeesIconPictureBox.Margin = new Padding(3, 4, 3, 4);
            emplyeesIconPictureBox.Name = "emplyeesIconPictureBox";
            emplyeesIconPictureBox.Size = new Size(114, 67);
            emplyeesIconPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            emplyeesIconPictureBox.TabIndex = 9;
            emplyeesIconPictureBox.TabStop = false;
            // 
            // searchEmployeeTextBox
            // 
            searchEmployeeTextBox.FormattingEnabled = true;
            searchEmployeeTextBox.Location = new Point(456, 28);
            searchEmployeeTextBox.Margin = new Padding(3, 4, 3, 4);
            searchEmployeeTextBox.Name = "searchEmployeeTextBox";
            searchEmployeeTextBox.Size = new Size(548, 28);
            searchEmployeeTextBox.TabIndex = 2;
            // 
            // searchEmployeeLabel
            // 
            searchEmployeeLabel.AutoSize = true;
            searchEmployeeLabel.BackColor = Color.WhiteSmoke;
            searchEmployeeLabel.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchEmployeeLabel.ForeColor = SystemColors.ActiveCaptionText;
            searchEmployeeLabel.Location = new Point(233, 28);
            searchEmployeeLabel.Name = "searchEmployeeLabel";
            searchEmployeeLabel.Size = new Size(211, 32);
            searchEmployeeLabel.TabIndex = 0;
            searchEmployeeLabel.Text = "Buscar Empleado";
            // 
            // EmployeesDataGridView
            // 
            EmployeesDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            EmployeesDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            EmployeesDataGridView.BackgroundColor = Color.Lavender;
            EmployeesDataGridView.ColumnHeadersHeight = 29;
            EmployeesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            EmployeesDataGridView.Location = new Point(27, 141);
            EmployeesDataGridView.Margin = new Padding(3, 4, 3, 4);
            EmployeesDataGridView.Name = "EmployeesDataGridView";
            EmployeesDataGridView.RowHeadersWidth = 51;
            EmployeesDataGridView.Size = new Size(1369, 336);
            EmployeesDataGridView.TabIndex = 2;
            // 
            // btnAddEmployee
            // 
            btnAddEmployee.BackColor = Color.FromArgb(0, 166, 225);
            btnAddEmployee.Font = new Font("Segoe UI Historic", 11F, FontStyle.Bold);
            btnAddEmployee.ForeColor = Color.White;
            btnAddEmployee.Location = new Point(819, 563);
            btnAddEmployee.Margin = new Padding(3, 4, 3, 4);
            btnAddEmployee.Name = "btnAddEmployee";
            btnAddEmployee.Size = new Size(263, 49);
            btnAddEmployee.TabIndex = 3;
            btnAddEmployee.Text = "Agregar nuevo empledo";
            btnAddEmployee.UseVisualStyleBackColor = false;
            // 
            // btnEditEmployee
            // 
            btnEditEmployee.BackColor = Color.FromArgb(0, 166, 225);
            btnEditEmployee.Font = new Font("Segoe UI Historic", 11F, FontStyle.Bold);
            btnEditEmployee.ForeColor = Color.White;
            btnEditEmployee.Location = new Point(819, 663);
            btnEditEmployee.Margin = new Padding(3, 4, 3, 4);
            btnEditEmployee.Name = "btnEditEmployee";
            btnEditEmployee.Size = new Size(263, 49);
            btnEditEmployee.TabIndex = 4;
            btnEditEmployee.Text = "Editar empleado";
            btnEditEmployee.UseVisualStyleBackColor = false;
            // 
            // btnDeteleEmployee
            // 
            btnDeteleEmployee.BackColor = Color.FromArgb(0, 166, 225);
            btnDeteleEmployee.Font = new Font("Segoe UI Historic", 11F, FontStyle.Bold);
            btnDeteleEmployee.ForeColor = Color.White;
            btnDeteleEmployee.Location = new Point(819, 767);
            btnDeteleEmployee.Margin = new Padding(3, 4, 3, 4);
            btnDeteleEmployee.Name = "btnDeteleEmployee";
            btnDeteleEmployee.Size = new Size(263, 49);
            btnDeteleEmployee.TabIndex = 5;
            btnDeteleEmployee.Text = "Borrar empleado";
            btnDeteleEmployee.UseVisualStyleBackColor = false;
            // 
            // addEmployeeTextBox
            // 
            addEmployeeTextBox.Location = new Point(98, 575);
            addEmployeeTextBox.Margin = new Padding(3, 4, 3, 4);
            addEmployeeTextBox.Name = "addEmployeeTextBox";
            addEmployeeTextBox.Size = new Size(548, 27);
            addEmployeeTextBox.TabIndex = 6;
            // 
            // boxEditEmployee
            // 
            boxEditEmployee.FormattingEnabled = true;
            boxEditEmployee.Location = new Point(98, 675);
            boxEditEmployee.Margin = new Padding(3, 4, 3, 4);
            boxEditEmployee.Name = "boxEditEmployee";
            boxEditEmployee.Size = new Size(548, 28);
            boxEditEmployee.TabIndex = 7;
            // 
            // boxDeteleEmployee
            // 
            boxDeteleEmployee.FormattingEnabled = true;
            boxDeteleEmployee.Location = new Point(98, 779);
            boxDeteleEmployee.Margin = new Padding(3, 4, 3, 4);
            boxDeteleEmployee.Name = "boxDeteleEmployee";
            boxDeteleEmployee.Size = new Size(548, 28);
            boxDeteleEmployee.TabIndex = 8;
            // 
            // ViewEmployeesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1419, 872);
            Controls.Add(boxDeteleEmployee);
            Controls.Add(boxEditEmployee);
            Controls.Add(addEmployeeTextBox);
            Controls.Add(btnDeteleEmployee);
            Controls.Add(btnEditEmployee);
            Controls.Add(btnAddEmployee);
            Controls.Add(EmployeesDataGridView);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ViewEmployeesForm";
            Text = "ViewEmployees";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)emplyeesIconPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)EmployeesDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private ComboBox searchEmployeeTextBox;
        private Label searchEmployeeLabel;
        private DataGridView EmployeesDataGridView;
        private Button btnAddEmployee;
        private Button btnEditEmployee;
        private Button btnDeteleEmployee;
        private TextBox addEmployeeTextBox;
        private ComboBox boxEditEmployee;
        private ComboBox boxDeteleEmployee;
        private PictureBox emplyeesIconPictureBox;
    }
}