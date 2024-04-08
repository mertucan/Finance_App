using System;
using System.Windows.Forms;

namespace Finance_App.Forms
{
    public partial class FormStocksMarket : Form
    {
        private StocksManager stocksManager;

        public FormStocksMarket()
        {
            InitializeComponent();

            stocksManager = new StocksManager();
            LoadData();
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
    }
}
