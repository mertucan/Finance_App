using System;
using System.Collections.Generic;
using System.Windows.Forms;
using RestSharp;
using Newtonsoft.Json.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

            CryptoManager.FetchAllCryptoData("usd", dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CryptoManager.SearchInDataGridView(txtSearch.Text, dataGridView1);
        }
    }
}