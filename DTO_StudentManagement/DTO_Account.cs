using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_StudentManagement
{
    public class DTO_Account
    {


        private string sUsername;

        public string Username { get => sUsername; set => sUsername = value; }

        private string sPassword;

        public string Password { get => sPassword; set => sPassword = value; }

        public DTO_Account() { }

        public DTO_Account(string Username, string Password)
        {
            this.sUsername = Username;
            this.sPassword = Password;
        }

        public bool verifyPass(string Username, string Password)
        {
            if (!checkPass(Password))
            {
                return false;
            }
            else
                return true;

        }

        public bool checkPass(string pass)
        {
            /*if (pass.length >= 7)
            {
                int flagchu = 0;
                int flagso = 0;
                for (int i = 0; i < pass.length; i++)
                {
                    if (flagchu == 1 && flagso == 1)
                    {
                        return true;
                    }

                    if ((pass[i] >= 'a' && pass[i] <= 'z') || (pass[i] >= 'a' && pass[i] <= 'z'))
                    {
                        flagchu = 1;
                    }

                    if (pass[i] >= '0' && pass[i] <= '9')
                    {
                        flagso = 1;
                    }
                }
                return false;
            }
            else
                return false;*/
            return true;
        }
        ~DTO_Account() { }
    }
}
