using EmployeeManagementSystem.Models;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeManagementSystem.Interfaces
{
    public interface ISalary
    {
        IQueryable LoadData(string search, int page, int pageSize);

        (string email, string name, string posname, string depname, double? salary) GetEmployeebyEmail(string email);

        List<Position> getListPosition();

        List<Department> getListDepartment();

        void addSalary(string email, double? salaryAmount);

        void updateSalary(string email, string salaryAmount);

        void Payment(string email);

        IQueryable loadEmployee(string search, int pageSize);

        int getTotalEmployeeHasSalary();
    }
}
