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
            this.absenceDashboardListView = new System.Windows.Forms.ListView();
            this.absenceMonthHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.absenceMeetingHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.absenceDashboardListView.Location = new System.Drawing.Point(12, 12);
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
            // dashboardListViewCMS
            // 
            this.dashboardListViewCMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.detailsToolStripMenuItem});
            this.dashboardListViewCMS.Name = "dashboardListViewCMS";
            this.dashboardListViewCMS.Size = new System.Drawing.Size(133, 26);
            // 
            // detailsToolStripMenuItem
            // 
            this.detailsToolStripMenuItem.Name = "detailsToolStripMenuItem";
            this.detailsToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.detailsToolStripMenuItem.Text = "View Detail";
            this.detailsToolStripMenuItem.Click += new System.EventHandler(this.detailsToolStripMenuItem_Click);
            // 
            // absenceDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 546);
            this.Controls.Add(this.absenceDashboardListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "absenceDashboard";
            this.Text = "absenceDashboard";
            this.dashboardListViewCMS.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView absenceDashboardListView;
        private System.Windows.Forms.ColumnHeader absenceMonthHeader;
        private System.Windows.Forms.ColumnHeader absenceMeetingHeader;
        private System.Windows.Forms.ContextMenuStrip dashboardListViewCMS;
        private System.Windows.Forms.ToolStripMenuItem detailsToolStripMenuItem;
    }
}