namespace Badminton_Club_System
{
    partial class expenseDashboard
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
            this.components = new System.ComponentModel.Container();
            this.expenseDashboardExpenseListView = new System.Windows.Forms.ListView();
            this.expenseMonthHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.expenseTransactiontHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.expenseCashHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.thisExpsenselbl = new System.Windows.Forms.Label();
            this.totalExpenselbl = new System.Windows.Forms.Label();
            this.expenseDashboardCTM = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expenseDashboardMonthExpense = new System.Windows.Forms.TextBox();
            this.expenseDashboardTotalTbox = new System.Windows.Forms.TextBox();
            this.expenseDashboardCTM.SuspendLayout();
            this.SuspendLayout();
            // 
            // expenseDashboardExpenseListView
            // 
            this.expenseDashboardExpenseListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.expenseMonthHeader,
            this.expenseTransactiontHeader,
            this.expenseCashHeader});
            this.expenseDashboardExpenseListView.GridLines = true;
            this.expenseDashboardExpenseListView.Location = new System.Drawing.Point(12, 95);
            this.expenseDashboardExpenseListView.Name = "expenseDashboardExpenseListView";
            this.expenseDashboardExpenseListView.Size = new System.Drawing.Size(776, 343);
            this.expenseDashboardExpenseListView.TabIndex = 0;
            this.expenseDashboardExpenseListView.UseCompatibleStateImageBehavior = false;
            this.expenseDashboardExpenseListView.View = System.Windows.Forms.View.Details;
            // 
            // expenseMonthHeader
            // 
            this.expenseMonthHeader.Text = "Month";
            this.expenseMonthHeader.Width = 119;
            // 
            // expenseTransactiontHeader
            // 
            this.expenseTransactiontHeader.Text = "Total Transaction";
            this.expenseTransactiontHeader.Width = 131;
            // 
            // expenseCashHeader
            // 
            this.expenseCashHeader.Text = "Expense";
            this.expenseCashHeader.Width = 95;
            // 
            // thisExpsenselbl
            // 
            this.thisExpsenselbl.AutoSize = true;
            this.thisExpsenselbl.Location = new System.Drawing.Point(12, 24);
            this.thisExpsenselbl.Name = "thisExpsenselbl";
            this.thisExpsenselbl.Size = new System.Drawing.Size(104, 13);
            this.thisExpsenselbl.TabIndex = 1;
            this.thisExpsenselbl.Text = "This Month Expense";
            // 
            // totalExpenselbl
            // 
            this.totalExpenselbl.AutoSize = true;
            this.totalExpenselbl.Location = new System.Drawing.Point(12, 55);
            this.totalExpenselbl.Name = "totalExpenselbl";
            this.totalExpenselbl.Size = new System.Drawing.Size(78, 13);
            this.totalExpenselbl.TabIndex = 2;
            this.totalExpenselbl.Text = "Total  Expense";
            // 
            // expenseDashboardCTM
            // 
            this.expenseDashboardCTM.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewDetailToolStripMenuItem});
            this.expenseDashboardCTM.Name = "expenseDashboardCTM";
            this.expenseDashboardCTM.Size = new System.Drawing.Size(127, 26);
            // 
            // viewDetailToolStripMenuItem
            // 
            this.viewDetailToolStripMenuItem.Name = "viewDetailToolStripMenuItem";
            this.viewDetailToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.viewDetailToolStripMenuItem.Text = "View Detail";
            // 
            // expenseDashboardMonthExpense
            // 
            this.expenseDashboardMonthExpense.Location = new System.Drawing.Point(140, 21);
            this.expenseDashboardMonthExpense.Name = "expenseDashboardMonthExpense";
            this.expenseDashboardMonthExpense.Size = new System.Drawing.Size(148, 20);
            this.expenseDashboardMonthExpense.TabIndex = 5;
            // 
            // expenseDashboardTotalTbox
            // 
            this.expenseDashboardTotalTbox.Location = new System.Drawing.Point(140, 52);
            this.expenseDashboardTotalTbox.Name = "expenseDashboardTotalTbox";
            this.expenseDashboardTotalTbox.Size = new System.Drawing.Size(148, 20);
            this.expenseDashboardTotalTbox.TabIndex = 6;
            // 
            // expenseDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 546);
            this.Controls.Add(this.expenseDashboardTotalTbox);
            this.Controls.Add(this.expenseDashboardMonthExpense);
            this.Controls.Add(this.totalExpenselbl);
            this.Controls.Add(this.thisExpsenselbl);
            this.Controls.Add(this.expenseDashboardExpenseListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "expenseDashboard";
            this.Text = "expenseDashboard";
            this.expenseDashboardCTM.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView expenseDashboardExpenseListView;
        private System.Windows.Forms.Label thisExpsenselbl;
        private System.Windows.Forms.Label totalExpenselbl;
        private System.Windows.Forms.ColumnHeader expenseMonthHeader;
        private System.Windows.Forms.ColumnHeader expenseTransactiontHeader;
        private System.Windows.Forms.ContextMenuStrip expenseDashboardCTM;
        private System.Windows.Forms.ToolStripMenuItem viewDetailToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader expenseCashHeader;
        private System.Windows.Forms.TextBox expenseDashboardMonthExpense;
        private System.Windows.Forms.TextBox expenseDashboardTotalTbox;
    }
}