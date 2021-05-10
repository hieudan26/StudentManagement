using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL_StudentManagement
{
    public class DAL_Group : myDB
    {
        public bool insertGroup(int Id, string gname, int userid)
        {
            SqlCommand comand = new SqlCommand("INSERT INTO group (Id, name, userId)" +
                " VALUES (@cid, @fn,@ln)", this.getConnection);

            comand.Parameters.Add("@cid", SqlDbType.Int).Value = Id;
            comand.Parameters.Add("@fn", SqlDbType.VarChar).Value = gname;
            comand.Parameters.Add("@ln", SqlDbType.Int).Value = userid;
            this.openConnection();
            if ((comand.ExecuteNonQuery() == 1))
            {
                this.closeConnection();
                return true;
            }
            else
            {
                this.closeConnection();
                return false;
            }
        }
        public bool updateGroup(int Id, string gname, int userid)
        {
            SqlCommand command = new SqlCommand("UPDATE group SET name=@fn, userid=@ln WHERE Id=@Id", this.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = gname;
            command.Parameters.Add("@ln", SqlDbType.Int).Value = userid;
            this.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                this.closeConnection();
                return true;
            }
            else
            {
                this.closeConnection();
                return false;
            }
        }
        public bool deleteGroup(int id)
        {

            SqlCommand command = new SqlCommand("DELETE FROM group WHERE Id = @id", this.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            this.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                this.closeConnection();
                return true;
            }
            else
            {
                this.closeConnection();
                return false;
            }
        }
        public DataTable getGroups(int userid)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM group WHERE userId=@cId", this.getConnection);
            command.Parameters.Add("@cId", SqlDbType.Int).Value = userid;
            command.Connection = this.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool groupExist(string name, string operation, int userid, int groupid)
        {
            string query = "";
            SqlCommand command = new SqlCommand();
            if (operation == "add")
            {
                query = "SELECT * FROM group WHERE name = @name AND userid = @uid";
                command.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
                command.Parameters.Add("@uid", SqlDbType.Int).Value = userid;
            }
            else if (operation == "edit")
            {
                query = "SELECT * FROM group WHERE name=@name AND userid = @uid AND id<> @gid";
                command.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
                command.Parameters.Add("@uid", SqlDbType.Int).Value = userid;
                command.Parameters.Add("@gid", SqlDbType.Int).Value = groupid;
            }
            command.Connection = this.getConnection;
            command.CommandText = query;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool checkID(int id)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM group WHERE Id=@cId", this.getConnection);
            command.Parameters.Add("@cId", SqlDbType.Int).Value = id;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if ((table.Rows.Count > 0))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
