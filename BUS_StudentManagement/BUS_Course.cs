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

    public class BUS_Course
    {
        DAL_Course DALcourse = new DAL_Course();
        public bool insertCOURSE(DTO_Course course)
        {
            return DALcourse.insertCOURSE(course);
        }
        public DataTable getCOURSE()
        {
            return DALcourse.getCOURSE();
        }
        public DataTable getCOURSEId(int id)
        {
            return DALcourse.getCOURSEId(id);
        }
        public DataTable getCOURSELabel(string label)
        {
            return DALcourse.getCOURSELabel(label);
        }
        public bool deleteSCOURSE(int id)
        {
            return DALcourse.deleteSCOURSE(id);
        }
        public bool updateCOURSE(DTO_Course course,int id)
        {
            return DALcourse.updateCOURSE(course, id);
        }
        public DataTable getCOURSELabeInsemester(int id_course, int semester)
        {
            return DALcourse.getCOURSELabeInsemester(id_course,semester);
        }
        public DataTable getCOURSEsemester(int semester)
        {
            return DALcourse.getCOURSEsemester(semester);
        }
        public DataTable getCOURSELabelStudent(int id_course, int semester)
        {
            
            return DALcourse.getCOURSELabelStudent(id_course, semester);
        }
    }
}
