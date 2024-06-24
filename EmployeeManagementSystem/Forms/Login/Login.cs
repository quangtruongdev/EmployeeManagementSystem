using EmployeeManagementSystem.Models;
using System.Windows.Forms;

namespace EmployeeManagementSystem.Forms.Login
{
    public partial class Login : Form
    {
        private DatabaseDataContext db = new DatabaseDataContext();
        public Login()
        {
            InitializeComponent();
        }

        private void Btn_Login_Click(object sender, System.EventArgs e)
        {
            string username = UsernameInput.Text.Trim();
            string password = PasswordInput.Text.Trim();
        }
    }
}
