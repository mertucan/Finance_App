using System;
using System.Collections.Generic;
using System.Windows.Forms;
using RestSharp;
using Newtonsoft.Json.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static Finance_App.DatabaseManager;

namespace Finance_App.Forms
{
    public partial class FormCryptoMarket : Form
    {
        private string username;
        DatabaseManager databaseManager;
        decimal price, amount, last = 0;

        public FormCryptoMarket()
        {
            InitializeComponent();

            dataGridView1.Columns.Add("Column#", "#");
            dataGridView1.Columns.Add("ColumnName", "Name");
            dataGridView1.Columns.Add("ColumnPrice", "Price");

            CryptoManager.FetchAllCryptoData("usd", dataGridView1);

            this.username = username;
            databaseManager = new DatabaseManager();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CryptoManager.SearchInDataGridView(txtSearch.Text, dataGridView1);
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

            txtPrice.Text = rowData["ColumnPrice"];
            txtName.Text = rowData["ColumnName"];
            txtAmount.Text = "";
            label6.Text = "Payment: $ 00.00";
        }

        private void FormCryptoMarket_Load(object sender, EventArgs e)
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

        private void txtAmount_TextChanged_1(object sender, EventArgs e)
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
            CryptoManager cryptoManager = new CryptoManager();
            cryptoManager.BuyCrypto(wallet_address, price, amount, txtName.Text.ToString());
            cryptoManager.SubtractFromBalance(wallet_address, last);

            userData = databaseManager.GetUserData(loggedInUsername);
            label2.Text = "Balance: $" + userData.Balance.ToString();
        }
    }
}