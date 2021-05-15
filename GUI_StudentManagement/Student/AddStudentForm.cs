using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_StudentManagement;
using BUS_StudentManagement;
using System.IO;

namespace GUI_StudentManagement.Student
{
    public partial class AddStudentForm : Form
    {
        BUS_Student BUSstudent = new BUS_Student();
        public AddStudentForm()
        {
            InitializeComponent();
        }

        private void AddFileBtn_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.txtStudentId.Text != "")
            {
                int id = Convert.ToInt32(this.txtStudentId.Text);
                string fname = txtFirstName.Text;
                string lname = txtLastName.Text;
                DateTime bdt = dateBirthDay.Value;
                string phone = txtPhone.Text;
                string adr = txtAddress.Text;
                string gender = "Male";
                if (radioFemale.Checked == true)
                    gender = "Female";
                MemoryStream pic = new MemoryStream();
                pictureStudent.Image.Save(pic, pictureStudent.Image.RawFormat);
                DTO_Student student = new DTO_Student(id, lname, fname, bdt, phone, adr, gender, pic);
                if (BUSstudent.verifyStudent(student) == true && student.verif() == true)
                {
                    if (BUSstudent.insertStudent(student) == true)
                    {
                        MessageBox.Show("New Student Added", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Add Error", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void btnUploadPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                pictureStudent.Image = new Bitmap(opnfd.FileName);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
