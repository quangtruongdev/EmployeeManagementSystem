using EmployeeManagementSystem.Interfaces;
using EmployeeManagementSystem.Services;
using System.Windows.Forms;

namespace EmployeeManagementSystem.Forms.Leave
{
    public partial class LeaveForm : Form
    {
        private readonly IEmployees _employees;

        public LeaveForm()
        {
            InitializeComponent();
            _employees = new EmployeesService();
            this.Load += InitializeForm;
        }

        private void InitializeForm(object sender, System.EventArgs e)
        {
            var employees = _employees.GetEmployees();
            Cbx_AllEmployees.DataSource = employees;
            Cbx_AllEmployees.DisplayMember = "FirstName";
            Cbx_AllEmployees.ValueMember = "EmployeeID";

            //var leaveTypes = _employees.GetLeaveTypes();
            //Cbx_LeaveType.DataSource = leaveTypes;
            //Cbx_LeaveType.DisplayMember = "LeaveTypeName";
            //Cbx_LeaveType.ValueMember = "LeaveTypeID";

            // set values for status combobox "Pending", "Approved", "Rejected"
            Cbx_Status.Items.Add("Pending");
            Cbx_Status.Items.Add("Approved");
            Cbx_Status.Items.Add("Rejected");
        }

        private void Btn_Close_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void Btn_Save_Click(object sender, System.EventArgs e)
        {

        }
    }
}
