using EmployeeManagementSystem.Interfaces;
using EmployeeManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EmployeeManagementSystem.Services
{
    internal class EmployeesService : IEmployees
    {
        public List<Employee> GetEmployees()
        {
            DatabaseDataContext db = new DatabaseDataContext();
            try
            {

                return db.Employees.ToList();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Employee GetEmployeeById(string id)
        {
            DatabaseDataContext db = new DatabaseDataContext();
            try
            {
                return db.Employees.FirstOrDefault(d => d.EmployeeID == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void AddEmployee(Employee employee)
        {
            DatabaseDataContext db = new DatabaseDataContext();
            try
            {
                employee.EmployeeID = Guid.NewGuid().ToString();
                db.Employees.InsertOnSubmit(employee);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpdateEmployee(Employee employee)
        {
            DatabaseDataContext db = new DatabaseDataContext();
            try
            {
                Employee oldEmployee = db.Employees.FirstOrDefault(d => d.EmployeeID == employee.EmployeeID);
                oldEmployee.FirstName = employee.FirstName;
                oldEmployee.LastName = employee.LastName;
                oldEmployee.Gender = employee.Gender;
                oldEmployee.DateOfBirth = employee.DateOfBirth;
                oldEmployee.DepartmentID = employee.DepartmentID;
                oldEmployee.PhoneNumber = employee.PhoneNumber;
                oldEmployee.Email = employee.Email;
                oldEmployee.Address = employee.Address;
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void DeleteEmployee(string id)
        {
            DatabaseDataContext db = new DatabaseDataContext();
            try
            {
                Employee employee = db.Employees.FirstOrDefault(d => d.EmployeeID == id);
                db.Employees.DeleteOnSubmit(employee);
                db.SubmitChanges();
                MessageBox.Show("Xoá nhân viên thành công!");
            }
            catch (Exception)
            {
                MessageBox.Show("Xoá nhân viên thất bại!");
            }
        }

        public (IQueryable Employees, int totalEmployees, int totalPages) GetEmployees(
            string textSearch = null,
            DateTime? dateSearch = null,
            string cbbSearch = null,
            int page = 1,
            int pageSize = 10)
        {
            DatabaseDataContext db = new DatabaseDataContext();
            try
            {
                var employees = db.Employees;
                var positions = db.Positions;
                var departments = db.Departments;

                var query = from e in employees
                            join p in positions on e.PositionID equals p.PositionID
                            join d in departments on e.DepartmentID equals d.DepartmentID
                            select new
                            {
                                e.EmployeeID,
                                e.FirstName,
                                e.LastName,
                                e.Gender,
                                e.DateOfBirth,
                                e.PhoneNumber,
                                e.Email,
                                e.Address,
                                p.PositionID,
                                d.DepartmentID
                            };

                if (!string.IsNullOrEmpty(textSearch))
                {
                    textSearch = textSearch.ToLower();
                    query = query.Where(o =>
                        o.FirstName.ToLower().Contains(textSearch) ||
                        o.LastName.ToLower().Contains(textSearch) ||
                        o.PhoneNumber.Contains(textSearch) ||
                        o.Email.ToLower().Contains(textSearch) ||
                        o.Address.ToLower().Contains(textSearch)
                    );
                }

                if (dateSearch.HasValue)
                {
                    query = query.Where(o => o.DateOfBirth == dateSearch.Value);
                }

                if (!string.IsNullOrEmpty(cbbSearch))
                {
                    query = query.Where(o =>
                        o.DepartmentID == cbbSearch ||
                        o.PositionID == cbbSearch
                    );
                }

                var totalEmployees = query.Count();
                var totalPages = (int)Math.Ceiling((double)totalEmployees / pageSize);

                var Employees = query.Skip((page - 1) * pageSize).Take(pageSize);

                return (Employees, totalEmployees, totalPages);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
