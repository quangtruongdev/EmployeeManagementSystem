namespace EmployeeManagementSystem.Forms.Project
{
    partial class AddEmployeeToProject
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
            this.membersDataGridView = new System.Windows.Forms.DataGridView();
            this.EmployeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.projectNameLabel = new System.Windows.Forms.Label();
            this.membersComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.endDateLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.positionsComboBox = new System.Windows.Forms.ComboBox();
            this.addMemberBtn = new System.Windows.Forms.Button();
            this.PagingContainer = new System.Windows.Forms.Panel();
            this.PageOnPage = new System.Windows.Forms.Label();
            this.Btn_Next = new System.Windows.Forms.Button();
            this.Btn_Pre = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.membersDataGridView)).BeginInit();
            this.PagingContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // membersDataGridView
            // 
            this.membersDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.membersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.membersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.membersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmployeeId,
            this.FirstName,
            this.LastName,
            this.Position,
            this.DeleteBtn});
            this.membersDataGridView.Location = new System.Drawing.Point(-1, 238);
            this.membersDataGridView.Name = "membersDataGridView";
            this.membersDataGridView.RowHeadersWidth = 51;
            this.membersDataGridView.RowTemplate.Height = 24;
            this.membersDataGridView.Size = new System.Drawing.Size(816, 251);
            this.membersDataGridView.TabIndex = 0;
            this.membersDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.membersDataGridView_CellContentClick);
            // 
            // EmployeeId
            // 
            this.EmployeeId.HeaderText = "Employee Id";
            this.EmployeeId.MinimumWidth = 6;
            this.EmployeeId.Name = "EmployeeId";
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "First Name";
            this.FirstName.MinimumWidth = 6;
            this.FirstName.Name = "FirstName";
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Last Name";
            this.LastName.MinimumWidth = 6;
            this.LastName.Name = "LastName";
            // 
            // Position
            // 
            this.Position.HeaderText = "Position";
            this.Position.MinimumWidth = 6;
            this.Position.Name = "Position";
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.HeaderText = "";
            this.DeleteBtn.MinimumWidth = 6;
            this.DeleteBtn.Name = "DeleteBtn";
            // 
            // projectNameLabel
            // 
            this.projectNameLabel.AutoSize = true;
            this.projectNameLabel.Location = new System.Drawing.Point(114, 86);
            this.projectNameLabel.Name = "projectNameLabel";
            this.projectNameLabel.Size = new System.Drawing.Size(89, 16);
            this.projectNameLabel.TabIndex = 1;
            this.projectNameLabel.Text = "Project Name";
            // 
            // membersComboBox
            // 
            this.membersComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.membersComboBox.FormattingEnabled = true;
            this.membersComboBox.Location = new System.Drawing.Point(552, 91);
            this.membersComboBox.MaximumSize = new System.Drawing.Size(895, 0);
            this.membersComboBox.MinimumSize = new System.Drawing.Size(195, 0);
            this.membersComboBox.Name = "membersComboBox";
            this.membersComboBox.Size = new System.Drawing.Size(195, 24);
            this.membersComboBox.TabIndex = 2;
            this.membersComboBox.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedIndexChanged);
            this.membersComboBox.TextChanged += new System.EventHandler(this.ComboBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Members in project details";
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Location = new System.Drawing.Point(114, 111);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(66, 16);
            this.startDateLabel.TabIndex = 1;
            this.startDateLabel.Text = "Start Date";
            // 
            // endDateLabel
            // 
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.Location = new System.Drawing.Point(114, 138);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(63, 16);
            this.endDateLabel.TabIndex = 1;
            this.endDateLabel.Text = "End Date";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(483, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Member";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(483, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Position";
            // 
            // positionsComboBox
            // 
            this.positionsComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.positionsComboBox.FormattingEnabled = true;
            this.positionsComboBox.Location = new System.Drawing.Point(552, 135);
            this.positionsComboBox.MaximumSize = new System.Drawing.Size(895, 0);
            this.positionsComboBox.MinimumSize = new System.Drawing.Size(195, 0);
            this.positionsComboBox.Name = "positionsComboBox";
            this.positionsComboBox.Size = new System.Drawing.Size(195, 24);
            this.positionsComboBox.TabIndex = 2;
            this.positionsComboBox.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedIndexChanged);
            this.positionsComboBox.TextChanged += new System.EventHandler(this.ComboBox_TextChanged);
            // 
            // addMemberBtn
            // 
            this.addMemberBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addMemberBtn.Enabled = false;
            this.addMemberBtn.Location = new System.Drawing.Point(595, 174);
            this.addMemberBtn.MaximumSize = new System.Drawing.Size(808, 29);
            this.addMemberBtn.MinimumSize = new System.Drawing.Size(108, 29);
            this.addMemberBtn.Name = "addMemberBtn";
            this.addMemberBtn.Size = new System.Drawing.Size(108, 29);
            this.addMemberBtn.TabIndex = 3;
            this.addMemberBtn.Text = "Add Member";
            this.addMemberBtn.UseVisualStyleBackColor = true;
            this.addMemberBtn.Click += new System.EventHandler(this.addMemberBtn_Click);
            // 
            // PagingContainer
            // 
            this.PagingContainer.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.PagingContainer.Controls.Add(this.PageOnPage);
            this.PagingContainer.Controls.Add(this.Btn_Next);
            this.PagingContainer.Controls.Add(this.Btn_Pre);
            this.PagingContainer.Location = new System.Drawing.Point(292, 516);
            this.PagingContainer.Name = "PagingContainer";
            this.PagingContainer.Size = new System.Drawing.Size(230, 40);
            this.PagingContainer.TabIndex = 4;
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
            // AddEmployeeToProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 588);
            this.Controls.Add(this.PagingContainer);
            this.Controls.Add(this.addMemberBtn);
            this.Controls.Add(this.positionsComboBox);
            this.Controls.Add(this.membersComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.endDateLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.startDateLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.projectNameLabel);
            this.Controls.Add(this.membersDataGridView);
            this.Name = "AddEmployeeToProject";
            this.Text = "AddEmployeeToProject";
            ((System.ComponentModel.ISupportInitialize)(this.membersDataGridView)).EndInit();
            this.PagingContainer.ResumeLayout(false);
            this.PagingContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView membersDataGridView;
        private System.Windows.Forms.Label projectNameLabel;
        private System.Windows.Forms.ComboBox membersComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.Label endDateLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox positionsComboBox;
        private System.Windows.Forms.Button addMemberBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Position;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteBtn;
        private System.Windows.Forms.Panel PagingContainer;
        private System.Windows.Forms.Label PageOnPage;
        private System.Windows.Forms.Button Btn_Next;
        private System.Windows.Forms.Button Btn_Pre;
    }
}