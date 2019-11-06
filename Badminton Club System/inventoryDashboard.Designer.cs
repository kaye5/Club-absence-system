namespace Badminton_Club_System
{
    partial class inventoryDashboard
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.inventoryIDHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.inventoryItemHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.inventoryStockHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.commentHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.inventoryDashboardCMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.invetoryDashboardIDTbox = new System.Windows.Forms.TextBox();
            this.invetoryDashboardNameTbox = new System.Windows.Forms.TextBox();
            this.inventoryDashboardUpdateBtn = new System.Windows.Forms.Button();
            this.inventoryDashboardUpdatePanel = new System.Windows.Forms.Panel();
            this.inventoryDashboardCMS.SuspendLayout();
            this.inventoryDashboardUpdatePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Item : ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(82, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(48, 20);
            this.textBox1.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.inventoryIDHeader,
            this.inventoryItemHeader,
            this.inventoryStockHeader,
            this.commentHeader});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(199, 10);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(589, 287);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // inventoryIDHeader
            // 
            this.inventoryIDHeader.Text = "ID";
            this.inventoryIDHeader.Width = 176;
            // 
            // inventoryItemHeader
            // 
            this.inventoryItemHeader.Text = "Item Name";
            this.inventoryItemHeader.Width = 158;
            // 
            // inventoryStockHeader
            // 
            this.inventoryStockHeader.Text = "Stock";
            this.inventoryStockHeader.Width = 105;
            // 
            // commentHeader
            // 
            this.commentHeader.Text = "Comment";
            this.commentHeader.Width = 130;
            // 
            // inventoryDashboardCMS
            // 
            this.inventoryDashboardCMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.inventoryDashboardCMS.Name = "inventoryDashboardCMS";
            this.inventoryDashboardCMS.Size = new System.Drawing.Size(108, 48);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Item Name";
            // 
            // invetoryDashboardIDTbox
            // 
            this.invetoryDashboardIDTbox.Enabled = false;
            this.invetoryDashboardIDTbox.Location = new System.Drawing.Point(13, 22);
            this.invetoryDashboardIDTbox.Name = "invetoryDashboardIDTbox";
            this.invetoryDashboardIDTbox.Size = new System.Drawing.Size(174, 20);
            this.invetoryDashboardIDTbox.TabIndex = 7;
            // 
            // invetoryDashboardNameTbox
            // 
            this.invetoryDashboardNameTbox.Location = new System.Drawing.Point(13, 61);
            this.invetoryDashboardNameTbox.Name = "invetoryDashboardNameTbox";
            this.invetoryDashboardNameTbox.Size = new System.Drawing.Size(174, 20);
            this.invetoryDashboardNameTbox.TabIndex = 8;
            // 
            // inventoryDashboardUpdateBtn
            // 
            this.inventoryDashboardUpdateBtn.Location = new System.Drawing.Point(10, 97);
            this.inventoryDashboardUpdateBtn.Name = "inventoryDashboardUpdateBtn";
            this.inventoryDashboardUpdateBtn.Size = new System.Drawing.Size(111, 23);
            this.inventoryDashboardUpdateBtn.TabIndex = 10;
            this.inventoryDashboardUpdateBtn.Text = "Update";
            this.inventoryDashboardUpdateBtn.UseVisualStyleBackColor = true;
            this.inventoryDashboardUpdateBtn.Click += new System.EventHandler(this.inventoryDashboardUpdateBtn_Click);
            // 
            // inventoryDashboardUpdatePanel
            // 
            this.inventoryDashboardUpdatePanel.Controls.Add(this.invetoryDashboardIDTbox);
            this.inventoryDashboardUpdatePanel.Controls.Add(this.label2);
            this.inventoryDashboardUpdatePanel.Controls.Add(this.inventoryDashboardUpdateBtn);
            this.inventoryDashboardUpdatePanel.Controls.Add(this.label3);
            this.inventoryDashboardUpdatePanel.Controls.Add(this.invetoryDashboardNameTbox);
            this.inventoryDashboardUpdatePanel.Location = new System.Drawing.Point(2, 66);
            this.inventoryDashboardUpdatePanel.Name = "inventoryDashboardUpdatePanel";
            this.inventoryDashboardUpdatePanel.Size = new System.Drawing.Size(191, 140);
            this.inventoryDashboardUpdatePanel.TabIndex = 11;
            this.inventoryDashboardUpdatePanel.Visible = false;
            // 
            // inventoryDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 546);
            this.Controls.Add(this.inventoryDashboardUpdatePanel);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "inventoryDashboard";
            this.Text = "inventoryDashboard";
            this.inventoryDashboardCMS.ResumeLayout(false);
            this.inventoryDashboardUpdatePanel.ResumeLayout(false);
            this.inventoryDashboardUpdatePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader inventoryItemHeader;
        private System.Windows.Forms.ColumnHeader inventoryStockHeader;
        private System.Windows.Forms.ColumnHeader inventoryIDHeader;
        private System.Windows.Forms.ContextMenuStrip inventoryDashboardCMS;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox invetoryDashboardIDTbox;
        private System.Windows.Forms.TextBox invetoryDashboardNameTbox;
        private System.Windows.Forms.Button inventoryDashboardUpdateBtn;
        private System.Windows.Forms.Panel inventoryDashboardUpdatePanel;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader commentHeader;
    }
}