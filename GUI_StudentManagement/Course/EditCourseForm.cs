
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
    public partial class EditCourseForm : Form
    {
        BUS_Course BUSCourse = new BUS_Course();
        public EditCourseForm()
        { 
            InitializeComponent();
        }

        private void EditCourseForm_Load(object sender, EventArgs e)
        {
            this.fillCombo();
        }
        private void fillCombo()
        {
            DataTable tb = BUSCourse.getCOURSE();
            comboboxID.DisplayMember = "id";
            comboboxID.ValueMember = "id";
            comboboxID.DataSource = tb;
        }

        private void comboboxID_SelectedIndexChanged(object sender, EventArgs e)
        {
           try 
            {
                DataTable tb = BUSCourse.getCOURSEId(int.Parse(this.comboboxID.SelectedValue.ToString()));
                txtLabel.Text = tb.Rows[0][1].ToString();
                UpdownPeriod.Value = int.Parse(tb.Rows[0][2].ToString());
                txtDescription.Text = tb.Rows[0][3].ToString();
                txtSemester.Text = tb.Rows[0][4].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string label = txtLabel.Text;
            int period= int.Parse(UpdownPeriod.Value.ToString());
            string descrip = txtDescription.Text;
            int semester = int.Parse(txtSemester.Text);
            if (label == "")
            {
                MessageBox.Show("Invalid Label!!", "Invalid Label", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (period > 10)
            {
                try
                {
                    DTO_Course course = new DTO_Course(label, period, descrip,semester);
                    int id = Convert.ToInt32(comboboxID.SelectedValue);
                    if (BUSCourse.updateCOURSE(course,id) == true && course.verif() == true )
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
}
