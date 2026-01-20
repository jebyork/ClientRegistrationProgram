using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientRegistrationProgram
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }
        internal static void show()
        {
            throw new NotImplementedException();
        }

        private void buttonreg2_Click(object sender, EventArgs e)
        {
            CustomerApp registrationForm = new CustomerApp();
            registrationForm.Show();
            this.Hide();
        }
    }
}
