using EmployeeManagementSystem.Interfaces;
using EmployeeManagementSystem.Services;
using System.Windows.Forms;

namespace EmployeeManagementSystem.Forms.Department
{
    public partial class Department : Form
    {
        private readonly IDepartment _departmentService;
        private int currentPage = 1;
        private int pageSize = 2;
        public Department()
        {
            InitializeComponent();
            _departmentService = new DepartmentService();
            LoadDepartments();
        }

        private void Btn_AddDepartment_Click(object sender, System.EventArgs e)
        {
            AddDepartment addDepartment = new AddDepartment();
            if (addDepartment.ShowDialog() == DialogResult.OK)
            {
                LoadDepartments();
            }
        }

        private void LoadDepartments()
        {
            //var departments = _departmentService.GetDepartments();
            var results = _departmentService.GetDepartments(currentPage, pageSize);
            var departments = results.Departments;
            var totalPages = results.TotalPages;
            //var totalDepartments = results.totalDepartments;

            Tbl_Departments.Columns.Clear();

            //var sttColumn = new DataGridViewTextBoxColumn
            //{
            //    HeaderText = "STT",
            //    Name = "STT",
            //    ReadOnly = true,
            //    Width = 50
            //};
            //Tbl_Departments.Columns.Add(sttColumn);

            var departmentId = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DepartmentID",
                HeaderText = "Department Id",
                Name = "DepartmentID",
                ReadOnly = true,
            };
            Tbl_Departments.Columns.Add(departmentId);

            var departmentName = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DepartmentName",
                HeaderText = "Department Name",
                Name = "DepartmentName",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            };
            Tbl_Departments.Columns.Add(departmentName);

            var editButton = new DataGridViewButtonColumn
            {
                HeaderText = "Actions",
                Name = "Btn_Edit",
                Text = "Edit",
                UseColumnTextForButtonValue = true,
                Width = 50,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None
            };
            Tbl_Departments.Columns.Add(editButton);

            var deleteButton = new DataGridViewButtonColumn
            {
                HeaderText = "",
                Name = "Btn_Delete",
                Text = "Delete",
                UseColumnTextForButtonValue = true,
                Width = 50,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None
            };
            Tbl_Departments.Columns.Add(deleteButton);

            Tbl_Departments.DataSource = departments;

            //for (int i = 0; i < departments.Count; i++)
            //{
            //    Tbl_Departments.Rows[i].Cells["STT"].Value = (currentPage - 1) * pageSize + i + 1;
            //}


            PageOnPage.Text = $"{currentPage}/{totalPages}";

            Btn_Pre.Enabled = currentPage > 1;
            Btn_Next.Enabled = currentPage < totalPages;
        }

        private void EditDepartment(string departmentId)
        {
            AddDepartment addDepartment = new AddDepartment(departmentId);
            if (addDepartment.ShowDialog() == DialogResult.OK)
            {
                LoadDepartments();
            }
        }

        private void DeleteDepartment(string departmentId)
        {
            var comfirmResult = MessageBox.Show("Are you sure you want to delete this department?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (comfirmResult == DialogResult.Yes)
            {
                _departmentService.DeleteDepartment(departmentId);
                LoadDepartments();
            }
        }

        private void Tbl_Departments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var departmentId = Tbl_Departments.Rows[e.RowIndex].Cells["DepartmentID"].Value.ToString();
                if (e.ColumnIndex == Tbl_Departments.Columns["Btn_Edit"].Index)
                {
                    EditDepartment(departmentId);
                }
                else if (e.ColumnIndex == Tbl_Departments.Columns["Btn_Delete"].Index)
                {
                    DeleteDepartment(departmentId);
                }
            }
        }

        private void Btn_Pre_Click(object sender, System.EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadDepartments();
            }
        }

        private void Btn_Next_Click(object sender, System.EventArgs e)
        {
            currentPage++;
            LoadDepartments();
        }
    }
}
