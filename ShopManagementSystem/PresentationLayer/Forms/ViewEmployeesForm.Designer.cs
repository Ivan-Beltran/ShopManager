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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            searchEmployeeButton = new FontAwesome.Sharp.IconButton();
            searchEmployeeTextBox = new TextBox();
            emplyeesIconPictureBox = new PictureBox();
            searchEmployeeLabel = new Label();
            EmployeesDataGridView = new DataGridView();
            namesTextBox = new TextBox();
            nameEmployee = new Label();
            lastNameEmployee = new Label();
            lastNamesTextBox = new TextBox();
            passwordEmployee = new Label();
            passwordTextBox = new TextBox();
            usuarioEmployee = new Label();
            UserTextBox = new TextBox();
            emailEmployee = new Label();
            emailTextBox = new TextBox();
            duiEmployee = new Label();
            duiTextBox = new TextBox();
            addEmployeegroupBox = new GroupBox();
            label1 = new Label();
            rolesComboBox = new ComboBox();
            roleLabel = new Label();
            addEmployeeButton = new FontAwesome.Sharp.IconButton();
            editEmployeeButton = new FontAwesome.Sharp.IconButton();
            deteleEmployeeButton = new FontAwesome.Sharp.IconButton();
            employeeButtonsgroupBox = new GroupBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)emplyeesIconPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EmployeesDataGridView).BeginInit();
            addEmployeegroupBox.SuspendLayout();
            employeeButtonsgroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Controls.Add(searchEmployeeButton);
            panel1.Controls.Add(searchEmployeeTextBox);
            panel1.Controls.Add(emplyeesIconPictureBox);
            panel1.Controls.Add(searchEmployeeLabel);
            panel1.Location = new Point(-35, -3);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(2007, 85);
            panel1.TabIndex = 1;
            // 
            // searchEmployeeButton
            // 
            searchEmployeeButton.BackColor = Color.FromArgb(0, 166, 225);
            searchEmployeeButton.FlatAppearance.BorderColor = Color.Black;
            searchEmployeeButton.FlatAppearance.BorderSize = 2;
            searchEmployeeButton.FlatStyle = FlatStyle.Popup;
            searchEmployeeButton.ForeColor = SystemColors.Control;
            searchEmployeeButton.IconChar = FontAwesome.Sharp.IconChar.Search;
            searchEmployeeButton.IconColor = Color.White;
            searchEmployeeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            searchEmployeeButton.Location = new Point(1183, 23);
            searchEmployeeButton.Name = "searchEmployeeButton";
            searchEmployeeButton.Size = new Size(69, 42);
            searchEmployeeButton.TabIndex = 11;
            searchEmployeeButton.UseVisualStyleBackColor = false;
            searchEmployeeButton.Click += searchEmployeeButton_Click;
            // 
            // searchEmployeeTextBox
            // 
            searchEmployeeTextBox.BorderStyle = BorderStyle.FixedSingle;
            searchEmployeeTextBox.Location = new Point(485, 32);
            searchEmployeeTextBox.Name = "searchEmployeeTextBox";
            searchEmployeeTextBox.Size = new Size(664, 27);
            searchEmployeeTextBox.TabIndex = 10;
            searchEmployeeTextBox.TextChanged += searchEmployeeTextBox_TextChanged;
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
            // searchEmployeeLabel
            // 
            searchEmployeeLabel.AutoSize = true;
            searchEmployeeLabel.BackColor = Color.FromArgb(224, 224, 224);
            searchEmployeeLabel.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchEmployeeLabel.ForeColor = SystemColors.ActiveCaptionText;
            searchEmployeeLabel.Location = new Point(233, 28);
            searchEmployeeLabel.Name = "searchEmployeeLabel";
            searchEmployeeLabel.Size = new Size(227, 31);
            searchEmployeeLabel.TabIndex = 0;
            searchEmployeeLabel.Text = "Buscar Empleado";
            // 
            // EmployeesDataGridView
            // 
            EmployeesDataGridView.AllowUserToAddRows = false;
            EmployeesDataGridView.AllowUserToResizeColumns = false;
            EmployeesDataGridView.AllowUserToResizeRows = false;
            EmployeesDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            EmployeesDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            EmployeesDataGridView.BackgroundColor = SystemColors.Control;
            EmployeesDataGridView.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            EmployeesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            EmployeesDataGridView.ColumnHeadersHeight = 29;
            EmployeesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            EmployeesDataGridView.Cursor = Cursors.Hand;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 166, 225);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            EmployeesDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            EmployeesDataGridView.Location = new Point(27, 141);
            EmployeesDataGridView.Margin = new Padding(3, 4, 3, 4);
            EmployeesDataGridView.MultiSelect = false;
            EmployeesDataGridView.Name = "EmployeesDataGridView";
            EmployeesDataGridView.RowHeadersVisible = false;
            EmployeesDataGridView.RowHeadersWidth = 35;
            EmployeesDataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            EmployeesDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            EmployeesDataGridView.Size = new Size(1287, 367);
            EmployeesDataGridView.TabIndex = 2;
            EmployeesDataGridView.CellClick += EmployeesDataGridView_CellClick;
            // 
            // namesTextBox
            // 
            namesTextBox.BorderStyle = BorderStyle.FixedSingle;
            namesTextBox.Font = new Font("Microsoft Sans Serif", 12F);
            namesTextBox.Location = new Point(147, 98);
            namesTextBox.Margin = new Padding(3, 4, 3, 4);
            namesTextBox.Name = "namesTextBox";
            namesTextBox.Size = new Size(360, 30);
            namesTextBox.TabIndex = 6;
            // 
            // nameEmployee
            // 
            nameEmployee.AutoSize = true;
            nameEmployee.Font = new Font("Microsoft Sans Serif", 12F);
            nameEmployee.Location = new Point(27, 101);
            nameEmployee.Name = "nameEmployee";
            nameEmployee.Size = new Size(87, 25);
            nameEmployee.TabIndex = 9;
            nameEmployee.Text = "Nombre:";
            // 
            // lastNameEmployee
            // 
            lastNameEmployee.AutoSize = true;
            lastNameEmployee.Font = new Font("Microsoft Sans Serif", 12F);
            lastNameEmployee.Location = new Point(551, 101);
            lastNameEmployee.Name = "lastNameEmployee";
            lastNameEmployee.Size = new Size(88, 25);
            lastNameEmployee.TabIndex = 11;
            lastNameEmployee.Text = "Apellido:";
            // 
            // lastNamesTextBox
            // 
            lastNamesTextBox.BorderStyle = BorderStyle.FixedSingle;
            lastNamesTextBox.Font = new Font("Microsoft Sans Serif", 12F);
            lastNamesTextBox.Location = new Point(645, 98);
            lastNamesTextBox.Margin = new Padding(3, 4, 3, 4);
            lastNamesTextBox.Name = "lastNamesTextBox";
            lastNamesTextBox.Size = new Size(347, 30);
            lastNamesTextBox.TabIndex = 10;
            // 
            // passwordEmployee
            // 
            passwordEmployee.AutoSize = true;
            passwordEmployee.Font = new Font("Microsoft Sans Serif", 12F);
            passwordEmployee.Location = new Point(521, 196);
            passwordEmployee.Name = "passwordEmployee";
            passwordEmployee.Size = new Size(120, 25);
            passwordEmployee.TabIndex = 15;
            passwordEmployee.Text = "Contraseña:";
            // 
            // passwordTextBox
            // 
            passwordTextBox.BorderStyle = BorderStyle.FixedSingle;
            passwordTextBox.Font = new Font("Microsoft Sans Serif", 12F);
            passwordTextBox.Location = new Point(647, 193);
            passwordTextBox.Margin = new Padding(3, 4, 3, 4);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(347, 30);
            passwordTextBox.TabIndex = 14;
            // 
            // usuarioEmployee
            // 
            usuarioEmployee.AutoSize = true;
            usuarioEmployee.Font = new Font("Microsoft Sans Serif", 12F);
            usuarioEmployee.Location = new Point(29, 201);
            usuarioEmployee.Name = "usuarioEmployee";
            usuarioEmployee.Size = new Size(85, 25);
            usuarioEmployee.TabIndex = 13;
            usuarioEmployee.Text = "Usuario:";
            // 
            // UserTextBox
            // 
            UserTextBox.BorderStyle = BorderStyle.FixedSingle;
            UserTextBox.Font = new Font("Microsoft Sans Serif", 12F);
            UserTextBox.Location = new Point(149, 198);
            UserTextBox.Margin = new Padding(3, 4, 3, 4);
            UserTextBox.Name = "UserTextBox";
            UserTextBox.Size = new Size(229, 30);
            UserTextBox.TabIndex = 12;
            // 
            // emailEmployee
            // 
            emailEmployee.AutoSize = true;
            emailEmployee.Font = new Font("Microsoft Sans Serif", 12F);
            emailEmployee.Location = new Point(29, 280);
            emailEmployee.Name = "emailEmployee";
            emailEmployee.Size = new Size(68, 25);
            emailEmployee.TabIndex = 19;
            emailEmployee.Text = "Gmail:";
            // 
            // emailTextBox
            // 
            emailTextBox.BorderStyle = BorderStyle.FixedSingle;
            emailTextBox.Font = new Font("Microsoft Sans Serif", 12F);
            emailTextBox.Location = new Point(139, 280);
            emailTextBox.Margin = new Padding(3, 4, 3, 4);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(413, 30);
            emailTextBox.TabIndex = 18;
            // 
            // duiEmployee
            // 
            duiEmployee.AutoSize = true;
            duiEmployee.Font = new Font("Microsoft Sans Serif", 12F);
            duiEmployee.Location = new Point(1196, 185);
            duiEmployee.Name = "duiEmployee";
            duiEmployee.Size = new Size(51, 25);
            duiEmployee.TabIndex = 17;
            duiEmployee.Text = "DUI:";
            // 
            // duiTextBox
            // 
            duiTextBox.BorderStyle = BorderStyle.FixedSingle;
            duiTextBox.Font = new Font("Microsoft Sans Serif", 12F);
            duiTextBox.Location = new Point(1283, 183);
            duiTextBox.Margin = new Padding(3, 4, 3, 4);
            duiTextBox.Name = "duiTextBox";
            duiTextBox.Size = new Size(248, 30);
            duiTextBox.TabIndex = 16;
            // 
            // addEmployeegroupBox
            // 
            addEmployeegroupBox.Controls.Add(label1);
            addEmployeegroupBox.Controls.Add(rolesComboBox);
            addEmployeegroupBox.Controls.Add(roleLabel);
            addEmployeegroupBox.Controls.Add(namesTextBox);
            addEmployeegroupBox.Controls.Add(emailEmployee);
            addEmployeegroupBox.Controls.Add(nameEmployee);
            addEmployeegroupBox.Controls.Add(emailTextBox);
            addEmployeegroupBox.Controls.Add(lastNamesTextBox);
            addEmployeegroupBox.Controls.Add(duiEmployee);
            addEmployeegroupBox.Controls.Add(lastNameEmployee);
            addEmployeegroupBox.Controls.Add(duiTextBox);
            addEmployeegroupBox.Controls.Add(UserTextBox);
            addEmployeegroupBox.Controls.Add(passwordEmployee);
            addEmployeegroupBox.Controls.Add(usuarioEmployee);
            addEmployeegroupBox.Controls.Add(passwordTextBox);
            addEmployeegroupBox.Font = new Font("Segoe UI", 14F);
            addEmployeegroupBox.Location = new Point(27, 562);
            addEmployeegroupBox.Name = "addEmployeegroupBox";
            addEmployeegroupBox.Size = new Size(1562, 385);
            addEmployeegroupBox.TabIndex = 20;
            addEmployeegroupBox.TabStop = false;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(3, 35);
            label1.Name = "label1";
            label1.Size = new Size(1556, 32);
            label1.TabIndex = 22;
            label1.Text = "Datos del empleado";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // rolesComboBox
            // 
            rolesComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            rolesComboBox.Font = new Font("Microsoft Sans Serif", 12F);
            rolesComboBox.FormattingEnabled = true;
            rolesComboBox.Location = new Point(1283, 98);
            rolesComboBox.MaxDropDownItems = 10;
            rolesComboBox.Name = "rolesComboBox";
            rolesComboBox.Size = new Size(248, 33);
            rolesComboBox.TabIndex = 21;
            // 
            // roleLabel
            // 
            roleLabel.AutoSize = true;
            roleLabel.Font = new Font("Microsoft Sans Serif", 12F);
            roleLabel.Location = new Point(1081, 106);
            roleLabel.Name = "roleLabel";
            roleLabel.Size = new Size(180, 25);
            roleLabel.TabIndex = 20;
            roleLabel.Text = "Seleccionar Cargo:";
            // 
            // addEmployeeButton
            // 
            addEmployeeButton.BackColor = Color.FromArgb(0, 166, 225);
            addEmployeeButton.FlatStyle = FlatStyle.Popup;
            addEmployeeButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addEmployeeButton.ForeColor = Color.White;
            addEmployeeButton.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            addEmployeeButton.IconColor = Color.White;
            addEmployeeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            addEmployeeButton.IconSize = 38;
            addEmployeeButton.ImageAlign = ContentAlignment.MiddleLeft;
            addEmployeeButton.Location = new Point(19, 71);
            addEmployeeButton.Margin = new Padding(1);
            addEmployeeButton.Name = "addEmployeeButton";
            addEmployeeButton.Size = new Size(222, 67);
            addEmployeeButton.TabIndex = 22;
            addEmployeeButton.Text = "    Agregar empleado";
            addEmployeeButton.TextAlign = ContentAlignment.MiddleRight;
            addEmployeeButton.UseVisualStyleBackColor = false;
            addEmployeeButton.Click += addEmployeeButton_Click;
            // 
            // editEmployeeButton
            // 
            editEmployeeButton.BackColor = Color.FromArgb(0, 166, 225);
            editEmployeeButton.FlatStyle = FlatStyle.Popup;
            editEmployeeButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            editEmployeeButton.ForeColor = Color.White;
            editEmployeeButton.IconChar = FontAwesome.Sharp.IconChar.Edit;
            editEmployeeButton.IconColor = Color.White;
            editEmployeeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            editEmployeeButton.IconSize = 38;
            editEmployeeButton.ImageAlign = ContentAlignment.MiddleLeft;
            editEmployeeButton.Location = new Point(19, 162);
            editEmployeeButton.Margin = new Padding(3, 4, 3, 4);
            editEmployeeButton.Name = "editEmployeeButton";
            editEmployeeButton.Size = new Size(222, 67);
            editEmployeeButton.TabIndex = 21;
            editEmployeeButton.Text = "        Editar empleado";
            editEmployeeButton.TextAlign = ContentAlignment.MiddleRight;
            editEmployeeButton.UseVisualStyleBackColor = false;
            editEmployeeButton.Click += editEmployeeButton_Click;
            // 
            // deteleEmployeeButton
            // 
            deteleEmployeeButton.BackColor = Color.FromArgb(0, 166, 225);
            deteleEmployeeButton.FlatStyle = FlatStyle.Popup;
            deteleEmployeeButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deteleEmployeeButton.ForeColor = Color.White;
            deteleEmployeeButton.IconChar = FontAwesome.Sharp.IconChar.DeleteLeft;
            deteleEmployeeButton.IconColor = Color.White;
            deteleEmployeeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            deteleEmployeeButton.IconSize = 38;
            deteleEmployeeButton.ImageAlign = ContentAlignment.MiddleLeft;
            deteleEmployeeButton.Location = new Point(19, 250);
            deteleEmployeeButton.Margin = new Padding(3, 4, 3, 4);
            deteleEmployeeButton.Name = "deteleEmployeeButton";
            deteleEmployeeButton.Size = new Size(222, 67);
            deteleEmployeeButton.TabIndex = 22;
            deteleEmployeeButton.Text = "        Borrar empleado";
            deteleEmployeeButton.TextAlign = ContentAlignment.MiddleRight;
            deteleEmployeeButton.UseVisualStyleBackColor = false;
            deteleEmployeeButton.Click += deteleEmployeeButton_Click;
            // 
            // employeeButtonsgroupBox
            // 
            employeeButtonsgroupBox.Controls.Add(addEmployeeButton);
            employeeButtonsgroupBox.Controls.Add(editEmployeeButton);
            employeeButtonsgroupBox.Controls.Add(deteleEmployeeButton);
            employeeButtonsgroupBox.Location = new Point(1329, 141);
            employeeButtonsgroupBox.Name = "employeeButtonsgroupBox";
            employeeButtonsgroupBox.Size = new Size(260, 367);
            employeeButtonsgroupBox.TabIndex = 23;
            employeeButtonsgroupBox.TabStop = false;
            employeeButtonsgroupBox.Text = "acciones";
            // 
            // ViewEmployeesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1611, 1033);
            Controls.Add(addEmployeegroupBox);
            Controls.Add(EmployeesDataGridView);
            Controls.Add(panel1);
            Controls.Add(employeeButtonsgroupBox);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ViewEmployeesForm";
            Opacity = 0.1D;
            Text = "ViewEmployees";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)emplyeesIconPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)EmployeesDataGridView).EndInit();
            addEmployeegroupBox.ResumeLayout(false);
            addEmployeegroupBox.PerformLayout();
            employeeButtonsgroupBox.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label searchEmployeeLabel;
        private DataGridView EmployeesDataGridView;
        private Button btnAddEmployee;
        private TextBox namesTextBox;
        private PictureBox emplyeesIconPictureBox;
        private Label nameEmployee;
        private Label lastNameEmployee;
        private TextBox lastNamesTextBox;
        private Label passwordEmployee;
        private TextBox passwordTextBox;
        private Label usuarioEmployee;
        private TextBox UserTextBox;
        private Label emailEmployee;
        private TextBox emailTextBox;
        private Label duiEmployee;
        private TextBox duiTextBox;
        private GroupBox addEmployeegroupBox;
        private ComboBox rolesComboBox;
        private Label roleLabel;
        private FontAwesome.Sharp.IconButton editEmployeeButton;
        private FontAwesome.Sharp.IconButton deteleEmployeeButton;
        private FontAwesome.Sharp.IconButton addEmployeeButton;
        private GroupBox employeeButtonsgroupBox;
        private Label label1;
        private TextBox searchEmployeeTextBox;
        private FontAwesome.Sharp.IconButton searchEmployeeButton;
    }
}