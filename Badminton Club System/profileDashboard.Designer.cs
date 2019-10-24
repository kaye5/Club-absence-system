namespace Badminton_Club_System
{
    partial class profileDashboard
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.profileExpenseBtn = new System.Windows.Forms.Button();
            this.profileMemberBtn = new System.Windows.Forms.Button();
            this.profileExpenseTbox = new System.Windows.Forms.TextBox();
            this.profileIncomeTbox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.profileUpdateFeeBtn = new System.Windows.Forms.Button();
            this.profileChangeFeeBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.profileNewCoorBtn = new System.Windows.Forms.Button();
            this.profileActionPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.profileAddCoorBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.profileUpdateCoorBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.profilePassTbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.profilePositionTbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.profileEmailTbox = new System.Windows.Forms.TextBox();
            this.profileNimTBox = new System.Windows.Forms.TextBox();
            this.profileNameTbox = new System.Windows.Forms.TextBox();
            this.profileListView = new System.Windows.Forms.ListView();
            this.emailHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.passHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.positionHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NIMHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.profileMonthLbl = new System.Windows.Forms.Label();
            this.profileFeeTbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.profileInventoryBtn = new System.Windows.Forms.Button();
            this.profileViewIncomeButton = new System.Windows.Forms.Button();
            this.profileCashTextBox = new System.Windows.Forms.TextBox();
            this.profileKasLabel = new System.Windows.Forms.Label();
            this.profileAbsenceBtn = new System.Windows.Forms.Button();
            this.coorCTMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileActionPanel.SuspendLayout();
            this.coorCTMS.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(133, 330);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 51;
            // 
            // profileExpenseBtn
            // 
            this.profileExpenseBtn.AccessibleDescription = "3";
            this.profileExpenseBtn.Location = new System.Drawing.Point(121, 289);
            this.profileExpenseBtn.Name = "profileExpenseBtn";
            this.profileExpenseBtn.Size = new System.Drawing.Size(131, 23);
            this.profileExpenseBtn.TabIndex = 50;
            this.profileExpenseBtn.Text = "View Expense";
            this.profileExpenseBtn.UseVisualStyleBackColor = true;
            this.profileExpenseBtn.Click += new System.EventHandler(this.profileChangeTabBtn_Click);
            // 
            // profileMemberBtn
            // 
            this.profileMemberBtn.AccessibleDescription = "2";
            this.profileMemberBtn.Location = new System.Drawing.Point(9, 330);
            this.profileMemberBtn.Name = "profileMemberBtn";
            this.profileMemberBtn.Size = new System.Drawing.Size(109, 23);
            this.profileMemberBtn.TabIndex = 49;
            this.profileMemberBtn.Text = "View Member";
            this.profileMemberBtn.UseVisualStyleBackColor = true;
            this.profileMemberBtn.Click += new System.EventHandler(this.profileChangeTabBtn_Click);
            // 
            // profileExpenseTbox
            // 
            this.profileExpenseTbox.Location = new System.Drawing.Point(121, 254);
            this.profileExpenseTbox.Name = "profileExpenseTbox";
            this.profileExpenseTbox.ReadOnly = true;
            this.profileExpenseTbox.Size = new System.Drawing.Size(131, 20);
            this.profileExpenseTbox.TabIndex = 48;
            // 
            // profileIncomeTbox
            // 
            this.profileIncomeTbox.Location = new System.Drawing.Point(121, 175);
            this.profileIncomeTbox.Name = "profileIncomeTbox";
            this.profileIncomeTbox.ReadOnly = true;
            this.profileIncomeTbox.Size = new System.Drawing.Size(131, 20);
            this.profileIncomeTbox.TabIndex = 47;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 257);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 13);
            this.label10.TabIndex = 46;
            this.label10.Text = "This Month Expense";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 178);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 13);
            this.label9.TabIndex = 45;
            this.label9.Text = "This Month Income";
            // 
            // profileUpdateFeeBtn
            // 
            this.profileUpdateFeeBtn.Location = new System.Drawing.Point(258, 126);
            this.profileUpdateFeeBtn.Name = "profileUpdateFeeBtn";
            this.profileUpdateFeeBtn.Size = new System.Drawing.Size(94, 23);
            this.profileUpdateFeeBtn.TabIndex = 44;
            this.profileUpdateFeeBtn.Text = "Update";
            this.profileUpdateFeeBtn.UseVisualStyleBackColor = true;
            this.profileUpdateFeeBtn.Visible = false;
            this.profileUpdateFeeBtn.Click += new System.EventHandler(this.profileUpdateFeeBtn_Click);
            // 
            // profileChangeFeeBtn
            // 
            this.profileChangeFeeBtn.Location = new System.Drawing.Point(121, 126);
            this.profileChangeFeeBtn.Name = "profileChangeFeeBtn";
            this.profileChangeFeeBtn.Size = new System.Drawing.Size(131, 22);
            this.profileChangeFeeBtn.TabIndex = 43;
            this.profileChangeFeeBtn.Text = "change";
            this.profileChangeFeeBtn.UseVisualStyleBackColor = true;
            this.profileChangeFeeBtn.Click += new System.EventHandler(this.profileChangeFeeBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(603, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 42;
            this.label8.Text = "Coordinator";
            // 
            // profileNewCoorBtn
            // 
            this.profileNewCoorBtn.Location = new System.Drawing.Point(372, 330);
            this.profileNewCoorBtn.Name = "profileNewCoorBtn";
            this.profileNewCoorBtn.Size = new System.Drawing.Size(120, 37);
            this.profileNewCoorBtn.TabIndex = 41;
            this.profileNewCoorBtn.Text = "New Coordinator";
            this.profileNewCoorBtn.UseVisualStyleBackColor = true;
            this.profileNewCoorBtn.Click += new System.EventHandler(this.profileNewCoorBtn_Click);
            // 
            // profileActionPanel
            // 
            this.profileActionPanel.Controls.Add(this.label3);
            this.profileActionPanel.Controls.Add(this.profileAddCoorBtn);
            this.profileActionPanel.Controls.Add(this.label4);
            this.profileActionPanel.Controls.Add(this.profileUpdateCoorBtn);
            this.profileActionPanel.Controls.Add(this.label5);
            this.profileActionPanel.Controls.Add(this.profilePassTbox);
            this.profileActionPanel.Controls.Add(this.label6);
            this.profileActionPanel.Controls.Add(this.profilePositionTbox);
            this.profileActionPanel.Controls.Add(this.label7);
            this.profileActionPanel.Controls.Add(this.profileEmailTbox);
            this.profileActionPanel.Controls.Add(this.profileNimTBox);
            this.profileActionPanel.Controls.Add(this.profileNameTbox);
            this.profileActionPanel.Location = new System.Drawing.Point(372, 373);
            this.profileActionPanel.Name = "profileActionPanel";
            this.profileActionPanel.Size = new System.Drawing.Size(546, 160);
            this.profileActionPanel.TabIndex = 40;
            this.profileActionPanel.Visible = false;
            this.profileActionPanel.Leave += new System.EventHandler(this.validation);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "NIM";
            // 
            // profileAddCoorBtn
            // 
            this.profileAddCoorBtn.Enabled = false;
            this.profileAddCoorBtn.Location = new System.Drawing.Point(275, 45);
            this.profileAddCoorBtn.Name = "profileAddCoorBtn";
            this.profileAddCoorBtn.Size = new System.Drawing.Size(85, 46);
            this.profileAddCoorBtn.TabIndex = 19;
            this.profileAddCoorBtn.Text = "Add";
            this.profileAddCoorBtn.UseVisualStyleBackColor = true;
            this.profileAddCoorBtn.Click += new System.EventHandler(this.profileAddCoorBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Name";
            // 
            // profileUpdateCoorBtn
            // 
            this.profileUpdateCoorBtn.Location = new System.Drawing.Point(275, 97);
            this.profileUpdateCoorBtn.Name = "profileUpdateCoorBtn";
            this.profileUpdateCoorBtn.Size = new System.Drawing.Size(85, 46);
            this.profileUpdateCoorBtn.TabIndex = 18;
            this.profileUpdateCoorBtn.Text = "Update";
            this.profileUpdateCoorBtn.UseVisualStyleBackColor = true;
            this.profileUpdateCoorBtn.Visible = false;
            this.profileUpdateCoorBtn.Click += new System.EventHandler(this.profileUpdateCoorBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Email";
            // 
            // profilePassTbox
            // 
            this.profilePassTbox.Location = new System.Drawing.Point(77, 123);
            this.profilePassTbox.Name = "profilePassTbox";
            this.profilePassTbox.Size = new System.Drawing.Size(192, 20);
            this.profilePassTbox.TabIndex = 17;
            this.profilePassTbox.TextChanged += new System.EventHandler(this.validation);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Position";
            // 
            // profilePositionTbox
            // 
            this.profilePositionTbox.Location = new System.Drawing.Point(77, 97);
            this.profilePositionTbox.Name = "profilePositionTbox";
            this.profilePositionTbox.Size = new System.Drawing.Size(192, 20);
            this.profilePositionTbox.TabIndex = 16;
            this.profilePositionTbox.TextChanged += new System.EventHandler(this.validation);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Password";
            // 
            // profileEmailTbox
            // 
            this.profileEmailTbox.Location = new System.Drawing.Point(77, 71);
            this.profileEmailTbox.Name = "profileEmailTbox";
            this.profileEmailTbox.Size = new System.Drawing.Size(192, 20);
            this.profileEmailTbox.TabIndex = 15;
            this.profileEmailTbox.TextChanged += new System.EventHandler(this.validation);
            // 
            // profileNimTBox
            // 
            this.profileNimTBox.Location = new System.Drawing.Point(77, 19);
            this.profileNimTBox.Name = "profileNimTBox";
            this.profileNimTBox.Size = new System.Drawing.Size(192, 20);
            this.profileNimTBox.TabIndex = 13;
            this.profileNimTBox.TextChanged += new System.EventHandler(this.validation);
            // 
            // profileNameTbox
            // 
            this.profileNameTbox.Location = new System.Drawing.Point(77, 45);
            this.profileNameTbox.Name = "profileNameTbox";
            this.profileNameTbox.Size = new System.Drawing.Size(192, 20);
            this.profileNameTbox.TabIndex = 14;
            this.profileNameTbox.TextChanged += new System.EventHandler(this.validation);
            // 
            // profileListView
            // 
            this.profileListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.emailHeader,
            this.passHeader,
            this.nameHeader,
            this.positionHeader,
            this.NIMHeader});
            this.profileListView.FullRowSelect = true;
            this.profileListView.GridLines = true;
            this.profileListView.Location = new System.Drawing.Point(372, 48);
            this.profileListView.Name = "profileListView";
            this.profileListView.Size = new System.Drawing.Size(544, 276);
            this.profileListView.TabIndex = 39;
            this.profileListView.UseCompatibleStateImageBehavior = false;
            this.profileListView.View = System.Windows.Forms.View.Details;
            this.profileListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dashboardListViewCLick);
            // 
            // emailHeader
            // 
            this.emailHeader.Text = "Email";
            this.emailHeader.Width = 105;
            // 
            // passHeader
            // 
            this.passHeader.Text = "Password";
            this.passHeader.Width = 111;
            // 
            // nameHeader
            // 
            this.nameHeader.Text = "Name";
            this.nameHeader.Width = 110;
            // 
            // positionHeader
            // 
            this.positionHeader.Text = "Positon";
            this.positionHeader.Width = 109;
            // 
            // NIMHeader
            // 
            this.NIMHeader.Text = "NIM";
            this.NIMHeader.Width = 102;
            // 
            // profileMonthLbl
            // 
            this.profileMonthLbl.AutoSize = true;
            this.profileMonthLbl.Location = new System.Drawing.Point(9, 13);
            this.profileMonthLbl.Name = "profileMonthLbl";
            this.profileMonthLbl.Size = new System.Drawing.Size(46, 13);
            this.profileMonthLbl.TabIndex = 38;
            this.profileMonthLbl.Text = "Month : ";
            // 
            // profileFeeTbox
            // 
            this.profileFeeTbox.Location = new System.Drawing.Point(121, 90);
            this.profileFeeTbox.Name = "profileFeeTbox";
            this.profileFeeTbox.ReadOnly = true;
            this.profileFeeTbox.Size = new System.Drawing.Size(131, 20);
            this.profileFeeTbox.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Membership Fee";
            // 
            // profileInventoryBtn
            // 
            this.profileInventoryBtn.AccessibleDescription = "5";
            this.profileInventoryBtn.Location = new System.Drawing.Point(9, 441);
            this.profileInventoryBtn.Name = "profileInventoryBtn";
            this.profileInventoryBtn.Size = new System.Drawing.Size(109, 23);
            this.profileInventoryBtn.TabIndex = 35;
            this.profileInventoryBtn.Text = "View Inventory";
            this.profileInventoryBtn.UseVisualStyleBackColor = true;
            this.profileInventoryBtn.Click += new System.EventHandler(this.profileChangeTabBtn_Click);
            // 
            // profileViewIncomeButton
            // 
            this.profileViewIncomeButton.AccessibleDescription = "4";
            this.profileViewIncomeButton.Location = new System.Drawing.Point(121, 211);
            this.profileViewIncomeButton.Name = "profileViewIncomeButton";
            this.profileViewIncomeButton.Size = new System.Drawing.Size(131, 23);
            this.profileViewIncomeButton.TabIndex = 34;
            this.profileViewIncomeButton.Text = "View Income";
            this.profileViewIncomeButton.UseVisualStyleBackColor = true;
            this.profileViewIncomeButton.Click += new System.EventHandler(this.profileChangeTabBtn_Click);
            // 
            // profileCashTextBox
            // 
            this.profileCashTextBox.Location = new System.Drawing.Point(121, 48);
            this.profileCashTextBox.Name = "profileCashTextBox";
            this.profileCashTextBox.ReadOnly = true;
            this.profileCashTextBox.Size = new System.Drawing.Size(131, 20);
            this.profileCashTextBox.TabIndex = 33;
            // 
            // profileKasLabel
            // 
            this.profileKasLabel.AutoSize = true;
            this.profileKasLabel.Location = new System.Drawing.Point(6, 51);
            this.profileKasLabel.Name = "profileKasLabel";
            this.profileKasLabel.Size = new System.Drawing.Size(68, 13);
            this.profileKasLabel.TabIndex = 32;
            this.profileKasLabel.Text = "Current Cash";
            // 
            // profileAbsenceBtn
            // 
            this.profileAbsenceBtn.AccessibleDescription = "1";
            this.profileAbsenceBtn.Location = new System.Drawing.Point(9, 385);
            this.profileAbsenceBtn.Name = "profileAbsenceBtn";
            this.profileAbsenceBtn.Size = new System.Drawing.Size(109, 23);
            this.profileAbsenceBtn.TabIndex = 52;
            this.profileAbsenceBtn.Text = "View Absence";
            this.profileAbsenceBtn.UseVisualStyleBackColor = true;
            this.profileAbsenceBtn.Click += new System.EventHandler(this.profileChangeTabBtn_Click);
            // 
            // coorCTMS
            // 
            this.coorCTMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.coorCTMS.Name = "coorCTMS";
            this.coorCTMS.Size = new System.Drawing.Size(153, 70);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // profileDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 546);
            this.Controls.Add(this.profileAbsenceBtn);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.profileExpenseBtn);
            this.Controls.Add(this.profileMemberBtn);
            this.Controls.Add(this.profileExpenseTbox);
            this.Controls.Add(this.profileIncomeTbox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.profileUpdateFeeBtn);
            this.Controls.Add(this.profileChangeFeeBtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.profileNewCoorBtn);
            this.Controls.Add(this.profileActionPanel);
            this.Controls.Add(this.profileListView);
            this.Controls.Add(this.profileMonthLbl);
            this.Controls.Add(this.profileFeeTbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.profileInventoryBtn);
            this.Controls.Add(this.profileViewIncomeButton);
            this.Controls.Add(this.profileCashTextBox);
            this.Controls.Add(this.profileKasLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "profileDashboard";
            this.Text = "profileDashboard";
            this.profileActionPanel.ResumeLayout(false);
            this.profileActionPanel.PerformLayout();
            this.coorCTMS.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button profileExpenseBtn;
        private System.Windows.Forms.Button profileMemberBtn;
        private System.Windows.Forms.TextBox profileExpenseTbox;
        private System.Windows.Forms.TextBox profileIncomeTbox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button profileUpdateFeeBtn;
        private System.Windows.Forms.Button profileChangeFeeBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button profileNewCoorBtn;
        private System.Windows.Forms.Panel profileActionPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button profileAddCoorBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button profileUpdateCoorBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox profilePassTbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox profilePositionTbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox profileEmailTbox;
        private System.Windows.Forms.TextBox profileNimTBox;
        private System.Windows.Forms.TextBox profileNameTbox;
        private System.Windows.Forms.ListView profileListView;
        private System.Windows.Forms.Label profileMonthLbl;
        private System.Windows.Forms.TextBox profileFeeTbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button profileInventoryBtn;
        private System.Windows.Forms.Button profileViewIncomeButton;
        private System.Windows.Forms.TextBox profileCashTextBox;
        private System.Windows.Forms.Label profileKasLabel;
        private System.Windows.Forms.Button profileAbsenceBtn;
        private System.Windows.Forms.ColumnHeader emailHeader;
        private System.Windows.Forms.ColumnHeader passHeader;
        private System.Windows.Forms.ColumnHeader nameHeader;
        private System.Windows.Forms.ColumnHeader positionHeader;
        private System.Windows.Forms.ColumnHeader NIMHeader;
        private System.Windows.Forms.ContextMenuStrip coorCTMS;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}