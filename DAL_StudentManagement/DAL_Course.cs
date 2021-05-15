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
    public class DAL_Course : myDB
    {
        public bool insertCOURSE(DTO_Course course)
        {
            try
            {
                SqlCommand command = new SqlCommand("INSERT INTO COURSE ( id,label, period, description,semester)" +
                    "VALUES ( @id,@label, @period, @description,@semester)", this.getConnection);
                command.Parameters.Add("@id", SqlDbType.VarChar).Value = course.id;
                command.Parameters.Add("@label", SqlDbType.VarChar).Value = course.label;
                command.Parameters.Add("@period", SqlDbType.Int).Value = course.period;
                command.Parameters.Add("@description", SqlDbType.VarChar).Value = course.description;
                command.Parameters.Add("@semester", SqlDbType.Int).Value = course.Semester;

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
        public DataTable getCOURSE()
        {
            try { 
                SqlCommand command = new SqlCommand("SELECT * from COURSE", this.getConnection);
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
        public DataTable getCOURSEEmpty(int semester)
        {
            try
            {
                SqlCommand command = new SqlCommand("Select * from COURSE where COURSE.Id not in(Select course_id from CourseOfContact inner join COURSE on CourseOfContact.course_id = COURSE.Id) AND COURSE.semester = @semester", this.getConnection);
                command.Parameters.Add("@semester", SqlDbType.VarChar).Value = semester;
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
        public DataTable getCOURSEId(int id)
        {
            try { 
                SqlCommand command = new SqlCommand("SELECT * FROM COURSE WHERE id = @id", this.getConnection);
                command.Parameters.Add("@id", SqlDbType.VarChar).Value = id;
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
        public DataTable getCOURSELabel(string label,int semester)
        {
            try { 
                SqlCommand command = new SqlCommand("SELECT * FROM COURSE WHERE label = @label AND semester = @semester", this.getConnection);
                command.Parameters.Add("@label", SqlDbType.VarChar).Value = label;
                command.Parameters.Add("@semester", SqlDbType.VarChar).Value = semester;
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
        public bool deleteSCOURSE(int id)
        {
            try { 
                SqlCommand cmd = new SqlCommand("DELETE FROM COURSE WHERE id = @id", this.getConnection);
                SqlCommand cmd2 = new SqlCommand("DELETE FROM Score WHERE course_id = @id", this.getConnection);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                cmd2.Parameters.Add("@id", SqlDbType.Int).Value = id;
                this.openConnection();
                if (cmd.ExecuteNonQuery() == 1 && cmd2.ExecuteNonQuery() == 1)
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
        public bool updateCOURSE(DTO_Course course)
        {
            try { 
                SqlCommand command = new SqlCommand("UPDATE COURSE SET label=@label, period=@period, description=@description, semester =@semester WHERE id =@id", this.getConnection);
                command.Parameters.Add("@id", SqlDbType.Int).Value = course.id;
                command.Parameters.Add("@label", SqlDbType.VarChar).Value = course.label;
                command.Parameters.Add("@period", SqlDbType.VarChar).Value = course.period;
                command.Parameters.Add("@description", SqlDbType.VarChar).Value = course.description;
                command.Parameters.Add("@semester", SqlDbType.Int).Value = course.Semester;
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
        public DataTable getCOURSELabeInsemester(int id_course,int semester)
        {
            try { 
                SqlCommand command = new SqlCommand("SELECT StudentinCourse.id_student,StudentinCourse.fname,StudentinCourse.lname FROM COURSE inner join StudentinCourse on COURSE.id = StudentinCourse.id_course WHERE id_course = @id and semester=@semester", this.getConnection);
                command.Parameters.Add("@id", SqlDbType.Int).Value = id_course;
                command.Parameters.Add("@semester", SqlDbType.Int).Value = semester;
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
        public DataTable getCOURSELabelStudent(int id_student, int semester)
        {
            try
            {
                SqlCommand command = new SqlCommand("SELECT COURSE.label FROM COURSE inner join SCORE on COURSE.id = SCORE.course_id WHERE student_id = @id and semester=@semester", this.getConnection);
                command.Parameters.Add("@id", SqlDbType.Int).Value = id_student;
                command.Parameters.Add("@semester", SqlDbType.Int).Value = semester;
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
        public DataTable getCOURSEsemester(int semester)
        {
            try {
                SqlCommand command = new SqlCommand("SELECT label FROM COURSE  WHERE semester=@semester", this.getConnection);
                command.Parameters.Add("@semester", SqlDbType.Int).Value = semester;
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
        public DataTable gettableCOURSEsemester(int semester)
        {
            try
            {
                SqlCommand command = new SqlCommand("SELECT * FROM COURSE  WHERE semester=@semester", this.getConnection);
                command.Parameters.Add("@semester", SqlDbType.Int).Value = semester;
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
        public DataTable getCOURSEbyStudentId(int id_student)
        {
            try { 
                SqlCommand command = new SqlCommand("SELECT * FROM StudentinCourse Where id_student =@id_student", this.getConnection);
                command.Parameters.Add("@id_student", SqlDbType.Int).Value = id_student;
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
