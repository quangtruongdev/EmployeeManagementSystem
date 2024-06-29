using Newtonsoft.Json;
using System.IO;

namespace EmployeeManagementSystem.Utils
{
    public class SessionManager
    {
        private static readonly string SessionDirectory = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData), "EmployeeManagementSystem");
        private static readonly string SessionFilePath = Path.Combine(SessionDirectory, "session.json");
        // <Users>/<username>/AppData/Roaming/EmployeeManagementSystem

        public static void SaveSession()
        {
            var sessionData = new
            {
                Session.UserID,
                Session.Username,
                Session.Role,
                Session.IsLoggedIn,
            };

            var sessionJson = JsonConvert.SerializeObject(sessionData, Formatting.Indented);

            // Ensure the directory exists
            if (!Directory.Exists(SessionDirectory))
            {
                Directory.CreateDirectory(SessionDirectory);
            }

            File.WriteAllText(SessionFilePath, sessionJson);
        }

        public static void LoadSession()
        {
            if (File.Exists(SessionFilePath))
            {
                var sessionJson = File.ReadAllText(SessionFilePath);
                var sessionData = JsonConvert.DeserializeObject<dynamic>(sessionJson);

                Session.UserID = sessionData.UserID;
                Session.Username = sessionData.Username;
                Session.Role = sessionData.Role;
                Session.IsLoggedIn = sessionData.IsLoggedIn;
            }
        }

        public static void ClearSession()
        {
            if (File.Exists(SessionFilePath))
            {
                File.Delete(SessionFilePath);

            }
            Session.Clear();
        }
    }
}
