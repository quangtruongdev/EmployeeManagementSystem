using EmployeeManagementSystem.Interfaces;
using EmployeeManagementSystem.Models;
using System;
using System.Linq;

namespace EmployeeManagementSystem.Services
{
    public class LeaveService : ILeaveService
    {
        private readonly DatabaseDataContext _db = new DatabaseDataContext();

        public void AddLeaveType(LeaveType leaveType)
        {
            try
            {
                leaveType.LeaveTypeID = Guid.NewGuid().ToString();
                _db.LeaveTypes.InsertOnSubmit(leaveType);
                _db.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public IQueryable<LeaveType> GetLeaveTypes()
        {
            var query = _db.LeaveTypes.Select(p => p);
            return query;
        }

        public void AddLeave(LeaveManagement leave)
        {
            try
            {
                leave.LeaveID = Guid.NewGuid().ToString();
                _db.LeaveManagements.InsertOnSubmit(leave);
                _db.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public IQueryable<LeaveManagement> GetLeaves()
        {
            var query = _db.LeaveManagements.Select(p => p);
            return query;
        }

        public void UpdateLeave(LeaveManagement leave)
        {
            try
            {
                var query = _db.LeaveManagements.Where(p => p.LeaveID == leave.LeaveID).FirstOrDefault();
                if (query != null)
                {
                    query.EmployeeID = leave.EmployeeID;
                    query.LeaveTypeID = leave.LeaveTypeID;
                    query.StartDate = leave.StartDate;
                    query.EndDate = leave.EndDate;
                    query.Status = leave.Status;
                    //query.Reason = leave.Reason;
                    _db.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void DeleteLeave(string leaveID)
        {
            try
            {
                var query = _db.LeaveManagements.Where(p => p.LeaveID == leaveID).FirstOrDefault();
                if (query != null)
                {
                    _db.LeaveManagements.DeleteOnSubmit(query);
                    _db.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
