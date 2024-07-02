using EmployeeManagementSystem.Services;
using EmployeeManagementSystem.Utils;
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
    public partial class AddProject : Form
    {
        private ProjectService _projectService;
        private readonly string _projectId;

        public AddProject(string projectId = null)
        {
            InitializeComponent();
            _projectService = new ProjectService();
            _projectId = projectId;

            if (_projectId != null)
            {
                LoadProjectDetails();
                projectLabel.Text = "Edit Project";
                submitBtn.Enabled = false;
            }
            else
            {
               projectLabel.Text = "Add Project";
            }
        }

        private void LoadProjectDetails()
        {
            var project = _projectService.GetProjectById(_projectId);
            projectNameTextBox.Text = project.ProjectName;
            projectDescriptionTextBox.Text = project.Description;
            startDateDateTimePicker.Value = (DateTime) project.StartDate;
            endDateDateTimePicker.Value = (DateTime) project.EndDate;
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            string projectName = projectNameTextBox.Text.Trim();
            string projectDescription = projectDescriptionTextBox.Text.Trim();
            DateTime startDate = startDateDateTimePicker.Value;
            DateTime endDate = endDateDateTimePicker.Value;

            Models.Project project = new Models.Project
            {
                ProjectName = projectName,
                Description = projectDescription,
                StartDate = startDate,
                EndDate = endDate
            };

            if(_projectId != null)
            {
                project.ProjectID = _projectId;
                _projectService.UpdateProject(project);
            }
            else
            {
                _projectService.AddProject(project);
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void projectNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(projectNameTextBox.Text))
            {
                projectNameErrorLabel.Text = "Project name is required";
                submitBtn.Enabled = false;
            } else
            {
                projectNameErrorLabel.Text = "";
                submitBtn.Enabled = true;
            }
        }

        private void projectDescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            submitBtn.Enabled = true;
        }

        private void startDateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if(startDateDateTimePicker.Value > endDateDateTimePicker.Value)
            {
                startDateErrorLabel.Text = "Start date cannot be greater than end date";
                submitBtn.Enabled = false;
            } 
            else
            {
                startDateErrorLabel.Text = "";
                endDateErrorLabel.Text = "";
                submitBtn.Enabled = true;
            }
        }

        private void endDateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (startDateDateTimePicker.Value > endDateDateTimePicker.Value)
            {
                endDateErrorLabel.Text = "End date cannot be less than start date";
                submitBtn.Enabled = false;
            }
            else
            {
                startDateErrorLabel.Text = "";
                endDateErrorLabel.Text = "";
                submitBtn.Enabled = true;
            }
        }
    }
}
