namespace Finance_App
{
    partial class FrmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSettings));
            panelTitleBar = new Panel();
            lblTitle = new Label();
            panelDesktopPanel = new Panel();
            button2 = new Button();
            txtCommunication = new TextBox();
            label1 = new Label();
            button1 = new Button();
            checkPass = new CheckBox();
            txtNewPassword = new TextBox();
            label4 = new Label();
            txtOldPassword = new TextBox();
            label3 = new Label();
            txtUsername = new TextBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panelTitleBar.SuspendLayout();
            panelDesktopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            panelTitleBar.Controls.Add(pictureBox1);
            panelTitleBar.Controls.Add(lblTitle);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(0, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(725, 120);
            panelTitleBar.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Arial", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(251, 43);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(204, 42);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "SETTINGS";
            // 
            // panelDesktopPanel
            // 
            panelDesktopPanel.Controls.Add(button2);
            panelDesktopPanel.Controls.Add(txtCommunication);
            panelDesktopPanel.Controls.Add(label1);
            panelDesktopPanel.Controls.Add(button1);
            panelDesktopPanel.Controls.Add(checkPass);
            panelDesktopPanel.Controls.Add(txtNewPassword);
            panelDesktopPanel.Controls.Add(label4);
            panelDesktopPanel.Controls.Add(txtOldPassword);
            panelDesktopPanel.Controls.Add(label3);
            panelDesktopPanel.Controls.Add(txtUsername);
            panelDesktopPanel.Controls.Add(label2);
            panelDesktopPanel.Dock = DockStyle.Fill;
            panelDesktopPanel.Location = new Point(0, 120);
            panelDesktopPanel.Name = "panelDesktopPanel";
            panelDesktopPanel.Size = new Size(725, 880);
            panelDesktopPanel.TabIndex = 2;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkSlateBlue;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(173, 789);
            button2.Name = "button2";
            button2.Size = new Size(380, 68);
            button2.TabIndex = 19;
            button2.Text = "Save Address";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // txtCommunication
            // 
            txtCommunication.BackColor = Color.WhiteSmoke;
            txtCommunication.BorderStyle = BorderStyle.FixedSingle;
            txtCommunication.Font = new Font("Arial", 13.125F);
            txtCommunication.Location = new Point(75, 709);
            txtCommunication.Multiline = true;
            txtCommunication.Name = "txtCommunication";
            txtCommunication.Size = new Size(576, 47);
            txtCommunication.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 660);
            label1.Name = "label1";
            label1.Size = new Size(480, 32);
            label1.TabIndex = 17;
            label1.Text = "Communication Address (Optional)";
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSlateBlue;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(173, 553);
            button1.Name = "button1";
            button1.Size = new Size(380, 68);
            button1.TabIndex = 16;
            button1.Text = "Change Password";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // checkPass
            // 
            checkPass.AutoSize = true;
            checkPass.Cursor = Cursors.Hand;
            checkPass.FlatStyle = FlatStyle.Flat;
            checkPass.Location = new Point(395, 484);
            checkPass.Name = "checkPass";
            checkPass.Size = new Size(251, 36);
            checkPass.TabIndex = 15;
            checkPass.Text = "Show Password";
            checkPass.UseVisualStyleBackColor = true;
            checkPass.CheckedChanged += checkPass_CheckedChanged;
            // 
            // txtNewPassword
            // 
            txtNewPassword.BackColor = Color.WhiteSmoke;
            txtNewPassword.BorderStyle = BorderStyle.FixedSingle;
            txtNewPassword.Font = new Font("Arial", 13.125F);
            txtNewPassword.Location = new Point(75, 398);
            txtNewPassword.Multiline = true;
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.PasswordChar = '•';
            txtNewPassword.Size = new Size(576, 47);
            txtNewPassword.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(75, 349);
            label4.Name = "label4";
            label4.Size = new Size(207, 32);
            label4.TabIndex = 13;
            label4.Text = "New Password";
            // 
            // txtOldPassword
            // 
            txtOldPassword.BackColor = Color.WhiteSmoke;
            txtOldPassword.BorderStyle = BorderStyle.FixedSingle;
            txtOldPassword.Font = new Font("Arial", 13.125F);
            txtOldPassword.Location = new Point(75, 240);
            txtOldPassword.Multiline = true;
            txtOldPassword.Name = "txtOldPassword";
            txtOldPassword.PasswordChar = '•';
            txtOldPassword.Size = new Size(576, 47);
            txtOldPassword.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(75, 191);
            label3.Name = "label3";
            label3.Size = new Size(197, 32);
            label3.TabIndex = 11;
            label3.Text = "Old Password";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.WhiteSmoke;
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Arial", 13.125F);
            txtUsername.Location = new Point(75, 89);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.ReadOnly = true;
            txtUsername.Size = new Size(576, 47);
            txtUsername.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(75, 40);
            label2.Name = "label2";
            label2.Size = new Size(148, 32);
            label2.TabIndex = 9;
            label2.Text = "Username";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(673, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // FrmSettings
            // 
            AutoScaleDimensions = new SizeF(17F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(725, 1000);
            Controls.Add(panelDesktopPanel);
            Controls.Add(panelTitleBar);
            Font = new Font("Arial", 10.125F, FontStyle.Bold);
            ForeColor = Color.FromArgb(164, 165, 169);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmSettings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmCrypto";
            Load += FrmSettings_Load;
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            panelDesktopPanel.ResumeLayout(false);
            panelDesktopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelTitleBar;
        private Panel panelDesktopPanel;
        private Label lblTitle;
        private Button button1;
        private CheckBox checkPass;
        private TextBox txtNewPassword;
        private Label label4;
        private TextBox txtOldPassword;
        private Label label3;
        private TextBox txtUsername;
        private Label label2;
        private Button button2;
        private TextBox txtCommunication;
        private Label label1;
        private PictureBox pictureBox1;
    }
}