namespace EmployeeManagementSystem.Utils
{
    public class Session
    {
        public static string UserID { get; set; }
        public static string Username { get; set; }
        public static string Role { get; set; }
        public static bool IsLoggedIn { get; set; }

        public static void Clear()
        {
            UserID = null;
            Username = null;
            Role = null;
            IsLoggedIn = false;
        }
    }
}
