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
    public partial class AVGCourseForm : Form
    {
        BUS_Score BUSScore = new BUS_Score();
        public AVGCourseForm()
        {
            InitializeComponent();
        }

        private void AVGCourseForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BUSScore.getAVGCourse();
        }
    }
}
