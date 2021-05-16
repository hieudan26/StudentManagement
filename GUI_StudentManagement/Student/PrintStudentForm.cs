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
using Microsoft.Office.Interop.Word;

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

            this.gridviewStudent.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            this.gridviewStudent.RowTemplate.Height = 80;
            this.gridviewStudent.DataSource = BUSstudent.FilterStudent(this.YesBtn.Checked, this.MaleBtn.Checked,this.FemaleBtn.Checked ,this.dateBeforeDate.Value, this.dateAfterDay.Value);
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

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.DefaultExt = "*.docx";
            savefile.Filter = "DOCX files(*.docx)|*.docx";

            if (savefile.ShowDialog() == DialogResult.OK && savefile.FileName.Length > 0)
            {
                Export_Data_To_Word(gridviewStudent, savefile.FileName);
                MessageBox.Show("File saved!", "Message Dialog", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void CreateDocument(string docFilePath, Image image)
        {
            _Application oWord = new Microsoft.Office.Interop.Word.Application();
            //Nếu tạo một Document
            _Document oDoc = oWord.Documents.Add();
            //Nếu mở một Document
            //Microsoft.Office.Interop.Word._Document oDoc = oWord.Documents.Open(docFilePath, ReadOnly: false, Visible: true);

            //Để xem điều gì đang xảy ra trong khi điền tập tài liệu từ Visible = true
            oWord.Visible = true;

            //Chèn ảnh từ mảng byte vào MS Word, sử dụng Clipboard để dán Image vào tài liệu
            Object oMissing = System.Reflection.Missing.Value;
            Clipboard.SetDataObject(image);
            var oPara = oDoc.Content.Paragraphs.Add(ref oMissing);
            oPara.Range.Paste();
            oPara.Range.InsertParagraphAfter();

            //Nếu tạo document
            oDoc.SaveAs(docFilePath);
            //Nếu mở một document
            //oDoc.Save();
            oDoc.Close();
            oWord.Quit();
        }
        public Image ByteArrayToImage(byte[] byteArrayIn)
        {
            using (MemoryStream ms = new MemoryStream(byteArrayIn))
            {
                Image returnImage = Image.FromStream(ms);
                return returnImage;
            }
        }
        public void Export_Data_To_Word(DataGridView DGV, string filename)
        {
            try
            {
                Microsoft.Office.Interop.Word.Application winword = new Microsoft.Office.Interop.Word.Application();
                winword.ShowAnimation = false;
                winword.Visible = false;
                object missing = System.Reflection.Missing.Value;
                Microsoft.Office.Interop.Word.Document document = winword.Documents.Add(ref missing, ref missing, ref missing, ref missing);
                document.Content.SetRange(0, 0);
                document.Content.Font.Color = Microsoft.Office.Interop.Word.WdColor.wdColorBlack;


                Microsoft.Office.Interop.Word.Paragraph paraHeading = document.Content.Paragraphs.Add(ref missing);
                paraHeading.Range.Text = "Bộ giáo dục và đào tạo Việt Nam";
                paraHeading.Range.Font.Size = 14;
                paraHeading.Range.Font.Name = "Times New Roman";
                paraHeading.Range.Bold = 1;
                paraHeading.Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
                paraHeading.Range.Font.Color = Microsoft.Office.Interop.Word.WdColor.wdColorBlack;
                paraHeading.Range.InsertParagraphAfter();

                paraHeading.Range.Text = "Đại học Sư Phạm Kỹ Thuật";
                paraHeading.Range.Font.Size = 16;
                paraHeading.Range.Font.Name = "Times New Roman";
                paraHeading.Range.Bold = 1;
                paraHeading.Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
                paraHeading.Range.Font.Color = Microsoft.Office.Interop.Word.WdColor.wdColorBlack;
                paraHeading.Range.InsertParagraphAfter();
                paraHeading.Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;

                System.Data.DataTable table = DGV.DataSource as System.Data.DataTable;
                this.ExporterObjects_Paragraph(ref document, table, ("Bảng các học sinh"));



                // Word.WdParagraphAlignment.wdAlignParagraphRight;
                //Save the document
                document.SaveAs2(filename);

                ((Microsoft.Office.Interop.Word._Document)document).Close(ref missing, ref missing, ref missing);
                ((Microsoft.Office.Interop.Word._Application)winword).Quit(ref missing, ref missing, ref missing);


                MessageBox.Show("Document created successfully !");
                System.Diagnostics.Process.Start(filename);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ExporterObjects_Paragraph(ref Document document, System.Data.DataTable datatable, string namePara)
        {
            try
            {
                object missing = System.Reflection.Missing.Value;
                Microsoft.Office.Interop.Word.Paragraph para = document.Content.Paragraphs.Add(ref missing);
                para.Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;
                para.Range.Font.Bold = 1;
                para.Range.Font.Size = 13;
                para.Range.Font.Color = Microsoft.Office.Interop.Word.WdColor.wdColorBlack;
                para.Range.Text = "\n" + namePara;
                para.Range.InsertParagraphAfter();


                para.Range.Font.Bold = 1;
                para.Range.Font.Size = 10;
                para.Range.Font.Color = Microsoft.Office.Interop.Word.WdColor.wdColorBlack;
                para.Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;
                if (datatable.Rows.Count > 0)
                {
                    Microsoft.Office.Interop.Word.Table firstTable = document.Tables.Add(para.Range, 1, datatable.Columns.Count, ref missing, ref missing);
                    firstTable.AllowAutoFit = true;
                    firstTable.Borders.Enable = 1;

                    firstTable.Cell(1, 1).Range.Text = "ID student";
                    firstTable.Cell(1, 2).Range.Text = "First Name";
                    firstTable.Cell(1, 3).Range.Text = "Last Name";
                    firstTable.Cell(1, 4).Range.Text = "Birth Date";
                    firstTable.Cell(1, 5).Range.Text = "Gender";
                    firstTable.Cell(1, 6).Range.Text = "Phone";
                    firstTable.Cell(1, 7).Range.Text = "Address";
                    firstTable.Cell(1, 8).Range.Text = "Picture";
                    Object beforeRow = Type.Missing;

                    para.Range.Font.Bold = 0;
                    para.Range.Font.Size = 10;
                    para.Range.Font.Color = Microsoft.Office.Interop.Word.WdColor.wdColorBlack;
                    para.Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;


                    for (int i = 0; i < datatable.Rows.Count; i++)
                    {
                        firstTable.Rows.Add(ref beforeRow);
                        firstTable.Cell(i + 2, 1).Range.Text = datatable.Rows[i][0].ToString();
                        firstTable.Cell(i + 2, 2).Range.Text = datatable.Rows[i][1].ToString();
                        firstTable.Cell(i + 2, 3).Range.Text = datatable.Rows[i][2].ToString();
                        firstTable.Cell(i + 2, 4).Range.Text = datatable.Rows[i][3].ToString();
                        firstTable.Cell(i + 2, 5).Range.Text = datatable.Rows[i][4].ToString();
                        firstTable.Cell(i + 2, 6).Range.Text = datatable.Rows[i][5].ToString();
                        firstTable.Cell(i + 2, 7).Range.Text = datatable.Rows[i][6].ToString();
                    }
                    byte[] imgbyte;
                    MemoryStream ms;
                    Image finalPic;
                    for (int i = 0; i < datatable.Rows.Count; i++)
                    {
                        imgbyte = (byte[])datatable.Rows[i][7];
                        ms = new MemoryStream(imgbyte);
                        finalPic = (Image)(new Bitmap(Image.FromStream(ms), new Size(50, 50)));
                        Clipboard.SetDataObject(finalPic);
                        firstTable.Cell(i + 2, 8).Range.Paste();
                        firstTable.Cell(i + 2, 8).Range.InsertParagraph();
                    }
                }
                else
                {
                    Microsoft.Office.Interop.Word.Table firstTable = document.Tables.Add(para.Range, 1, datatable.Columns.Count, ref missing, ref missing);
                    firstTable.Borders.Enable = 1;
                    firstTable.Cell(1, 1).Range.Text = "ID student";
                    firstTable.Cell(1, 2).Range.Text = "First Name";
                    firstTable.Cell(1, 3).Range.Text = "Last Name";
                    firstTable.Cell(1, 4).Range.Text = "Birth Date";
                    firstTable.Cell(1, 5).Range.Text = "Gender";
                    firstTable.Cell(1, 6).Range.Text = "Phone";
                    firstTable.Cell(1, 7).Range.Text = "Address";
                    firstTable.Cell(1, 8).Range.Text = "Picture";
                    Object beforeRow = Type.Missing;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Err " + ex.Message);
            }
        }

        private void PrintStudentForm_Load(object sender, EventArgs e)
        {

        }
    }
}
