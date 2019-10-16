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
            this.thisExpsenselbl = new System.Windows.Forms.Label();
            this.totalExpenselbl = new System.Windows.Forms.Label();
            this.thisMonthExpsenseCountlbl = new System.Windows.Forms.Label();
            this.totalExpsenseCountlbl = new System.Windows.Forms.Label();
            this.expenseMonthHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.expenseTotalHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.expenseTransactiontHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.expenseDashboardCTM = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expenseCashHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.expenseDashboardCTM.SuspendLayout();
            this.SuspendLayout();
            // 
            // expenseDashboardExpenseListView
            // 
            this.expenseDashboardExpenseListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.expenseMonthHeader,
            this.expenseTotalHeader,
            this.expenseTransactiontHeader,
            this.expenseCashHeader});
            this.expenseDashboardExpenseListView.Location = new System.Drawing.Point(12, 95);
            this.expenseDashboardExpenseListView.Name = "expenseDashboardExpenseListView";
            this.expenseDashboardExpenseListView.Size = new System.Drawing.Size(776, 343);
            this.expenseDashboardExpenseListView.TabIndex = 0;
            this.expenseDashboardExpenseListView.UseCompatibleStateImageBehavior = false;
            this.expenseDashboardExpenseListView.View = System.Windows.Forms.View.Details;
            // 
            // thisExpsenselbl
            // 
            this.thisExpsenselbl.AutoSize = true;
            this.thisExpsenselbl.Location = new System.Drawing.Point(12, 24);
            this.thisExpsenselbl.Name = "thisExpsenselbl";
            this.thisExpsenselbl.Size = new System.Drawing.Size(110, 13);
            this.thisExpsenselbl.TabIndex = 1;
            this.thisExpsenselbl.Text = "This Month Expense :";
            // 
            // totalExpenselbl
            // 
            this.totalExpenselbl.AutoSize = true;
            this.totalExpenselbl.Location = new System.Drawing.Point(12, 55);
            this.totalExpenselbl.Name = "totalExpenselbl";
            this.totalExpenselbl.Size = new System.Drawing.Size(84, 13);
            this.totalExpenselbl.TabIndex = 2;
            this.totalExpenselbl.Text = "Total  Expense :";
            // 
            // thisMonthExpsenseCountlbl
            // 
            this.thisMonthExpsenseCountlbl.AutoSize = true;
            this.thisMonthExpsenseCountlbl.Location = new System.Drawing.Point(129, 24);
            this.thisMonthExpsenseCountlbl.Name = "thisMonthExpsenseCountlbl";
            this.thisMonthExpsenseCountlbl.Size = new System.Drawing.Size(13, 13);
            this.thisMonthExpsenseCountlbl.TabIndex = 3;
            this.thisMonthExpsenseCountlbl.Text = "0";
            // 
            // totalExpsenseCountlbl
            // 
            this.totalExpsenseCountlbl.AutoSize = true;
            this.totalExpsenseCountlbl.Location = new System.Drawing.Point(129, 55);
            this.totalExpsenseCountlbl.Name = "totalExpsenseCountlbl";
            this.totalExpsenseCountlbl.Size = new System.Drawing.Size(13, 13);
            this.totalExpsenseCountlbl.TabIndex = 4;
            this.totalExpsenseCountlbl.Text = "0";
            // 
            // expenseMonthHeader
            // 
            this.expenseMonthHeader.Text = "Month";
            this.expenseMonthHeader.Width = 119;
            // 
            // expenseTotalHeader
            // 
            this.expenseTotalHeader.Text = "Total";
            this.expenseTotalHeader.Width = 127;
            // 
            // expenseTransactiontHeader
            // 
            this.expenseTransactiontHeader.Text = "Participant";
            this.expenseTransactiontHeader.Width = 131;
            // 
            // expenseDashboardCTM
            // 
            this.expenseDashboardCTM.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewDetailToolStripMenuItem});
            this.expenseDashboardCTM.Name = "expenseDashboardCTM";
            this.expenseDashboardCTM.Size = new System.Drawing.Size(133, 26);
            // 
            // viewDetailToolStripMenuItem
            // 
            this.viewDetailToolStripMenuItem.Name = "viewDetailToolStripMenuItem";
            this.viewDetailToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.viewDetailToolStripMenuItem.Text = "View Detail";
            // 
            // expenseCashHeader
            // 
            this.expenseCashHeader.Text = "Cash";
            // 
            // expenseDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.totalExpsenseCountlbl);
            this.Controls.Add(this.thisMonthExpsenseCountlbl);
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
        private System.Windows.Forms.Label thisMonthExpsenseCountlbl;
        private System.Windows.Forms.Label totalExpsenseCountlbl;
        private System.Windows.Forms.ColumnHeader expenseMonthHeader;
        private System.Windows.Forms.ColumnHeader expenseTotalHeader;
        private System.Windows.Forms.ColumnHeader expenseTransactiontHeader;
        private System.Windows.Forms.ContextMenuStrip expenseDashboardCTM;
        private System.Windows.Forms.ToolStripMenuItem viewDetailToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader expenseCashHeader;
    }
}