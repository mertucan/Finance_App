namespace Finance_App
{
    partial class FrmRegister
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            label3 = new Label();
            txtConfirm = new TextBox();
            label4 = new Label();
            checkPass = new CheckBox();
            button1 = new Button();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS UI Gothic", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.FromArgb(116, 86, 174);
            label1.Location = new Point(44, 64);
            label1.Name = "label1";
            label1.Size = new Size(311, 53);
            label1.TabIndex = 0;
            label1.Text = "Get Started!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 156);
            label2.Name = "label2";
            label2.Size = new Size(148, 32);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(230, 231, 233);
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("MS UI Gothic", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtUsername.Location = new Point(44, 205);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(576, 58);
            txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(230, 231, 233);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("MS UI Gothic", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtPassword.Location = new Point(44, 356);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(576, 58);
            txtPassword.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 307);
            label3.Name = "label3";
            label3.Size = new Size(143, 32);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // txtConfirm
            // 
            txtConfirm.BackColor = Color.FromArgb(230, 231, 233);
            txtConfirm.BorderStyle = BorderStyle.None;
            txtConfirm.Font = new Font("MS UI Gothic", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtConfirm.Location = new Point(44, 514);
            txtConfirm.Multiline = true;
            txtConfirm.Name = "txtConfirm";
            txtConfirm.Size = new Size(576, 58);
            txtConfirm.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 465);
            label4.Name = "label4";
            label4.Size = new Size(259, 32);
            label4.TabIndex = 5;
            label4.Text = "Confirm Password";
            // 
            // checkPass
            // 
            checkPass.AutoSize = true;
            checkPass.Cursor = Cursors.Hand;
            checkPass.FlatStyle = FlatStyle.Flat;
            checkPass.Location = new Point(364, 600);
            checkPass.Name = "checkPass";
            checkPass.Size = new Size(251, 36);
            checkPass.TabIndex = 7;
            checkPass.Text = "Show Password";
            checkPass.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(116, 86, 174);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(142, 669);
            button1.Name = "button1";
            button1.Size = new Size(380, 68);
            button1.TabIndex = 8;
            button1.Text = "Sign Up";
            button1.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(150, 762);
            label5.Name = "label5";
            label5.Size = new Size(362, 32);
            label5.TabIndex = 9;
            label5.Text = "Already have an account ?";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.FromArgb(116, 86, 174);
            label6.Location = new Point(273, 805);
            label6.Name = "label6";
            label6.Size = new Size(107, 32);
            label6.TabIndex = 10;
            label6.Text = "Sign In";
            // 
            // FrmRegister
            // 
            AutoScaleDimensions = new SizeF(17F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(678, 888);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(checkPass);
            Controls.Add(txtConfirm);
            Controls.Add(label4);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Arial", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 162);
            ForeColor = Color.FromArgb(164, 165, 169);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label label3;
        private TextBox txtConfirm;
        private Label label4;
        private CheckBox checkPass;
        private Button button1;
        private Label label5;
        private Label label6;
    }
}
