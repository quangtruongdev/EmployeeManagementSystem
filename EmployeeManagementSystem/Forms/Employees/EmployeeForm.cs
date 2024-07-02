using EmployeeManagementSystem.Interfaces;
using EmployeeManagementSystem.Services;
using EmployeeManagementSystem.Utils;
using System;
using System.Windows.Forms;

namespace EmployeeManagementSystem.Forms.Employees
{
    public partial class EmployeeForm : Form
    {
        private readonly IDepartment _departmentService;
        private readonly IEmployees _employeesService;
        private readonly string _employeeID;

        public EmployeeForm(string employeeID = null)
        {
            InitializeComponent();
            _departmentService = new DepartmentService();
            _employeesService = new EmployeesService();
            _employeeID = employeeID;

            InitializeForm();
        }

        private void InitializeForm()
        {
            LoadDepartment();

            if (_employeeID != null)
            {
                LoadEmployeeDetails();
            }
            else
            {
                ClearAddEmployee();
            }
        }

        private void ClearAddEmployee()
        {
            txt_firstName.Clear();
            txt_lastName.Clear();
            cbb_gender.SelectedIndex = -1;
            dtp_dateOfBirth.Value = DateTime.Now;
            txt_phoneNumber.Clear();
            txt_email.Clear();
            txt_address.Clear();
            cbb_departmentID.SelectedIndex = -1;
        }

        private void LoadDepartment()
        {
            var departments = _departmentService.GetDepartments();
            cbb_departmentID.DataSource = departments;
            cbb_departmentID.DisplayMember = "DepartmentName";
            cbb_departmentID.ValueMember = "DepartmentID";
        }

        private void LoadEmployeeDetails()
        {
            var employee = _employeesService.GetEmployeeById(_employeeID);

            txt_firstName.Text = employee.FirstName;
            txt_lastName.Text = employee.LastName;
            cbb_gender.Text = GetGenderText(employee.Gender.GetValueOrDefault('O'));
            dtp_dateOfBirth.Value = employee.DateOfBirth ?? DateTime.Now;
            txt_phoneNumber.Text = employee.PhoneNumber;
            txt_email.Text = employee.Email;
            txt_address.Text = employee.Address;

            LoadDepartment();
            cbb_departmentID.SelectedValue = employee.DepartmentID;
        }

        private string GetGenderText(char gender)
        {
            switch (gender)
            {
                case 'M':
                    return "Male";
                case 'F':
                    return "Female";
                case 'O':
                default:
                    return "Other";
            }
        }

        private char GetGenderChar()
        {
            switch (cbb_gender.Text)
            {
                case "Male":
                    return 'M';
                case "Female":
                    return 'F';
                case "Other":
                default:
                    return 'O';
            }
        }

        private Models.Employee CreateEmployee()
        {
            return new Models.Employee
            {
                EmployeeID = _employeeID,
                FirstName = txt_firstName.Text,
                LastName = txt_lastName.Text,
                Gender = GetGenderChar(),
                DateOfBirth = dtp_dateOfBirth.Value,
                PhoneNumber = txt_phoneNumber.Text,
                Email = txt_email.Text,
                Address = txt_address.Text,
                DepartmentID = cbb_departmentID.SelectedValue.ToString()
            };
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            var employee = CreateEmployee();

            try
            {
                if (string.IsNullOrEmpty(_employeeID))
                {
                    _employeesService.AddEmployee(employee);
                    //MessageBox.Show("Employee added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Shared.ShowToastr("Success", "Employee added successfully");
                    ClearAddEmployee();
                }
                else
                {
                    _employeesService.UpdateEmployee(employee);
                    //MessageBox.Show("Employee updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Shared.ShowToastr("Success", "Employee updated successfully");
                    this.DialogResult = DialogResult.OK;
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
