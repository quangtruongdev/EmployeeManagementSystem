namespace EmployeeManagementSystem.Forms.Salary
{
    partial class Salary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Salary));
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.col_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Action = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_search
            // 
            this.txt_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_search.Location = new System.Drawing.Point(696, 20);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(150, 30);
            this.txt_search.TabIndex = 1;
            // 
            // btn_search
            // 
            this.btn_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_search.Location = new System.Drawing.Point(864, 12);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(88, 47);
            this.btn_search.TabIndex = 2;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_name,
            this.col_email,
            this.col_position,
            this.col_salary,
            this.col_Action});
            this.dataGridView1.Location = new System.Drawing.Point(-3, 84);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1031, 372);
            this.dataGridView1.TabIndex = 0;
            // 
            // col_name
            // 
            this.col_name.DataPropertyName = "FirstName";
            this.col_name.HeaderText = "Name";
            this.col_name.MinimumWidth = 6;
            this.col_name.Name = "col_name";
            // 
            // col_email
            // 
            this.col_email.DataPropertyName = "Email";
            this.col_email.HeaderText = "Email";
            this.col_email.MinimumWidth = 6;
            this.col_email.Name = "col_email";
            // 
            // col_position
            // 
            this.col_position.DataPropertyName = "PositionName";
            this.col_position.HeaderText = "Position";
            this.col_position.MinimumWidth = 6;
            this.col_position.Name = "col_position";
            // 
            // col_salary
            // 
            this.col_salary.DataPropertyName = "SalaryAmount";
            this.col_salary.HeaderText = "Salary";
            this.col_salary.MinimumWidth = 6;
            this.col_salary.Name = "col_salary";
            // 
            // col_Action
            // 
            this.col_Action.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_Action.HeaderText = "Action";
            this.col_Action.Image = ((System.Drawing.Image)(resources.GetObject("col_Action.Image")));
            this.col_Action.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.col_Action.MinimumWidth = 6;
            this.col_Action.Name = "col_Action";
            this.col_Action.Width = 73;
            // 
            // Salary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 544);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Salary";
            this.Text = "Salary";
            this.Load += new System.EventHandler(this.Salary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_email;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_position;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_salary;
        private System.Windows.Forms.DataGridViewImageColumn col_Action;
    }
}