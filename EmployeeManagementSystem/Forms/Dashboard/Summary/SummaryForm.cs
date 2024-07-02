using EmployeeManagementSystem.Interfaces;
using EmployeeManagementSystem.Services;
using System.Windows.Forms;

namespace EmployeeManagementSystem.Forms.Dashboard.Summary
{
    public partial class SummaryForm : Form
    {
        private readonly IDashboard _dashboardService;
        public SummaryForm()
        {
            InitializeComponent();
            _dashboardService = new DashboardService();
            this.Load += SummaryForm_Load;
            timer.Start();
        }

        private void SummaryForm_Load(object sender, System.EventArgs e)
        {
            var summary = _dashboardService.GetSummary();
            Txt_TotalProjects.Text = summary.totalProjects.ToString();
            Txt_TotalEmployees.Text = summary.totalEmployees.ToString();
        }

        private void timer_Tick(object sender, System.EventArgs e)
        {
            labelTime.Text = System.DateTime.Now.ToString("HH:mm:ss");
            dayTime.Text = System.DateTime.Now.ToString("dddd, dd MMMM yyyy");
        }
    }
}
