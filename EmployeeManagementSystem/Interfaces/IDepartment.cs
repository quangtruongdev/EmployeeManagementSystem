using EmployeeManagementSystem.Models;
using System.Collections.Generic;

namespace EmployeeManagementSystem.Interfaces
{
    public interface IDepartment
    {
        List<Department> GetDepartments();
        Department GetDepartmentById(string id);
        void AddDepartment(Department department);
        void UpdateDepartment(Department department);
        void DeleteDepartment(string id);
    }
}
