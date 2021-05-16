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

        public DataTable getContactByGroupId(int id)
        {
            return DALcontact.getContactByGroupId(id);
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
        public bool insertCTCourse(int contact_id,int course_id)
        {
            return DALcontact.insertCTCourse(contact_id,course_id);
        }
        public bool checkIdContatct(int contact_id)
        {
            return DALcontact.checkIdContatct(contact_id);
        }
        public bool checkIdCourse(int course_id)
        {
            return DALcontact.checkIdCourse(course_id);
        }
        public DataTable getIDCourse(int contact_id)
        {
            return DALcontact.getIDCourse(contact_id);
        }
        public DataTable getIDAllCourse(int contact_id)
        {
            return DALcontact.getIDAllCourse(contact_id);
        }
        public bool checkIdinsertCourt(int contact_id,int course_id)
        {
            return DALcontact.checkIdinsertCourt(contact_id,course_id);
        }
        public bool deleteCourseOfContact(int contact_id, int course_id)
        {
            return DALcontact.deleteCourseOfContact(contact_id, course_id);
        }
    }
}
