using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;
            DateTime dob = dateTimePickerDOB.Value;
            string rememberText = txtRemember.Text;

            // Validation
            if (string.IsNullOrWhiteSpace(username) || 
                string.IsNullOrWhiteSpace(password) || 
                string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("All fields are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Regex.IsMatch(password, "^(?=.*[a-zA-Z])(?=.*\\d).{6,}$"))
            {
                MessageBox.Show("Password must be alphanumeric and at least 6 characters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
