using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;

namespace ClientRegistrationProgram
{
    public static class ClientDatabase
    {
        private static string CLIEN_DB_FILE = "Clients.sqlite";
        private static string CLIENT_DATA_SOURCE = "Data Source=Clients.sqlite";

        public static void Init() 
        {
            if(!File.Exists(CLIEN_DB_FILE)) {
                using (var connection = new SqliteConnection(CLIENT_DATA_SOURCE))
                {
                    connection.Open();
                    string createTableQuery = @"
                        CREATE TABLE IF NOT EXISTS Clients (
                        ID INTEGER PRIMARY KEY AUTOINCREMENT,
                        Name TEXT NOT NULL,
                        Address TEXT NOT NULL,
                        Phone TEXT NOT NULL,
                        Email TEXT NOT NULL,
                        Software INTEGER,
                        Computers INTEGER,
                        Games INTEGER,
                        OfficeTools INTEGER,
                        Accessories INTEGER);";

                    using(var command = new SqliteCommand(createTableQuery, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
            }
        }

        public static List<ClientData> LoadAllClients()
        {
            List<ClientData> clients = new List<ClientData>();

            using (var connection = new SqliteConnection(CLIENT_DATA_SOURCE))
            {
                connection.Open();

                string query = @"
                    SELECT 
                    ID, Name, Address, Phone, Email, Software, Computers, Games, OfficeTools, Accessories
                    FROM Clients";

                using (var command = new SqliteCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ClientData client = new ClientData();

                        client.SetID(!reader.IsDBNull(0) ? reader.GetInt32(0) : 0);
                        client.Name = !reader.IsDBNull(1) ? reader.GetString(1) : "";
                        client.Address = !reader.IsDBNull(2) ? reader.GetString(2) : "";
                        client.PhoneNumber = !reader.IsDBNull(3) ? reader.GetString(3) : "";
                        client.Email = !reader.IsDBNull(4) ? reader.GetString(4) : "";
                        client.Software = !reader.IsDBNull(5) && reader.GetInt32(5) == 1;
                        client.Computers = !reader.IsDBNull(6) && reader.GetInt32(6) == 1;
                        client.Games = !reader.IsDBNull(7) && reader.GetInt32(7) == 1;
                        client.OfficeTools = !reader.IsDBNull(8) && reader.GetInt32(8) == 1;
                        client.Accessories = !reader.IsDBNull(9) && reader.GetInt32(9) == 1;

                        clients.Add(client);
                    }
                }
            }

            return clients;
        }

        public static long InsertClient(ClientData clientData)
        {
            using(var connection = new SqliteConnection(CLIENT_DATA_SOURCE)) 
            {
                connection.Open();
                string insertQuery = @"INSERT INTO Clients 
                    (Name, Address, Phone, Email, Software, Computers, Games, OfficeTools, Accessories) VALUES 
                    (@name, @address, @phone, @email, @software, @computers, @games, @officeTools, @accessories)";
                using (var command = new SqliteCommand(insertQuery, connection)) 
                {
                    command.Parameters.AddWithValue("@name", clientData.Name);
                    command.Parameters.AddWithValue("@address", clientData.Address);
                    command.Parameters.AddWithValue("@phone", clientData.PhoneNumber);
                    command.Parameters.AddWithValue("@email", clientData.Email);
                    command.Parameters.AddWithValue("@software", clientData.Software ? 1 : 0);
                    command.Parameters.AddWithValue("@computers", clientData.Computers ? 1 : 0);
                    command.Parameters.AddWithValue("@games", clientData.Games ? 1 : 0);
                    command.Parameters.AddWithValue("@officeTools", clientData.OfficeTools ? 1 : 0);
                    command.Parameters.AddWithValue("@accessories", clientData.Accessories ? 1 : 0);
                    command.ExecuteNonQuery(); 
                }


                string selectNewIdQuery = "SELECT last_insert_rowid();";
                using (var idCommand = new SqliteCommand(selectNewIdQuery, connection))
                {
                    long newId = Convert.ToInt64(idCommand.ExecuteScalar());
                    return newId;
                }
            }
        }

        public static void DeleteClient(int clientId)
        {
            using (var connection = new SqliteConnection(CLIENT_DATA_SOURCE))
            {
                connection.Open();

                string deleteQuery = "DELETE FROM Clients WHERE ID = @id";

                using (var command = new SqliteCommand(deleteQuery, connection))
                {
                    command.Parameters.AddWithValue("@id", clientId);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void UpdateClient(ClientData clientData)
        {
            using (var connection = new SqliteConnection(CLIENT_DATA_SOURCE))
            {
                connection.Open();

                string updateQuery = @"
                    UPDATE Clients
                    SET
                    Name = @name,
                    Address = @address,
                    Phone = @phone,
                    Email = @email,
                    Software = @software,
                    Computers = @computers,
                    Games = @games,
                    OfficeTools = @officeTools,
                    Accessories = @accessories
                    WHERE ID = @id";

                using (var command = new SqliteCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@id", clientData.ID);
                    command.Parameters.AddWithValue("@name", clientData.Name ?? string.Empty);
                    command.Parameters.AddWithValue("@address", clientData.Address ?? string.Empty);
                    command.Parameters.AddWithValue("@phone", clientData.PhoneNumber ?? string.Empty);
                    command.Parameters.AddWithValue("@email", clientData.Email ?? string.Empty);
                    command.Parameters.AddWithValue("@software", clientData.Software ? 1 : 0);
                    command.Parameters.AddWithValue("@computers", clientData.Computers ? 1 : 0);
                    command.Parameters.AddWithValue("@games", clientData.Games ? 1 : 0);
                    command.Parameters.AddWithValue("@officeTools", clientData.OfficeTools ? 1 : 0);
                    command.Parameters.AddWithValue("@accessories", clientData.Accessories ? 1 : 0);

                    command.ExecuteNonQuery();
                }
            }
        }


    }
}
