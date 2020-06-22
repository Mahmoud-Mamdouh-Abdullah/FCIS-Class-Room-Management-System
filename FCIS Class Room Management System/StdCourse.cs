using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCIS_Class_Room_Management_System
{
    public class StdCourse
    {
        public int courseID;
        public string courseName;
        public string courseSub;
        public string instName;
        public int instID;

        public StdCourse() { }
        public StdCourse(int courseID, string courseName, string courseSub, string instName, int instID)
        {
            this.courseID = courseID;
            this.courseName = courseName;
            this.courseSub = courseSub;
            this.instName = instName;
            this.instID = instID;
        }
    }
}
