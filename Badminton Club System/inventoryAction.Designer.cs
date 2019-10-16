namespace Badminton_Club_System
{
    partial class inventoryAction
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
            this.inventoryActionCountTbox = new System.Windows.Forms.NumericUpDown();
            this.inventoryActionCommentTbox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inventoryActionAddBtn = new System.Windows.Forms.Button();
            this.inventoryActionIDCB = new System.Windows.Forms.ComboBox();
            this.inventoryItemRemoveBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.inventoryActionNameTbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryActionCountTbox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item ID";
            // 
            // inventoryActionCountTbox
            // 
            this.inventoryActionCountTbox.Location = new System.Drawing.Point(77, 51);
            this.inventoryActionCountTbox.Name = "inventoryActionCountTbox";
            this.inventoryActionCountTbox.Size = new System.Drawing.Size(61, 20);
            this.inventoryActionCountTbox.TabIndex = 3;
            // 
            // inventoryActionCommentTbox
            // 
            this.inventoryActionCommentTbox.Location = new System.Drawing.Point(77, 78);
            this.inventoryActionCommentTbox.Name = "inventoryActionCommentTbox";
            this.inventoryActionCommentTbox.Size = new System.Drawing.Size(186, 96);
            this.inventoryActionCommentTbox.TabIndex = 4;
            this.inventoryActionCommentTbox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Count";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Comment";
            // 
            // inventoryActionAddBtn
            // 
            this.inventoryActionAddBtn.Location = new System.Drawing.Point(16, 198);
            this.inventoryActionAddBtn.Name = "inventoryActionAddBtn";
            this.inventoryActionAddBtn.Size = new System.Drawing.Size(102, 23);
            this.inventoryActionAddBtn.TabIndex = 7;
            this.inventoryActionAddBtn.Text = "Add";
            this.inventoryActionAddBtn.UseVisualStyleBackColor = true;
            // 
            // inventoryActionIDCB
            // 
            this.inventoryActionIDCB.FormattingEnabled = true;
            this.inventoryActionIDCB.Location = new System.Drawing.Point(77, 25);
            this.inventoryActionIDCB.Name = "inventoryActionIDCB";
            this.inventoryActionIDCB.Size = new System.Drawing.Size(186, 21);
            this.inventoryActionIDCB.TabIndex = 8;
            // 
            // inventoryItemRemoveBtn
            // 
            this.inventoryItemRemoveBtn.Location = new System.Drawing.Point(161, 198);
            this.inventoryItemRemoveBtn.Name = "inventoryItemRemoveBtn";
            this.inventoryItemRemoveBtn.Size = new System.Drawing.Size(102, 23);
            this.inventoryItemRemoveBtn.TabIndex = 9;
            this.inventoryItemRemoveBtn.Text = "Remove";
            this.inventoryItemRemoveBtn.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(283, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Item Name";
            // 
            // inventoryActionNameTbox
            // 
            this.inventoryActionNameTbox.Location = new System.Drawing.Point(348, 25);
            this.inventoryActionNameTbox.Name = "inventoryActionNameTbox";
            this.inventoryActionNameTbox.ReadOnly = true;
            this.inventoryActionNameTbox.Size = new System.Drawing.Size(145, 20);
            this.inventoryActionNameTbox.TabIndex = 11;
            // 
            // inventoryAction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 422);
            this.Controls.Add(this.inventoryActionNameTbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.inventoryItemRemoveBtn);
            this.Controls.Add(this.inventoryActionIDCB);
            this.Controls.Add(this.inventoryActionAddBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inventoryActionCommentTbox);
            this.Controls.Add(this.inventoryActionCountTbox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "inventoryAction";
            this.Text = "addInventory";
            ((System.ComponentModel.ISupportInitialize)(this.inventoryActionCountTbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown inventoryActionCountTbox;
        private System.Windows.Forms.RichTextBox inventoryActionCommentTbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button inventoryActionAddBtn;
        private System.Windows.Forms.ComboBox inventoryActionIDCB;
        private System.Windows.Forms.Button inventoryItemRemoveBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inventoryActionNameTbox;
    }
}