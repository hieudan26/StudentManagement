using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DTO_StudentManagement
{
    public class DTO_Student
    {
        private int iid;
        private string slname;
        private string sfname;
        private DateTime dbirthdate;
        private string sphone;
        private string saddress;
        private string sgender;
        private  MemoryStream ppicture = new MemoryStream();

        public int id { get => iid; set => iid = value; }
        public string lname { get => slname; set => slname = value; }
        public string fname { get => sfname; set => sfname = value; }
        public DateTime birthdate { get => dbirthdate; set => dbirthdate = value; }
        public string phone { get => sphone; set => sphone = value; }
        public string address { get => saddress; set => saddress = value; }
        public string gender { get => sgender; set => sgender = value; }
        public MemoryStream picture { get => ppicture; set => ppicture = value; }
        public DTO_Student(int id, string lname, string fname, DateTime birthdate, string phone, string address, string gender, MemoryStream picture)
        {
            this.id = id;
            this.lname = lname;
            this.fname = fname;
            this.birthdate = birthdate;
            this.phone = phone;
            this.address = address;
            this.gender = gender;
            this.picture = picture;
        }
        public bool verif()
        {
            if (this.sfname == ""
                || this.slname == ""
                || this.sphone == ""
                || this.saddress == ""
                || this.ppicture == null
                )
            {
                MessageBox.Show("Some field emty !!!");
                return false;
            }
            if (DateTime.Now.Year - this.dbirthdate.Year < 5 || DateTime.Now.Year - this.dbirthdate.Year > 100)
            {
                MessageBox.Show("Invalid birthdate!!!");
                return false;
            }    
                
            return true;
        }
        ~DTO_Student() { }
    }
}
