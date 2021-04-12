
namespace GUI_StudentManagement.Student
{
    partial class ListSearchForm
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
            this.gridviewStudent = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // gridviewStudent
            // 
            this.gridviewStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewStudent.Location = new System.Drawing.Point(0, 0);
            this.gridviewStudent.Name = "gridviewStudent";
            this.gridviewStudent.Size = new System.Drawing.Size(799, 451);
            this.gridviewStudent.TabIndex = 0;
            this.gridviewStudent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridviewStudent_CellContentClick);
            // 
            // ListSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridviewStudent);
            this.Name = "ListSearchForm";
            this.Text = "ListSearchForm";
            ((System.ComponentModel.ISupportInitialize)(this.gridviewStudent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView gridviewStudent;
    }
}