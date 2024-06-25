using System.Windows.Forms;

namespace EmployeeManagementSystem.Forms.Department
{
    partial class Department
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Department));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_AddDepartment = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PagingContainer = new System.Windows.Forms.Panel();
            this.PageOnPage = new System.Windows.Forms.Label();
            this.Btn_Next = new System.Windows.Forms.Button();
            this.Btn_Pre = new System.Windows.Forms.Button();
            this.Tbl_Departments = new System.Windows.Forms.DataGridView();
            this.DepartmentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartmentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Btn_Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.PagingContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tbl_Departments)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Btn_AddDepartment);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 60);
            this.panel1.TabIndex = 0;
            // 
            // Btn_AddDepartment
            // 
            this.Btn_AddDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_AddDepartment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_AddDepartment.Image = ((System.Drawing.Image)(resources.GetObject("Btn_AddDepartment.Image")));
            this.Btn_AddDepartment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_AddDepartment.Location = new System.Drawing.Point(588, 5);
            this.Btn_AddDepartment.Name = "Btn_AddDepartment";
            this.Btn_AddDepartment.Size = new System.Drawing.Size(200, 45);
            this.Btn_AddDepartment.TabIndex = 1;
            this.Btn_AddDepartment.Text = "Add Department";
            this.Btn_AddDepartment.UseVisualStyleBackColor = true;
            this.Btn_AddDepartment.Click += new System.EventHandler(this.Btn_AddDepartment_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Department";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.PagingContainer);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 350);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 100);
            this.panel2.TabIndex = 2;
            // 
            // PagingContainer
            // 
            this.PagingContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PagingContainer.Controls.Add(this.PageOnPage);
            this.PagingContainer.Controls.Add(this.Btn_Next);
            this.PagingContainer.Controls.Add(this.Btn_Pre);
            this.PagingContainer.Location = new System.Drawing.Point(559, 6);
            this.PagingContainer.Name = "PagingContainer";
            this.PagingContainer.Size = new System.Drawing.Size(230, 40);
            this.PagingContainer.TabIndex = 0;
            // 
            // PageOnPage
            // 
            this.PageOnPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PageOnPage.AutoSize = true;
            this.PageOnPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PageOnPage.Location = new System.Drawing.Point(81, 12);
            this.PageOnPage.Name = "PageOnPage";
            this.PageOnPage.Size = new System.Drawing.Size(61, 16);
            this.PageOnPage.TabIndex = 2;
            this.PageOnPage.Text = "Page 1/1";
            // 
            // Btn_Next
            // 
            this.Btn_Next.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_Next.Location = new System.Drawing.Point(155, 0);
            this.Btn_Next.Name = "Btn_Next";
            this.Btn_Next.Size = new System.Drawing.Size(75, 40);
            this.Btn_Next.TabIndex = 1;
            this.Btn_Next.Text = "Next";
            this.Btn_Next.UseVisualStyleBackColor = true;
            this.Btn_Next.Click += new System.EventHandler(this.Btn_Next_Click);
            // 
            // Btn_Pre
            // 
            this.Btn_Pre.Dock = System.Windows.Forms.DockStyle.Left;
            this.Btn_Pre.Location = new System.Drawing.Point(0, 0);
            this.Btn_Pre.Name = "Btn_Pre";
            this.Btn_Pre.Size = new System.Drawing.Size(75, 40);
            this.Btn_Pre.TabIndex = 0;
            this.Btn_Pre.Text = "Previous";
            this.Btn_Pre.UseVisualStyleBackColor = true;
            this.Btn_Pre.Click += new System.EventHandler(this.Btn_Pre_Click);
            // 
            // Tbl_Departments
            // 
            this.Tbl_Departments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tbl_Departments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DepartmentID,
            this.DepartmentName,
            this.Btn_Edit,
            this.Btn_Delete});
            this.Tbl_Departments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tbl_Departments.Location = new System.Drawing.Point(0, 60);
            this.Tbl_Departments.Name = "Tbl_Departments";
            this.Tbl_Departments.RowHeadersWidth = 51;
            this.Tbl_Departments.RowTemplate.Height = 24;
            this.Tbl_Departments.Size = new System.Drawing.Size(800, 290);
            this.Tbl_Departments.TabIndex = 3;
            this.Tbl_Departments.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Tbl_Departments_CellContentClick);
            // 
            // DepartmentID
            // 
            this.DepartmentID.DataPropertyName = "DepartmentID";
            this.DepartmentID.HeaderText = "#";
            this.DepartmentID.MinimumWidth = 6;
            this.DepartmentID.Name = "DepartmentID";
            this.DepartmentID.Width = 50;
            // 
            // DepartmentName
            // 
            this.DepartmentName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DepartmentName.DataPropertyName = "DepartmentName";
            this.DepartmentName.HeaderText = "Department Name";
            this.DepartmentName.MinimumWidth = 6;
            this.DepartmentName.Name = "DepartmentName";
            // 
            // Btn_Edit
            // 
            this.Btn_Edit.HeaderText = "Actions";
            this.Btn_Edit.MinimumWidth = 6;
            this.Btn_Edit.Name = "Btn_Edit";
            this.Btn_Edit.Text = "Edit";
            this.Btn_Edit.Width = 50;
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.HeaderText = "";
            this.Btn_Delete.MinimumWidth = 6;
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Text = "Delete";
            this.Btn_Delete.Width = 50;
            // 
            // Department
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Tbl_Departments);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Department";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Department";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.PagingContainer.ResumeLayout(false);
            this.PagingContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tbl_Departments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_AddDepartment;
        private System.Windows.Forms.Panel panel2;
        private DataGridView Tbl_Departments;
        private DataGridViewTextBoxColumn DepartmentID;
        private DataGridViewTextBoxColumn DepartmentName;
        private DataGridViewButtonColumn Btn_Edit;
        private DataGridViewButtonColumn Btn_Delete;
        private Panel PagingContainer;
        private Button Btn_Pre;
        private Button Btn_Next;
        private Label PageOnPage;
    }
}