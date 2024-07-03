namespace EmployeeManagementSystem.Forms.Dashboard.Summary
{
    partial class SummaryForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SummaryForm));
            this.SummaryContainer = new System.Windows.Forms.Panel();
            this.clockPanel = new System.Windows.Forms.Panel();
            this.EmployeesContainer = new System.Windows.Forms.Panel();
            this.Txt_TotalEmployees = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.UserIcon = new System.Windows.Forms.PictureBox();
            this.ProjectsContainer = new System.Windows.Forms.Panel();
            this.Txt_TotalProjects = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CubesIcon = new System.Windows.Forms.PictureBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.dayTime = new System.Windows.Forms.Label();
            this.SummaryContainer.SuspendLayout();
            this.clockPanel.SuspendLayout();
            this.EmployeesContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserIcon)).BeginInit();
            this.ProjectsContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CubesIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // SummaryContainer
            // 
            this.SummaryContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SummaryContainer.Controls.Add(this.clockPanel);
            this.SummaryContainer.Controls.Add(this.EmployeesContainer);
            this.SummaryContainer.Controls.Add(this.ProjectsContainer);
            this.SummaryContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SummaryContainer.Location = new System.Drawing.Point(0, 0);
            this.SummaryContainer.Name = "SummaryContainer";
            this.SummaryContainer.Size = new System.Drawing.Size(850, 120);
            this.SummaryContainer.TabIndex = 2;
            // 
            // clockPanel
            // 
            this.clockPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clockPanel.Controls.Add(this.dayTime);
            this.clockPanel.Controls.Add(this.labelTime);
            this.clockPanel.Location = new System.Drawing.Point(415, 3);
            this.clockPanel.Name = "clockPanel";
            this.clockPanel.Size = new System.Drawing.Size(423, 100);
            this.clockPanel.TabIndex = 7;
            // 
            // EmployeesContainer
            // 
            this.EmployeesContainer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.EmployeesContainer.Controls.Add(this.Txt_TotalEmployees);
            this.EmployeesContainer.Controls.Add(this.label12);
            this.EmployeesContainer.Controls.Add(this.UserIcon);
            this.EmployeesContainer.Location = new System.Drawing.Point(209, 3);
            this.EmployeesContainer.Name = "EmployeesContainer";
            this.EmployeesContainer.Size = new System.Drawing.Size(200, 100);
            this.EmployeesContainer.TabIndex = 6;
            // 
            // Txt_TotalEmployees
            // 
            this.Txt_TotalEmployees.AutoSize = true;
            this.Txt_TotalEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_TotalEmployees.Location = new System.Drawing.Point(117, 25);
            this.Txt_TotalEmployees.Name = "Txt_TotalEmployees";
            this.Txt_TotalEmployees.Size = new System.Drawing.Size(30, 31);
            this.Txt_TotalEmployees.TabIndex = 2;
            this.Txt_TotalEmployees.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(88, 75);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(109, 25);
            this.label12.TabIndex = 1;
            this.label12.Text = "Employees";
            // 
            // UserIcon
            // 
            this.UserIcon.Image = ((System.Drawing.Image)(resources.GetObject("UserIcon.Image")));
            this.UserIcon.Location = new System.Drawing.Point(10, 25);
            this.UserIcon.Name = "UserIcon";
            this.UserIcon.Size = new System.Drawing.Size(50, 50);
            this.UserIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UserIcon.TabIndex = 0;
            this.UserIcon.TabStop = false;
            // 
            // ProjectsContainer
            // 
            this.ProjectsContainer.Controls.Add(this.Txt_TotalProjects);
            this.ProjectsContainer.Controls.Add(this.label1);
            this.ProjectsContainer.Controls.Add(this.CubesIcon);
            this.ProjectsContainer.Location = new System.Drawing.Point(3, 3);
            this.ProjectsContainer.Name = "ProjectsContainer";
            this.ProjectsContainer.Size = new System.Drawing.Size(200, 100);
            this.ProjectsContainer.TabIndex = 1;
            // 
            // Txt_TotalProjects
            // 
            this.Txt_TotalProjects.AutoSize = true;
            this.Txt_TotalProjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_TotalProjects.Location = new System.Drawing.Point(117, 25);
            this.Txt_TotalProjects.Name = "Txt_TotalProjects";
            this.Txt_TotalProjects.Size = new System.Drawing.Size(30, 31);
            this.Txt_TotalProjects.TabIndex = 2;
            this.Txt_TotalProjects.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Projects";
            // 
            // CubesIcon
            // 
            this.CubesIcon.Image = ((System.Drawing.Image)(resources.GetObject("CubesIcon.Image")));
            this.CubesIcon.Location = new System.Drawing.Point(10, 25);
            this.CubesIcon.Name = "CubesIcon";
            this.CubesIcon.Size = new System.Drawing.Size(50, 50);
            this.CubesIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CubesIcon.TabIndex = 0;
            this.CubesIcon.TabStop = false;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("MS PGothic", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.Location = new System.Drawing.Point(119, 6);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(192, 47);
            this.labelTime.TabIndex = 0;
            this.labelTime.Text = "00:00:00";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // dayTime
            // 
            this.dayTime.AutoSize = true;
            this.dayTime.Font = new System.Drawing.Font("MS PGothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayTime.Location = new System.Drawing.Point(124, 75);
            this.dayTime.Name = "dayTime";
            this.dayTime.Size = new System.Drawing.Size(28, 17);
            this.dayTime.TabIndex = 0;
            this.dayTime.Text = "00";
            // 
            // SummaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 120);
            this.Controls.Add(this.SummaryContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SummaryForm";
            this.Text = "SummaryForm";
            this.SummaryContainer.ResumeLayout(false);
            this.clockPanel.ResumeLayout(false);
            this.clockPanel.PerformLayout();
            this.EmployeesContainer.ResumeLayout(false);
            this.EmployeesContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserIcon)).EndInit();
            this.ProjectsContainer.ResumeLayout(false);
            this.ProjectsContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CubesIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel SummaryContainer;
        private System.Windows.Forms.Panel ProjectsContainer;
        private System.Windows.Forms.Label Txt_TotalProjects;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox CubesIcon;
        private System.Windows.Forms.Panel EmployeesContainer;
        private System.Windows.Forms.Label Txt_TotalEmployees;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox UserIcon;
        private System.Windows.Forms.Panel clockPanel;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label dayTime;
    }
}