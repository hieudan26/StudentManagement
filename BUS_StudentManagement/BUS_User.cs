using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_StudentManagement;
using DTO_StudentManagement;
namespace BUS_StudentManagement
{
    public class BUS_User
    {
        DAL_User DALuser = new DAL_User();
        public DataTable getUserById(int userid)
        {
            return DALuser.getUserById(userid); 
        }
        public DataTable getImageAndUsername()
        {
            return DALuser.getImageAndUsername();
        }
        public bool insertUser(int Id, string fname, string lname, string username, string password, MemoryStream picture)
        {
            return DALuser.insertUser(Id,fname,lname,username,password,picture);
        }

        public bool checkID(int id)
        {
            return DALuser.checkID(id);
        }
        public int getIdByUserName(string username)
        {
            return DALuser.getIdByUserName(username);
        }

        public bool usernameExist(string username, string operation, int userid = 0)
        {
            return DALuser.usernameExist(username,operation,userid);
        }

        public bool updatetUser(int userid, string fname, string lname, string username, string password, MemoryStream picture)
        {
            return DALuser.updatetUser(userid,fname,lname,username,password,picture);
        }
    }
}
