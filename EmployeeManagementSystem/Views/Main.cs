using EmployeeManagementSystem.Forms.Dashboard;
using EmployeeManagementSystem.Forms.Department;
using EmployeeManagementSystem.Forms.Login;
using EmployeeManagementSystem.Forms.Positons;
using EmployeeManagementSystem.Interfaces;
using EmployeeManagementSystem.Services;
using EmployeeManagementSystem.Utils;
using System;
using System.Windows.Forms;

namespace EmployeeManagementSystem.Views
{
    public partial class Main : Form
    {
        private IAuth _authService;
        private bool projectsCollapsed = true;
        private bool employeesCollapsed = true;
        private bool sidebarCollapsed = true;
        private bool navbarCollapsed = true;

        public Main()
        {
            InitializeComponent();
            InitializeTimers();
            _authService = new AuthService();
            //this.Load += new EventHandler(Main_Load);
        }

        private bool CheckUserLogin()
        {
            var user = _authService.GetUserAccount(Session.Username);
            return user != null;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (!CheckUserLogin())
            {
                this.Hide(); // Ẩn form Main
                LoginForm login = new LoginForm();
                if (login.ShowDialog() != DialogResult.OK)
                {
                    this.Close(); // Đóng form Main nếu người dùng không đăng nhập
                }
                else
                {
                    this.Show(); // Hiển thị lại form Main nếu người dùng đăng nhập thành công
                }
            }
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
            DashboardForm dashboard = new DashboardForm();
            Shared.ShowMainContent(dashboard, MainContent);
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

        private void Btn_Logout_Click(object sender, EventArgs e)
        {
            Session.Clear();
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void Btn_Positions_Click(object sender, EventArgs e)
        {
            PositonsList positonsList = new PositonsList();
            Shared.ShowMainContent(positonsList, MainContent);
        }
    }
}
