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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.profileTab = new System.Windows.Forms.TabPage();
            this.absenceTab = new System.Windows.Forms.TabPage();
            this.profileKasLabel = new System.Windows.Forms.Label();
            this.profileKasTextBox = new System.Windows.Forms.TextBox();
            this.homeViewKasButton = new System.Windows.Forms.Button();
            this.homeViewInventoryButton = new System.Windows.Forms.Button();
            this.paymentTab = new System.Windows.Forms.TabPage();
            this.memberTab = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.absenceContentPanel = new System.Windows.Forms.Panel();
            this.AbsenceSummaryButton = new System.Windows.Forms.Button();
            this.AbsenceNewButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.profileTab.SuspendLayout();
            this.absenceTab.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.profileTab);
            this.tabControl1.Controls.Add(this.absenceTab);
            this.tabControl1.Controls.Add(this.paymentTab);
            this.tabControl1.Controls.Add(this.memberTab);
            this.tabControl1.Location = new System.Drawing.Point(-2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(764, 388);
            this.tabControl1.TabIndex = 0;
            // 
            // profileTab
            // 
            this.profileTab.Controls.Add(this.homeViewInventoryButton);
            this.profileTab.Controls.Add(this.homeViewKasButton);
            this.profileTab.Controls.Add(this.profileKasTextBox);
            this.profileTab.Controls.Add(this.profileKasLabel);
            this.profileTab.Location = new System.Drawing.Point(4, 22);
            this.profileTab.Name = "profileTab";
            this.profileTab.Padding = new System.Windows.Forms.Padding(3);
            this.profileTab.Size = new System.Drawing.Size(756, 362);
            this.profileTab.TabIndex = 0;
            this.profileTab.Text = "Profile";
            this.profileTab.UseVisualStyleBackColor = true;
            // 
            // absenceTab
            // 
            this.absenceTab.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.absenceTab.Controls.Add(this.absenceContentPanel);
            this.absenceTab.Controls.Add(this.panel1);
            this.absenceTab.Location = new System.Drawing.Point(4, 22);
            this.absenceTab.Name = "absenceTab";
            this.absenceTab.Padding = new System.Windows.Forms.Padding(3);
            this.absenceTab.Size = new System.Drawing.Size(756, 362);
            this.absenceTab.TabIndex = 1;
            this.absenceTab.Text = "Absence";
            this.absenceTab.UseVisualStyleBackColor = true;
            // 
            // profileKasLabel
            // 
            this.profileKasLabel.AutoSize = true;
            this.profileKasLabel.Location = new System.Drawing.Point(10, 28);
            this.profileKasLabel.Name = "profileKasLabel";
            this.profileKasLabel.Size = new System.Drawing.Size(34, 13);
            this.profileKasLabel.TabIndex = 0;
            this.profileKasLabel.Text = "Kas : ";
            // 
            // profileKasTextBox
            // 
            this.profileKasTextBox.Location = new System.Drawing.Point(59, 28);
            this.profileKasTextBox.Name = "profileKasTextBox";
            this.profileKasTextBox.ReadOnly = true;
            this.profileKasTextBox.Size = new System.Drawing.Size(159, 20);
            this.profileKasTextBox.TabIndex = 1;
            // 
            // homeViewKasButton
            // 
            this.homeViewKasButton.Location = new System.Drawing.Point(143, 69);
            this.homeViewKasButton.Name = "homeViewKasButton";
            this.homeViewKasButton.Size = new System.Drawing.Size(75, 23);
            this.homeViewKasButton.TabIndex = 2;
            this.homeViewKasButton.Text = "View Kas";
            this.homeViewKasButton.UseVisualStyleBackColor = true;
            // 
            // homeViewInventoryButton
            // 
            this.homeViewInventoryButton.Location = new System.Drawing.Point(13, 69);
            this.homeViewInventoryButton.Name = "homeViewInventoryButton";
            this.homeViewInventoryButton.Size = new System.Drawing.Size(124, 23);
            this.homeViewInventoryButton.TabIndex = 3;
            this.homeViewInventoryButton.Text = "View Inventory";
            this.homeViewInventoryButton.UseVisualStyleBackColor = true;
            // 
            // paymentTab
            // 
            this.paymentTab.Location = new System.Drawing.Point(4, 22);
            this.paymentTab.Name = "paymentTab";
            this.paymentTab.Padding = new System.Windows.Forms.Padding(3);
            this.paymentTab.Size = new System.Drawing.Size(756, 362);
            this.paymentTab.TabIndex = 2;
            this.paymentTab.Text = "Payment";
            this.paymentTab.UseVisualStyleBackColor = true;
            // 
            // memberTab
            // 
            this.memberTab.Location = new System.Drawing.Point(4, 22);
            this.memberTab.Name = "memberTab";
            this.memberTab.Padding = new System.Windows.Forms.Padding(3);
            this.memberTab.Size = new System.Drawing.Size(756, 362);
            this.memberTab.TabIndex = 3;
            this.memberTab.Text = "Member";
            this.memberTab.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.AbsenceNewButton);
            this.panel1.Controls.Add(this.AbsenceSummaryButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(135, 356);
            this.panel1.TabIndex = 0;
            // 
            // absenceContentPanel
            // 
            this.absenceContentPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.absenceContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.absenceContentPanel.Location = new System.Drawing.Point(138, 3);
            this.absenceContentPanel.Name = "absenceContentPanel";
            this.absenceContentPanel.Size = new System.Drawing.Size(615, 356);
            this.absenceContentPanel.TabIndex = 1;
            // 
            // AbsenceSummaryButton
            // 
            this.AbsenceSummaryButton.Location = new System.Drawing.Point(7, 20);
            this.AbsenceSummaryButton.Name = "AbsenceSummaryButton";
            this.AbsenceSummaryButton.Size = new System.Drawing.Size(122, 23);
            this.AbsenceSummaryButton.TabIndex = 0;
            this.AbsenceSummaryButton.Text = "Summary";
            this.AbsenceSummaryButton.UseVisualStyleBackColor = true;
            this.AbsenceSummaryButton.Click += new System.EventHandler(this.AbsenceSummaryButton_Click);
            // 
            // AbsenceNewButton
            // 
            this.AbsenceNewButton.Location = new System.Drawing.Point(7, 49);
            this.AbsenceNewButton.Name = "AbsenceNewButton";
            this.AbsenceNewButton.Size = new System.Drawing.Size(122, 23);
            this.AbsenceNewButton.TabIndex = 1;
            this.AbsenceNewButton.Text = "New Absence";
            this.AbsenceNewButton.UseVisualStyleBackColor = true;
            this.AbsenceNewButton.Click += new System.EventHandler(this.AbsenceNewButton_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 388);
            this.Controls.Add(this.tabControl1);
            this.Name = "Home";
            this.Text = "Home";
            this.tabControl1.ResumeLayout(false);
            this.profileTab.ResumeLayout(false);
            this.profileTab.PerformLayout();
            this.absenceTab.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage profileTab;
        private System.Windows.Forms.Label profileKasLabel;
        private System.Windows.Forms.TabPage absenceTab;
        private System.Windows.Forms.TextBox profileKasTextBox;
        private System.Windows.Forms.Button homeViewInventoryButton;
        private System.Windows.Forms.Button homeViewKasButton;
        private System.Windows.Forms.TabPage paymentTab;
        private System.Windows.Forms.TabPage memberTab;
        private System.Windows.Forms.Panel absenceContentPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button AbsenceNewButton;
        private System.Windows.Forms.Button AbsenceSummaryButton;
    }
}