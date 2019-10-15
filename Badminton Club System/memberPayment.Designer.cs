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
            this.memberPaymentContainer = new System.Windows.Forms.Panel();
            this.memberPaymentHead = new System.Windows.Forms.Panel();
            this.memberPaymentFooter = new System.Windows.Forms.Panel();
            this.memberIntakeComboBox = new System.Windows.Forms.ComboBox();
            this.paymentChangeBtn = new System.Windows.Forms.Button();
            this.memberPayBtn = new System.Windows.Forms.Button();
            this.paymentCancleBtn = new System.Windows.Forms.Button();
            this.memberPaymentHead.SuspendLayout();
            this.memberPaymentFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // memberPaymentContainer
            // 
            this.memberPaymentContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memberPaymentContainer.Location = new System.Drawing.Point(0, 0);
            this.memberPaymentContainer.Name = "memberPaymentContainer";
            this.memberPaymentContainer.Padding = new System.Windows.Forms.Padding(5);
            this.memberPaymentContainer.Size = new System.Drawing.Size(724, 318);
            this.memberPaymentContainer.TabIndex = 0;
            // 
            // memberPaymentHead
            // 
            this.memberPaymentHead.Controls.Add(this.paymentChangeBtn);
            this.memberPaymentHead.Controls.Add(this.memberIntakeComboBox);
            this.memberPaymentHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.memberPaymentHead.Location = new System.Drawing.Point(0, 0);
            this.memberPaymentHead.Name = "memberPaymentHead";
            this.memberPaymentHead.Size = new System.Drawing.Size(724, 45);
            this.memberPaymentHead.TabIndex = 1;
            // 
            // memberPaymentFooter
            // 
            this.memberPaymentFooter.Controls.Add(this.paymentCancleBtn);
            this.memberPaymentFooter.Controls.Add(this.memberPayBtn);
            this.memberPaymentFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.memberPaymentFooter.Location = new System.Drawing.Point(0, 273);
            this.memberPaymentFooter.Name = "memberPaymentFooter";
            this.memberPaymentFooter.Size = new System.Drawing.Size(724, 45);
            this.memberPaymentFooter.TabIndex = 2;
            // 
            // memberIntakeComboBox
            // 
            this.memberIntakeComboBox.FormattingEnabled = true;
            this.memberIntakeComboBox.Items.AddRange(new object[] {
            "All"});
            this.memberIntakeComboBox.Location = new System.Drawing.Point(12, 8);
            this.memberIntakeComboBox.Name = "memberIntakeComboBox";
            this.memberIntakeComboBox.Size = new System.Drawing.Size(121, 21);
            this.memberIntakeComboBox.TabIndex = 1;
            // 
            // paymentChangeBtn
            // 
            this.paymentChangeBtn.Location = new System.Drawing.Point(139, 6);
            this.paymentChangeBtn.Name = "paymentChangeBtn";
            this.paymentChangeBtn.Size = new System.Drawing.Size(75, 23);
            this.paymentChangeBtn.TabIndex = 2;
            this.paymentChangeBtn.Text = "change";
            this.paymentChangeBtn.UseVisualStyleBackColor = true;
            // 
            // memberPayBtn
            // 
            this.memberPayBtn.Location = new System.Drawing.Point(13, 10);
            this.memberPayBtn.Name = "memberPayBtn";
            this.memberPayBtn.Size = new System.Drawing.Size(75, 23);
            this.memberPayBtn.TabIndex = 0;
            this.memberPayBtn.Text = "Pay";
            this.memberPayBtn.UseVisualStyleBackColor = true;
            // 
            // paymentCancleBtn
            // 
            this.paymentCancleBtn.Location = new System.Drawing.Point(94, 10);
            this.paymentCancleBtn.Name = "paymentCancleBtn";
            this.paymentCancleBtn.Size = new System.Drawing.Size(75, 23);
            this.paymentCancleBtn.TabIndex = 1;
            this.paymentCancleBtn.Text = "Cancle";
            this.paymentCancleBtn.UseVisualStyleBackColor = true;
            // 
            // memberPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 318);
            this.Controls.Add(this.memberPaymentFooter);
            this.Controls.Add(this.memberPaymentHead);
            this.Controls.Add(this.memberPaymentContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "memberPayment";
            this.Text = "memberPayment";
            this.memberPaymentHead.ResumeLayout(false);
            this.memberPaymentFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel memberPaymentContainer;
        private System.Windows.Forms.Panel memberPaymentHead;
        private System.Windows.Forms.Panel memberPaymentFooter;
        private System.Windows.Forms.ComboBox memberIntakeComboBox;
        private System.Windows.Forms.Button paymentChangeBtn;
        private System.Windows.Forms.Button paymentCancleBtn;
        private System.Windows.Forms.Button memberPayBtn;
    }
}