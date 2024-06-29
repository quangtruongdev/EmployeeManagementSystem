﻿namespace EmployeeManagementSystem.Forms.Dashboard.Summary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SummaryForm));
            this.SummaryContainer = new System.Windows.Forms.Panel();
            this.ProjectsContainer = new System.Windows.Forms.Panel();
            this.Txt_TotalProjects = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CubesIcon = new System.Windows.Forms.PictureBox();
            this.ClientsContainer = new System.Windows.Forms.Panel();
            this.Txt_TotalClients = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.DolarIcon = new System.Windows.Forms.PictureBox();
            this.TasksContainer = new System.Windows.Forms.Panel();
            this.Txt_TotalTaks = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.GemIcon = new System.Windows.Forms.PictureBox();
            this.EmployeesContainer = new System.Windows.Forms.Panel();
            this.Txt_TotalEmployees = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.UserIcon = new System.Windows.Forms.PictureBox();
            this.SummaryContainer.SuspendLayout();
            this.ProjectsContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CubesIcon)).BeginInit();
            this.ClientsContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DolarIcon)).BeginInit();
            this.TasksContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GemIcon)).BeginInit();
            this.EmployeesContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // SummaryContainer
            // 
            this.SummaryContainer.Controls.Add(this.EmployeesContainer);
            this.SummaryContainer.Controls.Add(this.TasksContainer);
            this.SummaryContainer.Controls.Add(this.ClientsContainer);
            this.SummaryContainer.Controls.Add(this.ProjectsContainer);
            this.SummaryContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SummaryContainer.Location = new System.Drawing.Point(0, 0);
            this.SummaryContainer.Name = "SummaryContainer";
            this.SummaryContainer.Size = new System.Drawing.Size(850, 120);
            this.SummaryContainer.TabIndex = 2;
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
            // ClientsContainer
            // 
            this.ClientsContainer.Controls.Add(this.Txt_TotalClients);
            this.ClientsContainer.Controls.Add(this.label10);
            this.ClientsContainer.Controls.Add(this.DolarIcon);
            this.ClientsContainer.Location = new System.Drawing.Point(209, 3);
            this.ClientsContainer.Name = "ClientsContainer";
            this.ClientsContainer.Size = new System.Drawing.Size(200, 100);
            this.ClientsContainer.TabIndex = 4;
            // 
            // Txt_TotalClients
            // 
            this.Txt_TotalClients.AutoSize = true;
            this.Txt_TotalClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_TotalClients.Location = new System.Drawing.Point(117, 25);
            this.Txt_TotalClients.Name = "Txt_TotalClients";
            this.Txt_TotalClients.Size = new System.Drawing.Size(30, 31);
            this.Txt_TotalClients.TabIndex = 2;
            this.Txt_TotalClients.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(125, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 25);
            this.label10.TabIndex = 1;
            this.label10.Text = "Clients";
            // 
            // DolarIcon
            // 
            this.DolarIcon.Image = ((System.Drawing.Image)(resources.GetObject("DolarIcon.Image")));
            this.DolarIcon.Location = new System.Drawing.Point(10, 25);
            this.DolarIcon.Name = "DolarIcon";
            this.DolarIcon.Size = new System.Drawing.Size(50, 50);
            this.DolarIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DolarIcon.TabIndex = 0;
            this.DolarIcon.TabStop = false;
            // 
            // TasksContainer
            // 
            this.TasksContainer.Controls.Add(this.Txt_TotalTaks);
            this.TasksContainer.Controls.Add(this.label11);
            this.TasksContainer.Controls.Add(this.GemIcon);
            this.TasksContainer.Location = new System.Drawing.Point(415, 3);
            this.TasksContainer.Name = "TasksContainer";
            this.TasksContainer.Size = new System.Drawing.Size(200, 100);
            this.TasksContainer.TabIndex = 5;
            // 
            // Txt_TotalTaks
            // 
            this.Txt_TotalTaks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_TotalTaks.AutoSize = true;
            this.Txt_TotalTaks.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_TotalTaks.Location = new System.Drawing.Point(117, 25);
            this.Txt_TotalTaks.Name = "Txt_TotalTaks";
            this.Txt_TotalTaks.Size = new System.Drawing.Size(30, 31);
            this.Txt_TotalTaks.TabIndex = 2;
            this.Txt_TotalTaks.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(131, 75);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 25);
            this.label11.TabIndex = 1;
            this.label11.Text = "Tasks";
            // 
            // GemIcon
            // 
            this.GemIcon.Image = ((System.Drawing.Image)(resources.GetObject("GemIcon.Image")));
            this.GemIcon.Location = new System.Drawing.Point(10, 25);
            this.GemIcon.Name = "GemIcon";
            this.GemIcon.Size = new System.Drawing.Size(50, 50);
            this.GemIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GemIcon.TabIndex = 0;
            this.GemIcon.TabStop = false;
            // 
            // EmployeesContainer
            // 
            this.EmployeesContainer.Controls.Add(this.Txt_TotalEmployees);
            this.EmployeesContainer.Controls.Add(this.label12);
            this.EmployeesContainer.Controls.Add(this.UserIcon);
            this.EmployeesContainer.Location = new System.Drawing.Point(621, 3);
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
            this.ProjectsContainer.ResumeLayout(false);
            this.ProjectsContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CubesIcon)).EndInit();
            this.ClientsContainer.ResumeLayout(false);
            this.ClientsContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DolarIcon)).EndInit();
            this.TasksContainer.ResumeLayout(false);
            this.TasksContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GemIcon)).EndInit();
            this.EmployeesContainer.ResumeLayout(false);
            this.EmployeesContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserIcon)).EndInit();
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
        private System.Windows.Forms.Panel TasksContainer;
        private System.Windows.Forms.Label Txt_TotalTaks;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox GemIcon;
        private System.Windows.Forms.Panel ClientsContainer;
        private System.Windows.Forms.Label Txt_TotalClients;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox DolarIcon;
    }
}