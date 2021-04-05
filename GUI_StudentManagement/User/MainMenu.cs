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
    }
}
