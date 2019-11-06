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
            this.nameTbox = new System.Windows.Forms.TextBox();
            this.priceTbox = new System.Windows.Forms.TextBox();
            this.newExpenseAddBtn = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.commentTbox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
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
            // nameTbox
            // 
            this.nameTbox.Location = new System.Drawing.Point(24, 7);
            this.nameTbox.Name = "nameTbox";
            this.nameTbox.Size = new System.Drawing.Size(207, 20);
            this.nameTbox.TabIndex = 4;
            // 
            // priceTbox
            // 
            this.priceTbox.Location = new System.Drawing.Point(24, 33);
            this.priceTbox.Name = "priceTbox";
            this.priceTbox.Size = new System.Drawing.Size(207, 20);
            this.priceTbox.TabIndex = 5;
            // 
            // newExpenseAddBtn
            // 
            this.newExpenseAddBtn.Location = new System.Drawing.Point(16, 257);
            this.newExpenseAddBtn.Name = "newExpenseAddBtn";
            this.newExpenseAddBtn.Size = new System.Drawing.Size(304, 37);
            this.newExpenseAddBtn.TabIndex = 8;
            this.newExpenseAddBtn.Text = "Add";
            this.newExpenseAddBtn.UseVisualStyleBackColor = true;
            this.newExpenseAddBtn.Click += new System.EventHandler(this.newExpenseAddBtn_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(150, 206);
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
            // commentTbox
            // 
            this.commentTbox.Location = new System.Drawing.Point(24, 59);
            this.commentTbox.Multiline = true;
            this.commentTbox.Name = "commentTbox";
            this.commentTbox.Size = new System.Drawing.Size(207, 101);
            this.commentTbox.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.commentTbox);
            this.panel1.Controls.Add(this.nameTbox);
            this.panel1.Controls.Add(this.priceTbox);
            this.panel1.Location = new System.Drawing.Point(104, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 163);
            this.panel1.TabIndex = 17;
            // 
            // newExpense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.newExpenseAddBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "newExpense";
            this.Text = "newExpense";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameTbox;
        private System.Windows.Forms.TextBox priceTbox;
        private System.Windows.Forms.Button newExpenseAddBtn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox commentTbox;
        private System.Windows.Forms.Panel panel1;
    }
}