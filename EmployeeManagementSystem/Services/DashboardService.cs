using EmployeeManagementSystem.Interfaces;
using EmployeeManagementSystem.Models;
using System.Linq;

namespace EmployeeManagementSystem.Services
{
    public class DashboardService : IDashboard
    {
        private readonly DatabaseDataContext _db = new DatabaseDataContext();

        public (int totalProjects, int totalEmployees) GetSummary()
        {
            int totalProjects = _db.Projects.Count();
            int totalEmployees = _db.Employees.Count();

            return (totalProjects, totalEmployees);
        }
    }
}
