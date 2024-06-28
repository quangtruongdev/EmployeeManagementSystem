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
                var totalProjects = context.Projects.Count();
                var totalPages = (int)Math.Ceiling((double)totalProjects / pageSize);

                var Projects = context.Projects
                                    .Skip((page - 1) * pageSize)
                                    .Take(pageSize)
                                    .ToList();

                return (Projects, totalProjects, totalPages);
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
    }
}
