using EmployeeManagementSystem.Interfaces;
using EmployeeManagementSystem.Services;
using EmployeeManagementSystem.Utils;
using System;
using System.Windows.Forms;

namespace EmployeeManagementSystem.Forms.Leave
{
    public partial class LeaveForm : Form
    {
        private readonly IEmployees _employees;
        private readonly ILeaveService _leaveManagement;

        private readonly string _leaveId;

        public LeaveForm(string leaveId = null)
        {
            InitializeComponent();
            _employees = new EmployeesService();
            _leaveManagement = new LeaveService();
            _leaveId = leaveId;
            this.Load += InitializeForm;

            Cbx_AllEmployees.SelectedIndexChanged += (s, e) => ValidateForm();
            Cbx_LeaveType.SelectedIndexChanged += (s, e) => ValidateForm();
            DT_StartDate.ValueChanged += (s, e) => ValidateForm();
            DT_EndDate.ValueChanged += (s, e) => ValidateForm();
            Cbx_Status.SelectedIndexChanged += (s, e) => ValidateForm();
            Txt_Reason.TextChanged += (s, e) => ValidateForm();
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

            if (_leaveId != null)
            {
                this.Text = "Edit Leave";
                LoadLeaveDetails();
            }
            else
            {
                this.Text = "Add Leave";
            }
        }

        private bool ValidateForm()
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

        private void LoadLeaveDetails()
        {
            var leave = _leaveManagement.GetLeaveById(_leaveId);
            Cbx_AllEmployees.SelectedValue = leave.EmployeeID;
            Cbx_LeaveType.SelectedValue = leave.LeaveTypeID;
            DT_StartDate.Value = leave.StartDate.Value;
            DT_EndDate.Value = leave.EndDate.Value;
            Cbx_Status.SelectedItem = leave.Status;
            Txt_Reason.Text = leave.Reason;
        }

        private void Btn_Save_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (ValidateForm())
                {
                    if (!string.IsNullOrEmpty(_leaveId))
                    {
                        var leave = new Models.LeaveManagement
                        {
                            LeaveID = _leaveId,
                            EmployeeID = Cbx_AllEmployees.SelectedValue.ToString(),
                            LeaveTypeID = Cbx_LeaveType.SelectedValue.ToString(),
                            StartDate = DT_StartDate.Value,
                            EndDate = DT_EndDate.Value,
                            Status = Cbx_Status.SelectedItem.ToString(),
                            Reason = Txt_Reason.Text
                        };
                        _leaveManagement.UpdateLeave(leave);
                    }
                    else
                    {
                        var leave = new Models.LeaveManagement
                        {
                            LeaveID = Guid.NewGuid().ToString(),
                            EmployeeID = Cbx_AllEmployees.SelectedValue.ToString(),
                            LeaveTypeID = Cbx_LeaveType.SelectedValue.ToString(),
                            StartDate = DT_StartDate.Value,
                            EndDate = DT_EndDate.Value,
                            Status = Cbx_Status.SelectedItem.ToString(),
                            Reason = Txt_Reason.Text
                        };
                        _leaveManagement.AddLeave(leave);
                    }
                    Shared.ShowToastr("Success", "Leave saved successfully");
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Shared.ShowToastr("Error", ex.Message);
            }
        }

        private void Btn_Close_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }

}
