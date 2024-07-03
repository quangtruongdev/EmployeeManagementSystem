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

        public LeaveType GetLeaveTypeById(string leaveTypeID)
        {
            try
            {
                var query = _db.LeaveTypes.Where(p => p.LeaveTypeID == leaveTypeID).FirstOrDefault();
                return query;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpdateLeaveType(LeaveType leaveType)
        {
            try
            {
                var query = _db.LeaveTypes.Where(p => p.LeaveTypeID == leaveType.LeaveTypeID).FirstOrDefault();
                if (query != null)
                {
                    query.LeaveTypeName = leaveType.LeaveTypeName;
                    _db.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void DeleteLeaveType(string leaveTypeID)
        {
            try
            {
                var query = _db.LeaveTypes.Where(p => p.LeaveTypeID == leaveTypeID).FirstOrDefault();
                if (query != null)
                {
                    _db.LeaveTypes.DeleteOnSubmit(query);
                    _db.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public (IQueryable<LeaveType> res, int totalLeaveTypes, int totalPages) GetLeaveTypes(int currentPage, int pageSize)
        {
            DatabaseDataContext _db = new DatabaseDataContext();
            try
            {
                var leaveTypes = _db.LeaveTypes;
                int totalLeaveTypes = leaveTypes.Count();
                int totalPages = (int)Math.Ceiling((double)totalLeaveTypes / pageSize);
                var query = leaveTypes.Skip((currentPage - 1) * pageSize).Take(pageSize);
                return (query, totalLeaveTypes, totalPages);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
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

        public IQueryable<dynamic> GetLeaves()
        {
            DatabaseDataContext _db = new DatabaseDataContext();
            try
            {
                var employees = _db.Employees;
                var leaveTypes = _db.LeaveTypes;
                var query = from l in _db.LeaveManagements
                            join e in employees on l.EmployeeID equals e.EmployeeID
                            join lt in leaveTypes on l.LeaveTypeID equals lt.LeaveTypeID
                            select new
                            {
                                l.LeaveID,
                                e.FirstName,
                                l.StartDate,
                                l.EndDate,
                                l.Status,
                                //l.Reason,
                                lt.LeaveTypeName
                            };
                //if (query.Count() > 0) { return query; }

                return query;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public (IQueryable<dynamic> res, int totalLeaves, int totalPages) GetLeaves(int page, int pageSize)
        {
            DatabaseDataContext _db = new DatabaseDataContext();

            try
            {
                var leaves = _db.LeaveManagements;
                int totalLeaves = leaves.Count();
                int totalPages = (int)Math.Ceiling((double)totalLeaves / pageSize);
                var employees = _db.Employees;
                var leaveTypes = _db.LeaveTypes;

                var result = from l in leaves
                             join e in employees
                             on l.EmployeeID equals e.EmployeeID
                             join lt in leaveTypes
                             on l.LeaveTypeID equals lt.LeaveTypeID
                             select new
                             {
                                 l.LeaveID,
                                 e.FirstName,
                                 l.StartDate,
                                 l.EndDate,
                                 l.Status,
                                 l.Reason,
                                 lt.LeaveTypeName
                             };

                var query = result.Skip((page - 1) * pageSize).Take(pageSize);
                return (query, totalLeaves, totalPages);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public (IQueryable<dynamic> res, int totalLeaves, int totalPages) GetLeaves(string name, int page, int pageSize)
        {
            DatabaseDataContext _db = new DatabaseDataContext();
            try
            {
                var leaves = _db.LeaveManagements;
                int totalLeaves = leaves.Count();
                int totalPages = (int)Math.Ceiling((double)totalLeaves / pageSize);
                var employees = _db.Employees;
                var leaveTypes = _db.LeaveTypes;
                var result = from l in leaves
                             join e in employees
                                on l.EmployeeID equals e.EmployeeID
                             join lt in leaveTypes
                             on l.LeaveTypeID equals lt.LeaveTypeID
                             where e.FirstName.Contains(name)
                             select new
                             {
                                 l.LeaveID,
                                 e.FirstName,
                                 l.StartDate,
                                 l.EndDate,
                                 l.Status,
                                 l.Reason,
                                 lt.LeaveTypeName
                             };

                var query = result.Skip((page - 1) * pageSize).Take(pageSize);
                return (query, totalLeaves, totalPages);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public LeaveManagement GetLeaveById(string leaveID)
        {
            try
            {
                var query = _db.LeaveManagements.Where(p => p.LeaveID == leaveID).FirstOrDefault();
                return query;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
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
                    query.Reason = leave.Reason;
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
