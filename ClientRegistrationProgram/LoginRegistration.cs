using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace ClientRegistrationProgram
{
    public static class AuthService
    {
        private static readonly List<string> Emails = new List<string>(StringComparer.OrdinalIgnoreCase);
        private static readonly List<string> Hashes = new List<string>();
        private static readonly List<string> Roles = new List<string>(); // "Admin" or "Staff"

        public static bool EmailExists(string email) =>
            !string.IsNullOrWhiteSpace(email) && Emails.Exists(e => string.Equals(e, email.Trim(), StringComparison.OrdinalIgnoreCase));

        public static bool Register(string email, string password, string role)
        {
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrEmpty(password)) return false;
            email = email.Trim();
            if (EmailExists(email)) return false;

            Emails.Add(email);
            Hashes.Add(Hash(password));
            Roles.Add(role ?? "Staff");
            return true;
        }

        // returns role string when success, null when not found or wrong password
        public static string? Authenticate(string email, string password)
        {
            if (string.IsNullOrWhiteSpace(email)) return null;
            email = email.Trim();
            int idx = Emails.FindIndex(e => string.Equals(e, email, StringComparison.OrdinalIgnoreCase));
            if (idx < 0) return null;
            if (Hashes[idx] != Hash(password)) return null;
            return Roles[idx];
        }

        public static string Hash(string? text)
        {
            using var sha = SHA256.Create();
            byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(text ?? string.Empty));
            return Convert.ToBase64String(bytes);
        }
    }

    public static class UserStore
    {
        public static string Username;
        public static string Password;
        public static string Role; // "Admin" or "Staff"
    }
    class RegistrationLogin
    {
        static List<string> usernames = new List<string>();
        static List<string> passwords = new List<string>();
        static List<string> userTypes = new List<string>();
    }

    namespace ClientRegistrationProgram
    {
        public partial class LoginForm : Form
        {
            public bool IsAdmin { get; private set; }

            // Hook this to your login button (create a Login button in the designer if you don't have one)
            private void loginButton_Click(object sender, EventArgs e)
            {
                var email = textBox1.Text.Trim();
                var password = textBox2.Text;


                if (!string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(password))
                {
                    // set IsAdmin based on your auth result or a checkbox on the form
                    IsAdmin = false; // or true when admin
                    DialogResult = DialogResult.OK; // this closes the dialog and returns OK to Program.Main
                }
                else
                {
                    MessageBox.Show(this, "Enter email and password.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}