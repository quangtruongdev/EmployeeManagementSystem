namespace EmployeeManagementSystem.Forms.Leave
{
    partial class LeaveLists
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LeaveLists));
            this.label1 = new System.Windows.Forms.Label();
            this.Tbl_HeadContainer = new System.Windows.Forms.Panel();
            this.Btn_AddLeave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Txt_Search = new System.Windows.Forms.TextBox();
            this.PagingContainer = new System.Windows.Forms.Panel();
            this.PageOnPage = new System.Windows.Forms.Label();
            this.Btn_Next = new System.Windows.Forms.Button();
            this.Btn_Prev = new System.Windows.Forms.Button();
            this.Tbl_LeaveListsContainer = new System.Windows.Forms.Panel();
            this.Tbl_LeaveLists = new System.Windows.Forms.DataGridView();
            this.EmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeaveType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeaveFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeaveEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Col_Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Btn_Search = new System.Windows.Forms.Button();
            this.Tbl_HeadContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.PagingContainer.SuspendLayout();
            this.Tbl_LeaveListsContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tbl_LeaveLists)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Leave Requests";
            // 
            // Tbl_HeadContainer
            // 
            this.Tbl_HeadContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tbl_HeadContainer.Controls.Add(this.Btn_AddLeave);
            this.Tbl_HeadContainer.Controls.Add(this.panel1);
            this.Tbl_HeadContainer.Location = new System.Drawing.Point(12, 50);
            this.Tbl_HeadContainer.Name = "Tbl_HeadContainer";
            this.Tbl_HeadContainer.Size = new System.Drawing.Size(776, 50);
            this.Tbl_HeadContainer.TabIndex = 2;
            // 
            // Btn_AddLeave
            // 
            this.Btn_AddLeave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_AddLeave.Image = ((System.Drawing.Image)(resources.GetObject("Btn_AddLeave.Image")));
            this.Btn_AddLeave.Location = new System.Drawing.Point(737, 7);
            this.Btn_AddLeave.Name = "Btn_AddLeave";
            this.Btn_AddLeave.Size = new System.Drawing.Size(36, 36);
            this.Btn_AddLeave.TabIndex = 1;
            this.Btn_AddLeave.UseVisualStyleBackColor = true;
            this.Btn_AddLeave.Click += new System.EventHandler(this.Btn_AddLeave_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Btn_Search);
            this.panel1.Controls.Add(this.Txt_Search);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 50);
            this.panel1.TabIndex = 0;
            // 
            // Txt_Search
            // 
            this.Txt_Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Search.Location = new System.Drawing.Point(5, 7);
            this.Txt_Search.Multiline = true;
            this.Txt_Search.Name = "Txt_Search";
            this.Txt_Search.Size = new System.Drawing.Size(300, 35);
            this.Txt_Search.TabIndex = 1;
            // 
            // PagingContainer
            // 
            this.PagingContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PagingContainer.Controls.Add(this.PageOnPage);
            this.PagingContainer.Controls.Add(this.Btn_Next);
            this.PagingContainer.Controls.Add(this.Btn_Prev);
            this.PagingContainer.Location = new System.Drawing.Point(558, 398);
            this.PagingContainer.Name = "PagingContainer";
            this.PagingContainer.Size = new System.Drawing.Size(230, 40);
            this.PagingContainer.TabIndex = 5;
            // 
            // PageOnPage
            // 
            this.PageOnPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PageOnPage.AutoSize = true;
            this.PageOnPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PageOnPage.Location = new System.Drawing.Point(81, 10);
            this.PageOnPage.Name = "PageOnPage";
            this.PageOnPage.Size = new System.Drawing.Size(66, 18);
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
            // Btn_Prev
            // 
            this.Btn_Prev.Dock = System.Windows.Forms.DockStyle.Left;
            this.Btn_Prev.Location = new System.Drawing.Point(0, 0);
            this.Btn_Prev.Name = "Btn_Prev";
            this.Btn_Prev.Size = new System.Drawing.Size(75, 40);
            this.Btn_Prev.TabIndex = 0;
            this.Btn_Prev.Text = "Previous";
            this.Btn_Prev.UseVisualStyleBackColor = true;
            this.Btn_Prev.Click += new System.EventHandler(this.Btn_Prev_Click);
            // 
            // Tbl_LeaveListsContainer
            // 
            this.Tbl_LeaveListsContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tbl_LeaveListsContainer.Controls.Add(this.Tbl_LeaveLists);
            this.Tbl_LeaveListsContainer.Location = new System.Drawing.Point(12, 106);
            this.Tbl_LeaveListsContainer.Name = "Tbl_LeaveListsContainer";
            this.Tbl_LeaveListsContainer.Size = new System.Drawing.Size(776, 286);
            this.Tbl_LeaveListsContainer.TabIndex = 6;
            // 
            // Tbl_LeaveLists
            // 
            this.Tbl_LeaveLists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tbl_LeaveLists.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmployeeName,
            this.LeaveType,
            this.LeaveFrom,
            this.LeaveEnd,
            this.Status,
            this.Reason,
            this.Col_Edit,
            this.Col_Delete});
            this.Tbl_LeaveLists.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tbl_LeaveLists.Location = new System.Drawing.Point(0, 0);
            this.Tbl_LeaveLists.Name = "Tbl_LeaveLists";
            this.Tbl_LeaveLists.RowHeadersWidth = 51;
            this.Tbl_LeaveLists.RowTemplate.Height = 24;
            this.Tbl_LeaveLists.Size = new System.Drawing.Size(776, 286);
            this.Tbl_LeaveLists.TabIndex = 5;
            this.Tbl_LeaveLists.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Tbl_LeaveLists_CellContentClick);
            // 
            // EmployeeName
            // 
            this.EmployeeName.HeaderText = "Name";
            this.EmployeeName.MinimumWidth = 6;
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.Width = 125;
            // 
            // LeaveType
            // 
            this.LeaveType.HeaderText = "LeaveType";
            this.LeaveType.MinimumWidth = 6;
            this.LeaveType.Name = "LeaveType";
            this.LeaveType.Width = 125;
            // 
            // LeaveFrom
            // 
            this.LeaveFrom.HeaderText = "Leave From";
            this.LeaveFrom.MinimumWidth = 6;
            this.LeaveFrom.Name = "LeaveFrom";
            this.LeaveFrom.Width = 125;
            // 
            // LeaveEnd
            // 
            this.LeaveEnd.HeaderText = "LeaveEnd";
            this.LeaveEnd.MinimumWidth = 6;
            this.LeaveEnd.Name = "LeaveEnd";
            this.LeaveEnd.Width = 125;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.Width = 125;
            // 
            // Reason
            // 
            this.Reason.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Reason.HeaderText = "Reason";
            this.Reason.MinimumWidth = 6;
            this.Reason.Name = "Reason";
            // 
            // Col_Edit
            // 
            this.Col_Edit.HeaderText = "Actions";
            this.Col_Edit.MinimumWidth = 6;
            this.Col_Edit.Name = "Col_Edit";
            this.Col_Edit.Width = 50;
            // 
            // Col_Delete
            // 
            this.Col_Delete.HeaderText = "";
            this.Col_Delete.MinimumWidth = 6;
            this.Col_Delete.Name = "Col_Delete";
            this.Col_Delete.Width = 50;
            // 
            // Btn_Search
            // 
            this.Btn_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Search.Location = new System.Drawing.Point(311, 8);
            this.Btn_Search.Name = "Btn_Search";
            this.Btn_Search.Size = new System.Drawing.Size(75, 35);
            this.Btn_Search.TabIndex = 2;
            this.Btn_Search.Text = "Search";
            this.Btn_Search.UseVisualStyleBackColor = true;
            this.Btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // LeaveLists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Tbl_LeaveListsContainer);
            this.Controls.Add(this.PagingContainer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tbl_HeadContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LeaveLists";
            this.Text = "LeaveLists";
            this.Tbl_HeadContainer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PagingContainer.ResumeLayout(false);
            this.PagingContainer.PerformLayout();
            this.Tbl_LeaveListsContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Tbl_LeaveLists)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Tbl_HeadContainer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Txt_Search;
        private System.Windows.Forms.Button Btn_AddLeave;
        private System.Windows.Forms.Panel PagingContainer;
        private System.Windows.Forms.Button Btn_Next;
        private System.Windows.Forms.Button Btn_Prev;
        private System.Windows.Forms.Label PageOnPage;
        private System.Windows.Forms.Panel Tbl_LeaveListsContainer;
        private System.Windows.Forms.DataGridView Tbl_LeaveLists;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeaveType;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeaveFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeaveEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reason;
        private System.Windows.Forms.DataGridViewButtonColumn Col_Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Col_Delete;
        private System.Windows.Forms.Button Btn_Search;
    }
}