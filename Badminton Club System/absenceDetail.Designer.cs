namespace Badminton_Club_System
{
    partial class absenceDetail
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
            this.absenceDetailMonth = new System.Windows.Forms.Label();
            this.table = new System.Windows.Forms.ListView();
            this.absenceDetailNimHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.absenceDetailNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.absenceDetailAbsenceBtn = new System.Windows.Forms.Button();
            this.absenceDetailxAbsenceBtn = new System.Windows.Forms.Button();
            this.absenceDetailCB = new System.Windows.Forms.ComboBox();
            this.absenceDetailCMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.absenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.permissionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newMeetinBtn = new System.Windows.Forms.Button();
            this.monthTbox = new System.Windows.Forms.TextBox();
            this.permissionBtn = new System.Windows.Forms.Button();
            this.absenceDetailCMS.SuspendLayout();
            this.SuspendLayout();
            // 
            // absenceDetailMonth
            // 
            this.absenceDetailMonth.AutoSize = true;
            this.absenceDetailMonth.Location = new System.Drawing.Point(12, 20);
            this.absenceDetailMonth.Name = "absenceDetailMonth";
            this.absenceDetailMonth.Size = new System.Drawing.Size(37, 13);
            this.absenceDetailMonth.TabIndex = 0;
            this.absenceDetailMonth.Text = "Month";
            // 
            // table
            // 
            this.table.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.absenceDetailNimHeader,
            this.absenceDetailNameHeader});
            this.table.FullRowSelect = true;
            this.table.GridLines = true;
            this.table.Location = new System.Drawing.Point(13, 55);
            this.table.Name = "table";
            this.table.Size = new System.Drawing.Size(767, 319);
            this.table.TabIndex = 3;
            this.table.UseCompatibleStateImageBehavior = false;
            this.table.View = System.Windows.Forms.View.Details;
            this.table.MouseClick += new System.Windows.Forms.MouseEventHandler(this.absenceDetailListView_MouseClick);
            // 
            // absenceDetailNimHeader
            // 
            this.absenceDetailNimHeader.Text = "NIM";
            this.absenceDetailNimHeader.Width = 112;
            // 
            // absenceDetailNameHeader
            // 
            this.absenceDetailNameHeader.Text = "Name";
            this.absenceDetailNameHeader.Width = 146;
            // 
            // absenceDetailAbsenceBtn
            // 
            this.absenceDetailAbsenceBtn.Location = new System.Drawing.Point(13, 387);
            this.absenceDetailAbsenceBtn.Name = "absenceDetailAbsenceBtn";
            this.absenceDetailAbsenceBtn.Size = new System.Drawing.Size(117, 23);
            this.absenceDetailAbsenceBtn.TabIndex = 4;
            this.absenceDetailAbsenceBtn.Text = "Absence";
            this.absenceDetailAbsenceBtn.UseVisualStyleBackColor = true;
            this.absenceDetailAbsenceBtn.Click += new System.EventHandler(this.absenceDetailAbsenceBtn_Click);
            // 
            // absenceDetailxAbsenceBtn
            // 
            this.absenceDetailxAbsenceBtn.Location = new System.Drawing.Point(259, 387);
            this.absenceDetailxAbsenceBtn.Name = "absenceDetailxAbsenceBtn";
            this.absenceDetailxAbsenceBtn.Size = new System.Drawing.Size(112, 23);
            this.absenceDetailxAbsenceBtn.TabIndex = 5;
            this.absenceDetailxAbsenceBtn.Text = "Revert Absence";
            this.absenceDetailxAbsenceBtn.UseVisualStyleBackColor = true;
            this.absenceDetailxAbsenceBtn.Click += new System.EventHandler(this.absenceDetailxAbsenceBtn_Click);
            // 
            // absenceDetailCB
            // 
            this.absenceDetailCB.FormattingEnabled = true;
            this.absenceDetailCB.Items.AddRange(new object[] {
            "Meeting 1",
            "Meeting 2",
            "Meeting 3",
            "Meeting 4"});
            this.absenceDetailCB.Location = new System.Drawing.Point(377, 387);
            this.absenceDetailCB.Name = "absenceDetailCB";
            this.absenceDetailCB.Size = new System.Drawing.Size(121, 21);
            this.absenceDetailCB.TabIndex = 6;
            // 
            // absenceDetailCMS
            // 
            this.absenceDetailCMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.absenceToolStripMenuItem,
            this.cancleToolStripMenuItem,
            this.permissionToolStripMenuItem});
            this.absenceDetailCMS.Name = "absenceDetailCMS";
            this.absenceDetailCMS.Size = new System.Drawing.Size(153, 92);
            // 
            // absenceToolStripMenuItem
            // 
            this.absenceToolStripMenuItem.Name = "absenceToolStripMenuItem";
            this.absenceToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.absenceToolStripMenuItem.Text = "Absence";
            this.absenceToolStripMenuItem.Click += new System.EventHandler(this.absenceDetailAbsenceBtn_Click);
            // 
            // cancleToolStripMenuItem
            // 
            this.cancleToolStripMenuItem.Name = "cancleToolStripMenuItem";
            this.cancleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cancleToolStripMenuItem.Text = "Revert";
            this.cancleToolStripMenuItem.Click += new System.EventHandler(this.absenceDetailAbsenceBtn_Click);
            // 
            // permissionToolStripMenuItem
            // 
            this.permissionToolStripMenuItem.Name = "permissionToolStripMenuItem";
            this.permissionToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.permissionToolStripMenuItem.Text = "Permission";
            this.permissionToolStripMenuItem.Click += new System.EventHandler(this.permissionBtn_Click);
            // 
            // newMeetinBtn
            // 
            this.newMeetinBtn.Location = new System.Drawing.Point(641, 383);
            this.newMeetinBtn.Name = "newMeetinBtn";
            this.newMeetinBtn.Size = new System.Drawing.Size(139, 30);
            this.newMeetinBtn.TabIndex = 7;
            this.newMeetinBtn.Text = "Add New Meeting";
            this.newMeetinBtn.UseVisualStyleBackColor = true;
            this.newMeetinBtn.Click += new System.EventHandler(this.newMeetinBtn_Click);
            // 
            // monthTbox
            // 
            this.monthTbox.Enabled = false;
            this.monthTbox.Location = new System.Drawing.Point(55, 17);
            this.monthTbox.Name = "monthTbox";
            this.monthTbox.ReadOnly = true;
            this.monthTbox.Size = new System.Drawing.Size(136, 20);
            this.monthTbox.TabIndex = 8;
            // 
            // permissionBtn
            // 
            this.permissionBtn.Location = new System.Drawing.Point(136, 387);
            this.permissionBtn.Name = "permissionBtn";
            this.permissionBtn.Size = new System.Drawing.Size(117, 23);
            this.permissionBtn.TabIndex = 9;
            this.permissionBtn.Text = "Permission";
            this.permissionBtn.UseVisualStyleBackColor = true;
            this.permissionBtn.Click += new System.EventHandler(this.permissionBtn_Click);
            // 
            // absenceDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 422);
            this.Controls.Add(this.permissionBtn);
            this.Controls.Add(this.monthTbox);
            this.Controls.Add(this.newMeetinBtn);
            this.Controls.Add(this.absenceDetailCB);
            this.Controls.Add(this.absenceDetailxAbsenceBtn);
            this.Controls.Add(this.absenceDetailAbsenceBtn);
            this.Controls.Add(this.table);
            this.Controls.Add(this.absenceDetailMonth);
            this.Name = "absenceDetail";
            this.Text = "absenceDetail";
            this.absenceDetailCMS.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label absenceDetailMonth;
        private System.Windows.Forms.ListView table;
        private System.Windows.Forms.ColumnHeader absenceDetailNimHeader;
        private System.Windows.Forms.ColumnHeader absenceDetailNameHeader;
        private System.Windows.Forms.Button absenceDetailAbsenceBtn;
        private System.Windows.Forms.Button absenceDetailxAbsenceBtn;
        private System.Windows.Forms.ComboBox absenceDetailCB;
        private System.Windows.Forms.ContextMenuStrip absenceDetailCMS;
        private System.Windows.Forms.ToolStripMenuItem absenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancleToolStripMenuItem;
        private System.Windows.Forms.Button newMeetinBtn;
        private System.Windows.Forms.TextBox monthTbox;
        private System.Windows.Forms.Button permissionBtn;
        private System.Windows.Forms.ToolStripMenuItem permissionToolStripMenuItem;
    }
}