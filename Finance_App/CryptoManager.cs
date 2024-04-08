using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finance_App
{
    internal class CryptoManager
    {
        // Kripto verilerini çeken ve DataGridView'e dolduran metot
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
    }
}
