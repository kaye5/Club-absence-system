namespace Badminton_Club_System
{
    partial class viewMember
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
            this.memberListView = new System.Windows.Forms.ListView();
            this.memberNimHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.memberNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.memberEmailHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.memberIntakeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.memberClassHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.memberStatusHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.viewMemberHeadPanel = new System.Windows.Forms.Panel();
            this.viewMemberFooterPanel = new System.Windows.Forms.Panel();
            this.changeStatB = new System.Windows.Forms.Button();
            this.changeStatA = new System.Windows.Forms.Button();
            this.viewMemberDeleteBtn = new System.Windows.Forms.Button();
            this.viewMemberContainerPanel = new System.Windows.Forms.Panel();
            this.filterBtn = new System.Windows.Forms.Button();
            this.filterTbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.showBtn = new System.Windows.Forms.Button();
            this.viewMemberHeadPanel.SuspendLayout();
            this.viewMemberFooterPanel.SuspendLayout();
            this.viewMemberContainerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // memberListView
            // 
            this.memberListView.BackColor = System.Drawing.SystemColors.Info;
            this.memberListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.memberNimHeader,
            this.memberNameHeader,
            this.memberEmailHeader,
            this.memberIntakeHeader,
            this.memberClassHeader,
            this.memberStatusHeader});
            this.memberListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memberListView.FullRowSelect = true;
            this.memberListView.GridLines = true;
            this.memberListView.Location = new System.Drawing.Point(5, 5);
            this.memberListView.Name = "memberListView";
            this.memberListView.Size = new System.Drawing.Size(722, 246);
            this.memberListView.TabIndex = 0;
            this.memberListView.UseCompatibleStateImageBehavior = false;
            this.memberListView.View = System.Windows.Forms.View.Details;
            // 
            // memberNimHeader
            // 
            this.memberNimHeader.Text = "NIM";
            this.memberNimHeader.Width = 134;
            // 
            // memberNameHeader
            // 
            this.memberNameHeader.Text = "Name";
            this.memberNameHeader.Width = 129;
            // 
            // memberEmailHeader
            // 
            this.memberEmailHeader.Text = "Email";
            this.memberEmailHeader.Width = 147;
            // 
            // memberIntakeHeader
            // 
            this.memberIntakeHeader.Text = "Intake";
            this.memberIntakeHeader.Width = 66;
            // 
            // memberClassHeader
            // 
            this.memberClassHeader.Text = "Class";
            this.memberClassHeader.Width = 90;
            // 
            // memberStatusHeader
            // 
            this.memberStatusHeader.Text = "Status";
            this.memberStatusHeader.Width = 108;
            // 
            // viewMemberHeadPanel
            // 
            this.viewMemberHeadPanel.Controls.Add(this.showBtn);
            this.viewMemberHeadPanel.Controls.Add(this.label1);
            this.viewMemberHeadPanel.Controls.Add(this.filterTbox);
            this.viewMemberHeadPanel.Controls.Add(this.filterBtn);
            this.viewMemberHeadPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.viewMemberHeadPanel.Location = new System.Drawing.Point(0, 0);
            this.viewMemberHeadPanel.Name = "viewMemberHeadPanel";
            this.viewMemberHeadPanel.Size = new System.Drawing.Size(732, 45);
            this.viewMemberHeadPanel.TabIndex = 2;
            // 
            // viewMemberFooterPanel
            // 
            this.viewMemberFooterPanel.Controls.Add(this.changeStatB);
            this.viewMemberFooterPanel.Controls.Add(this.changeStatA);
            this.viewMemberFooterPanel.Controls.Add(this.viewMemberDeleteBtn);
            this.viewMemberFooterPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.viewMemberFooterPanel.Location = new System.Drawing.Point(0, 301);
            this.viewMemberFooterPanel.Name = "viewMemberFooterPanel";
            this.viewMemberFooterPanel.Size = new System.Drawing.Size(732, 45);
            this.viewMemberFooterPanel.TabIndex = 3;
            // 
            // changeStatB
            // 
            this.changeStatB.Location = new System.Drawing.Point(175, 11);
            this.changeStatB.Name = "changeStatB";
            this.changeStatB.Size = new System.Drawing.Size(75, 23);
            this.changeStatB.TabIndex = 2;
            this.changeStatB.Text = "Non-Active";
            this.changeStatB.UseVisualStyleBackColor = true;
            this.changeStatB.Click += new System.EventHandler(this.changeStatB_Click);
            // 
            // changeStatA
            // 
            this.changeStatA.Location = new System.Drawing.Point(94, 11);
            this.changeStatA.Name = "changeStatA";
            this.changeStatA.Size = new System.Drawing.Size(75, 23);
            this.changeStatA.TabIndex = 1;
            this.changeStatA.Text = "Active User";
            this.changeStatA.UseVisualStyleBackColor = true;
            this.changeStatA.Click += new System.EventHandler(this.changeStatA_Click);
            // 
            // viewMemberDeleteBtn
            // 
            this.viewMemberDeleteBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.viewMemberDeleteBtn.Location = new System.Drawing.Point(13, 11);
            this.viewMemberDeleteBtn.Name = "viewMemberDeleteBtn";
            this.viewMemberDeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.viewMemberDeleteBtn.TabIndex = 0;
            this.viewMemberDeleteBtn.Text = "Delete";
            this.viewMemberDeleteBtn.UseVisualStyleBackColor = false;
            this.viewMemberDeleteBtn.Click += new System.EventHandler(this.viewMemberDeleteBtn_Click);
            // 
            // viewMemberContainerPanel
            // 
            this.viewMemberContainerPanel.Controls.Add(this.memberListView);
            this.viewMemberContainerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewMemberContainerPanel.Location = new System.Drawing.Point(0, 45);
            this.viewMemberContainerPanel.Name = "viewMemberContainerPanel";
            this.viewMemberContainerPanel.Padding = new System.Windows.Forms.Padding(5);
            this.viewMemberContainerPanel.Size = new System.Drawing.Size(732, 256);
            this.viewMemberContainerPanel.TabIndex = 4;
            // 
            // filterBtn
            // 
            this.filterBtn.Location = new System.Drawing.Point(175, 11);
            this.filterBtn.Name = "filterBtn";
            this.filterBtn.Size = new System.Drawing.Size(75, 23);
            this.filterBtn.TabIndex = 0;
            this.filterBtn.Text = "Filter";
            this.filterBtn.UseVisualStyleBackColor = true;
            this.filterBtn.Click += new System.EventHandler(this.filterBtn_Click);
            // 
            // filterTbox
            // 
            this.filterTbox.Location = new System.Drawing.Point(69, 14);
            this.filterTbox.Name = "filterTbox";
            this.filterTbox.Size = new System.Drawing.Size(100, 20);
            this.filterTbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Intake ";
            // 
            // showBtn
            // 
            this.showBtn.Location = new System.Drawing.Point(257, 10);
            this.showBtn.Name = "showBtn";
            this.showBtn.Size = new System.Drawing.Size(75, 23);
            this.showBtn.TabIndex = 3;
            this.showBtn.Text = "Show All";
            this.showBtn.UseVisualStyleBackColor = true;
            this.showBtn.Click += new System.EventHandler(this.showBtn_Click);
            // 
            // viewMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(732, 346);
            this.Controls.Add(this.viewMemberContainerPanel);
            this.Controls.Add(this.viewMemberFooterPanel);
            this.Controls.Add(this.viewMemberHeadPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(647, 310);
            this.Name = "viewMember";
            this.Text = "viewMember";
            this.viewMemberHeadPanel.ResumeLayout(false);
            this.viewMemberHeadPanel.PerformLayout();
            this.viewMemberFooterPanel.ResumeLayout(false);
            this.viewMemberContainerPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView memberListView;
        private System.Windows.Forms.ColumnHeader memberNimHeader;
        private System.Windows.Forms.ColumnHeader memberNameHeader;
        private System.Windows.Forms.ColumnHeader memberIntakeHeader;
        private System.Windows.Forms.ColumnHeader memberClassHeader;
        private System.Windows.Forms.ColumnHeader memberStatusHeader;
        private System.Windows.Forms.Panel viewMemberHeadPanel;
        private System.Windows.Forms.Panel viewMemberFooterPanel;
        private System.Windows.Forms.Button viewMemberDeleteBtn;
        private System.Windows.Forms.Panel viewMemberContainerPanel;
        private System.Windows.Forms.ColumnHeader memberEmailHeader;
        private System.Windows.Forms.Button changeStatB;
        private System.Windows.Forms.Button changeStatA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox filterTbox;
        private System.Windows.Forms.Button filterBtn;
        private System.Windows.Forms.Button showBtn;
    }
}