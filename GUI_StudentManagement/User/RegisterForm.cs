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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }
        BUS_User user = new BUS_User();

        public bool verif()
        {
            if ((textBoxFirstName.Text.Trim() == "")
                      || (textBoxLastName.Text.Trim() == "")
                      || (textBoxUserID.Text.Trim() == "")
                      || (textBoxUserName.Text.Trim() == "")
                      || (textBoxPassword.Text.Trim() == "")
                      || (pictureBoxImage.Image == null))
            {
                return false;
            }
            else return true;
        }


        private void labelGotoLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uploadImg_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image (*.jpg; *.png; *.gif)| *.jpg; *.png; *.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                this.pictureBoxImage.Image = Image.FromFile(opf.FileName);
            }
        }

        private void Register_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (verif())
                {
                    int ID = Convert.ToInt32(textBoxUserID.Text);
                    string fname = textBoxFirstName.Text;
                    string lname = textBoxLastName.Text;
                    string username = textBoxUserName.Text;
                    string password = textBoxPassword.Text;
                    MemoryStream pic = new MemoryStream();
                    pictureBoxImage.Image.Save(pic, pictureBoxImage.Image.RawFormat);

                    if (user.checkID(ID) == true && user.usernameExist(username, "register") == true)
                    {

                        if (user.insertUser(ID, fname, lname, username, password, pic))
                        {
                            MessageBox.Show("New user account", "Register", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error", "Register", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Da ton tai ID hay Username", "Register", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Empty Fields", "Register", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Loi"+ ex.Message, "Register", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }
    }
}
