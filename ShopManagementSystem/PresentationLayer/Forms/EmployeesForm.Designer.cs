namespace PresentationLayer.Forms
{
    partial class EmployeesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeesForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            searchEmployeeButton = new FontAwesome.Sharp.IconButton();
            emplyeesIconPictureBox = new PictureBox();
            searchEmployeeTextBox = new TextBox();
            searchEmployeeLabel = new Label();
            employeeButtonsgroupBox = new GroupBox();
            clearRowButton = new FontAwesome.Sharp.IconButton();
            addEmployeeButton = new FontAwesome.Sharp.IconButton();
            editEmployeeButton = new FontAwesome.Sharp.IconButton();
            deteleEmployeeButton = new FontAwesome.Sharp.IconButton();
            EmployeesDataGridView = new DataGridView();
            addEmployeegroupBox = new GroupBox();
            label1 = new Label();
            rolesComboBox = new ComboBox();
            roleLabel = new Label();
            namesTextBox = new TextBox();
            emailEmployee = new Label();
            nameEmployee = new Label();
            emailTextBox = new TextBox();
            lastNamesTextBox = new TextBox();
            duiEmployee = new Label();
            lastNameEmployee = new Label();
            duiTextBox = new TextBox();
            UserTextBox = new TextBox();
            passwordEmployee = new Label();
            usuarioEmployee = new Label();
            passwordTextBox = new TextBox();
            validationErrorProvider = new ErrorProvider(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)emplyeesIconPictureBox).BeginInit();
            employeeButtonsgroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EmployeesDataGridView).BeginInit();
            addEmployeegroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)validationErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Controls.Add(searchEmployeeButton);
            panel1.Controls.Add(emplyeesIconPictureBox);
            panel1.Controls.Add(searchEmployeeTextBox);
            panel1.Controls.Add(searchEmployeeLabel);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1714, 64);
            panel1.TabIndex = 2;
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
            searchEmployeeButton.Location = new Point(1035, 17);
            searchEmployeeButton.Margin = new Padding(3, 2, 3, 2);
            searchEmployeeButton.Name = "searchEmployeeButton";
            searchEmployeeButton.Size = new Size(60, 32);
            searchEmployeeButton.TabIndex = 11;
            searchEmployeeButton.UseVisualStyleBackColor = false;
            searchEmployeeButton.Click += searchEmployeeButton_Click;
            // 
            // emplyeesIconPictureBox
            // 
            emplyeesIconPictureBox.BackColor = Color.FromArgb(224, 224, 224);
            emplyeesIconPictureBox.Image = (Image)resources.GetObject("emplyeesIconPictureBox.Image");
            emplyeesIconPictureBox.Location = new Point(97, 3);
            emplyeesIconPictureBox.Name = "emplyeesIconPictureBox";
            emplyeesIconPictureBox.Size = new Size(100, 50);
            emplyeesIconPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            emplyeesIconPictureBox.TabIndex = 9;
            emplyeesIconPictureBox.TabStop = false;
            // 
            // searchEmployeeTextBox
            // 
            searchEmployeeTextBox.BorderStyle = BorderStyle.FixedSingle;
            searchEmployeeTextBox.Location = new Point(424, 24);
            searchEmployeeTextBox.Margin = new Padding(3, 2, 3, 2);
            searchEmployeeTextBox.Name = "searchEmployeeTextBox";
            searchEmployeeTextBox.Size = new Size(581, 23);
            searchEmployeeTextBox.TabIndex = 10;
            searchEmployeeTextBox.TextChanged += searchEmployeeTextBox_TextChanged;
            // 
            // searchEmployeeLabel
            // 
            searchEmployeeLabel.AutoSize = true;
            searchEmployeeLabel.BackColor = Color.FromArgb(224, 224, 224);
            searchEmployeeLabel.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchEmployeeLabel.ForeColor = SystemColors.ActiveCaptionText;
            searchEmployeeLabel.Location = new Point(220, 21);
            searchEmployeeLabel.Name = "searchEmployeeLabel";
            searchEmployeeLabel.Size = new Size(181, 25);
            searchEmployeeLabel.TabIndex = 0;
            searchEmployeeLabel.Text = "Buscar Empleado";
            // 
            // employeeButtonsgroupBox
            // 
            employeeButtonsgroupBox.Controls.Add(clearRowButton);
            employeeButtonsgroupBox.Controls.Add(addEmployeeButton);
            employeeButtonsgroupBox.Controls.Add(editEmployeeButton);
            employeeButtonsgroupBox.Controls.Add(deteleEmployeeButton);
            employeeButtonsgroupBox.Location = new Point(1213, 98);
            employeeButtonsgroupBox.Margin = new Padding(3, 2, 3, 2);
            employeeButtonsgroupBox.Name = "employeeButtonsgroupBox";
            employeeButtonsgroupBox.Padding = new Padding(3, 2, 3, 2);
            employeeButtonsgroupBox.Size = new Size(228, 275);
            employeeButtonsgroupBox.TabIndex = 24;
            employeeButtonsgroupBox.TabStop = false;
            employeeButtonsgroupBox.Text = "acciones";
            // 
            // clearRowButton
            // 
            clearRowButton.BackColor = Color.FromArgb(0, 166, 225);
            clearRowButton.FlatStyle = FlatStyle.Popup;
            clearRowButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clearRowButton.ForeColor = Color.White;
            clearRowButton.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            clearRowButton.IconColor = Color.White;
            clearRowButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            clearRowButton.IconSize = 38;
            clearRowButton.ImageAlign = ContentAlignment.MiddleLeft;
            clearRowButton.Location = new Point(17, 214);
            clearRowButton.Name = "clearRowButton";
            clearRowButton.Size = new Size(194, 40);
            clearRowButton.TabIndex = 23;
            clearRowButton.Text = "Quitar seleccion";
            clearRowButton.TextAlign = ContentAlignment.MiddleRight;
            clearRowButton.UseVisualStyleBackColor = false;
            clearRowButton.Click += clearRowButton_Click;
            // 
            // addEmployeeButton
            // 
            addEmployeeButton.BackColor = Color.FromArgb(0, 166, 225);
            addEmployeeButton.FlatStyle = FlatStyle.Popup;
            addEmployeeButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addEmployeeButton.ForeColor = Color.White;
            addEmployeeButton.IconChar = FontAwesome.Sharp.IconChar.CirclePlus;
            addEmployeeButton.IconColor = Color.White;
            addEmployeeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            addEmployeeButton.IconSize = 38;
            addEmployeeButton.ImageAlign = ContentAlignment.MiddleLeft;
            addEmployeeButton.Location = new Point(17, 30);
            addEmployeeButton.Margin = new Padding(1);
            addEmployeeButton.Name = "addEmployeeButton";
            addEmployeeButton.Size = new Size(194, 40);
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
            editEmployeeButton.Location = new Point(17, 83);
            editEmployeeButton.Name = "editEmployeeButton";
            editEmployeeButton.Size = new Size(194, 40);
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
            deteleEmployeeButton.Location = new Point(17, 148);
            deteleEmployeeButton.Name = "deteleEmployeeButton";
            deteleEmployeeButton.Size = new Size(194, 40);
            deteleEmployeeButton.TabIndex = 22;
            deteleEmployeeButton.Text = "        Borrar empleado";
            deteleEmployeeButton.TextAlign = ContentAlignment.MiddleRight;
            deteleEmployeeButton.UseVisualStyleBackColor = false;
            deteleEmployeeButton.Click += deteleEmployeeButton_Click;
            // 
            // EmployeesDataGridView
            // 
            EmployeesDataGridView.AllowUserToAddRows = false;
            EmployeesDataGridView.AllowUserToResizeColumns = false;
            EmployeesDataGridView.AllowUserToResizeRows = false;
            EmployeesDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            EmployeesDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            EmployeesDataGridView.BackgroundColor = Color.SkyBlue;
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
            EmployeesDataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            EmployeesDataGridView.Location = new Point(10, 98);
            EmployeesDataGridView.MultiSelect = false;
            EmployeesDataGridView.Name = "EmployeesDataGridView";
            EmployeesDataGridView.ReadOnly = true;
            EmployeesDataGridView.RowHeadersVisible = false;
            EmployeesDataGridView.RowHeadersWidth = 35;
            EmployeesDataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            EmployeesDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            EmployeesDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            EmployeesDataGridView.ShowCellToolTips = false;
            EmployeesDataGridView.Size = new Size(1174, 275);
            EmployeesDataGridView.TabIndex = 25;
            EmployeesDataGridView.SelectionChanged += EmployeesDataGridView_SelectionChanged_1;
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
            addEmployeegroupBox.Location = new Point(10, 396);
            addEmployeegroupBox.Margin = new Padding(3, 2, 3, 2);
            addEmployeegroupBox.Name = "addEmployeegroupBox";
            addEmployeegroupBox.Padding = new Padding(3, 2, 3, 2);
            addEmployeegroupBox.Size = new Size(1174, 289);
            addEmployeegroupBox.TabIndex = 26;
            addEmployeegroupBox.TabStop = false;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(3, 27);
            label1.Name = "label1";
            label1.Size = new Size(1168, 24);
            label1.TabIndex = 22;
            label1.Text = "Datos del empleado";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // rolesComboBox
            // 
            rolesComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            rolesComboBox.Font = new Font("Microsoft Sans Serif", 12F);
            rolesComboBox.FormattingEnabled = true;
            rolesComboBox.Location = new Point(984, 141);
            rolesComboBox.Margin = new Padding(3, 2, 3, 2);
            rolesComboBox.MaxDropDownItems = 10;
            rolesComboBox.Name = "rolesComboBox";
            rolesComboBox.Size = new Size(151, 28);
            rolesComboBox.TabIndex = 21;
            // 
            // roleLabel
            // 
            roleLabel.AutoSize = true;
            roleLabel.Font = new Font("Microsoft Sans Serif", 12F);
            roleLabel.Location = new Point(821, 147);
            roleLabel.Name = "roleLabel";
            roleLabel.Size = new Size(143, 20);
            roleLabel.TabIndex = 20;
            roleLabel.Text = "Seleccionar Cargo:";
            // 
            // namesTextBox
            // 
            namesTextBox.BorderStyle = BorderStyle.FixedSingle;
            namesTextBox.Font = new Font("Microsoft Sans Serif", 12F);
            namesTextBox.Location = new Point(129, 74);
            namesTextBox.Name = "namesTextBox";
            namesTextBox.Size = new Size(202, 26);
            namesTextBox.TabIndex = 6;
            // 
            // emailEmployee
            // 
            emailEmployee.AutoSize = true;
            emailEmployee.Font = new Font("Microsoft Sans Serif", 12F);
            emailEmployee.Location = new Point(25, 210);
            emailEmployee.Name = "emailEmployee";
            emailEmployee.Size = new Size(54, 20);
            emailEmployee.TabIndex = 19;
            emailEmployee.Text = "Gmail:";
            // 
            // nameEmployee
            // 
            nameEmployee.AutoSize = true;
            nameEmployee.Font = new Font("Microsoft Sans Serif", 12F);
            nameEmployee.Location = new Point(24, 76);
            nameEmployee.Name = "nameEmployee";
            nameEmployee.Size = new Size(69, 20);
            nameEmployee.TabIndex = 9;
            nameEmployee.Text = "Nombre:";
            // 
            // emailTextBox
            // 
            emailTextBox.BorderStyle = BorderStyle.FixedSingle;
            emailTextBox.Font = new Font("Microsoft Sans Serif", 12F);
            emailTextBox.Location = new Point(122, 210);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(362, 26);
            emailTextBox.TabIndex = 18;
            // 
            // lastNamesTextBox
            // 
            lastNamesTextBox.BorderStyle = BorderStyle.FixedSingle;
            lastNamesTextBox.Font = new Font("Microsoft Sans Serif", 12F);
            lastNamesTextBox.Location = new Point(481, 74);
            lastNamesTextBox.Name = "lastNamesTextBox";
            lastNamesTextBox.Size = new Size(248, 26);
            lastNamesTextBox.TabIndex = 10;
            // 
            // duiEmployee
            // 
            duiEmployee.AutoSize = true;
            duiEmployee.Font = new Font("Microsoft Sans Serif", 12F);
            duiEmployee.Location = new Point(899, 76);
            duiEmployee.Name = "duiEmployee";
            duiEmployee.Size = new Size(42, 20);
            duiEmployee.TabIndex = 17;
            duiEmployee.Text = "DUI:";
            // 
            // lastNameEmployee
            // 
            lastNameEmployee.AutoSize = true;
            lastNameEmployee.Font = new Font("Microsoft Sans Serif", 12F);
            lastNameEmployee.Location = new Point(399, 76);
            lastNameEmployee.Name = "lastNameEmployee";
            lastNameEmployee.Size = new Size(69, 20);
            lastNameEmployee.TabIndex = 11;
            lastNameEmployee.Text = "Apellido:";
            // 
            // duiTextBox
            // 
            duiTextBox.BorderStyle = BorderStyle.FixedSingle;
            duiTextBox.Font = new Font("Microsoft Sans Serif", 12F);
            duiTextBox.Location = new Point(984, 74);
            duiTextBox.Name = "duiTextBox";
            duiTextBox.Size = new Size(151, 26);
            duiTextBox.TabIndex = 16;
            // 
            // UserTextBox
            // 
            UserTextBox.BorderStyle = BorderStyle.FixedSingle;
            UserTextBox.Font = new Font("Microsoft Sans Serif", 12F);
            UserTextBox.Location = new Point(130, 148);
            UserTextBox.Name = "UserTextBox";
            UserTextBox.Size = new Size(201, 26);
            UserTextBox.TabIndex = 12;
            // 
            // passwordEmployee
            // 
            passwordEmployee.AutoSize = true;
            passwordEmployee.Font = new Font("Microsoft Sans Serif", 12F);
            passwordEmployee.Location = new Point(373, 147);
            passwordEmployee.Name = "passwordEmployee";
            passwordEmployee.Size = new Size(96, 20);
            passwordEmployee.TabIndex = 15;
            passwordEmployee.Text = "Contraseña:";
            // 
            // usuarioEmployee
            // 
            usuarioEmployee.AutoSize = true;
            usuarioEmployee.Font = new Font("Microsoft Sans Serif", 12F);
            usuarioEmployee.Location = new Point(25, 151);
            usuarioEmployee.Name = "usuarioEmployee";
            usuarioEmployee.Size = new Size(68, 20);
            usuarioEmployee.TabIndex = 13;
            usuarioEmployee.Text = "Usuario:";
            // 
            // passwordTextBox
            // 
            passwordTextBox.BorderStyle = BorderStyle.FixedSingle;
            passwordTextBox.Font = new Font("Microsoft Sans Serif", 12F);
            passwordTextBox.Location = new Point(483, 145);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(248, 26);
            passwordTextBox.TabIndex = 14;
            // 
            // validationErrorProvider
            // 
            validationErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            validationErrorProvider.ContainerControl = this;
            // 
            // EmployeesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1494, 591);
            Controls.Add(addEmployeegroupBox);
            Controls.Add(EmployeesDataGridView);
            Controls.Add(employeeButtonsgroupBox);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "EmployeesForm";
            Text = "e";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)emplyeesIconPictureBox).EndInit();
            employeeButtonsgroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)EmployeesDataGridView).EndInit();
            addEmployeegroupBox.ResumeLayout(false);
            addEmployeegroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)validationErrorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconButton searchEmployeeButton;
        private PictureBox emplyeesIconPictureBox;
        private TextBox searchEmployeeTextBox;
        private Label searchEmployeeLabel;
        private GroupBox employeeButtonsgroupBox;
        private FontAwesome.Sharp.IconButton clearRowButton;
        private FontAwesome.Sharp.IconButton addEmployeeButton;
        private FontAwesome.Sharp.IconButton editEmployeeButton;
        private FontAwesome.Sharp.IconButton deteleEmployeeButton;
        private DataGridView EmployeesDataGridView;
        private GroupBox addEmployeegroupBox;
        private Label label1;
        private ComboBox rolesComboBox;
        private Label roleLabel;
        private TextBox namesTextBox;
        private Label emailEmployee;
        private Label nameEmployee;
        private TextBox emailTextBox;
        private TextBox lastNamesTextBox;
        private Label duiEmployee;
        private Label lastNameEmployee;
        private TextBox duiTextBox;
        private TextBox UserTextBox;
        private Label passwordEmployee;
        private Label usuarioEmployee;
        private TextBox passwordTextBox;
        private ErrorProvider validationErrorProvider;
    }
}