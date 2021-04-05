
namespace GUI_StudentManagement
{
    partial class Register_Child
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
            this.RePasswordLabel = new System.Windows.Forms.Label();
            this.txtRepassword = new System.Windows.Forms.TextBox();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // RePasswordLabel
            // 
            this.RePasswordLabel.AutoSize = true;
            this.RePasswordLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RePasswordLabel.Location = new System.Drawing.Point(37, 184);
            this.RePasswordLabel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.RePasswordLabel.Name = "RePasswordLabel";
            this.RePasswordLabel.Size = new System.Drawing.Size(85, 20);
            this.RePasswordLabel.TabIndex = 28;
            this.RePasswordLabel.Text = "RePassword";
            // 
            // txtRepassword
            // 
            this.txtRepassword.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRepassword.Location = new System.Drawing.Point(99, 207);
            this.txtRepassword.Name = "txtRepassword";
            this.txtRepassword.PasswordChar = '*';
            this.txtRepassword.Size = new System.Drawing.Size(192, 26);
            this.txtRepassword.TabIndex = 27;
            // 
            // RegisterButton
            // 
            this.RegisterButton.AllowDrop = true;
            this.RegisterButton.AutoSize = true;
            this.RegisterButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.RegisterButton.ForeColor = System.Drawing.SystemColors.Control;
            this.RegisterButton.Location = new System.Drawing.Point(146, 253);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(109, 37);
            this.RegisterButton.TabIndex = 26;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = false;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(45, 124);
            this.PasswordLabel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(68, 20);
            this.PasswordLabel.TabIndex = 25;
            this.PasswordLabel.Text = "Password";
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.BackColor = System.Drawing.Color.White;
            this.UserNameLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLabel.Location = new System.Drawing.Point(41, 60);
            this.UserNameLabel.Margin = new System.Windows.Forms.Padding(3);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.UserNameLabel.Size = new System.Drawing.Size(76, 20);
            this.UserNameLabel.TabIndex = 24;
            this.UserNameLabel.Text = "User Name";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(99, 147);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(192, 26);
            this.txtPassword.TabIndex = 23;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(99, 86);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(192, 26);
            this.txtUsername.TabIndex = 22;
            // 
            // Register_Child
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(392, 342);
            this.Controls.Add(this.RePasswordLabel);
            this.Controls.Add(this.txtRepassword);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Register_Child";
            this.Text = "Register_Child";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RePasswordLabel;
        private System.Windows.Forms.TextBox txtRepassword;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
    }
}