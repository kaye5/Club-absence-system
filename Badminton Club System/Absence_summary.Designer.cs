namespace Badminton_Club_System
{
    partial class Absence_summary
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
            this.absenceSummaryListView = new System.Windows.Forms.ListView();
            this.absenceSummaryDateHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AbsenceSummaryTotalAbsenceLabel = new System.Windows.Forms.Label();
            this.AbsenceSummaryTotalAbsenceLabelCount = new System.Windows.Forms.Label();
            this.absenceSummaryMonthHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.absenceSummaryCreateTimeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.absenceSummaryParticipantHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.absenceSummaryAbsenceParticipateCountHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.absenceSummaryNParticipateCountHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.absenceSummaryMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.absenceSummaryMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // absenceSummaryListView
            // 
            this.absenceSummaryListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.absenceSummaryCreateTimeHeader,
            this.absenceSummaryMonthHeader,
            this.absenceSummaryDateHeader,
            this.absenceSummaryParticipantHeader,
            this.absenceSummaryAbsenceParticipateCountHeader,
            this.absenceSummaryNParticipateCountHeader});
            this.absenceSummaryListView.Location = new System.Drawing.Point(12, 66);
            this.absenceSummaryListView.Name = "absenceSummaryListView";
            this.absenceSummaryListView.Size = new System.Drawing.Size(684, 297);
            this.absenceSummaryListView.TabIndex = 0;
            this.absenceSummaryListView.UseCompatibleStateImageBehavior = false;
            // 
            // absenceSummaryDateHeader
            // 
            this.absenceSummaryDateHeader.DisplayIndex = 0;
            this.absenceSummaryDateHeader.Text = "Date";
            // 
            // AbsenceSummaryTotalAbsenceLabel
            // 
            this.AbsenceSummaryTotalAbsenceLabel.AutoSize = true;
            this.AbsenceSummaryTotalAbsenceLabel.BackColor = System.Drawing.SystemColors.Control;
            this.AbsenceSummaryTotalAbsenceLabel.Location = new System.Drawing.Point(12, 31);
            this.AbsenceSummaryTotalAbsenceLabel.Name = "AbsenceSummaryTotalAbsenceLabel";
            this.AbsenceSummaryTotalAbsenceLabel.Size = new System.Drawing.Size(85, 13);
            this.AbsenceSummaryTotalAbsenceLabel.TabIndex = 1;
            this.AbsenceSummaryTotalAbsenceLabel.Text = "Total Absence : ";
            // 
            // AbsenceSummaryTotalAbsenceLabelCount
            // 
            this.AbsenceSummaryTotalAbsenceLabelCount.AutoSize = true;
            this.AbsenceSummaryTotalAbsenceLabelCount.Location = new System.Drawing.Point(103, 31);
            this.AbsenceSummaryTotalAbsenceLabelCount.Name = "AbsenceSummaryTotalAbsenceLabelCount";
            this.AbsenceSummaryTotalAbsenceLabelCount.Size = new System.Drawing.Size(13, 13);
            this.AbsenceSummaryTotalAbsenceLabelCount.TabIndex = 2;
            this.AbsenceSummaryTotalAbsenceLabelCount.Text = "0";
            // 
            // absenceSummaryMonthHeader
            // 
            this.absenceSummaryMonthHeader.Text = "Month";
            // 
            // absenceSummaryCreateTimeHeader
            // 
            this.absenceSummaryCreateTimeHeader.DisplayIndex = 2;
            this.absenceSummaryCreateTimeHeader.Text = "Create Time";
            // 
            // absenceSummaryParticipantHeader
            // 
            this.absenceSummaryParticipantHeader.Text = "Participant";
            // 
            // absenceSummaryAbsenceParticipateCountHeader
            // 
            this.absenceSummaryAbsenceParticipateCountHeader.Text = "Come";
            // 
            // absenceSummaryMenuStrip
            // 
            this.absenceSummaryMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.absenceSummaryMenuStrip.Name = "absenceSummaryMenuStrip";
            this.absenceSummaryMenuStrip.Size = new System.Drawing.Size(106, 48);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // Absence_summary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 375);
            this.Controls.Add(this.AbsenceSummaryTotalAbsenceLabelCount);
            this.Controls.Add(this.AbsenceSummaryTotalAbsenceLabel);
            this.Controls.Add(this.absenceSummaryListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Absence_summary";
            this.Text = "Summary";
            this.absenceSummaryMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView absenceSummaryListView;
        private System.Windows.Forms.ColumnHeader absenceSummaryCreateTimeHeader;
        private System.Windows.Forms.ColumnHeader absenceSummaryMonthHeader;
        private System.Windows.Forms.ColumnHeader absenceSummaryDateHeader;
        private System.Windows.Forms.ColumnHeader absenceSummaryParticipantHeader;
        private System.Windows.Forms.ColumnHeader absenceSummaryAbsenceParticipateCountHeader;
        private System.Windows.Forms.ColumnHeader absenceSummaryNParticipateCountHeader;
        private System.Windows.Forms.Label AbsenceSummaryTotalAbsenceLabel;
        private System.Windows.Forms.Label AbsenceSummaryTotalAbsenceLabelCount;
        private System.Windows.Forms.ContextMenuStrip absenceSummaryMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}