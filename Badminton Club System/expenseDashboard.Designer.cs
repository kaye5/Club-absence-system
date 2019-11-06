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
            this.expenseListView = new System.Windows.Forms.ListView();
            this.expenseMonthHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.expenseCashHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.thisExpsenselbl = new System.Windows.Forms.Label();
            this.transTboxLabel = new System.Windows.Forms.Label();
            this.expenseDashboardCTM = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expenseTbox = new System.Windows.Forms.TextBox();
            this.transTbox = new System.Windows.Forms.TextBox();
            this.expenseDashboardCTM.SuspendLayout();
            this.SuspendLayout();
            // 
            // expenseListView
            // 
            this.expenseListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.expenseMonthHeader,
            this.expenseCashHeader});
            this.expenseListView.GridLines = true;
            this.expenseListView.Location = new System.Drawing.Point(12, 95);
            this.expenseListView.Name = "expenseListView";
            this.expenseListView.Size = new System.Drawing.Size(776, 343);
            this.expenseListView.TabIndex = 0;
            this.expenseListView.UseCompatibleStateImageBehavior = false;
            this.expenseListView.View = System.Windows.Forms.View.Details;
            // 
            // expenseMonthHeader
            // 
            this.expenseMonthHeader.Text = "Month";
            this.expenseMonthHeader.Width = 119;
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
            // transTboxLabel
            // 
            this.transTboxLabel.AutoSize = true;
            this.transTboxLabel.Location = new System.Drawing.Point(12, 55);
            this.transTboxLabel.Name = "transTboxLabel";
            this.transTboxLabel.Size = new System.Drawing.Size(93, 13);
            this.transTboxLabel.TabIndex = 2;
            this.transTboxLabel.Text = "Total  Transaction";
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
            // expenseTbox
            // 
            this.expenseTbox.Enabled = false;
            this.expenseTbox.Location = new System.Drawing.Point(140, 21);
            this.expenseTbox.Name = "expenseTbox";
            this.expenseTbox.ReadOnly = true;
            this.expenseTbox.Size = new System.Drawing.Size(148, 20);
            this.expenseTbox.TabIndex = 5;
            // 
            // transTbox
            // 
            this.transTbox.Enabled = false;
            this.transTbox.Location = new System.Drawing.Point(140, 52);
            this.transTbox.Name = "transTbox";
            this.transTbox.ReadOnly = true;
            this.transTbox.Size = new System.Drawing.Size(148, 20);
            this.transTbox.TabIndex = 6;
            // 
            // expenseDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(980, 610);
            this.Controls.Add(this.transTbox);
            this.Controls.Add(this.expenseTbox);
            this.Controls.Add(this.transTboxLabel);
            this.Controls.Add(this.thisExpsenselbl);
            this.Controls.Add(this.expenseListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "expenseDashboard";
            this.Text = "expenseDashboard";
            this.expenseDashboardCTM.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView expenseListView;
        private System.Windows.Forms.Label thisExpsenselbl;
        private System.Windows.Forms.Label transTboxLabel;
        private System.Windows.Forms.ColumnHeader expenseMonthHeader;
        private System.Windows.Forms.ContextMenuStrip expenseDashboardCTM;
        private System.Windows.Forms.ToolStripMenuItem viewDetailToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader expenseCashHeader;
        private System.Windows.Forms.TextBox expenseTbox;
        private System.Windows.Forms.TextBox transTbox;
    }
}