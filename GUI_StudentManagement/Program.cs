using GUI_StudentManagement.Course;
using GUI_StudentManagement.Score;
using GUI_StudentManagement.Student;
using Login_form;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_StudentManagement
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ManageCourseForm());
        }
    }
}
