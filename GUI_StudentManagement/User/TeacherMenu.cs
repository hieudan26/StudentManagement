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
    public partial class TeacherMenu : Form
    {
        BUS_Contact BUSContact = new BUS_Contact();
        BUS_User BUSUser = new BUS_User();
        public TeacherMenu()
        {
            InitializeComponent();
        }

        private void fMain_Hs_Load(object sender, EventArgs e)
        {
            this.getImageAndUsername();
           
        }

        private void getImageAndUsername()
        {
            DataTable table = BUSUser.getImageAndUsername();
            if (table.Rows.Count > 0)
            {
                byte[] pic = (byte[])table.Rows[0]["picture"];
                MemoryStream picture = new MemoryStream(pic);
                this.pB.Image = Image.FromStream(picture);
                this.lbWel.Text = "Welcome Back: " + table.Rows[0]["username"].ToString();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EditContactForm form = new EditContactForm();
            form.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.fMain_Hs_Load(sender, e);
        }

        private void btnSelectCnt_Click(object sender, EventArgs e)
        {
            
            try
            {
                SelectContactForm SelectContactF = new SelectContactForm();
                SelectContactF.ShowDialog();
                if (SelectContactF.dataGridViewListContact.RowCount != 0)
                { 
                    int contactId = Convert.ToInt32(SelectContactF.dataGridViewListContact.CurrentRow.Cells[0].Value.ToString());
                    SelectContactForm form = new SelectContactForm();
                    this.txtContact.Text = contactId.ToString();
                }
                //int id = int.Parse(this.txtContact.Text);
                //DataTable table = this.contact.getContactbyID(id);
                //if (table.Rows.Count > 0)
                //{
                //    MessageBox.Show("có tồn tại contact này");
                //}
                //else
                //{
                //    MessageBox.Show("Không tồn tại contact này vui lòng chọn lại");
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(this.txtContact.Text);
                if (this.BUSContact.deleteContact(id))
                {
                    MessageBox.Show("Xóa thành công");
                    this.txtContact.Text = "";
                }
                else
                {
                    MessageBox.Show("Xóa không thành công");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: ", ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddContactForm form = new AddContactForm();
            form.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditContactForm form = new EditContactForm();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ContactForm form = new ContactForm();
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            btnAddcourse form = new btnAddcourse();
            form.Show();
        }

        private void TeacherMenu_Load(object sender, EventArgs e)
        {
            this.fMain_Hs_Load(sender, e);
        }
    }
}
