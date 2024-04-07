using System;
using System.Windows.Forms;

namespace Finance_App
{
    public partial class FrmSettings : Form
    {
        private DatabaseManager dbManager = new DatabaseManager();
        public static string username = "";

        public FrmSettings()
        {
            InitializeComponent();
        }

        private void FrmSettings_Load(object sender, EventArgs e)
        {
            txtUsername.Text = username;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string oldPassword = txtOldPassword.Text;
            string newPassword = txtNewPassword.Text;

            dbManager.ChangePassword(username, oldPassword, newPassword);
            FrmHub frmHub = new FrmHub();
            frmHub.Show();
            this.Hide();
        }

        private void checkPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPass.Checked)
            {
                txtOldPassword.PasswordChar = '\0';
                txtNewPassword.PasswordChar = '\0';
            }
            else
            {
                txtOldPassword.PasswordChar = '•';
                txtNewPassword.PasswordChar = '•';
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dbManager.AddCommunicationAddress(username, txtCommunication.Text);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
