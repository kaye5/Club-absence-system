namespace Badminton_Club_System
{
    partial class inventoryHistory
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
            this.label1 = new System.Windows.Forms.Label();
            this.inventoryHistoryTotTrasnTbox = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.idHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.inventoryHistoryDateHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.inventoryHistoryItemHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.qtyHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.inventoryHistoryActionHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.inventoryHistoryCommentHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Transaction";
            // 
            // inventoryHistoryTotTrasnTbox
            // 
            this.inventoryHistoryTotTrasnTbox.Enabled = false;
            this.inventoryHistoryTotTrasnTbox.Location = new System.Drawing.Point(110, 13);
            this.inventoryHistoryTotTrasnTbox.Name = "inventoryHistoryTotTrasnTbox";
            this.inventoryHistoryTotTrasnTbox.ReadOnly = true;
            this.inventoryHistoryTotTrasnTbox.Size = new System.Drawing.Size(45, 20);
            this.inventoryHistoryTotTrasnTbox.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idHeader,
            this.inventoryHistoryDateHeader,
            this.inventoryHistoryItemHeader,
            this.qtyHeader,
            this.inventoryHistoryActionHeader,
            this.inventoryHistoryCommentHeader});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(13, 45);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(767, 365);
            this.listView1.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // idHeader
            // 
            this.idHeader.Text = "ID";
            this.idHeader.Width = 172;
            // 
            // inventoryHistoryDateHeader
            // 
            this.inventoryHistoryDateHeader.Text = "Date";
            this.inventoryHistoryDateHeader.Width = 156;
            // 
            // inventoryHistoryItemHeader
            // 
            this.inventoryHistoryItemHeader.Text = "Item Name";
            this.inventoryHistoryItemHeader.Width = 141;
            // 
            // qtyHeader
            // 
            this.qtyHeader.Text = "Qty";
            this.qtyHeader.Width = 59;
            // 
            // inventoryHistoryActionHeader
            // 
            this.inventoryHistoryActionHeader.Text = "Action";
            this.inventoryHistoryActionHeader.Width = 103;
            // 
            // inventoryHistoryCommentHeader
            // 
            this.inventoryHistoryCommentHeader.Text = "Comment";
            this.inventoryHistoryCommentHeader.Width = 176;
            // 
            // inventoryHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(792, 422);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.inventoryHistoryTotTrasnTbox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "inventoryHistory";
            this.Text = "inventoryHistory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inventoryHistoryTotTrasnTbox;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader inventoryHistoryDateHeader;
        private System.Windows.Forms.ColumnHeader inventoryHistoryItemHeader;
        private System.Windows.Forms.ColumnHeader inventoryHistoryActionHeader;
        private System.Windows.Forms.ColumnHeader inventoryHistoryCommentHeader;
        private System.Windows.Forms.ColumnHeader qtyHeader;
        private System.Windows.Forms.ColumnHeader idHeader;
    }
}