using EmployeeManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EmployeeManagementSystem.Services
{
    internal class EmployeesService
    {
        private DataClasses1DataContext db = new DataClasses1DataContext();

        public List<Employee> GetEmployees()
        {
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
                oldEmployee.HireDate = employee.HireDate;
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
    }
}
