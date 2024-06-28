using EmployeeManagementSystem.Interfaces;
using EmployeeManagementSystem.Models;
using System.Linq;

namespace EmployeeManagementSystem.Services
{
    public class SalaryService : ISalary
    {
        public IQueryable LoadData(string search)
        {
            try
            {
                DatabaseDataContext db = new DatabaseDataContext();

                var employees = db.Employees;
                var salaries = db.Salaries;
                var positions = db.Positions;
                var detail = db.ContactDetails;

                var query = from s in salaries
                            join e in employees on s.EmployeeID equals e.EmployeeID
                            join p in positions on e.PositionID equals p.PositionID
                            join d in detail on e.EmployeeID equals d.EmployeeID
                            select new
                            {
                                e.FirstName,
                                p.PositionName,
                                s.SalaryAmount,
                                d.Email
                            };
                if (search == "")
                {
                    query = query.Where(x => x.FirstName.Contains(search) || x.PositionName.Contains(search) || x.Email.Contains(search));
                }

                return query;
            }
            catch
            {
                return null;
            }
        }
    }
}
