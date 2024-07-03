using EmployeeManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeManagementSystem.Interfaces
{
    internal interface IEmployees
    {
        List<Employee> GetEmployees();
        Employee GetEmployeeById(string id);
        void AddEmployee(Employee employee);
        void DeleteEmployee(string id);
        void UpdateEmployee(Employee employee);
        (IQueryable Employees, int totalEmployees, int totalPages) GetEmployees(
            string textSearch = null,
            DateTime? dateSearch = null,
            string departmentSearch = null,
            int page = 1,
            int pageSize = 10);
    }
}
