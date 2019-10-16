namespace Badminton_Club_System
{
    partial class cashDetail
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
            this.cashDetailListView = new System.Windows.Forms.ListView();
            this.IncomeDateHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IncomeTransactionHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.expensePriceHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.expenseCommentHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cashDetailTransTbox = new System.Windows.Forms.TextBox();
            this.cashDetailTotalTbox = new System.Windows.Forms.TextBox();
            this.cashDetailTotalTransLbl = new System.Windows.Forms.Label();
            this.cashDetailTotalLbl = new System.Windows.Forms.Label();
            this.cashDetailMonthlbl = new System.Windows.Forms.Label();
            this.cashDetailMemberIncomeLbl = new System.Windows.Forms.Label();
            this.cashDetailMemberIncomeTbox = new System.Windows.Forms.TextBox();
            this.cashDetailTotalMemberTbox = new System.Windows.Forms.TextBox();
            this.cashDetaiTotallMemberIncomeLbl = new System.Windows.Forms.Label();
            this.cashDetailOtherLbl = new System.Windows.Forms.Label();
            this.cashDetailOtherTbox = new System.Windows.Forms.TextBox();
            this.cashDetailDeleteBtn = new System.Windows.Forms.Button();
            this.cashDetailAddBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cashDetailListView
            // 
            this.cashDetailListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IncomeDateHeader,
            this.IncomeTransactionHeader,
            this.expensePriceHeader,
            this.expenseCommentHeader});
            this.cashDetailListView.GridLines = true;
            this.cashDetailListView.Location = new System.Drawing.Point(14, 81);
            this.cashDetailListView.Name = "cashDetailListView";
            this.cashDetailListView.Size = new System.Drawing.Size(773, 316);
            this.cashDetailListView.TabIndex = 11;
            this.cashDetailListView.UseCompatibleStateImageBehavior = false;
            this.cashDetailListView.View = System.Windows.Forms.View.Details;
            // 
            // IncomeDateHeader
            // 
            this.IncomeDateHeader.Text = "Transaction Date";
            this.IncomeDateHeader.Width = 137;
            // 
            // IncomeTransactionHeader
            // 
            this.IncomeTransactionHeader.Text = "Transaction";
            this.IncomeTransactionHeader.Width = 172;
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
            // cashDetailTransTbox
            // 
            this.cashDetailTransTbox.Location = new System.Drawing.Point(407, 13);
            this.cashDetailTransTbox.Name = "cashDetailTransTbox";
            this.cashDetailTransTbox.Size = new System.Drawing.Size(70, 20);
            this.cashDetailTransTbox.TabIndex = 10;
            // 
            // cashDetailTotalTbox
            // 
            this.cashDetailTotalTbox.Location = new System.Drawing.Point(158, 13);
            this.cashDetailTotalTbox.Name = "cashDetailTotalTbox";
            this.cashDetailTotalTbox.Size = new System.Drawing.Size(131, 20);
            this.cashDetailTotalTbox.TabIndex = 9;
            // 
            // cashDetailTotalTransLbl
            // 
            this.cashDetailTotalTransLbl.AutoSize = true;
            this.cashDetailTotalTransLbl.Location = new System.Drawing.Point(311, 16);
            this.cashDetailTotalTransLbl.Name = "cashDetailTotalTransLbl";
            this.cashDetailTotalTransLbl.Size = new System.Drawing.Size(90, 13);
            this.cashDetailTotalTransLbl.TabIndex = 8;
            this.cashDetailTotalTransLbl.Text = "Total Transaction";
            // 
            // cashDetailTotalLbl
            // 
            this.cashDetailTotalLbl.AutoSize = true;
            this.cashDetailTotalLbl.Location = new System.Drawing.Point(83, 16);
            this.cashDetailTotalLbl.Name = "cashDetailTotalLbl";
            this.cashDetailTotalLbl.Size = new System.Drawing.Size(69, 13);
            this.cashDetailTotalLbl.TabIndex = 7;
            this.cashDetailTotalLbl.Text = "Total Income";
            // 
            // cashDetailMonthlbl
            // 
            this.cashDetailMonthlbl.AutoSize = true;
            this.cashDetailMonthlbl.Location = new System.Drawing.Point(499, 49);
            this.cashDetailMonthlbl.Name = "cashDetailMonthlbl";
            this.cashDetailMonthlbl.Size = new System.Drawing.Size(37, 13);
            this.cashDetailMonthlbl.TabIndex = 6;
            this.cashDetailMonthlbl.Text = "Month";
            // 
            // cashDetailMemberIncomeLbl
            // 
            this.cashDetailMemberIncomeLbl.AutoSize = true;
            this.cashDetailMemberIncomeLbl.Location = new System.Drawing.Point(69, 46);
            this.cashDetailMemberIncomeLbl.Name = "cashDetailMemberIncomeLbl";
            this.cashDetailMemberIncomeLbl.Size = new System.Drawing.Size(83, 13);
            this.cashDetailMemberIncomeLbl.TabIndex = 12;
            this.cashDetailMemberIncomeLbl.Text = "Member Income";
            // 
            // cashDetailMemberIncomeTbox
            // 
            this.cashDetailMemberIncomeTbox.Location = new System.Drawing.Point(158, 46);
            this.cashDetailMemberIncomeTbox.Name = "cashDetailMemberIncomeTbox";
            this.cashDetailMemberIncomeTbox.Size = new System.Drawing.Size(131, 20);
            this.cashDetailMemberIncomeTbox.TabIndex = 13;
            // 
            // cashDetailTotalMemberTbox
            // 
            this.cashDetailTotalMemberTbox.Location = new System.Drawing.Point(407, 46);
            this.cashDetailTotalMemberTbox.Name = "cashDetailTotalMemberTbox";
            this.cashDetailTotalMemberTbox.Size = new System.Drawing.Size(70, 20);
            this.cashDetailTotalMemberTbox.TabIndex = 14;
            // 
            // cashDetaiTotallMemberIncomeLbl
            // 
            this.cashDetaiTotallMemberIncomeLbl.AutoSize = true;
            this.cashDetaiTotallMemberIncomeLbl.Location = new System.Drawing.Point(329, 49);
            this.cashDetaiTotallMemberIncomeLbl.Name = "cashDetaiTotallMemberIncomeLbl";
            this.cashDetaiTotallMemberIncomeLbl.Size = new System.Drawing.Size(72, 13);
            this.cashDetaiTotallMemberIncomeLbl.TabIndex = 15;
            this.cashDetaiTotallMemberIncomeLbl.Text = "Total Member";
            // 
            // cashDetailOtherLbl
            // 
            this.cashDetailOtherLbl.AutoSize = true;
            this.cashDetailOtherLbl.Location = new System.Drawing.Point(499, 16);
            this.cashDetailOtherLbl.Name = "cashDetailOtherLbl";
            this.cashDetailOtherLbl.Size = new System.Drawing.Size(71, 13);
            this.cashDetailOtherLbl.TabIndex = 16;
            this.cashDetailOtherLbl.Text = "Other Income";
            // 
            // cashDetailOtherTbox
            // 
            this.cashDetailOtherTbox.Location = new System.Drawing.Point(576, 13);
            this.cashDetailOtherTbox.Name = "cashDetailOtherTbox";
            this.cashDetailOtherTbox.Size = new System.Drawing.Size(131, 20);
            this.cashDetailOtherTbox.TabIndex = 17;
            // 
            // cashDetailDeleteBtn
            // 
            this.cashDetailDeleteBtn.Location = new System.Drawing.Point(14, 413);
            this.cashDetailDeleteBtn.Name = "cashDetailDeleteBtn";
            this.cashDetailDeleteBtn.Size = new System.Drawing.Size(117, 23);
            this.cashDetailDeleteBtn.TabIndex = 18;
            this.cashDetailDeleteBtn.Text = "Delete";
            this.cashDetailDeleteBtn.UseVisualStyleBackColor = true;
            // 
            // cashDetailAddBtn
            // 
            this.cashDetailAddBtn.Location = new System.Drawing.Point(137, 413);
            this.cashDetailAddBtn.Name = "cashDetailAddBtn";
            this.cashDetailAddBtn.Size = new System.Drawing.Size(117, 23);
            this.cashDetailAddBtn.TabIndex = 19;
            this.cashDetailAddBtn.Text = "Add";
            this.cashDetailAddBtn.UseVisualStyleBackColor = true;
            // 
            // cashDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cashDetailAddBtn);
            this.Controls.Add(this.cashDetailDeleteBtn);
            this.Controls.Add(this.cashDetailOtherTbox);
            this.Controls.Add(this.cashDetailOtherLbl);
            this.Controls.Add(this.cashDetaiTotallMemberIncomeLbl);
            this.Controls.Add(this.cashDetailTotalMemberTbox);
            this.Controls.Add(this.cashDetailMemberIncomeTbox);
            this.Controls.Add(this.cashDetailMemberIncomeLbl);
            this.Controls.Add(this.cashDetailListView);
            this.Controls.Add(this.cashDetailTransTbox);
            this.Controls.Add(this.cashDetailTotalTbox);
            this.Controls.Add(this.cashDetailTotalTransLbl);
            this.Controls.Add(this.cashDetailTotalLbl);
            this.Controls.Add(this.cashDetailMonthlbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "cashDetail";
            this.Text = "incomeDetail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView cashDetailListView;
        private System.Windows.Forms.ColumnHeader IncomeDateHeader;
        private System.Windows.Forms.ColumnHeader IncomeTransactionHeader;
        private System.Windows.Forms.ColumnHeader expensePriceHeader;
        private System.Windows.Forms.ColumnHeader expenseCommentHeader;
        private System.Windows.Forms.TextBox cashDetailTransTbox;
        private System.Windows.Forms.TextBox cashDetailTotalTbox;
        private System.Windows.Forms.Label cashDetailTotalTransLbl;
        private System.Windows.Forms.Label cashDetailTotalLbl;
        private System.Windows.Forms.Label cashDetailMonthlbl;
        private System.Windows.Forms.Label cashDetailMemberIncomeLbl;
        private System.Windows.Forms.TextBox cashDetailMemberIncomeTbox;
        private System.Windows.Forms.TextBox cashDetailTotalMemberTbox;
        private System.Windows.Forms.Label cashDetaiTotallMemberIncomeLbl;
        private System.Windows.Forms.Label cashDetailOtherLbl;
        private System.Windows.Forms.TextBox cashDetailOtherTbox;
        private System.Windows.Forms.Button cashDetailDeleteBtn;
        private System.Windows.Forms.Button cashDetailAddBtn;
    }
}