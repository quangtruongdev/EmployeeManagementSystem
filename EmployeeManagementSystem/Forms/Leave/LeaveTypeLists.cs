using EmployeeManagementSystem.Interfaces;
using EmployeeManagementSystem.Services;
using System.Windows.Forms;

namespace EmployeeManagementSystem.Forms.Leave
{
    public partial class LeaveTypeLists : Form
    {
        private readonly ILeaveService _leaveService;
        private int currentPage = 1;
        private int pageSize = 10;

        public LeaveTypeLists()
        {
            InitializeComponent();
            _leaveService = new LeaveService();
            Tbl_LeaveTypeLists.AllowUserToAddRows = false;
            LoadLeaveTypes();
        }

        private void LoadLeaveTypes()
        {
            var res = _leaveService.GetLeaveTypes(currentPage, pageSize);
            var totalPages = res.totalPages;
            var leaveTypes = res.res;

            Tbl_LeaveTypeLists.AutoGenerateColumns = false;
            Tbl_LeaveTypeLists.Columns.Clear();

            var leaveTypeID = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "LeaveTypeID",
                HeaderText = "Leave Type ID",
                Name = "LeaveTypeID",
                ReadOnly = true,
            };

            var leaveTypeName = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "LeaveTypeName",
                HeaderText = "Leave Type Name",
                Name = "LeaveTypeName",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            };

            //var leaveTypeDescription = new DataGridViewTextBoxColumn
            //{
            //    DataPropertyName = "LeaveTypeDescription",
            //    HeaderText = "Leave Type Description",
            //    Name = "LeaveTypeDescription",
            //    ReadOnly = true,
            //    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            //};

            //var leaveTypeDays = new DataGridViewTextBoxColumn
            //{
            //    DataPropertyName = "LeaveTypeDays",
            //    HeaderText = "Leave Type Days",
            //    Name = "LeaveTypeDays",
            //    ReadOnly = true,
            //    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            //};

            var editButton = new DataGridViewButtonColumn
            {
                HeaderText = "Actions",
                Text = "Edit",
                UseColumnTextForButtonValue = true,
                Name = "Edit",
                Width = 50,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
            };

            var deleteButton = new DataGridViewButtonColumn
            {
                HeaderText = "",
                Text = "Delete",
                UseColumnTextForButtonValue = true,
                Name = "Delete",
                Width = 50,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
            };

            Tbl_LeaveTypeLists.Columns.Add(leaveTypeID);
            Tbl_LeaveTypeLists.Columns.Add(leaveTypeName);
            //Tbl_LeaveTypeLists.Columns.Add(leaveTypeDescription);
            //Tbl_LeaveTypeLists.Columns.Add(leaveTypeDays);
            Tbl_LeaveTypeLists.Columns.Add(editButton);
            Tbl_LeaveTypeLists.Columns.Add(deleteButton);

            Tbl_LeaveTypeLists.DataSource = leaveTypes;

            PageOnPage.Text = $"Page {currentPage}/{totalPages}";

            Btn_Next.Enabled = currentPage < totalPages;
            Btn_Prev.Enabled = currentPage > 1;
        }

        private void Tbl_LeaveTypeLists_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var leaveTypeID = Tbl_LeaveTypeLists.Rows[e.RowIndex].Cells["LeaveTypeID"].Value.ToString();
                if (Tbl_LeaveTypeLists.Columns[e.ColumnIndex].Name == "Edit")
                {
                    UpdateLeaveType(leaveTypeID);
                }
                else if (Tbl_LeaveTypeLists.Columns[e.ColumnIndex].Name == "Delete")
                {
                    DeleteLeaveType(leaveTypeID);
                }
            }
        }

        private void Btn_AddLeaveType_Click(object sender, System.EventArgs e)
        {
            LeaveTypeForm leaveTypeForm = new LeaveTypeForm();
            if (leaveTypeForm.ShowDialog() == DialogResult.OK)
            {
                LoadLeaveTypes();
            }
        }

        private void UpdateLeaveType(string leaveTypeID)
        {
            LeaveTypeForm leaveTypeForm = new LeaveTypeForm(leaveTypeID);
            if (leaveTypeForm.ShowDialog() == DialogResult.OK)
            {
                LoadLeaveTypes();
            }
        }

        private void DeleteLeaveType(string leaveTypeID)
        {
            if (MessageBox.Show("Are you sure you want to delete this leave type?", "Delete Leave Type", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _leaveService.DeleteLeaveType(leaveTypeID);
                LoadLeaveTypes();
            }
        }

        private void Btn_Next_Click(object sender, System.EventArgs e)
        {
            currentPage++;
            LoadLeaveTypes();
        }

        private void Btn_Prev_Click(object sender, System.EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadLeaveTypes();
            }
        }
    }
}
