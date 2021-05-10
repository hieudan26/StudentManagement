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
using GUI_StudentManagement.Student;
using GUI_StudentManagement.User;

namespace GUI_StudentManagement
{
    public partial class Login_Child : Form
    {
        BUS_Account BUSacc = new BUS_Account();
        BUS_User BUSUser = new BUS_User();
        public Login_Child()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (this.txtUsername.Text == "" || this.txtPassword.Text == "")
            {
                MessageBox.Show("Invalid Username or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DTO_Account DTOacc = new DTO_Account(this.txtUsername.Text, this.txtPassword.Text);

                if (this.BUSacc.loginAccount(DTOacc))
                {
                    DialogResult dialogResult = MessageBox.Show("Login Successfully");
                    DTO_Global.SetGlabelUserId(BUSUser.getIdByUserName(this.txtUsername.Text));
                    //MenuStudent menu1 = new MenuStudent();
                    AddContactForm menu1= new AddContactForm();
                    menu1.Show();
                    
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Login_Child_Load(object sender, EventArgs e)
        {

        }
    }
}
