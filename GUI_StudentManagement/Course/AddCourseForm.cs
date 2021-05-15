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
namespace Login_form
{
    public partial class AddCourseForm : Form
    {
        BUS_Course BUScourse = new BUS_Course();
        public AddCourseForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.txtID.Text == "" || this.txtLabel.Text == "" || this.txtPeriod.Text == "" || comboBoxGroup.SelectedItem == null)
            {
                MessageBox.Show("Add error", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                
                int Id = int.Parse(this.txtID.Text);
                string Label = this.txtLabel.Text;
                int period = int.Parse(this.txtPeriod.Text);
                string desciption = this.txtDescription.Text;
                int semester = int.Parse(this.txtSemester.Text);
                int groupid = (int)comboBoxGroup.SelectedValue;
                DTO_Course Course = new DTO_Course(Id,Label,period, desciption,semester,groupid);
                DataTable tb = BUScourse.getCOURSEId(Id);
                DataTable tb2 = BUScourse.getCOURSELabel(Label, semester);
                if (tb.Rows.Count > 0)
                {
                    MessageBox.Show("Register Error ID existence", "Add COURSE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (tb2.Rows.Count > 0)
                {
                    MessageBox.Show("Register Error Label existence", "Add COURSE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Course.verif())
                {
                    if (BUScourse.insertCOURSE(Course) == true)
                    {
                        MessageBox.Show("Add succesfully", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //Close();
                    }
                    else
                    {
                        MessageBox.Show("Register Error", "Add User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
               
            }
        }

        private void labelPeriod_Click(object sender, EventArgs e)
        {

        }

        private void AddCourseForm_Load(object sender, EventArgs e)
        {
            BUS_Group BUSGroup = new BUS_Group();
            this.comboBoxGroup.DataSource = BUSGroup.getGroups(DTO_Global.GlobalUserId);
            this.comboBoxGroup.DisplayMember = "name";
            this.comboBoxGroup.ValueMember = "Id";
        }
    }
}
