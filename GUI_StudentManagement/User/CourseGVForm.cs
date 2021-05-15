
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_StudentManagement;
using BUS_StudentManagement;
using GUI_StudentManagement.Course;

namespace GUI_StudentManagement.User
{
    public partial class CourseGVForm : Form
    {
        BUS_Contact BUScontact = new BUS_Contact();
        BUS_Course BUSCourse = new BUS_Course();
        BUS_Score BUSScore = new BUS_Score();
        private int IDContact;
        int check = 0;
        public CourseGVForm(int IDcontact)
        {
            InitializeComponent();
            this.IDContact = IDcontact;
        }

        private void listBoxGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(check == 1)
            {
                int idCourse = int.Parse(this.listBoxGroup.SelectedValue.ToString());
                StdCourseForm form = new StdCourseForm(idCourse);
                form.Show();
            }    
        }
        void reloadListBoxData()
        {
            this.listBoxGroup.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxGroup.DataSource = this.BUScontact.getIDAllCourse(this.IDContact);
            this.listBoxGroup.ValueMember = "id";
            this.listBoxGroup.DisplayMember = "label";
            this.listBoxGroup.SelectedItem = null;
            check = 1;
        }

        private void CourseGVForm_Load(object sender, EventArgs e)
        {
            this.reloadListBoxData();
        }
    }
}
