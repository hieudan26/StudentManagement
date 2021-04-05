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
namespace GUI_StudentManagement
{
    public partial class Register_Child : Form
    {
        BUS_Account BUSacc = new BUS_Account();
        public Register_Child()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            DTO_Account acc = new DTO_Account( this.txtUsername.Text, this.txtPassword.Text);
            try
            {
                if (!BUSacc.verifyAccount(acc))
                {
                    throw new Exception("Account already exists !! please try again");
                }
                else
                {
                    if (!BUSacc.insertAccount(acc))
                    {
                        this.txtUsername.Text = "";
                        this.txtPassword.Text = "";
                        this.txtRepassword.Text = "";
                        this.txtUsername.Focus();
                        MessageBox.Show("Wrong format Password!!");
                    }
                    else
                    {
                        MessageBox.Show("Successfully!!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtUsername.Text = "";
                this.txtPassword.Text = "";
                this.txtRepassword.Text = "";
                this.txtUsername.Focus();
            }
        }
    }
}
