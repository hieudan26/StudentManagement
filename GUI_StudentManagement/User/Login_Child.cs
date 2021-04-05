﻿using System;
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

namespace GUI_StudentManagement
{
    public partial class Login_Child : Form
    {
        BUS_Account BUSacc = new BUS_Account();
       
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
                    MenuStudent menu1 = new MenuStudent();
                    menu1.Show();
                    
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}