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
        private DataClasses2DataContext db = new DataClasses2DataContext();

        public List<Employee> GetEmployees()
        {
            try
            {
                using (var db = new DataClasses2DataContext())
                {
                    return db.Employees.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Employee GetEmployeeById(string id)
        {
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

        public (List<Employee> Employees, int totalEmployees, int TotalPages) GetEmployees(string search, int page, int pageSize)
        {
            try
            {
                using (var db = new DataClasses2DataContext())
                {
                    var query = db.Employees.AsQueryable();

                    if (!string.IsNullOrEmpty(search))
                    {
                        search = search.ToLower();
                        query = query.Where(o =>
                            o.FirstName.ToLower().Contains(search) ||
                            o.LastName.ToLower().Contains(search) ||
                            o.PhoneNumber.Contains(search) ||
                            o.Email.ToLower().Contains(search) ||
                            o.Address.ToLower().Contains(search)
                        );
                    }

                    var totalEmployees = query.Count();
                    var totalPages = (int)Math.Ceiling((double)totalEmployees / pageSize);

                    var Employees = query.Skip((page - 1) * pageSize).Take(pageSize).ToList();

                    return (Employees, totalEmployees, totalPages);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public (List<Employee> Employees, int totalEmployees, int TotalPages) GetEmployeesDate(DateTime search, int page, int pageSize)
        {

            try
            {

                using (var db = new DataClasses2DataContext())
                {
                    var query = db.Employees.AsQueryable();
                    if (search != null)
                    {
                        query = query.Where(o =>
                            o.DateOfBirth == search);
                    }
                    var totalEmployees = query.Count();
                    var totalPages = (int)Math.Ceiling((double)totalEmployees / pageSize);

                    var Employees = query.Skip((page - 1) * pageSize).Take(pageSize).ToList();

                    return (Employees, totalEmployees, totalPages);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }

        public (List<Employee> Employees, int totalEmployees, int TotalPages) GetEmployeesDepartment(string search, int page, int pageSize)
        {
            try
            {
                using (var db = new DataClasses2DataContext())
                {
                    var query = db.Employees.AsQueryable();

                    if (search != null)
                    {
                        query = query.Where(o =>
                            o.DepartmentID == search ||
                            o.PositionID == search
                        );
                    }

                    var totalEmployees = query.Count();
                    var totalPages = (int)Math.Ceiling((double)totalEmployees / pageSize);

                    var Employees = query.Skip((page - 1) * pageSize).Take(pageSize).ToList();

                    return (Employees, totalEmployees, totalPages);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
