
namespace GUI_StudentManagement.Student
{
    partial class StudentManagementForm
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
            this.btnReset = new System.Windows.Forms.Button();
            this.gridviewStudent = new System.Windows.Forms.DataGridView();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.PictureLabel = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.RichTextBox();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.radioFemale = new System.Windows.Forms.RadioButton();
            this.GenderLabel = new System.Windows.Forms.Label();
            this.radioMale = new System.Windows.Forms.RadioButton();
            this.dateBirthDay = new System.Windows.Forms.DateTimePicker();
            this.BirthDayLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.groupStudent = new System.Windows.Forms.GroupBox();
            this.btnUpLoadpic = new System.Windows.Forms.Button();
            this.pictureStudent = new System.Windows.Forms.PictureBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnFindId = new System.Windows.Forms.Button();
            StudentIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewStudent)).BeginInit();
            this.groupStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentIdLabel
            // 
            StudentIdLabel.AutoSize = true;
            StudentIdLabel.Cursor = System.Windows.Forms.Cursors.SizeNS;
            StudentIdLabel.Location = new System.Drawing.Point(14, 29);
            StudentIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            StudentIdLabel.Name = "StudentIdLabel";
            StudentIdLabel.Size = new System.Drawing.Size(74, 15);
            StudentIdLabel.TabIndex = 53;
            StudentIdLabel.Text = "Student ID";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(524, 523);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(120, 44);
            this.btnReset.TabIndex = 78;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // gridviewStudent
            // 
            this.gridviewStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewStudent.Location = new System.Drawing.Point(382, 101);
            this.gridviewStudent.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gridviewStudent.Name = "gridviewStudent";
            this.gridviewStudent.Size = new System.Drawing.Size(842, 400);
            this.gridviewStudent.TabIndex = 74;
            this.gridviewStudent.DoubleClick += new System.EventHandler(this.gridviewStudent_DoubleClick);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Red;
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(769, 523);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(120, 45);
            this.btnRemove.TabIndex = 73;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(652, 524);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(109, 44);
            this.btnEdit.TabIndex = 72;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(409, 523);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(107, 45);
            this.btnAdd.TabIndex = 70;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.addButton_Click);
            // 
            // PictureLabel
            // 
            this.PictureLabel.AutoSize = true;
            this.PictureLabel.Location = new System.Drawing.Point(14, 350);
            this.PictureLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PictureLabel.Name = "PictureLabel";
            this.PictureLabel.Size = new System.Drawing.Size(52, 15);
            this.PictureLabel.TabIndex = 67;
            this.PictureLabel.Text = "Picture";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(52, 280);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(276, 65);
            this.txtAddress.TabIndex = 66;
            this.txtAddress.Text = "";
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(14, 262);
            this.AddressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(58, 15);
            this.AddressLabel.TabIndex = 65;
            this.AddressLabel.Text = "Address";
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Location = new System.Drawing.Point(18, 204);
            this.PhoneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(48, 15);
            this.PhoneLabel.TabIndex = 64;
            this.PhoneLabel.Text = "Phone";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(52, 222);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(205, 21);
            this.txtPhone.TabIndex = 63;
            // 
            // radioFemale
            // 
            this.radioFemale.AutoSize = true;
            this.radioFemale.Location = new System.Drawing.Point(149, 186);
            this.radioFemale.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioFemale.Name = "radioFemale";
            this.radioFemale.Size = new System.Drawing.Size(73, 19);
            this.radioFemale.TabIndex = 62;
            this.radioFemale.TabStop = true;
            this.radioFemale.Text = "Female";
            this.radioFemale.UseVisualStyleBackColor = true;
            // 
            // GenderLabel
            // 
            this.GenderLabel.AutoSize = true;
            this.GenderLabel.Location = new System.Drawing.Point(21, 168);
            this.GenderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(54, 15);
            this.GenderLabel.TabIndex = 61;
            this.GenderLabel.Text = "Gender";
            // 
            // radioMale
            // 
            this.radioMale.AutoSize = true;
            this.radioMale.Location = new System.Drawing.Point(69, 186);
            this.radioMale.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioMale.Name = "radioMale";
            this.radioMale.Size = new System.Drawing.Size(57, 19);
            this.radioMale.TabIndex = 60;
            this.radioMale.TabStop = true;
            this.radioMale.Text = "Male";
            this.radioMale.UseVisualStyleBackColor = true;
            // 
            // dateBirthDay
            // 
            this.dateBirthDay.Location = new System.Drawing.Point(53, 136);
            this.dateBirthDay.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateBirthDay.Name = "dateBirthDay";
            this.dateBirthDay.Size = new System.Drawing.Size(275, 21);
            this.dateBirthDay.TabIndex = 59;
            // 
            // BirthDayLabel
            // 
            this.BirthDayLabel.AutoSize = true;
            this.BirthDayLabel.Location = new System.Drawing.Point(21, 118);
            this.BirthDayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BirthDayLabel.Name = "BirthDayLabel";
            this.BirthDayLabel.Size = new System.Drawing.Size(65, 15);
            this.BirthDayLabel.TabIndex = 58;
            this.BirthDayLabel.Text = "Birth Day";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(21, 71);
            this.LastNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(76, 15);
            this.LastNameLabel.TabIndex = 57;
            this.LastNameLabel.Text = "Last Name";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(222, 89);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(106, 21);
            this.txtLastName.TabIndex = 56;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(174, 71);
            this.FirstNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(77, 15);
            this.FirstNameLabel.TabIndex = 55;
            this.FirstNameLabel.Text = "First Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(53, 89);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(120, 21);
            this.txtFirstName.TabIndex = 54;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(53, 47);
            this.txtId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(103, 21);
            this.txtId.TabIndex = 52;
            // 
            // groupStudent
            // 
            this.groupStudent.BackColor = System.Drawing.Color.White;
            this.groupStudent.Controls.Add(this.btnFindId);
            this.groupStudent.Controls.Add(this.btnUpLoadpic);
            this.groupStudent.Controls.Add(this.pictureStudent);
            this.groupStudent.Controls.Add(this.PictureLabel);
            this.groupStudent.Controls.Add(this.txtAddress);
            this.groupStudent.Controls.Add(this.AddressLabel);
            this.groupStudent.Controls.Add(this.PhoneLabel);
            this.groupStudent.Controls.Add(this.txtPhone);
            this.groupStudent.Controls.Add(this.radioFemale);
            this.groupStudent.Controls.Add(this.GenderLabel);
            this.groupStudent.Controls.Add(this.radioMale);
            this.groupStudent.Controls.Add(this.dateBirthDay);
            this.groupStudent.Controls.Add(this.BirthDayLabel);
            this.groupStudent.Controls.Add(this.LastNameLabel);
            this.groupStudent.Controls.Add(this.txtLastName);
            this.groupStudent.Controls.Add(this.FirstNameLabel);
            this.groupStudent.Controls.Add(this.txtFirstName);
            this.groupStudent.Controls.Add(StudentIdLabel);
            this.groupStudent.Controls.Add(this.txtId);
            this.groupStudent.Location = new System.Drawing.Point(12, 12);
            this.groupStudent.Name = "groupStudent";
            this.groupStudent.Size = new System.Drawing.Size(360, 555);
            this.groupStudent.TabIndex = 79;
            this.groupStudent.TabStop = false;
            this.groupStudent.Text = "Student";
            // 
            // btnUpLoadpic
            // 
            this.btnUpLoadpic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnUpLoadpic.BackgroundImage = global::GUI_StudentManagement.Properties.Resources.uploadIcon;
            this.btnUpLoadpic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpLoadpic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnUpLoadpic.Location = new System.Drawing.Point(270, 381);
            this.btnUpLoadpic.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUpLoadpic.Name = "btnUpLoadpic";
            this.btnUpLoadpic.Size = new System.Drawing.Size(58, 64);
            this.btnUpLoadpic.TabIndex = 69;
            this.btnUpLoadpic.UseVisualStyleBackColor = false;
            // 
            // pictureStudent
            // 
            this.pictureStudent.Image = global::GUI_StudentManagement.Properties.Resources.nonePic;
            this.pictureStudent.Location = new System.Drawing.Point(55, 368);
            this.pictureStudent.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureStudent.Name = "pictureStudent";
            this.pictureStudent.Size = new System.Drawing.Size(207, 140);
            this.pictureStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureStudent.TabIndex = 68;
            this.pictureStudent.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSearch.BackgroundImage = global::GUI_StudentManagement.Properties.Resources.SearchIcon;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSearch.Location = new System.Drawing.Point(846, 26);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(56, 45);
            this.btnSearch.TabIndex = 72;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(521, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 71;
            this.label1.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(599, 37);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(222, 21);
            this.txtSearch.TabIndex = 70;
            // 
            // btnFindId
            // 
            this.btnFindId.BackColor = System.Drawing.Color.Gray;
            this.btnFindId.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFindId.Location = new System.Drawing.Point(177, 43);
            this.btnFindId.Margin = new System.Windows.Forms.Padding(4);
            this.btnFindId.Name = "btnFindId";
            this.btnFindId.Size = new System.Drawing.Size(129, 28);
            this.btnFindId.TabIndex = 80;
            this.btnFindId.Text = "Get information";
            this.btnFindId.UseVisualStyleBackColor = false;
            this.btnFindId.Click += new System.EventHandler(this.btnFindId_Click);
            // 
            // StudentManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1237, 579);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupStudent);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.gridviewStudent);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "StudentManagementForm";
            this.Text = "StudentManagementForm";
            this.Load += new System.EventHandler(this.StudentManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridviewStudent)).EndInit();
            this.groupStudent.ResumeLayout(false);
            this.groupStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReset;
        public System.Windows.Forms.DataGridView gridviewStudent;
        public System.Windows.Forms.Button btnRemove;
        public System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpLoadpic;
        private System.Windows.Forms.PictureBox pictureStudent;
        private System.Windows.Forms.Label PictureLabel;
        private System.Windows.Forms.RichTextBox txtAddress;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.RadioButton radioFemale;
        private System.Windows.Forms.Label GenderLabel;
        private System.Windows.Forms.RadioButton radioMale;
        private System.Windows.Forms.DateTimePicker dateBirthDay;
        private System.Windows.Forms.Label BirthDayLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.GroupBox groupStudent;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        public System.Windows.Forms.Button btnFindId;
    }
}