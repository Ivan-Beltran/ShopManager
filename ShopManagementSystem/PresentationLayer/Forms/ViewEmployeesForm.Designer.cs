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
            boxEditEmployee = new ComboBox();
            boxDeteleEmployee = new ComboBox();
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
            searchEmployeeLabel.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchEmployeeLabel.ForeColor = SystemColors.ActiveCaptionText;
            searchEmployeeLabel.Location = new Point(204, 21);
            searchEmployeeLabel.Name = "searchEmployeeLabel";
            searchEmployeeLabel.Size = new Size(172, 25);
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
            EmployeesDataGridView.Size = new Size(1198, 252);
            EmployeesDataGridView.TabIndex = 2;
            // 
            // btnAddEmployee
            // 
            btnAddEmployee.BackColor = Color.FromArgb(0, 166, 225);
            btnAddEmployee.Font = new Font("Segoe UI Historic", 11F, FontStyle.Bold);
            btnAddEmployee.ForeColor = Color.White;
            btnAddEmployee.Location = new Point(1178, 509);
            btnAddEmployee.Name = "btnAddEmployee";
            btnAddEmployee.Size = new Size(262, 56);
            btnAddEmployee.TabIndex = 3;
            btnAddEmployee.Text = "Agregar nuevo empledo";
            btnAddEmployee.UseVisualStyleBackColor = false;
            // 
            // btnEditEmployee
            // 
            btnEditEmployee.BackColor = Color.FromArgb(0, 166, 225);
            btnEditEmployee.Font = new Font("Segoe UI Historic", 11F, FontStyle.Bold);
            btnEditEmployee.ForeColor = Color.White;
            btnEditEmployee.Location = new Point(1562, 134);
            btnEditEmployee.Name = "btnEditEmployee";
            btnEditEmployee.Size = new Size(130, 60);
            btnEditEmployee.TabIndex = 4;
            btnEditEmployee.Text = "Editar empleado";
            btnEditEmployee.UseVisualStyleBackColor = false;
            // 
            // btnDeteleEmployee
            // 
            btnDeteleEmployee.BackColor = Color.FromArgb(0, 166, 225);
            btnDeteleEmployee.Font = new Font("Segoe UI Historic", 11F, FontStyle.Bold);
            btnDeteleEmployee.ForeColor = Color.White;
            btnDeteleEmployee.Location = new Point(1562, 246);
            btnDeteleEmployee.Name = "btnDeteleEmployee";
            btnDeteleEmployee.Size = new Size(130, 60);
            btnDeteleEmployee.TabIndex = 5;
            btnDeteleEmployee.Text = "Borrar empleado";
            btnDeteleEmployee.UseVisualStyleBackColor = false;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI Historic", 11F, FontStyle.Bold);
            txtName.Location = new Point(122, 496);
            txtName.Name = "txtName";
            txtName.Size = new Size(201, 27);
            txtName.TabIndex = 6;
            // 
            // boxEditEmployee
            // 
            boxEditEmployee.FormattingEnabled = true;
            boxEditEmployee.Location = new Point(1239, 155);
            boxEditEmployee.Name = "boxEditEmployee";
            boxEditEmployee.Size = new Size(291, 23);
            boxEditEmployee.TabIndex = 7;
            // 
            // boxDeteleEmployee
            // 
            boxDeteleEmployee.FormattingEnabled = true;
            boxDeteleEmployee.Location = new Point(1239, 267);
            boxDeteleEmployee.Name = "boxDeteleEmployee";
            boxDeteleEmployee.Size = new Size(291, 23);
            boxDeteleEmployee.TabIndex = 8;
            // 
            // nameEmployee
            // 
            nameEmployee.AutoSize = true;
            nameEmployee.Font = new Font("Segoe UI Historic", 11F, FontStyle.Bold);
            nameEmployee.Location = new Point(25, 496);
            nameEmployee.Name = "nameEmployee";
            nameEmployee.Size = new Size(74, 20);
            nameEmployee.TabIndex = 9;
            nameEmployee.Text = "Nombre:";
            // 
            // lastNameEmployee
            // 
            lastNameEmployee.AutoSize = true;
            lastNameEmployee.Font = new Font("Segoe UI Historic", 11F, FontStyle.Bold);
            lastNameEmployee.Location = new Point(25, 550);
            lastNameEmployee.Name = "lastNameEmployee";
            lastNameEmployee.Size = new Size(78, 20);
            lastNameEmployee.TabIndex = 11;
            lastNameEmployee.Text = "Apellido:";
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI Historic", 11F, FontStyle.Bold);
            txtLastName.Location = new Point(122, 550);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(201, 27);
            txtLastName.TabIndex = 10;
            // 
            // passwordEmployee
            // 
            passwordEmployee.AutoSize = true;
            passwordEmployee.Font = new Font("Segoe UI Historic", 11F, FontStyle.Bold);
            passwordEmployee.Location = new Point(382, 553);
            passwordEmployee.Name = "passwordEmployee";
            passwordEmployee.Size = new Size(97, 20);
            passwordEmployee.TabIndex = 15;
            passwordEmployee.Text = "Contraseña:";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI Historic", 11F, FontStyle.Bold);
            txtPassword.Location = new Point(479, 553);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(201, 27);
            txtPassword.TabIndex = 14;
            // 
            // usuarioEmployee
            // 
            usuarioEmployee.AutoSize = true;
            usuarioEmployee.Font = new Font("Segoe UI Historic", 11F, FontStyle.Bold);
            usuarioEmployee.Location = new Point(382, 499);
            usuarioEmployee.Name = "usuarioEmployee";
            usuarioEmployee.Size = new Size(70, 20);
            usuarioEmployee.TabIndex = 13;
            usuarioEmployee.Text = "Usuario:";
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI Historic", 11F, FontStyle.Bold);
            txtUsuario.Location = new Point(479, 499);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(201, 27);
            txtUsuario.TabIndex = 12;
            // 
            // emailEmployee
            // 
            emailEmployee.AutoSize = true;
            emailEmployee.Font = new Font("Segoe UI Historic", 11F, FontStyle.Bold);
            emailEmployee.Location = new Point(728, 556);
            emailEmployee.Name = "emailEmployee";
            emailEmployee.Size = new Size(57, 20);
            emailEmployee.TabIndex = 19;
            emailEmployee.Text = "Gmail:";
            // 
            // txtGmail
            // 
            txtGmail.Font = new Font("Segoe UI Historic", 11F, FontStyle.Bold);
            txtGmail.Location = new Point(825, 556);
            txtGmail.Name = "txtGmail";
            txtGmail.Size = new Size(201, 27);
            txtGmail.TabIndex = 18;
            // 
            // duiEmployee
            // 
            duiEmployee.AutoSize = true;
            duiEmployee.Font = new Font("Segoe UI Historic", 11F, FontStyle.Bold);
            duiEmployee.Location = new Point(728, 502);
            duiEmployee.Name = "duiEmployee";
            duiEmployee.Size = new Size(41, 20);
            duiEmployee.TabIndex = 17;
            duiEmployee.Text = "DUI:";
            // 
            // txtDui
            // 
            txtDui.Font = new Font("Segoe UI Historic", 11F, FontStyle.Bold);
            txtDui.Location = new Point(825, 502);
            txtDui.Name = "txtDui";
            txtDui.Size = new Size(201, 27);
            txtDui.TabIndex = 16;
            // 
            // ViewEmployeesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1723, 706);
            Controls.Add(emailEmployee);
            Controls.Add(txtGmail);
            Controls.Add(duiEmployee);
            Controls.Add(txtDui);
            Controls.Add(passwordEmployee);
            Controls.Add(txtPassword);
            Controls.Add(usuarioEmployee);
            Controls.Add(txtUsuario);
            Controls.Add(lastNameEmployee);
            Controls.Add(txtLastName);
            Controls.Add(nameEmployee);
            Controls.Add(boxDeteleEmployee);
            Controls.Add(boxEditEmployee);
            Controls.Add(txtName);
            Controls.Add(btnDeteleEmployee);
            Controls.Add(btnEditEmployee);
            Controls.Add(btnAddEmployee);
            Controls.Add(EmployeesDataGridView);
            Controls.Add(panel1);
            Name = "ViewEmployeesForm";
            Text = "ViewEmployees";
            WindowState = FormWindowState.Maximized;
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
        private TextBox txtName;
        private ComboBox boxEditEmployee;
        private ComboBox boxDeteleEmployee;
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
    }
}