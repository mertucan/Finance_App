namespace Finance_App.Forms
{
    partial class FormProfile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtPassword = new TextBox();
            label3 = new Label();
            txtUsername = new TextBox();
            label2 = new Label();
            txtWalletAdress = new TextBox();
            label1 = new Label();
            checkPass = new CheckBox();
            txtCommunication = new TextBox();
            label4 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.WhiteSmoke;
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Arial", 13.125F);
            txtPassword.Location = new Point(233, 183);
            txtPassword.Margin = new Padding(4, 3, 4, 3);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '•';
            txtPassword.ReadOnly = true;
            txtPassword.Size = new Size(576, 47);
            txtPassword.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(233, 146);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(143, 32);
            label3.TabIndex = 7;
            label3.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.WhiteSmoke;
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Arial", 13.125F);
            txtUsername.Location = new Point(233, 83);
            txtUsername.Margin = new Padding(4, 3, 4, 3);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.ReadOnly = true;
            txtUsername.Size = new Size(576, 47);
            txtUsername.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(233, 46);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(148, 32);
            label2.TabIndex = 5;
            label2.Text = "Username";
            // 
            // txtWalletAdress
            // 
            txtWalletAdress.BackColor = Color.WhiteSmoke;
            txtWalletAdress.BorderStyle = BorderStyle.FixedSingle;
            txtWalletAdress.Font = new Font("Arial", 13.125F);
            txtWalletAdress.Location = new Point(233, 284);
            txtWalletAdress.Margin = new Padding(4, 3, 4, 3);
            txtWalletAdress.Multiline = true;
            txtWalletAdress.Name = "txtWalletAdress";
            txtWalletAdress.ReadOnly = true;
            txtWalletAdress.Size = new Size(576, 47);
            txtWalletAdress.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(233, 247);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(209, 32);
            label1.TabIndex = 9;
            label1.Text = "Wallet Address";
            // 
            // checkPass
            // 
            checkPass.AutoSize = true;
            checkPass.Cursor = Cursors.Hand;
            checkPass.FlatStyle = FlatStyle.Flat;
            checkPass.Location = new Point(558, 461);
            checkPass.Name = "checkPass";
            checkPass.Size = new Size(251, 36);
            checkPass.TabIndex = 11;
            checkPass.Text = "Show Password";
            checkPass.UseVisualStyleBackColor = true;
            checkPass.CheckedChanged += checkPass_CheckedChanged;
            // 
            // txtCommunication
            // 
            txtCommunication.BackColor = Color.WhiteSmoke;
            txtCommunication.BorderStyle = BorderStyle.FixedSingle;
            txtCommunication.Font = new Font("Arial", 13.125F);
            txtCommunication.Location = new Point(233, 385);
            txtCommunication.Margin = new Padding(4, 3, 4, 3);
            txtCommunication.Multiline = true;
            txtCommunication.Name = "txtCommunication";
            txtCommunication.ReadOnly = true;
            txtCommunication.Size = new Size(576, 47);
            txtCommunication.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(233, 348);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(342, 32);
            label4.TabIndex = 12;
            label4.Text = "Communication Address";
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSlateBlue;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(558, 503);
            button1.Name = "button1";
            button1.Size = new Size(251, 59);
            button1.TabIndex = 20;
            button1.Text = "To Update Profile";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FormProfile
            // 
            AutoScaleDimensions = new SizeF(17F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1046, 723);
            Controls.Add(button1);
            Controls.Add(txtCommunication);
            Controls.Add(label4);
            Controls.Add(checkPass);
            Controls.Add(txtWalletAdress);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Font = new Font("Arial", 10.125F, FontStyle.Bold);
            ForeColor = Color.FromArgb(164, 165, 169);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormProfile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormProfile";
            Load += FormProfile_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPassword;
        private Label label3;
        private TextBox txtUsername;
        private Label label2;
        private TextBox txtWalletAdress;
        private Label label1;
        private CheckBox checkPass;
        private TextBox txtCommunication;
        private Label label4;
        private Button button1;
    }
}