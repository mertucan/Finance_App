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

namespace Finance_App
{
    internal class DatabaseManager
    {
        private string connectionString = "Data Source=MERT;Initial Catalog=FinanceApp;Integrated Security=True;";

        public bool SaveUser(string username, string password)
        {
            bool userExists = CheckIfUserExists(username);
            if (userExists)
            {
                MessageBox.Show("Bu kullanıcı adına sahip bir kullanıcı zaten var!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    FrmHub frmHub = new FrmHub();
                    FrmLogin frmLogin = new FrmLogin();
                    frmLogin.Hide();
                    frmHub.Show();
                    return true;
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre yanlış!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
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
                MessageBox.Show("Kullanıcı başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
