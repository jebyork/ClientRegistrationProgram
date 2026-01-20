using System;
using System.Windows.Forms;

namespace ClientRegistrationProgram
{
    public partial class LoginForm : Form
    {
        // Exposed after success
        public bool IsAdmin { get; private set; }

        public LoginForm()
        {
            InitializeComponent();
        }

        // Register button handler (button1)
        private void button1_Click(object sender, EventArgs e)
        {
            var email = textBox1.Text.Trim();
            var password = textBox2.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show(this, "Email and password are required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (AuthService.EmailExists(email))
            {
                MessageBox.Show(this, "Email already registered. Please use Login.", "Register", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var asAdmin = MessageBox.Show(this, "Register as Admin? (Yes = Admin, No = Staff)", "Choose Role", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
            var success = AuthService.Register(email, password, asAdmin ? "Admin" : "Staff");
            if (!success)
            {
                MessageBox.Show(this, "Registration failed.", "Register", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show(this, "Registered and logged in.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            IsAdmin = asAdmin;
            DialogResult = DialogResult.OK;
            Close();
        }

        // Login button handler (btnLogin)
        private void btnLogin_Click(object sender, EventArgs e)
        {
            var email = textBox1.Text.Trim();
            var password = textBox2.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show(this, "Email and password are required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var role = AuthService.Authenticate(email, password);
            if (role != null)
            {
                IsAdmin = string.Equals(role, "Admin", StringComparison.OrdinalIgnoreCase);
                DialogResult = DialogResult.OK;
                Close();
                return;
            }

            // If email exists but password wrong, give a helpful message.
            if (AuthService.EmailExists(email))
            {
                MessageBox.Show(this, "Incorrect password.", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Email not found -> offer registration shortcut
            var registerNow = MessageBox.Show(this, "Email not registered. Register now?", "Not found", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (registerNow == DialogResult.Yes)
            {
                // Transfer to register flow (reuse button1 logic)
                button1_Click(sender, e);
            }
        }
    }
}
