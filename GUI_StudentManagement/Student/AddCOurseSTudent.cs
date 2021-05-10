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

namespace GUI_StudentManagement.Student
{
    public partial class AddCOurseSTudent : Form
    {
        BUS_Course BUScourse = new BUS_Course();
        BUS_Student BUSstudent = new BUS_Student();
        BUS_Score BUSscore = new BUS_Score();
        public AddCOurseSTudent()
        {
            InitializeComponent();
        }

        private void UpdownPeriod_ValueChanged(object sender, EventArgs e)
        {
            int sem = int.Parse(this.comboSem.Value.ToString());
            this.datagridAvailable.DataSource = BUScourse.getCOURSEsemester(sem);
        }

        private void AddCOurseSTudent_Load(object sender, EventArgs e)
        {
            this.datagridSelected.DataSource = this.BUScourse.getCOURSELabelStudent(int.Parse(this.txtStudentId.Text), int.Parse(this.comboSem.Value.ToString()));
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            if (table != null)
            {
                table.Clear();
                table.Columns.Clear();
                table.Columns.Add("label", typeof(string));
            }
            string label = this.datagridAvailable.CurrentRow.Cells[0].Value.ToString();
            DataRow row = table.NewRow();
            row["label"] = label;
            table.Rows.Add(row);
            this.datagridSelected.DataSource = table;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            
            string label = this.datagridSelected.CurrentRow.Cells[0].Value.ToString();
            int id_cou = int.Parse(this.BUScourse.getCOURSELabel(label).Rows[0][0].ToString());
            int id_stu = int.Parse(this.txtStudentId.Text);
            DTO_Score score = new DTO_Score(id_stu, id_cou, 0, "nothing");
            if (this.BUSscore.insertSCORE(score))
            {
                MessageBox.Show("success");
                if (this.BUScourse.getCOURSELabelStudent(id_stu, int.Parse(this.comboSem.Value.ToString())) != null)
                {
                    this.datagridSelected.DataSource = this.BUScourse.getCOURSELabelStudent(id_stu, int.Parse(this.comboSem.Value.ToString()));
                }
            }
            else
            {
                MessageBox.Show("unsuccess");
            }
        }
    }
}
