using System;
using System.Collections.Generic;
using System.Windows.Forms;
using RestSharp;
using Newtonsoft.Json.Linq;

namespace Finance_App.Forms
{
    public partial class FormCryptoMarket : Form
    {
        public FormCryptoMarket()
        {
            InitializeComponent();

            dataGridView1.Columns.Add("Column#", "#");
            dataGridView1.Columns.Add("ColumnName", "Name");
            dataGridView1.Columns.Add("ColumnPrice", "Price");

            FetchCryptoData();

        }

        string currency = "usd";

        private void FetchCryptoData()
        {
            List<string> cryptoCurrencies = new List<string>
            {
                "bitcoin", "ethereum", "tether", "binancecoin", "solana",
                "ripple", "dogecoin", "cardano", "avalanche", "shiba-inu"
            };

            string currency = "usd";

            dataGridView1.Rows.Clear(); // Önceki verileri temizle

            foreach (string cryptoCurrency in cryptoCurrencies)
            {
                var client = new RestClient($"https://api.coingecko.com/api/v3/simple/price?ids={cryptoCurrency}&vs_currencies={currency}");

                var request = new RestRequest(Method.GET);
                request.AddHeader("Accepts", "application/json");

                IRestResponse response = client.Execute(request);

                if (response.IsSuccessful)
                {
                    JObject jsonResponse = JObject.Parse(response.Content);
                    double price = (double)jsonResponse[cryptoCurrency][currency];

                    dataGridView1.Rows.Add(
                        dataGridView1.Rows.Count + 1,
                        cryptoCurrency.ToUpper(),
                        price
                    );
                }
            }
        }
    }
}