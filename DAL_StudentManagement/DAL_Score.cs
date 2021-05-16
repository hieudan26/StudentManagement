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
   
    public class DAL_Score : myDB
    {
        public bool insertSCORE(DTO_Score score)
        {
            try { 
                SqlCommand command = new SqlCommand("INSERT INTO Score ( student_id, course_id, student_score ,description)" +
                 "VALUES ( @student_id, @course_id, @student_score, @description)", this.getConnection);
                command.Parameters.Add("@student_id", SqlDbType.Int).Value = score.idStudent;
                command.Parameters.Add("@course_id", SqlDbType.Int).Value = score.idCourse;
                command.Parameters.Add("@student_score", SqlDbType.Float).Value = score.Score;
                command.Parameters.Add("@description", SqlDbType.VarChar).Value = score.desciption;
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public DataTable getSCORE()
        {
            try { 
                    SqlCommand command = new SqlCommand("SELECT * from Score", this.getConnection);
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
        public DataTable getSCOREAStudent(int idStudent,int idCourse)
        {
            try { SqlCommand command = new SqlCommand("SELECT * FROM Score WHERE student_id = @student_id AND course_id = @course_id", this.getConnection);
            command.Parameters.Add("@student_id", SqlDbType.Int).Value = idStudent;
            command.Parameters.Add("@course_id", SqlDbType.Int).Value = idCourse;
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
        public DataTable getSCOREAStudent(int idStudent, string idCourse)
        {
            try { 
                 SqlCommand command = new SqlCommand("Select * from Score where student_id = @student_id AND course_id=@course_id", this.getConnection);
                command.Parameters.Add("@student_id", SqlDbType.Int).Value = idStudent;
                command.Parameters.Add("@course_id", SqlDbType.Int).Value = idCourse;
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
        public DataTable getSCOREbyIDStudent(int idStudent)
        {
            try { 
                SqlCommand command = new SqlCommand("SELECT * FROM Score WHERE student_id = @student_id", this.getConnection);
                command.Parameters.Add("@student_id", SqlDbType.Int).Value = idStudent;
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
        public DataTable getSCOREbyIDCourse(int idCourse)
        {
            try { 
                SqlCommand command = new SqlCommand("SELECT * FROM Score WHERE course_id = @course_id", this.getConnection);
                command.Parameters.Add("@course_id", SqlDbType.Int).Value = idCourse;
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
        public DataTable getSCOREbyListStudentCourse(int idCourse)
        {
            try
            {
                SqlCommand command = new SqlCommand("SELECT DISTINCT ROW_NUMBER() OVER (ORDER BY id) AS [STT],student_id as [ID], fname as [First Name], lname as [Last Name],bdate as DoB,Score.student_score as Score  FROM Score inner join std on  Score.student_id = std.id WHERE course_id = @course_id", this.getConnection);
                command.Parameters.Add("@course_id", SqlDbType.Int).Value = idCourse;
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
        public bool deleteScore(int idStudent, int idCourse)
        {
            try { SqlCommand command = new SqlCommand("DELETE FROM Score WHERE student_id = @student_id AND course_id = @course_id", this.getConnection);
            command.Parameters.Add("@student_id", SqlDbType.Int).Value = idStudent;
            command.Parameters.Add("@course_id", SqlDbType.Int).Value = idCourse;
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
        public bool updateCOURSE(DTO_Score score)
        {
            try { SqlCommand command = new SqlCommand("UPDATE Score SET student_score =@student_score ,description = @description WHERE  student_id = @student_id and course_id = @course_id", this.getConnection);
            command.Parameters.Add("@student_id", SqlDbType.Int).Value = score.idStudent;
            command.Parameters.Add("@course_id", SqlDbType.Int).Value = score.idCourse;
            command.Parameters.Add("@student_score", SqlDbType.Float).Value = score.Score;
            command.Parameters.Add("@description", SqlDbType.VarChar).Value = score.desciption;
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

        public DataTable getAVGCourse()
        {
            try { SqlCommand command = new SqlCommand("SELECT COURSE.label, AVG(Score.student_score) as avgScore FROM Score inner join COURSE on Score.course_id = COURSE.Id " +
                "GROUP BY COURSE.label", this.getConnection);
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
        public DataTable getSCOREAVGStudent()
        {
            try { 
                SqlCommand command = new SqlCommand("Select std.id,fname,lname, avg(student_score) as avg from std, score where score.student_id = std.Id Group by std.id,fname,lname", this.getConnection);
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
        public DataTable getSearchFull (string s)
        {
            try { 
                SqlCommand command = new SqlCommand("Select std.id,fname,lname, avg(student_score) as avg from std, score where score.student_id = std.Id Group by std.id,fname,lname", this.getConnection);
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
            try { 
                 SqlCommand command = new SqlCommand("Select std.id,fname,lname, avg(student_score) as avg from std, score where score.student_id = std.Id and  CONCAT(fname,lname) LIKE '%" + text + "%' Group by std.id,fname,lname");
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
    }
}
