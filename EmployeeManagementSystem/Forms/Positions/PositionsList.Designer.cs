namespace EmployeeManagementSystem.Forms.Positons
{
    partial class PositionsList
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_AddPositon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PagingContainer = new System.Windows.Forms.Panel();
            this.PageOnPage = new System.Windows.Forms.Label();
            this.Btn_Next = new System.Windows.Forms.Button();
            this.Btn_Pre = new System.Windows.Forms.Button();
            this.Tbl_Positions = new System.Windows.Forms.DataGridView();
            this.col_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PositonName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Btn_Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.PagingContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tbl_Positions)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Btn_AddPositon);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1147, 60);
            this.panel1.TabIndex = 4;
            // 
            // Btn_AddPositon
            // 
            this.Btn_AddPositon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_AddPositon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_AddPositon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_AddPositon.Location = new System.Drawing.Point(935, 5);
            this.Btn_AddPositon.Name = "Btn_AddPositon";
            this.Btn_AddPositon.Size = new System.Drawing.Size(200, 45);
            this.Btn_AddPositon.TabIndex = 1;
            this.Btn_AddPositon.Text = "Add Position";
            this.Btn_AddPositon.UseVisualStyleBackColor = true;
            this.Btn_AddPositon.Click += new System.EventHandler(this.Btn_AddPosition_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Positons";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.PagingContainer);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 486);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1147, 100);
            this.panel2.TabIndex = 5;
            // 
            // PagingContainer
            // 
            this.PagingContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PagingContainer.Controls.Add(this.PageOnPage);
            this.PagingContainer.Controls.Add(this.Btn_Next);
            this.PagingContainer.Controls.Add(this.Btn_Pre);
            this.PagingContainer.Location = new System.Drawing.Point(906, 6);
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
            // Tbl_Positions
            // 
            this.Tbl_Positions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tbl_Positions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_id,
            this.PositonName,
            this.Btn_Edit,
            this.Btn_Delete});
            this.Tbl_Positions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tbl_Positions.Location = new System.Drawing.Point(0, 60);
            this.Tbl_Positions.Name = "Tbl_Positions";
            this.Tbl_Positions.RowHeadersWidth = 51;
            this.Tbl_Positions.RowTemplate.Height = 24;
            this.Tbl_Positions.Size = new System.Drawing.Size(1147, 426);
            this.Tbl_Positions.TabIndex = 6;
            this.Tbl_Positions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Tbl_Positions_CellContentClick);
            // 
            // col_id
            // 
            this.col_id.DataPropertyName = "PositionID";
            this.col_id.HeaderText = "PositionID";
            this.col_id.MinimumWidth = 6;
            this.col_id.Name = "col_id";
            this.col_id.Width = 125;
            // 
            // PositonName
            // 
            this.PositonName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PositonName.DataPropertyName = "PositionName";
            this.PositonName.HeaderText = "Positon Name";
            this.PositonName.MinimumWidth = 6;
            this.PositonName.Name = "PositonName";
            // 
            // Btn_Edit
            // 
            this.Btn_Edit.HeaderText = "Actions";
            this.Btn_Edit.MinimumWidth = 6;
            this.Btn_Edit.Name = "Btn_Edit";
            this.Btn_Edit.Text = "Edit";
            this.Btn_Edit.UseColumnTextForButtonValue = true;
            this.Btn_Edit.Width = 50;
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.HeaderText = "";
            this.Btn_Delete.MinimumWidth = 6;
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Text = "Delete";
            this.Btn_Delete.UseColumnTextForButtonValue = true;
            this.Btn_Delete.Width = 50;
            // 
            // PositionsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 586);
            this.Controls.Add(this.Tbl_Positions);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PositionsList";
            this.Text = "PositonsList";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.PagingContainer.ResumeLayout(false);
            this.PagingContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tbl_Positions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_AddPositon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel PagingContainer;
        private System.Windows.Forms.Label PageOnPage;
        private System.Windows.Forms.Button Btn_Next;
        private System.Windows.Forms.Button Btn_Pre;
        private System.Windows.Forms.DataGridView Tbl_Positions;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn PositonName;
        private System.Windows.Forms.DataGridViewButtonColumn Btn_Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Btn_Delete;
    }
}