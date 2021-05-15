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
        private void choice(int id)
        {
            DTO_Global.SetGlobalUserId(id);
            if (this.rbHu.Checked == false && this.rbStu.Checked == false)
            {
                MessageBox.Show("You have to choose one");
            }
            else if (this.rbStu.Checked == true)
            {
                MenuStudent mainForm = new MenuStudent();
                this.Hide();
                mainForm.ShowDialog();
                this.Show();
            }
            else
            {
                TeacherMenu form1 = new TeacherMenu();
                form1.Show();
            }
        }


        private void Login_Child_Load(object sender, EventArgs e)
        {

        }

        private void btnLog_Click(object sender, EventArgs e)
        { 
            if (this.txtUser.Text == "" || this.txtPass.Text == "")
            {
                MessageBox.Show("Invalid Username or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DTO_Account DTOacc = new DTO_Account(this.txtUser.Text, this.txtPass.Text);

                if (this.BUSacc.loginAccount(DTOacc))
                {
                    DialogResult dialogResult = MessageBox.Show("Login Successfully");
                     DTO_Global.SetGlobalUserId(BUSUser.getIdByUserName(this.txtUser.Text));
                    //MenuStudent menu1 = new MenuStudent();
                    this.choice(DTO_Global.GlobalUserId);

                }
                else
                {
                    MessageBox.Show("Invalid Username or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void RegistLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm form = new RegisterForm();
            form.Show();
        }
    }
}
