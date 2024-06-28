namespace EmployeeManagementSystem.Views
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.SidebarContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DashboardContainer = new System.Windows.Forms.Panel();
            this.Btn_Dashboard = new System.Windows.Forms.Button();
            this.ProjectsContainer = new System.Windows.Forms.Panel();
            this.Btn_AddProject = new System.Windows.Forms.Button();
            this.Btn_AllProjects = new System.Windows.Forms.Button();
            this.Btn_Projects = new System.Windows.Forms.Button();
            this.EmployeesContainer = new System.Windows.Forms.Panel();
            this.Btn_AddEmployee = new System.Windows.Forms.Button();
            this.Btn_AllEmployees = new System.Windows.Forms.Button();
            this.Btn_Employees = new System.Windows.Forms.Button();
            this.DepartmentContainer = new System.Windows.Forms.Panel();
            this.Btn_Department = new System.Windows.Forms.Button();
            this.PositionsContainer = new System.Windows.Forms.Panel();
            this.Btn_Positions = new System.Windows.Forms.Button();
            this.PayrollContainer = new System.Windows.Forms.Panel();
            this.Btn_Payroll = new System.Windows.Forms.Button();
            this.LeaveManagementContainer = new System.Windows.Forms.Panel();
            this.Btn_LeaveManagement = new System.Windows.Forms.Button();
            this.LogoutContainer = new System.Windows.Forms.Panel();
            this.Btn_Logout = new System.Windows.Forms.Button();
            this.ProjectsTransition = new System.Windows.Forms.Timer(this.components);
            this.EmployeesTransition = new System.Windows.Forms.Timer(this.components);
            this.NavbarContainer = new System.Windows.Forms.Panel();
            this.Btn_Sidebar = new System.Windows.Forms.Button();
            this.SidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.NavbarTransition = new System.Windows.Forms.Timer(this.components);
            this.MainContent = new System.Windows.Forms.Panel();
            this.SidebarContainer.SuspendLayout();
            this.DashboardContainer.SuspendLayout();
            this.ProjectsContainer.SuspendLayout();
            this.EmployeesContainer.SuspendLayout();
            this.DepartmentContainer.SuspendLayout();
            this.PositionsContainer.SuspendLayout();
            this.PayrollContainer.SuspendLayout();
            this.LeaveManagementContainer.SuspendLayout();
            this.LogoutContainer.SuspendLayout();
            this.NavbarContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // SidebarContainer
            // 
            this.SidebarContainer.AutoScroll = true;
            this.SidebarContainer.Controls.Add(this.panel1);
            this.SidebarContainer.Controls.Add(this.DashboardContainer);
            this.SidebarContainer.Controls.Add(this.ProjectsContainer);
            this.SidebarContainer.Controls.Add(this.EmployeesContainer);
            this.SidebarContainer.Controls.Add(this.DepartmentContainer);
            this.SidebarContainer.Controls.Add(this.PositionsContainer);
            this.SidebarContainer.Controls.Add(this.PayrollContainer);
            this.SidebarContainer.Controls.Add(this.LeaveManagementContainer);
            this.SidebarContainer.Controls.Add(this.LogoutContainer);
            this.SidebarContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidebarContainer.Location = new System.Drawing.Point(0, 0);
            this.SidebarContainer.MaximumSize = new System.Drawing.Size(320, 673);
            this.SidebarContainer.MinimumSize = new System.Drawing.Size(70, 673);
            this.SidebarContainer.Name = "SidebarContainer";
            this.SidebarContainer.Size = new System.Drawing.Size(320, 673);
            this.SidebarContainer.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 100);
            this.panel1.TabIndex = 0;
            // 
            // DashboardContainer
            // 
            this.DashboardContainer.Controls.Add(this.Btn_Dashboard);
            this.DashboardContainer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DashboardContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.DashboardContainer.Location = new System.Drawing.Point(3, 109);
            this.DashboardContainer.Name = "DashboardContainer";
            this.DashboardContainer.Size = new System.Drawing.Size(300, 45);
            this.DashboardContainer.TabIndex = 1;
            // 
            // Btn_Dashboard
            // 
            this.Btn_Dashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Dashboard.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Dashboard.Image")));
            this.Btn_Dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Dashboard.Location = new System.Drawing.Point(0, 0);
            this.Btn_Dashboard.Name = "Btn_Dashboard";
            this.Btn_Dashboard.Size = new System.Drawing.Size(300, 45);
            this.Btn_Dashboard.TabIndex = 0;
            this.Btn_Dashboard.Text = "Dashboard";
            this.Btn_Dashboard.UseVisualStyleBackColor = true;
            this.Btn_Dashboard.Click += new System.EventHandler(this.Btn_Dashboard_Click);
            // 
            // ProjectsContainer
            // 
            this.ProjectsContainer.Controls.Add(this.Btn_AddProject);
            this.ProjectsContainer.Controls.Add(this.Btn_AllProjects);
            this.ProjectsContainer.Controls.Add(this.Btn_Projects);
            this.ProjectsContainer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProjectsContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProjectsContainer.Location = new System.Drawing.Point(3, 160);
            this.ProjectsContainer.MaximumSize = new System.Drawing.Size(300, 135);
            this.ProjectsContainer.MinimumSize = new System.Drawing.Size(300, 45);
            this.ProjectsContainer.Name = "ProjectsContainer";
            this.ProjectsContainer.Size = new System.Drawing.Size(300, 45);
            this.ProjectsContainer.TabIndex = 2;
            // 
            // Btn_AddProject
            // 
            this.Btn_AddProject.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_AddProject.Location = new System.Drawing.Point(0, 90);
            this.Btn_AddProject.Name = "Btn_AddProject";
            this.Btn_AddProject.Size = new System.Drawing.Size(300, 45);
            this.Btn_AddProject.TabIndex = 2;
            this.Btn_AddProject.Text = "Add Project";
            this.Btn_AddProject.UseVisualStyleBackColor = true;
            // 
            // Btn_AllProjects
            // 
            this.Btn_AllProjects.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_AllProjects.Location = new System.Drawing.Point(0, 45);
            this.Btn_AllProjects.Name = "Btn_AllProjects";
            this.Btn_AllProjects.Size = new System.Drawing.Size(300, 45);
            this.Btn_AllProjects.TabIndex = 1;
            this.Btn_AllProjects.Text = "All Projects";
            this.Btn_AllProjects.UseVisualStyleBackColor = true;
            // 
            // Btn_Projects
            // 
            this.Btn_Projects.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Projects.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Projects.Image")));
            this.Btn_Projects.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Projects.Location = new System.Drawing.Point(0, 0);
            this.Btn_Projects.Name = "Btn_Projects";
            this.Btn_Projects.Size = new System.Drawing.Size(300, 45);
            this.Btn_Projects.TabIndex = 0;
            this.Btn_Projects.Text = "Projects";
            this.Btn_Projects.UseVisualStyleBackColor = true;
            this.Btn_Projects.Click += new System.EventHandler(this.Btn_Projects_Click);
            // 
            // EmployeesContainer
            // 
            this.EmployeesContainer.Controls.Add(this.Btn_AddEmployee);
            this.EmployeesContainer.Controls.Add(this.Btn_AllEmployees);
            this.EmployeesContainer.Controls.Add(this.Btn_Employees);
            this.EmployeesContainer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EmployeesContainer.Location = new System.Drawing.Point(3, 211);
            this.EmployeesContainer.MaximumSize = new System.Drawing.Size(300, 135);
            this.EmployeesContainer.MinimumSize = new System.Drawing.Size(300, 45);
            this.EmployeesContainer.Name = "EmployeesContainer";
            this.EmployeesContainer.Size = new System.Drawing.Size(300, 45);
            this.EmployeesContainer.TabIndex = 3;
            // 
            // Btn_AddEmployee
            // 
            this.Btn_AddEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_AddEmployee.Location = new System.Drawing.Point(0, 90);
            this.Btn_AddEmployee.Name = "Btn_AddEmployee";
            this.Btn_AddEmployee.Size = new System.Drawing.Size(300, 45);
            this.Btn_AddEmployee.TabIndex = 2;
            this.Btn_AddEmployee.Text = "Add Employee";
            this.Btn_AddEmployee.UseVisualStyleBackColor = true;
            // 
            // Btn_AllEmployees
            // 
            this.Btn_AllEmployees.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_AllEmployees.Location = new System.Drawing.Point(0, 45);
            this.Btn_AllEmployees.Name = "Btn_AllEmployees";
            this.Btn_AllEmployees.Size = new System.Drawing.Size(300, 45);
            this.Btn_AllEmployees.TabIndex = 1;
            this.Btn_AllEmployees.Text = "All Employees";
            this.Btn_AllEmployees.UseVisualStyleBackColor = true;
            // 
            // Btn_Employees
            // 
            this.Btn_Employees.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Employees.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Employees.Image")));
            this.Btn_Employees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Employees.Location = new System.Drawing.Point(0, 0);
            this.Btn_Employees.Name = "Btn_Employees";
            this.Btn_Employees.Size = new System.Drawing.Size(300, 45);
            this.Btn_Employees.TabIndex = 0;
            this.Btn_Employees.Text = "Employees";
            this.Btn_Employees.UseVisualStyleBackColor = true;
            this.Btn_Employees.Click += new System.EventHandler(this.Btn_Employees_Click);
            // 
            // DepartmentContainer
            // 
            this.DepartmentContainer.Controls.Add(this.Btn_Department);
            this.DepartmentContainer.Location = new System.Drawing.Point(3, 262);
            this.DepartmentContainer.Name = "DepartmentContainer";
            this.DepartmentContainer.Size = new System.Drawing.Size(300, 45);
            this.DepartmentContainer.TabIndex = 0;
            // 
            // Btn_Department
            // 
            this.Btn_Department.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Department.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Department.Image")));
            this.Btn_Department.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Department.Location = new System.Drawing.Point(0, 0);
            this.Btn_Department.Name = "Btn_Department";
            this.Btn_Department.Size = new System.Drawing.Size(300, 45);
            this.Btn_Department.TabIndex = 0;
            this.Btn_Department.Text = "Department";
            this.Btn_Department.UseVisualStyleBackColor = true;
            this.Btn_Department.Click += new System.EventHandler(this.Btn_Department_Click);
            // 
            // PositionsContainer
            // 
            this.PositionsContainer.Controls.Add(this.Btn_Positions);
            this.PositionsContainer.Location = new System.Drawing.Point(3, 313);
            this.PositionsContainer.Name = "PositionsContainer";
            this.PositionsContainer.Size = new System.Drawing.Size(300, 45);
            this.PositionsContainer.TabIndex = 6;
            // 
            // Btn_Positions
            // 
            this.Btn_Positions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Positions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Positions.Image")));
            this.Btn_Positions.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Positions.Location = new System.Drawing.Point(0, 0);
            this.Btn_Positions.Name = "Btn_Positions";
            this.Btn_Positions.Size = new System.Drawing.Size(300, 45);
            this.Btn_Positions.TabIndex = 0;
            this.Btn_Positions.Text = "Positions";
            this.Btn_Positions.UseVisualStyleBackColor = true;
            this.Btn_Positions.Click += new System.EventHandler(this.Btn_Positions_Click);
            // 
            // PayrollContainer
            // 
            this.PayrollContainer.Controls.Add(this.Btn_Payroll);
            this.PayrollContainer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PayrollContainer.Location = new System.Drawing.Point(3, 364);
            this.PayrollContainer.MinimumSize = new System.Drawing.Size(300, 45);
            this.PayrollContainer.Name = "PayrollContainer";
            this.PayrollContainer.Size = new System.Drawing.Size(300, 45);
            this.PayrollContainer.TabIndex = 5;
            // 
            // Btn_Payroll
            // 
            this.Btn_Payroll.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Payroll.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Payroll.Image")));
            this.Btn_Payroll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Payroll.Location = new System.Drawing.Point(0, 0);
            this.Btn_Payroll.Name = "Btn_Payroll";
            this.Btn_Payroll.Size = new System.Drawing.Size(300, 45);
            this.Btn_Payroll.TabIndex = 0;
            this.Btn_Payroll.Text = "Payroll";
            this.Btn_Payroll.UseVisualStyleBackColor = true;
            // 
            // LeaveManagementContainer
            // 
            this.LeaveManagementContainer.Controls.Add(this.Btn_LeaveManagement);
            this.LeaveManagementContainer.Location = new System.Drawing.Point(3, 415);
            this.LeaveManagementContainer.Name = "LeaveManagementContainer";
            this.LeaveManagementContainer.Size = new System.Drawing.Size(300, 45);
            this.LeaveManagementContainer.TabIndex = 0;
            // 
            // Btn_LeaveManagement
            // 
            this.Btn_LeaveManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_LeaveManagement.Image = ((System.Drawing.Image)(resources.GetObject("Btn_LeaveManagement.Image")));
            this.Btn_LeaveManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_LeaveManagement.Location = new System.Drawing.Point(0, 0);
            this.Btn_LeaveManagement.Name = "Btn_LeaveManagement";
            this.Btn_LeaveManagement.Size = new System.Drawing.Size(300, 45);
            this.Btn_LeaveManagement.TabIndex = 0;
            this.Btn_LeaveManagement.Text = "Leave Management";
            this.Btn_LeaveManagement.UseVisualStyleBackColor = true;
            // 
            // LogoutContainer
            // 
            this.LogoutContainer.Controls.Add(this.Btn_Logout);
            this.LogoutContainer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoutContainer.Location = new System.Drawing.Point(3, 466);
            this.LogoutContainer.Name = "LogoutContainer";
            this.LogoutContainer.Size = new System.Drawing.Size(300, 45);
            this.LogoutContainer.TabIndex = 4;
            // 
            // Btn_Logout
            // 
            this.Btn_Logout.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Logout.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Logout.Image")));
            this.Btn_Logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Logout.Location = new System.Drawing.Point(0, 0);
            this.Btn_Logout.Name = "Btn_Logout";
            this.Btn_Logout.Size = new System.Drawing.Size(300, 45);
            this.Btn_Logout.TabIndex = 0;
            this.Btn_Logout.Text = "Logout";
            this.Btn_Logout.UseVisualStyleBackColor = true;
            this.Btn_Logout.Click += new System.EventHandler(this.Btn_Logout_Click);
            // 
            // ProjectsTransition
            // 
            this.ProjectsTransition.Interval = 10;
            this.ProjectsTransition.Tick += new System.EventHandler(this.ProjectsTransition_Tick);
            // 
            // EmployeesTransition
            // 
            this.EmployeesTransition.Interval = 10;
            this.EmployeesTransition.Tick += new System.EventHandler(this.EmployeesTransition_Tick);
            // 
            // NavbarContainer
            // 
            this.NavbarContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NavbarContainer.Controls.Add(this.Btn_Sidebar);
            this.NavbarContainer.Location = new System.Drawing.Point(326, 3);
            this.NavbarContainer.MaximumSize = new System.Drawing.Size(990, 100);
            this.NavbarContainer.MinimumSize = new System.Drawing.Size(924, 100);
            this.NavbarContainer.Name = "NavbarContainer";
            this.NavbarContainer.Size = new System.Drawing.Size(924, 100);
            this.NavbarContainer.TabIndex = 1;
            // 
            // Btn_Sidebar
            // 
            this.Btn_Sidebar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Sidebar.Image")));
            this.Btn_Sidebar.Location = new System.Drawing.Point(3, 3);
            this.Btn_Sidebar.Name = "Btn_Sidebar";
            this.Btn_Sidebar.Size = new System.Drawing.Size(50, 50);
            this.Btn_Sidebar.TabIndex = 0;
            this.Btn_Sidebar.UseVisualStyleBackColor = true;
            this.Btn_Sidebar.Click += new System.EventHandler(this.Btn_Sidebar_Click);
            // 
            // SidebarTransition
            // 
            this.SidebarTransition.Interval = 10;
            this.SidebarTransition.Tick += new System.EventHandler(this.SidebarTransition_Tick);
            // 
            // NavbarTransition
            // 
            this.NavbarTransition.Interval = 10;
            this.NavbarTransition.Tick += new System.EventHandler(this.NavbarTransition_Tick);
            // 
            // MainContent
            // 
            this.MainContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainContent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MainContent.Location = new System.Drawing.Point(326, 109);
            this.MainContent.Name = "MainContent";
            this.MainContent.Size = new System.Drawing.Size(924, 564);
            this.MainContent.TabIndex = 2;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.MainContent);
            this.Controls.Add(this.NavbarContainer);
            this.Controls.Add(this.SidebarContainer);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.SidebarContainer.ResumeLayout(false);
            this.DashboardContainer.ResumeLayout(false);
            this.ProjectsContainer.ResumeLayout(false);
            this.EmployeesContainer.ResumeLayout(false);
            this.DepartmentContainer.ResumeLayout(false);
            this.PositionsContainer.ResumeLayout(false);
            this.PayrollContainer.ResumeLayout(false);
            this.LeaveManagementContainer.ResumeLayout(false);
            this.LogoutContainer.ResumeLayout(false);
            this.NavbarContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel SidebarContainer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel DashboardContainer;
        private System.Windows.Forms.Button Btn_Dashboard;
        private System.Windows.Forms.Panel ProjectsContainer;
        private System.Windows.Forms.Button Btn_AddProject;
        private System.Windows.Forms.Button Btn_AllProjects;
        private System.Windows.Forms.Button Btn_Projects;
        private System.Windows.Forms.Panel EmployeesContainer;
        private System.Windows.Forms.Button Btn_AddEmployee;
        private System.Windows.Forms.Button Btn_AllEmployees;
        private System.Windows.Forms.Button Btn_Employees;
        private System.Windows.Forms.Panel LogoutContainer;
        private System.Windows.Forms.Button Btn_Logout;
        private System.Windows.Forms.Timer ProjectsTransition;
        private System.Windows.Forms.Timer EmployeesTransition;
        private System.Windows.Forms.Panel NavbarContainer;
        private System.Windows.Forms.Button Btn_Sidebar;
        private System.Windows.Forms.Panel PayrollContainer;
        private System.Windows.Forms.Button Btn_Payroll;
        private System.Windows.Forms.Timer SidebarTransition;
        private System.Windows.Forms.Timer NavbarTransition;
        private System.Windows.Forms.Panel MainContent;
        private System.Windows.Forms.Panel DepartmentContainer;
        private System.Windows.Forms.Button Btn_Department;
        private System.Windows.Forms.Panel PositionsContainer;
        private System.Windows.Forms.Button Btn_Positions;
        private System.Windows.Forms.Panel LeaveManagementContainer;
        private System.Windows.Forms.Button Btn_LeaveManagement;
    }
}