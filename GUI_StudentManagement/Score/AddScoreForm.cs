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

namespace GUI_StudentManagement.Score
{
    public partial class AddScoreForm : Form
    {

        BUS_Student BUSstudent = new BUS_Student();
        BUS_Course BUSCourse = new BUS_Course();
        BUS_Score BUSScore = new BUS_Score();
        public AddScoreForm()
        {
           
            InitializeComponent();
        }
        private void AddScoreForm_Load(object sender, EventArgs e)
        {
            comboCourse.DataSource = BUSCourse.getCOURSE();
            comboCourse.DisplayMember = "label";
            comboCourse.ValueMember = "Id";
            dataGridView1.DataSource = BUSstudent.getAllIfnoStudent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int idStudent = int.Parse(txtID.Text);
                int idCourse = int.Parse(comboCourse.SelectedValue.ToString());
                float score = float.Parse(txtScore.Text);
                string desciption = txtDescription.Text;
                if(BUSScore.getSCOREAStudent(idStudent,idCourse).Rows.Count ==0)
                {
                    DTO_Score Score = new DTO_Score(idStudent,idCourse,score,desciption);
                    if(BUSScore.insertSCORE(Score))
                    {
                        MessageBox.Show("Student score inserted");
                    }
                    else
                    {
                        MessageBox.Show("Student score is not inserted");
                    }    
                }
                else
                {
                    MessageBox.Show("Student score is exited" + BUSScore.getSCOREAStudent(idStudent, idCourse).Rows.Count);
                }    
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            txtID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
