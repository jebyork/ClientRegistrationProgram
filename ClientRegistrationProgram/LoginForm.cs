using System;
using System.Windows.Forms;

namespace ClientRegistrationProgram
{
    public partial class LoginForm : Form
    {
        public bool IsAdmin { get; private set; }
        public IAuthService AuthService { get; private set; }

        public LoginForm(IAuthService authService)
        {
            InitializeComponent();
            AuthService = authService ?? throw new ArgumentNullException(nameof(authService));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var email = txtEmail.Text.Trim();
            var password = txtPassword.Text;

            if (!string.IsNullOrWhiteSpace(email) && AuthService.EmailExists(email))
            {
                MessageBox.Show(this, "Email already registered. Please use Login.", "Register", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var registrationForm = new RegistrationForm();
            registrationForm.ShowDialog();

            return;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var email = txtEmail.Text.Trim();
            var password = txtPassword.Text;

            if (!string.IsNullOrWhiteSpace(email) && !string.IsNullOrEmpty(password))
            {
                if (AuthService.EmailExists(email))
                {
                    MessageBox.Show(this, "Incorrect password.", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Hide();
                using (var form1 = new CustomerApp())
                {
                    form1.ShowDialog();
                }
                Close();
            }
            else
            {
                MessageBox.Show(this, "Email and password are required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var registrationForm = new RegistrationForm();
            registrationForm.ShowDialog();
            this.Hide();
        }

        private void buttonreg2_Click(object sender, EventArgs e)
        {
            var registrationForm = new CustomerApp();
            registrationForm.ShowDialog();
            this.Hide();
        }
    }
}
