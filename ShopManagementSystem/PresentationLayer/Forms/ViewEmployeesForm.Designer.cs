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
            rolesComboBox = new ComboBox();
            roleLabel = new Label();
            editEmployeeButton = new FontAwesome.Sharp.IconButton();
            deteleEmployeeButton = new FontAwesome.Sharp.IconButton();
            rolesEmployeeButton = new FontAwesome.Sharp.IconButton();
            add2EmployeeButton = new FontAwesome.Sharp.IconButton();
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
            panel1.Location = new Point(-31, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1756, 64);
            panel1.TabIndex = 1;
            // 
            // emplyeesIconPictureBox
            // 
            emplyeesIconPictureBox.BackColor = Color.FromArgb(224, 224, 224);
            emplyeesIconPictureBox.Image = (Image)resources.GetObject("emplyeesIconPictureBox.Image");
            emplyeesIconPictureBox.Location = new Point(98, 11);
            emplyeesIconPictureBox.Name = "emplyeesIconPictureBox";
            emplyeesIconPictureBox.Size = new Size(100, 50);
            emplyeesIconPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            emplyeesIconPictureBox.TabIndex = 9;
            emplyeesIconPictureBox.TabStop = false;
            // 
            // searchEmployeeTextBox
            // 
            searchEmployeeTextBox.FormattingEnabled = true;
            searchEmployeeTextBox.Location = new Point(399, 21);
            searchEmployeeTextBox.Name = "searchEmployeeTextBox";
            searchEmployeeTextBox.Size = new Size(480, 23);
            searchEmployeeTextBox.TabIndex = 2;
            // 
            // searchEmployeeLabel
            // 
            searchEmployeeLabel.AutoSize = true;
            searchEmployeeLabel.BackColor = Color.WhiteSmoke;
            searchEmployeeLabel.Font = new Font("Reem Kufi", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchEmployeeLabel.ForeColor = SystemColors.ActiveCaptionText;
            searchEmployeeLabel.Location = new Point(204, 21);
            searchEmployeeLabel.Name = "searchEmployeeLabel";
            searchEmployeeLabel.Size = new Size(181, 37);
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
            EmployeesDataGridView.Location = new Point(24, 106);
            EmployeesDataGridView.Name = "EmployeesDataGridView";
            EmployeesDataGridView.RowHeadersWidth = 51;
            EmployeesDataGridView.Size = new Size(1181, 252);
            EmployeesDataGridView.TabIndex = 2;
            // 
            // btnAddEmployee
            // 
            btnAddEmployee.BackColor = Color.FromArgb(0, 166, 225);
            btnAddEmployee.Font = new Font("Reem Kufi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddEmployee.ForeColor = Color.White;
            btnAddEmployee.Location = new Point(838, 132);
            btnAddEmployee.Name = "btnAddEmployee";
            btnAddEmployee.Size = new Size(216, 49);
            btnAddEmployee.TabIndex = 3;
            btnAddEmployee.Text = "Agregar nuevo empledo";
            btnAddEmployee.UseVisualStyleBackColor = false;
            btnAddEmployee.Click += btnAddEmployee_Click;
            // 
            // namesTextBox
            // 
            namesTextBox.Font = new Font("Reem Kufi", 12F);
            namesTextBox.Location = new Point(129, 76);
            namesTextBox.Name = "namesTextBox";
            namesTextBox.Size = new Size(201, 31);
            namesTextBox.TabIndex = 6;
            // 
            // nameEmployee
            // 
            nameEmployee.AutoSize = true;
            nameEmployee.Font = new Font("Reem Kufi", 12F);
            nameEmployee.Location = new Point(24, 78);
            nameEmployee.Name = "nameEmployee";
            nameEmployee.Size = new Size(74, 28);
            nameEmployee.TabIndex = 9;
            nameEmployee.Text = "Nombre:";
            // 
            // lastNameEmployee
            // 
            lastNameEmployee.AutoSize = true;
            lastNameEmployee.Font = new Font("Reem Kufi", 12F);
            lastNameEmployee.Location = new Point(24, 132);
            lastNameEmployee.Name = "lastNameEmployee";
            lastNameEmployee.Size = new Size(75, 28);
            lastNameEmployee.TabIndex = 11;
            lastNameEmployee.Text = "Apellido:";
            // 
            // lastNamesTextBox
            // 
            lastNamesTextBox.Font = new Font("Reem Kufi", 12F);
            lastNamesTextBox.Location = new Point(129, 132);
            lastNamesTextBox.Name = "lastNamesTextBox";
            lastNamesTextBox.Size = new Size(201, 31);
            lastNamesTextBox.TabIndex = 10;
            // 
            // passwordEmployee
            // 
            passwordEmployee.AutoSize = true;
            passwordEmployee.Font = new Font("Reem Kufi", 12F);
            passwordEmployee.Location = new Point(417, 185);
            passwordEmployee.Name = "passwordEmployee";
            passwordEmployee.Size = new Size(98, 28);
            passwordEmployee.TabIndex = 15;
            passwordEmployee.Text = "Contraseña:";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Font = new Font("Reem Kufi", 12F);
            passwordTextBox.Location = new Point(521, 183);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(201, 31);
            passwordTextBox.TabIndex = 14;
            // 
            // usuarioEmployee
            // 
            usuarioEmployee.AutoSize = true;
            usuarioEmployee.Font = new Font("Reem Kufi", 12F);
            usuarioEmployee.Location = new Point(24, 182);
            usuarioEmployee.Name = "usuarioEmployee";
            usuarioEmployee.Size = new Size(71, 28);
            usuarioEmployee.TabIndex = 13;
            usuarioEmployee.Text = "Usuario:";
            // 
            // UserTextBox
            // 
            UserTextBox.Font = new Font("Reem Kufi", 12F);
            UserTextBox.Location = new Point(129, 180);
            UserTextBox.Name = "UserTextBox";
            UserTextBox.Size = new Size(201, 31);
            UserTextBox.TabIndex = 12;
            // 
            // emailEmployee
            // 
            emailEmployee.AutoSize = true;
            emailEmployee.Font = new Font("Reem Kufi", 12F);
            emailEmployee.Location = new Point(424, 130);
            emailEmployee.Name = "emailEmployee";
            emailEmployee.Size = new Size(57, 28);
            emailEmployee.TabIndex = 19;
            emailEmployee.Text = "Gmail:";
            // 
            // emailTextBox
            // 
            emailTextBox.Font = new Font("Reem Kufi", 12F);
            emailTextBox.Location = new Point(521, 130);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(201, 31);
            emailTextBox.TabIndex = 18;
            // 
            // duiEmployee
            // 
            duiEmployee.AutoSize = true;
            duiEmployee.Font = new Font("Reem Kufi", 12F);
            duiEmployee.Location = new Point(424, 76);
            duiEmployee.Name = "duiEmployee";
            duiEmployee.Size = new Size(44, 28);
            duiEmployee.TabIndex = 17;
            duiEmployee.Text = "DUI:";
            // 
            // duiTextBox
            // 
            duiTextBox.Font = new Font("Reem Kufi", 12F);
            duiTextBox.Location = new Point(521, 76);
            duiTextBox.Name = "duiTextBox";
            duiTextBox.Size = new Size(201, 31);
            duiTextBox.TabIndex = 16;
            // 
            // addEmployeegroupBox
            // 
            addEmployeegroupBox.Controls.Add(add2EmployeeButton);
            addEmployeegroupBox.Controls.Add(rolesComboBox);
            addEmployeegroupBox.Controls.Add(roleLabel);
            addEmployeegroupBox.Controls.Add(namesTextBox);
            addEmployeegroupBox.Controls.Add(emailEmployee);
            addEmployeegroupBox.Controls.Add(nameEmployee);
            addEmployeegroupBox.Controls.Add(btnAddEmployee);
            addEmployeegroupBox.Controls.Add(emailTextBox);
            addEmployeegroupBox.Controls.Add(lastNamesTextBox);
            addEmployeegroupBox.Controls.Add(duiEmployee);
            addEmployeegroupBox.Controls.Add(lastNameEmployee);
            addEmployeegroupBox.Controls.Add(duiTextBox);
            addEmployeegroupBox.Controls.Add(UserTextBox);
            addEmployeegroupBox.Controls.Add(passwordEmployee);
            addEmployeegroupBox.Controls.Add(usuarioEmployee);
            addEmployeegroupBox.Controls.Add(passwordTextBox);
            addEmployeegroupBox.Location = new Point(24, 376);
            addEmployeegroupBox.Margin = new Padding(3, 2, 3, 2);
            addEmployeegroupBox.Name = "addEmployeegroupBox";
            addEmployeegroupBox.Padding = new Padding(3, 2, 3, 2);
            addEmployeegroupBox.Size = new Size(1181, 292);
            addEmployeegroupBox.TabIndex = 20;
            addEmployeegroupBox.TabStop = false;
            addEmployeegroupBox.Text = "Agregar nuevo empleado";
            // 
            // rolesComboBox
            // 
            rolesComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            rolesComboBox.FormattingEnabled = true;
            rolesComboBox.Location = new Point(388, 251);
            rolesComboBox.Margin = new Padding(3, 2, 3, 2);
            rolesComboBox.MaxDropDownItems = 10;
            rolesComboBox.Name = "rolesComboBox";
            rolesComboBox.Size = new Size(133, 23);
            rolesComboBox.TabIndex = 21;
            // 
            // roleLabel
            // 
            roleLabel.AutoSize = true;
            roleLabel.Font = new Font("Reem Kufi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roleLabel.Location = new Point(270, 250);
            roleLabel.Name = "roleLabel";
            roleLabel.Size = new Size(60, 28);
            roleLabel.TabIndex = 20;
            roleLabel.Text = "Cargo:";
            // 
            // editEmployeeButton
            // 
            editEmployeeButton.BackColor = Color.FromArgb(0, 166, 225);
            editEmployeeButton.Font = new Font("Reem Kufi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            editEmployeeButton.ForeColor = Color.White;
            editEmployeeButton.IconChar = FontAwesome.Sharp.IconChar.Edit;
            editEmployeeButton.IconColor = Color.White;
            editEmployeeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            editEmployeeButton.IconSize = 38;
            editEmployeeButton.ImageAlign = ContentAlignment.MiddleLeft;
            editEmployeeButton.Location = new Point(1211, 106);
            editEmployeeButton.Name = "editEmployeeButton";
            editEmployeeButton.Size = new Size(182, 50);
            editEmployeeButton.TabIndex = 21;
            editEmployeeButton.Text = "        Editar empleado";
            editEmployeeButton.UseVisualStyleBackColor = false;
            // 
            // deteleEmployeeButton
            // 
            deteleEmployeeButton.BackColor = Color.FromArgb(0, 166, 225);
            deteleEmployeeButton.Font = new Font("Reem Kufi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deteleEmployeeButton.ForeColor = Color.White;
            deteleEmployeeButton.IconChar = FontAwesome.Sharp.IconChar.DeleteLeft;
            deteleEmployeeButton.IconColor = Color.White;
            deteleEmployeeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            deteleEmployeeButton.IconSize = 38;
            deteleEmployeeButton.ImageAlign = ContentAlignment.MiddleLeft;
            deteleEmployeeButton.Location = new Point(1211, 189);
            deteleEmployeeButton.Name = "deteleEmployeeButton";
            deteleEmployeeButton.Size = new Size(182, 50);
            deteleEmployeeButton.TabIndex = 22;
            deteleEmployeeButton.Text = "        Borrar empleado";
            deteleEmployeeButton.UseVisualStyleBackColor = false;
            // 
            // rolesEmployeeButton
            // 
            rolesEmployeeButton.BackColor = Color.FromArgb(0, 166, 225);
            rolesEmployeeButton.Font = new Font("Reem Kufi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rolesEmployeeButton.ForeColor = Color.White;
            rolesEmployeeButton.IconChar = FontAwesome.Sharp.IconChar.Add;
            rolesEmployeeButton.IconColor = Color.White;
            rolesEmployeeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            rolesEmployeeButton.IconSize = 38;
            rolesEmployeeButton.ImageAlign = ContentAlignment.MiddleLeft;
            rolesEmployeeButton.Location = new Point(1211, 285);
            rolesEmployeeButton.Name = "rolesEmployeeButton";
            rolesEmployeeButton.Size = new Size(182, 50);
            rolesEmployeeButton.TabIndex = 23;
            rolesEmployeeButton.Text = "        Agregar cargos";
            rolesEmployeeButton.UseVisualStyleBackColor = false;
            // 
            // add2EmployeeButton
            // 
            add2EmployeeButton.BackColor = Color.FromArgb(0, 166, 225);
            add2EmployeeButton.Font = new Font("Reem Kufi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            add2EmployeeButton.ForeColor = Color.White;
            add2EmployeeButton.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            add2EmployeeButton.IconColor = Color.White;
            add2EmployeeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            add2EmployeeButton.IconSize = 38;
            add2EmployeeButton.ImageAlign = ContentAlignment.MiddleLeft;
            add2EmployeeButton.Location = new Point(849, 201);
            add2EmployeeButton.Name = "add2EmployeeButton";
            add2EmployeeButton.Size = new Size(205, 50);
            add2EmployeeButton.TabIndex = 22;
            add2EmployeeButton.Text = "    Agregar empleado";
            add2EmployeeButton.UseVisualStyleBackColor = false;
            // 
            // ViewEmployeesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(rolesEmployeeButton);
            Controls.Add(deteleEmployeeButton);
            Controls.Add(editEmployeeButton);
            Controls.Add(addEmployeegroupBox);
            Controls.Add(EmployeesDataGridView);
            Controls.Add(panel1);
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
        private FontAwesome.Sharp.IconButton rolesEmployeeButton;
        private FontAwesome.Sharp.IconButton add2EmployeeButton;
    }
}