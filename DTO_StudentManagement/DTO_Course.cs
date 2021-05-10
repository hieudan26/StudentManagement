﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DTO_StudentManagement
{
    public class DTO_Course
    {
        private string slabel;
        private int iperiod;
        private string sdescription;
        private int iSemester;
        public string label { get => slabel; set => slabel = value; }
        public int period { get => iperiod; set => iperiod = value; }
        public string description { get => sdescription; set => sdescription = value; }
        public int Semester { get => iSemester; set => iSemester = value; }

        public DTO_Course(string label, int period, string description,int semester)
        {
            this.slabel = label;
            this.iperiod = period;
            this.sdescription = description;
            this.iSemester = semester;
        }
        public bool verif()
        {
            if (this.label == "" || this.period.ToString() == "" || this.description == "")
            {
                MessageBox.Show("Add error", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (this.period < 10)
            {
                MessageBox.Show("Period is too short", "Add COURSE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (this.Semester < 0 ||Semester > 3)
            {
                MessageBox.Show("Period is too short", "Add COURSE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

    }
}
