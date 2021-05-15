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
    public partial class ContactForm : Form
    {
        public ContactForm()
        {
            InitializeComponent();
        }
        BUS_Contact BUSContact = new BUS_Contact();
        BUS_Group BUSGroup = new BUS_Group();
        BUS_User BUSUser = new BUS_User();
        public void getImageAndUsername()
        {
            DataTable table = BUSUser.getImageAndUsername();
            
            if (table.Rows.Count > 0)
            {
                byte[] pic = (byte[])table.Rows[0]["picture"];
                MemoryStream picture = new MemoryStream(pic);
                this.pictureBoxUser.Image = Image.FromStream(picture);

                this.labelTitle.Text = "Welcome (" + table.Rows[0]["username"].ToString().Trim() + ")";
                this.labelName.Text = "(" + table.Rows[0]["fname"].ToString().Trim() + " " + table.Rows[0]["lname"].ToString().Trim() + ")";
            }
        }


        public void loadCombobox()
        {
            this.comboBoxSelectGroupEdit.DataSource = BUSGroup.getGroups(DTO_Global.GlobalUserId);
            this.comboBoxSelectGroupEdit.DisplayMember = "name";
            this.comboBoxSelectGroupEdit.ValueMember = "Id";

            this.comboBoxSelectGroupRemove.DataSource = BUSGroup.getGroups(DTO_Global.GlobalUserId);
            this.comboBoxSelectGroupRemove.DisplayMember = "name";
            this.comboBoxSelectGroupRemove.ValueMember = "Id";
        }


        private void ContactForm_Load_1(object sender, EventArgs e)
        {
            this.getImageAndUsername();
            this.loadCombobox();
        }

        private void buttonAdd_Click_1(object sender, EventArgs e)
        {
            AddContactForm addcontact = new AddContactForm();
            addcontact.Show(this);
        }

        private void buttonEdit_Click_1(object sender, EventArgs e)
        {
            EditContactForm editContactForm = new EditContactForm();
            editContactForm.Show(this);
        }

        private void buttonSelect_Click_1(object sender, EventArgs e)
        {
            SelectContactForm SelectContactF = new SelectContactForm();
            SelectContactF.ShowDialog();
            try
            {

                int contactId = Convert.ToInt32(SelectContactF.dataGridViewListContact.CurrentRow.Cells[0].Value.ToString());
                DataTable table = BUSContact.getContactById(contactId);

                this.textBoxContactID.Text = table.Rows[0]["Id"].ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Loi", "Select Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRemove_Click_1(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBoxContactID.Text);
                if ((MessageBox.Show("ban co muon xoa BUSContact nay", "Delete Contact", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    if (BUSContact.deleteContact(id))
                    {
                        MessageBox.Show("Xoa Thanh Cong", "Delete Contact", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Khong The Khoa", "Delete Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Please Enter Valid ID", "Delete Contact", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonShowFull_Click_1(object sender, EventArgs e)
        {
            btnAddcourse showfull = new btnAddcourse();
            showfull.Show();
        }

        private void buttonGAdd_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (this.textBoxGroupName.Text.Trim() != "" && this.textBoxIDGroup.Text.Trim() != "")
                {
                    int id = Convert.ToInt32(this.textBoxIDGroup.Text);
                    string name = this.textBoxGroupName.Text;
                    int userid = DTO_Global.GlobalUserId;

                    if (BUSGroup.checkID(id) && BUSGroup.groupExist(name, "add", DTO_Global.GlobalUserId, 0))
                    {
                        if (BUSGroup.insertGroup(id, name, userid))
                        {
                            this.loadCombobox();
                            MessageBox.Show("New Group Added", "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error", "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("This ID Already Exists, Try Another One", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("One Or More Fields Are Empty", "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Loi", "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonGEdit_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (this.comboBoxSelectGroupEdit.SelectedValue != null && this.textBoxNewNameGroup.Text.Trim() != "")
                {
                    int groupID = Convert.ToInt32(this.comboBoxSelectGroupEdit.SelectedValue.ToString().Trim());
                    string name = this.textBoxGroupName.Text;
                    int userid = DTO_Global.GlobalUserId;
                    if (BUSGroup.groupExist(name, "edit", DTO_Global.GlobalUserId, groupID))
                    {
                        if (BUSGroup.updateGroup(groupID, name, userid))
                        {
                            this.loadCombobox();
                            MessageBox.Show("Da Cap Nhap", "Edit Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("error", "Edit Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Exist Name", "Edit Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("empty fieds", "Edit Group", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch
            {
                MessageBox.Show("Loi", "Edit Group", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void buttonGRemove_Click_1(object sender, EventArgs e)
        {
            try
            {
                int groupID = Convert.ToInt32(this.comboBoxSelectGroupRemove.SelectedValue.ToString().Trim());
                if (MessageBox.Show("Ban Chan Chac Muon Xoa Group Nay ", "Delete Group", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (BUSGroup.deleteGroup(groupID))
                    {
                        this.loadCombobox();
                        MessageBox.Show("Xoa Thanh Cong", "Delete Group", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Khong Thanh Cong", "Delete Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Ban Da Huy Xoa", "Delete Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch
            {
                MessageBox.Show("Empty Fieds", "Delete Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
