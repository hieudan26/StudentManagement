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
        private void loadStaticPanel()
        {
            DataTable table = this.BUSScore.getAVGCourse();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                Label lb = new Label();
                lb.Text = table.Rows[i]["label"].ToString() + " :" + table.Rows[i]["avgScore"].ToString();
                this.panelAVG.Controls.Add(lb);
            }
        }
        private void loadStaticStudent()
        {
            
            DataTable table = this.BUSScore.getAVGCourse();
            int xuatSac = 0, gioi = 0, kha = 0, trungbinh = 0, yeu = 0;
            for (int i = 0; i < table.Rows.Count; i++)
            {
                float temp = float.Parse(table.Rows[i]["avgScore"].ToString());
                if (temp <= 10 && temp >= 9.1)
                {
                    xuatSac++;
                }
                else if (temp <= 9 && temp >= 8.1)
                {
                    gioi++;
                }
                else if (temp <= 8 && temp >= 6.1)
                {
                    kha++;
                }
                else if (temp <= 6 && temp >= 4.1)
                {
                    trungbinh++;
                }
                else
                {
                    yeu++;
                }
            }

            int totalStu = xuatSac + gioi + kha + trungbinh + yeu;
            this.labelXuatsac.Text = "Xuất sắc: " + (xuatSac * 100 / totalStu).ToString() + " %";
            this.labelGioi.Text = "Giỏi: " + (gioi * 100 / totalStu).ToString() + " %";
            this.labelKha.Text = "Khá: " + (kha * 100 / totalStu).ToString() + " %";
            this.labelTrungBinh.Text = "Trung bình: " + (trungbinh * 100 / totalStu).ToString() + " %";
            this.labelYeu.Text = "Yếu: " + (yeu * 100 / totalStu).ToString() + " %";
        }
        private void StaticScoreForm_Load(object sender, EventArgs e)
        {
            this.loadStaticPanel();
            this.loadStaticStudent();
        }
    }
}
