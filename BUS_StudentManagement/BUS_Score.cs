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
    public class BUS_Score
    {
        DAL_Score scoreDAL = new DAL_Score();
        public bool insertSCORE(DTO_Score score)
        {
            return scoreDAL.insertSCORE(score);
        }
        public DataTable getSCORE()
        {
            return scoreDAL.getSCORE();
        }
        public DataTable getSCOREAStudent(int idStudent, int idCourse)
        {
            return scoreDAL.getSCOREAStudent(idStudent, idCourse);
        }
        public DataTable getSCOREbyIDStudent(int idStudent)
        {
            return scoreDAL.getSCOREbyIDStudent(idStudent);
        }
        public DataTable getSCOREbyIDCourse(int idCourse)
        {
            return getSCOREbyIDCourse(idCourse);
        }
        public bool deleteScore(int idStudent, int idCourse)
        {
            return scoreDAL.deleteScore(idStudent, idCourse);
        }
        public bool updateCOURSE(DTO_Score score)
        {
            return scoreDAL.updateCOURSE(score);
        }
        public DataTable getAVGCourse()
        {
            return scoreDAL.getAVGCourse();
        }
    }
}
