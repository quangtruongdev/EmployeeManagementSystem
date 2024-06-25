using EmployeeManagementSystem.Forms.Department;
using System;
using System.Windows.Forms;

namespace EmployeeManagementSystem.Views
{
    public partial class Main : Form
    {
        private bool projectsCollapsed = true;
        private bool employeesCollapsed = true;
        private bool sidebarCollapsed = true;
        private bool navbarCollapsed = true;

        public Main()
        {
            InitializeComponent();
            InitializeTimers();
        }

        private void InitializeTimers()
        {
            ProjectsTransition.Tick += ProjectsTransition_Tick;
            EmployeesTransition.Tick += EmployeesTransition_Tick;
            SidebarTransition.Tick += SidebarTransition_Tick;
            NavbarTransition.Tick += NavbarTransition_Tick;
        }

        private void HandleTransition(Timer timer, Control container, ref bool collapsed, int stepSize, bool isVertical)
        {
            if (collapsed)
            {
                if (isVertical)
                {
                    container.Height += stepSize;
                    if (container.Height >= container.MaximumSize.Height)
                    {
                        timer.Stop();
                        collapsed = false;
                    }
                }
                else
                {
                    container.Width += stepSize;
                    if (container.Width >= container.MaximumSize.Width)
                    {
                        timer.Stop();
                        collapsed = false;
                    }
                }
            }
            else
            {
                if (isVertical)
                {
                    container.Height -= stepSize;
                    if (container.Height <= container.MinimumSize.Height)
                    {
                        timer.Stop();
                        collapsed = true;
                    }
                }
                else
                {
                    container.Width -= stepSize;
                    if (container.Width <= container.MinimumSize.Width)
                    {
                        timer.Stop();
                        collapsed = true;
                    }
                }
            }
        }

        private void ProjectsTransition_Tick(object sender, EventArgs e)
        {
            HandleTransition(ProjectsTransition, ProjectsContainer, ref projectsCollapsed, 10, true);
        }

        private void Btn_Projects_Click(object sender, EventArgs e)
        {
            ProjectsTransition.Start();
            EnsureSidebarOpen();
        }

        private void EmployeesTransition_Tick(object sender, EventArgs e)
        {
            HandleTransition(EmployeesTransition, EmployeesContainer, ref employeesCollapsed, 10, true);
        }

        private void Btn_Employees_Click(object sender, EventArgs e)
        {
            EmployeesTransition.Start();
            EnsureSidebarOpen();
        }

        private void SidebarTransition_Tick(object sender, EventArgs e)
        {
            HandleTransition(SidebarTransition, SidebarContainer, ref sidebarCollapsed, 10, false);
        }

        private void NavbarTransition_Tick(object sender, EventArgs e)
        {
            HandleTransition(NavbarTransition, NavbarContainer, ref navbarCollapsed, 10, true);
        }

        private void Btn_Sidebar_Click(object sender, EventArgs e)
        {
            //SidebarTransition.Start();
            //NavbarTransition.Start();
        }

        private void Btn_Dashboard_Click(object sender, EventArgs e)
        {
            // Handle dashboard button click
        }

        private void Btn_Logout_Click(object sender, EventArgs e)
        {
            // Handle logout button click
        }

        private void EnsureSidebarOpen()
        {
            if (sidebarCollapsed)
            {
                SidebarTransition.Start();
            }
        }

        private void Btn_Department_Click(object sender, EventArgs e)
        {
            Department department = new Department();
            department.TopLevel = false;
            department.Dock = DockStyle.Fill;
            MainContent.Controls.Clear();
            MainContent.Controls.Add(department);
            department.Show();
        }
    }
}
