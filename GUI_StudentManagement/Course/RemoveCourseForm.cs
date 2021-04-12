using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_StudentManagement;
namespace Login_form
{
    public partial class RemoveCourseForm : Form
    {
        BUS_Course BUScourse = new BUS_Course();
        public RemoveCourseForm()
        {
            InitializeComponent();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                int courseID = Convert.ToInt32(txtRemove.Text);
                if (MessageBox.Show("Are you sure aboud remove this Course", "Delete Course", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (BUScourse.deleteSCOURSE(courseID))
                    {
                        MessageBox.Show("Course deleted", "Course delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtRemove.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Course can't deleted", "Course delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Please enter a valid ID", "Course delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
