using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ClientRegistrationProgram
{
    public static class UserStore
    {
        public static string Username { get; set; }
        public static string Password { get; set; }
        public static string Role { get; set; }
    }

    public partial class LoginRegistration : Form
    {
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnLogin;

        private void btnRegister_Click(object sender, EventArgs e)
        {
            UserStore.Username = txtUsername.Text;
            UserStore.Password = txtPassword.Text;
            UserStore.Role = "User"; // Default role
            MessageBox.Show("Registration successful!");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Login logic...
            if (txtUsername.Text == UserStore.Username && txtPassword.Text == UserStore.Password)
            {
                MessageBox.Show($"Login successful! Role: {UserStore.Role}");
            }
            else
            {
                MessageBox.Show("Invalid credentials.");
            }
            this.Hide();
        }

        internal string GetPasswordHash(string samplePassword)
        {
            throw new NotImplementedException();
        }
    }
}