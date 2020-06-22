using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCIS_Class_Room_Management_System
{
    class course
    {
        public int courseId;
        public string courseName;
        public string subjectName;
        public int userId;
        //private string _courseName;
        //public string courseNameprop
        //{
        //    get { return _courseName; }
        //    set { _courseName = value; courseName = value; }
        //}

        //private string _subjectName;
        //public string subjectNameprop
        //{
        //    get { return _subjectName; }
        //    set { _subjectName = value; courseName = value; }
        //}
        public course(int courseId,string courseName, string subjectName, int userId)
        {
            this.courseName = courseName;
            this.subjectName = subjectName;
            this.courseId = courseId;
            this.userId = userId;
        }
        //public course(string courseName, string subjectName)
        //{
        //    this.courseName = courseName;
        //    this.subjectName = subjectName;
        //}
    }
}
