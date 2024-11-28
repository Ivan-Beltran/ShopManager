namespace PresentationLayer.Forms
{
    partial class ViewCustomers
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
            viewCustomersDataGridView = new DataGridView();
            registerClientsLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)viewCustomersDataGridView).BeginInit();
            SuspendLayout();
            // 
            // viewCustomersDataGridView
            // 
            viewCustomersDataGridView.BackgroundColor = Color.SkyBlue;
            viewCustomersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            viewCustomersDataGridView.Location = new Point(93, 198);
            viewCustomersDataGridView.Name = "viewCustomersDataGridView";
            viewCustomersDataGridView.Size = new Size(1094, 272);
            viewCustomersDataGridView.TabIndex = 0;
            // 
            // registerClientsLabel
            // 
            registerClientsLabel.AutoSize = true;
            registerClientsLabel.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            registerClientsLabel.Location = new Point(498, 97);
            registerClientsLabel.Name = "registerClientsLabel";
            registerClientsLabel.Size = new Size(231, 25);
            registerClientsLabel.TabIndex = 1;
            registerClientsLabel.Text = "Clientes Registrados";
            // 
            // ViewCustomers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1279, 667);
            Controls.Add(registerClientsLabel);
            Controls.Add(viewCustomersDataGridView);
            Name = "ViewCustomers";
            Text = "ViewCustomers";
            ((System.ComponentModel.ISupportInitialize)viewCustomersDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView viewCustomersDataGridView;
        private Label registerClientsLabel;
    }
}