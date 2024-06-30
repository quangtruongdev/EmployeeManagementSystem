using EmployeeManagementSystem.Interfaces;
using EmployeeManagementSystem.Models;
using System;

namespace EmployeeManagementSystem.Services
{
    public class LeaveService : ILeaveService
    {
        private readonly DatabaseDataContext _db = new DatabaseDataContext();

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
    }
}
