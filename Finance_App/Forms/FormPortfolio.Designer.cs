namespace Finance_App.Forms
{
    partial class FormPortfolio
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
            label1 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(256, 584);
            label1.Name = "label1";
            label1.Size = new Size(645, 32);
            label1.TabIndex = 21;
            label1.Text = "This process may take some time. Please wait...";
            // 
            // FormPortfolio
            // 
            AutoScaleDimensions = new SizeF(17F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1092, 625);
            Controls.Add(label1);
            Font = new Font("Arial", 10.125F, FontStyle.Bold);
            ForeColor = Color.FromArgb(164, 165, 169);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormPortfolio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormPortfolio";
            Load += FormPortfolio_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
    }
}