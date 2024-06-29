using EmployeeManagementSystem.Interfaces;
using EmployeeManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeManagementSystem.Services
{
    public class DepartmentService : IDepartment
    {
        private DataClasses1DataContext db = new DataClasses1DataContext();

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

        public Department GetDepartmentById(string id)
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
                department.DepartmentID = Guid.NewGuid().ToString();
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

        public void DeleteDepartment(string id)
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

        //public List<Department> SearchDepartment(string search)
        //{
        //    try
        //    {
        //        return db.Departments.Where(d => d.DepartmentName.Contains(search)).ToList();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //}

        // Paging
        public (List<Department> Departments, int totalDepartments, int TotalPages) GetDepartments(int page, int pageSize)
        {
            try
            {
                var totalDepartments = db.Departments.Count();
                var totalPages = (int)Math.Ceiling((double)totalDepartments / pageSize);

                var Departments = db.Departments
                                    .Skip((page - 1) * pageSize)
                                    .Take(pageSize)
                                    .ToList();

                return (Departments, totalDepartments, totalPages);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
