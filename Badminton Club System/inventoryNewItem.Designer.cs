namespace Badminton_Club_System
{
    partial class inventoryNewItem
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
            this.label3 = new System.Windows.Forms.Label();
            this.inventoryNewItemNameTbox = new System.Windows.Forms.TextBox();
            this.inventoryNewItemCommentTbox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inventoryNewItemIDTbox = new System.Windows.Forms.TextBox();
            this.inventoryNewItemAddBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Comment";
            // 
            // inventoryNewItemNameTbox
            // 
            this.inventoryNewItemNameTbox.Location = new System.Drawing.Point(85, 9);
            this.inventoryNewItemNameTbox.Name = "inventoryNewItemNameTbox";
            this.inventoryNewItemNameTbox.Size = new System.Drawing.Size(160, 20);
            this.inventoryNewItemNameTbox.TabIndex = 0;
            this.inventoryNewItemNameTbox.TextChanged += new System.EventHandler(this.validate);
            // 
            // inventoryNewItemCommentTbox
            // 
            this.inventoryNewItemCommentTbox.Location = new System.Drawing.Point(85, 80);
            this.inventoryNewItemCommentTbox.Name = "inventoryNewItemCommentTbox";
            this.inventoryNewItemCommentTbox.Size = new System.Drawing.Size(160, 96);
            this.inventoryNewItemCommentTbox.TabIndex = 2;
            this.inventoryNewItemCommentTbox.Text = "";
            this.inventoryNewItemCommentTbox.TextChanged += new System.EventHandler(this.validate);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Item ID";
            // 
            // inventoryNewItemIDTbox
            // 
            this.inventoryNewItemIDTbox.Location = new System.Drawing.Point(85, 38);
            this.inventoryNewItemIDTbox.Name = "inventoryNewItemIDTbox";
            this.inventoryNewItemIDTbox.Size = new System.Drawing.Size(160, 20);
            this.inventoryNewItemIDTbox.TabIndex = 1;
            this.inventoryNewItemIDTbox.TextChanged += new System.EventHandler(this.validate);
            // 
            // inventoryNewItemAddBtn
            // 
            this.inventoryNewItemAddBtn.Enabled = false;
            this.inventoryNewItemAddBtn.Location = new System.Drawing.Point(12, 239);
            this.inventoryNewItemAddBtn.Name = "inventoryNewItemAddBtn";
            this.inventoryNewItemAddBtn.Size = new System.Drawing.Size(112, 41);
            this.inventoryNewItemAddBtn.TabIndex = 0;
            this.inventoryNewItemAddBtn.Text = "Add";
            this.inventoryNewItemAddBtn.UseVisualStyleBackColor = true;
            this.inventoryNewItemAddBtn.Click += new System.EventHandler(this.inventoryNewItemAddBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.inventoryNewItemCommentTbox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.inventoryNewItemIDTbox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.inventoryNewItemNameTbox);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 221);
            this.panel1.TabIndex = 8;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(85, 188);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Stock";
            // 
            // inventoryNewItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 422);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.inventoryNewItemAddBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "inventoryNewItem";
            this.Text = "inventoryNewItem";
            this.TextChanged += new System.EventHandler(this.validate);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inventoryNewItemNameTbox;
        private System.Windows.Forms.RichTextBox inventoryNewItemCommentTbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inventoryNewItemIDTbox;
        private System.Windows.Forms.Button inventoryNewItemAddBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label4;
    }
}