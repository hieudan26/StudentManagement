using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_StudentManagement;
using DTO_StudentManagement;
namespace BUS_StudentManagement
{
    public class BUS_Account
    {
         DAL_Account accDAL = new DAL_Account();

        public bool verifyAccount(DTO_Account acc)
        {
            return accDAL.verifyAccount(acc);
        }

        public bool insertAccount(DTO_Account acc)
        {
            return accDAL.insertAccount(acc);
        }

        public bool loginAccount(DTO_Account acc)
        {
            return accDAL.loginAccount(acc);
        }

        public bool changeInfoAccount(DTO_Account accold, DTO_Account accnew)
        {
            return accDAL.changeInfoAccount(accold, accnew);
        }

        public string forgotPassword(DTO_Account acc)
        {
            return accDAL.forgotPassword(acc);
        }
    }
}
