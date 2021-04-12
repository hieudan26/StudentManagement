using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_StudentManagement;
using DTO_StudentManagement;
namespace GUI_StudentManagement.Student
{
    public partial class ListViewStudentForm : Form
    {
        BUS_Student BUSstudent = new BUS_Student();
        public ListViewStudentForm()
        {
            InitializeComponent();
        }

        private void ListViewStudentForm_Load(object sender, EventArgs e)
        {
            
            
            this.gridviewStudent.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            this.gridviewStudent.RowTemplate.Height = 80;
            this.gridviewStudent.DataSource = BUSstudent.getAllStudent();
            picCol = (DataGridViewImageColumn)this.gridviewStudent.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            this.gridviewStudent.AllowUserToAddRows = false;
        }

        private void gridviewStudent_DoubleClick(object sender, EventArgs e)
        {
            UpdateStudentForm f = new UpdateStudentForm();
            f.txtID.Text = this.gridviewStudent.CurrentRow.Cells[0].Value.ToString();
            f.txtFirstName.Text = this.gridviewStudent.CurrentRow.Cells[1].Value.ToString();
            f.txtLastName.Text = this.gridviewStudent.CurrentRow.Cells[2].Value.ToString();
            f.dateBirthDay.Value = (DateTime)this.gridviewStudent.CurrentRow.Cells[3].Value;
            if (this.gridviewStudent.CurrentRow.Cells[4].Value.ToString() == "Female    ")
                f.radioFemale.Checked = true;
            else
                f.radioMale.Checked = true;
            f.txtPhone.Text = this.gridviewStudent.CurrentRow.Cells[5].Value.ToString();
            f.txtAddress.Text = this.gridviewStudent.CurrentRow.Cells[6].Value.ToString();
            byte[] pic;
            pic = (byte[])this.gridviewStudent.CurrentRow.Cells[7].Value;
            MemoryStream picture = new MemoryStream(pic);
            f.pictureStudent.Image = Image.FromStream(picture);
            f.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.gridviewStudent.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            this.gridviewStudent.RowTemplate.Height = 80;
            this.gridviewStudent.DataSource = BUSstudent.getAllStudent();
            picCol = (DataGridViewImageColumn)this.gridviewStudent.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            this.gridviewStudent.AllowUserToAddRows = false;
        }
    }
}
