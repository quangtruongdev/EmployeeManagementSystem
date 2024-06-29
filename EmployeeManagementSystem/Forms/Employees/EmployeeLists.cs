﻿using EmployeeManagementSystem.Interfaces;
using EmployeeManagementSystem.Services;
using System;
using System.Windows.Forms;

namespace EmployeeManagementSystem.Forms.Employees
{
    public partial class EmployeeLists : Form
    {
        private readonly IDepartment _departmentService;
        private readonly IEmployees _employeesService;
        private int currentPage = 1;
        private int pageSize = 10;
        public EmployeeLists()
        {
            InitializeComponent();
            _employeesService = new EmployeesService();
            _departmentService = new DepartmentService();
            LoadEmployees();
        }

        private void LoadDepartment()
        {
            var departments = _departmentService.GetDepartments();
            cbb_DepartmentName.DataSource = departments;
            cbb_DepartmentName.DisplayMember = "DepartmentName";
            cbb_DepartmentName.ValueMember = "DepartmentID";
        }

        private void LoadEmployees()
        {
            cbb_DepartmentName.Visible = false;
            dtp_Date.Visible = false;

            string item = cbb_Item.Text;
            if (item == "Date")
            {
                DateTime search = dtp_Date.Value;
                var results = _employeesService.GetEmployeesDate(search, currentPage, pageSize);
                var employees = results.Employees;
                var totalPages = results.TotalPages;
                dataGridView.Columns.Clear();
                dataGridView.DataSource = employees;

                PageOnPage.Text = $"{currentPage}/{totalPages}";

                btn_Previous.Enabled = currentPage > 1;
                btn_Next.Enabled = currentPage < totalPages;
            }
            else if (item == "Department")
            {
                string search = cbb_DepartmentName.SelectedValue.ToString();
                var results = _employeesService.GetEmployeesDepartment(search, currentPage, pageSize);
                var employees = results.Employees;
                var totalPages = results.TotalPages;
                dataGridView.Columns.Clear();
                dataGridView.DataSource = employees;

                PageOnPage.Text = $"{currentPage}/{totalPages}";

                btn_Previous.Enabled = currentPage > 1;
                btn_Next.Enabled = currentPage < totalPages;
            }
            else
            {
                string search = txt_search.Text;
                var results = _employeesService.GetEmployees(search, currentPage, pageSize);
                var employees = results.Employees;
                var totalPages = results.TotalPages;
                dataGridView.Columns.Clear();
                dataGridView.DataSource = employees;

                PageOnPage.Text = $"{currentPage}/{totalPages}";

                btn_Previous.Enabled = currentPage > 1;
                btn_Next.Enabled = currentPage < totalPages;
            }




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
            EmployeeForm employeeForm = new EmployeeForm(employeeID);
            if (employeeForm.ShowDialog() == DialogResult.OK)
            {
                LoadEmployees();
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
                    EditEmployee(employeeId);
                }
                else if (e.ColumnIndex == dataGridView.Columns["btn_Delete"].Index)
                {
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
            }
            else if (item == "Department")
            {
                LoadDepartment();
                txt_search.Visible = false;
                dtp_Date.Visible = false;
                cbb_DepartmentName.Visible = true;
            }
            else if (item == "Text")
            {
                txt_search.Visible = true;
                dtp_Date.Visible = false;
                cbb_DepartmentName.Visible = false;
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
            }
            else if (item == "Department")
            {
                LoadDepartment();
                txt_search.Visible = false;
                dtp_Date.Visible = false;
                cbb_DepartmentName.Visible = true;
            }
            else
            {
                txt_search.Visible = true;
                dtp_Date.Visible = false;
                cbb_DepartmentName.Visible = false;
            }
        }
    }
}