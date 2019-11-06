namespace Badminton_Club_System
{
    partial class loginPage
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
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passLabel = new System.Windows.Forms.Label();
            this.loginUserTextBox = new System.Windows.Forms.TextBox();
            this.loginPassTextBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(24, 62);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(110, 25);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "Username";
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Location = new System.Drawing.Point(24, 160);
            this.passLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(106, 25);
            this.passLabel.TabIndex = 1;
            this.passLabel.Text = "Password";
            // 
            // loginUserTextBox
            // 
            this.loginUserTextBox.Location = new System.Drawing.Point(188, 62);
            this.loginUserTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.loginUserTextBox.Name = "loginUserTextBox";
            this.loginUserTextBox.Size = new System.Drawing.Size(306, 31);
            this.loginUserTextBox.TabIndex = 2;
            // 
            // loginPassTextBox
            // 
            this.loginPassTextBox.Location = new System.Drawing.Point(188, 160);
            this.loginPassTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.loginPassTextBox.Name = "loginPassTextBox";
            this.loginPassTextBox.Size = new System.Drawing.Size(306, 31);
            this.loginPassTextBox.TabIndex = 3;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.loginButton.Location = new System.Drawing.Point(188, 298);
            this.loginButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(150, 66);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // loginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(584, 523);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.loginPassTextBox);
            this.Controls.Add(this.loginUserTextBox);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.usernameLabel);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "loginPage";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.TextBox loginUserTextBox;
        private System.Windows.Forms.TextBox loginPassTextBox;
        public System.Windows.Forms.Button loginButton;
    }
}

