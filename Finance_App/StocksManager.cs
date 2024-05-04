using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using YahooFinanceApi;

namespace Finance_App
{
    public class StocksManager
    {
        private List<string> companySymbols = new List<string>()
        {
            "MSFT", "AAPL", "NVDA", "GOOG", "GOOGL", "AMZN", "META", "AVGO", "TSLA",
            "ASML", "COST", "AMD", "NFLX", "PEP", "LIN", "ADBE",
            "AZN", "CSCO", "TMUS", "QCOM", "INTU", "AMAT", "INTC", "CMCSA", "PDD", "TXN",
            "AMGN", "MU", "ISRG", "HON", "LRCX", "BKNG", "VRTX", "REGN", "ABNB", "SBUX",
            "ADP", "ADI", "MDLZ", "KLAC", "GILD", "SNPS", "PANW", "CDNS", "MELI", "CRWD", "MAR",
            "WDAY", "CSX", "CTAS", "ORLY", "PCAR", "MRVL", "NXPI", "MNST", "CEG", "ROP", "DASH",
            "CPRT", "FTNT", "ADSK", "DXCM", "TEAM", "ODFL", "ROST", "MCHP", "KHC", "AEP", "LULU","PAYX",
            "IDXX", "FAST", "KDP", "TTD", "DDOG", "GEHC", "CHTR", "MRNA", "CSGP", "EXC", "FANG",
            "CTSH", "EA", "BKR", "CDW", "VRSK", "CCEP", "XEL", "BIIB", "ANSS", "ON", "DLTR", "GFS",
            "ZS", "TTWO", "MDB", "WBD", "ILMN", "WBA", "SIRI"
        };

        public async Task LoadDataAsync(DataGridView dataGridView)
        {
            try
            {
                dataGridView.Columns.Add("Number", "#");
                dataGridView.Columns.Add("TickerSymbol", "Ticker Symbol");
                dataGridView.Columns.Add("CompanyName", "Company Name");
                dataGridView.Columns.Add("Close", "Close Price");

                for (int i = 0; i < companySymbols.Count; i++)
                {
                    string symbol = companySymbols[i];
                    DateTime endDate = DateTime.Today;
                    DateTime startDate = new DateTime(endDate.Year, 1, 1);

                    var historic_data = await Yahoo.GetHistoricalAsync(symbol, startDate, endDate);
                    var security = await Yahoo.Symbols(symbol).Fields(Field.LongName).QueryAsync();
                    var ticker = security[symbol];
                    var companyName = ticker[Field.LongName];

                    var lastData = historic_data.LastOrDefault();

                    if (lastData != null)
                    {
                        dataGridView.Rows.Add(i + 1, symbol, companyName, Math.Round(lastData.Close, 2));
                    }
                    else
                    {
                        MessageBox.Show($"No data available for {companyName}.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        public static void SearchInDataGridView(string searchText, DataGridView dataGridView)
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Cells.Cast<DataGridViewCell>().Any(cell => cell.Value != null && cell.Value.ToString().ToLower().Contains(searchText.ToLower())))
                {
                    row.Selected = true;

                    dataGridView.FirstDisplayedScrollingRowIndex = row.Index;
                    break;
                }
            }
        }

        public void BuyStocks(string walletAddress, decimal price, decimal amount, string name)
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
                    command.Parameters.AddWithValue("@TransactionType", "stocks");
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
