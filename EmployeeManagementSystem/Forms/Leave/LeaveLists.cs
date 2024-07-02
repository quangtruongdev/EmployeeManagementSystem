using EmployeeManagementSystem.Interfaces;
using EmployeeManagementSystem.Services;
using System.Windows.Forms;

namespace EmployeeManagementSystem.Forms.Leave
{
    public partial class LeaveLists : Form
    {
        private readonly ILeaveService _leaveManagement;

        public LeaveLists()
        {
            InitializeComponent();
            _leaveManagement = new LeaveService();
            this.Load += LoadLeaveLists;
        }

        private void LoadLeaveLists(object sender, System.EventArgs e)
        {
            var leaves = _leaveManagement.GetLeaves();
            var leaveTypes = _leaveManagement.GetLeaveTypes();

            Tbl_LeaveLists.Columns.Clear();

            var leaveId = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "LeaveID",
                HeaderText = "Leave Id",
                Name = "LeaveID",
                ReadOnly = true,
            };

            var employeeId = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "EmployeeID",
                HeaderText = "Employee Id",
                Name = "EmployeeID",
                ReadOnly = true,
            };

            var leaveTypeId = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "LeaveTypeID",
                HeaderText = "Leave Type Id",
                Name = "LeaveTypeID",
                ReadOnly = true,
            };

            var startDate = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "StartDate",
                HeaderText = "Start Date",
                Name = "StartDate",
                ReadOnly = true,
            };

            var endDate = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "EndDate",
                HeaderText = "End Date",
                Name = "EndDate",
                ReadOnly = true,
            };

            var status = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Status",
                HeaderText = "Status",
                Name = "Status",
                ReadOnly = true,
            };

            var editButton = new DataGridViewButtonColumn
            {
                HeaderText = "Actions",
                Name = "Btn_Edit",
                Text = "Edit",
                UseColumnTextForButtonValue = true,
                Width = 50,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None
            };

            var deleteButton = new DataGridViewButtonColumn
            {
                HeaderText = "",
                Name = "Btn_Delete",
                Text = "Delete",
                UseColumnTextForButtonValue = true,
                Width = 50,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None
            };

            Tbl_LeaveLists.Columns.Add(leaveId);
            Tbl_LeaveLists.Columns.Add(employeeId);
            Tbl_LeaveLists.Columns.Add(leaveTypeId);
            Tbl_LeaveLists.Columns.Add(startDate);
            Tbl_LeaveLists.Columns.Add(endDate);
            Tbl_LeaveLists.Columns.Add(status);
            Tbl_LeaveLists.Columns.Add(editButton);
            Tbl_LeaveLists.Columns.Add(deleteButton);

            Tbl_LeaveLists.DataSource = leaves;
        }


        private void Btn_AddLeave_Click(object sender, System.EventArgs e)
        {
            LeaveForm leaveForm = new LeaveForm();
            leaveForm.ShowDialog();
        }
    }
}
