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

namespace GUI_StudentManagement.User
{
    public partial class AddContactForm : Form
    {
        BUS_Contact BUSContact = new BUS_Contact();
        
        public AddContactForm()
        {
            InitializeComponent();
        }

        public bool verif()
        {
            if (this.comboBoxGroup.SelectedValue == null)
                return false;
            else
            {
                if (this.textBoxId.Text.Trim() == ""
                    || this.textBoxMail.Text.Trim() == ""
                    || this.TextBoxFname.Text.Trim() == ""
                    || this.TextBoxlname.Text.Trim() == ""
                    || this.TextBoxPhone.Text.Trim() == ""
                    || this.TextBoxAdress.Text.Trim() == ""
                    || this.PictureBoxStudentImage.Image == null)
                    return false;
                else return true;
            }
        }


        

        private void ButtonUpload_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image (*.jpg; *.png; *.gif)| *.jpg; *.png; *.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                this.PictureBoxStudentImage.Image = Image.FromFile(opf.FileName);
            }
        }

        private void buttonAddContact_Click_1(object sender, EventArgs e)
        {
            if (this.verif())
            {

                int id = Convert.ToInt32(textBoxId.Text);
                string fname = TextBoxFname.Text;
                string lname = TextBoxlname.Text;
                string phone = TextBoxPhone.Text;
                string address = TextBoxAdress.Text;
                string email = textboxEmail.Text;
                int userid = DTO_Global.GlobalUserId;
                int groupid = (int)comboBoxGroup.SelectedValue;


                MemoryStream pic = new MemoryStream();
                PictureBoxStudentImage.Image.Save(pic, PictureBoxStudentImage.Image.RawFormat);

                if (BUSContact.checkId(id))
                {
                    if (BUSContact.insertContact(id, fname, lname, groupid, phone, email, address, pic, userid))
                    {
                        MessageBox.Show("New Contact Added", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("This ID Already Exists, Try Another One", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("One Or More Fields Are Empty", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddContactForm_Load_1(object sender, EventArgs e)
        {
            BUS_Group BUSGroup = new BUS_Group();
            this.comboBoxGroup.DataSource = BUSGroup.getGroups(DTO_Global.GlobalUserId);
            this.comboBoxGroup.DisplayMember = "name";
            this.comboBoxGroup.ValueMember = "Id";
        }

        private void comboBoxGroup_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
