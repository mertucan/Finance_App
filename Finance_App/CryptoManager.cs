using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Finance_App
{
    internal class CryptoManager
    {
        public static void FetchAllCryptoData(string currency, DataGridView dataGridView)
        {
            var client = new RestClient("https://api.coingecko.com/api/v3/coins/markets");
            var request = new RestRequest(Method.GET);
            request.AddParameter("vs_currency", currency);
            request.AddParameter("order", "market_cap_desc");
            request.AddParameter("per_page", "250");
            request.AddParameter("page", "1");

            IRestResponse response = client.Execute(request);

            if (response.IsSuccessful)
            {
                JArray jsonResponse = JArray.Parse(response.Content);

                int rowIndex = 1; // Satır indeksini 1'den başlat

                foreach (JToken token in jsonResponse)
                {
                    string name = token["name"].ToString();
                    name = char.ToUpper(name[0]) + name.Substring(1);
                    double price = (double)token["current_price"];

                    dataGridView.Rows.Add(
                        rowIndex,
                        name,
                        price
                    );

                    rowIndex++;
                }
            }
            else
            {
                MessageBox.Show("Error fetching data from API.");
            }
        }

        public static void SearchInDataGridView(string searchText, DataGridView dataGridView)
        {
            // DataGridView'deki her satırı kontrol et
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                // Satırın herhangi bir hücresinde aranan metni içeriyorsa
                if (row.Cells.Cast<DataGridViewCell>().Any(cell => cell.Value != null && cell.Value.ToString().ToLower().Contains(searchText.ToLower())))
                {
                    // Satırı seç (isteğe bağlı)
                    row.Selected = true;

                    // İlk bulunan sonucu göster ve döngüden çık
                    dataGridView.FirstDisplayedScrollingRowIndex = row.Index;
                    break;
                }
            }
        }

        public void BuyCrypto(string walletAddress, decimal price, decimal amount, string name)
        {
            string connectionString = "Data Source=MERT;Initial Catalog=FinanceApp;Integrated Security=True;";
            string query = "INSERT INTO Transactions (wallet_address, transaction_type, price, amount, name) VALUES (@WalletAddress, @TransactionType, @Price, @Amount, @Name)";

            // SqlConnection nesnesi oluşturma
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Komut oluşturma
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Parametreleri ekleme
                    command.Parameters.AddWithValue("@WalletAddress", walletAddress);
                    command.Parameters.AddWithValue("@TransactionType", "crypto");
                    command.Parameters.AddWithValue("@Price", price);
                    command.Parameters.AddWithValue("@Amount", amount);
                    command.Parameters.AddWithValue("@Name", name);

                    // Bağlantıyı açma ve komutu çalıştırma
                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Payment is successful!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error inserting data into database: " + ex.Message);
                    }
                }
            }
        }

        public void SubtractFromBalance(string walletAddress, decimal price)
        {
            string connectionString = "Data Source=MERT;Initial Catalog=FinanceApp;Integrated Security=True;";
            string query = "UPDATE Users SET balance = balance - @Price WHERE wallet_address = @WalletAddress";

            // SqlConnection nesnesi oluşturma
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Komut oluşturma
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Parametreleri ekleme
                    command.Parameters.AddWithValue("@Price", price);
                    command.Parameters.AddWithValue("@WalletAddress", walletAddress);

                    // Bağlantıyı açma ve komutu çalıştırma
                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating balance in database: " + ex.Message);
                    }
                }
            }
        }

    }
}
