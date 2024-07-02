using EmployeeManagementSystem.Interfaces;
using EmployeeManagementSystem.Services;
using System;
using System.Windows.Forms;

namespace EmployeeManagementSystem.Forms.Employees
{
    public partial class EmployeeLists : Form
    {

        private readonly IPositions _positiontService;
        private readonly IDepartment _departmentService;
        private readonly IEmployees _employeesService;
        private int currentPage = 1;
        private int pageSize = 10;
        public EmployeeLists()
        {
            InitializeComponent();
            _employeesService = new EmployeesService();
            _departmentService = new DepartmentService();
            _positiontService = new PositionsService();
            LoadEmployees();
        }

        private void LoadSearch()
        {
            if (cbb_Item.Text == "Department")
            {
                var departments = _departmentService.GetDepartments();
                cbb_ID.DataSource = departments;
                cbb_ID.DisplayMember = "DepartmentName";
                cbb_ID.ValueMember = "DepartmentID";
            }
            else if (cbb_Item.Text == "Position")
            {
                var positions = _positiontService.GetPositions();
                cbb_ID.DataSource = positions;
                cbb_ID.DisplayMember = "PositionName";
                cbb_ID.ValueMember = "PositionID";
            }
        }

        private void LoadEmployees()
        {
            string item = cbb_Item.Text;
            string textSearch = null;
            DateTime? dateSearch = null;
            string cbbSearch = null;

            if (item == "Date")
            {
                dateSearch = dtp_Date.Value;
            }
            else if (item == "Department" || item == "Position")
            {
                cbbSearch = cbb_ID.Text;
            }
            else
            {
                textSearch = txt_search.Text;
            }

            var results = _employeesService.GetEmployees(textSearch, dateSearch, cbbSearch, currentPage, pageSize);
            var employees = results.Employees;
            var totalPages = results.totalPages;
            dataGridView.Columns.Clear();
            dataGridView.DataSource = employees;

            // Cập nhật thông tin phân trang và các nút điều hướng
            PageOnPage.Text = $"{currentPage}/{totalPages}";
            btn_Previous.Enabled = currentPage > 1;
            btn_Next.Enabled = currentPage < totalPages;


            var editButton = new DataGridViewButtonColumn
            {
                HeaderText = "Actions",
                Name = "btn_Edit",
                Text = "Edit",
                UseColumnTextForButtonValue = true,
                Width = 50,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None
            };
            dataGridView.Columns.Add(editButton);

            var deleteButton = new DataGridViewButtonColumn
            {
                HeaderText = "",
                Name = "btn_Delete",
                Text = "Delete",
                UseColumnTextForButtonValue = true,
                Width = 50,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None
            };
            dataGridView.Columns.Add(deleteButton);
        }

        private void EditEmployee(string employeeID)
        {
            using (EmployeeForm employeeForm = new EmployeeForm(employeeID))
            {
                if (employeeForm.ShowDialog() == DialogResult.OK)
                {
                    LoadEmployees();
                }
            }
        }

        private void DeleteEmployee(string employeeID)
        {
            var comfirmResult = MessageBox.Show("Are you sure you want to delete this employee?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (comfirmResult == DialogResult.Yes)
            {
                _employeesService.DeleteEmployee(employeeID);
                LoadEmployees();
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var employeeId = dataGridView.Rows[e.RowIndex].Cells["EmployeeID"].Value.ToString();
                if (e.ColumnIndex == dataGridView.Columns["btn_Edit"].Index)
                {
                    cbb_Item.Text = "Text";
                    txt_search.Text = "";
                    EditEmployee(employeeId);
                }
                else if (e.ColumnIndex == dataGridView.Columns["btn_Delete"].Index)
                {
                    cbb_Item.Text = "Text";
                    txt_search.Text = "";
                    DeleteEmployee(employeeId);
                }
            }
        }

        private void btn_Previous_Click(object sender, System.EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadEmployees();
            }
        }

        private void btn_Next_Click(object sender, System.EventArgs e)
        {
            currentPage++;
            LoadEmployees();
        }

        private void btn_Search_Click(object sender, System.EventArgs e)
        {

            LoadEmployees();
            string item = cbb_Item.Text;
            if (item == "Date")
            {
                txt_search.Visible = false;
                dtp_Date.Visible = true;
                cbb_ID.Visible = false;
            }
            else if (item == "Department" || item == "Position")
            {
                txt_search.Visible = false;
                dtp_Date.Visible = false;
                cbb_ID.Visible = true;
            }
            else if (item == "Text")
            {
                txt_search.Visible = true;
                dtp_Date.Visible = false;
                cbb_ID.Visible = false;
            }
            else MessageBox.Show("Please select search!");
        }

        private void cbb_Item_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            string item = cbb_Item.Text;
            if (item == "Date")
            {
                txt_search.Visible = false;
                dtp_Date.Visible = true;
                cbb_ID.Visible = false;
            }
            else if (item == "Department" || item == "Position")
            {
                LoadSearch();
                txt_search.Visible = false;
                dtp_Date.Visible = false;
                cbb_ID.Visible = true;
            }
            else
            {
                txt_search.Visible = true;
                dtp_Date.Visible = false;
                cbb_ID.Visible = false;
            }
        }
    }
}
