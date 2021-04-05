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
using System.IO;
using System.Drawing.Printing;

namespace GUI_StudentManagement.Student
{
    public partial class PrintStudentForm : Form
    {
        BUS_Student BUSstudent = new BUS_Student();

        public PrintStudentForm()
        {
            InitializeComponent();
        }

        private void CheckBtn_Click(object sender, EventArgs e)
        {
            SqlCommand cmd;
            if (this.YesBtn.Checked == false)
            {
                cmd = new SqlCommand("SELECT * FROM std");
            }
            else
            {
                cmd = new SqlCommand("SELECT * FROM std WHERE bdate BETWEEN @bf_Date  AND @at_Date");
                cmd.Parameters.Add("@bf_Date", SqlDbType.Date).Value = dateBeforeDate.Value;
                cmd.Parameters.Add("@at_Date", SqlDbType.Date).Value = dateAfterDay.Value;
            }
            if (this.MaleBtn.Checked == true)
            {
                if (this.YesBtn.Checked == false)
                {
                    cmd = new SqlCommand("SELECT * FROM std WHERE gender = @gender");
                    cmd.Parameters.Add("@gender", SqlDbType.NVarChar).Value = "Male";
                }
                else
                {
                    cmd = new SqlCommand("SELECT * FROM std WHERE gender = @gender AND bdate BETWEEN @bf_Date  AND @at_Date");
                    cmd.Parameters.Add("@gender", SqlDbType.NVarChar).Value = "Male";
                    cmd.Parameters.Add("@bf_Date", SqlDbType.Date).Value = dateBeforeDate.Value;
                    cmd.Parameters.Add("@at_Date", SqlDbType.Date).Value = dateAfterDay.Value;
                }

            }
            else if (this.FemaleBtn.Checked == true)
            {
                if (this.YesBtn.Checked == false)
                {
                    cmd = new SqlCommand("SELECT * FROM std WHERE gender = @gender");
                    cmd.Parameters.Add("@gender", SqlDbType.NVarChar).Value = "Female";
                }
                else
                {
                    cmd = new SqlCommand("SELECT * FROM std WHERE gender = @gender AND bdate BETWEEN @bf_Date  AND @at_Date");
                    cmd.Parameters.Add("@gender", SqlDbType.NVarChar).Value = "Female";
                    cmd.Parameters.Add("@bf_Date", SqlDbType.Date).Value = dateBeforeDate.Value;
                    cmd.Parameters.Add("@at_Date", SqlDbType.Date).Value = dateAfterDay.Value;
                }
            }
            this.gridviewStudent.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            this.gridviewStudent.RowTemplate.Height = 80;
            this.gridviewStudent.DataSource = BUSstudent.getStudents(cmd);
            picCol = (DataGridViewImageColumn)this.gridviewStudent.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            this.gridviewStudent.AllowUserToAddRows = false;
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog printPreviewDialog1 = new PrintPreviewDialog();
            PrintDialog pDlg = new PrintDialog();
            PrintDocument pDoc = new PrintDocument();
            pDoc.DocumentName = "Print Document";
            pDlg.Document = pDoc;
            pDlg.AllowSelection = true;
            pDlg.AllowSomePages = true;
            pDoc.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            if (pDlg.ShowDialog() == DialogResult.OK)
            {
                printPreviewDialog1.Document = pDoc;
                printPreviewDialog1.ShowDialog();
                pDoc.Print();
            }
            else
            {
                MessageBox.Show("Đã hủy in");
            }
        }


        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {

            string str = "";
            int row = this.gridviewStudent.Rows.Count;
            int cell = this.gridviewStudent.Rows[1].Cells.Count;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < cell; j++)
                {
                    if (this.gridviewStudent.Rows[i].Cells[j].Value == null)
                    {
                        this.gridviewStudent.Rows[i].Cells[j].Value = "null";
                    }
                    str += this.gridviewStudent.Rows[i].Cells[j].Value.ToString().Trim() + " , ";
                }
                str += "\n";



            }

            e.Graphics.DrawString(str, new System.Drawing.Font("Arial", 30), Brushes.Black, new System.Drawing.Point(10, 10));
        }
    }
}
