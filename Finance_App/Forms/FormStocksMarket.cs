using System;
using System.Windows.Forms;
using static Finance_App.DatabaseManager;

namespace Finance_App.Forms
{
    public partial class FormStocksMarket : Form
    {
        private StocksManager stocksManager;
        private string username;
        DatabaseManager databaseManager;
        decimal price, amount, last = 0;

        public FormStocksMarket()
        {
            InitializeComponent();

            stocksManager = new StocksManager();
            LoadData();

            this.username = username;
            databaseManager = new DatabaseManager();
        }

        private async void LoadData()
        {
            try
            {
                await stocksManager.LoadDataAsync(dataGridView1);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();
            if (!string.IsNullOrEmpty(searchText))
            {
                StocksManager.SearchInDataGridView(searchText, dataGridView1);
            }
            else
            {
                MessageBox.Show("Please enter a search term.");
            }
        }

        private void FormStocksMarket_Load(object sender, EventArgs e)
        {
            UserData userData = databaseManager.GetUserData(loggedInUsername);
            if (userData != null)
            {
                label2.Text = "Balance: $" + userData.Balance.ToString();
            }
            else
            {
                MessageBox.Show("Kullanıcı bilgileri yüklenirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label6.ForeColor = Color.FromArgb(164, 165, 169);
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            Dictionary<string, string> rowData = new Dictionary<string, string>();
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                string columnName = column.Name;
                string cellValue = row.Cells[columnName].Value.ToString();
                rowData.Add(columnName, cellValue);
            }

            txtPrice.Text = rowData["Close"];
            txtName.Text = rowData["TickerSymbol"];
            txtAmount.Text = "";
            label6.Text = "Payment: $ 00.00";
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            UserData userData = databaseManager.GetUserData(loggedInUsername);
            decimal balance = userData.Balance;

            if (txtAmount.Text == "")
            {
                amount = 0;
            }

            else
            {
                price = Convert.ToDecimal(txtPrice.Text);
                amount = Convert.ToDecimal(txtAmount.Text);
                last = price * amount;
                label6.Text = "Payment: $" + last.ToString();
            }

            if (balance < last)
            {
                label6.ForeColor = Color.Red;
                label6.Text = "Insufficient funds!";
                button2.Enabled = false;
            }

            else
            {
                label6.ForeColor = Color.FromArgb(164, 165, 169);
                button2.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserData userData = databaseManager.GetUserData(loggedInUsername);
            string wallet_address = userData.WalletAddress;
            StocksManager cryptoManager = new StocksManager();
            cryptoManager.BuyStocks(wallet_address, price, amount, txtName.Text.ToString());
            cryptoManager.SubtractFromBalance(wallet_address, last);

            userData = databaseManager.GetUserData(loggedInUsername);
            label2.Text = "Balance: $" + userData.Balance.ToString();
        }
    }
}
