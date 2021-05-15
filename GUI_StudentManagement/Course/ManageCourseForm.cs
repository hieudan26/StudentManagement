
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
using Login_form;

namespace GUI_StudentManagement.Course
{
    public partial class ManageCourseForm : Form
    {
        BUS_Course BUScourse = new BUS_Course();
        int pos;
        public ManageCourseForm()
        {
            InitializeComponent();
        }

        private void ManageCourseForm_Load(object sender, EventArgs e)
        {
            this.reloadListData();
            BUS_Group BUSGroup = new BUS_Group();
            this.comboBoxGroup.DataSource = BUSGroup.getGroups(DTO_Global.GlobalUserId);
            this.comboBoxGroup.DisplayMember = "name";
            this.comboBoxGroup.ValueMember = "Id";
            
        }
        private void reloadListData()
        {
            listBox1.DataSource = BUScourse.getCOURSE();
            listBox1.ValueMember = "Id";
            listBox1.DisplayMember = "label";
            listBox1.SelectedItem = null;
            labelTotal.Text = "Total Course: " + BUScourse.getCOURSE().Rows.Count.ToString();
            this.comboBoxGroup.SelectedItem = null;
        }
        private void showData(int index)
        {
            try
            {
                DataRow dr = BUScourse.getCOURSE().Rows[index];
                listBox1.SelectedIndex = index;
                txtID.Text = dr.ItemArray[0].ToString();
                txtLabel.Text = dr.ItemArray[1].ToString();
                UpdownPeriod.Value = int.Parse(dr.ItemArray[2].ToString());
                txtDescription.Text = dr.ItemArray[3].ToString();
                txtSemester.Text = dr.ItemArray[4].ToString();
                this.comboBoxGroup.SelectedValue = int.Parse(dr.ItemArray[5].ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)listBox1.SelectedItem;
            pos = listBox1.SelectedIndex;
            showData(pos);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddCourseForm form = new AddCourseForm();
            form.Show();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                int courseID = Convert.ToInt32(txtID.Text);
                if (MessageBox.Show("Are you sure aboud remove this Course", "Delete Course", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (BUScourse.deleteSCOURSE(courseID))
                    {
                        MessageBox.Show("Course deleted", "Course delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtID.Text = "";
                        txtDescription.Text = "";
                        txtLabel.Text = "";
                        txtSemester.Text = "";
                        this.reloadListData();
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (this.txtID.Text == "" || this.txtLabel.Text == "" || this.txtSemester.Text=="")
            {
                MessageBox.Show("Field Emty", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string label = txtLabel.Text;
                int period = int.Parse(UpdownPeriod.Value.ToString());
                string descrip = txtDescription.Text;
                int semester = int.Parse(this.txtSemester.Text);
                if (label == "")
                {
                    MessageBox.Show("Invalid Label!!", "Invalid Label", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (period > 10)
                {
                    try
                    {
                        int id = Convert.ToInt32(txtID.Text);
                        int groupid = (int)comboBoxGroup.SelectedValue;
                        DTO_Course course = new DTO_Course(id,label, period, descrip, semester, groupid);
                        if (BUScourse.updateCOURSE(course) == true && course.verif() == true)
                        {
                            MessageBox.Show("course informationg Updated", "edit course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Edit Error", "Edit course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Edit course", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Emty Fields", "Edit course", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            pos = 0;
            showData(pos);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            
            if (pos > 0)
            {
                pos = pos - 1;
                showData(pos);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (pos < BUScourse.getCOURSE().Rows.Count - 1)
            {
                pos = pos + 1;
                showData(pos);
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            pos = BUScourse.getCOURSE().Rows.Count -1;
            this.reloadListData();
            showData(pos);
        }



        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                DataRowView drv = (DataRowView)listBox1.SelectedItem;
                DataRow dr = BUScourse.getCOURSE().Rows[listBox1.SelectedIndex];
                int x = int.Parse(dr.ItemArray[0].ToString());
                
                StdCourseForm form = new StdCourseForm(x);
                form.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
    }
}
