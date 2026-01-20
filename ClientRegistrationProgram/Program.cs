using System;
using System.Windows.Forms;

namespace ClientRegistrationProgram
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            using var login = new LoginForm();
            if (login.ShowDialog() != DialogResult.OK)
            {
                // user cancelled or failed to authenticate
                return;
            }

            var main = new CustomerApp();
            // apply role and signed-in state to main form
            main.ApplyAuth(login.IsAdmin);
            Application.Run(main);
        }
    }
}