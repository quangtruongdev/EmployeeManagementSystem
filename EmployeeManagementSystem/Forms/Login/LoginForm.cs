using EmployeeManagementSystem.Interfaces;
using EmployeeManagementSystem.Services;
using EmployeeManagementSystem.Views;
using System;
using System.Windows.Forms;

namespace EmployeeManagementSystem.Forms.Login
{
    public partial class LoginForm : Form
    {
        private readonly IAuth _authService;

        public LoginForm()
        {
            InitializeComponent();
            _authService = new AuthService();
            UsernameInput.TextChanged += Input_TextChanged;
            PasswordInput.TextChanged += Input_TextChanged;
            //Btn_Login.Click += Btn_Login_Click;
            //Link_Register.Click += Link_Register_Click;
        }

        private void Input_TextChanged(object sender, System.EventArgs e)
        {
            ValidateForm();
        }

        private void ValidateForm()
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
            else if (PasswordInput.Text.Trim().Length < 6)
            {
                PasswordError.Text = "Password must be at least 6 characters";
                isFormValid = false;
            }
            else
            {
                PasswordError.Text = string.Empty;
            }

            // Enable or Disable Login Button
            Btn_Login.Enabled = isFormValid;

        }

        private void Btn_Login_Click(object sender, System.EventArgs e)
        {
            //string username = UsernameInput.Text.Trim();
            //string password = PasswordInput.Text.Trim();

            //try
            //{
            //    var user = new UserAccount
            //    {
            //        Username = username,
            //        Password = password
            //    };

            //    var existingUser = _authService.Login(user);

            //    if (existingUser == null)
            //    {
            //        MessageBox.Show("Invalid username or password");
            //    }
            //    else
            //    {
            //        if (RememberMe.Checked)
            //        {
            //            Session.UserID = existingUser.UserID;
            //            Session.Username = existingUser.Username;
            //            Session.IsLoggedIn = true;
            //        }
            //        else
            //        {
            //            Session.Username = string.Empty;
            //        }
            //        Main main = new Main();
            //        main.Show();
            //        this.Hide();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"An error occurred: {ex.Message}");
            //}

            Main main = new Main();
            main.Show();
            this.Hide();
        }

        private void Link_Register_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    RegisterForm register = new RegisterForm();
            //    register.Show();
            //    this.Hide();
            //    MessageBox.Show("This feature is not available in this version");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"An error occurred: {ex.Message}");
            //}
        }
    }
}