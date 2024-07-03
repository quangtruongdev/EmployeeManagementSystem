using EmployeeManagementSystem.Interfaces;
using EmployeeManagementSystem.Services;
using EmployeeManagementSystem.Utils;
using System;
using System.Windows.Forms;

namespace EmployeeManagementSystem.Forms.Leave
{
    public partial class LeaveTypeForm : Form
    {
        private readonly ILeaveService _leaveService;
        private readonly string _leaveTypeID;

        public LeaveTypeForm(string leaveTypeID = null)
        {
            InitializeComponent();
            _leaveService = new LeaveService();
            _leaveTypeID = leaveTypeID;
            this.Load += InitializeForm;

            // Add TextChanged event handlers for real-time validation
            Txt_LeaveTypeName.TextChanged += (s, e) => ValidateForm();
            //Txt_LeaveTypeDescription.TextChanged += (s, e) => ValidateForm();
            //Txt_LeaveTypeDays.TextChanged += (s, e) => ValidateForm();
        }

        private void InitializeForm(object sender, EventArgs e)
        {
            if (_leaveTypeID != null)
            {
                this.Text = "Edit Leave Type";
                LoadLeaveTypeDetails();
            }
            else
            {
                this.Text = "Add Leave Type";
            }
        }

        private void LoadLeaveTypeDetails()
        {
            var leaveType = _leaveService.GetLeaveTypeById(_leaveTypeID);
            Txt_LeaveTypeName.Text = leaveType.LeaveTypeName;
            //Txt_LeaveTypeDescription.Text = leaveType.LeaveTypeDescription;
            //Txt_LeaveTypeDays.Text = leaveType.LeaveTypeDays.ToString();
        }

        private bool ValidateForm()
        {
            bool isValid = true;

            if (string.IsNullOrEmpty(Txt_LeaveTypeName.Text))
            {
                ErrorLeaveName.Text = "Please enter leave type name";
                isValid = false;
            }
            else
            {
                ErrorLeaveName.Text = "";
            }

            //if (string.IsNullOrEmpty(Txt_LeaveTypeDescription.Text))
            //{
            //    ErrorDescription.Text = "Please enter leave type description";
            //    isValid = false;
            //}
            //else
            //{
            //    ErrorDescription.Text = "";
            //}

            //if (string.IsNullOrEmpty(Txt_LeaveTypeDays.Text))
            //{
            //    ErrorDays.Text = "Please enter leave type days";
            //    isValid = false;
            //}
            //else if (!int.TryParse(Txt_LeaveTypeDays.Text, out _))
            //{
            //    ErrorDays.Text = "Please enter a valid number";
            //    isValid = false;
            //}
            //else
            //{
            //    ErrorDays.Text = "";
            //}

            Btn_Submit.Enabled = isValid;
            return isValid;
        }

        private void Btn_Submit_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateForm())
                {
                    if (_leaveTypeID != null)
                    {
                        var leaveType = _leaveService.GetLeaveTypeById(_leaveTypeID);
                        leaveType.LeaveTypeName = Txt_LeaveTypeName.Text;
                        //leaveType.LeaveTypeDescription = Txt_LeaveTypeDescription.Text;
                        //leaveType.LeaveTypeDays = int.Parse(Txt_LeaveTypeDays.Text);
                        _leaveService.UpdateLeaveType(leaveType);
                    }
                    else
                    {
                        var leaveType = new Models.LeaveType
                        {
                            LeaveTypeName = Txt_LeaveTypeName.Text,
                            //LeaveTypeDescription = Txt_LeaveTypeDescription.Text,
                            //LeaveTypeDays = int.Parse(Txt_LeaveTypeDays.Text)
                        };
                        _leaveService.AddLeaveType(leaveType);
                    }
                    Shared.ShowToastr("Success", "Leave type saved successfully");
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
