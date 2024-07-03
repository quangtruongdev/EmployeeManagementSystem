using EmployeeManagementSystem.Interfaces;
using EmployeeManagementSystem.Services;
using System.Windows.Forms;

namespace EmployeeManagementSystem.Forms.Leave
{
    public partial class LeaveLists : Form
    {
        private readonly ILeaveService _leaveManagement;
        private readonly IEmployees _employeeService;

        private int currentPage = 1;
        private int pageSize = 10;

        public LeaveLists()
        {
            InitializeComponent();
            _leaveManagement = new LeaveService();
            LoadLeaveLists();
        }

        private void LoadLeaveLists()
        {
            var res = _leaveManagement.GetLeaves(currentPage, pageSize);
            var leaves = res.res;
            var totalPage = res.totalPages;

            Tbl_LeaveLists.Columns.Clear();

            var leaveId = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "LeaveID",
                HeaderText = "Leave Id",
                Name = "LeaveID",
                ReadOnly = true,
            };

            var employeeName = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "FirstName",
                HeaderText = "Employee Name",
                Name = "FirstName",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            };

            var leaveTypeName = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "LeaveTypeName",
                HeaderText = "Leave Type",
                Name = "LeaveTypeName",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
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

            var reason = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Reason",
                HeaderText = "Reason",
                Name = "Reason",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
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
            Tbl_LeaveLists.Columns.Add(employeeName);
            Tbl_LeaveLists.Columns.Add(leaveTypeName);
            Tbl_LeaveLists.Columns.Add(startDate);
            Tbl_LeaveLists.Columns.Add(endDate);
            Tbl_LeaveLists.Columns.Add(status);
            Tbl_LeaveLists.Columns.Add(reason);
            Tbl_LeaveLists.Columns.Add(editButton);
            Tbl_LeaveLists.Columns.Add(deleteButton);

            Tbl_LeaveLists.AutoGenerateColumns = false;

            Tbl_LeaveLists.DataSource = leaves;

            PageOnPage.Text = $"Page {currentPage}/{totalPage}";

            Btn_Next.Enabled = currentPage < totalPage;
            Btn_Prev.Enabled = currentPage > 1;
        }

        private void Btn_AddLeave_Click(object sender, System.EventArgs e)
        {
            LeaveForm leaveForm = new LeaveForm();
            leaveForm.ShowDialog();
        }

        private void Tbl_LeaveLists_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string leaveId = Tbl_LeaveLists.Rows[e.RowIndex].Cells["LeaveID"].Value.ToString();

                if (Tbl_LeaveLists.Columns[e.ColumnIndex].Name == "Btn_Edit")
                {
                    EditLeaveForm(leaveId);
                }
                else if (Tbl_LeaveLists.Columns[e.ColumnIndex].Name == "Btn_Delete")
                {
                    DeleteLeave(leaveId);
                }
            }
        }

        private void EditLeaveForm(string leaveId)
        {
            LeaveForm leaveForm = new LeaveForm(leaveId);
            if (leaveForm.ShowDialog() == DialogResult.OK)
            {
                LoadLeaveLists();
            }
        }

        private void DeleteLeave(string leaveId)
        {
            var dialogResult = MessageBox.Show("Are you sure you want to delete this leave?", "Delete Leave", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                _leaveManagement.DeleteLeave(leaveId);
                LoadLeaveLists();
            }
        }

        private void Btn_Next_Click(object sender, System.EventArgs e)
        {
            currentPage++;
            LoadLeaveLists();
        }

        private void Btn_Prev_Click(object sender, System.EventArgs e)
        {
            if (currentPage > 0)
            {
                currentPage--;
                LoadLeaveLists();
            }
        }

        private void Btn_Search_Click(object sender, System.EventArgs e)
        {
            var name = Txt_Search.Text;
            if (name == "")
            {
                LoadLeaveLists();
                return;
            }
            var res = _leaveManagement.GetLeaves(name, currentPage, pageSize);
            Tbl_LeaveLists.RowsDefaultCellStyle.BackColor = System.Drawing.Color.White;
            Tbl_LeaveLists.DataSource = res.res;
        }
    }
}
