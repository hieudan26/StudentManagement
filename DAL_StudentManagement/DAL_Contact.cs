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
    public class DAL_Contact : myDB
    {
        public bool insertContact(int id, string fname, string lname, int groupid, string phone, string email, string address, MemoryStream picture, int userid)
        {
            try
            { 
                SqlCommand comand = new SqlCommand("INSERT INTO Contact (Id, fname, lname, group_id, phone,email, address, picture,userid)" +
                    " VALUES (@id, @fn, @ln, @gri,@phn,@em, @adrs, @picture,@ui)", this.getConnection);
                comand.Parameters.Add("@id", SqlDbType.Int).Value = id;
                comand.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
                comand.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
                comand.Parameters.Add("@phn", SqlDbType.VarChar).Value = phone;
                comand.Parameters.Add("@em", SqlDbType.VarChar).Value = email;
                comand.Parameters.Add("@adrs", SqlDbType.Text).Value = address;
                comand.Parameters.Add("@picture", SqlDbType.Image).Value = picture.ToArray();
                comand.Parameters.Add("@ui", SqlDbType.Int).Value = DTO_Global.GlobalUserId;
                comand.Parameters.Add("@gri", SqlDbType.Int).Value = groupid;
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public bool insertCTCourse(int contact_id,int course_id)
        {
            try
            {
                SqlCommand comand = new SqlCommand("INSERT INTO CourseOfContact (contact_id,course_id)" +
                    " VALUES (@contact_id, @course_id)", this.getConnection);
                comand.Parameters.Add("@contact_id", SqlDbType.Int).Value = contact_id;
                comand.Parameters.Add("@course_id", SqlDbType.VarChar).Value = course_id;

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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public bool UpdateContact(int id, string fname, string lname, int groupid, string phone, string email, string address, MemoryStream picture)
        {
            try
            { 
                SqlCommand comand = new SqlCommand("UPDATE Contact SET fname=@fn,lname=@ln,group_id=@gri,phone=@phn,email=@em,ad" +
                    "dress=@adrs,picture=@picture WHERE id=" + id, this.getConnection);

                comand.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
                comand.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
                comand.Parameters.Add("@gri", SqlDbType.Int).Value = groupid;
                comand.Parameters.Add("@phn", SqlDbType.VarChar).Value = phone;
                comand.Parameters.Add("@em", SqlDbType.VarChar).Value = email;
                comand.Parameters.Add("@adrs", SqlDbType.VarChar).Value = address;
                comand.Parameters.Add("@picture", SqlDbType.Image).Value = picture.ToArray();
                comand.Parameters.Add("@ui", SqlDbType.Int).Value = DTO_Global.GlobalUserId;
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool deleteContact(int id)
        {
            try 
            { 
                SqlCommand command = new SqlCommand("DELETE FROM CourseOfContact WHERE id= @id", this.getConnection);
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public bool deleteCourseOfContact(int contact_id, int course_id)
        {
            try
            {
                SqlCommand command = new SqlCommand("DELETE FROM CourseOfContact WHERE contact_id=@contact_id AND course_id=@course_id", this.getConnection);
                command.Parameters.Add("@contact_id", SqlDbType.Int).Value = contact_id;
                command.Parameters.Add("@course_id", SqlDbType.VarChar).Value = course_id;
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public DataTable getContactById(int id)
        {
            try
            {  
                SqlCommand command = new SqlCommand("select * from Contact where id=@id", this.getConnection);
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
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
        public DataTable getContactByGroupId(int id)
        {
            try
            {
                SqlCommand command = new SqlCommand("select * from Contact where group_id=@id", this.getConnection);
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
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
        public DataTable getContactByUserId(int userid)
        {
            try
            { 
                SqlCommand command = new SqlCommand("select * from Contact where userid = @id", this.getConnection);
                command.Parameters.Add("@id", SqlDbType.Int).Value = userid;
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

        public DataTable getContact(SqlCommand command)
        {
            try 
            { 
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

        public bool checkId(int courseId)
        {
            try
            { 
                SqlCommand command = new SqlCommand("SELECT * FROM Contact WHERE Id=@cId", this.getConnection);
                command.Parameters.Add("@cId", SqlDbType.Int).Value = courseId;
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                if ((table.Rows.Count > 0))
                {
                    return false;   //Ton Tai
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
                return false;
            }
        }

        public bool checkIdContatct(int contact_id)
        {
            try
            {
                SqlCommand command = new SqlCommand("SELECT * FROM CourseOfContact WHERE contact_id=@contact_id", this.getConnection);
                command.Parameters.Add("@contact_id", SqlDbType.Int).Value = contact_id;
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                if ((table.Rows.Count > 0))
                {
                    return false;   //Ton Tai
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                return false;
            }
        }
        public bool checkIdinsertCourt(int contact_id, int course_id)
        {
            try
            {
                SqlCommand command = new SqlCommand("SELECT * FROM CourseOfContact WHERE contact_id=@contact_id AND course_id=@course_id", this.getConnection);
                command.Parameters.Add("@contact_id", SqlDbType.Int).Value = contact_id;
                command.Parameters.Add("@course_id", SqlDbType.Int).Value = course_id;
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                if ((table.Rows.Count > 0))
                {
                    return false;   //Ton Tai
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                return false;
            }
        }
        public bool  checkIdCourse(int course_id)
        {
            try
            {
                SqlCommand command = new SqlCommand("SELECT * FROM CourseOfContact WHERE course_id=@course_id", this.getConnection);
                command.Parameters.Add("@course_id", SqlDbType.Int).Value = course_id;
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                if ((table.Rows.Count > 0))
                {
                    return false;   //Ton Tai
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                return false;
            }
        }
        public DataTable getIDCourse(int contact_id)
        {
            try
            {
                SqlCommand command = new SqlCommand("select * from CourseOfContact where contact_id = @contact_id", this.getConnection);
                command.Parameters.Add("@contact_id", SqlDbType.Int).Value = contact_id;
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
        public DataTable getIDAllCourse(int contact_id)
        {
            try
            {
                SqlCommand command = new SqlCommand("select * from COURSE where COURSE.Id in(select course_id from CourseOfContact where contact_id = @contact_id)", this.getConnection);
                command.Parameters.Add("@contact_id", SqlDbType.Int).Value = contact_id;
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
    }
}
