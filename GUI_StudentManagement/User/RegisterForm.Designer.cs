
namespace GUI_StudentManagement.User
{
    partial class RegisterForm
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
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.Register = new System.Windows.Forms.Button();
            this.uploadImg = new System.Windows.Forms.Button();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxUserID = new System.Windows.Forms.TextBox();
            this.Picture = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.Lname = new System.Windows.Forms.Label();
            this.Fname = new System.Windows.Forms.Label();
            this.UserID = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.textBoxPassword.Location = new System.Drawing.Point(195, 176);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(278, 29);
            this.textBoxPassword.TabIndex = 49;
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.Color.White;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Password.Location = new System.Drawing.Point(37, 180);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(111, 24);
            this.Password.TabIndex = 48;
            this.Password.Text = "Password";
            // 
            // Register
            // 
            this.Register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(63)))), ((int)(((byte)(52)))));
            this.Register.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Register.Location = new System.Drawing.Point(65, 432);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(429, 50);
            this.Register.TabIndex = 47;
            this.Register.Text = "Register";
            this.Register.UseVisualStyleBackColor = false;
            this.Register.Click += new System.EventHandler(this.Register_Click_1);
            // 
            // uploadImg
            // 
            this.uploadImg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(188)))), ((int)(((byte)(249)))));
            this.uploadImg.Location = new System.Drawing.Point(196, 376);
            this.uploadImg.Name = "uploadImg";
            this.uploadImg.Size = new System.Drawing.Size(278, 24);
            this.uploadImg.TabIndex = 46;
            this.uploadImg.Text = "Upload Image";
            this.uploadImg.UseVisualStyleBackColor = false;
            this.uploadImg.Click += new System.EventHandler(this.uploadImg_Click_1);
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            this.pictureBoxImage.Location = new System.Drawing.Point(196, 231);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(277, 139);
            this.pictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxImage.TabIndex = 45;
            this.pictureBoxImage.TabStop = false;
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.textBoxUserName.Location = new System.Drawing.Point(196, 130);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(278, 29);
            this.textBoxUserName.TabIndex = 44;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.textBoxLastName.Location = new System.Drawing.Point(195, 85);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(278, 29);
            this.textBoxLastName.TabIndex = 43;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.textBoxFirstName.Location = new System.Drawing.Point(195, 48);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(278, 29);
            this.textBoxFirstName.TabIndex = 42;
            // 
            // textBoxUserID
            // 
            this.textBoxUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.textBoxUserID.Location = new System.Drawing.Point(195, 13);
            this.textBoxUserID.Name = "textBoxUserID";
            this.textBoxUserID.Size = new System.Drawing.Size(278, 29);
            this.textBoxUserID.TabIndex = 41;
            // 
            // Picture
            // 
            this.Picture.BackColor = System.Drawing.Color.White;
            this.Picture.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Picture.Location = new System.Drawing.Point(39, 231);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(111, 24);
            this.Picture.TabIndex = 40;
            this.Picture.Text = "Picture";
            // 
            // Username
            // 
            this.Username.BackColor = System.Drawing.Color.White;
            this.Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Username.Location = new System.Drawing.Point(39, 134);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(111, 24);
            this.Username.TabIndex = 39;
            this.Username.Text = "User name";
            // 
            // Lname
            // 
            this.Lname.BackColor = System.Drawing.Color.White;
            this.Lname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Lname.Location = new System.Drawing.Point(38, 89);
            this.Lname.Name = "Lname";
            this.Lname.Size = new System.Drawing.Size(111, 24);
            this.Lname.TabIndex = 38;
            this.Lname.Text = "Last Name";
            // 
            // Fname
            // 
            this.Fname.BackColor = System.Drawing.Color.White;
            this.Fname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Fname.Location = new System.Drawing.Point(38, 52);
            this.Fname.Name = "Fname";
            this.Fname.Size = new System.Drawing.Size(111, 24);
            this.Fname.TabIndex = 37;
            this.Fname.Text = "Fist Name";
            // 
            // UserID
            // 
            this.UserID.BackColor = System.Drawing.Color.White;
            this.UserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.UserID.Location = new System.Drawing.Point(38, 16);
            this.UserID.Name = "UserID";
            this.UserID.Size = new System.Drawing.Size(111, 24);
            this.UserID.TabIndex = 36;
            this.UserID.Text = "User ID";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(181, 501);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(165, 13);
            this.linkLabel1.TabIndex = 50;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Have an account? Back to Login";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(534, 523);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.uploadImg);
            this.Controls.Add(this.pictureBoxImage);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.textBoxUserID);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.Lname);
            this.Controls.Add(this.Fname);
            this.Controls.Add(this.UserID);
            this.Controls.Add(this.Picture);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Button Register;
        private System.Windows.Forms.Button uploadImg;
        private System.Windows.Forms.PictureBox pictureBoxImage;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxUserID;
        private System.Windows.Forms.Label Picture;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label Lname;
        private System.Windows.Forms.Label Fname;
        private System.Windows.Forms.Label UserID;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}