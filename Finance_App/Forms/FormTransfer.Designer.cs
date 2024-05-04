namespace Finance_App.Forms
{
    partial class FormTransfer
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
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            txtBalance = new TextBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(435, 90);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(187, 51);
            label2.TabIndex = 6;
            label2.Text = "Balance";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(459, 162);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(144, 44);
            label1.TabIndex = 7;
            label1.Text = "$ 00.00";
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSlateBlue;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(401, 408);
            button1.Name = "button1";
            button1.Size = new Size(265, 62);
            button1.TabIndex = 22;
            button1.Text = "Transfer";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtBalance
            // 
            txtBalance.BackColor = Color.WhiteSmoke;
            txtBalance.BorderStyle = BorderStyle.FixedSingle;
            txtBalance.Font = new Font("Arial", 13.125F);
            txtBalance.Location = new Point(401, 283);
            txtBalance.Multiline = true;
            txtBalance.Name = "txtBalance";
            txtBalance.Size = new Size(265, 47);
            txtBalance.TabIndex = 21;
            // 
            // FormTransfer
            // 
            AutoScaleDimensions = new SizeF(17F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1092, 625);
            Controls.Add(button1);
            Controls.Add(txtBalance);
            Controls.Add(label1);
            Controls.Add(label2);
            Font = new Font("Arial", 10.125F, FontStyle.Bold);
            ForeColor = Color.FromArgb(164, 165, 169);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormTransfer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormTransfer";
            Load += FormTransfer_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Button button1;
        private TextBox txtBalance;
    }
}