
namespace GUI_StudentManagement.User
{
    partial class AddContactForm
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
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.textboxEmail = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAddContact = new System.Windows.Forms.Button();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxGroup = new System.Windows.Forms.ComboBox();
            this.textboxGroup = new System.Windows.Forms.Label();
            this.ButtonUpload = new System.Windows.Forms.Button();
            this.TextBoxAdress = new System.Windows.Forms.TextBox();
            this.TextBoxPhone = new System.Windows.Forms.TextBox();
            this.TextBoxlname = new System.Windows.Forms.TextBox();
            this.TextBoxFname = new System.Windows.Forms.TextBox();
            this.Picture = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.Label();
            this.PictureBoxStudentImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxStudentImage)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxMail
            // 
            this.textBoxMail.Location = new System.Drawing.Point(147, 178);
            this.textBoxMail.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(216, 20);
            this.textBoxMail.TabIndex = 88;
            // 
            // textboxEmail
            // 
            this.textboxEmail.AutoSize = true;
            this.textboxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxEmail.Location = new System.Drawing.Point(71, 179);
            this.textboxEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.textboxEmail.Name = "textboxEmail";
            this.textboxEmail.Size = new System.Drawing.Size(42, 17);
            this.textboxEmail.TabIndex = 87;
            this.textboxEmail.Text = "Email";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(223, 402);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(120, 33);
            this.buttonCancel.TabIndex = 86;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click_1);
            // 
            // buttonAddContact
            // 
            this.buttonAddContact.Location = new System.Drawing.Point(48, 402);
            this.buttonAddContact.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddContact.Name = "buttonAddContact";
            this.buttonAddContact.Size = new System.Drawing.Size(108, 33);
            this.buttonAddContact.TabIndex = 85;
            this.buttonAddContact.Text = "Add Contact";
            this.buttonAddContact.UseVisualStyleBackColor = true;
            this.buttonAddContact.Click += new System.EventHandler(this.buttonAddContact_Click_1);
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(294, 298);
            this.textBoxId.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(68, 20);
            this.textBoxId.TabIndex = 84;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(256, 295);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 83;
            this.label1.Text = "ID:";
            // 
            // comboBoxGroup
            // 
            this.comboBoxGroup.FormattingEnabled = true;
            this.comboBoxGroup.Location = new System.Drawing.Point(147, 91);
            this.comboBoxGroup.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxGroup.Name = "comboBoxGroup";
            this.comboBoxGroup.Size = new System.Drawing.Size(216, 21);
            this.comboBoxGroup.TabIndex = 82;
            // 
            // textboxGroup
            // 
            this.textboxGroup.AutoSize = true;
            this.textboxGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxGroup.Location = new System.Drawing.Point(71, 91);
            this.textboxGroup.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.textboxGroup.Name = "textboxGroup";
            this.textboxGroup.Size = new System.Drawing.Size(48, 17);
            this.textboxGroup.TabIndex = 81;
            this.textboxGroup.Text = "Group";
            // 
            // ButtonUpload
            // 
            this.ButtonUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonUpload.Location = new System.Drawing.Point(147, 361);
            this.ButtonUpload.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonUpload.Name = "ButtonUpload";
            this.ButtonUpload.Size = new System.Drawing.Size(105, 23);
            this.ButtonUpload.TabIndex = 80;
            this.ButtonUpload.Text = "Upload";
            this.ButtonUpload.UseVisualStyleBackColor = true;
            this.ButtonUpload.Click += new System.EventHandler(this.ButtonUpload_Click_1);
            // 
            // TextBoxAdress
            // 
            this.TextBoxAdress.Location = new System.Drawing.Point(148, 211);
            this.TextBoxAdress.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxAdress.Multiline = true;
            this.TextBoxAdress.Name = "TextBoxAdress";
            this.TextBoxAdress.Size = new System.Drawing.Size(216, 71);
            this.TextBoxAdress.TabIndex = 78;
            // 
            // TextBoxPhone
            // 
            this.TextBoxPhone.Location = new System.Drawing.Point(148, 134);
            this.TextBoxPhone.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxPhone.Name = "TextBoxPhone";
            this.TextBoxPhone.Size = new System.Drawing.Size(216, 20);
            this.TextBoxPhone.TabIndex = 77;
            // 
            // TextBoxlname
            // 
            this.TextBoxlname.Location = new System.Drawing.Point(148, 41);
            this.TextBoxlname.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxlname.Name = "TextBoxlname";
            this.TextBoxlname.Size = new System.Drawing.Size(215, 20);
            this.TextBoxlname.TabIndex = 76;
            // 
            // TextBoxFname
            // 
            this.TextBoxFname.Location = new System.Drawing.Point(148, 9);
            this.TextBoxFname.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxFname.Name = "TextBoxFname";
            this.TextBoxFname.Size = new System.Drawing.Size(215, 20);
            this.TextBoxFname.TabIndex = 75;
            // 
            // Picture
            // 
            this.Picture.AutoSize = true;
            this.Picture.Location = new System.Drawing.Point(74, 298);
            this.Picture.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(40, 13);
            this.Picture.TabIndex = 74;
            this.Picture.Text = "Picture\r\n";
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address.Location = new System.Drawing.Point(60, 211);
            this.Address.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(60, 17);
            this.Address.TabIndex = 73;
            this.Address.Text = "Address";
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone.Location = new System.Drawing.Point(73, 135);
            this.Phone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(49, 17);
            this.Phone.TabIndex = 72;
            this.Phone.Text = "Phone";
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastName.Location = new System.Drawing.Point(45, 46);
            this.LastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(76, 17);
            this.LastName.TabIndex = 71;
            this.LastName.Text = "Last Name";
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstName.Location = new System.Drawing.Point(46, 9);
            this.FirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(76, 17);
            this.FirstName.TabIndex = 70;
            this.FirstName.Text = "First Name";
            // 
            // PictureBoxStudentImage
            // 
            this.PictureBoxStudentImage.Location = new System.Drawing.Point(147, 298);
            this.PictureBoxStudentImage.Margin = new System.Windows.Forms.Padding(2);
            this.PictureBoxStudentImage.Name = "PictureBoxStudentImage";
            this.PictureBoxStudentImage.Size = new System.Drawing.Size(105, 50);
            this.PictureBoxStudentImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxStudentImage.TabIndex = 79;
            this.PictureBoxStudentImage.TabStop = false;
            // 
            // AddContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 450);
            this.Controls.Add(this.textBoxMail);
            this.Controls.Add(this.textboxEmail);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAddContact);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxGroup);
            this.Controls.Add(this.textboxGroup);
            this.Controls.Add(this.ButtonUpload);
            this.Controls.Add(this.PictureBoxStudentImage);
            this.Controls.Add(this.TextBoxAdress);
            this.Controls.Add(this.TextBoxPhone);
            this.Controls.Add(this.TextBoxlname);
            this.Controls.Add(this.TextBoxFname);
            this.Controls.Add(this.Picture);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.FirstName);
            this.Name = "AddContactForm";
            this.Text = "AddContactForm";
            this.Load += new System.EventHandler(this.AddContactForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxStudentImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.Label textboxEmail;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAddContact;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxGroup;
        private System.Windows.Forms.Label textboxGroup;
        private System.Windows.Forms.Button ButtonUpload;
        private System.Windows.Forms.PictureBox PictureBoxStudentImage;
        private System.Windows.Forms.TextBox TextBoxAdress;
        private System.Windows.Forms.TextBox TextBoxPhone;
        private System.Windows.Forms.TextBox TextBoxlname;
        private System.Windows.Forms.TextBox TextBoxFname;
        private System.Windows.Forms.Label Picture;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.Label Phone;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.Label FirstName;
    }
}