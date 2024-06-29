using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagementSystem.Interfaces;
using EmployeeManagementSystem.Models;

namespace EmployeeManagementSystem.Services
{
    //public class ProjectService : IProject
    public class ProjectService
    {
        private DatabaseDataContext context = new DatabaseDataContext();
        public List<Project> GetProjects() {
            try
            {
                return context.Projects.ToList();
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public (List<Project> Projects, int totalDepartments, int TotalPages) GetProjects(int page, int pageSize)
        {
            try
            {
                using (var context = new DatabaseDataContext()) 
                // this to make sure that data is newest
                // because it use cache
                {
                    var totalProjects = context.Projects.Count();
                    var totalPages = (int)Math.Ceiling((double)totalProjects / pageSize);

                    var Projects = context.Projects
                                        .Skip((page - 1) * pageSize)
                                        .Take(pageSize)
                                        .ToList();

                    return (Projects, totalProjects, totalPages);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Project GetProjectById(string id)
        {
            try
            {
                return context.Projects.FirstOrDefault(p => p.ProjectID == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void DeleteProject(string id)
        {
            try
            {
                Project project = context.Projects.FirstOrDefault(p => p.ProjectID == id);
                context.Projects.DeleteOnSubmit(project);
                context.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        
        public void AddProject(Project project)
        {
            try
            {
                project.ProjectID = Guid.NewGuid().ToString();
                context.Projects.InsertOnSubmit(project);
                context.SubmitChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void UpdateProject(Project project)
        {
            var oldProject = context.Projects.FirstOrDefault(p => p.ProjectID == project.ProjectID);
            oldProject.ProjectName = project.ProjectName;
            oldProject.Description = project.Description;
            oldProject.StartDate = project.StartDate;
            oldProject.EndDate = project.EndDate;
            context.SubmitChanges();
        }
    }
}
