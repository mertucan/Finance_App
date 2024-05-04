using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Finance_App.DatabaseManager;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Finance_App.Forms
{
    public partial class FormPortfolio : Form
    {
        private string username;
        DatabaseManager databaseManager;

        public FormPortfolio()
        {
            InitializeComponent();
            this.username = username;
            databaseManager = new DatabaseManager();
        }

        private void FormPortfolio_Load(object sender, EventArgs e)
        {
            UserData userData = databaseManager.GetUserData(loggedInUsername);
            databaseManager.GetTransactions(dataGridView1, userData.WalletAddress);
        }
    }
}
