
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
using BUS_StudentManagement;
namespace Login_form
{
    
    public partial class CourseManagamentForm : Form
    {
        BUS_Course course = new BUS_Course();
        public CourseManagamentForm()
        {
            InitializeComponent();
        }

        private void CourseManagamentForm_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM COURSE");
            DataTable tb = course.getCOURSE();
            dataGridView1.DataSource = tb;
            
        }
    }
}
