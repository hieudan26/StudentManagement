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


namespace GUI_StudentManagement.User
{
    public partial class AddCourseForContactForm : Form
    {
        public AddCourseForContactForm()
        {
            InitializeComponent();
        }
        BUS_Contact BUSContact = new BUS_Contact();
        BUS_Course BUSCourse = new BUS_Course();
        private void btnSelect_Click(object sender, EventArgs e)
        {

            SelectContactForm SelectContactF = new SelectContactForm();
            SelectContactF.ShowDialog();
            try
            {

                if (SelectContactF.dataGridViewListContact.Rows.Count != 0)
                {
                    int contactId = Convert.ToInt32(SelectContactF.dataGridViewListContact.CurrentRow.Cells[0].Value.ToString());
                    DataTable table = BUSContact.getContactById(contactId);
                    this.txtID.Text = table.Rows[0]["Id"].ToString();
                }  
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi", "Edit Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool verif()
        {
            if (txtID.Text == "")
                return false;
            if (comboCourse.SelectedItem == null || comboCourse.SelectedItem.ToString() == "")
                return false;
            try
            {
                if (BUSContact.checkIdinsertCourt(int.Parse(txtID.Text), int.Parse(this.comboCourse.SelectedValue.ToString())) == false)
                return false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            return true;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.verif())
            {
                if (BUSContact.insertCTCourse(int.Parse(txtID.Text),int.Parse(this.comboCourse.SelectedValue.ToString())))
                {
                    MessageBox.Show(" Added Success", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    comboCourse.DataSource = BUSCourse.getCOURSEEmpty(int.Parse(this.comboSem.Value.ToString()));
                    comboCourse.DisplayMember = "label";
                    comboCourse.ValueMember = "Id";
                    comboCourse.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("Error", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                comboCourse.SelectedIndex = -1;
                MessageBox.Show("One Or More Fields Are Empty Or Contact already have Course", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddCourseForContactForm_Load(object sender, EventArgs e)
        {
            comboCourse.DataSource = BUSCourse.getCOURSEEmpty(1);
            comboCourse.DisplayMember = "label";
            comboCourse.ValueMember = "Id";
            comboCourse.SelectedIndex = -1;
        }

        private void comboCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
    
        }

        private void comboSem_ValueChanged(object sender, EventArgs e)
        {
            comboCourse.DataSource = BUSCourse.getCOURSEEmpty(int.Parse(this.comboSem.Value.ToString()));
            comboCourse.DisplayMember = "label";
            comboCourse.ValueMember = "Id";
            comboCourse.SelectedIndex = -1;
        }
    }
}
