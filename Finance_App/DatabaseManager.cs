using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Finance_App.Forms;

namespace Finance_App
{
    internal class DatabaseManager
    {
        private string connectionString = "Data Source=MERT;Initial Catalog=FinanceApp;Integrated Security=True;";
        public static string loggedInUsername;

        public bool SaveUser(string username, string password)
        {
            bool userExists = CheckIfUserExists(username);
            if (userExists)
            {
                MessageBox.Show("Username is already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            string walletAddress = GenerateWalletAddress();
            string query = "INSERT INTO Users (username, password, wallet_address) VALUES (@username, @password, @walletAddress)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@walletAddress", walletAddress);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return false;
                }
            }
        }

        public bool userLogin(string username, string password)
        {
            string query = "SELECT COUNT(*) FROM Users WHERE username = @username AND password = @password";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                connection.Open();
                int count = (int)command.ExecuteScalar();

                if (count > 0)
                {
                    loggedInUsername = username; // Kullanıcı giriş yaptığında kullanıcı adını sakla
                    FrmSettings.username = username;
                    FormProfile.username = username;
                    FrmHub frmHub = new FrmHub();
                    FrmLogin frmLogin = new FrmLogin();
                    frmLogin.Hide();
                    frmHub.Show();
                    return true;
                }
                else
                {
                    MessageBox.Show("Username or password is wrong!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        public UserData GetUserData()
        {
            if (string.IsNullOrEmpty(loggedInUsername))
            {
                return null;
            }

            return GetUserData(loggedInUsername);
        }

        private bool CheckIfUserExists(string username)
        {
            string query = "SELECT COUNT(*) FROM Users WHERE username = @username";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);

                connection.Open();
                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
        }

        public void addUser(string username, string password)
        {
            bool success = SaveUser(username, password);
            if (success)
            {
                MessageBox.Show("User is successfully added!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private string GenerateWalletAddress()
        {
            Random random = new Random();
            const string chars = "0123456789abcdefghijklmnopqrstuvwxyz";
            char[] addressChars = new char[34];

            addressChars[0] = '1';
            for (int i = 1; i < 34; i++)
            {
                addressChars[i] = chars[random.Next(chars.Length)];
            }

            return new string(addressChars);
        }

        public void ChangePassword(string username, string oldPassword, string newPassword)
        {
            string query = "SELECT password FROM Users WHERE username = @username";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);

                connection.Open();
                string dbPassword = (string)command.ExecuteScalar();

                if (dbPassword == oldPassword)
                {
                    string updateQuery = "UPDATE Users SET password = @newPassword WHERE username = @username";
                    SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                    updateCommand.Parameters.AddWithValue("@newPassword", newPassword);
                    updateCommand.Parameters.AddWithValue("@username", username);
                    updateCommand.ExecuteNonQuery();
                    MessageBox.Show("Password is succesfully changed.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Old password is wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void ClearTextBoxes(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }
                else if (c.HasChildren)
                {
                    ClearTextBoxes(c);
                }
            }
        }

        public void AddCommunicationAddress(string username, string communicationAddress)
        {
            string query = "UPDATE Users SET contact_address = @contact_address WHERE username = @username";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@contact_address", communicationAddress);
                command.Parameters.AddWithValue("@username", username);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Contact address is successfully added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Username not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        public UserData GetUserData(string username)
        {
            string query = "SELECT username, password, wallet_address, contact_address, balance FROM Users WHERE username = @username";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    UserData userData = new UserData
                    {
                        Username = reader["username"].ToString(),
                        Password = reader["password"].ToString(),
                        WalletAddress = reader["wallet_address"].ToString(),
                        CommunicationAddress = reader["contact_address"].ToString(),
                        Balance = Convert.ToDecimal(reader["balance"])
                    };
                    return userData;
                }
                else
                {
                    return null;
                }
            }
        }

        public bool UpdateUserBalance(string username, decimal additionalAmount)
        {
            string query = "UPDATE Users SET balance = balance + @additionalAmount WHERE username = @username";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@additionalAmount", additionalAmount);
                command.Parameters.AddWithValue("@username", username);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return false;
                }
            }
        }

        public void GetTransactions(DataGridView dataGridView, string walletAddress)
        {
            string connectionString = "Data Source=MERT;Initial Catalog=FinanceApp;Integrated Security=True;";
            string query = "SELECT * FROM Transactions WHERE wallet_address = @wallet_address";

            // SqlConnection nesnesi oluşturma
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Komut oluşturma
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Parametre ekleme
                    command.Parameters.AddWithValue("@wallet_address", walletAddress);

                    // SqlDataAdapter oluşturma
                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    // DataTable oluşturma
                    DataTable dataTable = new DataTable();

                    // Bağlantıyı açma ve verileri yükleyerek kripto işlemlerini al
                    try
                    {
                        connection.Open();
                        adapter.Fill(dataTable);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error retrieving crypto transactions from database: " + ex.Message);
                    }

                    // DataTable'ı DataGridView'e bağlama
                    dataGridView.DataSource = dataTable;
                }
            }
        }

        public class UserData
        {
            public string Username { get; set; }
            public string Password { get; set; }
            public string WalletAddress { get; set; }
            public string CommunicationAddress { get; set; }
            public decimal Balance { get; set; }
        }

    }
}
