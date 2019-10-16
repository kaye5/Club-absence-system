namespace Badminton_Club_System
{
    partial class newExpense
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.newExpenseTrasnNameTbxox = new System.Windows.Forms.TextBox();
            this.newExpensePriceTbox = new System.Windows.Forms.TextBox();
            this.newExpenseCommentTbox = new System.Windows.Forms.RichTextBox();
            this.newExpenseAddBtn = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Transaction Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Comment";
            // 
            // newExpenseTrasnNameTbxox
            // 
            this.newExpenseTrasnNameTbxox.Location = new System.Drawing.Point(113, 41);
            this.newExpenseTrasnNameTbxox.Name = "newExpenseTrasnNameTbxox";
            this.newExpenseTrasnNameTbxox.Size = new System.Drawing.Size(207, 20);
            this.newExpenseTrasnNameTbxox.TabIndex = 4;
            // 
            // newExpensePriceTbox
            // 
            this.newExpensePriceTbox.Location = new System.Drawing.Point(113, 67);
            this.newExpensePriceTbox.Name = "newExpensePriceTbox";
            this.newExpensePriceTbox.Size = new System.Drawing.Size(207, 20);
            this.newExpensePriceTbox.TabIndex = 5;
            // 
            // newExpenseCommentTbox
            // 
            this.newExpenseCommentTbox.Location = new System.Drawing.Point(113, 93);
            this.newExpenseCommentTbox.Name = "newExpenseCommentTbox";
            this.newExpenseCommentTbox.Size = new System.Drawing.Size(207, 107);
            this.newExpenseCommentTbox.TabIndex = 6;
            this.newExpenseCommentTbox.Text = "";
            // 
            // newExpenseAddBtn
            // 
            this.newExpenseAddBtn.Location = new System.Drawing.Point(16, 257);
            this.newExpenseAddBtn.Name = "newExpenseAddBtn";
            this.newExpenseAddBtn.Size = new System.Drawing.Size(304, 37);
            this.newExpenseAddBtn.TabIndex = 8;
            this.newExpenseAddBtn.Text = "Add";
            this.newExpenseAddBtn.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(135, 206);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(185, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date";
            // 
            // newExpense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.newExpenseAddBtn);
            this.Controls.Add(this.newExpenseCommentTbox);
            this.Controls.Add(this.newExpensePriceTbox);
            this.Controls.Add(this.newExpenseTrasnNameTbxox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "newExpense";
            this.Text = "newExpense";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox newExpenseTrasnNameTbxox;
        private System.Windows.Forms.TextBox newExpensePriceTbox;
        private System.Windows.Forms.RichTextBox newExpenseCommentTbox;
        private System.Windows.Forms.Button newExpenseAddBtn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
    }
}