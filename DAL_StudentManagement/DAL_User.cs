using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_StudentManagement;
namespace DAL_StudentManagement
{
    public class DAL_User : myDB
    {
        public DataTable getUserById(int userid)
        {
            try { 
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                SqlCommand command = new SqlCommand("SELECT * FROM Login WHERE Id = @uid", this.getConnection);

                command.Parameters.Add("@uid", SqlDbType.Int).Value = userid;
                adapter.SelectCommand = command;
                adapter.Fill(table);
                return table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                DataTable table = new DataTable();
                return table;
            }
        }
        public DataTable getImageAndUsername()
        {
            try
            { 
                SqlCommand command = new SqlCommand("SELECT * FROM Login where Id=@uid", this.getConnection);
                command.Parameters.Add("@uid", SqlDbType.Int).Value = DTO_Global.GlobalUserId;
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                DataTable table = new DataTable();
                return table;
            }
}
        public int getIdByUserName(string username)
        {

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SELECT * FROM Login WHERE username = @username", this.getConnection);
            command.Parameters.Add("@username", SqlDbType.NVarChar).Value = username;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            return int.Parse(table.Rows[0][0].ToString());
        }
        public bool insertUser(int Id, string fname, string lname, string username, string password, MemoryStream picture)
        {
            try { 
                SqlCommand command = new SqlCommand("INSERT INTO Login (id, fname, lname, username, password, picture) VALUES (@id, @fn, @ln, @un, @pass, @pic)", this.getConnection);
                command.Parameters.Add("@id", SqlDbType.Int).Value = Id;
                command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
                command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
                command.Parameters.Add("@un", SqlDbType.VarChar).Value = username;
                command.Parameters.Add("@pass", SqlDbType.VarChar).Value = password;
                command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();

                this.openConnection();

                if (command.ExecuteNonQuery() == 1)
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool checkID(int id)
        {
            DataTable table = this.getUserById(id);
            if (table.Rows.Count > 0)
            {
                return false;   // Da ton tai id
            }
            else return true;   // Chua co id
        }

        public bool usernameExist(string username, string operation, int userid = 0)
        {
            string query = "";
            if (operation == "register")
            {
                query = "Select * from Login where username = @un";

            }
            else if (operation == "edit")
            {
                query = "Select * from Login where username = @un and id <> uid";
            }

            SqlCommand command = new SqlCommand(query, this.getConnection);
            command.Parameters.Add("@un", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@uid", SqlDbType.Int).Value = userid;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);


            if (table.Rows.Count > 0)
            {
                return false;        //Da ton tai

            }
            else
            {
                return true;       // Khong ton tai
            }
        }

        public bool updatetUser(int userid, string fname, string lname, string username, string password, MemoryStream picture)
        {
            try { 
                SqlCommand command = new SqlCommand("Update Login set fname = @fn, lname = @ln, username = @un, password = @pass, picture = @pic where id = @unid", this.getConnection);
                command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
                command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
                command.Parameters.Add("@un", SqlDbType.VarChar).Value = username;
                command.Parameters.Add("@pass", SqlDbType.VarChar).Value = password;
                command.Parameters.Add("@pic", SqlDbType.VarChar).Value = picture.ToArray();
                command.Parameters.Add("@uid", SqlDbType.Int).Value = userid;

                this.openConnection();

                if (command.ExecuteNonQuery() == 1)
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
