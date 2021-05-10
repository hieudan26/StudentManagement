using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_StudentManagement;
using DTO_StudentManagement;

namespace BUS_StudentManagement
{
    public class BUS_Group
    {
        DAL_Group DALgroup = new DAL_Group();
        public bool insertGroup(int Id, string gname, int userid)
        {
            return DALgroup.insertGroup(Id, gname, userid);
        }
        public bool updateGroup(int Id, string gname, int userid)
        {
            return DALgroup.updateGroup(Id, gname, userid);
        }
        public bool deleteGroup(int id)
        {
            return DALgroup.deleteGroup(id);
        }
        public DataTable getGroups(int userid)
        {
            return DALgroup.getGroups(userid);
        }
        public bool groupExist(string name, string operation, int userid, int groupid)
        {
            return DALgroup.groupExist(name,operation,userid,groupid);
        }

        public bool checkID(int id)
        {
            return DALgroup.checkID(id);
        }
    }
}
