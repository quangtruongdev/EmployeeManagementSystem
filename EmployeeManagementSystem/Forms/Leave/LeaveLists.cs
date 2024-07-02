using System.Windows.Forms;

namespace EmployeeManagementSystem.Forms.Leave
{
    public partial class LeaveLists : Form
    {
        public LeaveLists()
        {
            InitializeComponent();
        }

        private void Btn_AddLeave_Click(object sender, System.EventArgs e)
        {
            LeaveForm leaveForm = new LeaveForm();
            leaveForm.ShowDialog();
        }
    }
}
