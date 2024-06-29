using EmployeeManagementSystem.Models;
using System.Collections.Generic;

namespace EmployeeManagementSystem.Interfaces
{
    internal interface IEmployees
    {
        List<Employee> GetEmployees();
        Employee GetEmployeeById(string id);
        void AddEmployee(Employee employee);
        void DeleteEmployee(string id);
        void UpdateEmployee(Employee employee);
    }
}
