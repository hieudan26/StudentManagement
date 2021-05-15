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
    public partial class StaticScoreForm : Form
    {
        BUS_Score BUSScore = new BUS_Score();
        public StaticScoreForm()
        {
            InitializeComponent();
        }
       
        private void StaticScoreForm_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Course");
            this.dGV.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            this.dGV.RowTemplate.Height = 80;
            this.dGV.DataSource = BUSScore.getAVGCourse();
            this.dGV.AllowUserToAddRows = false;

            //Biểu đồ
            veBieuDo();
        }
        private void veBieuDo()
        {
            DataTable table = this.BUSScore.getAVGCourse();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                string label = table.Rows[i]["label"].ToString();
                this.chart1.Series["Members"].Points.AddXY(label, table.Rows[i]["avgScore"]);
            }
        }
    }
}
