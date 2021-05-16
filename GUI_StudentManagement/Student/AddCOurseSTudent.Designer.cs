
namespace GUI_StudentManagement.Student
{
    partial class AddCOurseSTudent
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.labelAvailabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboSem = new System.Windows.Forms.NumericUpDown();
            this.datagridAvailable = new System.Windows.Forms.DataGridView();
            this.datagridSelected = new System.Windows.Forms.DataGridView();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.comboSem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridAvailable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridSelected)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(359, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Semester";
            // 
            // txtStudentId
            // 
            this.txtStudentId.Location = new System.Drawing.Point(83, 47);
            this.txtStudentId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.ReadOnly = true;
            this.txtStudentId.Size = new System.Drawing.Size(105, 20);
            this.txtStudentId.TabIndex = 24;
            // 
            // labelAvailabel
            // 
            this.labelAvailabel.AutoSize = true;
            this.labelAvailabel.Location = new System.Drawing.Point(47, 112);
            this.labelAvailabel.Name = "labelAvailabel";
            this.labelAvailabel.Size = new System.Drawing.Size(50, 13);
            this.labelAvailabel.TabIndex = 25;
            this.labelAvailabel.Text = "Availabel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(402, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Selected Course";
            // 
            // comboSem
            // 
            this.comboSem.Location = new System.Drawing.Point(417, 48);
            this.comboSem.Margin = new System.Windows.Forms.Padding(4);
            this.comboSem.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.comboSem.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.comboSem.Name = "comboSem";
            this.comboSem.Size = new System.Drawing.Size(91, 20);
            this.comboSem.TabIndex = 27;
            this.comboSem.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.comboSem.ValueChanged += new System.EventHandler(this.UpdownPeriod_ValueChanged);
            // 
            // datagridAvailable
            // 
            this.datagridAvailable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridAvailable.Location = new System.Drawing.Point(21, 137);
            this.datagridAvailable.Name = "datagridAvailable";
            this.datagridAvailable.Size = new System.Drawing.Size(185, 221);
            this.datagridAvailable.TabIndex = 28;
            // 
            // datagridSelected
            // 
            this.datagridSelected.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridSelected.Location = new System.Drawing.Point(325, 137);
            this.datagridSelected.Name = "datagridSelected";
            this.datagridSelected.Size = new System.Drawing.Size(192, 221);
            this.datagridSelected.TabIndex = 29;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(227, 250);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(78, 34);
            this.buttonSave.TabIndex = 30;
            this.buttonSave.Text = "SAVE";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(227, 187);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(78, 34);
            this.buttonAdd.TabIndex = 31;
            this.buttonAdd.Text = "ADD";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // AddCOurseSTudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 381);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.datagridSelected);
            this.Controls.Add(this.datagridAvailable);
            this.Controls.Add(this.comboSem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelAvailabel);
            this.Controls.Add(this.txtStudentId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddCOurseSTudent";
            this.Text = "AddCOurseSTudent";
            this.Load += new System.EventHandler(this.AddCOurseSTudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.comboSem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridAvailable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridSelected)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelAvailabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown comboSem;
        private System.Windows.Forms.DataGridView datagridAvailable;
        private System.Windows.Forms.DataGridView datagridSelected;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonAdd;
        public System.Windows.Forms.TextBox txtStudentId;
    }
}