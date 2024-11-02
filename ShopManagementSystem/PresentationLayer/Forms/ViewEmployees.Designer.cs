namespace PresentationLayer.Forms
{
    partial class ViewEmployees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewEmployees));
            panel1 = new Panel();
            searchEmployee = new Label();
            BoxEmployee = new ComboBox();
            dataEmployee = new DataGridView();
            btnAddEmployee = new Button();
            btnEditEmployee = new Button();
            btnDeteleEmployee = new Button();
            txtAddEmployee = new TextBox();
            boxEditEmployee = new ComboBox();
            boxDeteleEmployee = new ComboBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataEmployee).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 166, 225);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(BoxEmployee);
            panel1.Controls.Add(searchEmployee);
            panel1.Location = new Point(-31, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1173, 64);
            panel1.TabIndex = 1;
            // 
            // searchEmployee
            // 
            searchEmployee.AutoSize = true;
            searchEmployee.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchEmployee.ForeColor = SystemColors.ButtonFace;
            searchEmployee.Location = new Point(204, 21);
            searchEmployee.Name = "searchEmployee";
            searchEmployee.Size = new Size(172, 25);
            searchEmployee.TabIndex = 0;
            searchEmployee.Text = "Buscar Empleado";
            // 
            // BoxEmployee
            // 
            BoxEmployee.FormattingEnabled = true;
            BoxEmployee.Location = new Point(399, 21);
            BoxEmployee.Name = "BoxEmployee";
            BoxEmployee.Size = new Size(480, 23);
            BoxEmployee.TabIndex = 2;
            // 
            // dataEmployee
            // 
            dataEmployee.BackgroundColor = Color.Lavender;
            dataEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataEmployee.Location = new Point(24, 106);
            dataEmployee.Name = "dataEmployee";
            dataEmployee.Size = new Size(1070, 252);
            dataEmployee.TabIndex = 2;
            // 
            // btnAddEmployee
            // 
            btnAddEmployee.BackColor = Color.FromArgb(0, 166, 225);
            btnAddEmployee.Font = new Font("Segoe UI Historic", 11F, FontStyle.Bold);
            btnAddEmployee.ForeColor = Color.White;
            btnAddEmployee.Location = new Point(717, 422);
            btnAddEmployee.Name = "btnAddEmployee";
            btnAddEmployee.Size = new Size(230, 37);
            btnAddEmployee.TabIndex = 3;
            btnAddEmployee.Text = "Agregar nuevo empledo";
            btnAddEmployee.UseVisualStyleBackColor = false;
            // 
            // btnEditEmployee
            // 
            btnEditEmployee.BackColor = Color.FromArgb(0, 166, 225);
            btnEditEmployee.Font = new Font("Segoe UI Historic", 11F, FontStyle.Bold);
            btnEditEmployee.ForeColor = Color.White;
            btnEditEmployee.Location = new Point(717, 497);
            btnEditEmployee.Name = "btnEditEmployee";
            btnEditEmployee.Size = new Size(230, 37);
            btnEditEmployee.TabIndex = 4;
            btnEditEmployee.Text = "Editar empleado";
            btnEditEmployee.UseVisualStyleBackColor = false;
            // 
            // btnDeteleEmployee
            // 
            btnDeteleEmployee.BackColor = Color.FromArgb(0, 166, 225);
            btnDeteleEmployee.Font = new Font("Segoe UI Historic", 11F, FontStyle.Bold);
            btnDeteleEmployee.ForeColor = Color.White;
            btnDeteleEmployee.Location = new Point(717, 575);
            btnDeteleEmployee.Name = "btnDeteleEmployee";
            btnDeteleEmployee.Size = new Size(230, 37);
            btnDeteleEmployee.TabIndex = 5;
            btnDeteleEmployee.Text = "Borrar empleado";
            btnDeteleEmployee.UseVisualStyleBackColor = false;
            // 
            // txtAddEmployee
            // 
            txtAddEmployee.Location = new Point(86, 431);
            txtAddEmployee.Name = "txtAddEmployee";
            txtAddEmployee.Size = new Size(480, 23);
            txtAddEmployee.TabIndex = 6;
            // 
            // boxEditEmployee
            // 
            boxEditEmployee.FormattingEnabled = true;
            boxEditEmployee.Location = new Point(86, 506);
            boxEditEmployee.Name = "boxEditEmployee";
            boxEditEmployee.Size = new Size(480, 23);
            boxEditEmployee.TabIndex = 7;
            // 
            // boxDeteleEmployee
            // 
            boxDeteleEmployee.FormattingEnabled = true;
            boxDeteleEmployee.Location = new Point(86, 584);
            boxDeteleEmployee.Name = "boxDeteleEmployee";
            boxDeteleEmployee.Size = new Size(480, 23);
            boxDeteleEmployee.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(0, 166, 225);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(98, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // ViewEmployees
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1134, 654);
            Controls.Add(boxDeteleEmployee);
            Controls.Add(boxEditEmployee);
            Controls.Add(txtAddEmployee);
            Controls.Add(btnDeteleEmployee);
            Controls.Add(btnEditEmployee);
            Controls.Add(btnAddEmployee);
            Controls.Add(dataEmployee);
            Controls.Add(panel1);
            Name = "ViewEmployees";
            Text = "ViewEmployees";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataEmployee).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private ComboBox BoxEmployee;
        private Label searchEmployee;
        private DataGridView dataEmployee;
        private Button btnAddEmployee;
        private Button btnEditEmployee;
        private Button btnDeteleEmployee;
        private TextBox txtAddEmployee;
        private ComboBox boxEditEmployee;
        private ComboBox boxDeteleEmployee;
        private PictureBox pictureBox1;
    }
}