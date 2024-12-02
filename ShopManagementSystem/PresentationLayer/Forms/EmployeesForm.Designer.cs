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
            DataGridViewCellStyle dataGridViewCellStyle19 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle20 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle21 = new DataGridViewCellStyle();
            TittlePanel = new Panel();
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
            noFoundPictureBox = new PictureBox();
            TittlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)emplyeesIconPictureBox).BeginInit();
            employeeButtonsgroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EmployeesDataGridView).BeginInit();
            addEmployeegroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)validationErrorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)noFoundPictureBox).BeginInit();
            SuspendLayout();
            // 
            // TittlePanel
            // 
            TittlePanel.BackColor = Color.FromArgb(0, 166, 225);
            TittlePanel.Controls.Add(searchEmployeeButton);
            TittlePanel.Controls.Add(emplyeesIconPictureBox);
            TittlePanel.Controls.Add(searchEmployeeTextBox);
            TittlePanel.Controls.Add(searchEmployeeLabel);
            TittlePanel.Location = new Point(0, 1);
            TittlePanel.Margin = new Padding(0);
            TittlePanel.Name = "TittlePanel";
            TittlePanel.Size = new Size(1833, 85);
            TittlePanel.TabIndex = 2;
            // 
            // searchEmployeeButton
            // 
            searchEmployeeButton.BackColor = Color.Transparent;
            searchEmployeeButton.FlatAppearance.BorderColor = Color.Black;
            searchEmployeeButton.FlatAppearance.BorderSize = 2;
            searchEmployeeButton.FlatStyle = FlatStyle.Popup;
            searchEmployeeButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchEmployeeButton.ForeColor = SystemColors.Control;
            searchEmployeeButton.IconChar = FontAwesome.Sharp.IconChar.Search;
            searchEmployeeButton.IconColor = Color.White;
            searchEmployeeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            searchEmployeeButton.IconSize = 60;
            searchEmployeeButton.Location = new Point(1163, 20);
            searchEmployeeButton.Name = "searchEmployeeButton";
            searchEmployeeButton.Size = new Size(69, 54);
            searchEmployeeButton.TabIndex = 11;
            searchEmployeeButton.UseVisualStyleBackColor = false;
            searchEmployeeButton.Click += searchEmployeeButton_Click;
            // 
            // emplyeesIconPictureBox
            // 
            emplyeesIconPictureBox.BackColor = Color.Transparent;
            emplyeesIconPictureBox.Image = (Image)resources.GetObject("emplyeesIconPictureBox.Image");
            emplyeesIconPictureBox.Location = new Point(79, 7);
            emplyeesIconPictureBox.Margin = new Padding(3, 4, 3, 4);
            emplyeesIconPictureBox.Name = "emplyeesIconPictureBox";
            emplyeesIconPictureBox.Size = new Size(114, 67);
            emplyeesIconPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            emplyeesIconPictureBox.TabIndex = 9;
            emplyeesIconPictureBox.TabStop = false;
            // 
            // searchEmployeeTextBox
            // 
            searchEmployeeTextBox.BorderStyle = BorderStyle.None;
            searchEmployeeTextBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchEmployeeTextBox.Location = new Point(506, 26);
            searchEmployeeTextBox.Name = "searchEmployeeTextBox";
            searchEmployeeTextBox.Size = new Size(617, 40);
            searchEmployeeTextBox.TabIndex = 10;
            searchEmployeeTextBox.TextChanged += searchEmployeeTextBox_TextChanged;
            // 
            // searchEmployeeLabel
            // 
            searchEmployeeLabel.AutoSize = true;
            searchEmployeeLabel.BackColor = Color.Transparent;
            searchEmployeeLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchEmployeeLabel.ForeColor = Color.White;
            searchEmployeeLabel.Location = new Point(222, 26);
            searchEmployeeLabel.Name = "searchEmployeeLabel";
            searchEmployeeLabel.Size = new Size(241, 38);
            searchEmployeeLabel.TabIndex = 0;
            searchEmployeeLabel.Text = "Buscar Empleado";
            // 
            // employeeButtonsgroupBox
            // 
            employeeButtonsgroupBox.Controls.Add(clearRowButton);
            employeeButtonsgroupBox.Controls.Add(addEmployeeButton);
            employeeButtonsgroupBox.Controls.Add(editEmployeeButton);
            employeeButtonsgroupBox.Controls.Add(deteleEmployeeButton);
            employeeButtonsgroupBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            employeeButtonsgroupBox.Location = new Point(1289, 154);
            employeeButtonsgroupBox.Name = "employeeButtonsgroupBox";
            employeeButtonsgroupBox.Size = new Size(325, 367);
            employeeButtonsgroupBox.TabIndex = 24;
            employeeButtonsgroupBox.TabStop = false;
            employeeButtonsgroupBox.Text = "Acciones";
            // 
            // clearRowButton
            // 
            clearRowButton.BackColor = Color.FromArgb(0, 166, 225);
            clearRowButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            clearRowButton.ForeColor = Color.White;
            clearRowButton.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            clearRowButton.IconColor = Color.White;
            clearRowButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            clearRowButton.IconSize = 30;
            clearRowButton.ImageAlign = ContentAlignment.MiddleLeft;
            clearRowButton.Location = new Point(19, 285);
            clearRowButton.Margin = new Padding(3, 4, 3, 4);
            clearRowButton.Name = "clearRowButton";
            clearRowButton.Size = new Size(277, 57);
            clearRowButton.TabIndex = 23;
            clearRowButton.Text = "Quitar seleccion";
            clearRowButton.UseVisualStyleBackColor = false;
            clearRowButton.Click += clearRowButton_Click;
            // 
            // addEmployeeButton
            // 
            addEmployeeButton.BackColor = Color.FromArgb(0, 166, 225);
            addEmployeeButton.FlatStyle = FlatStyle.Flat;
            addEmployeeButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            addEmployeeButton.ForeColor = Color.White;
            addEmployeeButton.IconChar = FontAwesome.Sharp.IconChar.CirclePlus;
            addEmployeeButton.IconColor = Color.White;
            addEmployeeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            addEmployeeButton.IconSize = 30;
            addEmployeeButton.ImageAlign = ContentAlignment.MiddleLeft;
            addEmployeeButton.Location = new Point(19, 40);
            addEmployeeButton.Margin = new Padding(1);
            addEmployeeButton.Name = "addEmployeeButton";
            addEmployeeButton.Size = new Size(277, 53);
            addEmployeeButton.TabIndex = 22;
            addEmployeeButton.Text = "    Agregar";
            addEmployeeButton.UseVisualStyleBackColor = false;
            addEmployeeButton.Click += addEmployeeButton_Click;
            // 
            // editEmployeeButton
            // 
            editEmployeeButton.BackColor = Color.FromArgb(0, 166, 225);
            editEmployeeButton.FlatStyle = FlatStyle.Flat;
            editEmployeeButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            editEmployeeButton.ForeColor = Color.White;
            editEmployeeButton.IconChar = FontAwesome.Sharp.IconChar.Edit;
            editEmployeeButton.IconColor = Color.White;
            editEmployeeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            editEmployeeButton.IconSize = 30;
            editEmployeeButton.ImageAlign = ContentAlignment.MiddleLeft;
            editEmployeeButton.Location = new Point(19, 123);
            editEmployeeButton.Margin = new Padding(3, 4, 3, 4);
            editEmployeeButton.Name = "editEmployeeButton";
            editEmployeeButton.Size = new Size(277, 53);
            editEmployeeButton.TabIndex = 21;
            editEmployeeButton.Text = "Editar ";
            editEmployeeButton.UseVisualStyleBackColor = false;
            editEmployeeButton.Click += editEmployeeButton_Click;
            // 
            // deteleEmployeeButton
            // 
            deteleEmployeeButton.BackColor = Color.FromArgb(0, 166, 225);
            deteleEmployeeButton.FlatStyle = FlatStyle.Flat;
            deteleEmployeeButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            deteleEmployeeButton.ForeColor = Color.White;
            deteleEmployeeButton.IconChar = FontAwesome.Sharp.IconChar.DeleteLeft;
            deteleEmployeeButton.IconColor = Color.White;
            deteleEmployeeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            deteleEmployeeButton.IconSize = 30;
            deteleEmployeeButton.ImageAlign = ContentAlignment.MiddleLeft;
            deteleEmployeeButton.Location = new Point(19, 197);
            deteleEmployeeButton.Margin = new Padding(3, 4, 3, 4);
            deteleEmployeeButton.Name = "deteleEmployeeButton";
            deteleEmployeeButton.Size = new Size(277, 53);
            deteleEmployeeButton.TabIndex = 22;
            deteleEmployeeButton.Text = "Borrar ";
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
            EmployeesDataGridView.BackgroundColor = Color.White;
            EmployeesDataGridView.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle19.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = SystemColors.Control;
            dataGridViewCellStyle19.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle19.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = Color.White;
            dataGridViewCellStyle19.SelectionForeColor = Color.White;
            dataGridViewCellStyle19.WrapMode = DataGridViewTriState.True;
            EmployeesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            EmployeesDataGridView.ColumnHeadersHeight = 29;
            EmployeesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            EmployeesDataGridView.Cursor = Cursors.Hand;
            dataGridViewCellStyle20.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = SystemColors.Window;
            dataGridViewCellStyle20.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle20.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle20.SelectionBackColor = Color.FromArgb(0, 166, 225);
            dataGridViewCellStyle20.SelectionForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle20.WrapMode = DataGridViewTriState.False;
            EmployeesDataGridView.DefaultCellStyle = dataGridViewCellStyle20;
            EmployeesDataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            EmployeesDataGridView.Location = new Point(138, 154);
            EmployeesDataGridView.Margin = new Padding(3, 4, 3, 4);
            EmployeesDataGridView.MultiSelect = false;
            EmployeesDataGridView.Name = "EmployeesDataGridView";
            EmployeesDataGridView.ReadOnly = true;
            EmployeesDataGridView.RowHeadersVisible = false;
            EmployeesDataGridView.RowHeadersWidth = 35;
            EmployeesDataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle21.Alignment = DataGridViewContentAlignment.MiddleCenter;
            EmployeesDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle21;
            EmployeesDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            EmployeesDataGridView.ShowCellToolTips = false;
            EmployeesDataGridView.Size = new Size(1095, 367);
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
            addEmployeegroupBox.Font = new Font("Segoe UI", 13F);
            addEmployeegroupBox.Location = new Point(63, 538);
            addEmployeegroupBox.Name = "addEmployeegroupBox";
            addEmployeegroupBox.Size = new Size(1610, 465);
            addEmployeegroupBox.TabIndex = 26;
            addEmployeegroupBox.TabStop = false;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label1.Location = new Point(3, 32);
            label1.Name = "label1";
            label1.Size = new Size(1604, 32);
            label1.TabIndex = 22;
            label1.Text = "Datos del empleado";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // rolesComboBox
            // 
            rolesComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            rolesComboBox.Font = new Font("Microsoft Sans Serif", 12F);
            rolesComboBox.FormattingEnabled = true;
            rolesComboBox.Location = new Point(980, 191);
            rolesComboBox.MaxDropDownItems = 10;
            rolesComboBox.Name = "rolesComboBox";
            rolesComboBox.Size = new Size(172, 33);
            rolesComboBox.TabIndex = 21;
            rolesComboBox.Click += rolesComboBox_Click;
            // 
            // roleLabel
            // 
            roleLabel.AutoSize = true;
            roleLabel.Font = new Font("Microsoft Sans Serif", 12F);
            roleLabel.Location = new Point(805, 196);
            roleLabel.Name = "roleLabel";
            roleLabel.Size = new Size(180, 25);
            roleLabel.TabIndex = 20;
            roleLabel.Text = "Seleccionar Cargo:";
            // 
            // namesTextBox
            // 
            namesTextBox.BorderStyle = BorderStyle.FixedSingle;
            namesTextBox.Font = new Font("Microsoft Sans Serif", 12F);
            namesTextBox.Location = new Point(137, 99);
            namesTextBox.Margin = new Padding(3, 4, 3, 4);
            namesTextBox.Name = "namesTextBox";
            namesTextBox.Size = new Size(231, 30);
            namesTextBox.TabIndex = 6;
            namesTextBox.TextChanged += namesTextBox_TextChanged;
            // 
            // emailEmployee
            // 
            emailEmployee.AutoSize = true;
            emailEmployee.Font = new Font("Microsoft Sans Serif", 12F);
            emailEmployee.Location = new Point(17, 280);
            emailEmployee.Name = "emailEmployee";
            emailEmployee.Size = new Size(68, 25);
            emailEmployee.TabIndex = 19;
            emailEmployee.Text = "Gmail:";
            // 
            // nameEmployee
            // 
            nameEmployee.AutoSize = true;
            nameEmployee.Font = new Font("Microsoft Sans Serif", 12F);
            nameEmployee.Location = new Point(17, 101);
            nameEmployee.Name = "nameEmployee";
            nameEmployee.Size = new Size(87, 25);
            nameEmployee.TabIndex = 9;
            nameEmployee.Text = "Nombre:";
            // 
            // emailTextBox
            // 
            emailTextBox.BorderStyle = BorderStyle.FixedSingle;
            emailTextBox.Font = new Font("Microsoft Sans Serif", 12F);
            emailTextBox.Location = new Point(127, 280);
            emailTextBox.Margin = new Padding(3, 4, 3, 4);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(335, 30);
            emailTextBox.TabIndex = 18;
            emailTextBox.TextChanged += emailTextBox_TextChanged;
            // 
            // lastNamesTextBox
            // 
            lastNamesTextBox.BorderStyle = BorderStyle.FixedSingle;
            lastNamesTextBox.Font = new Font("Microsoft Sans Serif", 12F);
            lastNamesTextBox.Location = new Point(513, 102);
            lastNamesTextBox.Margin = new Padding(3, 4, 3, 4);
            lastNamesTextBox.Name = "lastNamesTextBox";
            lastNamesTextBox.Size = new Size(271, 30);
            lastNamesTextBox.TabIndex = 10;
            lastNamesTextBox.TextAlignChanged += lastNamesTextBox_TextAlignChanged;
            // 
            // duiEmployee
            // 
            duiEmployee.AutoSize = true;
            duiEmployee.Font = new Font("Microsoft Sans Serif", 12F);
            duiEmployee.Location = new Point(894, 101);
            duiEmployee.Name = "duiEmployee";
            duiEmployee.Size = new Size(51, 25);
            duiEmployee.TabIndex = 17;
            duiEmployee.Text = "DUI:";
            // 
            // lastNameEmployee
            // 
            lastNameEmployee.AutoSize = true;
            lastNameEmployee.Font = new Font("Microsoft Sans Serif", 12F);
            lastNameEmployee.Location = new Point(420, 104);
            lastNameEmployee.Name = "lastNameEmployee";
            lastNameEmployee.Size = new Size(88, 25);
            lastNameEmployee.TabIndex = 11;
            lastNameEmployee.Text = "Apellido:";
            // 
            // duiTextBox
            // 
            duiTextBox.BorderStyle = BorderStyle.FixedSingle;
            duiTextBox.Font = new Font("Microsoft Sans Serif", 12F);
            duiTextBox.Location = new Point(980, 102);
            duiTextBox.Margin = new Padding(3, 4, 3, 4);
            duiTextBox.Name = "duiTextBox";
            duiTextBox.Size = new Size(172, 30);
            duiTextBox.TabIndex = 16;
            duiTextBox.TextChanged += duiTextBox_TextChanged;
            // 
            // UserTextBox
            // 
            UserTextBox.BorderStyle = BorderStyle.FixedSingle;
            UserTextBox.Font = new Font("Microsoft Sans Serif", 12F);
            UserTextBox.Location = new Point(139, 197);
            UserTextBox.Margin = new Padding(3, 4, 3, 4);
            UserTextBox.Name = "UserTextBox";
            UserTextBox.Size = new Size(229, 30);
            UserTextBox.TabIndex = 12;
            UserTextBox.TextChanged += UserTextBox_TextChanged;
            // 
            // passwordEmployee
            // 
            passwordEmployee.AutoSize = true;
            passwordEmployee.Font = new Font("Microsoft Sans Serif", 12F);
            passwordEmployee.Location = new Point(390, 199);
            passwordEmployee.Name = "passwordEmployee";
            passwordEmployee.Size = new Size(120, 25);
            passwordEmployee.TabIndex = 15;
            passwordEmployee.Text = "Contraseña:";
            // 
            // usuarioEmployee
            // 
            usuarioEmployee.AutoSize = true;
            usuarioEmployee.Font = new Font("Microsoft Sans Serif", 12F);
            usuarioEmployee.Location = new Point(19, 201);
            usuarioEmployee.Name = "usuarioEmployee";
            usuarioEmployee.Size = new Size(85, 25);
            usuarioEmployee.TabIndex = 13;
            usuarioEmployee.Text = "Usuario:";
            // 
            // passwordTextBox
            // 
            passwordTextBox.BorderStyle = BorderStyle.FixedSingle;
            passwordTextBox.Font = new Font("Microsoft Sans Serif", 12F);
            passwordTextBox.Location = new Point(515, 196);
            passwordTextBox.Margin = new Padding(3, 4, 3, 4);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(269, 30);
            passwordTextBox.TabIndex = 14;
            passwordTextBox.TextChanged += passwordTextBox_TextChanged;
            // 
            // validationErrorProvider
            // 
            validationErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            validationErrorProvider.ContainerControl = this;
            // 
            // noFoundPictureBox
            // 
            noFoundPictureBox.Image = (Image)resources.GetObject("noFoundPictureBox.Image");
            noFoundPictureBox.Location = new Point(453, 277);
            noFoundPictureBox.Name = "noFoundPictureBox";
            noFoundPictureBox.Size = new Size(430, 154);
            noFoundPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            noFoundPictureBox.TabIndex = 27;
            noFoundPictureBox.TabStop = false;
            noFoundPictureBox.Visible = false;
            // 
            // EmployeesForm
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.White;
            ClientSize = new Size(1768, 1102);
            Controls.Add(noFoundPictureBox);
            Controls.Add(addEmployeegroupBox);
            Controls.Add(EmployeesDataGridView);
            Controls.Add(employeeButtonsgroupBox);
            Controls.Add(TittlePanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EmployeesForm";
            Text = "e";
            TittlePanel.ResumeLayout(false);
            TittlePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)emplyeesIconPictureBox).EndInit();
            employeeButtonsgroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)EmployeesDataGridView).EndInit();
            addEmployeegroupBox.ResumeLayout(false);
            addEmployeegroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)validationErrorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)noFoundPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel TittlePanel;
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
        private PictureBox noFoundPictureBox;
    }
}