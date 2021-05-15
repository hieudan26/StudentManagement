using DTO_StudentManagement;
using BUS_StudentManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GUI_StudentManagement.Student
{
    public partial class UpdateStudentForm : Form
    {
        BUS_Student BUSstudent = new BUS_Student();
        public UpdateStudentForm()
        {
            InitializeComponent();
        }

        private void btnUpLoadPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                pictureStudent.Image = new Bitmap(opnfd.FileName);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(this.txtID.Text);
                string fname = this.txtFirstName.Text;
                string lname = txtLastName.Text;
                DateTime bdt = (DateTime)this.dateBirthDay.Value;
                string phone = this.txtPhone.Text;
                string adr = this.txtAddress.Text;
                string gender = "Male";
                if (this.radioFemale.Checked == true)
                    gender = "Female";
                MemoryStream pic = new MemoryStream();
                this.pictureStudent.Image.Save(pic, pictureStudent.Image.RawFormat);
                DTO_Student student = new DTO_Student(id, lname, fname, bdt, phone, adr, gender, pic);
                if (student.verif())
                {
                    if (BUSstudent.updateStudent(student) == true)
                    {
                        MessageBox.Show("Student Updated", "Update Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Update Error", "Update Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Please enter a valid ID", "Student Edit", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try { 
                    int StudentID = Convert.ToInt32(this.txtID.Text);
                    if (MessageBox.Show("Are you sure aboud remove this Student", "Delete STudent", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (BUSstudent.deleteStudent(StudentID) == true)
                        {
                            MessageBox.Show("Student deleted", "Student delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.txtID.Text = "";
                            txtFirstName.Text = "";
                            txtLastName.Text = "";
                            txtPhone.Text = "";
                            txtLastName.Text = "";
                            dateBirthDay.Value = DateTime.Now;
                            pictureStudent.Image = null;
                            radioMale.Checked = true;
                        }
                        else
                        {
                            MessageBox.Show("Student can't deleted", "Student delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                 }
            catch
            {
                MessageBox.Show("Please enter a valid ID", "Student delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private void Showdialog(DataTable dtb)
        {
            ListSearchForm f = new ListSearchForm();
            f.gridviewStudent.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            f.gridviewStudent.RowTemplate.Height = 80;
            f.gridviewStudent.DataSource = dtb;
            picCol = (DataGridViewImageColumn)f.gridviewStudent.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            f.gridviewStudent.AllowUserToAddRows = false;
            f.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable dtb = BUSstudent.SearchFull(this.txtSearch.Text);
            Showdialog(dtb);
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnFindId_Click(object sender, EventArgs e)
        {
            try {
                int id = int.Parse(txtID.Text);
                DataTable table = BUSstudent.getStudentsId(id);
                if (table.Rows.Count > 0)
                {
                    txtFirstName.Text = table.Rows[0]["fname"].ToString();
                    txtLastName.Text = table.Rows[0]["lname"].ToString();
                    dateBirthDay.Value = (DateTime)table.Rows[0]["bdate"];
                    if (table.Rows[0]["gender"].ToString() == "Female    ")
                        radioFemale.Checked = true;
                    else
                        radioMale.Checked = true;
                    txtPhone.Text = table.Rows[0]["phone"].ToString();
                    txtAddress.Text = table.Rows[0]["address"].ToString();

                    byte[] pic;
                    pic = (byte[])table.Rows[0]["picture"];
                    MemoryStream picture = new MemoryStream(pic);
                    pictureStudent.Image = Image.FromStream(picture);
                }
                else
                {
                    MessageBox.Show("not found ", "Find Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Find Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {

            if (this.txtID.Text != "")
            {
                DataTable X = BUSstudent.getStudentsId(int.Parse(this.txtID.Text));
                if (X != null && X.Rows.Count != 0)
                {
                    AddCOurseSTudent form = new AddCOurseSTudent();
                    form.txtStudentId.Text = this.txtID.Text;
                    this.Hide();
                    form.ShowDialog();
                    this.Show();
                }
                else
                    MessageBox.Show("Id is not exited");

            }
            else
                MessageBox.Show("Id is empty");
        }
    }
}
