namespace Finance_App
{
    partial class FrmCrypto
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
            panelMenu = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panelLogo = new Panel();
            label1 = new Label();
            panelTitleBar = new Panel();
            lblTitle = new Label();
            panelDesktopPanel = new Panel();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            panelTitleBar.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(51, 51, 76);
            panelMenu.Controls.Add(button3);
            panelMenu.Controls.Add(button2);
            panelMenu.Controls.Add(button1);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(307, 750);
            panelMenu.TabIndex = 0;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Top;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Arial", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button3.ForeColor = Color.White;
            button3.Location = new Point(0, 284);
            button3.Name = "button3";
            button3.Size = new Size(307, 82);
            button3.TabIndex = 3;
            button3.Text = "Profile";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Top;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button2.ForeColor = Color.White;
            button2.Location = new Point(0, 202);
            button2.Name = "button2";
            button2.Size = new Size(307, 82);
            button2.TabIndex = 2;
            button2.Text = "Portfolio";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.White;
            button1.Location = new Point(0, 120);
            button1.Name = "button1";
            button1.Size = new Size(307, 82);
            button1.TabIndex = 1;
            button1.Text = "Market";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            panelLogo.Controls.Add(label1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(307, 120);
            panelLogo.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(61, 43);
            label1.Name = "label1";
            label1.Size = new Size(178, 33);
            label1.TabIndex = 1;
            label1.Text = "Crypto Menu";
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            panelTitleBar.Controls.Add(lblTitle);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(307, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(1118, 120);
            panelTitleBar.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Arial", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(448, 43);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(130, 42);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "HOME";
            // 
            // panelDesktopPanel
            // 
            panelDesktopPanel.Dock = DockStyle.Fill;
            panelDesktopPanel.Location = new Point(307, 120);
            panelDesktopPanel.Name = "panelDesktopPanel";
            panelDesktopPanel.Size = new Size(1118, 630);
            panelDesktopPanel.TabIndex = 2;
            // 
            // FrmCrypto
            // 
            AutoScaleDimensions = new SizeF(17F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1425, 750);
            Controls.Add(panelDesktopPanel);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            Font = new Font("Arial", 10.125F, FontStyle.Bold);
            ForeColor = Color.FromArgb(164, 165, 169);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmCrypto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmCrypto";
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Button button1;
        private Panel panelLogo;
        private Button button3;
        private Button button2;
        private Panel panelTitleBar;
        private Label lblTitle;
        private Label label1;
        private Panel panelDesktopPanel;
    }
}