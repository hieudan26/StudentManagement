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
    public partial class ResultForm : Form
    {
        BUS_Score BUSScore = new BUS_Score();
        BUS_Course BUSCourse = new BUS_Course();
        public ResultForm()
        {
            InitializeComponent();
        }

        private void ResultForm_Load(object sender, EventArgs e)
        {
            DataTable table = this.BUSScore.getSCOREAVGStudent();
            this.LoadST(table);
        }

        private void datagridScore_DoubleClick(object sender, EventArgs e)
        {
            this.txtID.Text = this.datagridScore.CurrentRow.Cells[0].Value.ToString();
            this.txtFirstName.Text = this.datagridScore.CurrentRow.Cells[1].Value.ToString();
            this.txtLastName.Text = this.datagridScore.CurrentRow.Cells[2].Value.ToString();
        }
        private void LoadST(DataTable table)
        {
            table.Columns.Add("Rank", typeof(string));
            for (int i = 0; i < table.Rows.Count; i++)
            {
                DataRow row = table.Rows[i];
                float temp = float.Parse(table.Rows[i]["AVG"].ToString());
                if (temp <= 10 && temp >= 9.1)
                {
                    row["Rank"] = "Xuất Sắc";
                }
                else if (temp <= 9 && temp >= 8.1)
                {
                    row["Rank"] = "Giỏi";
                }
                else if (temp <= 8 && temp >= 6.1)
                {
                    row["Rank"] = "Khá";
                }
                else if (temp <= 6 && temp >= 4.1)
                {
                    row["Rank"] = "Trung Bình";
                }
                else
                {
                    row["Rank"] = "Yếu";
                }
            }
            this.AddCourse(table);
            DataGridViewCellStyle headerStyle = new DataGridViewCellStyle();
            headerStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.datagridScore.ColumnHeadersDefaultCellStyle = headerStyle;
            this.datagridScore.DataSource = table;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable table = BUSScore.SearchFull(this.txtSearch.Text);
            this.LoadST(table);
        }
        private void AddCourse(DataTable table)
        {
            int temp = table.Columns.Count;
            DataTable tableCourse = BUSCourse.gettableCOURSEsemester(1);
            for (int i = 0; i < tableCourse.Rows.Count; i++)
            {
                table.Columns.Add(tableCourse.Rows[i][1].ToString().Trim(), typeof(string)).SetOrdinal(3);
                
                int idCourse = int.Parse(tableCourse.Rows[i][0].ToString());
                for (int j = 0; j < table.Rows.Count; j++)
                {
                    DataTable tablescore = BUSScore.getSCOREAStudent(int.Parse(table.Rows[j][0].ToString()), idCourse);
                    if (tablescore.Rows.Count > 0)
                        table.Rows[j][3] = tablescore.Rows[0][2].ToString();
                    else
                        table.Rows[j][3] = "NULL";
                }
            }

        }
    }
}
