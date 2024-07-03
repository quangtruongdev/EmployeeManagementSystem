namespace EmployeeManagementSystem.Forms.Leave
{
    partial class LeaveTypeLists
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PagingContainer = new System.Windows.Forms.Panel();
            this.PageOnPage = new System.Windows.Forms.Label();
            this.Btn_Next = new System.Windows.Forms.Button();
            this.Btn_Prev = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Btn_AddLeaveType = new System.Windows.Forms.Button();
            this.Tbl_LeaveTypeLists = new System.Windows.Forms.DataGridView();
            this.LeaveID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeaveTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            this.PagingContainer.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tbl_LeaveTypeLists)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Leave Type";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PagingContainer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 380);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 70);
            this.panel1.TabIndex = 1;
            // 
            // PagingContainer
            // 
            this.PagingContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PagingContainer.Controls.Add(this.PageOnPage);
            this.PagingContainer.Controls.Add(this.Btn_Next);
            this.PagingContainer.Controls.Add(this.Btn_Prev);
            this.PagingContainer.Location = new System.Drawing.Point(558, 18);
            this.PagingContainer.Name = "PagingContainer";
            this.PagingContainer.Size = new System.Drawing.Size(230, 40);
            this.PagingContainer.TabIndex = 6;
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
            // panel2
            // 
            this.panel2.Controls.Add(this.Btn_AddLeaveType);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 70);
            this.panel2.TabIndex = 2;
            // 
            // Btn_AddLeaveType
            // 
            this.Btn_AddLeaveType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_AddLeaveType.Location = new System.Drawing.Point(638, 12);
            this.Btn_AddLeaveType.Name = "Btn_AddLeaveType";
            this.Btn_AddLeaveType.Size = new System.Drawing.Size(150, 45);
            this.Btn_AddLeaveType.TabIndex = 1;
            this.Btn_AddLeaveType.Text = "Add Leave Type";
            this.Btn_AddLeaveType.UseVisualStyleBackColor = true;
            this.Btn_AddLeaveType.Click += new System.EventHandler(this.Btn_AddLeaveType_Click);
            // 
            // Tbl_LeaveTypeLists
            // 
            this.Tbl_LeaveTypeLists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tbl_LeaveTypeLists.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LeaveID,
            this.LeaveTypeName,
            this.Edit,
            this.Delete});
            this.Tbl_LeaveTypeLists.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tbl_LeaveTypeLists.Location = new System.Drawing.Point(0, 70);
            this.Tbl_LeaveTypeLists.Name = "Tbl_LeaveTypeLists";
            this.Tbl_LeaveTypeLists.RowHeadersWidth = 51;
            this.Tbl_LeaveTypeLists.RowTemplate.Height = 24;
            this.Tbl_LeaveTypeLists.Size = new System.Drawing.Size(800, 310);
            this.Tbl_LeaveTypeLists.TabIndex = 3;
            this.Tbl_LeaveTypeLists.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Tbl_LeaveTypeLists_CellContentClick);
            // 
            // LeaveID
            // 
            this.LeaveID.HeaderText = "Leave ID";
            this.LeaveID.MinimumWidth = 6;
            this.LeaveID.Name = "LeaveID";
            this.LeaveID.ReadOnly = true;
            this.LeaveID.Width = 125;
            // 
            // LeaveTypeName
            // 
            this.LeaveTypeName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LeaveTypeName.HeaderText = "Leave Type Name";
            this.LeaveTypeName.MinimumWidth = 6;
            this.LeaveTypeName.Name = "LeaveTypeName";
            this.LeaveTypeName.ReadOnly = true;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Actions";
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Width = 125;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.Width = 125;
            // 
            // LeaveTypeLists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Tbl_LeaveTypeLists);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LeaveTypeLists";
            this.Text = "LeaveTypeLists";
            this.panel1.ResumeLayout(false);
            this.PagingContainer.ResumeLayout(false);
            this.PagingContainer.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tbl_LeaveTypeLists)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView Tbl_LeaveTypeLists;
        private System.Windows.Forms.Panel PagingContainer;
        private System.Windows.Forms.Label PageOnPage;
        private System.Windows.Forms.Button Btn_Next;
        private System.Windows.Forms.Button Btn_Prev;
        private System.Windows.Forms.Button Btn_AddLeaveType;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeaveID;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeaveTypeName;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}