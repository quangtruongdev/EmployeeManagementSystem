using EmployeeManagementSystem.Models;
using System.Linq;

namespace EmployeeManagementSystem.Interfaces
{
    public interface ILeaveService
    {
        void AddLeaveType(LeaveType leaveType);
        IQueryable<LeaveType> GetLeaveTypes();
        void AddLeave(LeaveManagement leave);
        IQueryable<LeaveManagement> GetLeaves();
        void UpdateLeave(LeaveManagement leave);
        void DeleteLeave(string id);
    }
}
