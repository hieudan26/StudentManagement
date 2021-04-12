
namespace GUI_StudentManagement.Student
{
    partial class MenuStudent
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
            this.MenuMain = new System.Windows.Forms.MenuStrip();
            this.StudentMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staticListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editRemoveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageStudentFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOURSEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sCOREToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addScoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aVGScoreByCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageScoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printResultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuMain
            // 
            this.MenuMain.BackColor = System.Drawing.Color.LightSeaGreen;
            this.MenuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StudentMenu,
            this.cOURSEToolStripMenuItem,
            this.sCOREToolStripMenuItem});
            this.MenuMain.Location = new System.Drawing.Point(0, 0);
            this.MenuMain.Name = "MenuMain";
            this.MenuMain.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.MenuMain.Size = new System.Drawing.Size(800, 24);
            this.MenuMain.TabIndex = 1;
            this.MenuMain.Text = "menuStrip1";
            // 
            // StudentMenu
            // 
            this.StudentMenu.BackColor = System.Drawing.SystemColors.Control;
            this.StudentMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewStudentToolStripMenuItem,
            this.studentListToolStripMenuItem,
            this.staticListToolStripMenuItem,
            this.editRemoveToolStripMenuItem,
            this.manageStudentFormToolStripMenuItem,
            this.printToolStripMenuItem});
            this.StudentMenu.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.StudentMenu.Name = "StudentMenu";
            this.StudentMenu.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.StudentMenu.Size = new System.Drawing.Size(65, 24);
            this.StudentMenu.Text = "STUDENT";
            this.StudentMenu.Click += new System.EventHandler(this.StudentMenu_Click);
            // 
            // addNewStudentToolStripMenuItem
            // 
            this.addNewStudentToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addNewStudentToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.addNewStudentToolStripMenuItem.Name = "addNewStudentToolStripMenuItem";
            this.addNewStudentToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0);
            this.addNewStudentToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.addNewStudentToolStripMenuItem.Size = new System.Drawing.Size(206, 20);
            this.addNewStudentToolStripMenuItem.Text = "Add new student";
            this.addNewStudentToolStripMenuItem.Click += new System.EventHandler(this.addNewStudentToolStripMenuItem_Click);
            // 
            // studentListToolStripMenuItem
            // 
            this.studentListToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.studentListToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.studentListToolStripMenuItem.Name = "studentListToolStripMenuItem";
            this.studentListToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.studentListToolStripMenuItem.Text = "Student List";
            this.studentListToolStripMenuItem.Click += new System.EventHandler(this.studentListToolStripMenuItem_Click);
            // 
            // staticListToolStripMenuItem
            // 
            this.staticListToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.staticListToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.staticListToolStripMenuItem.Name = "staticListToolStripMenuItem";
            this.staticListToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.staticListToolStripMenuItem.Text = "Static List";
            this.staticListToolStripMenuItem.Click += new System.EventHandler(this.staticListToolStripMenuItem_Click);
            // 
            // editRemoveToolStripMenuItem
            // 
            this.editRemoveToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.editRemoveToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.editRemoveToolStripMenuItem.Name = "editRemoveToolStripMenuItem";
            this.editRemoveToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.editRemoveToolStripMenuItem.Text = "Edit/ Remove";
            this.editRemoveToolStripMenuItem.Click += new System.EventHandler(this.editRemoveToolStripMenuItem_Click);
            // 
            // manageStudentFormToolStripMenuItem
            // 
            this.manageStudentFormToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.manageStudentFormToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.manageStudentFormToolStripMenuItem.Name = "manageStudentFormToolStripMenuItem";
            this.manageStudentFormToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.manageStudentFormToolStripMenuItem.Text = "Manage Student Form";
            this.manageStudentFormToolStripMenuItem.Click += new System.EventHandler(this.manageStudentFormToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.printToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // cOURSEToolStripMenuItem
            // 
            this.cOURSEToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.cOURSEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCourseToolStripMenuItem,
            this.removeCourseToolStripMenuItem,
            this.editCourseToolStripMenuItem,
            this.manageCourseToolStripMenuItem,
            this.printToolStripMenuItem1});
            this.cOURSEToolStripMenuItem.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.cOURSEToolStripMenuItem.Name = "cOURSEToolStripMenuItem";
            this.cOURSEToolStripMenuItem.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.cOURSEToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.cOURSEToolStripMenuItem.Text = "COURSE";
            // 
            // addCourseToolStripMenuItem
            // 
            this.addCourseToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addCourseToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.addCourseToolStripMenuItem.Name = "addCourseToolStripMenuItem";
            this.addCourseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addCourseToolStripMenuItem.Text = "Add Course";
            this.addCourseToolStripMenuItem.Click += new System.EventHandler(this.addCourseToolStripMenuItem_Click);
            // 
            // removeCourseToolStripMenuItem
            // 
            this.removeCourseToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.removeCourseToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.removeCourseToolStripMenuItem.Name = "removeCourseToolStripMenuItem";
            this.removeCourseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.removeCourseToolStripMenuItem.Text = "Remove Course";
            this.removeCourseToolStripMenuItem.Click += new System.EventHandler(this.removeCourseToolStripMenuItem_Click);
            // 
            // editCourseToolStripMenuItem
            // 
            this.editCourseToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.editCourseToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.editCourseToolStripMenuItem.Name = "editCourseToolStripMenuItem";
            this.editCourseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editCourseToolStripMenuItem.Text = "Edit Course";
            this.editCourseToolStripMenuItem.Click += new System.EventHandler(this.editCourseToolStripMenuItem_Click);
            // 
            // manageCourseToolStripMenuItem
            // 
            this.manageCourseToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.manageCourseToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.manageCourseToolStripMenuItem.Name = "manageCourseToolStripMenuItem";
            this.manageCourseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.manageCourseToolStripMenuItem.Text = "Manage Course";
            this.manageCourseToolStripMenuItem.Click += new System.EventHandler(this.manageCourseToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem1
            // 
            this.printToolStripMenuItem1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.printToolStripMenuItem1.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.printToolStripMenuItem1.Name = "printToolStripMenuItem1";
            this.printToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.printToolStripMenuItem1.Text = "Print";
            // 
            // sCOREToolStripMenuItem
            // 
            this.sCOREToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.sCOREToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addScoreToolStripMenuItem,
            this.aVGScoreByCourseToolStripMenuItem,
            this.manageScoreToolStripMenuItem,
            this.removeToolStripMenuItem,
            this.printResultToolStripMenuItem});
            this.sCOREToolStripMenuItem.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.sCOREToolStripMenuItem.Name = "sCOREToolStripMenuItem";
            this.sCOREToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0);
            this.sCOREToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.sCOREToolStripMenuItem.Text = "SCORE";
            // 
            // addScoreToolStripMenuItem
            // 
            this.addScoreToolStripMenuItem.Name = "addScoreToolStripMenuItem";
            this.addScoreToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.addScoreToolStripMenuItem.Text = "Add Score";
            this.addScoreToolStripMenuItem.Click += new System.EventHandler(this.addScoreToolStripMenuItem_Click);
            // 
            // aVGScoreByCourseToolStripMenuItem
            // 
            this.aVGScoreByCourseToolStripMenuItem.Name = "aVGScoreByCourseToolStripMenuItem";
            this.aVGScoreByCourseToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.aVGScoreByCourseToolStripMenuItem.Text = "AVG score by Course";
            this.aVGScoreByCourseToolStripMenuItem.Click += new System.EventHandler(this.aVGScoreByCourseToolStripMenuItem_Click);
            // 
            // manageScoreToolStripMenuItem
            // 
            this.manageScoreToolStripMenuItem.Name = "manageScoreToolStripMenuItem";
            this.manageScoreToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.manageScoreToolStripMenuItem.Text = "ManageScore";
            this.manageScoreToolStripMenuItem.Click += new System.EventHandler(this.manageScoreToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // printResultToolStripMenuItem
            // 
            this.printResultToolStripMenuItem.Name = "printResultToolStripMenuItem";
            this.printResultToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.printResultToolStripMenuItem.Text = "Print Result";
            this.printResultToolStripMenuItem.Click += new System.EventHandler(this.printResultToolStripMenuItem_Click);
            // 
            // MenuStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MenuMain);
            this.Name = "MenuStudent";
            this.Text = "MainMenu";
            this.MenuMain.ResumeLayout(false);
            this.MenuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuMain;
        private System.Windows.Forms.ToolStripMenuItem StudentMenu;
        private System.Windows.Forms.ToolStripMenuItem addNewStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staticListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editRemoveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageStudentFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cOURSEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeCourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editCourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageCourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sCOREToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addScoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aVGScoreByCourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageScoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printResultToolStripMenuItem;
    }
}