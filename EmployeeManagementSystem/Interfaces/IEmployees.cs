using EmployeeManagementSystem.Models;
using System;
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

        (List<Employee> Employees, int totalEmployees, int TotalPages) GetEmployees(string search, int page, int pageSize);

        (List<Employee> Employees, int totalEmployees, int TotalPages) GetEmployeesDate(DateTime search, int page, int pageSize);

        (List<Employee> Employees, int totalEmployees, int TotalPages) GetEmployeesDepartment(string search, int page, int pageSize);
    }
}
