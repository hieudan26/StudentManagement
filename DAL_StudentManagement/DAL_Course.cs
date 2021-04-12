using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_StudentManagement;
namespace DAL_StudentManagement
{
    public class DAL_Course : myDB
    {
        public bool insertCOURSE(DTO_Course course)
        {
            SqlCommand command = new SqlCommand("INSERT INTO COURSE ( label, period, description)" +
                 "VALUES ( @label, @period, @description)", this.getConnection);
            command.Parameters.Add("@label", SqlDbType.VarChar).Value = course.label;
            command.Parameters.Add("@period", SqlDbType.Int).Value = course.period;
            command.Parameters.Add("@description", SqlDbType.VarChar).Value = course.description;

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
        public DataTable getCOURSE()
        {
            SqlCommand command = new SqlCommand("SELECT * from COURSE", this.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable getCOURSEId(int id)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM COURSE WHERE id = @id", this.getConnection);
            command.Parameters.Add("@id", SqlDbType.VarChar).Value = id;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable getCOURSELabel(string label)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM COURSE WHERE label = @label", this.getConnection);
            command.Parameters.Add("@label", SqlDbType.VarChar).Value = label;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool deleteSCOURSE(int id)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM COURSE WHERE id = @id", this.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            this.openConnection();
            if (cmd.ExecuteNonQuery() == 1)
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
        public bool updateCOURSE(DTO_Course course,int id)
        {
            SqlCommand command = new SqlCommand("UPDATE COURSE SET label=@label, period=@period, description=@description WHERE id =@id", this.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@label", SqlDbType.VarChar).Value = course.label;
            command.Parameters.Add("@period", SqlDbType.VarChar).Value = course.period;
            command.Parameters.Add("@description", SqlDbType.VarChar).Value = course.description;

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
    }
}
