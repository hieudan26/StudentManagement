
namespace GUI_StudentManagement.Student
{
    partial class AddStudentForm
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
            System.Windows.Forms.Label StudentIdLabel;
            this.btnAdd = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.btnUploadPic = new System.Windows.Forms.Button();
            this.PictureLabel = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.RichTextBox();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.radioFemale = new System.Windows.Forms.RadioButton();
            this.radioMale = new System.Windows.Forms.RadioButton();
            this.dateBirthDay = new System.Windows.Forms.DateTimePicker();
            this.BirthDayLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.groupAdd = new System.Windows.Forms.GroupBox();
            this.pictureStudent = new System.Windows.Forms.PictureBox();
            this.GenderLabel = new System.Windows.Forms.Label();
            StudentIdLabel = new System.Windows.Forms.Label();
            this.groupAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentIdLabel
            // 
            StudentIdLabel.AutoSize = true;
            StudentIdLabel.Cursor = System.Windows.Forms.Cursors.SizeNS;
            StudentIdLabel.Location = new System.Drawing.Point(53, 61);
            StudentIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            StudentIdLabel.Name = "StudentIdLabel";
            StudentIdLabel.Size = new System.Drawing.Size(74, 15);
            StudentIdLabel.TabIndex = 24;
            StudentIdLabel.Text = "Student ID";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Gray;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdd.Location = new System.Drawing.Point(445, 400);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(149, 86);
            this.btnAdd.TabIndex = 42;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.Gray;
            this.CancelButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.CancelButton.Location = new System.Drawing.Point(887, 439);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(119, 52);
            this.CancelButton.TabIndex = 41;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // btnUploadPic
            // 
            this.btnUploadPic.BackColor = System.Drawing.Color.Gray;
            this.btnUploadPic.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUploadPic.Location = new System.Drawing.Point(727, 313);
            this.btnUploadPic.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUploadPic.Name = "btnUploadPic";
            this.btnUploadPic.Size = new System.Drawing.Size(207, 56);
            this.btnUploadPic.TabIndex = 40;
            this.btnUploadPic.Text = "Uppload Image";
            this.btnUploadPic.UseVisualStyleBackColor = false;
            this.btnUploadPic.Click += new System.EventHandler(this.btnUploadPic_Click);
            // 
            // PictureLabel
            // 
            this.PictureLabel.AutoSize = true;
            this.PictureLabel.Location = new System.Drawing.Point(799, 82);
            this.PictureLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PictureLabel.Name = "PictureLabel";
            this.PictureLabel.Size = new System.Drawing.Size(52, 15);
            this.PictureLabel.TabIndex = 38;
            this.PictureLabel.Text = "Picture";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(101, 309);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(351, 85);
            this.txtAddress.TabIndex = 37;
            this.txtAddress.Text = "";
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(53, 291);
            this.AddressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(58, 15);
            this.AddressLabel.TabIndex = 36;
            this.AddressLabel.Text = "Address";
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Location = new System.Drawing.Point(53, 211);
            this.PhoneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(48, 15);
            this.PhoneLabel.TabIndex = 35;
            this.PhoneLabel.Text = "Phone";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(101, 230);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(205, 21);
            this.txtPhone.TabIndex = 34;
            // 
            // radioFemale
            // 
            this.radioFemale.AutoSize = true;
            this.radioFemale.Location = new System.Drawing.Point(445, 230);
            this.radioFemale.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioFemale.Name = "radioFemale";
            this.radioFemale.Size = new System.Drawing.Size(73, 19);
            this.radioFemale.TabIndex = 33;
            this.radioFemale.TabStop = true;
            this.radioFemale.Text = "Female";
            this.radioFemale.UseVisualStyleBackColor = true;
            // 
            // radioMale
            // 
            this.radioMale.AutoSize = true;
            this.radioMale.Location = new System.Drawing.Point(367, 230);
            this.radioMale.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioMale.Name = "radioMale";
            this.radioMale.Size = new System.Drawing.Size(57, 19);
            this.radioMale.TabIndex = 31;
            this.radioMale.TabStop = true;
            this.radioMale.Text = "Male";
            this.radioMale.UseVisualStyleBackColor = true;
            // 
            // dateBirthDay
            // 
            this.dateBirthDay.Location = new System.Drawing.Point(359, 82);
            this.dateBirthDay.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateBirthDay.Name = "dateBirthDay";
            this.dateBirthDay.Size = new System.Drawing.Size(232, 21);
            this.dateBirthDay.TabIndex = 30;
            // 
            // BirthDayLabel
            // 
            this.BirthDayLabel.AutoSize = true;
            this.BirthDayLabel.Location = new System.Drawing.Point(325, 61);
            this.BirthDayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BirthDayLabel.Name = "BirthDayLabel";
            this.BirthDayLabel.Size = new System.Drawing.Size(65, 15);
            this.BirthDayLabel.TabIndex = 29;
            this.BirthDayLabel.Text = "Birth Day";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(53, 141);
            this.LastNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(76, 15);
            this.LastNameLabel.TabIndex = 28;
            this.LastNameLabel.Text = "Last Name";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(101, 159);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(205, 21);
            this.txtLastName.TabIndex = 27;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(316, 141);
            this.FirstNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(77, 15);
            this.FirstNameLabel.TabIndex = 26;
            this.FirstNameLabel.Text = "First Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(359, 159);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(232, 21);
            this.txtFirstName.TabIndex = 25;
            // 
            // txtStudentId
            // 
            this.txtStudentId.Location = new System.Drawing.Point(101, 82);
            this.txtStudentId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.Size = new System.Drawing.Size(205, 21);
            this.txtStudentId.TabIndex = 23;
            this.txtStudentId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStudentId_KeyPress);
            // 
            // groupAdd
            // 
            this.groupAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupAdd.BackColor = System.Drawing.Color.MintCream;
            this.groupAdd.Controls.Add(StudentIdLabel);
            this.groupAdd.Controls.Add(this.txtStudentId);
            this.groupAdd.Controls.Add(this.btnAdd);
            this.groupAdd.Controls.Add(this.txtLastName);
            this.groupAdd.Controls.Add(this.CancelButton);
            this.groupAdd.Controls.Add(this.LastNameLabel);
            this.groupAdd.Controls.Add(this.btnUploadPic);
            this.groupAdd.Controls.Add(this.FirstNameLabel);
            this.groupAdd.Controls.Add(this.pictureStudent);
            this.groupAdd.Controls.Add(this.dateBirthDay);
            this.groupAdd.Controls.Add(this.PictureLabel);
            this.groupAdd.Controls.Add(this.BirthDayLabel);
            this.groupAdd.Controls.Add(this.txtAddress);
            this.groupAdd.Controls.Add(this.GenderLabel);
            this.groupAdd.Controls.Add(this.AddressLabel);
            this.groupAdd.Controls.Add(this.radioFemale);
            this.groupAdd.Controls.Add(this.PhoneLabel);
            this.groupAdd.Controls.Add(this.txtFirstName);
            this.groupAdd.Controls.Add(this.txtPhone);
            this.groupAdd.Controls.Add(this.radioMale);
            this.groupAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupAdd.Location = new System.Drawing.Point(13, 12);
            this.groupAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupAdd.Name = "groupAdd";
            this.groupAdd.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupAdd.Size = new System.Drawing.Size(1014, 497);
            this.groupAdd.TabIndex = 44;
            this.groupAdd.TabStop = false;
            this.groupAdd.Text = "Add Student";
            // 
            // pictureStudent
            // 
            this.pictureStudent.Image = global::GUI_StudentManagement.Properties.Resources.nonePic;
            this.pictureStudent.Location = new System.Drawing.Point(650, 100);
            this.pictureStudent.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureStudent.Name = "pictureStudent";
            this.pictureStudent.Size = new System.Drawing.Size(338, 206);
            this.pictureStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureStudent.TabIndex = 39;
            this.pictureStudent.TabStop = false;
            // 
            // GenderLabel
            // 
            this.GenderLabel.AutoSize = true;
            this.GenderLabel.Location = new System.Drawing.Point(316, 211);
            this.GenderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(54, 15);
            this.GenderLabel.TabIndex = 32;
            this.GenderLabel.Text = "Gender";
            // 
            // AddStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1040, 522);
            this.Controls.Add(this.groupAdd);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "AddStudentForm";
            this.Text = "AddStudentForm";
            this.groupAdd.ResumeLayout(false);
            this.groupAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureStudent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button btnUploadPic;
        private System.Windows.Forms.PictureBox pictureStudent;
        private System.Windows.Forms.Label PictureLabel;
        private System.Windows.Forms.RichTextBox txtAddress;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.RadioButton radioFemale;
        private System.Windows.Forms.RadioButton radioMale;
        private System.Windows.Forms.DateTimePicker dateBirthDay;
        private System.Windows.Forms.Label BirthDayLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.GroupBox groupAdd;
        private System.Windows.Forms.Label GenderLabel;
    }
}