using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_StudentManagement;

namespace DAL_StudentManagement
{
    public class DAL_Account : myDB
    {
        public DataTable getAcc(SqlCommand cmd)
        {
            cmd.Connection = this.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool insertAccount(DTO_Account acc)
        {
            if (!acc.verifyPass(acc.Username, acc.Password))
            {
                return false;
            }
            else
            {
                try
                {
                    this.openConnection();

                    SqlCommand cmd = new SqlCommand("INSERT INTO Login (Username, Password)" +
             "VALUES (@username, @pass)", this.getConnection);

                    cmd.Parameters.Add("@username", SqlDbType.NVarChar).Value = acc.Username;
                    cmd.Parameters.Add("@pass", SqlDbType.NVarChar).Value = acc.Password;

                    if (cmd.ExecuteNonQuery() == 1)
                        return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: ", ex.Message);
                }
                finally
                {
                    this.closeConnection();
                }
                return false;
            }
        }

        public bool verifyAccount(DTO_Account acc)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();

            DataTable table = new DataTable();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Login WHERE Username = @username", this.getConnection);

            cmd.Parameters.Add("@Username", SqlDbType.NVarChar).Value = acc.Username;

            adapter.SelectCommand = cmd;

            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                return false;
            }
            else
                return true;
        }

        public bool loginAccount(DTO_Account acc)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();

            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SELECT * FROM Login WHERE Username = @username AND Password = @password", this.getConnection);

            command.Parameters.Add("@username", SqlDbType.NVarChar).Value = acc.Username;
            command.Parameters.Add("@password", SqlDbType.NVarChar).Value = acc.Password;

            adapter.SelectCommand = command;

            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
                return false;
        }

        public bool changeInfoAccount(DTO_Account accold, DTO_Account accnew)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();

            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SELECT * FROM Login WHERE Username = @username", this.getConnection);

            command.Parameters.Add("@username", SqlDbType.NVarChar).Value = accold.Username;

            adapter.SelectCommand = command;

            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                int id = Convert.ToInt32(table.Rows[0]["ID"]);

                command = new SqlCommand("UPDATE Login SET Username = @usernamenew, PASSWORD = @passwordnew WHERE ID = @id", this.getConnection);

                command.Parameters.Add("@usernamenew", SqlDbType.NVarChar).Value = accnew.Username;

                command.Parameters.Add("@passwordnew", SqlDbType.NVarChar).Value = accnew.Password;

                command.Parameters.Add("@id", SqlDbType.Int).Value = id;

                adapter.SelectCommand = command;

                adapter.Fill(table);

                //check


                SqlDataAdapter adapter2 = new SqlDataAdapter();

                DataTable table2 = new DataTable();
                SqlCommand command2 = new SqlCommand("SELECT Username FROM Login WHERE ID = " + id, this.getConnection);

                adapter2.SelectCommand = command2;

                adapter2.Fill(table2);

                if (table2.Rows.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
                return false;
        }

        public string forgotPassword(DTO_Account acc)
        {
            string tmp = "";
            SqlDataAdapter adapter = new SqlDataAdapter();

            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SELECT * FROM log WHERE Username = @username", this.getConnection);

            command.Parameters.Add("@username", SqlDbType.NVarChar).Value = acc.Username;

            adapter.SelectCommand = command;

            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                tmp = table.Rows[0]["Password"].ToString();
                //MessageBox.Show("Don't forget your password anymore: \n=> Your pass: " + tmp, "Account usename", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return tmp;
            }
            else
            {
                return tmp;
            }
        }
    }
}
