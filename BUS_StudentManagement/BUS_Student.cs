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
    public class BUS_Student
    {
        DAL_Student DALstudent = new DAL_Student();
        public bool insertStudent(DTO_Student student)
        {
            return DALstudent.insertStudent(student);
        }

        public DataTable getStudents(SqlCommand command)
        {
            return  DALstudent.getStudents(command);
        }

        public DataTable getStudentsId(int id)
        {
            return DALstudent.getStudentsId(id);
        }
        public bool verifyStudent(DTO_Student student)
        {
            return DALstudent.verifyStudent(student);
        }

        public bool deleteStudent(int id)
        {
            return DALstudent.deleteStudent(id);
        }

        public bool updateStudent(DTO_Student student)
        {
            return DALstudent.updateStudent(student);
        }

        public DataTable SearchFull(string txt)
        {
            return DALstudent.SearchFull(txt);
        }
        public DataTable getAllStudent()
        {
            return DALstudent.getAllStudent();
        }
        public int totalStudent()
        {
            return DALstudent.totalStudent();
        }

        public int totalMaleStudent()
        {
            return DALstudent.totalMaleStudent();
        }

        public int totalFemaleStudent()
        {
            return DALstudent.totalFemaleStudent();
        }

        public DataTable FilterStudent(bool YesBtn, bool MaleBtn, bool FeMaleBtn, DateTime dateBeforeDate, DateTime dateAfterDay)
        {
            return DALstudent.FilterStudent(YesBtn, MaleBtn,FeMaleBtn, dateBeforeDate, dateAfterDay);
        }
        public DataTable getAllIfnoStudent()
        {
            return DALstudent.getAllStudent();
        }
    }
}
