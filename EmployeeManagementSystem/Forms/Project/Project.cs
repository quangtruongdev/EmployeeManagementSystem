using EmployeeManagementSystem.Interfaces;
using EmployeeManagementSystem.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystem.Forms.Project
{
    public partial class Project : Form
    {
        ProjectService _projectService;
        private int currentPage = 1;
        private int pageSize = 2;
        private string projectNameKey = null;
        private DateTime? startDateKey = null;
        private DateTime? endDateKey = null;
        public Project()
        {
            InitializeComponent();
            _projectService = new ProjectService();
            LoadProjects();
        }

        public void LoadProjects()
        {
            var results = _projectService.GetProjects(currentPage, pageSize
                , projectNameKey , startDateKey, endDateKey);
            var projects = results.Projects;
            var totalPages = results.TotalPages;

            Tbl_Projects.Columns.Clear();
            Tbl_Projects.AutoGenerateColumns = false; // turn off auto generate columns

            var projectId = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ProjectID",
                HeaderText = "Project Id",
                Name = "ProjectID",
                ReadOnly = true,
            };
            Tbl_Projects.Columns.Add(projectId);

            var projectName = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ProjectName",
                HeaderText = "Project Name",
                Name = "ProjectName",
                ReadOnly = true,
            };
            Tbl_Projects.Columns.Add(projectName);

            var projectDescription = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Description",
                HeaderText = "Project Description",
                Name = "Description",
                ReadOnly = true,
            };
            Tbl_Projects.Columns.Add(projectDescription);

            var projectStartDate = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "StartDate",
                HeaderText = "Start Date",
                Name = "StartDate",
                ReadOnly = true,
            };
            Tbl_Projects.Columns.Add(projectStartDate);

            var projectEndDate = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "EndDate",
                HeaderText = "End Date",
                Name = "EndDate",
                ReadOnly = true,
            };
            Tbl_Projects.Columns.Add(projectEndDate);

            var editButton = new DataGridViewButtonColumn
            {
                HeaderText = "",
                Name = "BtnEdit",
                Text = "Edit",
                UseColumnTextForButtonValue = true,
                Width = 50,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None
            };

            Tbl_Projects.Columns.Add(editButton);

            var deleteButton = new DataGridViewButtonColumn
            {
                HeaderText = "",
                Name = "BtnDelete",
                Text = "Delete",
                UseColumnTextForButtonValue = true,
                Width = 50,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None
            };
            Tbl_Projects.Columns.Add(deleteButton);

            var membersDetailsButton = new DataGridViewButtonColumn
            {
                HeaderText = "",
                Name = "BtnMembersDetails",
                Text = "MembersDetails",
                UseColumnTextForButtonValue = true,
                Width = 100,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None
            };
            Tbl_Projects.Columns.Add(membersDetailsButton);

            Tbl_Projects.DataSource = projects;

            PageOnPage.Text = $"Page {currentPage}/{totalPages}";

            Btn_Pre.Enabled = currentPage > 1;
            Btn_Next.Enabled = currentPage < totalPages;
        }

        private void Btn_Pre_Click(object sender, EventArgs e)
        {
                currentPage--;
                LoadProjects();
        }

        private void Btn_Next_Click(object sender, EventArgs e)
        {
                currentPage++;
                LoadProjects();
        }

        private void Btn_AddProject_Click(object sender, EventArgs e)
        {
            AddProject addProject = new AddProject();
            if(addProject.ShowDialog() == DialogResult.OK)
            {
                LoadProjects();
            }
        }

        private void Tbl_Projects_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                var projectId = Tbl_Projects.Rows[e.RowIndex].Cells["ProjectID"].Value.ToString();
                if (e.ColumnIndex == Tbl_Projects.Columns["BtnEdit"].Index)
                {
                    EditProject(projectId);
                }
                else if (e.ColumnIndex == Tbl_Projects.Columns["BtnDelete"].Index)
                {
                    DeleteProject(projectId);
                }
                else if (e.ColumnIndex == Tbl_Projects.Columns["BtnMembersDetails"].Index)
                {
                    var projectName = Tbl_Projects.Rows[e.RowIndex].Cells["ProjectName"].Value.ToString();
                    string startDate = Tbl_Projects.Rows[e.RowIndex].Cells["StartDate"].Value.ToString();
                    string endDate = Tbl_Projects.Rows[e.RowIndex].Cells["EndDate"].Value.ToString();
                    MembersDetails(projectId, projectName, startDate, endDate);
                }
            }
        }

        private void EditProject(string projectId)
        {
            AddProject addProject = new AddProject(projectId);
            if (addProject.ShowDialog() == DialogResult.OK)
            {
                LoadProjects();
            }
        }

        private void DeleteProject(string projectId)
        {
            var comfirmResult = MessageBox.Show("Are you sure you want to delete this project?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (comfirmResult == DialogResult.Yes)
            {
                _projectService.DeleteProject(projectId);
                LoadProjects();
            }
        }

        private void MembersDetails(string projectId, string projectName, string startDate, string endDate)
        {
            AddEmployeeToProject membersDetails = new AddEmployeeToProject(projectId, projectName, startDate, endDate);
            if (membersDetails.ShowDialog() == DialogResult.OK)
            {
                LoadProjects();
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            projectNameKey = projectNameTextBox.Text;
            startDateKey = startDateFrom.Value;
            endDateKey = endDateFrom.Value;
            currentPage = 1;
            LoadProjects();
        }

        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if(startDateFrom.Value <= endDateFrom.Value)
            {
                searchBtn.Enabled = true;
                errorLabel.Visible = false;
            }
            else
            {
                errorLabel.Visible = true;
                searchBtn.Enabled = false;
            }
        }

        private void pageSizeComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            pageSize = Convert.ToInt32(pageSizeComboBox.SelectedItem);
            LoadProjects();
        }
    }
}
