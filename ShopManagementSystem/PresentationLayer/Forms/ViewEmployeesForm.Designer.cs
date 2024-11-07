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
            addEmployeeButton = new FontAwesome.Sharp.IconButton();
            rolesComboBox = new ComboBox();
            roleLabel = new Label();
            editEmployeeButton = new FontAwesome.Sharp.IconButton();
            deteleEmployeeButton = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)emplyeesIconPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EmployeesDataGridView).BeginInit();
            addEmployeegroupBox.SuspendLayout();
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
            panel1.Size = new Size(2007, 85);
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
            EmployeesDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            EmployeesDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            EmployeesDataGridView.BackgroundColor = Color.Lavender;
            EmployeesDataGridView.ColumnHeadersHeight = 29;
            EmployeesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            EmployeesDataGridView.Location = new Point(27, 141);
            EmployeesDataGridView.Margin = new Padding(3, 4, 3, 4);
            EmployeesDataGridView.Name = "EmployeesDataGridView";
            EmployeesDataGridView.RowHeadersWidth = 51;
            EmployeesDataGridView.Size = new Size(1350, 336);
            EmployeesDataGridView.TabIndex = 2;
            EmployeesDataGridView.CellClick += EmployeesDataGridView_CellClick;
            // 
            // namesTextBox
            // 
            namesTextBox.Font = new Font("Microsoft Sans Serif", 12F);
            namesTextBox.Location = new Point(147, 101);
            namesTextBox.Margin = new Padding(3, 4, 3, 4);
            namesTextBox.Name = "namesTextBox";
            namesTextBox.Size = new Size(229, 30);
            namesTextBox.TabIndex = 6;
            // 
            // nameEmployee
            // 
            nameEmployee.AutoSize = true;
            nameEmployee.Font = new Font("Microsoft Sans Serif", 12F);
            nameEmployee.Location = new Point(27, 104);
            nameEmployee.Name = "nameEmployee";
            nameEmployee.Size = new Size(87, 25);
            nameEmployee.TabIndex = 9;
            nameEmployee.Text = "Nombre:";
            // 
            // lastNameEmployee
            // 
            lastNameEmployee.AutoSize = true;
            lastNameEmployee.Font = new Font("Microsoft Sans Serif", 12F);
            lastNameEmployee.Location = new Point(27, 176);
            lastNameEmployee.Name = "lastNameEmployee";
            lastNameEmployee.Size = new Size(88, 25);
            lastNameEmployee.TabIndex = 11;
            lastNameEmployee.Text = "Apellido:";
            // 
            // lastNamesTextBox
            // 
            lastNamesTextBox.Font = new Font("Microsoft Sans Serif", 12F);
            lastNamesTextBox.Location = new Point(147, 176);
            lastNamesTextBox.Margin = new Padding(3, 4, 3, 4);
            lastNamesTextBox.Name = "lastNamesTextBox";
            lastNamesTextBox.Size = new Size(229, 30);
            lastNamesTextBox.TabIndex = 10;
            // 
            // passwordEmployee
            // 
            passwordEmployee.AutoSize = true;
            passwordEmployee.Font = new Font("Microsoft Sans Serif", 12F);
            passwordEmployee.Location = new Point(477, 247);
            passwordEmployee.Name = "passwordEmployee";
            passwordEmployee.Size = new Size(120, 25);
            passwordEmployee.TabIndex = 15;
            passwordEmployee.Text = "Contraseña:";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Font = new Font("Microsoft Sans Serif", 12F);
            passwordTextBox.Location = new Point(595, 244);
            passwordTextBox.Margin = new Padding(3, 4, 3, 4);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(229, 30);
            passwordTextBox.TabIndex = 14;
            // 
            // usuarioEmployee
            // 
            usuarioEmployee.AutoSize = true;
            usuarioEmployee.Font = new Font("Microsoft Sans Serif", 12F);
            usuarioEmployee.Location = new Point(27, 243);
            usuarioEmployee.Name = "usuarioEmployee";
            usuarioEmployee.Size = new Size(85, 25);
            usuarioEmployee.TabIndex = 13;
            usuarioEmployee.Text = "Usuario:";
            // 
            // UserTextBox
            // 
            UserTextBox.Font = new Font("Microsoft Sans Serif", 12F);
            UserTextBox.Location = new Point(147, 240);
            UserTextBox.Margin = new Padding(3, 4, 3, 4);
            UserTextBox.Name = "UserTextBox";
            UserTextBox.Size = new Size(229, 30);
            UserTextBox.TabIndex = 12;
            // 
            // emailEmployee
            // 
            emailEmployee.AutoSize = true;
            emailEmployee.Font = new Font("Microsoft Sans Serif", 12F);
            emailEmployee.Location = new Point(485, 173);
            emailEmployee.Name = "emailEmployee";
            emailEmployee.Size = new Size(68, 25);
            emailEmployee.TabIndex = 19;
            emailEmployee.Text = "Gmail:";
            // 
            // emailTextBox
            // 
            emailTextBox.Font = new Font("Microsoft Sans Serif", 12F);
            emailTextBox.Location = new Point(595, 173);
            emailTextBox.Margin = new Padding(3, 4, 3, 4);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(229, 30);
            emailTextBox.TabIndex = 18;
            // 
            // duiEmployee
            // 
            duiEmployee.AutoSize = true;
            duiEmployee.Font = new Font("Microsoft Sans Serif", 12F);
            duiEmployee.Location = new Point(485, 101);
            duiEmployee.Name = "duiEmployee";
            duiEmployee.Size = new Size(51, 25);
            duiEmployee.TabIndex = 17;
            duiEmployee.Text = "DUI:";
            // 
            // duiTextBox
            // 
            duiTextBox.Font = new Font("Microsoft Sans Serif", 12F);
            duiTextBox.Location = new Point(595, 101);
            duiTextBox.Margin = new Padding(3, 4, 3, 4);
            duiTextBox.Name = "duiTextBox";
            duiTextBox.Size = new Size(229, 30);
            duiTextBox.TabIndex = 16;
            // 
            // addEmployeegroupBox
            // 
            addEmployeegroupBox.Controls.Add(addEmployeeButton);
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
            addEmployeegroupBox.Location = new Point(27, 501);
            addEmployeegroupBox.Name = "addEmployeegroupBox";
            addEmployeegroupBox.Size = new Size(1350, 389);
            addEmployeegroupBox.TabIndex = 20;
            addEmployeegroupBox.TabStop = false;
            addEmployeegroupBox.Text = "Agregar nuevo empleado";
            // 
            // addEmployeeButton
            // 
            addEmployeeButton.BackColor = Color.FromArgb(0, 166, 225);
            addEmployeeButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addEmployeeButton.ForeColor = Color.White;
            addEmployeeButton.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            addEmployeeButton.IconColor = Color.White;
            addEmployeeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            addEmployeeButton.IconSize = 38;
            addEmployeeButton.ImageAlign = ContentAlignment.MiddleLeft;
            addEmployeeButton.Location = new Point(971, 37);
            addEmployeeButton.Margin = new Padding(3, 4, 3, 4);
            addEmployeeButton.Name = "addEmployeeButton";
            addEmployeeButton.Size = new Size(234, 67);
            addEmployeeButton.TabIndex = 22;
            addEmployeeButton.Text = "    Agregar empleado";
            addEmployeeButton.UseVisualStyleBackColor = false;
            addEmployeeButton.Click += addEmployeeButton_Click;
            // 
            // rolesComboBox
            // 
            rolesComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            rolesComboBox.FormattingEnabled = true;
            rolesComboBox.Location = new Point(443, 335);
            rolesComboBox.MaxDropDownItems = 10;
            rolesComboBox.Name = "rolesComboBox";
            rolesComboBox.Size = new Size(151, 28);
            rolesComboBox.TabIndex = 21;
            // 
            // roleLabel
            // 
            roleLabel.AutoSize = true;
            roleLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roleLabel.Location = new Point(309, 333);
            roleLabel.Name = "roleLabel";
            roleLabel.Size = new Size(72, 25);
            roleLabel.TabIndex = 20;
            roleLabel.Text = "Cargo:";
            // 
            // editEmployeeButton
            // 
            editEmployeeButton.BackColor = Color.FromArgb(0, 166, 225);
            editEmployeeButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            editEmployeeButton.ForeColor = Color.White;
            editEmployeeButton.IconChar = FontAwesome.Sharp.IconChar.Edit;
            editEmployeeButton.IconColor = Color.White;
            editEmployeeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            editEmployeeButton.IconSize = 38;
            editEmployeeButton.ImageAlign = ContentAlignment.MiddleLeft;
            editEmployeeButton.Location = new Point(1384, 141);
            editEmployeeButton.Margin = new Padding(3, 4, 3, 4);
            editEmployeeButton.Name = "editEmployeeButton";
            editEmployeeButton.Size = new Size(208, 67);
            editEmployeeButton.TabIndex = 21;
            editEmployeeButton.Text = "        Editar empleado";
            editEmployeeButton.UseVisualStyleBackColor = false;
            editEmployeeButton.Click += editEmployeeButton_Click;
            // 
            // deteleEmployeeButton
            // 
            deteleEmployeeButton.BackColor = Color.FromArgb(0, 166, 225);
            deteleEmployeeButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deteleEmployeeButton.ForeColor = Color.White;
            deteleEmployeeButton.IconChar = FontAwesome.Sharp.IconChar.DeleteLeft;
            deteleEmployeeButton.IconColor = Color.White;
            deteleEmployeeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            deteleEmployeeButton.IconSize = 38;
            deteleEmployeeButton.ImageAlign = ContentAlignment.MiddleLeft;
            deteleEmployeeButton.Location = new Point(1384, 252);
            deteleEmployeeButton.Margin = new Padding(3, 4, 3, 4);
            deteleEmployeeButton.Name = "deteleEmployeeButton";
            deteleEmployeeButton.Size = new Size(208, 67);
            deteleEmployeeButton.TabIndex = 22;
            deteleEmployeeButton.Text = "        Borrar empleado";
            deteleEmployeeButton.UseVisualStyleBackColor = false;
            deteleEmployeeButton.Click += deteleEmployeeButton_Click;
            // 
            // ViewEmployeesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1566, 999);
            Controls.Add(deteleEmployeeButton);
            Controls.Add(editEmployeeButton);
            Controls.Add(addEmployeegroupBox);
            Controls.Add(EmployeesDataGridView);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ViewEmployeesForm";
            Text = "ViewEmployees";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)emplyeesIconPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)EmployeesDataGridView).EndInit();
            addEmployeegroupBox.ResumeLayout(false);
            addEmployeegroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private ComboBox searchEmployeeTextBox;
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
    }
}