using EmployeeManagementSystem.Models;
using EmployeeManagementSystem.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.ApplicationModel.VoiceCommands;

namespace EmployeeManagementSystem.Forms.Project
{
    public partial class AddEmployeeToProject : Form
    {
        private ProjectService _projectService;
        private readonly string _projectId;
        private int page = 1;
        private int pageSize = 2;

        public AddEmployeeToProject(string projectId, string projectName
            , string startDate, string endDate)
        {
            InitializeComponent();
            _projectService = new ProjectService();
            _projectId = projectId;

            projectNameLabel.Text = "Project Name: " + projectName;
            startDateLabel.Text = "Start Date: " + startDate;
            endDateLabel.Text = "End Date: " + endDate;
            LoadMembers();
        }

        public void LoadMembers()
        {
            var results = _projectService.GetEmployeesInProject(_projectId, page, pageSize);
            var employees = results.employees;
            var positions = results.positions;

            membersDataGridView.Columns.Clear();
            membersDataGridView.AutoGenerateColumns = false;

            LoadColumnsToMembersDataGridView(membersDataGridView);

            membersDataGridView.DataSource = results.res;

            PageOnPage.Text = $"Page {page}/{results.totalPages}";
            Btn_Pre.Enabled = page > 1;
            Btn_Next.Enabled = page < results.totalPages;

            LoadMembersComboBox(results.employeesNotInProject);
            LoadPositionsComboBox(positions); 
        }

        private void LoadColumnsToMembersDataGridView(DataGridView membersDataGridView)
        {
            var employeeId = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "EmployeeId",
                HeaderText = "Employee Id",
                Name = "EmployeeId",
                ReadOnly = true,
            };
            membersDataGridView.Columns.Add(employeeId);

            var firstName = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "FirstName",
                HeaderText = "First Name",
                Name = "FirstName",
                ReadOnly = true,
            };
            membersDataGridView.Columns.Add(firstName);

            var lastName = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "LastName",
                HeaderText = "Last Name",
                Name = "LastName",
                ReadOnly = true,
            };
            membersDataGridView.Columns.Add(lastName);

            var position = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Position",
                HeaderText = "Position",
                Name = "Position",
                ReadOnly = true,
            };
            membersDataGridView.Columns.Add(position);

            var deleteBtn = new DataGridViewButtonColumn
            {
                HeaderText = "",
                Name = "DeleteBtn",
                Text = "Delete",
                UseColumnTextForButtonValue = true,
                Width = 60,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
            };
            membersDataGridView.Columns.Add(deleteBtn);
        }

        private void LoadMembersComboBox(List<Employee> employeesNotInProject)
        {
            var employeesDetails = employeesNotInProject.Select(e => new EmployeesDetails
            {
                EmployeeId = e.EmployeeID,
                FullName = e.FirstName + " " + e.LastName
            }).ToList();

            membersComboBox.DataSource = employeesDetails;
            membersComboBox.DisplayMember = "FullName";
            membersComboBox.ValueMember = "EmployeeId";
            membersComboBox.SelectedIndex = -1;
        }

        private void LoadPositionsComboBox(List<Positon> positions)
        {
            positionsComboBox.DataSource = positions;
            positionsComboBox.DisplayMember = "PositionName";
            positionsComboBox.ValueMember = "PositionID";
            positionsComboBox.SelectedIndex = -1;
        }

        private void Btn_Pre_Click(object sender, EventArgs e)
        {
            page--;
            LoadMembers();
        }

        private void Btn_Next_Click(object sender, EventArgs e)
        {
            page++;
            LoadMembers();
        }

        private void addMemberBtn_Click(object sender, EventArgs e)
        {
            EmployeeProject employeeProject = new EmployeeProject
            {
                EmployeeID = membersComboBox.SelectedValue.ToString(),
                ProjectID = _projectId,
                PositionID = positionsComboBox.SelectedValue.ToString(),
            };
            _projectService.AddEmployeeToProject(employeeProject);
            LoadMembers();
        }

        public class EmployeesDetails
        {
            public string EmployeeId { get; set; }
            public string FullName { get; set; }
        }

        private void membersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if(e.ColumnIndex == membersDataGridView.Columns["DeleteBtn"].Index)
            {
                var employeeId = membersDataGridView.Rows[e.RowIndex].Cells["EmployeeId"].Value.ToString();
                _projectService.DeleteEmployeeFromProject(employeeId, _projectId);
                LoadMembers();
            }
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            addMemberBtn.Enabled = (membersComboBox.SelectedItem != null
                && membersComboBox.SelectedIndex >= 0 && positionsComboBox.SelectedItem != null
                && positionsComboBox.SelectedIndex >= 0) ? true : false;
        }

        private void ComboBox_TextChanged(object sender, EventArgs e)
        {
            if (membersComboBox.Text == "" || positionsComboBox.Text == "") addMemberBtn.Enabled = false;
        }
    }
}
