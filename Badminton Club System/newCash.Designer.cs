namespace Badminton_Club_System
{
    partial class newCash
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
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.newCashAddBtn = new System.Windows.Forms.Button();
            this.priceTbox = new System.Windows.Forms.TextBox();
            this.tNameTbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.commentTbox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(160, 204);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(185, 20);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // newCashAddBtn
            // 
            this.newCashAddBtn.Location = new System.Drawing.Point(23, 249);
            this.newCashAddBtn.Name = "newCashAddBtn";
            this.newCashAddBtn.Size = new System.Drawing.Size(304, 37);
            this.newCashAddBtn.TabIndex = 17;
            this.newCashAddBtn.Text = "Add";
            this.newCashAddBtn.UseVisualStyleBackColor = true;
            this.newCashAddBtn.Click += new System.EventHandler(this.newCashAddBtn_Click);
            // 
            // priceTbox
            // 
            this.priceTbox.Location = new System.Drawing.Point(6, 28);
            this.priceTbox.Name = "priceTbox";
            this.priceTbox.Size = new System.Drawing.Size(207, 20);
            this.priceTbox.TabIndex = 14;
            // 
            // tNameTbox
            // 
            this.tNameTbox.Location = new System.Drawing.Point(6, 2);
            this.tNameTbox.Name = "tNameTbox";
            this.tNameTbox.Size = new System.Drawing.Size(207, 20);
            this.tNameTbox.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Comment";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Transaction Name";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.commentTbox);
            this.panel1.Controls.Add(this.tNameTbox);
            this.panel1.Controls.Add(this.priceTbox);
            this.panel1.Location = new System.Drawing.Point(142, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 159);
            this.panel1.TabIndex = 18;
            // 
            // commentTbox
            // 
            this.commentTbox.Location = new System.Drawing.Point(6, 55);
            this.commentTbox.Multiline = true;
            this.commentTbox.Name = "commentTbox";
            this.commentTbox.Size = new System.Drawing.Size(207, 101);
            this.commentTbox.TabIndex = 15;
            // 
            // newCash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.newCashAddBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "newCash";
            this.Text = "newCash";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button newCashAddBtn;
        private System.Windows.Forms.TextBox priceTbox;
        private System.Windows.Forms.TextBox tNameTbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox commentTbox;
    }
}