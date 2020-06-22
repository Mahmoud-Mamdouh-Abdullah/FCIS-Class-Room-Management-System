using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FCIS_Class_Room_Management_System
{
    public partial class StdCourseLayout : UserControl
    {
        user logged_user;
        DataBaseModel classRoom;
        public StdCourseLayout(user user)
        {
            InitializeComponent();
            logged_user = user;
        }
        #region ImportantInit
        private int _CourseID;
        private string _CourseName;
        private string _CouseSub;
        private string _InstName;
        private int _enroll;

        public int enroll
        {
            get { return _enroll; }
            set
            {
                _enroll = value;
                if (value == 1)
                {
                    enroll_btn.Text = "Unenroll";
                    report.Visible = true;
                }
                else if (value == 0)
                    enroll_btn.Text = "Enroll";
            }
        }
        public int CourseID
        {
            get { return _CourseID; }
            set { _CourseID = value; Course_ID.Text = value.ToString();}
        }
        public string CourseName
        {
            get { return _CourseName; }
            set { _CourseName = value; course_name.Text = value; }
        }
        public string CourseSub
        {
            get { return _CouseSub; }
            set { _CouseSub = value; sub_name.Text = value; }
        }
        public string InstName
        {
            get { return _InstName; }
            set { _InstName = value; inst_name.Text = value; }
        }
        #endregion
        private void StdCourseLayout_Load(object sender, EventArgs e)
        {

        }

        private void show_res_Click(object sender, EventArgs e)
        {
            if (enroll_btn.Text == "Unenroll")
            {
                int course_id = Convert.ToInt32(Course_ID.Text);
                StdViewRes ViewRes = new StdViewRes(course_id);
                ViewRes.ShowDialog();
            }
            else
            {
                MessageBox.Show("We are Sorry, you Should have Enroll in this Course First to Show the Resources.", "Attention Please", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void enroll_Click(object sender, EventArgs e)
        {
            if (enroll_btn.Text == "Enroll")
                enroll_process();
            else
                unenroll_process();
        }
        private void enroll_process()
        {
            classRoom = new DataBaseModel();
            int course_id = Convert.ToInt32(Course_ID.Text);
            int ans = classRoom.enroll(logged_user.user_id, course_id);
            if (ans == 1)
            {
                MessageBox.Show("you are Now Enrolled in this Course Successfully", "Enrollment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                enroll_btn.Text = "Unenroll";
                report.Visible = true;
            }
            else
                MessageBox.Show("Something Wrong was Happened,try again :(", "Enrollment", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void unenroll_process()
        {
            classRoom = new DataBaseModel();
            int course_id = Convert.ToInt32(Course_ID.Text);
            int ans = classRoom.unenroll(logged_user.user_id, course_id);
            if (ans == 1)
            {
                MessageBox.Show("you are Now Unenrolled in this Course Successfully", "Unenrollment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                enroll_btn.Text = "Enroll";
                report.Visible = false;
            }
            else
                MessageBox.Show("Something Wrong was Happened,try again :(", "Unenrollment", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void report_Click(object sender, EventArgs e)
        {
            Report1Form report = new Report1Form(Course_ID.Text);
            report.Show();
            
        }
        
    }
}
