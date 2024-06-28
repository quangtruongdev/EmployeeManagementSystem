namespace EmployeeManagementSystem.Forms.Project
{
    partial class Project
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Project));
            this.Tbl_Projects = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_AddProject = new System.Windows.Forms.Button();
            this.PagingContainer = new System.Windows.Forms.Panel();
            this.PageOnPage = new System.Windows.Forms.Label();
            this.Btn_Next = new System.Windows.Forms.Button();
            this.Btn_Pre = new System.Windows.Forms.Button();
            this.ProjectId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Tbl_Projects)).BeginInit();
            this.PagingContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tbl_Projects
            // 
            this.Tbl_Projects.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tbl_Projects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Tbl_Projects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tbl_Projects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProjectId,
            this.ProjectName,
            this.Description,
            this.StartDate,
            this.EndDate,
            this.BtnEdit,
            this.BtnDelete});
            this.Tbl_Projects.Location = new System.Drawing.Point(-1, 103);
            this.Tbl_Projects.Name = "Tbl_Projects";
            this.Tbl_Projects.RowHeadersWidth = 51;
            this.Tbl_Projects.RowTemplate.Height = 24;
            this.Tbl_Projects.Size = new System.Drawing.Size(1004, 441);
            this.Tbl_Projects.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Project";
            // 
            // Btn_AddProject
            // 
            this.Btn_AddProject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_AddProject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_AddProject.Image = ((System.Drawing.Image)(resources.GetObject("Btn_AddProject.Image")));
            this.Btn_AddProject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_AddProject.Location = new System.Drawing.Point(790, 12);
            this.Btn_AddProject.Name = "Btn_AddProject";
            this.Btn_AddProject.Size = new System.Drawing.Size(200, 45);
            this.Btn_AddProject.TabIndex = 2;
            this.Btn_AddProject.Text = "Add Department";
            this.Btn_AddProject.UseVisualStyleBackColor = true;
            // 
            // PagingContainer
            // 
            this.PagingContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PagingContainer.Controls.Add(this.PageOnPage);
            this.PagingContainer.Controls.Add(this.Btn_Next);
            this.PagingContainer.Controls.Add(this.Btn_Pre);
            this.PagingContainer.Location = new System.Drawing.Point(728, 559);
            this.PagingContainer.Name = "PagingContainer";
            this.PagingContainer.Size = new System.Drawing.Size(230, 40);
            this.PagingContainer.TabIndex = 3;
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
            // ProjectId
            // 
            this.ProjectId.DataPropertyName = "ProjectId";
            this.ProjectId.HeaderText = "Project Id";
            this.ProjectId.MinimumWidth = 6;
            this.ProjectId.Name = "ProjectId";
            // 
            // ProjectName
            // 
            this.ProjectName.DataPropertyName = "ProjectName";
            this.ProjectName.HeaderText = "Project Name";
            this.ProjectName.MinimumWidth = 6;
            this.ProjectName.Name = "ProjectName";
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            // 
            // StartDate
            // 
            this.StartDate.DataPropertyName = "StartDate";
            this.StartDate.HeaderText = "Start Date";
            this.StartDate.MinimumWidth = 6;
            this.StartDate.Name = "StartDate";
            // 
            // EndDate
            // 
            this.EndDate.DataPropertyName = "EndDate";
            this.EndDate.HeaderText = "End Date";
            this.EndDate.MinimumWidth = 6;
            this.EndDate.Name = "EndDate";
            // 
            // BtnEdit
            // 
            this.BtnEdit.HeaderText = "";
            this.BtnEdit.MinimumWidth = 6;
            this.BtnEdit.Name = "BtnEdit";
            // 
            // BtnDelete
            // 
            this.BtnDelete.HeaderText = "";
            this.BtnDelete.MinimumWidth = 6;
            this.BtnDelete.Name = "BtnDelete";
            // 
            // Project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 628);
            this.Controls.Add(this.PagingContainer);
            this.Controls.Add(this.Btn_AddProject);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tbl_Projects);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Project";
            this.Text = "Project";
            ((System.ComponentModel.ISupportInitialize)(this.Tbl_Projects)).EndInit();
            this.PagingContainer.ResumeLayout(false);
            this.PagingContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Tbl_Projects;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_AddProject;
        private System.Windows.Forms.Panel PagingContainer;
        private System.Windows.Forms.Label PageOnPage;
        private System.Windows.Forms.Button Btn_Next;
        private System.Windows.Forms.Button Btn_Pre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDate;
        private System.Windows.Forms.DataGridViewButtonColumn BtnEdit;
        private System.Windows.Forms.DataGridViewButtonColumn BtnDelete;
    }
}