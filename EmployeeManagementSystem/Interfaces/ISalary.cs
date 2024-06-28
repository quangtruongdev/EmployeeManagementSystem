using System.Linq;

namespace EmployeeManagementSystem.Interfaces
{
    public interface ISalary
    {
        IQueryable LoadData(string search);
    }
}
