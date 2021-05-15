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
    public partial class StaticStudent : Form
    {
        BUS_Student BUSstudent = new BUS_Student();
        Color panTotalColor;
        Color panMaleColor;
        Color panFemaleColor;
        public StaticStudent()
        {
            InitializeComponent();
        }
        private void LabelTotal_MouseEnter(object sender, EventArgs e)
        {
            LabelTotal.ForeColor = panTotalColor;
            PanelTotal.BackColor = Color.Black;
        }

        private void LabelTotal_MouseLeave(object sender, EventArgs e)
        {
            LabelTotal.ForeColor = Color.White;
            PanelTotal.BackColor = panTotalColor;
        }

        private void LabelMale_MouseEnter(object sender, EventArgs e)
        {
            LabelMale.ForeColor = panMaleColor;
            PanelMale.BackColor = Color.Black;
        }

        private void LabelMale_MouseLeave(object sender, EventArgs e)
        {
            LabelMale.ForeColor = Color.Black;
            PanelMale.BackColor = panMaleColor;
        }

        private void LabelFemale_MouseEnter(object sender, EventArgs e)
        {
            LabelFemale.ForeColor = panFemaleColor;
            PanelFemale.BackColor = Color.Black;
        }

        private void LabelFemale_MouseLeave(object sender, EventArgs e)
        {
            LabelFemale.ForeColor = Color.White;
            PanelFemale.BackColor = panFemaleColor;
        }

        private void StaticForm_Load(object sender, EventArgs e)
        {
            panTotalColor = PanelTotal.BackColor;
            panMaleColor = PanelMale.BackColor;
            panFemaleColor = PanelFemale.BackColor;

            double total = Double.Parse(this.BUSstudent.totalStudent().ToString());
            double totalMale = Double.Parse(this.BUSstudent.totalMaleStudent().ToString());
            double totalFemale = Double.Parse(this.BUSstudent.totalFemaleStudent().ToString());

            double maleStudentsPercentage = (totalMale * (100 / total));
            double femaleStudentsPercentage = (totalFemale * (100 / total));
            LabelTotal.Text = ("Total Students: " + total.ToString());
            LabelMale.Text = ("Male: " + (maleStudentsPercentage.ToString("0.00") + "%"));
            LabelFemale.Text = ("Female: " + (femaleStudentsPercentage.ToString("0.00") + "%"));
            fillChart();

        }
        private void fillChart()
        {

            chart1.Series["Gender"].Points.AddXY("Male", this.BUSstudent.totalMaleStudent());
            chart1.Series["Gender"].Points.AddXY("Female", this.BUSstudent.totalFemaleStudent());

        }
    }
}
