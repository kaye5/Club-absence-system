namespace Badminton_Club_System
{
    partial class incomeDashboard
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
            this.incomeTable = new System.Windows.Forms.ListView();
            this.incomeMonthHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.incomeCashHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.incomeTransactiontHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.incomeDashboardTotalTbox = new System.Windows.Forms.TextBox();
            this.incomeDashboardMonthIncome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // incomeTable
            // 
            this.incomeTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.incomeMonthHeader,
            this.incomeCashHeader,
            this.incomeTransactiontHeader});
            this.incomeTable.FullRowSelect = true;
            this.incomeTable.GridLines = true;
            this.incomeTable.Location = new System.Drawing.Point(12, 95);
            this.incomeTable.Name = "incomeTable";
            this.incomeTable.Size = new System.Drawing.Size(776, 343);
            this.incomeTable.TabIndex = 5;
            this.incomeTable.UseCompatibleStateImageBehavior = false;
            this.incomeTable.View = System.Windows.Forms.View.Details;
            // 
            // incomeMonthHeader
            // 
            this.incomeMonthHeader.Text = "Month";
            this.incomeMonthHeader.Width = 138;
            // 
            // incomeCashHeader
            // 
            this.incomeCashHeader.Text = "Income";
            this.incomeCashHeader.Width = 137;
            // 
            // incomeTransactiontHeader
            // 
            this.incomeTransactiontHeader.Text = "Total Transaction";
            this.incomeTransactiontHeader.Width = 131;
            // 
            // incomeDashboardTotalTbox
            // 
            this.incomeDashboardTotalTbox.Enabled = false;
            this.incomeDashboardTotalTbox.Location = new System.Drawing.Point(140, 53);
            this.incomeDashboardTotalTbox.Name = "incomeDashboardTotalTbox";
            this.incomeDashboardTotalTbox.ReadOnly = true;
            this.incomeDashboardTotalTbox.Size = new System.Drawing.Size(148, 20);
            this.incomeDashboardTotalTbox.TabIndex = 10;
            // 
            // incomeDashboardMonthIncome
            // 
            this.incomeDashboardMonthIncome.Enabled = false;
            this.incomeDashboardMonthIncome.Location = new System.Drawing.Point(140, 22);
            this.incomeDashboardMonthIncome.Name = "incomeDashboardMonthIncome";
            this.incomeDashboardMonthIncome.ReadOnly = true;
            this.incomeDashboardMonthIncome.Size = new System.Drawing.Size(148, 20);
            this.incomeDashboardMonthIncome.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Total  Income";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "This Month Income";
            // 
            // incomeDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.incomeDashboardTotalTbox);
            this.Controls.Add(this.incomeDashboardMonthIncome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.incomeTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "incomeDashboard";
            this.Text = "incomeDashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView incomeTable;
        private System.Windows.Forms.ColumnHeader incomeMonthHeader;
        private System.Windows.Forms.ColumnHeader incomeTransactiontHeader;
        private System.Windows.Forms.ColumnHeader incomeCashHeader;
        private System.Windows.Forms.TextBox incomeDashboardTotalTbox;
        private System.Windows.Forms.TextBox incomeDashboardMonthIncome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}