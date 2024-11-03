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
            txtName = new TextBox();
            nameEmployee = new Label();
            lastNameEmployee = new Label();
            txtLastName = new TextBox();
            passwordEmployee = new Label();
            txtPassword = new TextBox();
            usuarioEmployee = new Label();
            txtUsuario = new TextBox();
            emailEmployee = new Label();
            txtGmail = new TextBox();
            duiEmployee = new Label();
            txtDui = new TextBox();
            addEmployeegroupBox = new GroupBox();
            roleComboBox = new ComboBox();
            roleLabel = new Label();
            viewRoleButton = new Button();
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
            EmployeesDataGridView.Size = new Size(1350, 336);
            EmployeesDataGridView.TabIndex = 2;
            // 
            // btnAddEmployee
            // 
            btnAddEmployee.BackColor = Color.FromArgb(0, 166, 225);
            btnAddEmployee.Font = new Font("Segoe UI Historic", 10F, FontStyle.Bold);
            btnAddEmployee.ForeColor = Color.White;
            btnAddEmployee.Location = new Point(72, 50);
            btnAddEmployee.Margin = new Padding(3, 4, 3, 4);
            btnAddEmployee.Name = "btnAddEmployee";
            btnAddEmployee.Size = new Size(247, 65);
            btnAddEmployee.TabIndex = 3;
            btnAddEmployee.Text = "Agregar nuevo empledo";
            btnAddEmployee.UseVisualStyleBackColor = false;
            // 
            // btnEditEmployee
            // 
            btnEditEmployee.BackColor = Color.FromArgb(0, 166, 225);
            btnEditEmployee.Font = new Font("Segoe UI Historic", 10F, FontStyle.Bold);
            btnEditEmployee.ForeColor = Color.White;
            btnEditEmployee.Location = new Point(1429, 158);
            btnEditEmployee.Margin = new Padding(3, 4, 3, 4);
            btnEditEmployee.Name = "btnEditEmployee";
            btnEditEmployee.Size = new Size(175, 62);
            btnEditEmployee.TabIndex = 4;
            btnEditEmployee.Text = "Editar empleado";
            btnEditEmployee.UseVisualStyleBackColor = false;
            // 
            // btnDeteleEmployee
            // 
            btnDeteleEmployee.BackColor = Color.FromArgb(0, 166, 225);
            btnDeteleEmployee.Font = new Font("Segoe UI Historic", 10F, FontStyle.Bold);
            btnDeteleEmployee.ForeColor = Color.White;
            btnDeteleEmployee.Location = new Point(1429, 268);
            btnDeteleEmployee.Margin = new Padding(3, 4, 3, 4);
            btnDeteleEmployee.Name = "btnDeteleEmployee";
            btnDeteleEmployee.Size = new Size(175, 62);
            btnDeteleEmployee.TabIndex = 5;
            btnDeteleEmployee.Text = "Borrar empleado";
            btnDeteleEmployee.UseVisualStyleBackColor = false;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI Historic", 11F, FontStyle.Bold);
            txtName.Location = new Point(192, 171);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(229, 32);
            txtName.TabIndex = 6;
            // 
            // nameEmployee
            // 
            nameEmployee.AutoSize = true;
            nameEmployee.Font = new Font("Segoe UI Historic", 11F, FontStyle.Bold);
            nameEmployee.Location = new Point(72, 174);
            nameEmployee.Name = "nameEmployee";
            nameEmployee.Size = new Size(92, 25);
            nameEmployee.TabIndex = 9;
            nameEmployee.Text = "Nombre:";
            // 
            // lastNameEmployee
            // 
            lastNameEmployee.AutoSize = true;
            lastNameEmployee.Font = new Font("Segoe UI Historic", 11F, FontStyle.Bold);
            lastNameEmployee.Location = new Point(72, 246);
            lastNameEmployee.Name = "lastNameEmployee";
            lastNameEmployee.Size = new Size(95, 25);
            lastNameEmployee.TabIndex = 11;
            lastNameEmployee.Text = "Apellido:";
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI Historic", 11F, FontStyle.Bold);
            txtLastName.Location = new Point(192, 246);
            txtLastName.Margin = new Padding(3, 4, 3, 4);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(229, 32);
            txtLastName.TabIndex = 10;
            // 
            // passwordEmployee
            // 
            passwordEmployee.AutoSize = true;
            passwordEmployee.Font = new Font("Segoe UI Historic", 11F, FontStyle.Bold);
            passwordEmployee.Location = new Point(564, 319);
            passwordEmployee.Name = "passwordEmployee";
            passwordEmployee.Size = new Size(123, 25);
            passwordEmployee.TabIndex = 15;
            passwordEmployee.Text = "Contraseña:";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI Historic", 11F, FontStyle.Bold);
            txtPassword.Location = new Point(684, 316);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(229, 32);
            txtPassword.TabIndex = 14;
            // 
            // usuarioEmployee
            // 
            usuarioEmployee.AutoSize = true;
            usuarioEmployee.Font = new Font("Segoe UI Historic", 11F, FontStyle.Bold);
            usuarioEmployee.Location = new Point(72, 312);
            usuarioEmployee.Name = "usuarioEmployee";
            usuarioEmployee.Size = new Size(89, 25);
            usuarioEmployee.TabIndex = 13;
            usuarioEmployee.Text = "Usuario:";
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI Historic", 11F, FontStyle.Bold);
            txtUsuario.Location = new Point(192, 309);
            txtUsuario.Margin = new Padding(3, 4, 3, 4);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(229, 32);
            txtUsuario.TabIndex = 12;
            // 
            // emailEmployee
            // 
            emailEmployee.AutoSize = true;
            emailEmployee.Font = new Font("Segoe UI Historic", 11F, FontStyle.Bold);
            emailEmployee.Location = new Point(573, 246);
            emailEmployee.Name = "emailEmployee";
            emailEmployee.Size = new Size(71, 25);
            emailEmployee.TabIndex = 19;
            emailEmployee.Text = "Gmail:";
            // 
            // txtGmail
            // 
            txtGmail.Font = new Font("Segoe UI Historic", 11F, FontStyle.Bold);
            txtGmail.Location = new Point(684, 246);
            txtGmail.Margin = new Padding(3, 4, 3, 4);
            txtGmail.Name = "txtGmail";
            txtGmail.Size = new Size(229, 32);
            txtGmail.TabIndex = 18;
            // 
            // duiEmployee
            // 
            duiEmployee.AutoSize = true;
            duiEmployee.Font = new Font("Segoe UI Historic", 11F, FontStyle.Bold);
            duiEmployee.Location = new Point(573, 174);
            duiEmployee.Name = "duiEmployee";
            duiEmployee.Size = new Size(51, 25);
            duiEmployee.TabIndex = 17;
            duiEmployee.Text = "DUI:";
            // 
            // txtDui
            // 
            txtDui.Font = new Font("Segoe UI Historic", 11F, FontStyle.Bold);
            txtDui.Location = new Point(684, 174);
            txtDui.Margin = new Padding(3, 4, 3, 4);
            txtDui.Name = "txtDui";
            txtDui.Size = new Size(229, 32);
            txtDui.TabIndex = 16;
            // 
            // addEmployeegroupBox
            // 
            addEmployeegroupBox.Controls.Add(roleComboBox);
            addEmployeegroupBox.Controls.Add(roleLabel);
            addEmployeegroupBox.Controls.Add(txtName);
            addEmployeegroupBox.Controls.Add(emailEmployee);
            addEmployeegroupBox.Controls.Add(nameEmployee);
            addEmployeegroupBox.Controls.Add(btnAddEmployee);
            addEmployeegroupBox.Controls.Add(txtGmail);
            addEmployeegroupBox.Controls.Add(txtLastName);
            addEmployeegroupBox.Controls.Add(duiEmployee);
            addEmployeegroupBox.Controls.Add(lastNameEmployee);
            addEmployeegroupBox.Controls.Add(txtDui);
            addEmployeegroupBox.Controls.Add(txtUsuario);
            addEmployeegroupBox.Controls.Add(passwordEmployee);
            addEmployeegroupBox.Controls.Add(usuarioEmployee);
            addEmployeegroupBox.Controls.Add(txtPassword);
            addEmployeegroupBox.Location = new Point(27, 501);
            addEmployeegroupBox.Name = "addEmployeegroupBox";
            addEmployeegroupBox.Size = new Size(1350, 390);
            addEmployeegroupBox.TabIndex = 20;
            addEmployeegroupBox.TabStop = false;
            addEmployeegroupBox.Text = "agregar nuevo empleado";
            // 
            // roleComboBox
            // 
            roleComboBox.FormattingEnabled = true;
            roleComboBox.Location = new Point(1142, 172);
            roleComboBox.Name = "roleComboBox";
            roleComboBox.Size = new Size(151, 28);
            roleComboBox.TabIndex = 21;
            // 
            // roleLabel
            // 
            roleLabel.AutoSize = true;
            roleLabel.Font = new Font("Segoe UI Historic", 11F, FontStyle.Bold);
            roleLabel.Location = new Point(1007, 171);
            roleLabel.Name = "roleLabel";
            roleLabel.Size = new Size(73, 25);
            roleLabel.TabIndex = 20;
            roleLabel.Text = "Cargo:";
            // 
            // viewRoleButton
            // 
            viewRoleButton.BackColor = Color.FromArgb(0, 166, 225);
            viewRoleButton.Font = new Font("Segoe UI Historic", 10F, FontStyle.Bold);
            viewRoleButton.ForeColor = Color.White;
            viewRoleButton.Location = new Point(1429, 386);
            viewRoleButton.Margin = new Padding(3, 4, 3, 4);
            viewRoleButton.Name = "viewRoleButton";
            viewRoleButton.Size = new Size(175, 62);
            viewRoleButton.TabIndex = 21;
            viewRoleButton.Text = "ver cargos";
            viewRoleButton.UseVisualStyleBackColor = false;
            // 
            // ViewEmployeesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1650, 941);
            Controls.Add(viewRoleButton);
            Controls.Add(addEmployeegroupBox);
            Controls.Add(btnDeteleEmployee);
            Controls.Add(btnEditEmployee);
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
        private Button btnEditEmployee;
        private Button btnDeteleEmployee;
        private TextBox txtName;
        private PictureBox emplyeesIconPictureBox;
        private Label nameEmployee;
        private Label lastNameEmployee;
        private TextBox txtLastName;
        private Label passwordEmployee;
        private TextBox txtPassword;
        private Label usuarioEmployee;
        private TextBox txtUsuario;
        private Label emailEmployee;
        private TextBox txtGmail;
        private Label duiEmployee;
        private TextBox txtDui;
        private GroupBox addEmployeegroupBox;
        private ComboBox roleComboBox;
        private Label roleLabel;
        private Button viewRoleButton;
    }
}