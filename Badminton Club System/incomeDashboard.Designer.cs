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
            this.totalExpenselbl = new System.Windows.Forms.Label();
            this.thisIncomelbl = new System.Windows.Forms.Label();
            this.expenseDashboardExpenseListView = new System.Windows.Forms.ListView();
            this.incomeMonthHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.incomeTotalHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.incomeTransactiontHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.incomeCashHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // totalExpenselbl
            // 
            this.totalExpenselbl.AutoSize = true;
            this.totalExpenselbl.Location = new System.Drawing.Point(12, 56);
            this.totalExpenselbl.Name = "totalExpenselbl";
            this.totalExpenselbl.Size = new System.Drawing.Size(78, 13);
            this.totalExpenselbl.TabIndex = 4;
            this.totalExpenselbl.Text = "Total  Income :";
            // 
            // thisIncomelbl
            // 
            this.thisIncomelbl.AutoSize = true;
            this.thisIncomelbl.Location = new System.Drawing.Point(12, 25);
            this.thisIncomelbl.Name = "thisIncomelbl";
            this.thisIncomelbl.Size = new System.Drawing.Size(104, 13);
            this.thisIncomelbl.TabIndex = 3;
            this.thisIncomelbl.Text = "This Month Income :";
            // 
            // expenseDashboardExpenseListView
            // 
            this.expenseDashboardExpenseListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.incomeMonthHeader,
            this.incomeTransactiontHeader,
            this.incomeTotalHeader,
            this.incomeCashHeader});
            this.expenseDashboardExpenseListView.Location = new System.Drawing.Point(12, 95);
            this.expenseDashboardExpenseListView.Name = "expenseDashboardExpenseListView";
            this.expenseDashboardExpenseListView.Size = new System.Drawing.Size(776, 343);
            this.expenseDashboardExpenseListView.TabIndex = 5;
            this.expenseDashboardExpenseListView.UseCompatibleStateImageBehavior = false;
            this.expenseDashboardExpenseListView.View = System.Windows.Forms.View.Details;
            // 
            // incomeMonthHeader
            // 
            this.incomeMonthHeader.Text = "Month";
            this.incomeMonthHeader.Width = 119;
            // 
            // incomeTotalHeader
            // 
            this.incomeTotalHeader.DisplayIndex = 1;
            this.incomeTotalHeader.Text = "Total";
            this.incomeTotalHeader.Width = 127;
            // 
            // incomeTransactiontHeader
            // 
            this.incomeTransactiontHeader.DisplayIndex = 2;
            this.incomeTransactiontHeader.Text = "Participant";
            this.incomeTransactiontHeader.Width = 131;
            // 
            // incomeCashHeader
            // 
            this.incomeCashHeader.Text = "Cash";
            // 
            // incomeDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.expenseDashboardExpenseListView);
            this.Controls.Add(this.totalExpenselbl);
            this.Controls.Add(this.thisIncomelbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "incomeDashboard";
            this.Text = "incomeDashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label totalExpenselbl;
        private System.Windows.Forms.Label thisIncomelbl;
        private System.Windows.Forms.ListView expenseDashboardExpenseListView;
        private System.Windows.Forms.ColumnHeader incomeMonthHeader;
        private System.Windows.Forms.ColumnHeader incomeTransactiontHeader;
        private System.Windows.Forms.ColumnHeader incomeTotalHeader;
        private System.Windows.Forms.ColumnHeader incomeCashHeader;
    }
}