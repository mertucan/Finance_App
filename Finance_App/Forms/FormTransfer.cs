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
    public partial class FormTransfer : Form
    {
        private string username;
        DatabaseManager databaseManager;

        public FormTransfer(string username)
        {
            this.username = username;
            InitializeComponent();
            databaseManager = new DatabaseManager();
        }

        private void FormTransfer_Load(object sender, EventArgs e)
        {
            getBalance();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtBalance.Text, out decimal additionalAmount))
            {
                databaseManager.UpdateUserBalance(this.username, additionalAmount);
                getBalance();
            }
            else
            {
                MessageBox.Show("Geçersiz bakiye miktarı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void getBalance()
        {
            UserData userData = databaseManager.GetUserData(this.username);
            if (userData != null)
            {
                label1.Text = "$" + userData.Balance.ToString();
            }
            else
            {
                MessageBox.Show("Kullanıcı bilgileri yüklenirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
