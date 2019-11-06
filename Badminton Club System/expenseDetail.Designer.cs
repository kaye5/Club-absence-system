namespace Badminton_Club_System
{
    partial class expenseDetail
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
            this.expenseDetailMonthlbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.totalExpenseTbox = new System.Windows.Forms.TextBox();
            this.ttTbox = new System.Windows.Forms.TextBox();
            this.expenseDetailListView = new System.Windows.Forms.ListView();
            this.expenseDateHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.expenseTransactionHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.expensePriceHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.expenseCommentHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.monthTbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // expenseDetailMonthlbl
            // 
            this.expenseDetailMonthlbl.AutoSize = true;
            this.expenseDetailMonthlbl.Location = new System.Drawing.Point(12, 20);
            this.expenseDetailMonthlbl.Name = "expenseDetailMonthlbl";
            this.expenseDetailMonthlbl.Size = new System.Drawing.Size(37, 13);
            this.expenseDetailMonthlbl.TabIndex = 0;
            this.expenseDetailMonthlbl.Text = "Month";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total Expense";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(253, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total Transaction";
            // 
            // totalExpenseTbox
            // 
            this.totalExpenseTbox.Enabled = false;
            this.totalExpenseTbox.Location = new System.Drawing.Point(103, 47);
            this.totalExpenseTbox.Name = "totalExpenseTbox";
            this.totalExpenseTbox.ReadOnly = true;
            this.totalExpenseTbox.Size = new System.Drawing.Size(131, 20);
            this.totalExpenseTbox.TabIndex = 3;
            // 
            // ttTbox
            // 
            this.ttTbox.Enabled = false;
            this.ttTbox.Location = new System.Drawing.Point(349, 47);
            this.ttTbox.Name = "ttTbox";
            this.ttTbox.ReadOnly = true;
            this.ttTbox.Size = new System.Drawing.Size(131, 20);
            this.ttTbox.TabIndex = 4;
            // 
            // expenseDetailListView
            // 
            this.expenseDetailListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.expenseDateHeader,
            this.expenseTransactionHeader,
            this.expensePriceHeader,
            this.expenseCommentHeader});
            this.expenseDetailListView.GridLines = true;
            this.expenseDetailListView.Location = new System.Drawing.Point(12, 73);
            this.expenseDetailListView.Name = "expenseDetailListView";
            this.expenseDetailListView.Size = new System.Drawing.Size(773, 327);
            this.expenseDetailListView.TabIndex = 5;
            this.expenseDetailListView.UseCompatibleStateImageBehavior = false;
            this.expenseDetailListView.View = System.Windows.Forms.View.Details;
            // 
            // expenseDateHeader
            // 
            this.expenseDateHeader.Text = "Transaction Date";
            this.expenseDateHeader.Width = 147;
            // 
            // expenseTransactionHeader
            // 
            this.expenseTransactionHeader.Text = "Transaction";
            this.expenseTransactionHeader.Width = 172;
            // 
            // expensePriceHeader
            // 
            this.expensePriceHeader.Text = "Price";
            this.expensePriceHeader.Width = 144;
            // 
            // expenseCommentHeader
            // 
            this.expenseCommentHeader.Text = "Comment";
            this.expenseCommentHeader.Width = 119;
            // 
            // monthTbox
            // 
            this.monthTbox.Enabled = false;
            this.monthTbox.Location = new System.Drawing.Point(103, 17);
            this.monthTbox.Name = "monthTbox";
            this.monthTbox.ReadOnly = true;
            this.monthTbox.Size = new System.Drawing.Size(128, 20);
            this.monthTbox.TabIndex = 6;
            // 
            // expenseDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(980, 610);
            this.Controls.Add(this.monthTbox);
            this.Controls.Add(this.expenseDetailListView);
            this.Controls.Add(this.ttTbox);
            this.Controls.Add(this.totalExpenseTbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.expenseDetailMonthlbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "expenseDetail";
            this.Text = "expenseDetail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label expenseDetailMonthlbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox totalExpenseTbox;
        private System.Windows.Forms.TextBox ttTbox;
        private System.Windows.Forms.ListView expenseDetailListView;
        private System.Windows.Forms.ColumnHeader expenseTransactionHeader;
        private System.Windows.Forms.ColumnHeader expensePriceHeader;
        private System.Windows.Forms.ColumnHeader expenseCommentHeader;
        private System.Windows.Forms.ColumnHeader expenseDateHeader;
        private System.Windows.Forms.TextBox monthTbox;
    }
}