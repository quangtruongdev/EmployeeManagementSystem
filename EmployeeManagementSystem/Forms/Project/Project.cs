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
        private int _currentPage = 1;
        private int _pageSize = 2;
        private string _projectNameKey = null;
        private DateTime? _startDateKey = null;
        private DateTime? _endDateKey = null;

        private const string ProjectIdColumnName = "ProjectID";
        private const string ProjectNameColumnName = "ProjectName";
        private const string DescriptionColumnName = "Description";
        private const string StartDateColumnName = "StartDate";
        private const string EndDateColumnName = "EndDate";
        private const string EditButtonName = "BtnEdit";
        private const string DeleteButtonName = "BtnDelete";
        private const string MembersDetailsButtonName = "BtnMembersDetails";

        public Project()
        {
            InitializeComponent();
            _projectService = new ProjectService();
            InitializeDataGridView();
            LoadProjects();
        }

        private void InitializeDataGridView()
        {
            Tbl_Projects.AutoGenerateColumns = false;
            Tbl_Projects.Columns.AddRange(CreateDataGridViewColumns());
        }

        private DataGridViewColumn[] CreateDataGridViewColumns()
        {
            return new DataGridViewColumn[]
            {
                CreateTextBoxColumn(ProjectIdColumnName, "Project Id"),
                CreateTextBoxColumn(ProjectNameColumnName, "Project Name"),
                CreateTextBoxColumn(DescriptionColumnName, "Project Description"),
                CreateTextBoxColumn(StartDateColumnName, "Start Date"),
                CreateTextBoxColumn(EndDateColumnName, "End Date"),
                CreateButtonColumn(EditButtonName, "Edit", 50),
                CreateButtonColumn(DeleteButtonName, "Delete", 50),
                CreateButtonColumn(MembersDetailsButtonName, "MembersDetails", 100)
            };
        }

        private DataGridViewTextBoxColumn CreateTextBoxColumn(string dataPropertyName, string headerText)
        {
            return new DataGridViewTextBoxColumn
            {
                DataPropertyName = dataPropertyName,
                HeaderText = headerText,
                Name = dataPropertyName,
                ReadOnly = true
            };
        }

        private DataGridViewButtonColumn CreateButtonColumn(string name, string text, int width)
        {
            return new DataGridViewButtonColumn
            {
                HeaderText = "",
                Name = name,
                Text = text,
                UseColumnTextForButtonValue = true,
                Width = width,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None
            };
        }

        private void LoadProjects()
        {
            var results = _projectService.GetProjects(_currentPage, _pageSize, _projectNameKey, _startDateKey, _endDateKey);
            Tbl_Projects.DataSource = results.Projects;
            PageOnPage.Text = $"Page {_currentPage}/{results.TotalPages}";

            Btn_Pre.Enabled = _currentPage > 1;
            Btn_Next.Enabled = _currentPage < results.TotalPages;
        }

        //public void LoadProjects()
        //{
        //    var results = _projectService.GetProjects(currentPage, pageSize
        //        , projectNameKey , startDateKey, endDateKey);
        //    var projects = results.Projects;
        //    var totalPages = results.TotalPages;

        //    Tbl_Projects.Columns.Clear();
        //    Tbl_Projects.AutoGenerateColumns = false; // turn off auto generate columns

        //    var projectId = new DataGridViewTextBoxColumn
        //    {
        //        DataPropertyName = "ProjectID",
        //        HeaderText = "Project Id",
        //        Name = "ProjectID",
        //        ReadOnly = true,
        //    };
        //    Tbl_Projects.Columns.Add(projectId);

        //    var projectName = new DataGridViewTextBoxColumn
        //    {
        //        DataPropertyName = "ProjectName",
        //        HeaderText = "Project Name",
        //        Name = "ProjectName",
        //        ReadOnly = true,
        //    };
        //    Tbl_Projects.Columns.Add(projectName);

        //    var projectDescription = new DataGridViewTextBoxColumn
        //    {
        //        DataPropertyName = "Description",
        //        HeaderText = "Project Description",
        //        Name = "Description",
        //        ReadOnly = true,
        //    };
        //    Tbl_Projects.Columns.Add(projectDescription);

        //    var projectStartDate = new DataGridViewTextBoxColumn
        //    {
        //        DataPropertyName = "StartDate",
        //        HeaderText = "Start Date",
        //        Name = "StartDate",
        //        ReadOnly = true,
        //    };
        //    Tbl_Projects.Columns.Add(projectStartDate);

        //    var projectEndDate = new DataGridViewTextBoxColumn
        //    {
        //        DataPropertyName = "EndDate",
        //        HeaderText = "End Date",
        //        Name = "EndDate",
        //        ReadOnly = true,
        //    };
        //    Tbl_Projects.Columns.Add(projectEndDate);

        //    var editButton = new DataGridViewButtonColumn
        //    {
        //        HeaderText = "",
        //        Name = "BtnEdit",
        //        Text = "Edit",
        //        UseColumnTextForButtonValue = true,
        //        Width = 50,
        //        AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        //    };

        //    Tbl_Projects.Columns.Add(editButton);

        //    var deleteButton = new DataGridViewButtonColumn
        //    {
        //        HeaderText = "",
        //        Name = "BtnDelete",
        //        Text = "Delete",
        //        UseColumnTextForButtonValue = true,
        //        Width = 50,
        //        AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        //    };
        //    Tbl_Projects.Columns.Add(deleteButton);

        //    var membersDetailsButton = new DataGridViewButtonColumn
        //    {
        //        HeaderText = "",
        //        Name = "BtnMembersDetails",
        //        Text = "MembersDetails",
        //        UseColumnTextForButtonValue = true,
        //        Width = 100,
        //        AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        //    };
        //    Tbl_Projects.Columns.Add(membersDetailsButton);

        //    Tbl_Projects.DataSource = projects;

        //    PageOnPage.Text = $"Page {currentPage}/{totalPages}";

        //    Btn_Pre.Enabled = currentPage > 1;
        //    Btn_Next.Enabled = currentPage < totalPages;
        //}

        private void Btn_Pre_Click(object sender, EventArgs e)
        {
                _currentPage--;
                LoadProjects();
        }

        private void Btn_Next_Click(object sender, EventArgs e)
        {
                _currentPage++;
                LoadProjects();
        }

        private void Btn_AddProject_Click(object sender, EventArgs e)
        {
            AddProject addProject = new AddProject(null, true);
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
            AddProject addProject = new AddProject(projectId, true);
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
            _projectNameKey = projectNameTextBox.Text;
            _startDateKey = startDateFrom.Value;
            _endDateKey = endDateFrom.Value;
            _currentPage = 1;
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
            _pageSize = Convert.ToInt32(pageSizeComboBox.SelectedItem);
            _currentPage = 1;
            LoadProjects();
        }
    }
}
