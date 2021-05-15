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
        public DataTable getCOURSELabel(string label, int semeste)
        {
            return DALcourse.getCOURSELabel(label, semeste);
        }
        public bool deleteSCOURSE(int id)
        {
            return DALcourse.deleteSCOURSE(id);
        }
        public bool updateCOURSE(DTO_Course course)
        {
            return DALcourse.updateCOURSE(course);
        }
        public DataTable getCOURSEsemester(int semester)
        {
            return DALcourse.getCOURSEsemester(semester);
        }
        public DataTable getCOURSELabelStudent(int id_course, int semester)
        {
            
            return DALcourse.getCOURSELabelStudent(id_course, semester);
        }
        public DataTable getCOURSEEmpty(int semester)
        {

            return DALcourse.getCOURSEEmpty(semester);
        }
        public DataTable gettableCOURSEsemester(int semester)
        {

            return DALcourse.gettableCOURSEsemester(semester);
        }
        public DataTable getCOURSEEmptyGroup(int semester, int id_group)
        {
                return DALcourse.getCOURSEEmptyGroup(semester, id_group);
        }
    }
}
