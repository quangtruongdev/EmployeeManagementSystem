using EmployeeManagementSystem.Interfaces;
using EmployeeManagementSystem.Services;
using System;
using System.Windows.Forms;

namespace EmployeeManagementSystem.Forms.Department
{
    public partial class AddDepartment : Form
    {
        private readonly string _departmentId;
        private readonly IDepartment _departmentService;
        public AddDepartment(string departmentId = null)
        {
            InitializeComponent();
            _departmentService = new DepartmentService();
            _departmentId = departmentId;
            if (_departmentId != null)
            {

                this.Text = "Edit Department";
                LoadDepartmentDetails();
            }
            else
            {
                this.Text = "Add Department";
            }
        }

        private void Btn_Submit_Click(object sender, EventArgs e)
        {
            string departmentName = txtDepartmentName.Text.Trim();
            //if (string.IsNullOrEmpty(departmentName))
            //{
            //    MessageBox.Show("Department name is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            ValidateForm();

            Models.Department department = new Models.Department
            {
                DepartmentName = departmentName
            };

            try
            {
                if (_departmentId != null)
                {
                    department.DepartmentID = _departmentId;
                    _departmentService.UpdateDepartment(department);
                    MessageBox.Show("Department updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _departmentService.AddDepartment(department);
                    MessageBox.Show("Department added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDepartmentDetails()
        {
            var department = _departmentService.GetDepartmentById(_departmentId);
            txtDepartmentName.Text = department.DepartmentName;
        }

        private void ValidateForm()
        {
            bool isFormValid = true;
            string departmentName = txtDepartmentName.Text.Trim();
            if (string.IsNullOrEmpty(departmentName))
            {
                DepartmentNameError.Text = "Department name is required";
                isFormValid = false;
            }
            Btn_Submit.Enabled = isFormValid;
        }
    }
}
