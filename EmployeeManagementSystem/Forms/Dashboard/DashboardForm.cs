using EmployeeManagementSystem.Forms.Dashboard.Summary;
using EmployeeManagementSystem.Utils;
using System.Windows.Forms;

namespace EmployeeManagementSystem.Forms.Dashboard
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
            SummaryForm summaryForm = new SummaryForm();
            Shared.ShowMainContent(summaryForm, SummaryContainer);
            pictureBox.Image = Properties.Resources.dashboard;
        }
    }
}
