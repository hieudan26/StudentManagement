using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_StudentManagement
{
    public partial class User : Form
    {
        Login_Child LoginForm = new Login_Child();
        Register_Child RegiForm = new Register_Child();
        public User()
        {
            InitializeComponent();
        }

        
        private void User_Load(object sender, EventArgs e)
        {
            LoginForm.MdiParent = this;
            LoginForm.Show();
            LoginForm.StartPosition = FormStartPosition.Manual;
            LoginForm.Location = new Point(0,200);
            LoginForm.Visible = true;
            this.btnSignIn.BackColor = Color.White;
            this.btnSignIn.ForeColor = Color.LightSeaGreen;
            
            RegiForm.MdiParent = this;
            RegiForm.Show();
            RegiForm.StartPosition = FormStartPosition.Manual;
            RegiForm.Location = new Point(0, 200);
            RegiForm.Visible = false;
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is MdiClient)
                {
                    ctrl.BackColor = Color.White;
                }
            }
        }
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            LoginForm.Visible = true;
            RegiForm.Visible = false;

            this.btnSignIn.BackColor = Color.White;
            this.btnSignIn.ForeColor = Color.LightSeaGreen;

            this.btnSignUp.BackColor = Color.LightSeaGreen;
            this.btnSignUp.ForeColor = Color.White;

        }
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            LoginForm.Visible = false;
            RegiForm.Visible = true;

            this.btnSignUp.BackColor = Color.White;
            this.btnSignUp.ForeColor = Color.LightSeaGreen;

            this.btnSignIn.BackColor = Color.LightSeaGreen;
            this.btnSignIn.ForeColor = Color.White;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
