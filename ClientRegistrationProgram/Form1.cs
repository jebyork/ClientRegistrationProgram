using System.ComponentModel;
using System.Windows.Forms;

namespace ClientRegistrationProgram
{
    public partial class CustomerApp : Form
    {

        ClientDataManager _clientManager;

        public CustomerApp()
        {
            InitializeComponent();
            _clientManager = new ClientDataManager(CustomerDataGridView);
            _clientManager.SetupDataGrid();
            _clientManager.ChangeAdminState(AdminCheckBox.Checked);
            _clientManager.ChangeSignedInState(SignedInCheckBocx.Checked);
            ClientDatabase.Init();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var client = new ClientData
            {
                Name = NameInputTxt.Text,
                Address = AddressInputTxt.Text,
                PhoneNumber = NumberInputTxt.Text,
                Email = EmailInputTxt.Text,
                Software = SoftwareAddCheckBox.Checked,
                Computers = ComputersAddCheckBox.Checked,
                Games = GamesAddCheckBox.Checked,
                OfficeTools = OfficeToolsAddCheckBox.Checked,
                Accessories = AccessoriesAddCheckBox.Checked
            };

            bool success = _clientManager.TryAddClient(client);

            if (success) 
            {
                ClearInputs();
            }
        }

        private void AdminCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _clientManager.ChangeAdminState(AdminCheckBox.Checked);
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            _clientManager.TryRemoveClient(CustomerDataGridView.SelectedRows);
        }

        private void SignedInCheckBocx_CheckedChanged(object sender, EventArgs e)
        {
            _clientManager.ChangeSignedInState(SignedInCheckBocx.Checked);
        }

        private void CustomerDataGridView_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (!SignedInCheckBocx.Checked || !AdminCheckBox.Checked)
                return;

            var row = CustomerDataGridView.Rows[e.RowIndex];
            if (row.DataBoundItem is ClientData client)
            {
                _clientManager.TrySaveClientChanges(client);
            }
        }


        /// <summary>
        /// Clears all client input data sections
        /// </summary>
        private void ClearInputs() {
            NameInputTxt.Clear();
            AddressInputTxt.Clear();
            NumberInputTxt.Clear();
            EmailInputTxt.Clear();
            SoftwareAddCheckBox.Checked = false;
            ComputersAddCheckBox.Checked = false;
            GamesAddCheckBox.Checked = false;
            OfficeToolsAddCheckBox.Checked = false;
            AccessoriesAddCheckBox.Checked = false;
        }
    }
}
