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
    public partial class RemoveScoreForm : Form
    {
        BUS_Score BUSScore = new BUS_Score();
        public RemoveScoreForm()
        {
            InitializeComponent();
        }

        private void RemoveScoreForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BUSScore.getSCORE();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                int idStudent = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                int idCourse = int.Parse(dataGridView1.CurrentRow.Cells[1].Value.ToString());

                if (BUSScore.deleteScore(idStudent,idCourse))
                {
                    MessageBox.Show("Student score deleted");
                }
                else
                {
                    MessageBox.Show("Student score is not deleted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
    }
}
