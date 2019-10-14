namespace Badminton_Club_System
{
    partial class Absence_new
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
            this.AbsenceNewDateLabel = new System.Windows.Forms.Label();
            this.absenceNewDatePicker = new System.Windows.Forms.DateTimePicker();
            this.absenceNewCreateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AbsenceNewDateLabel
            // 
            this.AbsenceNewDateLabel.AutoSize = true;
            this.AbsenceNewDateLabel.Location = new System.Drawing.Point(12, 32);
            this.AbsenceNewDateLabel.Name = "AbsenceNewDateLabel";
            this.AbsenceNewDateLabel.Size = new System.Drawing.Size(39, 13);
            this.AbsenceNewDateLabel.TabIndex = 0;
            this.AbsenceNewDateLabel.Text = "Date : ";
            // 
            // absenceNewDatePicker
            // 
            this.absenceNewDatePicker.Location = new System.Drawing.Point(57, 32);
            this.absenceNewDatePicker.Name = "absenceNewDatePicker";
            this.absenceNewDatePicker.Size = new System.Drawing.Size(200, 20);
            this.absenceNewDatePicker.TabIndex = 1;
            // 
            // absenceNewCreateButton
            // 
            this.absenceNewCreateButton.Location = new System.Drawing.Point(57, 78);
            this.absenceNewCreateButton.Name = "absenceNewCreateButton";
            this.absenceNewCreateButton.Size = new System.Drawing.Size(75, 23);
            this.absenceNewCreateButton.TabIndex = 2;
            this.absenceNewCreateButton.Text = "Create";
            this.absenceNewCreateButton.UseVisualStyleBackColor = true;
            // 
            // Absence_new
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 360);
            this.Controls.Add(this.absenceNewCreateButton);
            this.Controls.Add(this.absenceNewDatePicker);
            this.Controls.Add(this.AbsenceNewDateLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Absence_new";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AbsenceNewDateLabel;
        private System.Windows.Forms.DateTimePicker absenceNewDatePicker;
        private System.Windows.Forms.Button absenceNewCreateButton;
    }
}