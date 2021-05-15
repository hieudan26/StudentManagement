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
    public partial class EditContactForm : Form
    {
        public EditContactForm()
        {
            InitializeComponent();
        }
        BUS_Contact BUSContact = new BUS_Contact();


        public bool verif()
        {
            if (this.comboBoxGroup.SelectedValue == null)
                return false;
            else
            {
                if (this.textBoxId.Text.Trim() == ""
                    || this.textBoxEmail.Text.Trim() == ""
                    || this.textBoxFname.Text.Trim() == ""
                    || this.textBoxlname.Text.Trim() == ""
                    || this.textBoxPhone.Text.Trim() == ""
                    || this.textBoxAdress.Text.Trim() == ""
                    || this.PictureBoxStudentImage.Image == null)
                    return false;
                else return true;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image (*.jpg; *.png; *.gif)| *.jpg; *.png; *.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                this.PictureBoxStudentImage.Image = Image.FromFile(opf.FileName);
            }
        }

        private void buttonEdit_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (verif())
                {

                    int id = Convert.ToInt32(textBoxId.Text);
                    string fname = this.textBoxFname.Text;
                    string lname = this.textBoxlname.Text;
                    int groupby = int.Parse(comboBoxGroup.SelectedValue.ToString());
                    string phone = this.textBoxPhone.Text;
                    string email = this.textBoxEmail.Text;
                    string adrs = this.textBoxAdress.Text;
                    MemoryStream pic = new MemoryStream();

                    PictureBoxStudentImage.Image.Save(pic, PictureBoxStudentImage.Image.RawFormat);
                    if (BUSContact.UpdateContact(id, fname, lname, groupby, phone, email, adrs, pic))
                    {
                        MessageBox.Show("da cap nhat", "Edit Contact", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("error", "Edit Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("empty fieds", "Edit Contact", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi "+ex.Message, "Edit Contact", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void buttonSelectId_Click_1(object sender, EventArgs e)
        {
            SelectContactForm SelectContactF = new SelectContactForm();
            SelectContactF.ShowDialog();
            try
            {

                if(SelectContactF.dataGridViewListContact.Rows.Count != 0)
                {
                    int contactId = Convert.ToInt32(SelectContactF.dataGridViewListContact.CurrentRow.Cells[0].Value.ToString());
                    DataTable table = BUSContact.getContactById(contactId);

                    this.textBoxId.Text = table.Rows[0]["Id"].ToString();
                    this.textBoxFname.Text = table.Rows[0]["fname"].ToString();
                    this.textBoxlname.Text = table.Rows[0]["lname"].ToString();
                    this.comboBoxGroup.SelectedValue = table.Rows[0]["group_id"];
                    this.textBoxPhone.Text = table.Rows[0]["phone"].ToString();
                    this.textBoxEmail.Text = table.Rows[0]["email"].ToString();
                    this.textBoxAdress.Text = table.Rows[0]["address"].ToString();
                    byte[] pic = (byte[])table.Rows[0]["picture"];
                    MemoryStream picture = new MemoryStream(pic);
                    this.PictureBoxStudentImage.Image = Image.FromStream(picture);
                }    
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi "+ex.Message, "Edit Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditContactForm_Load_1(object sender, EventArgs e)
        {
            BUS_Group BUSGroup = new BUS_Group();
            this.comboBoxGroup.DataSource = BUSGroup.getGroups(DTO_Global.GlobalUserId);
            this.comboBoxGroup.DisplayMember = "name";
            this.comboBoxGroup.ValueMember = "Id";
        }
    }
}
