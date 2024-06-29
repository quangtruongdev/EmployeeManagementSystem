using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        public (List<Project> Projects, int totalProjects, int TotalPages) 
            GetProjects(int page, int pageSize, string projectNameKey = null
            , DateTime? startFromDateKey = null, DateTime? startToDateKey = null,
            DateTime? endFromDateKey = null, DateTime? endToDateKey = null )
        {
            try
            {
                using (var context = new DatabaseDataContext())
                // this to make sure that data is newest because it use cache
                {
                    var projects = context.Projects.AsQueryable();
                    projects = (string.IsNullOrEmpty(projectNameKey)) ? projects 
                        : projects.Where(p => p.ProjectName.Contains(projectNameKey));
                    projects = (!startFromDateKey.HasValue) ? projects
                        : projects.Where(p => p.StartDate >= startFromDateKey 
                        && p.StartDate <= startToDateKey);
                    projects = (!endFromDateKey.HasValue) ? projects
                        : projects.Where(p => p.EndDate >= endFromDateKey
                        && p.EndDate <= endToDateKey);

                    var totalProjects = projects.Count();
                    var totalPages = (int)Math.Ceiling((double)totalProjects / pageSize);

                    var Projects = projects
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

        public (IQueryable res, int totalEmployees, int totalPages, List<Positon> positions
            , List<Employee> employees, List<Employee> employeesNotInProject) GetEmployeesInProject(string projectId, int page, int pageSize)
        {
            try
            {
                var employeesInProject = context.EmployeeProjects
                    .Where(ep => ep.ProjectID == projectId);
                int totalEmployees = employeesInProject.Count();
                int totalPages = (int)Math.Ceiling((double)totalEmployees / pageSize);
                var employees = context.Employees;
                var positions = context.Positons;

                var employeeIdsInProject = context.EmployeeProjects.Where(ep => 
                    ep.ProjectID == projectId).Select(ep => ep.EmployeeID).ToList();
                var employeesNotInProject = context.Employees
                    .Where(e => !employeeIdsInProject.Contains(e.EmployeeID)).ToList();



                var result = from employee in employeesInProject
                             join position in positions
                             on employee.PositionID equals position.PositionID
                             join employeeInProject in employees
                             on employee.EmployeeID equals employeeInProject.EmployeeID
                             select new
                             {
                                 EmployeeId = employee.EmployeeID,
                                 FirstName = employeeInProject.FirstName,
                                 LastName = employeeInProject.LastName,
                                 Position = position.PositionName
                             };
                result = result.Skip((page-1) * pageSize).Take(pageSize);

                return (result, totalEmployees, totalPages, positions.ToList(), employees.ToList(), employeesNotInProject);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return (null, 0, 0, null, null, null);
            }
        }

        public void AddEmployeeToProject(EmployeeProject employeeProject) 
        {
            try
            {
                context.EmployeeProjects.InsertOnSubmit(employeeProject);
                context.SubmitChanges();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void DeleteEmployeeFromProject(string employeeId, string projectId)
        {
            try
            {
                var employeeProject = context.EmployeeProjects
                    .FirstOrDefault(ep => ep.ProjectID == projectId && ep.EmployeeID == employeeId);
                context.EmployeeProjects.DeleteOnSubmit(employeeProject);
                context.SubmitChanges();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
