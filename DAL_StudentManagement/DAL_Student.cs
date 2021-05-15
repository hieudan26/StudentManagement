
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
    public class DAL_Student : myDB
    {
        public bool insertStudent(DTO_Student student)
        {
            try
            { 
                SqlCommand command = new SqlCommand("INSERT INTO std (id, fname, lname, bdate, gender, phone, address, picture)" +
                     "VALUES (@id, @fn, @ln, @bdt, @gdr, @phn, @adr, @pic)", this.getConnection);
                command.Parameters.Add("@id", SqlDbType.Int).Value = student.id;
                command.Parameters.Add("@fn", SqlDbType.VarChar).Value = student.fname;
                command.Parameters.Add("@ln", SqlDbType.VarChar).Value = student.lname;
                command.Parameters.Add("@bdt", SqlDbType.DateTime).Value = student.birthdate;
                command.Parameters.Add("@gdr", SqlDbType.VarChar).Value = student.gender;
                command.Parameters.Add("@phn", SqlDbType.VarChar).Value = student.phone;
                command.Parameters.Add("@adr", SqlDbType.VarChar).Value = student.address;
                command.Parameters.Add("@pic", SqlDbType.Image).Value = student.picture.ToArray();

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
        public DataTable getStudentsId(int id)
        {
            try { 
                SqlCommand command = new SqlCommand("SELECT id, fname, lname, bdate, gender, phone, address, picture FROM std WHERE id = " + id);
                command.Connection = this.getConnection;
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
        public DataTable SearchFull(string text)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM std WHERE CONCAT(fname,lname,address) LIKE '%" + text + "%'");
            command.Connection = this.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }
        public DataTable getAllStudent()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM std");
            command.Connection = this.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }
        public DataTable getStudents(SqlCommand command)
        {
            command.Connection = this.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }
        public bool verifyStudent(DTO_Student student)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();

            DataTable table = new DataTable();

            SqlCommand cmd = new SqlCommand("SELECT * FROM std WHERE id = @id", this.getConnection);

            cmd.Parameters.Add("@id", SqlDbType.Int).Value = student.id;

            adapter.SelectCommand = cmd;

            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("ID is exsited", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                return true;
        }
        public bool deleteStudent(int id)
        {
            try
            { 
                SqlCommand cmd = new SqlCommand("DELETE FROM std WHERE id = @id", this.getConnection);
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
}

        public bool updateStudent(DTO_Student student)
        {
            try
            { 
                SqlCommand command = new SqlCommand("UPDATE std SET fname=@fn, lname=@ln, bdate=@bdt, gender=@gdr, phone=@phn, address=@adr, picture=@pic WHERE id =@id", this.getConnection);
                command.Parameters.Add("@id", SqlDbType.Int).Value = student.id;
                command.Parameters.Add("@fn", SqlDbType.VarChar).Value = student.fname;
                command.Parameters.Add("@ln", SqlDbType.VarChar).Value = student.lname;
                command.Parameters.Add("@gdr", SqlDbType.VarChar).Value = student.gender;
                command.Parameters.Add("@bdt", SqlDbType.DateTime).Value = student.birthdate;
                command.Parameters.Add("@phn", SqlDbType.VarChar).Value = student.phone;
                command.Parameters.Add("@adr", SqlDbType.VarChar).Value = student.address;
                command.Parameters.Add("@pic", SqlDbType.Image).Value = student.picture.ToArray();

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
        public int totalStudent()
        {

            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM std", this.getConnection);
            this.openConnection();
            Int32 count = Convert.ToInt32(cmd.ExecuteScalar());
            this.closeConnection();
            if (count > 0)
            {
                return count;
            }
            else
            {
                return 0;
            }
        }
        public int totalMaleStudent()
        {

            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM std WHERE gender = @gender", this.getConnection);
            cmd.Parameters.Add("@gender", SqlDbType.NVarChar).Value = "Male";
            this.openConnection();
            Int32 count = Convert.ToInt32(cmd.ExecuteScalar());
            this.closeConnection();
            if (count > 0)
            {
                return count;
            }
            else
            {
                return 0;
            }
        }
        public int totalFemaleStudent()
        {
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM std WHERE gender = @gender", this.getConnection);
            cmd.Parameters.Add("@gender", SqlDbType.NVarChar).Value = "Female";
            this.openConnection();
            Int32 count = Convert.ToInt32(cmd.ExecuteScalar());
            this.closeConnection();
            if (count > 0)
            {
                return count;
            }
            else
            {
                return 0;
            }
        }
        public DataTable FilterStudent(bool YesBtn,  bool MaleBtn, bool FeMaleBtn, DateTime dateBeforeDate, DateTime dateAfterDay)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM std");
            if (YesBtn == false && MaleBtn == false && FeMaleBtn == false)
            {
                command = new SqlCommand("SELECT * FROM std");
            }
            else if(YesBtn == true && MaleBtn == false && FeMaleBtn == false)
            {
                command = new SqlCommand("SELECT * FROM std WHERE bdate BETWEEN @bf_Date  AND @at_Date");
                command.Parameters.Add("@bf_Date", SqlDbType.Date).Value = dateBeforeDate;
                command.Parameters.Add("@at_Date", SqlDbType.Date).Value = dateAfterDay;
            }
            else if (MaleBtn == true)
            {
                if (YesBtn == false)
                {
                    command = new SqlCommand("SELECT * FROM std WHERE gender = @gender");
                    command.Parameters.Add("@gender", SqlDbType.NVarChar).Value = "Male";
                }
                else
                {
                    command = new SqlCommand("SELECT * FROM std WHERE gender = @gender AND bdate BETWEEN @bf_Date  AND @at_Date");
                    command.Parameters.Add("@gender", SqlDbType.NVarChar).Value = "Male";
                    command.Parameters.Add("@bf_Date", SqlDbType.Date).Value = dateBeforeDate;
                    command.Parameters.Add("@at_Date", SqlDbType.Date).Value = dateAfterDay;
                }

            }
            else
            {
                if (YesBtn == false)
                {
                    command = new SqlCommand("SELECT * FROM std WHERE gender = @gender");
                    command.Parameters.Add("@gender", SqlDbType.NVarChar).Value = "Female";
                }
                else
                {
                    command = new SqlCommand("SELECT * FROM std WHERE gender = @gender AND bdate BETWEEN @bf_Date  AND @at_Date");
                    command.Parameters.Add("@gender", SqlDbType.NVarChar).Value = "Female";
                    command.Parameters.Add("@bf_Date", SqlDbType.Date).Value = dateBeforeDate;
                    command.Parameters.Add("@at_Date", SqlDbType.Date).Value = dateAfterDay;
                }
            }
            return this.getStudents(command);
        }
        public DataTable getAllIfnoStudent()
        {
            SqlCommand command = new SqlCommand("SELECT id,fname,lname FROM std");
            command.Connection = this.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }
    }
}
