﻿using EmployeeManagementSystem.Interfaces;
using EmployeeManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeManagementSystem.Services
{
    public class SalaryService : ISalary
    {
        public IQueryable LoadData(string search, int page, int pageSize)
        {
            try
            {
                DatabaseDataContext db = new DatabaseDataContext();

                var employees = db.Employees;
                var salaries = db.Salaries;
                var positions = db.Positions;

                var query = from s in salaries
                            join e in employees on s.EmployeeID equals e.EmployeeID
                            join p in positions on e.PositionID equals p.PositionID
                            select new
                            {
                                e.FirstName,
                                p.PositionName,
                                s.SalaryAmount,
                                e.Email
                            };
                if (search != "")
                {
                    query = query.Where(x => x.FirstName.Contains(search) || x.PositionName.Contains(search) || x.Email.Contains(search));
                }


                query = query.Skip((page - 1) * pageSize).Take(pageSize);

                return query;
            }
            catch
            {
                return null;
            }
        }

        public (string email, string name, string posname, string depname, double? salary) GetEmployeebyEmail(string email)
        {
            try
            {
                DatabaseDataContext db = new DatabaseDataContext();

                var tbl_employee = db.Employees;
                var tbl_position = db.Positions;
                var tbl_department = db.Departments;
                var tbl_salary = db.Salaries;

                var query = from emp in tbl_employee
                            join pos in tbl_position on emp.PositionID equals pos.PositionID
                            join dep in tbl_department on emp.DepartmentID equals dep.DepartmentID
                            join sal in tbl_salary on emp.EmployeeID equals sal.EmployeeID
                            where emp.Email == email
                            select new
                            {
                                emp.FirstName,
                                emp.Email,
                                pos.PositionName,
                                dep.DepartmentName,
                                sal.SalaryAmount
                            };

                var result = query.FirstOrDefault();

                if (result != null)
                {
                    string name = result.FirstName;
                    string emailResult = result.Email;
                    string posname = result.PositionName;
                    string depname = result.DepartmentName;
                    var salary = result.SalaryAmount;
                    return (emailResult, name, posname, depname, salary);
                }
                else
                {
                    return (null, null, null, null, 0);
                }
            }
            catch
            {
                // Ghi log lỗi nếu cần thiết
                return (null, null, null, null, 0);
            }
        }


        public List<Position> getListPosition()
        {
            DatabaseDataContext db = new DatabaseDataContext();
            return db.Positions.ToList();
        }

        public List<Department> getListDepartment()
        {
            DatabaseDataContext db = new DatabaseDataContext();
            return db.Departments.ToList();
        }


        public void addSalary(string email, double? salaryAmount)
        {
            try
            {
                DatabaseDataContext db = new DatabaseDataContext();
                var tbl_employee = db.Employees;
                var query = from emp in tbl_employee
                            where emp.Email == email
                            select new
                            {
                                emp.EmployeeID
                            };

                var s = new
                {
                    SalaryID = Guid.NewGuid().ToString(),
                    EmployeeID = query.FirstOrDefault().EmployeeID,
                    SalaryAmount = salaryAmount,

                };

                db.Salaries.InsertOnSubmit(new Salary
                {
                    SalaryID = s.SalaryID,
                    EmployeeID = s.EmployeeID,
                    SalaryAmount = s.SalaryAmount
                });

                db.SubmitChanges();

            }
            catch
            {
                // Ghi log lỗi nếu cần thiết
            }
        }
        public void updateSalary(string email, string salaryAmount)
        {
            try
            {
                DatabaseDataContext db = new DatabaseDataContext();
                var tbl_employee = db.Employees;
                var tbl_salary = db.Salaries;

                var query = from emp in tbl_employee
                            join salary in tbl_salary on emp.EmployeeID equals salary.EmployeeID
                            where emp.Email == email
                            select new
                            {
                                emp.EmployeeID,
                                salary.SalaryAmount,
                                salary.SalaryID
                            };

                var result = query.FirstOrDefault();
                var qr_sal = db.Salaries.Where(x => x.SalaryID == result.SalaryID).FirstOrDefault();
                qr_sal.SalaryAmount = float.Parse(salaryAmount);
                db.SubmitChanges();

            }
            catch
            {
                // Ghi log lỗi nếu cần thiết
            }
        }

        public void Payment(string email)
        {
            try
            {
                DatabaseDataContext db = new DatabaseDataContext();
                var tbl_employee = db.Employees;
                var tbl_salary = db.Salaries;

                var query = from emp in tbl_employee
                            join salary in tbl_salary on emp.EmployeeID equals salary.EmployeeID
                            where emp.Email == email
                            select new
                            {
                                salary.SalaryID
                            };

                var result = query.FirstOrDefault();
                var qr_sal = db.Salaries.Where(x => x.SalaryID == result.SalaryID).FirstOrDefault();
                db.Salaries.DeleteOnSubmit(qr_sal);
                db.SubmitChanges();

            }
            catch
            {
                // Ghi log lỗi nếu cần thiết
            }
        }

        public IQueryable loadEmployee(string search, int pageSize)
        {
            try
            {
                DatabaseDataContext db = new DatabaseDataContext();

                var employees = db.Employees;
                var positions = db.Positions;
                var departments = db.Departments;
                var salaries = db.Salaries;

                var query = from e in employees
                            join p in positions on e.PositionID equals p.PositionID
                            join dep in departments on e.DepartmentID equals dep.DepartmentID
                            join s in salaries on e.EmployeeID equals s.EmployeeID into empSalaries
                            from empSalary in empSalaries.DefaultIfEmpty()
                            where empSalary == null
                            select new
                            {
                                e.FirstName,
                                e.LastName,
                                p.PositionName,
                                e.Email,
                                dep.DepartmentName
                            };

                if (!string.IsNullOrEmpty(search))
                {
                    query = query.Where(x => x.FirstName.Contains(search) || x.PositionName.Contains(search) || x.Email.Contains(search));
                }

                query = query.Take(pageSize);

                return query;

            }
            catch
            {
                return null;
            }
        }

        public int getTotalEmployeeHasSalary()
        {
            try
            {
                DatabaseDataContext db = new DatabaseDataContext();
                return db.Salaries.Count();
            }
            catch
            {
                return 0;
            }
        }
    }
}
