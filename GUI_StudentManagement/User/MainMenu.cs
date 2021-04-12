﻿using GUI_StudentManagement.Score;
using Login_form;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_StudentManagement.Student
{
    public partial class MenuStudent : Form
    {
        public MenuStudent()
        {
            InitializeComponent();
        }

        private void addNewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudentForm tempForm = new AddStudentForm();
            tempForm.ShowDialog();
        }

        private void studentListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewStudentForm tempForm = new ListViewStudentForm();
            tempForm.ShowDialog();
        }

        private void staticListToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editRemoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateStudentForm tempForm = new UpdateStudentForm();
            tempForm.ShowDialog();
        }

        private void manageStudentFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentManagementForm tempForm = new StudentManagementForm();
            tempForm.ShowDialog();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintStudentForm tempForm = new PrintStudentForm();
            tempForm.ShowDialog();
        }

        private void StudentMenu_Click(object sender, EventArgs e)
        {

        }

        private void addCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCourseForm tempForm = new AddCourseForm();
            tempForm.Show();
        }

        private void removeCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveCourseForm tempForm = new RemoveCourseForm();
            tempForm.Show();
        }

        private void editCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditCourseForm tempForm = new EditCourseForm();
            tempForm.Show();
        }

        private void manageCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CourseManagamentForm tempForm = new CourseManagamentForm();
            tempForm.Show();
        }

        private void addScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddScoreForm tempForm = new AddScoreForm();
            tempForm.Show();
        }

        private void aVGScoreByCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AVGCourseForm tempForm = new AVGCourseForm();
            tempForm.Show();
        }

        private void manageScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageScore tempForm = new ManageScore();
            tempForm.Show();
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveScoreForm tempForm = new RemoveScoreForm();
            tempForm.Show();
        }

        private void printResultToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
