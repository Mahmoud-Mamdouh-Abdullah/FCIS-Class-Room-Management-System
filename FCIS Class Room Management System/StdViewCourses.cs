using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FCIS_Class_Room_Management_System
{
    public partial class StdViewCourses : Form
    {
        DataBaseModel dataModel;
        user logged_user;
        List<StdCourse> StdCourses;
        int numCourses;
        int enroll;
        public StdViewCourses(List<StdCourse> courses,user user,int type)
        {
            InitializeComponent();
            StdCourses = courses;
            numCourses = StdCourses.Count;
            logged_user = user;
            enroll = type;
        }
        private void StdViewCourses_Load(object sender, EventArgs e)
        {
            view_courses(numCourses,StdCourses);
        }
        private void view_courses(int num, List<StdCourse> courses)
        {
            dataModel = new DataBaseModel();
            if (flowLayoutPanel1.Controls.Count > 0)
                flowLayoutPanel1.Controls.Clear();
            for(int i = 0; i < num; i ++)
            {
                StdCourseLayout CourseLayout = new StdCourseLayout(logged_user);
                CourseLayout.CourseID = courses[i].courseID;
                CourseLayout.CourseName = courses[i].courseName;
                CourseLayout.CourseSub = courses[i].courseSub;
                CourseLayout.InstName = courses[i].instName;
                string check_course = dataModel.CheckEnrollment(courses[i].courseID, logged_user.user_id);
                if (check_course == "1")
                    CourseLayout.enroll = 1;
                else
                    CourseLayout.enroll = 0;
                flowLayoutPanel1.Controls.Add(CourseLayout);
            }
        }
    }
}
