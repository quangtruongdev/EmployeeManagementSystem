using EmployeeManagementSystem.Forms.Dashboard;
using EmployeeManagementSystem.Forms.Department;
using EmployeeManagementSystem.Forms.Employees;
using EmployeeManagementSystem.Forms.Leave;
using EmployeeManagementSystem.Forms.Login;
using EmployeeManagementSystem.Forms.Positons;
using EmployeeManagementSystem.Forms.Project;
using EmployeeManagementSystem.Utils;
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
        private bool leaveManagementCollapsed = true;

        public Main()
        {
            InitializeComponent();
            InitializeTimers();
            this.Load += Main_Load;
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

        private void EmployeesTransition_Tick(object sender, EventArgs e)
        {
            HandleTransition(EmployeesTransition, EmployeesContainer, ref employeesCollapsed, 10, true);
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

        private void LeaveManagementTransition_Tick(object sender, EventArgs e)
        {
            HandleTransition(LeaveManagementTransition, LeaveManagementContainer, ref leaveManagementCollapsed, 10, true);
        }

        private void EnsureSidebarOpen()
        {
            if (sidebarCollapsed)
            {
                SidebarTransition.Start();
            }
        }

        #region Dashboard
        private void Btn_Dashboard_Click(object sender, EventArgs e)
        {
            DashboardForm dashboard = new DashboardForm();
            Shared.ShowMainContent(dashboard, MainContent);
        }
        #endregion


        #region Project Management

        private void Btn_Projects_Click(object sender, EventArgs e)
        {
            ProjectsTransition.Start();
            EnsureSidebarOpen();
        }

        private void Btn_AllProjects_Click(object sender, EventArgs e)
        {
            Project projectLists = new Project();
            Shared.ShowMainContent(projectLists, MainContent);
        }

        private void Btn_AddProject_Click(object sender, EventArgs e)
        {
            AddProject addProject = new AddProject(null, false);
            addProject.FormBorderStyle = FormBorderStyle.None;
            Shared.ShowMainContent(addProject, MainContent);
        }

        #endregion

        #region Employee Management

        private void Btn_Employees_Click(object sender, EventArgs e)
        {
            EmployeesTransition.Start();
            EnsureSidebarOpen();
        }

        public void Btn_AllEmployees_Click(object sender, EventArgs e)
        {
            MainContent.Controls.Clear();
            EmployeeLists employee = new EmployeeLists();
            employee.TopLevel = false;
            employee.Dock = DockStyle.Fill;
            MainContent.Controls.Add(employee);
            employee.Show();
        }

        private void Btn_AddEmployee_Click(object sender, EventArgs e)
        {
            MainContent.Controls.Clear();
            EmployeeForm employee = new EmployeeForm();
            employee.TopLevel = false;
            employee.FormBorderStyle = FormBorderStyle.None;
            employee.Dock = DockStyle.Fill;
            MainContent.Controls.Add(employee);
            employee.Show();
        }

        #endregion

        #region Department Management
        private void Btn_Departments_Click(object sender, EventArgs e)
        {
            DepartmentLists department = new DepartmentLists();
            Shared.ShowMainContent(department, MainContent);
        }
        #endregion

        #region Position Management
        private void Btn_Positions_Click(object sender, EventArgs e)
        {
            PositionsList positonsList = new PositionsList();
            Shared.ShowMainContent(positonsList, MainContent);
        }
        #endregion

        private void Btn_Payroll_Click(object sender, EventArgs e)
        {
            EmployeeManagementSystem.Forms.Salary.Salary salary = new EmployeeManagementSystem.Forms.Salary.Salary();
            Shared.ShowMainContent(salary, MainContent);
        }

        #region Leave Management
        private void Btn_LeaveManagement_Click(object sender, EventArgs e)
        {
            LeaveManagementTransition.Start();
            EnsureSidebarOpen();
        }

        private void Btn_AllLeaveRequests_Click(object sender, EventArgs e)
        {
            LeaveLists leaveLists = new LeaveLists();
            Shared.ShowMainContent(leaveLists, MainContent);
        }

        private void Btn_LeaveType_Click(object sender, EventArgs e)
        {
            LeaveTypeLists leaveType = new LeaveTypeLists();
            Shared.ShowMainContent(leaveType, MainContent);
        }
        #endregion

        private void Btn_Logout_Click(object sender, EventArgs e)
        {
            SessionManager.ClearSession(); // Xóa thông tin phiên người dùng

            // Hiển thị form đăng nhập
            LoginForm login = new LoginForm();
            login.FormClosed += LoginForm_FormClosed; // Đăng ký sự kiện FormClosed để theo dõi khi form đăng nhập đóng lại
            login.Show();

            // Ẩn form chính
            this.Hide();
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Xử lý khi form đăng nhập đóng lại
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit(); // Đóng chương trình
            }
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        // set dashboard as default view
        private void Main_Load(object sender, EventArgs e)
        {
            DashboardForm dashboard = new DashboardForm();
            Shared.ShowMainContent(dashboard, MainContent);
        }
    }
}