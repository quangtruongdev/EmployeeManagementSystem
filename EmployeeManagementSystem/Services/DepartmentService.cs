using EmployeeManagementSystem.Interfaces;
using EmployeeManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeManagementSystem.Services
{
    public class DepartmentService : IDepartment
    {
        private DatabaseDataContext db = new DatabaseDataContext();

        public List<Department> GetDepartments()
        {
            try
            {
                return db.Departments.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Department GetDepartmentById(int id)
        {
            try
            {
                return db.Departments.FirstOrDefault(d => d.DepartmentID == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void AddDepartment(Department department)
        {
            try
            {
                //department.DepartmentID = Guid.NewGuid().ToString();
                db.Departments.InsertOnSubmit(department);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpdateDepartment(Department department)
        {
            try
            {
                Department oldDepartment = db.Departments.FirstOrDefault(d => d.DepartmentID == department.DepartmentID);
                oldDepartment.DepartmentName = department.DepartmentName;
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void DeleteDepartment(int id)
        {
            try
            {
                Department department = db.Departments.FirstOrDefault(d => d.DepartmentID == id);
                db.Departments.DeleteOnSubmit(department);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
