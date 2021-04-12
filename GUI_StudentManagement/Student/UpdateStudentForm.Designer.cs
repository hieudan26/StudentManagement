
namespace GUI_StudentManagement.Student
{
    partial class UpdateStudentForm
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dateBirthDay = new System.Windows.Forms.DateTimePicker();
            this.btnFindId = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnUpLoadPic = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.RichTextBox();
            this.radioFemale = new System.Windows.Forms.RadioButton();
            this.radioMale = new System.Windows.Forms.RadioButton();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.PictureLabel = new System.Windows.Forms.Label();
            this.AdressLabel = new System.Windows.Forms.Label();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.GenderLabel = new System.Windows.Forms.Label();
            this.BirthDayLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            this.groupUdateStudent = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pictureStudent = new System.Windows.Forms.PictureBox();
            this.groupUdateStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(475, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 51;
            this.label1.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(553, 29);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(222, 22);
            this.txtSearch.TabIndex = 50;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dateBirthDay
            // 
            this.dateBirthDay.Location = new System.Drawing.Point(46, 195);
            this.dateBirthDay.Margin = new System.Windows.Forms.Padding(4);
            this.dateBirthDay.Name = "dateBirthDay";
            this.dateBirthDay.Size = new System.Drawing.Size(298, 22);
            this.dateBirthDay.TabIndex = 47;
            // 
            // btnFindId
            // 
            this.btnFindId.BackColor = System.Drawing.Color.Gray;
            this.btnFindId.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFindId.Location = new System.Drawing.Point(214, 73);
            this.btnFindId.Margin = new System.Windows.Forms.Padding(4);
            this.btnFindId.Name = "btnFindId";
            this.btnFindId.Size = new System.Drawing.Size(129, 28);
            this.btnFindId.TabIndex = 46;
            this.btnFindId.Text = "Get information";
            this.btnFindId.UseVisualStyleBackColor = false;
            this.btnFindId.Click += new System.EventHandler(this.btnFindId_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRemove.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRemove.Location = new System.Drawing.Point(574, 452);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(168, 49);
            this.btnRemove.TabIndex = 45;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEdit.Location = new System.Drawing.Point(398, 452);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(168, 49);
            this.btnEdit.TabIndex = 44;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnUpLoadPic
            // 
            this.btnUpLoadPic.BackColor = System.Drawing.Color.Gray;
            this.btnUpLoadPic.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUpLoadPic.Location = new System.Drawing.Point(654, 360);
            this.btnUpLoadPic.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpLoadPic.Name = "btnUpLoadPic";
            this.btnUpLoadPic.Size = new System.Drawing.Size(218, 46);
            this.btnUpLoadPic.TabIndex = 43;
            this.btnUpLoadPic.Text = "Upload Image";
            this.btnUpLoadPic.UseVisualStyleBackColor = false;
            this.btnUpLoadPic.Click += new System.EventHandler(this.btnUpLoadPic_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(46, 356);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(285, 117);
            this.txtAddress.TabIndex = 41;
            this.txtAddress.Text = "";
            // 
            // radioFemale
            // 
            this.radioFemale.AutoSize = true;
            this.radioFemale.Location = new System.Drawing.Point(160, 252);
            this.radioFemale.Margin = new System.Windows.Forms.Padding(4);
            this.radioFemale.Name = "radioFemale";
            this.radioFemale.Size = new System.Drawing.Size(78, 20);
            this.radioFemale.TabIndex = 40;
            this.radioFemale.TabStop = true;
            this.radioFemale.Text = "Female";
            this.radioFemale.UseVisualStyleBackColor = true;
            // 
            // radioMale
            // 
            this.radioMale.AutoSize = true;
            this.radioMale.Location = new System.Drawing.Point(70, 252);
            this.radioMale.Margin = new System.Windows.Forms.Padding(4);
            this.radioMale.Name = "radioMale";
            this.radioMale.Size = new System.Drawing.Size(60, 20);
            this.radioMale.TabIndex = 39;
            this.radioMale.TabStop = true;
            this.radioMale.Text = "Male";
            this.radioMale.UseVisualStyleBackColor = true;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(46, 298);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(298, 22);
            this.txtPhone.TabIndex = 38;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(246, 131);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(148, 22);
            this.txtFirstName.TabIndex = 37;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(46, 131);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(148, 22);
            this.txtLastName.TabIndex = 36;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(46, 76);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(148, 22);
            this.txtID.TabIndex = 35;
            this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_KeyPress);
            // 
            // PictureLabel
            // 
            this.PictureLabel.AutoSize = true;
            this.PictureLabel.Location = new System.Drawing.Point(450, 111);
            this.PictureLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PictureLabel.Name = "PictureLabel";
            this.PictureLabel.Size = new System.Drawing.Size(64, 16);
            this.PictureLabel.TabIndex = 34;
            this.PictureLabel.Text = "Picture: ";
            // 
            // AdressLabel
            // 
            this.AdressLabel.AutoSize = true;
            this.AdressLabel.Location = new System.Drawing.Point(14, 336);
            this.AdressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AdressLabel.Name = "AdressLabel";
            this.AdressLabel.Size = new System.Drawing.Size(66, 16);
            this.AdressLabel.TabIndex = 33;
            this.AdressLabel.Text = "Address";
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Location = new System.Drawing.Point(14, 278);
            this.PhoneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(60, 16);
            this.PhoneLabel.TabIndex = 32;
            this.PhoneLabel.Text = "Phone: ";
            // 
            // GenderLabel
            // 
            this.GenderLabel.AutoSize = true;
            this.GenderLabel.Location = new System.Drawing.Point(15, 232);
            this.GenderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(59, 16);
            this.GenderLabel.TabIndex = 31;
            this.GenderLabel.Text = "Gender";
            // 
            // BirthDayLabel
            // 
            this.BirthDayLabel.AutoSize = true;
            this.BirthDayLabel.Location = new System.Drawing.Point(15, 175);
            this.BirthDayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BirthDayLabel.Name = "BirthDayLabel";
            this.BirthDayLabel.Size = new System.Drawing.Size(84, 16);
            this.BirthDayLabel.TabIndex = 30;
            this.BirthDayLabel.Text = "BirthDate : ";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(29, 111);
            this.LastNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(90, 16);
            this.LastNameLabel.TabIndex = 29;
            this.LastNameLabel.Text = "Last Name: ";
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(211, 111);
            this.FirstNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(87, 16);
            this.FirstNameLabel.TabIndex = 28;
            this.FirstNameLabel.Text = "First Name:";
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(29, 56);
            this.IDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(27, 16);
            this.IDLabel.TabIndex = 27;
            this.IDLabel.Text = "ID:";
            // 
            // groupUdateStudent
            // 
            this.groupUdateStudent.BackColor = System.Drawing.Color.White;
            this.groupUdateStudent.Controls.Add(this.btnFindId);
            this.groupUdateStudent.Controls.Add(this.btnSearch);
            this.groupUdateStudent.Controls.Add(this.IDLabel);
            this.groupUdateStudent.Controls.Add(this.label1);
            this.groupUdateStudent.Controls.Add(this.FirstNameLabel);
            this.groupUdateStudent.Controls.Add(this.txtSearch);
            this.groupUdateStudent.Controls.Add(this.LastNameLabel);
            this.groupUdateStudent.Controls.Add(this.BirthDayLabel);
            this.groupUdateStudent.Controls.Add(this.GenderLabel);
            this.groupUdateStudent.Controls.Add(this.dateBirthDay);
            this.groupUdateStudent.Controls.Add(this.PhoneLabel);
            this.groupUdateStudent.Controls.Add(this.AdressLabel);
            this.groupUdateStudent.Controls.Add(this.btnRemove);
            this.groupUdateStudent.Controls.Add(this.PictureLabel);
            this.groupUdateStudent.Controls.Add(this.btnEdit);
            this.groupUdateStudent.Controls.Add(this.txtID);
            this.groupUdateStudent.Controls.Add(this.btnUpLoadPic);
            this.groupUdateStudent.Controls.Add(this.txtLastName);
            this.groupUdateStudent.Controls.Add(this.pictureStudent);
            this.groupUdateStudent.Controls.Add(this.txtFirstName);
            this.groupUdateStudent.Controls.Add(this.txtAddress);
            this.groupUdateStudent.Controls.Add(this.txtPhone);
            this.groupUdateStudent.Controls.Add(this.radioFemale);
            this.groupUdateStudent.Controls.Add(this.radioMale);
            this.groupUdateStudent.Location = new System.Drawing.Point(13, 13);
            this.groupUdateStudent.Margin = new System.Windows.Forms.Padding(4);
            this.groupUdateStudent.Name = "groupUdateStudent";
            this.groupUdateStudent.Padding = new System.Windows.Forms.Padding(4);
            this.groupUdateStudent.Size = new System.Drawing.Size(1017, 509);
            this.groupUdateStudent.TabIndex = 53;
            this.groupUdateStudent.TabStop = false;
            this.groupUdateStudent.Text = "Update Student";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSearch.BackgroundImage = global::GUI_StudentManagement.Properties.Resources.SearchIcon;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSearch.Location = new System.Drawing.Point(800, 18);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(56, 45);
            this.btnSearch.TabIndex = 52;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pictureStudent
            // 
            this.pictureStudent.Image = global::GUI_StudentManagement.Properties.Resources.nonePic;
            this.pictureStudent.Location = new System.Drawing.Point(541, 100);
            this.pictureStudent.Margin = new System.Windows.Forms.Padding(4);
            this.pictureStudent.Name = "pictureStudent";
            this.pictureStudent.Size = new System.Drawing.Size(423, 252);
            this.pictureStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureStudent.TabIndex = 42;
            this.pictureStudent.TabStop = false;
            // 
            // UpdateStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1043, 535);
            this.Controls.Add(this.groupUdateStudent);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UpdateStudentForm";
            this.Text = "UpdateStudentForm";
            this.groupUdateStudent.ResumeLayout(false);
            this.groupUdateStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureStudent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DateTimePicker dateBirthDay;
        public System.Windows.Forms.Button btnFindId;
        public System.Windows.Forms.Button btnRemove;
        public System.Windows.Forms.Button btnEdit;
        public System.Windows.Forms.Button btnUpLoadPic;
        public System.Windows.Forms.PictureBox pictureStudent;
        public System.Windows.Forms.RichTextBox txtAddress;
        public System.Windows.Forms.RadioButton radioFemale;
        public System.Windows.Forms.RadioButton radioMale;
        public System.Windows.Forms.TextBox txtPhone;
        public System.Windows.Forms.TextBox txtFirstName;
        public System.Windows.Forms.TextBox txtLastName;
        public System.Windows.Forms.TextBox txtID;
        public System.Windows.Forms.Label PictureLabel;
        public System.Windows.Forms.Label AdressLabel;
        public System.Windows.Forms.Label PhoneLabel;
        public System.Windows.Forms.Label GenderLabel;
        public System.Windows.Forms.Label BirthDayLabel;
        public System.Windows.Forms.Label LastNameLabel;
        public System.Windows.Forms.Label FirstNameLabel;
        public System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.GroupBox groupUdateStudent;
        public System.Windows.Forms.TextBox txtSearch;
    }
}