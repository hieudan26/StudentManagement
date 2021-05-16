
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
using GUI_StudentManagement.Course;

namespace GUI_StudentManagement.User
{

    public partial class RemoveCourseFromContactForm : Form
    {
        BUS_Contact BUScontact = new BUS_Contact();
        BUS_Course BUSCourse = new BUS_Course();
        BUS_Score BUSScore = new BUS_Score();
        private int IDContact =-1;
        int check = 0;
        int IDcourse = -1;
        public RemoveCourseFromContactForm()
        {
            InitializeComponent();
        }
        void reloadListBoxData()
        {
            if(IDContact != -1 && this.txtID.Text !="")
            {
                this.listBoxGroup.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.listBoxGroup.DataSource = this.BUScontact.getIDAllCourse(this.IDContact);
                this.listBoxGroup.ValueMember = "id";
                this.listBoxGroup.DisplayMember = "label";
                this.listBoxGroup.SelectedItem = null;
                check = 1;
                IDcourse = -1;
            }
        }

        private void RemoveCourseFromContactForm_Load(object sender, EventArgs e)
        {
            
        }

        private void listBoxGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (check == 1 && this.listBoxGroup.SelectedItem != null)
            {
                IDcourse = int.Parse(this.listBoxGroup.SelectedValue.ToString());
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if(IDcourse == -1 || IDContact ==-1)
            {
                MessageBox.Show("You have to choose Course and contact ID is not empty!!");
            }
            else
            {
                if (BUScontact.deleteCourseOfContact(this.IDContact, IDcourse))
                {
                    MessageBox.Show("Remove success full!!");
                    this.reloadListBoxData();
                }
                else
                {
                    MessageBox.Show("Remove failed!!");
                }    
            }    
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            SelectContactForm SelectContactF = new SelectContactForm();
            SelectContactF.ShowDialog();
            try
            {

                if (SelectContactF.dataGridViewListContact.Rows.Count != 0)
                {
                    this.IDContact = Convert.ToInt32(SelectContactF.dataGridViewListContact.CurrentRow.Cells[0].Value.ToString());
                    DataTable table = BUScontact.getContactById(IDContact);
                    this.txtID.Text = table.Rows[0]["Id"].ToString();
                    this.reloadListBoxData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi", "Edit Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
        }
    }
}
