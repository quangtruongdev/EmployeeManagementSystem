using EmployeeManagementSystem.Interfaces;
using EmployeeManagementSystem.Models;
using EmployeeManagementSystem.Services;
using System.Windows.Forms;

namespace EmployeeManagementSystem.Forms.Register
{
    public partial class RegisterForm : Form
    {
        private readonly IAuth _authService;
        public RegisterForm()
        {
            InitializeComponent();
            _authService = new AuthService();
            UsernameInput.TextChanged += Input_TextChanged;
            PasswordInput.TextChanged += Input_TextChanged;
            ConfirmPasswordInput.TextChanged += Input_TextChanged;
        }

        private void Input_TextChanged(object sender, System.EventArgs e)
        {
            ValidateForm();
        }

        private bool ValidateForm()
        {
            bool isFormValid = true;

            // Validate Username
            if (string.IsNullOrEmpty(UsernameInput.Text.Trim()))
            {
                UsernameError.Text = "Username is required";
                isFormValid = false;
            }
            else
            {
                UsernameError.Text = string.Empty;
            }

            // Validate Password
            if (string.IsNullOrEmpty(PasswordInput.Text.Trim()))
            {
                PasswordError.Text = "Password is required";
                isFormValid = false;
            }
            else if (PasswordInput.Text.Length < 6)
            {
                PasswordError.Text = "Password must be at least 6 characters";
                isFormValid = false;
            }
            else
            {
                PasswordError.Text = string.Empty;
            }

            // Validate Confirm Password
            if (string.IsNullOrEmpty(ConfirmPasswordInput.Text.Trim()))
            {
                ConfirmPasswordError.Text = "Confirm password is required";
                isFormValid = false;
            }
            else if (ConfirmPasswordInput.Text != PasswordInput.Text)
            {
                ConfirmPasswordError.Text = "Passwords do not match";
                isFormValid = false;
            }
            else
            {
                ConfirmPasswordError.Text = string.Empty;
            }

            // Enable or Disable Register Button
            Btn_Register.Enabled = isFormValid;
            return isFormValid;
        }

        private void Btn_Register_Click(object sender, System.EventArgs e)
        {
            string username = UsernameInput.Text.Trim();
            string password = PasswordInput.Text.Trim();

            try
            {
                if (ValidateForm())
                {
                    var user = new UserAccount
                    {
                        Username = username,
                        PasswordHash = password,
                    };

                    _authService.Register(user);
                    MessageBox.Show("Registration successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Login.LoginForm login = new Login.LoginForm();
                    login.Show();
                    this.Hide();
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Link_Login_Click(object sender, System.EventArgs e)
        {
            Login.LoginForm login = new Login.LoginForm();
            login.Show();
            this.Hide();
        }

        private void RegisterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
