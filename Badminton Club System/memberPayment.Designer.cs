namespace Badminton_Club_System
{
    partial class memberPayment
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
            this.memberPaymentHead = new System.Windows.Forms.Panel();
            this.memberPaymentFooter = new System.Windows.Forms.Panel();
            this.paymentCancleBtn = new System.Windows.Forms.Button();
            this.memberPayBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.paymentNimHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.paymentNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.paymentStatusHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.memberPaymentFooter.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // memberPaymentHead
            // 
            this.memberPaymentHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.memberPaymentHead.Location = new System.Drawing.Point(0, 0);
            this.memberPaymentHead.Name = "memberPaymentHead";
            this.memberPaymentHead.Size = new System.Drawing.Size(900, 49);
            this.memberPaymentHead.TabIndex = 1;
            // 
            // memberPaymentFooter
            // 
            this.memberPaymentFooter.Controls.Add(this.paymentCancleBtn);
            this.memberPaymentFooter.Controls.Add(this.memberPayBtn);
            this.memberPaymentFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.memberPaymentFooter.Location = new System.Drawing.Point(0, 446);
            this.memberPaymentFooter.Name = "memberPaymentFooter";
            this.memberPaymentFooter.Size = new System.Drawing.Size(900, 54);
            this.memberPaymentFooter.TabIndex = 2;
            // 
            // paymentCancleBtn
            // 
            this.paymentCancleBtn.Location = new System.Drawing.Point(94, 10);
            this.paymentCancleBtn.Name = "paymentCancleBtn";
            this.paymentCancleBtn.Size = new System.Drawing.Size(75, 23);
            this.paymentCancleBtn.TabIndex = 1;
            this.paymentCancleBtn.Text = "Cancle";
            this.paymentCancleBtn.UseVisualStyleBackColor = true;
            this.paymentCancleBtn.Click += new System.EventHandler(this.paymentCancleBtn_Click);
            // 
            // memberPayBtn
            // 
            this.memberPayBtn.Location = new System.Drawing.Point(13, 10);
            this.memberPayBtn.Name = "memberPayBtn";
            this.memberPayBtn.Size = new System.Drawing.Size(75, 23);
            this.memberPayBtn.TabIndex = 0;
            this.memberPayBtn.Text = "Pay";
            this.memberPayBtn.UseVisualStyleBackColor = true;
            this.memberPayBtn.Click += new System.EventHandler(this.memberPayBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 49);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(900, 397);
            this.panel1.TabIndex = 3;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.paymentNimHeader,
            this.paymentNameHeader,
            this.paymentStatusHeader});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(5, 5);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(890, 387);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // paymentNimHeader
            // 
            this.paymentNimHeader.Text = "NIM";
            this.paymentNimHeader.Width = 152;
            // 
            // paymentNameHeader
            // 
            this.paymentNameHeader.Text = "Name";
            this.paymentNameHeader.Width = 121;
            // 
            // paymentStatusHeader
            // 
            this.paymentStatusHeader.Text = "Status";
            this.paymentStatusHeader.Width = 181;
            // 
            // memberPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.memberPaymentFooter);
            this.Controls.Add(this.memberPaymentHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "memberPayment";
            this.Text = "memberPayment";
            this.memberPaymentFooter.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel memberPaymentHead;
        private System.Windows.Forms.Panel memberPaymentFooter;
        private System.Windows.Forms.Button paymentCancleBtn;
        private System.Windows.Forms.Button memberPayBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader paymentNimHeader;
        private System.Windows.Forms.ColumnHeader paymentNameHeader;
        private System.Windows.Forms.ColumnHeader paymentStatusHeader;
    }
}