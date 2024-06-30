using EmployeeManagementSystem.Interfaces;
using EmployeeManagementSystem.Models;
using System;
using System.Linq;

namespace EmployeeManagementSystem.Services
{
    public class AuthService : IAuth
    {
        private DatabaseDataContext db = new DatabaseDataContext();
        public UserAccount Login(UserAccount user)
        {
            try
            {
                var existingUser = db.UserAccounts.SingleOrDefault(u => u.Username == user.Username && u.PasswordHash == user.PasswordHash);
                if (existingUser == null)
                {
                    throw new Exception("Invalid username or password");
                }
                return existingUser;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Register(UserAccount user)
        {
            try
            {
                var existingUser = db.UserAccounts.SingleOrDefault(u => u.Username == user.Username);

                if (existingUser != null)
                {
                    throw new Exception("Username already exists");
                }

                user.UserID = Guid.NewGuid().ToString();
                db.UserAccounts.InsertOnSubmit(user);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }

        public UserAccount GetUserAccount(string username)
        {
            try
            {
                var user = db.UserAccounts.SingleOrDefault(u => u.Username == username);
                return user;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
