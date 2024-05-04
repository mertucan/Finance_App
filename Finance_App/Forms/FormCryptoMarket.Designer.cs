namespace Finance_App.Forms
{
    partial class FormCryptoMarket
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            txtSearch = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            txtPrice = new TextBox();
            label3 = new Label();
            label4 = new Label();
            button2 = new Button();
            label5 = new Label();
            txtName = new TextBox();
            label6 = new Label();
            txtAmount = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.WhiteSmoke;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(20, 25, 70);
            dataGridViewCellStyle1.Font = new Font("Arial", 10.125F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Arial", 10.125F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(164, 165, 169);
            dataGridViewCellStyle2.SelectionBackColor = Color.ForestGreen;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(25, 88);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(721, 483);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.WhiteSmoke;
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Arial", 13.125F);
            txtSearch.Location = new Point(86, 16);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(265, 47);
            txtSearch.TabIndex = 14;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSlateBlue;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(383, 16);
            button1.Name = "button1";
            button1.Size = new Size(281, 47);
            button1.TabIndex = 20;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 588);
            label1.Name = "label1";
            label1.Size = new Size(645, 32);
            label1.TabIndex = 22;
            label1.Text = "This process may take some time. Please wait...";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(759, 136);
            label2.Name = "label2";
            label2.Size = new Size(137, 32);
            label2.TabIndex = 23;
            label2.Text = "Balance: ";
            // 
            // txtPrice
            // 
            txtPrice.BackColor = Color.WhiteSmoke;
            txtPrice.BorderStyle = BorderStyle.FixedSingle;
            txtPrice.Font = new Font("Arial", 13.125F);
            txtPrice.Location = new Point(889, 286);
            txtPrice.Multiline = true;
            txtPrice.Name = "txtPrice";
            txtPrice.ReadOnly = true;
            txtPrice.Size = new Size(181, 47);
            txtPrice.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(759, 295);
            label3.Name = "label3";
            label3.Size = new Size(81, 32);
            label3.TabIndex = 25;
            label3.Text = "Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(759, 374);
            label4.Name = "label4";
            label4.Size = new Size(119, 32);
            label4.TabIndex = 27;
            label4.Text = "Amount";
            // 
            // button2
            // 
            button2.BackColor = Color.DarkSlateBlue;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(889, 510);
            button2.Name = "button2";
            button2.Size = new Size(181, 61);
            button2.TabIndex = 28;
            button2.Text = "Buy";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(759, 206);
            label5.Name = "label5";
            label5.Size = new Size(90, 32);
            label5.TabIndex = 30;
            label5.Text = "Name";
            // 
            // txtName
            // 
            txtName.BackColor = Color.WhiteSmoke;
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Font = new Font("Arial", 13.125F);
            txtName.Location = new Point(889, 197);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(181, 47);
            txtName.TabIndex = 29;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(759, 429);
            label6.Name = "label6";
            label6.Size = new Size(238, 32);
            label6.TabIndex = 31;
            label6.Text = "Payment: $ 00.00";
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(889, 371);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(181, 39);
            txtAmount.TabIndex = 32;
            txtAmount.TextChanged += txtAmount_TextChanged_1;
            // 
            // FormCryptoMarket
            // 
            AutoScaleDimensions = new SizeF(17F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1092, 625);
            Controls.Add(txtAmount);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtName);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtPrice);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(txtSearch);
            Controls.Add(dataGridView1);
            Font = new Font("Arial", 10.125F, FontStyle.Bold);
            ForeColor = Color.FromArgb(164, 165, 169);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormCryptoMarket";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCryptoMarket";
            Load += FormCryptoMarket_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txtSearch;
        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox txtPrice;
        private Label label3;
        private Label label4;
        private Button button2;
        private Label label5;
        private TextBox txtName;
        private Label label6;
        private TextBox txtAmount;
    }
}