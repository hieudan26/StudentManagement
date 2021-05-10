using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DTO_StudentManagement
{
    public static class DTO_Global
    {
        public static int GlobalUserId { get; private set; }

        public static void SetGlabelUserId(int userID)
        {
            GlobalUserId = userID;
        }
    }
}
