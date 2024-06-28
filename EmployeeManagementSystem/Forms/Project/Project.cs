using EmployeeManagementSystem.Interfaces;
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

namespace EmployeeManagementSystem.Forms.Project
{
    public partial class Project : Form
    {
        ProjectService _projectService;
        private int currentPage = 1;
        private int pageSize = 2;
        public Project()
        {
            InitializeComponent();
            _projectService = new ProjectService();
            LoadProjects();
        }

        public void LoadProjects()
        {
            var results = _projectService.GetProjects(currentPage, pageSize);
            var projects = results.Projects;
            var totalPages = results.TotalPages;

            Tbl_Projects.Columns.Clear();

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
                Name = "Btn_Edit",
                Text = "Edit",
                UseColumnTextForButtonValue = true,
                Width = 50,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None
            };

            Tbl_Projects.Columns.Add(editButton);

            var deleteButton = new DataGridViewButtonColumn
            {
                HeaderText = "",
                Name = "Btn_Delete",
                Text = "Delete",
                UseColumnTextForButtonValue = true,
                Width = 50,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None
            };
            Tbl_Projects.Columns.Add(deleteButton);

            Tbl_Projects.DataSource = projects;
        }
    }
}
