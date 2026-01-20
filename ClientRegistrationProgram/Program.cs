using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace ClientRegistrationProgram
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            IAuthService authService = new AuthService(); 

            using var login = new LoginForm(authService);
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

    internal class AuthService : IAuthService
    {
        public bool EmailExists(object email)
        {
            throw new NotImplementedException();
        }

        public bool Register(object email, object password, string v)
        {
            throw new NotImplementedException();
        }
    }
}