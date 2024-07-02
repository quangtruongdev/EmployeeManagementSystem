using EmployeeManagementSystem.Interfaces;
using EmployeeManagementSystem.Services;
using EmployeeManagementSystem.Utils;
using System.Windows.Forms;

namespace EmployeeManagementSystem.Forms.Leave
{
    public partial class LeaveForm : Form
    {
        private readonly IEmployees _employees;
        private readonly ILeaveService _leaveManagement;

        public LeaveForm()
        {
            InitializeComponent();
            _employees = new EmployeesService();
            _leaveManagement = new LeaveService();
            this.Load += InitializeForm;
        }

        private void InitializeForm(object sender, System.EventArgs e)
        {
            var employees = _employees.GetEmployees();
            Cbx_AllEmployees.DataSource = employees;
            Cbx_AllEmployees.DisplayMember = "FirstName";
            Cbx_AllEmployees.ValueMember = "EmployeeID";

            var leaveTypes = _leaveManagement.GetLeaveTypes();
            Cbx_LeaveType.DataSource = leaveTypes;
            Cbx_LeaveType.DisplayMember = "LeaveTypeName";
            Cbx_LeaveType.ValueMember = "LeaveTypeID";

            // set values for status combobox "Pending", "Approved", "Rejected"
            Cbx_Status.Items.Add("Pending");
            Cbx_Status.Items.Add("Approved");
            Cbx_Status.Items.Add("Rejected");
        }

        private bool ValidForm()
        {
            bool isValid = true;
            if (Cbx_AllEmployees.SelectedIndex == -1)
            {
                ErrorName.Text = "Please select an employee";
                isValid = false;
            }
            else
            {
                ErrorName.Text = "";
            }

            if (Cbx_LeaveType.SelectedIndex == -1)
            {
                ErrorLeaveType.Text = "Please select a leave type";
                isValid = false;
            }
            else
            {
                ErrorLeaveType.Text = "";
            }

            if (DT_EndDate.Value.Date < DT_StartDate.Value.Date)
            {
                ErrorDate.Text = "End date must be greater than start date";
                isValid = false;
            }
            else
            {
                ErrorDate.Text = "";
            }

            if (Cbx_Status.SelectedIndex == -1)
            {
                ErrorStatus.Text = "Please select a status";
                isValid = false;
            }
            else
            {
                ErrorStatus.Text = "";
            }

            Btn_Save.Enabled = isValid;
            return isValid;
        }

        private void Btn_Save_Click(object sender, System.EventArgs e)
        {

            if (ValidForm())
            {
                var leave = new Models.LeaveManagement
                {
                    EmployeeID = (string)Cbx_AllEmployees.SelectedValue,
                    //LeaveTypeID = (string)Cbx_LeaveType.SelectedValue,
                    StartDate = DT_StartDate.Value,
                    EndDate = DT_EndDate.Value,
                    Status = Cbx_Status.Text,
                    //Reason = Txt_Reason.Text,
                    //Note = Txt_Note.Text
                    //CreatedDate = DateTime.Now
                };

                _leaveManagement.AddLeave(leave);
                //MessageBox.Show("Leave added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Shared.ShowToastr("Success", "Leave added successfully");
                Close();
            }
        }

        private void Btn_Close_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
