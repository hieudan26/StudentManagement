using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_StudentManagement
{
    public class DTO_Score
    {
        private int iidStudent;
        private int iidCourse;
        private float iScore;
        private string sdesciption;
        public DTO_Score()
        {
        }

        public DTO_Score(  int iidStudent, int iidCourse, float iScore,string desciption)
        {
            this.iidCourse = iidCourse;
            this.iidStudent = iidStudent;
            this.iScore = iScore;
            this.sdesciption = desciption;
        }
        
        public int idCourse { get => iidCourse; set => iidCourse = value; }
        public int idStudent { get => iidStudent; set => iidStudent = value; }
        public float Score { get => iScore; set => iScore = value; }
        public string desciption { get => sdesciption; set => sdesciption = value; }


        public bool verif()
        {
            if (this.idCourse.ToString() == "" || this.idStudent.ToString() == "" || iScore < 0 || iScore > 10)
                return false;
            return true;
        }
    }
}
