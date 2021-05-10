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
    public class BUS_Contact
    {
        DAL_Contact DALcontact = new DAL_Contact();
        public bool insertContact(int id, string fname, string lname, int groupid, string phone, string email, string address, MemoryStream picture, int userid)
        {
            return DALcontact.insertContact(id, fname, lname, groupid, phone, email, address, picture, userid);
        }
        public bool UpdateContact(int id, string fname, string lname, int groupid, string phone, string email, string address, MemoryStream picture)
        {
            return DALcontact.UpdateContact(id, fname, lname, groupid, phone, email, address, picture);
        }

        public bool deleteContact(int id)
        {
            return DALcontact.deleteContact(id);
        }
        public DataTable getContactById(int id)
        {
            return DALcontact.getContactById(id);
        }

        public DataTable getContactByUserId(int userid)
        {
            return DALcontact.getContactByUserId(userid);
        }

        public DataTable getContact(SqlCommand command)
        {
            return DALcontact.getContact(command);
        }

        public bool checkId(int courseId)
        {
            return DALcontact.checkId(courseId);
        }
    }
}
