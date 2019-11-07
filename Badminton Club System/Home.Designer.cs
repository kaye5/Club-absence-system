namespace Badminton_Club_System
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.homeTabControl = new System.Windows.Forms.TabControl();
            this.profileTab = new System.Windows.Forms.TabPage();
            this.profileContainerPanel = new System.Windows.Forms.Panel();
            this.absenceTab = new System.Windows.Forms.TabPage();
            this.absenceContainerPanel = new System.Windows.Forms.Panel();
            this.memberTab = new System.Windows.Forms.TabPage();
            this.memberContainerPanel = new System.Windows.Forms.Panel();
            this.memberNavBarPanel = new System.Windows.Forms.Panel();
            this.memberPaymentButton = new System.Windows.Forms.Button();
            this.memberAddButton = new System.Windows.Forms.Button();
            this.memberMemberButton = new System.Windows.Forms.Button();
            this.expenseTab = new System.Windows.Forms.TabPage();
            this.expenseContainerPanel = new System.Windows.Forms.Panel();
            this.expenseNavBarPanel = new System.Windows.Forms.Panel();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.expenseLastMonthButton = new System.Windows.Forms.Button();
            this.expenseThisMonthButton = new System.Windows.Forms.Button();
            this.expenseAddButton = new System.Windows.Forms.Button();
            this.expenseDashboardButton = new System.Windows.Forms.Button();
            this.incomeTab = new System.Windows.Forms.TabPage();
            this.incomeContainerPanel = new System.Windows.Forms.Panel();
            this.incomeNavBarPanel = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.incomeAddBtn = new System.Windows.Forms.Button();
            this.incomeLastMonthBtn = new System.Windows.Forms.Button();
            this.incomeHistoryBtn = new System.Windows.Forms.Button();
            this.incomeDashboardBtn = new System.Windows.Forms.Button();
            this.inventoryTab = new System.Windows.Forms.TabPage();
            this.inventoryContainerPanel = new System.Windows.Forms.Panel();
            this.inventoryNavBarPanel = new System.Windows.Forms.Panel();
            this.inventoryAddButton = new System.Windows.Forms.Button();
            this.inventoryNewItemButton = new System.Windows.Forms.Button();
            this.inventoryHistoryButton = new System.Windows.Forms.Button();
            this.inventoryDashboardButton = new System.Windows.Forms.Button();
            this.profileListViewCMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeTabControl.SuspendLayout();
            this.profileTab.SuspendLayout();
            this.absenceTab.SuspendLayout();
            this.memberTab.SuspendLayout();
            this.memberNavBarPanel.SuspendLayout();
            this.expenseTab.SuspendLayout();
            this.expenseNavBarPanel.SuspendLayout();
            this.incomeTab.SuspendLayout();
            this.incomeNavBarPanel.SuspendLayout();
            this.inventoryTab.SuspendLayout();
            this.inventoryNavBarPanel.SuspendLayout();
            this.profileListViewCMS.SuspendLayout();
            this.SuspendLayout();
            // 
            // homeTabControl
            // 
            this.homeTabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.homeTabControl.Controls.Add(this.profileTab);
            this.homeTabControl.Controls.Add(this.absenceTab);
            this.homeTabControl.Controls.Add(this.memberTab);
            this.homeTabControl.Controls.Add(this.expenseTab);
            this.homeTabControl.Controls.Add(this.incomeTab);
            this.homeTabControl.Controls.Add(this.inventoryTab);
            this.homeTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homeTabControl.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeTabControl.HotTrack = true;
            this.homeTabControl.ItemSize = new System.Drawing.Size(50, 21);
            this.homeTabControl.Location = new System.Drawing.Point(0, 0);
            this.homeTabControl.Margin = new System.Windows.Forms.Padding(0);
            this.homeTabControl.Name = "homeTabControl";
            this.homeTabControl.SelectedIndex = 0;
            this.homeTabControl.Size = new System.Drawing.Size(934, 581);
            this.homeTabControl.TabIndex = 0;
            this.homeTabControl.TabIndexChanged += new System.EventHandler(this.homeTabControl_TabIndexChanged);
            this.homeTabControl.Click += new System.EventHandler(this.homeTabControl_TabIndexChanged);
            // 
            // profileTab
            // 
            this.profileTab.Controls.Add(this.profileContainerPanel);
            this.profileTab.Location = new System.Drawing.Point(4, 25);
            this.profileTab.Name = "profileTab";
            this.profileTab.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.profileTab.Size = new System.Drawing.Size(926, 552);
            this.profileTab.TabIndex = 0;
            this.profileTab.Text = "Profile";
            this.profileTab.UseVisualStyleBackColor = true;
            // 
            // profileContainerPanel
            // 
            this.profileContainerPanel.BackColor = System.Drawing.Color.White;
            this.profileContainerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profileContainerPanel.Location = new System.Drawing.Point(3, 3);
            this.profileContainerPanel.Name = "profileContainerPanel";
            this.profileContainerPanel.Size = new System.Drawing.Size(920, 546);
            this.profileContainerPanel.TabIndex = 0;
            // 
            // absenceTab
            // 
            this.absenceTab.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.absenceTab.Controls.Add(this.absenceContainerPanel);
            this.absenceTab.Location = new System.Drawing.Point(4, 25);
            this.absenceTab.Name = "absenceTab";
            this.absenceTab.Size = new System.Drawing.Size(946, 510);
            this.absenceTab.TabIndex = 1;
            this.absenceTab.Text = "Absence";
            this.absenceTab.UseVisualStyleBackColor = true;
            // 
            // absenceContainerPanel
            // 
            this.absenceContainerPanel.BackColor = System.Drawing.Color.White;
            this.absenceContainerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.absenceContainerPanel.Location = new System.Drawing.Point(0, 0);
            this.absenceContainerPanel.Name = "absenceContainerPanel";
            this.absenceContainerPanel.Size = new System.Drawing.Size(946, 510);
            this.absenceContainerPanel.TabIndex = 2;
            // 
            // memberTab
            // 
            this.memberTab.Controls.Add(this.memberContainerPanel);
            this.memberTab.Controls.Add(this.memberNavBarPanel);
            this.memberTab.Location = new System.Drawing.Point(4, 25);
            this.memberTab.Name = "memberTab";
            this.memberTab.Size = new System.Drawing.Size(946, 510);
            this.memberTab.TabIndex = 3;
            this.memberTab.Text = "Member";
            this.memberTab.UseVisualStyleBackColor = true;
            // 
            // memberContainerPanel
            // 
            this.memberContainerPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.memberContainerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memberContainerPanel.Location = new System.Drawing.Point(127, 0);
            this.memberContainerPanel.Name = "memberContainerPanel";
            this.memberContainerPanel.Size = new System.Drawing.Size(819, 510);
            this.memberContainerPanel.TabIndex = 2;
            // 
            // memberNavBarPanel
            // 
            this.memberNavBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.memberNavBarPanel.Controls.Add(this.memberPaymentButton);
            this.memberNavBarPanel.Controls.Add(this.memberAddButton);
            this.memberNavBarPanel.Controls.Add(this.memberMemberButton);
            this.memberNavBarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.memberNavBarPanel.Location = new System.Drawing.Point(0, 0);
            this.memberNavBarPanel.Name = "memberNavBarPanel";
            this.memberNavBarPanel.Size = new System.Drawing.Size(127, 510);
            this.memberNavBarPanel.TabIndex = 1;
            // 
            // memberPaymentButton
            // 
            this.memberPaymentButton.Location = new System.Drawing.Point(8, 32);
            this.memberPaymentButton.Name = "memberPaymentButton";
            this.memberPaymentButton.Size = new System.Drawing.Size(113, 23);
            this.memberPaymentButton.TabIndex = 3;
            this.memberPaymentButton.Text = "Payment";
            this.memberPaymentButton.UseVisualStyleBackColor = true;
            this.memberPaymentButton.Click += new System.EventHandler(this.containerPaymentButton_Click);
            // 
            // memberAddButton
            // 
            this.memberAddButton.Location = new System.Drawing.Point(8, 505);
            this.memberAddButton.Name = "memberAddButton";
            this.memberAddButton.Size = new System.Drawing.Size(113, 23);
            this.memberAddButton.TabIndex = 2;
            this.memberAddButton.Text = "Add Member";
            this.memberAddButton.UseVisualStyleBackColor = true;
            this.memberAddButton.Click += new System.EventHandler(this.memberAddButton_Click);
            // 
            // memberMemberButton
            // 
            this.memberMemberButton.Location = new System.Drawing.Point(8, 3);
            this.memberMemberButton.Name = "memberMemberButton";
            this.memberMemberButton.Size = new System.Drawing.Size(113, 23);
            this.memberMemberButton.TabIndex = 1;
            this.memberMemberButton.Text = "Member";
            this.memberMemberButton.UseVisualStyleBackColor = true;
            this.memberMemberButton.Click += new System.EventHandler(this.containerMemberButton_Click);
            // 
            // expenseTab
            // 
            this.expenseTab.Controls.Add(this.expenseContainerPanel);
            this.expenseTab.Controls.Add(this.expenseNavBarPanel);
            this.expenseTab.Location = new System.Drawing.Point(4, 25);
            this.expenseTab.Name = "expenseTab";
            this.expenseTab.Size = new System.Drawing.Size(946, 510);
            this.expenseTab.TabIndex = 2;
            this.expenseTab.Text = "Expense";
            this.expenseTab.UseVisualStyleBackColor = true;
            // 
            // expenseContainerPanel
            // 
            this.expenseContainerPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.expenseContainerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.expenseContainerPanel.Location = new System.Drawing.Point(127, 0);
            this.expenseContainerPanel.Name = "expenseContainerPanel";
            this.expenseContainerPanel.Size = new System.Drawing.Size(819, 510);
            this.expenseContainerPanel.TabIndex = 1;
            // 
            // expenseNavBarPanel
            // 
            this.expenseNavBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.expenseNavBarPanel.Controls.Add(this.dateTimePicker2);
            this.expenseNavBarPanel.Controls.Add(this.expenseLastMonthButton);
            this.expenseNavBarPanel.Controls.Add(this.expenseThisMonthButton);
            this.expenseNavBarPanel.Controls.Add(this.expenseAddButton);
            this.expenseNavBarPanel.Controls.Add(this.expenseDashboardButton);
            this.expenseNavBarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.expenseNavBarPanel.Location = new System.Drawing.Point(0, 0);
            this.expenseNavBarPanel.Name = "expenseNavBarPanel";
            this.expenseNavBarPanel.Size = new System.Drawing.Size(127, 510);
            this.expenseNavBarPanel.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "MMMM yyyy";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(9, 91);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowUpDown = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(112, 22);
            this.dateTimePicker2.TabIndex = 5;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // expenseLastMonthButton
            // 
            this.expenseLastMonthButton.Location = new System.Drawing.Point(8, 61);
            this.expenseLastMonthButton.Name = "expenseLastMonthButton";
            this.expenseLastMonthButton.Size = new System.Drawing.Size(113, 23);
            this.expenseLastMonthButton.TabIndex = 4;
            this.expenseLastMonthButton.Text = "Last Month History";
            this.expenseLastMonthButton.UseVisualStyleBackColor = true;
            this.expenseLastMonthButton.Click += new System.EventHandler(this.expenseLastMonthButton_Click);
            // 
            // expenseThisMonthButton
            // 
            this.expenseThisMonthButton.Location = new System.Drawing.Point(8, 32);
            this.expenseThisMonthButton.Name = "expenseThisMonthButton";
            this.expenseThisMonthButton.Size = new System.Drawing.Size(113, 23);
            this.expenseThisMonthButton.TabIndex = 3;
            this.expenseThisMonthButton.Text = "This Month History";
            this.expenseThisMonthButton.UseVisualStyleBackColor = true;
            this.expenseThisMonthButton.Click += new System.EventHandler(this.expenseThisMonthButton_Click);
            // 
            // expenseAddButton
            // 
            this.expenseAddButton.Location = new System.Drawing.Point(8, 505);
            this.expenseAddButton.Name = "expenseAddButton";
            this.expenseAddButton.Size = new System.Drawing.Size(113, 23);
            this.expenseAddButton.TabIndex = 2;
            this.expenseAddButton.Text = "New Expense";
            this.expenseAddButton.UseVisualStyleBackColor = true;
            this.expenseAddButton.Click += new System.EventHandler(this.ExpenseAddButton_Click);
            // 
            // expenseDashboardButton
            // 
            this.expenseDashboardButton.Location = new System.Drawing.Point(8, 3);
            this.expenseDashboardButton.Name = "expenseDashboardButton";
            this.expenseDashboardButton.Size = new System.Drawing.Size(113, 23);
            this.expenseDashboardButton.TabIndex = 0;
            this.expenseDashboardButton.Text = " Dashboard";
            this.expenseDashboardButton.UseVisualStyleBackColor = true;
            this.expenseDashboardButton.Click += new System.EventHandler(this.ExpenseDashboardButton_Click);
            // 
            // incomeTab
            // 
            this.incomeTab.Controls.Add(this.incomeContainerPanel);
            this.incomeTab.Controls.Add(this.incomeNavBarPanel);
            this.incomeTab.Location = new System.Drawing.Point(4, 25);
            this.incomeTab.Name = "incomeTab";
            this.incomeTab.Size = new System.Drawing.Size(946, 510);
            this.incomeTab.TabIndex = 4;
            this.incomeTab.Text = "Income";
            this.incomeTab.UseVisualStyleBackColor = true;
            // 
            // incomeContainerPanel
            // 
            this.incomeContainerPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.incomeContainerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.incomeContainerPanel.Location = new System.Drawing.Point(127, 0);
            this.incomeContainerPanel.Name = "incomeContainerPanel";
            this.incomeContainerPanel.Size = new System.Drawing.Size(819, 510);
            this.incomeContainerPanel.TabIndex = 2;
            // 
            // incomeNavBarPanel
            // 
            this.incomeNavBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.incomeNavBarPanel.Controls.Add(this.dateTimePicker1);
            this.incomeNavBarPanel.Controls.Add(this.incomeAddBtn);
            this.incomeNavBarPanel.Controls.Add(this.incomeLastMonthBtn);
            this.incomeNavBarPanel.Controls.Add(this.incomeHistoryBtn);
            this.incomeNavBarPanel.Controls.Add(this.incomeDashboardBtn);
            this.incomeNavBarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.incomeNavBarPanel.Location = new System.Drawing.Point(0, 0);
            this.incomeNavBarPanel.Name = "incomeNavBarPanel";
            this.incomeNavBarPanel.Size = new System.Drawing.Size(127, 510);
            this.incomeNavBarPanel.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MMMM yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(9, 91);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(112, 22);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // incomeAddBtn
            // 
            this.incomeAddBtn.Location = new System.Drawing.Point(8, 505);
            this.incomeAddBtn.Name = "incomeAddBtn";
            this.incomeAddBtn.Size = new System.Drawing.Size(113, 23);
            this.incomeAddBtn.TabIndex = 6;
            this.incomeAddBtn.Text = "New Income";
            this.incomeAddBtn.UseVisualStyleBackColor = true;
            this.incomeAddBtn.Click += new System.EventHandler(this.IncomeAddBtn_Click);
            // 
            // incomeLastMonthBtn
            // 
            this.incomeLastMonthBtn.Location = new System.Drawing.Point(8, 61);
            this.incomeLastMonthBtn.Name = "incomeLastMonthBtn";
            this.incomeLastMonthBtn.Size = new System.Drawing.Size(113, 23);
            this.incomeLastMonthBtn.TabIndex = 4;
            this.incomeLastMonthBtn.Text = "Last Month History";
            this.incomeLastMonthBtn.UseVisualStyleBackColor = true;
            this.incomeLastMonthBtn.Click += new System.EventHandler(this.incomeLastMonthBtn_Click);
            // 
            // incomeHistoryBtn
            // 
            this.incomeHistoryBtn.Location = new System.Drawing.Point(8, 32);
            this.incomeHistoryBtn.Name = "incomeHistoryBtn";
            this.incomeHistoryBtn.Size = new System.Drawing.Size(113, 23);
            this.incomeHistoryBtn.TabIndex = 1;
            this.incomeHistoryBtn.Text = "This Month History";
            this.incomeHistoryBtn.UseVisualStyleBackColor = true;
            this.incomeHistoryBtn.Click += new System.EventHandler(this.IncomeHistoryBtn_Click);
            // 
            // incomeDashboardBtn
            // 
            this.incomeDashboardBtn.Location = new System.Drawing.Point(8, 3);
            this.incomeDashboardBtn.Name = "incomeDashboardBtn";
            this.incomeDashboardBtn.Size = new System.Drawing.Size(113, 23);
            this.incomeDashboardBtn.TabIndex = 0;
            this.incomeDashboardBtn.Text = " Dashboard";
            this.incomeDashboardBtn.UseVisualStyleBackColor = true;
            this.incomeDashboardBtn.Click += new System.EventHandler(this.IncomeDashboardButton_Click);
            // 
            // inventoryTab
            // 
            this.inventoryTab.Controls.Add(this.inventoryContainerPanel);
            this.inventoryTab.Controls.Add(this.inventoryNavBarPanel);
            this.inventoryTab.Location = new System.Drawing.Point(4, 25);
            this.inventoryTab.Name = "inventoryTab";
            this.inventoryTab.Size = new System.Drawing.Size(946, 510);
            this.inventoryTab.TabIndex = 5;
            this.inventoryTab.Text = "Inventory";
            this.inventoryTab.UseVisualStyleBackColor = true;
            // 
            // inventoryContainerPanel
            // 
            this.inventoryContainerPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.inventoryContainerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inventoryContainerPanel.Location = new System.Drawing.Point(127, 0);
            this.inventoryContainerPanel.Name = "inventoryContainerPanel";
            this.inventoryContainerPanel.Size = new System.Drawing.Size(819, 510);
            this.inventoryContainerPanel.TabIndex = 2;
            // 
            // inventoryNavBarPanel
            // 
            this.inventoryNavBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.inventoryNavBarPanel.Controls.Add(this.inventoryAddButton);
            this.inventoryNavBarPanel.Controls.Add(this.inventoryNewItemButton);
            this.inventoryNavBarPanel.Controls.Add(this.inventoryHistoryButton);
            this.inventoryNavBarPanel.Controls.Add(this.inventoryDashboardButton);
            this.inventoryNavBarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.inventoryNavBarPanel.Location = new System.Drawing.Point(0, 0);
            this.inventoryNavBarPanel.Name = "inventoryNavBarPanel";
            this.inventoryNavBarPanel.Size = new System.Drawing.Size(127, 510);
            this.inventoryNavBarPanel.TabIndex = 1;
            // 
            // inventoryAddButton
            // 
            this.inventoryAddButton.Location = new System.Drawing.Point(8, 505);
            this.inventoryAddButton.Name = "inventoryAddButton";
            this.inventoryAddButton.Size = new System.Drawing.Size(113, 23);
            this.inventoryAddButton.TabIndex = 3;
            this.inventoryAddButton.Text = "Action";
            this.inventoryAddButton.UseVisualStyleBackColor = true;
            this.inventoryAddButton.Click += new System.EventHandler(this.inventoryAddButton_Click);
            // 
            // inventoryNewItemButton
            // 
            this.inventoryNewItemButton.Location = new System.Drawing.Point(8, 476);
            this.inventoryNewItemButton.Name = "inventoryNewItemButton";
            this.inventoryNewItemButton.Size = new System.Drawing.Size(113, 23);
            this.inventoryNewItemButton.TabIndex = 2;
            this.inventoryNewItemButton.Text = "New Item";
            this.inventoryNewItemButton.UseVisualStyleBackColor = true;
            this.inventoryNewItemButton.Click += new System.EventHandler(this.inventoryNewItemButton_Click);
            // 
            // inventoryHistoryButton
            // 
            this.inventoryHistoryButton.Location = new System.Drawing.Point(8, 32);
            this.inventoryHistoryButton.Name = "inventoryHistoryButton";
            this.inventoryHistoryButton.Size = new System.Drawing.Size(113, 23);
            this.inventoryHistoryButton.TabIndex = 1;
            this.inventoryHistoryButton.Text = "History";
            this.inventoryHistoryButton.UseVisualStyleBackColor = true;
            this.inventoryHistoryButton.Click += new System.EventHandler(this.inventoryHistoryButton_Click);
            // 
            // inventoryDashboardButton
            // 
            this.inventoryDashboardButton.Location = new System.Drawing.Point(8, 3);
            this.inventoryDashboardButton.Name = "inventoryDashboardButton";
            this.inventoryDashboardButton.Size = new System.Drawing.Size(113, 23);
            this.inventoryDashboardButton.TabIndex = 0;
            this.inventoryDashboardButton.Text = " Dashboard";
            this.inventoryDashboardButton.UseVisualStyleBackColor = true;
            this.inventoryDashboardButton.Click += new System.EventHandler(this.inventoryDashboardButton_Click);
            // 
            // profileListViewCMS
            // 
            this.profileListViewCMS.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.profileListViewCMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.addToolStripMenuItem});
            this.profileListViewCMS.Name = "profileListViewCMS";
            this.profileListViewCMS.Size = new System.Drawing.Size(108, 70);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(934, 581);
            this.Controls.Add(this.homeTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(950, 620);
            this.MinimumSize = new System.Drawing.Size(847, 523);
            this.Name = "Home";
            this.Text = "Badminton Club";
            this.homeTabControl.ResumeLayout(false);
            this.profileTab.ResumeLayout(false);
            this.absenceTab.ResumeLayout(false);
            this.memberTab.ResumeLayout(false);
            this.memberNavBarPanel.ResumeLayout(false);
            this.expenseTab.ResumeLayout(false);
            this.expenseNavBarPanel.ResumeLayout(false);
            this.incomeTab.ResumeLayout(false);
            this.incomeNavBarPanel.ResumeLayout(false);
            this.inventoryTab.ResumeLayout(false);
            this.inventoryNavBarPanel.ResumeLayout(false);
            this.profileListViewCMS.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl homeTabControl;
        private System.Windows.Forms.TabPage profileTab;
        private System.Windows.Forms.TabPage absenceTab;
        private System.Windows.Forms.TabPage expenseTab;
        private System.Windows.Forms.TabPage memberTab;
        private System.Windows.Forms.Panel expenseContainerPanel;
        private System.Windows.Forms.Panel expenseNavBarPanel;
        private System.Windows.Forms.Button expenseLastMonthButton;
        private System.Windows.Forms.Button expenseThisMonthButton;
        private System.Windows.Forms.Button expenseAddButton;
        private System.Windows.Forms.Button expenseDashboardButton;
        private System.Windows.Forms.Panel absenceContainerPanel;
        private System.Windows.Forms.Panel memberContainerPanel;
        private System.Windows.Forms.Panel memberNavBarPanel;
        private System.Windows.Forms.Button memberAddButton;
        private System.Windows.Forms.Button memberMemberButton;
        private System.Windows.Forms.Button memberPaymentButton;
        private System.Windows.Forms.TabPage incomeTab;
        private System.Windows.Forms.Panel incomeContainerPanel;
        private System.Windows.Forms.Panel incomeNavBarPanel;
        private System.Windows.Forms.Button incomeLastMonthBtn;
        private System.Windows.Forms.Button incomeHistoryBtn;
        private System.Windows.Forms.Button incomeDashboardBtn;
        private System.Windows.Forms.TabPage inventoryTab;
        private System.Windows.Forms.Panel inventoryContainerPanel;
        private System.Windows.Forms.Panel inventoryNavBarPanel;
        private System.Windows.Forms.Button inventoryAddButton;
        private System.Windows.Forms.Button inventoryNewItemButton;
        private System.Windows.Forms.Button inventoryHistoryButton;
        private System.Windows.Forms.Button inventoryDashboardButton;
        private System.Windows.Forms.Button incomeAddBtn;
        private System.Windows.Forms.ContextMenuStrip profileListViewCMS;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.Panel profileContainerPanel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}