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
            this.memberEmailIn = new System.Windows.Forms.TextBox();
            this.memberClassNameIn = new System.Windows.Forms.TextBox();
            this.memberNameIn = new System.Windows.Forms.TextBox();
            this.memberNimIn = new System.Windows.Forms.TextBox();
            this.memberEmaillbl = new System.Windows.Forms.Label();
            this.memberClasslbl = new System.Windows.Forms.Label();
            this.memberNamelbl = new System.Windows.Forms.Label();
            this.memberNimlbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.memberPaymentFooter.SuspendLayout();
            this.memberPaymentContainer.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.memberAddUserBtn.Enabled = false;
            this.memberAddUserBtn.Location = new System.Drawing.Point(12, 6);
            this.memberAddUserBtn.Name = "memberAddUserBtn";
            this.memberAddUserBtn.Size = new System.Drawing.Size(105, 33);
            this.memberAddUserBtn.TabIndex = 0;
            this.memberAddUserBtn.Text = "Add User";
            this.memberAddUserBtn.UseVisualStyleBackColor = true;
            this.memberAddUserBtn.Click += new System.EventHandler(this.memberAddUserBtn_Click);
            // 
            // memberPaymentContainer
            // 
            this.memberPaymentContainer.Controls.Add(this.panel1);
            this.memberPaymentContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memberPaymentContainer.Location = new System.Drawing.Point(0, 45);
            this.memberPaymentContainer.Name = "memberPaymentContainer";
            this.memberPaymentContainer.Padding = new System.Windows.Forms.Padding(5);
            this.memberPaymentContainer.Size = new System.Drawing.Size(724, 228);
            this.memberPaymentContainer.TabIndex = 4;
            // 
            // memberEmailIn
            // 
            this.memberEmailIn.Location = new System.Drawing.Point(61, 76);
            this.memberEmailIn.Name = "memberEmailIn";
            this.memberEmailIn.Size = new System.Drawing.Size(136, 20);
            this.memberEmailIn.TabIndex = 7;
            this.memberEmailIn.TextChanged += new System.EventHandler(this.validation);
            // 
            // memberClassNameIn
            // 
            this.memberClassNameIn.Location = new System.Drawing.Point(61, 50);
            this.memberClassNameIn.Name = "memberClassNameIn";
            this.memberClassNameIn.Size = new System.Drawing.Size(136, 20);
            this.memberClassNameIn.TabIndex = 6;
            this.memberClassNameIn.TextChanged += new System.EventHandler(this.validation);
            // 
            // memberNameIn
            // 
            this.memberNameIn.Location = new System.Drawing.Point(61, 24);
            this.memberNameIn.Name = "memberNameIn";
            this.memberNameIn.Size = new System.Drawing.Size(136, 20);
            this.memberNameIn.TabIndex = 5;
            this.memberNameIn.TextChanged += new System.EventHandler(this.validation);
            // 
            // memberNimIn
            // 
            this.memberNimIn.Location = new System.Drawing.Point(61, -2);
            this.memberNimIn.Name = "memberNimIn";
            this.memberNimIn.Size = new System.Drawing.Size(136, 20);
            this.memberNimIn.TabIndex = 4;
            this.memberNimIn.TextChanged += new System.EventHandler(this.validation);
            // 
            // memberEmaillbl
            // 
            this.memberEmaillbl.AutoSize = true;
            this.memberEmaillbl.Location = new System.Drawing.Point(9, 76);
            this.memberEmaillbl.Name = "memberEmaillbl";
            this.memberEmaillbl.Size = new System.Drawing.Size(32, 13);
            this.memberEmaillbl.TabIndex = 3;
            this.memberEmaillbl.Text = "Email";
            // 
            // memberClasslbl
            // 
            this.memberClasslbl.AutoSize = true;
            this.memberClasslbl.Location = new System.Drawing.Point(9, 53);
            this.memberClasslbl.Name = "memberClasslbl";
            this.memberClasslbl.Size = new System.Drawing.Size(32, 13);
            this.memberClasslbl.TabIndex = 2;
            this.memberClasslbl.Text = "Class";
            // 
            // memberNamelbl
            // 
            this.memberNamelbl.AutoSize = true;
            this.memberNamelbl.Location = new System.Drawing.Point(9, 27);
            this.memberNamelbl.Name = "memberNamelbl";
            this.memberNamelbl.Size = new System.Drawing.Size(35, 13);
            this.memberNamelbl.TabIndex = 1;
            this.memberNamelbl.Text = "Name";
            // 
            // memberNimlbl
            // 
            this.memberNimlbl.AutoSize = true;
            this.memberNimlbl.Location = new System.Drawing.Point(9, 1);
            this.memberNimlbl.Name = "memberNimlbl";
            this.memberNimlbl.Size = new System.Drawing.Size(27, 13);
            this.memberNimlbl.TabIndex = 0;
            this.memberNimlbl.Text = "NIM";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.memberClassNameIn);
            this.panel1.Controls.Add(this.memberEmailIn);
            this.panel1.Controls.Add(this.memberNimlbl);
            this.panel1.Controls.Add(this.memberNamelbl);
            this.panel1.Controls.Add(this.memberNameIn);
            this.panel1.Controls.Add(this.memberClasslbl);
            this.panel1.Controls.Add(this.memberNimIn);
            this.panel1.Controls.Add(this.memberEmaillbl);
            this.panel1.Location = new System.Drawing.Point(12, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 130);
            this.panel1.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(61, 102);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(136, 20);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.validation);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Intake";
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}