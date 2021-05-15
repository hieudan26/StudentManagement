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
using System.Data.SqlClient;

namespace GUI_StudentManagement.Student
{
    public partial class StudentManagementForm : Form
    {
        BUS_Student BUSstudent = new BUS_Student();
        public StudentManagementForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (this.txtId.Text != "")
            {
                int id = Convert.ToInt32(this.txtId.Text);
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
            else
            {
                MessageBox.Show("ID Error", "Update Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.Reset();
        }
        private void Reset()
        {
            this.txtId.Text = "";
            this.txtFirstName.Text = "";
            this.txtLastName.Text = "";
            this.dateBirthDay.Value = DateTime.Now;
            this.radioFemale.Checked = false;
            this.radioMale.Checked = false;
            this.txtPhone.Text = "";
            this.txtAddress.Text = "";
            this.pictureStudent.Image = null;
            SqlCommand cmd = new SqlCommand("SELECT * FROM std");
            this.gridviewStudent.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            this.gridviewStudent.RowTemplate.Height = 80;
            this.gridviewStudent.DataSource = BUSstudent.getStudents(cmd);
            picCol = (DataGridViewImageColumn)this.gridviewStudent.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            this.gridviewStudent.AllowUserToAddRows = false;
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(this.txtId.Text !="")
            {
                int id = Convert.ToInt32(this.txtId.Text);
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
            else
            {
                MessageBox.Show("ID Error", "Update Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                int StudentID = Convert.ToInt32(this.txtId.Text);
                if (MessageBox.Show("Are you sure aboud remove this Student", "Delete STudent", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (BUSstudent.deleteStudent(StudentID) == true)
                    {
                        MessageBox.Show("Student deleted", "Student delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.txtId.Text = "";
                        this.txtFirstName.Text = "";
                        this.txtLastName.Text = "";
                        this.txtPhone.Text = "";
                        this.txtLastName.Text = "";
                        this.dateBirthDay.Value = DateTime.Now;
                        this.pictureStudent.Image = null;
                        this.radioMale.Checked = true;
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

        private void gridviewStudent_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                this.txtId.Text = this.gridviewStudent.CurrentRow.Cells[0].Value.ToString();
                this.txtFirstName.Text = this.gridviewStudent.CurrentRow.Cells[1].Value.ToString();
                this.txtLastName.Text = this.gridviewStudent.CurrentRow.Cells[2].Value.ToString();
                this.dateBirthDay.Value = (DateTime)this.gridviewStudent.CurrentRow.Cells[3].Value;
                if (this.gridviewStudent.CurrentRow.Cells[4].Value.ToString() == "Female    ")
                    this.radioFemale.Checked = true;
                else
                    this.radioMale.Checked = true;
                this.txtPhone.Text = this.gridviewStudent.CurrentRow.Cells[5].Value.ToString();
                this.txtAddress.Text = this.gridviewStudent.CurrentRow.Cells[6].Value.ToString();
                byte[] pic;
                pic = (byte[])this.gridviewStudent.CurrentRow.Cells[7].Value;
                MemoryStream picture = new MemoryStream(pic);

                this.pictureStudent.Image = Image.FromStream(picture);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnFindId_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtId.Text);
                DataTable table = BUSstudent.getStudentsId(id);
                if (table.Rows.Count > 0)
                {
                    this.txtFirstName.Text = table.Rows[0]["fname"].ToString();
                    this.txtLastName.Text = table.Rows[0]["lname"].ToString();
                    this.dateBirthDay.Value = (DateTime)table.Rows[0]["bdate"];
                    if (table.Rows[0]["gender"].ToString() == "Female    ")
                        this.radioFemale.Checked = true;
                    else
                        this.radioMale.Checked = true;
                    this.txtPhone.Text = table.Rows[0]["phone"].ToString();
                    this.txtAddress.Text = table.Rows[0]["address"].ToString();

                    byte[] pic;
                    pic = (byte[])table.Rows[0]["picture"];
                    MemoryStream picture = new MemoryStream(pic);
                    this.pictureStudent.Image = Image.FromStream(picture);
                }
                else
                {
                    MessageBox.Show("not found ", "Find Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Find Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void StudentManagementForm_Load(object sender, EventArgs e)
        {
            this.Load1();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable dtb = BUSstudent.SearchFull(this.txtSearch.Text);
            Load2(dtb);
        }
       
        private void Load2(DataTable dtb)
        {
            this.gridviewStudent.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            this.gridviewStudent.RowTemplate.Height = 80;
            this.gridviewStudent.DataSource = dtb;
            picCol = (DataGridViewImageColumn)this.gridviewStudent.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            this.gridviewStudent.AllowUserToAddRows = false;
        }
        private void Load1()
        {
            DataTable dtb = BUSstudent.getAllStudent();
            this.gridviewStudent.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            this.gridviewStudent.RowTemplate.Height = 80;
            this.gridviewStudent.DataSource = dtb;
            picCol = (DataGridViewImageColumn)this.gridviewStudent.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            this.gridviewStudent.AllowUserToAddRows = false;
        }

        private void btnUpLoadpic_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                pictureStudent.Image = new Bitmap(opnfd.FileName);
            }
        }
    }
}
