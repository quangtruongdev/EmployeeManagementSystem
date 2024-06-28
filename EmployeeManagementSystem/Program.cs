using EmployeeManagementSystem.Forms.Login;
using EmployeeManagementSystem.Interfaces;
using EmployeeManagementSystem.Services;
using EmployeeManagementSystem.Utils;
using EmployeeManagementSystem.Views;
using System;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    internal static class Program
    {
        private static readonly IAuth _authService = new AuthService();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Load session to check if the user is logged in
            SessionManager.LoadSession();

            var user = _authService.GetUserAccount(Session.Username);

            // Check if user is logged in
            if (user != null)
            {
                // Show the main form
                Application.Run(new Main());
            }
            else
            {
                // Show the login form
                Application.Run(new LoginForm());
            }
        }
    }
}
