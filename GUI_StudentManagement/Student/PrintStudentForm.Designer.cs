
namespace GUI_StudentManagement.Student
{
    partial class PrintStudentForm
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
            this.groupFilter = new System.Windows.Forms.GroupBox();
            this.chooseFIlter = new System.Windows.Forms.Label();
            this.dateAfterDay = new System.Windows.Forms.DateTimePicker();
            this.CheckBtn = new System.Windows.Forms.Button();
            this.dateBeforeDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NoBtn = new System.Windows.Forms.RadioButton();
            this.YesBtn = new System.Windows.Forms.RadioButton();
            this.AllBtn = new System.Windows.Forms.RadioButton();
            this.FemaleBtn = new System.Windows.Forms.RadioButton();
            this.MaleBtn = new System.Windows.Forms.RadioButton();
            this.PrintButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.gridviewStudent = new System.Windows.Forms.DataGridView();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.groupGender = new System.Windows.Forms.GroupBox();
            this.groupFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewStudent)).BeginInit();
            this.groupGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupFilter
            // 
            this.groupFilter.BackColor = System.Drawing.Color.White;
            this.groupFilter.Controls.Add(this.chooseFIlter);
            this.groupFilter.Controls.Add(this.dateAfterDay);
            this.groupFilter.Controls.Add(this.CheckBtn);
            this.groupFilter.Controls.Add(this.dateBeforeDate);
            this.groupFilter.Controls.Add(this.label2);
            this.groupFilter.Controls.Add(this.label1);
            this.groupFilter.Controls.Add(this.NoBtn);
            this.groupFilter.Controls.Add(this.YesBtn);
            this.groupFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupFilter.Location = new System.Drawing.Point(284, 31);
            this.groupFilter.Margin = new System.Windows.Forms.Padding(4);
            this.groupFilter.Name = "groupFilter";
            this.groupFilter.Padding = new System.Windows.Forms.Padding(4);
            this.groupFilter.Size = new System.Drawing.Size(628, 118);
            this.groupFilter.TabIndex = 15;
            this.groupFilter.TabStop = false;
            this.groupFilter.Text = "Filter";
            // 
            // chooseFIlter
            // 
            this.chooseFIlter.AutoSize = true;
            this.chooseFIlter.Location = new System.Drawing.Point(7, 30);
            this.chooseFIlter.Name = "chooseFIlter";
            this.chooseFIlter.Size = new System.Drawing.Size(80, 15);
            this.chooseFIlter.TabIndex = 10;
            this.chooseFIlter.Text = "Want filter?";
            // 
            // dateAfterDay
            // 
            this.dateAfterDay.Location = new System.Drawing.Point(204, 80);
            this.dateAfterDay.Margin = new System.Windows.Forms.Padding(4);
            this.dateAfterDay.Name = "dateAfterDay";
            this.dateAfterDay.Size = new System.Drawing.Size(250, 21);
            this.dateAfterDay.TabIndex = 9;
            // 
            // CheckBtn
            // 
            this.CheckBtn.BackColor = System.Drawing.Color.Gray;
            this.CheckBtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.CheckBtn.Location = new System.Drawing.Point(473, 38);
            this.CheckBtn.Margin = new System.Windows.Forms.Padding(4);
            this.CheckBtn.Name = "CheckBtn";
            this.CheckBtn.Size = new System.Drawing.Size(123, 49);
            this.CheckBtn.TabIndex = 14;
            this.CheckBtn.Text = "Check";
            this.CheckBtn.UseVisualStyleBackColor = false;
            this.CheckBtn.Click += new System.EventHandler(this.CheckBtn_Click);
            // 
            // dateBeforeDate
            // 
            this.dateBeforeDate.Location = new System.Drawing.Point(204, 37);
            this.dateBeforeDate.Margin = new System.Windows.Forms.Padding(4);
            this.dateBeforeDate.Name = "dateBeforeDate";
            this.dateBeforeDate.Size = new System.Drawing.Size(250, 21);
            this.dateBeforeDate.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "And";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "BirthDay Between";
            // 
            // NoBtn
            // 
            this.NoBtn.AutoSize = true;
            this.NoBtn.Location = new System.Drawing.Point(79, 53);
            this.NoBtn.Margin = new System.Windows.Forms.Padding(4);
            this.NoBtn.Name = "NoBtn";
            this.NoBtn.Size = new System.Drawing.Size(43, 19);
            this.NoBtn.TabIndex = 1;
            this.NoBtn.TabStop = true;
            this.NoBtn.Text = "No";
            this.NoBtn.UseVisualStyleBackColor = true;
            // 
            // YesBtn
            // 
            this.YesBtn.AutoSize = true;
            this.YesBtn.Location = new System.Drawing.Point(23, 53);
            this.YesBtn.Margin = new System.Windows.Forms.Padding(4);
            this.YesBtn.Name = "YesBtn";
            this.YesBtn.Size = new System.Drawing.Size(48, 19);
            this.YesBtn.TabIndex = 0;
            this.YesBtn.TabStop = true;
            this.YesBtn.Text = "Yes";
            this.YesBtn.UseVisualStyleBackColor = true;
            // 
            // AllBtn
            // 
            this.AllBtn.AutoSize = true;
            this.AllBtn.Location = new System.Drawing.Point(25, 36);
            this.AllBtn.Margin = new System.Windows.Forms.Padding(4);
            this.AllBtn.Name = "AllBtn";
            this.AllBtn.Size = new System.Drawing.Size(41, 19);
            this.AllBtn.TabIndex = 13;
            this.AllBtn.TabStop = true;
            this.AllBtn.Text = "All";
            this.AllBtn.UseVisualStyleBackColor = true;
            // 
            // FemaleBtn
            // 
            this.FemaleBtn.AutoSize = true;
            this.FemaleBtn.Location = new System.Drawing.Point(110, 79);
            this.FemaleBtn.Margin = new System.Windows.Forms.Padding(4);
            this.FemaleBtn.Name = "FemaleBtn";
            this.FemaleBtn.Size = new System.Drawing.Size(73, 19);
            this.FemaleBtn.TabIndex = 12;
            this.FemaleBtn.TabStop = true;
            this.FemaleBtn.Text = "Female";
            this.FemaleBtn.UseVisualStyleBackColor = true;
            // 
            // MaleBtn
            // 
            this.MaleBtn.AutoSize = true;
            this.MaleBtn.Location = new System.Drawing.Point(110, 39);
            this.MaleBtn.Margin = new System.Windows.Forms.Padding(4);
            this.MaleBtn.Name = "MaleBtn";
            this.MaleBtn.Size = new System.Drawing.Size(57, 19);
            this.MaleBtn.TabIndex = 11;
            this.MaleBtn.TabStop = true;
            this.MaleBtn.Text = "Male";
            this.MaleBtn.UseVisualStyleBackColor = true;
            // 
            // PrintButton
            // 
            this.PrintButton.BackColor = System.Drawing.Color.SteelBlue;
            this.PrintButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.PrintButton.Location = new System.Drawing.Point(531, 462);
            this.PrintButton.Margin = new System.Windows.Forms.Padding(4);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(258, 53);
            this.PrintButton.TabIndex = 10;
            this.PrintButton.Text = "Print";
            this.PrintButton.UseVisualStyleBackColor = false;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.SaveButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.SaveButton.Location = new System.Drawing.Point(196, 462);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(4);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(258, 53);
            this.SaveButton.TabIndex = 9;
            this.SaveButton.Text = "Save to text";
            this.SaveButton.UseVisualStyleBackColor = false;
            // 
            // gridviewStudent
            // 
            this.gridviewStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewStudent.Location = new System.Drawing.Point(13, 157);
            this.gridviewStudent.Margin = new System.Windows.Forms.Padding(4);
            this.gridviewStudent.Name = "gridviewStudent";
            this.gridviewStudent.Size = new System.Drawing.Size(948, 297);
            this.gridviewStudent.TabIndex = 8;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // groupGender
            // 
            this.groupGender.BackColor = System.Drawing.Color.White;
            this.groupGender.Controls.Add(this.AllBtn);
            this.groupGender.Controls.Add(this.MaleBtn);
            this.groupGender.Controls.Add(this.FemaleBtn);
            this.groupGender.Location = new System.Drawing.Point(54, 32);
            this.groupGender.Name = "groupGender";
            this.groupGender.Size = new System.Drawing.Size(200, 118);
            this.groupGender.TabIndex = 16;
            this.groupGender.TabStop = false;
            this.groupGender.Text = "Gender";
            // 
            // PrintStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(980, 527);
            this.Controls.Add(this.groupGender);
            this.Controls.Add(this.groupFilter);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.gridviewStudent);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PrintStudentForm";
            this.Text = "PrintStudentForm";
            this.groupFilter.ResumeLayout(false);
            this.groupFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewStudent)).EndInit();
            this.groupGender.ResumeLayout(false);
            this.groupGender.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupFilter;
        private System.Windows.Forms.Label chooseFIlter;
        private System.Windows.Forms.DateTimePicker dateAfterDay;
        private System.Windows.Forms.DateTimePicker dateBeforeDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton NoBtn;
        private System.Windows.Forms.RadioButton YesBtn;
        private System.Windows.Forms.Button CheckBtn;
        private System.Windows.Forms.RadioButton AllBtn;
        private System.Windows.Forms.RadioButton FemaleBtn;
        private System.Windows.Forms.RadioButton MaleBtn;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.DataGridView gridviewStudent;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.GroupBox groupGender;
    }
}