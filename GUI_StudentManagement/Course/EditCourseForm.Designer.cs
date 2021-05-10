
namespace Login_form
{
    partial class EditCourseForm
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
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelPeriod = new System.Windows.Forms.Label();
            this.txtLabel = new System.Windows.Forms.TextBox();
            this.labelLabel = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.labelID = new System.Windows.Forms.Label();
            this.comboboxID = new System.Windows.Forms.ComboBox();
            this.UpdownPeriod = new System.Windows.Forms.NumericUpDown();
            this.txtSemester = new System.Windows.Forms.TextBox();
            this.labelSemester = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UpdownPeriod)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(149, 176);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(340, 115);
            this.txtDescription.TabIndex = 17;
            this.txtDescription.Text = "";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(63, 156);
            this.labelDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(87, 16);
            this.labelDescription.TabIndex = 16;
            this.labelDescription.Text = "Description";
            // 
            // labelPeriod
            // 
            this.labelPeriod.AutoSize = true;
            this.labelPeriod.Location = new System.Drawing.Point(96, 110);
            this.labelPeriod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPeriod.Name = "labelPeriod";
            this.labelPeriod.Size = new System.Drawing.Size(54, 16);
            this.labelPeriod.TabIndex = 14;
            this.labelPeriod.Text = "Period";
            // 
            // txtLabel
            // 
            this.txtLabel.Location = new System.Drawing.Point(149, 75);
            this.txtLabel.Margin = new System.Windows.Forms.Padding(4);
            this.txtLabel.Name = "txtLabel";
            this.txtLabel.Size = new System.Drawing.Size(340, 22);
            this.txtLabel.TabIndex = 13;
            // 
            // labelLabel
            // 
            this.labelLabel.AutoSize = true;
            this.labelLabel.Location = new System.Drawing.Point(96, 55);
            this.labelLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLabel.Name = "labelLabel";
            this.labelLabel.Size = new System.Drawing.Size(47, 16);
            this.labelLabel.TabIndex = 12;
            this.labelLabel.Text = "Label";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Red;
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(52, 311);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(492, 48);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(74, 9);
            this.labelID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(76, 16);
            this.labelID.TabIndex = 9;
            this.labelID.Text = "ID Course";
            // 
            // comboboxID
            // 
            this.comboboxID.FormattingEnabled = true;
            this.comboboxID.Location = new System.Drawing.Point(149, 29);
            this.comboboxID.Margin = new System.Windows.Forms.Padding(4);
            this.comboboxID.Name = "comboboxID";
            this.comboboxID.Size = new System.Drawing.Size(254, 24);
            this.comboboxID.TabIndex = 18;
            this.comboboxID.SelectedIndexChanged += new System.EventHandler(this.comboboxID_SelectedIndexChanged);
            // 
            // UpdownPeriod
            // 
            this.UpdownPeriod.Location = new System.Drawing.Point(149, 130);
            this.UpdownPeriod.Margin = new System.Windows.Forms.Padding(4);
            this.UpdownPeriod.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.UpdownPeriod.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.UpdownPeriod.Name = "UpdownPeriod";
            this.UpdownPeriod.Size = new System.Drawing.Size(180, 22);
            this.UpdownPeriod.TabIndex = 20;
            this.UpdownPeriod.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // txtSemester
            // 
            this.txtSemester.Location = new System.Drawing.Point(477, 29);
            this.txtSemester.Name = "txtSemester";
            this.txtSemester.Size = new System.Drawing.Size(92, 22);
            this.txtSemester.TabIndex = 22;
            // 
            // labelSemester
            // 
            this.labelSemester.AutoSize = true;
            this.labelSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSemester.Location = new System.Drawing.Point(404, 11);
            this.labelSemester.Name = "labelSemester";
            this.labelSemester.Size = new System.Drawing.Size(74, 16);
            this.labelSemester.TabIndex = 21;
            this.labelSemester.Text = "Semester";
            // 
            // EditCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(592, 374);
            this.Controls.Add(this.txtSemester);
            this.Controls.Add(this.labelSemester);
            this.Controls.Add(this.UpdownPeriod);
            this.Controls.Add(this.comboboxID);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelPeriod);
            this.Controls.Add(this.txtLabel);
            this.Controls.Add(this.labelLabel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.labelID);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EditCourseForm";
            this.Text = "EditCourseForm";
            this.Load += new System.EventHandler(this.EditCourseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UpdownPeriod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelPeriod;
        private System.Windows.Forms.TextBox txtLabel;
        private System.Windows.Forms.Label labelLabel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.ComboBox comboboxID;
        private System.Windows.Forms.NumericUpDown UpdownPeriod;
        private System.Windows.Forms.TextBox txtSemester;
        private System.Windows.Forms.Label labelSemester;
    }
}