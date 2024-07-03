using EmployeeManagementSystem.Models;
using System.Linq;

namespace EmployeeManagementSystem.Interfaces
{
    public interface ILeaveService
    {
        void AddLeaveType(LeaveType leaveType);
        IQueryable<LeaveType> GetLeaveTypes();
        (IQueryable<LeaveType> res, int totalLeaveTypes, int totalPages) GetLeaveTypes(int currentPage, int pageSize);
        LeaveType GetLeaveTypeById(string leaveTypeID);
        void UpdateLeaveType(LeaveType leaveType);
        void DeleteLeaveType(string leaveTypeID);
        void AddLeave(LeaveManagement leave);
        IQueryable<dynamic> GetLeaves();
        (IQueryable<dynamic> res, int totalLeaves, int totalPages) GetLeaves(int currentPage, int pageSize);
        (IQueryable<dynamic> res, int totalLeaves, int totalPages) GetLeaves(string name, int currentPage, int pageSize);
        LeaveManagement GetLeaveById(string id);
        void UpdateLeave(LeaveManagement leave);
        void DeleteLeave(string id);
    }
}
