using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ClientRegistrationProgram
{
    public class ClientDataManager
    {
        private BindingList<ClientData> _clients = new BindingList<ClientData>();
        private DataGridView DataGrid;

        private bool _IsAdmin = false;
        private bool _IsSignedIn = false;

        public ClientDataManager(DataGridView dataGridView) 
        {
            DataGrid = dataGridView;
            var clientsFromDB = ClientDatabase.LoadAllClients();
            _clients = new BindingList<ClientData>(clientsFromDB);
        }

        /// <summary>
        /// Trys to add a new client to the list of clients
        /// </summary>
        /// <param name="client">client with all corresponding data</param>
        /// <returns>True if client was added successfuly false if not</returns>
        public bool TryAddClient(ClientData client)
        {
            if (!CanAddClient(client))
                return false;

            long newId = ClientDatabase.InsertClient(client);
            client.SetID((int)newId);
            _clients.Add(client);
            return true;
        }

        /// <summary>
        /// Sets up all the collums for the data grid
        /// </summary>
        public void SetupDataGrid()
        {
            if (DataGrid == null)
                return;

            DataGrid.AutoGenerateColumns = false;
            DataGrid.DataSource = _clients;
            DataGrid.Columns.Clear();

            DataGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Client ID",
                DataPropertyName = "ID",
                ReadOnly = true,
            });

            DataGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Name",
                DataPropertyName = "Name",
            });

            DataGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Address",
                DataPropertyName = "Address",
            });

            DataGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Phone Number",
                DataPropertyName = "PhoneNumber",
            });

            DataGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Email",
                DataPropertyName = "Email",
            });

            DataGrid.Columns.Add(new DataGridViewCheckBoxColumn
            {
                HeaderText = "Software",
                DataPropertyName = "Software",
            });

            DataGrid.Columns.Add(new DataGridViewCheckBoxColumn
            {
                HeaderText = "Computers",
                DataPropertyName = "Computers",
            });

            DataGrid.Columns.Add(new DataGridViewCheckBoxColumn
            {
                HeaderText = "Games",
                DataPropertyName = "Games",
            });

            DataGrid.Columns.Add(new DataGridViewCheckBoxColumn
            {
                HeaderText = "Office Tools",
                DataPropertyName = "OfficeTools",
            });

            DataGrid.Columns.Add(new DataGridViewCheckBoxColumn
            {
                HeaderText = "Accessories",
                DataPropertyName = "Accessories",
            });

            DataGrid.AllowUserToAddRows = false;
            DataGrid.RowHeadersVisible = false;
            DataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        /// <summary>
        /// Sets the  Admin state of the client managers
        /// </summary>
        /// <param name="isAdmin">Value to set the admin state to</param>
        public void ChangeAdminState(bool isAdmin) 
        {
            _IsAdmin = isAdmin;
            DataGrid.ReadOnly = !_IsAdmin;
        }

        /// <summary>
        /// Sets the  Signed In state of the client managers
        /// </summary>
        /// <param name="isSignedIn">Value to set the IsSigned in state to</param>
        public void ChangeSignedInState(bool isSignedIn) 
        {
            _IsSignedIn = isSignedIn;
        }

        /// <summary>
        /// Trys to remove all currently selected rows in grid
        /// </summary>
        /// <param name="selectedRows">The rows that are sellected in the data grid</param>
        public void TryRemoveClient(DataGridViewSelectedRowCollection selectedRows) 
        {
            if (!CanRemoveClient(selectedRows))
                return;

            DialogResult result = MessageBox.Show(
                "Are you sure you want to remove the selected clients?",
                "Confirm Remove",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning );

            if (result != DialogResult.Yes)
                return;

            List<ClientData> toRemove = new List<ClientData>();
            foreach (DataGridViewRow row in selectedRows)
            { 
                if(row.DataBoundItem is ClientData client) {
                    toRemove.Add(client);
                }
            }

            foreach (ClientData client in toRemove)
            {
                ClientDatabase.DeleteClient(client.ID);
                _clients.Remove(client);
            }
        }

        public void TrySaveClientChanges(ClientData clientData)
        {
            if (!CanUpdateClient())
                return;
                
            ClientDatabase.UpdateClient(clientData);
        }


        /// <summary>
        /// Checks if the current user can add a new client at this time and creates necersary pop ups if not
        /// </summary>
        /// <param name="client">Client data that is trying to be added</param>
        /// <returns>True if a client can be added</returns>
        private bool CanAddClient(ClientData client) 
        {
            if (!_IsSignedIn)
            {
                MessageBox.Show("Please sign in to add Client",
                    "Cannot Add", 
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(client.Address) || string.IsNullOrEmpty(client.Email) || 
                    string.IsNullOrEmpty(client.Name) || string.IsNullOrEmpty(client.PhoneNumber)) 
            {
                MessageBox.Show("Insufficient client data added",
                    "Cannot Add",
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        /// <summary>
        /// Checks if the current user can remove a current client at this time and creates necersary pop ups if not
        /// </summary>
        /// <param name="selectedRows">Collection of all rows that are selected in data grid</param>
        /// <returns>True if a client or clients can be removed</returns>
        private bool CanRemoveClient(DataGridViewSelectedRowCollection selectedRows)
        {
            if(selectedRows.Count == 0) {
                MessageBox.Show("No client selected", 
                    "Cannot Remove", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
                return false;
            }

            if (!_IsSignedIn) {
                MessageBox.Show("Please sign in to remove Client", 
                    "Cannot Remove",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

            if (!_IsAdmin)
            {
                MessageBox.Show("Dont have permissions to remove client", 
                    "Cannot Remove", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool CanUpdateClient()
        {
            if (!_IsSignedIn)
            {
                MessageBox.Show("Please sign in to Update Client",
                    "Cannot Update",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

            if (!_IsAdmin)
            {
                MessageBox.Show("Dont have permissions to Update client",
                    "Cannot Update",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public void FilterDataGrid(Filters filters)
        {
            if (DataGrid == null)
                return;

            BindingList<ClientData> filtered = new BindingList<ClientData>(
                _clients.Where(
                    client =>
                        client.Name.Contains(filters.Name) &&
                        client.Email.Contains(filters.Email)
                ).ToList()
            );
            DataGrid.DataSource = filtered;
        }
    }
}
