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
            this.absenceDetailListView = new System.Windows.Forms.ListView();
            this.absenceDetailAbsenceBtn = new System.Windows.Forms.Button();
            this.absenceDetailxAbsenceBtn = new System.Windows.Forms.Button();
            this.absenceDetailNimHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.absenceDetailNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.absenceDetail1Header = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.absenceDetail2Header = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.absenceDetail3Header = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.absenceDetail4Header = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.absenceDetailCB = new System.Windows.Forms.ComboBox();
            this.absenceDetailCMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.absenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            // absenceDetailListView
            // 
            this.absenceDetailListView.CheckBoxes = true;
            this.absenceDetailListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.absenceDetailNimHeader,
            this.absenceDetailNameHeader,
            this.absenceDetail1Header,
            this.absenceDetail2Header,
            this.absenceDetail3Header,
            this.absenceDetail4Header});
            this.absenceDetailListView.FullRowSelect = true;
            this.absenceDetailListView.GridLines = true;
            this.absenceDetailListView.Location = new System.Drawing.Point(13, 55);
            this.absenceDetailListView.Name = "absenceDetailListView";
            this.absenceDetailListView.Size = new System.Drawing.Size(767, 319);
            this.absenceDetailListView.TabIndex = 3;
            this.absenceDetailListView.UseCompatibleStateImageBehavior = false;
            this.absenceDetailListView.View = System.Windows.Forms.View.Details;
            this.absenceDetailListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.absenceDetailListView_MouseClick);
            // 
            // absenceDetailAbsenceBtn
            // 
            this.absenceDetailAbsenceBtn.Location = new System.Drawing.Point(13, 387);
            this.absenceDetailAbsenceBtn.Name = "absenceDetailAbsenceBtn";
            this.absenceDetailAbsenceBtn.Size = new System.Drawing.Size(117, 23);
            this.absenceDetailAbsenceBtn.TabIndex = 4;
            this.absenceDetailAbsenceBtn.Text = "Absence";
            this.absenceDetailAbsenceBtn.UseVisualStyleBackColor = true;
            // 
            // absenceDetailxAbsenceBtn
            // 
            this.absenceDetailxAbsenceBtn.Location = new System.Drawing.Point(136, 387);
            this.absenceDetailxAbsenceBtn.Name = "absenceDetailxAbsenceBtn";
            this.absenceDetailxAbsenceBtn.Size = new System.Drawing.Size(112, 23);
            this.absenceDetailxAbsenceBtn.TabIndex = 5;
            this.absenceDetailxAbsenceBtn.Text = "Cancle Absence";
            this.absenceDetailxAbsenceBtn.UseVisualStyleBackColor = true;
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
            // absenceDetail1Header
            // 
            this.absenceDetail1Header.Text = "Meeting 1";
            this.absenceDetail1Header.Width = 104;
            // 
            // absenceDetail2Header
            // 
            this.absenceDetail2Header.Text = "Meeting 2";
            this.absenceDetail2Header.Width = 104;
            // 
            // absenceDetail3Header
            // 
            this.absenceDetail3Header.Text = "Meeting 3";
            this.absenceDetail3Header.Width = 102;
            // 
            // absenceDetail4Header
            // 
            this.absenceDetail4Header.Text = "Meeting 4";
            this.absenceDetail4Header.Width = 102;
            // 
            // absenceDetailCB
            // 
            this.absenceDetailCB.FormattingEnabled = true;
            this.absenceDetailCB.Items.AddRange(new object[] {
            "Meeting 1",
            "Meeting 2",
            "Meeting 3",
            "Meeting 4"});
            this.absenceDetailCB.Location = new System.Drawing.Point(254, 389);
            this.absenceDetailCB.Name = "absenceDetailCB";
            this.absenceDetailCB.Size = new System.Drawing.Size(121, 21);
            this.absenceDetailCB.TabIndex = 6;
            // 
            // absenceDetailCMS
            // 
            this.absenceDetailCMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.absenceToolStripMenuItem,
            this.cancleToolStripMenuItem});
            this.absenceDetailCMS.Name = "absenceDetailCMS";
            this.absenceDetailCMS.Size = new System.Drawing.Size(116, 48);
            // 
            // absenceToolStripMenuItem
            // 
            this.absenceToolStripMenuItem.Name = "absenceToolStripMenuItem";
            this.absenceToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.absenceToolStripMenuItem.Text = "Absence";
            // 
            // cancleToolStripMenuItem
            // 
            this.cancleToolStripMenuItem.Name = "cancleToolStripMenuItem";
            this.cancleToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.cancleToolStripMenuItem.Text = "Cancle";
            // 
            // absenceDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 422);
            this.Controls.Add(this.absenceDetailCB);
            this.Controls.Add(this.absenceDetailxAbsenceBtn);
            this.Controls.Add(this.absenceDetailAbsenceBtn);
            this.Controls.Add(this.absenceDetailListView);
            this.Controls.Add(this.absenceDetailMonth);
            this.Name = "absenceDetail";
            this.Text = "absenceDetail";
            this.absenceDetailCMS.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label absenceDetailMonth;
        private System.Windows.Forms.ListView absenceDetailListView;
        private System.Windows.Forms.ColumnHeader absenceDetailNimHeader;
        private System.Windows.Forms.ColumnHeader absenceDetailNameHeader;
        private System.Windows.Forms.ColumnHeader absenceDetail1Header;
        private System.Windows.Forms.ColumnHeader absenceDetail2Header;
        private System.Windows.Forms.ColumnHeader absenceDetail3Header;
        private System.Windows.Forms.ColumnHeader absenceDetail4Header;
        private System.Windows.Forms.Button absenceDetailAbsenceBtn;
        private System.Windows.Forms.Button absenceDetailxAbsenceBtn;
        private System.Windows.Forms.ComboBox absenceDetailCB;
        private System.Windows.Forms.ContextMenuStrip absenceDetailCMS;
        private System.Windows.Forms.ToolStripMenuItem absenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancleToolStripMenuItem;
    }
}