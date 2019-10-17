namespace Badminton_Club_System
{
    partial class absenceDashboard
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Sabu",
            "Samcan"}, -1);
            this.absenceDashboardListView = new System.Windows.Forms.ListView();
            this.absenceMonthHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.absenceMeetingHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.absencelbl1 = new System.Windows.Forms.Label();
            this.absencelblCount = new System.Windows.Forms.Label();
            this.dashboardListViewCMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.detailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashboardListViewCMS.SuspendLayout();
            this.SuspendLayout();
            // 
            // absenceDashboardListView
            // 
            this.absenceDashboardListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.absenceMonthHeader,
            this.absenceMeetingHeader});
            this.absenceDashboardListView.FullRowSelect = true;
            this.absenceDashboardListView.GridLines = true;
            listViewItem1.StateImageIndex = 0;
            this.absenceDashboardListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.absenceDashboardListView.Location = new System.Drawing.Point(12, 62);
            this.absenceDashboardListView.Name = "absenceDashboardListView";
            this.absenceDashboardListView.Size = new System.Drawing.Size(776, 314);
            this.absenceDashboardListView.TabIndex = 0;
            this.absenceDashboardListView.UseCompatibleStateImageBehavior = false;
            this.absenceDashboardListView.View = System.Windows.Forms.View.Details;
            this.absenceDashboardListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dashboardListViewCLick);
            // 
            // absenceMonthHeader
            // 
            this.absenceMonthHeader.Text = "Month";
            this.absenceMonthHeader.Width = 146;
            // 
            // absenceMeetingHeader
            // 
            this.absenceMeetingHeader.Text = "Total Meeting";
            this.absenceMeetingHeader.Width = 165;
            // 
            // absencelbl1
            // 
            this.absencelbl1.AutoSize = true;
            this.absencelbl1.Location = new System.Drawing.Point(12, 26);
            this.absencelbl1.Name = "absencelbl1";
            this.absencelbl1.Size = new System.Drawing.Size(73, 13);
            this.absencelbl1.TabIndex = 1;
            this.absencelbl1.Text = "Total Month : ";
            // 
            // absencelblCount
            // 
            this.absencelblCount.AutoSize = true;
            this.absencelblCount.Location = new System.Drawing.Point(92, 26);
            this.absencelblCount.Name = "absencelblCount";
            this.absencelblCount.Size = new System.Drawing.Size(13, 13);
            this.absencelblCount.TabIndex = 2;
            this.absencelblCount.Text = "0";
            // 
            // dashboardListViewCMS
            // 
            this.dashboardListViewCMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.detailsToolStripMenuItem});
            this.dashboardListViewCMS.Name = "dashboardListViewCMS";
            this.dashboardListViewCMS.Size = new System.Drawing.Size(127, 26);
            // 
            // detailsToolStripMenuItem
            // 
            this.detailsToolStripMenuItem.Name = "detailsToolStripMenuItem";
            this.detailsToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.detailsToolStripMenuItem.Text = "View Detail";
            this.detailsToolStripMenuItem.Click += new System.EventHandler(this.detailsToolStripMenuItem_Click);
            // 
            // absenceDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 546);
            this.Controls.Add(this.absencelblCount);
            this.Controls.Add(this.absencelbl1);
            this.Controls.Add(this.absenceDashboardListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "absenceDashboard";
            this.Text = "absenceDashboard";
            this.dashboardListViewCMS.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView absenceDashboardListView;
        private System.Windows.Forms.Label absencelbl1;
        private System.Windows.Forms.Label absencelblCount;
        private System.Windows.Forms.ColumnHeader absenceMonthHeader;
        private System.Windows.Forms.ColumnHeader absenceMeetingHeader;
        private System.Windows.Forms.ContextMenuStrip dashboardListViewCMS;
        private System.Windows.Forms.ToolStripMenuItem detailsToolStripMenuItem;
    }
}