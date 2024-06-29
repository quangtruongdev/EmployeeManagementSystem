using EmployeeManagementSystem.Models;

namespace EmployeeManagementSystem.Interfaces
{
    public interface IAuth
    {
        UserAccount Login(UserAccount user);
        void Register(UserAccount user);
        UserAccount GetUserAccount(string username);
    }
}
