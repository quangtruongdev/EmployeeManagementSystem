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

        private void Btn_Payroll_Click(object sender, EventArgs e)
        {
            Salary salary = new Salary();
            Shared.ShowMainContent(salary, MainContent);
        }

        private void Btn_Departments_Click(object sender, EventArgs e)
        {
            Department department = new Department();
            Shared.ShowMainContent(department, MainContent);
        }

        private void Btn_Positions_Click(object sender, EventArgs e)
        {
            PositonsList positonsList = new PositonsList();
            Shared.ShowMainContent(positonsList, MainContent);
        }

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

        private void Btn_LeaveManagement_Click(object sender, EventArgs e)
        {
            LeaveLists leaveLists = new LeaveLists();
            Shared.ShowMainContent(leaveLists, MainContent);
        }
    }
}
