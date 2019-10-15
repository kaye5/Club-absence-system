namespace Badminton_Club_System
{
    partial class addMember
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
            this.memberAddUserBtn = new System.Windows.Forms.Button();
            this.memberPaymentContainer = new System.Windows.Forms.Panel();
            this.memberNimlbl = new System.Windows.Forms.Label();
            this.memberNamelbl = new System.Windows.Forms.Label();
            this.memberClasslbl = new System.Windows.Forms.Label();
            this.memberEmaillbl = new System.Windows.Forms.Label();
            this.memberNimIn = new System.Windows.Forms.TextBox();
            this.memberNameIn = new System.Windows.Forms.TextBox();
            this.memberClassNameIn = new System.Windows.Forms.TextBox();
            this.memberEmailIn = new System.Windows.Forms.TextBox();
            this.memberPaymentFooter.SuspendLayout();
            this.memberPaymentContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // memberPaymentHead
            // 
            this.memberPaymentHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.memberPaymentHead.Location = new System.Drawing.Point(0, 0);
            this.memberPaymentHead.Name = "memberPaymentHead";
            this.memberPaymentHead.Size = new System.Drawing.Size(724, 45);
            this.memberPaymentHead.TabIndex = 2;
            // 
            // memberPaymentFooter
            // 
            this.memberPaymentFooter.Controls.Add(this.memberAddUserBtn);
            this.memberPaymentFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.memberPaymentFooter.Location = new System.Drawing.Point(0, 273);
            this.memberPaymentFooter.Name = "memberPaymentFooter";
            this.memberPaymentFooter.Size = new System.Drawing.Size(724, 45);
            this.memberPaymentFooter.TabIndex = 3;
            // 
            // memberAddUserBtn
            // 
            this.memberAddUserBtn.Location = new System.Drawing.Point(13, 10);
            this.memberAddUserBtn.Name = "memberAddUserBtn";
            this.memberAddUserBtn.Size = new System.Drawing.Size(75, 23);
            this.memberAddUserBtn.TabIndex = 0;
            this.memberAddUserBtn.Text = "Add User";
            this.memberAddUserBtn.UseVisualStyleBackColor = true;
            // 
            // memberPaymentContainer
            // 
            this.memberPaymentContainer.Controls.Add(this.memberEmailIn);
            this.memberPaymentContainer.Controls.Add(this.memberClassNameIn);
            this.memberPaymentContainer.Controls.Add(this.memberNameIn);
            this.memberPaymentContainer.Controls.Add(this.memberNimIn);
            this.memberPaymentContainer.Controls.Add(this.memberEmaillbl);
            this.memberPaymentContainer.Controls.Add(this.memberClasslbl);
            this.memberPaymentContainer.Controls.Add(this.memberNamelbl);
            this.memberPaymentContainer.Controls.Add(this.memberNimlbl);
            this.memberPaymentContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memberPaymentContainer.Location = new System.Drawing.Point(0, 45);
            this.memberPaymentContainer.Name = "memberPaymentContainer";
            this.memberPaymentContainer.Padding = new System.Windows.Forms.Padding(5);
            this.memberPaymentContainer.Size = new System.Drawing.Size(724, 228);
            this.memberPaymentContainer.TabIndex = 4;
            // 
            // memberNimlbl
            // 
            this.memberNimlbl.AutoSize = true;
            this.memberNimlbl.Location = new System.Drawing.Point(8, 8);
            this.memberNimlbl.Name = "memberNimlbl";
            this.memberNimlbl.Size = new System.Drawing.Size(27, 13);
            this.memberNimlbl.TabIndex = 0;
            this.memberNimlbl.Text = "NIM";
            // 
            // memberNamelbl
            // 
            this.memberNamelbl.AutoSize = true;
            this.memberNamelbl.Location = new System.Drawing.Point(8, 34);
            this.memberNamelbl.Name = "memberNamelbl";
            this.memberNamelbl.Size = new System.Drawing.Size(35, 13);
            this.memberNamelbl.TabIndex = 1;
            this.memberNamelbl.Text = "Name";
            // 
            // memberClasslbl
            // 
            this.memberClasslbl.AutoSize = true;
            this.memberClasslbl.Location = new System.Drawing.Point(8, 60);
            this.memberClasslbl.Name = "memberClasslbl";
            this.memberClasslbl.Size = new System.Drawing.Size(32, 13);
            this.memberClasslbl.TabIndex = 2;
            this.memberClasslbl.Text = "Class";
            // 
            // memberEmaillbl
            // 
            this.memberEmaillbl.AutoSize = true;
            this.memberEmaillbl.Location = new System.Drawing.Point(8, 86);
            this.memberEmaillbl.Name = "memberEmaillbl";
            this.memberEmaillbl.Size = new System.Drawing.Size(32, 13);
            this.memberEmaillbl.TabIndex = 3;
            this.memberEmaillbl.Text = "Email";
            // 
            // memberNimIn
            // 
            this.memberNimIn.Location = new System.Drawing.Point(60, 5);
            this.memberNimIn.Name = "memberNimIn";
            this.memberNimIn.Size = new System.Drawing.Size(136, 20);
            this.memberNimIn.TabIndex = 4;
            // 
            // memberNameIn
            // 
            this.memberNameIn.Location = new System.Drawing.Point(60, 31);
            this.memberNameIn.Name = "memberNameIn";
            this.memberNameIn.Size = new System.Drawing.Size(136, 20);
            this.memberNameIn.TabIndex = 5;
            // 
            // memberClassNameIn
            // 
            this.memberClassNameIn.Location = new System.Drawing.Point(60, 57);
            this.memberClassNameIn.Name = "memberClassNameIn";
            this.memberClassNameIn.Size = new System.Drawing.Size(136, 20);
            this.memberClassNameIn.TabIndex = 6;
            // 
            // memberEmailIn
            // 
            this.memberEmailIn.Location = new System.Drawing.Point(60, 83);
            this.memberEmailIn.Name = "memberEmailIn";
            this.memberEmailIn.Size = new System.Drawing.Size(136, 20);
            this.memberEmailIn.TabIndex = 7;
            // 
            // addMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 318);
            this.Controls.Add(this.memberPaymentContainer);
            this.Controls.Add(this.memberPaymentFooter);
            this.Controls.Add(this.memberPaymentHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "addMember";
            this.Text = "addMember";
            this.memberPaymentFooter.ResumeLayout(false);
            this.memberPaymentContainer.ResumeLayout(false);
            this.memberPaymentContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel memberPaymentHead;
        private System.Windows.Forms.Panel memberPaymentFooter;
        private System.Windows.Forms.Button memberAddUserBtn;
        private System.Windows.Forms.Panel memberPaymentContainer;
        private System.Windows.Forms.TextBox memberEmailIn;
        private System.Windows.Forms.TextBox memberClassNameIn;
        private System.Windows.Forms.TextBox memberNameIn;
        private System.Windows.Forms.TextBox memberNimIn;
        private System.Windows.Forms.Label memberEmaillbl;
        private System.Windows.Forms.Label memberClasslbl;
        private System.Windows.Forms.Label memberNamelbl;
        private System.Windows.Forms.Label memberNimlbl;
    }
}