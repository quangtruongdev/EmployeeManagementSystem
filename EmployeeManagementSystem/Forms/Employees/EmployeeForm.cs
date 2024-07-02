using EmployeeManagementSystem.Interfaces;
using EmployeeManagementSystem.Services;
using System;
using System.Windows.Forms;

namespace EmployeeManagementSystem.Forms.Employees
{
    public partial class EmployeeForm : Form
    {
        private readonly IPositions _positionService;
        private readonly IDepartment _departmentService;
        private readonly IEmployees _employeesService;
        private readonly string _employeeID;
        public EmployeeForm(string employeeID = null)
        {
            InitializeComponent();
            _departmentService = new DepartmentService();
            _employeesService = new EmployeesService();
            _positionService = new PositionsService();
            _employeeID = employeeID;
            if (employeeID != null)
            {
                btn_Add.Visible = false;
                nameForm.Text = "Edit Employee";
                LoadEmployeeDetails();
            }
            else
            {
                btn_Update.Visible = false;
                btn_Close.Visible = false;
                nameForm.Text = "Add Employee";
                LoadDepartment();
                LoadPosition();
                ClearAddEployee();
            }
        }
        private void ClearAddEployee()
        {
            txt_firstName.Text = "";
            txt_lastName.Text = "";
            cbb_gender.SelectedIndex = -1;
            dtp_dateOfBirth.Value = DateTime.Now;
            txt_phoneNumber.Text = "";
            txt_email.Text = "";
            txt_address.Text = "";
            cbb_departmentID.SelectedIndex = -1;
            cbb_positionID.SelectedIndex = -1;
        }
        private void LoadDepartment()
        {
            var departments = _departmentService.GetDepartments();
            cbb_departmentID.DataSource = departments;
            cbb_departmentID.DisplayMember = "DepartmentName";
            cbb_departmentID.ValueMember = "DepartmentID";
        }
        private void LoadPosition()
        {
            var positions = _positionService.GetPositions();
            cbb_positionID.DataSource = positions;
            cbb_positionID.DisplayMember = "PositionName";
            cbb_positionID.ValueMember = "PositionID";
        }


        private void LoadEmployeeDetails()
        {
            var employee = _employeesService.GetEmployeeById(_employeeID);

            txt_firstName.Text = employee.FirstName;
            txt_lastName.Text = employee.LastName;

            switch (employee.Gender)
            {
                case 'M':
                    cbb_gender.Text = "Male";
                    break;
                case 'F':
                    cbb_gender.Text = "Female";
                    break;
                case 'O':
                    cbb_gender.Text = "Other";
                    break;
            }

            dtp_dateOfBirth.Value = employee.DateOfBirth.Value;
            txt_phoneNumber.Text = employee.PhoneNumber;
            txt_email.Text = employee.Email;
            txt_address.Text = employee.Address;

            LoadDepartment();
            cbb_departmentID.SelectedValue = employee.DepartmentID;

            LoadPosition();
            cbb_positionID.SelectedValue = employee.PositionID;
        }

        private void btn_Update_Click(object sender, System.EventArgs e)
        {
            char gender;
            switch (cbb_gender.Text)
            {
                case "Male":
                    gender = 'M';
                    break;
                case "Female":
                    gender = 'F';
                    break;
                case "Other":
                    gender = 'O';
                    break;
                default:
                    gender = 'O';
                    break;
            }
            if (dtp_dateOfBirth.Value > DateTime.Now)
            {
                MessageBox.Show("Date of Birth cannot be in the future.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Models.Employee employee = new Models.Employee
            {
                FirstName = txt_firstName.Text,
                LastName = txt_lastName.Text,
                Gender = gender,
                DateOfBirth = dtp_dateOfBirth.Value,
                PhoneNumber = txt_phoneNumber.Text,
                Email = txt_email.Text,
                Address = txt_address.Text,
                DepartmentID = cbb_departmentID.SelectedValue.ToString(),
                PositionID = cbb_positionID.SelectedValue.ToString(),
            };
            try
            {
                employee.EmployeeID = _employeeID;
                _employeesService.UpdateEmployee(employee);
                MessageBox.Show("Employee updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Close_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            char gender;
            switch (cbb_gender.Text)
            {
                case "Male":
                    gender = 'M';
                    break;
                case "Female":
                    gender = 'F';
                    break;
                case "Other":
                    gender = 'O';
                    break;
                default:
                    gender = 'O';
                    break;
            }
            if (dtp_dateOfBirth.Value > DateTime.Now)
            {
                MessageBox.Show("Date of Birth cannot be in the future.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Models.Employee employee = new Models.Employee
            {
                FirstName = txt_firstName.Text,
                LastName = txt_lastName.Text,
                Gender = gender,
                DateOfBirth = dtp_dateOfBirth.Value,
                PhoneNumber = txt_phoneNumber.Text,
                Email = txt_email.Text,
                Address = txt_address.Text,
                DepartmentID = cbb_departmentID.SelectedValue.ToString(),
                PositionID = cbb_positionID.SelectedValue.ToString(),
            };
            try
            {
                _employeesService.AddEmployee(employee);
                MessageBox.Show("Employee added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearAddEployee();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
