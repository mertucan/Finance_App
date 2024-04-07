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

namespace Finance_App.Forms
{
    public partial class FormProfile : Form
    {
        private DatabaseManager dbManager = new DatabaseManager();
        public static string username = "";
        public static string password = "";
        public static string wallet_address = "";
        public static string communication = "";

        public FormProfile()
        {
            InitializeComponent();
        }

        private void FormProfile_Load(object sender, EventArgs e)
        {
            UserData userData = dbManager.GetUserData(username);
            if (userData != null)
            {
                txtUsername.Text = userData.Username;
                txtPassword.Text = userData.Password;
                txtWalletAdress.Text = userData.WalletAddress;
                txtCommunication.Text = userData.CommunicationAddress;
            }
            else
            {
                MessageBox.Show("Kullanıcı bilgileri yüklenirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPass.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '•';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmCrypto frmCrypto = new FrmCrypto();
            frmCrypto.Hide();
            FrmStocks frmStocks = new FrmStocks();
            frmStocks.Hide();
            FrmSettings frmSettings = new FrmSettings();
            frmSettings.Show();
        }
    }
}
